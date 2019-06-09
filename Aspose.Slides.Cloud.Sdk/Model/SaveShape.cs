// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveShape.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
  /// <summary>
  /// Save shape task.
  /// </summary>  
  public class SaveShape : Task 
  {                       
        /// <summary>
        /// Format.
        /// </summary>
        /// <value>Format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            
            /// <summary>
            /// Enum Jpeg for "Jpeg"
            /// </summary>
            Jpeg,
            
            /// <summary>
            /// Enum Png for "Png"
            /// </summary>
            Png,
            
            /// <summary>
            /// Enum Gif for "Gif"
            /// </summary>
            Gif,
            
            /// <summary>
            /// Enum Bmp for "Bmp"
            /// </summary>
            Bmp,
            
            /// <summary>
            /// Enum Tiff for "Tiff"
            /// </summary>
            Tiff,
            
            /// <summary>
            /// Enum Svg for "Svg"
            /// </summary>
            Svg
        }

        /// <summary>
        /// Format.
        /// </summary>
        public FormatEnum? Format { get; set; }

        /// <summary>
        /// Shape path.
        /// </summary>
        public string ShapePath { get; set; }

        /// <summary>
        /// Output file.
        /// </summary>
        public OutputFile Output { get; set; }

        /// <summary>
        /// Save options.
        /// </summary>
        public IShapeExportOptions Options { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public SaveShape() : base()
        {
          Type = TypeEnum.SaveShape;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveShape {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  ShapePath: ").Append(this.ShapePath).Append("\n");
          sb.Append("  Output: ").Append(this.Output).Append("\n");
          sb.Append("  Options: ").Append(this.Options).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
