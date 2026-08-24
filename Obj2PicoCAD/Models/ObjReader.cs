using Obj2PicoCAD.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Obj2PicoCAD.Models
{
    internal class ObjReader
    {
        public Vector3 Pos { get; set; } = new Vector3(0, 0, 0);
        public Vector3 Rot { get; set; } = new Vector3(0, 0, 0);

        public int AlphaColorIndex { get; set; } = 0;
        public int BgColorIndex { get; set; } = 0;
        public float Zoom { get; set; } = 16;

        private int _meshMode = 10;

        public void ObjToPicoCAD(string path, string exportPath, float size0, int meshMode)
        {
            float maxX = -20000, minX = 20000, maxY = -20000, minY = 20000, maxZ = -20000, minZ = 20000;

            var v = new List<Vector3>();
            var f = new List<List<int>>();

            _meshMode = meshMode;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    ReadObj(sr, v, f, ref maxX, ref minX, ref maxY, ref minY, ref maxZ, ref minZ);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File read error: {ex.Message}");
                return;
            }

            // Calculate uniform scaling factor
            float boundingMax = Math.Max(Math.Max(Math.Abs(maxX - minX), Math.Abs(maxY - minY)), Math.Abs(maxZ - minZ));
            float size = boundingMax == 0 ? size0 : size0 / boundingMax;

            WriteToTxt(exportPath, size, v, f);
        }

        private void ReadObj(StreamReader sr, List<Vector3> v, List<List<int>> f, ref float maxX, ref float minX, ref float maxY,
            ref float minY, ref float maxZ, ref float minZ)
        {
            while (sr.Peek() >= 0)
            {
                var line = sr.ReadLine() ?? string.Empty;

                if (line.StartsWith("v "))
                {
                    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 4)
                    {
                        if (float.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out float v1) &&
                            float.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out float v2) &&
                            float.TryParse(parts[3], NumberStyles.Float, CultureInfo.InvariantCulture, out float v3))
                        {
                            v.Add(new Vector3(v1, v2, v3));
                            Utilities.MaxMin(new Vector3(v1, v2, v3), ref maxX, ref minX, ref maxY, ref minY, ref maxZ, ref minZ);
                        }
                    }
                }
                else if (line.StartsWith("f "))
                {
                    var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var f0 = new List<int>();
                    for (int i = 1; i < parts.Length; i++)
                    {
                        var components = parts[i].Split('/');

                        if (components.Length >= 1)
                        {
                            if (int.TryParse(components[0], out int index))
                            {
                                f0.Add(index);
                            }
                        }
                    }
                    if (f0.Count > 0)
                    {
                        f.Add(f0);
                    }
                }
            }
        }

        private void WriteToTxt(string exportFilePath, float size, List<Vector3> v, List<List<int>> f)
        {
            var filename = Path.GetFileNameWithoutExtension(exportFilePath);

            if (!exportFilePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
            {
                exportFilePath += ".txt";
            }

            StringBuilder sb = new StringBuilder();

            // 1. Metadata Header
            sb.AppendLine("{");
            sb.AppendLine("  \"metadata\": {");
            sb.AppendLine("    \"version\": \"2.0\",");
            sb.AppendLine("    \"motion_duration\": 8,");
            sb.AppendLine("    \"shading_mode\": 0,");
            sb.AppendLine("    \"face_mode\": 2,");
            sb.AppendLine("    \"camera\": {");
            sb.AppendLine("      \"pos\": { \"x\": 3.56, \"y\": 4.13, \"z\": -0.95 },");
            sb.AppendLine("      \"distance_to_target\": 2.97,");
            sb.AppendLine("      \"omega\": -0.15,");
            sb.AppendLine("      \"theta\": 0.17,");
            sb.AppendLine("      \"target\": { \"x\": 0.66, \"y\": 3.62, \"z\": -0.51 },");
            sb.AppendLine("      \"bookmark\": {");
            sb.AppendLine("        \"distance_to_target\": 10, \"omega\": 0.3, \"theta\": 0.5,");
            sb.AppendLine("        \"target\": { \"x\": 0, \"y\": 0, \"z\": 0 },");
            sb.AppendLine("        \"pos\": { \"x\": 0, \"y\": 0, \"z\": 0 }");
            sb.AppendLine("      }");
            sb.AppendLine("    },");
            sb.AppendLine("    \"export_settings\": {");
            sb.AppendLine("      \"watermark2\": \"\", \"anim\": \"spin\", \"watermark\": \"#picoCAD2\",");
            sb.AppendLine("      \"dir\": -1, \"scanlines\": false, \"outline_color\": 0,");
            sb.AppendLine("      \"size\": 128, \"scale\": 3, \"outline_size\": 0,");
            sb.AppendLine("      \"scanline_color\": 0, \"speed\": 5");
            sb.AppendLine("    }");
            sb.AppendLine("  },");

            // 2. Graph & Mesh Setup
            sb.AppendLine("  \"graph\": {");
            sb.AppendLine("    \"name\": \"root\",");
            sb.AppendLine("    \"transform\": {");
            sb.AppendLine("      \"scale\": { \"x\": 1, \"y\": 1, \"z\": 1 },");
            sb.AppendLine("      \"pos\": { \"x\": 0, \"y\": 0, \"z\": 0 },");
            sb.AppendLine("      \"rot\": { \"x\": 0, \"y\": 0, \"z\": 0 }");
            sb.AppendLine("    },");
            sb.AppendLine("    \"children\": [{");
            sb.AppendLine($"      \"name\": \"{filename}\",");
            sb.AppendLine("      \"transform\": {");
            sb.AppendLine("        \"scale\": { \"x\": 1, \"y\": 1, \"z\": 1 },");
            sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "        \"pos\": {{ \"x\": {0:0.###}, \"y\": {1:0.###}, \"z\": {2:0.###} }},", Pos.x, Pos.y, Pos.z));
            sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "        \"rot\": {{ \"x\": {0:0.###}, \"y\": {1:0.###}, \"z\": {2:0.###} }}", Rot.x, Rot.y, Rot.z));
            sb.AppendLine("      },");
            sb.AppendLine("      \"children\": [], \"open\": false,");
            sb.AppendLine("      \"motions\": { \"tracks\": [[], [], [], []] },");
            sb.AppendLine("      \"visible\": true, \"locked\": false,");

            // 3. Vertices & Faces
            sb.AppendLine("      \"mesh\": {");
            sb.Append("        \"vertices\": [");
            for (int i = 0; i < v.Count; i++)
            {
                float vx = v[i].x * size;
                float vy = v[i].y * size;
                float vz = v[i].z * size;

                sb.Append(string.Format(CultureInfo.InvariantCulture, "{0:0.###},{1:0.###},{2:0.###}", vx, vy, vz));
                if (i + 1 < v.Count) sb.Append(",");
            }
            sb.AppendLine("],");

            sb.AppendLine($"        \"name\": \"{filename}\",");
            sb.AppendLine("        \"faces\": [");

            for (int i = 0; i < f.Count; i++)
            {
                sb.AppendLine("          {");
                sb.Append("            \"vertex_ids\": [");

                List<int> faceIndices = f[i];
                for (int j = 0; j < faceIndices.Count; j++)
                {
                    int idx = (_meshMode == 0) ? faceIndices[j] : faceIndices[faceIndices.Count - 1 - j];
                    sb.Append(idx);
                    if (j + 1 < faceIndices.Count) sb.Append(",");
                }
                sb.AppendLine("],");

                sb.Append("            \"uvs\": [");
                for (int j = 0; j < faceIndices.Count; j++)
                {
                    List<float> d = Utilities.En(faceIndices.Count, j, 1);
                    sb.Append(string.Format(CultureInfo.InvariantCulture, "{0:0.###},{1:0.###}", d[0], d[1]));
                    if (j + 1 < faceIndices.Count) sb.Append(",");
                }
                sb.AppendLine("],");

                sb.AppendLine("            \"color\": 2");
                sb.Append("          }");
                if (i + 1 < f.Count) sb.AppendLine(",");
                else sb.AppendLine();
            }

            sb.AppendLine("        ]");
            sb.AppendLine("      }");
            sb.AppendLine("    }],");
            sb.AppendLine("    \"open\": false,");
            sb.AppendLine("    \"motions\": { \"tracks\": [[], [], [], []] },");
            sb.AppendLine("    \"visible\": true, \"locked\": false");
            sb.AppendLine("  },");

            // 4. Clean Single-line Texture Payload
            sb.AppendLine("  \"texture\": {");
            sb.AppendLine("    \"shade_pal_1\": [0,1,2,3,2,5,3,2,8,4,4,5,6,6,10,12],");
            sb.AppendLine($"    \"background_color\": {BgColorIndex},");
            sb.AppendLine("    \"colors\": [[0,0,0],[0.11372549019608,0.16862745098039,0.32549019607843],[0.49411764705882,0.14509803921569,0.32549019607843],[0.37254901960784,0.34117647058824,0.30980392156863],[0.67058823529412,0.32156862745098,0.21176470588235],[0,0.52941176470588,0.31764705882353],[0.51372549019608,0.46274509803922,0.61176470588235],[1,0,0.30196078431373],[0.16078431372549,0.67843137254902,1],[1,0.46666666666667,0.65882352941176],[1,0.63921568627451,0],[0,0.89411764705882,0.21176470588235],[0.76078431372549,0.76470588235294,0.78039215686275],[1,0.8,0.66666666666667],[1,0.92549019607843,0.15294117647059],[1,0.94509803921569,0.90980392156863]],");

            // Exactly 16,384 hex characters on a single string, representing a 128x128 grid:
            string defaultPixels = new string('c', 16384);
            sb.AppendLine($"    \"pixels\": \"{defaultPixels}\",");

            sb.AppendLine("    \"transparent_color\": 0,");
            sb.AppendLine("    \"shade_pal_2\": [0,31,1,1,1,1,1,1,5,2,2,1,3,3,4,6]");
            sb.AppendLine("  }");
            sb.AppendLine("}");

            File.WriteAllText(exportFilePath, sb.ToString(), Encoding.UTF8);
        }
    }
}