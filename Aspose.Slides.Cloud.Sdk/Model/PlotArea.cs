// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PlotArea.cs">
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
    /// Represents the plot area
    /// </summary>  
    public class PlotArea 
    {                       
        /// <summary>
        /// If layout of the plot area is defined manually specifies whether to layout the plot area by its inside (not including axis and axis labels) or outside.
        /// </summary>
        /// <value>If layout of the plot area is defined manually specifies whether to layout the plot area by its inside (not including axis and axis labels) or outside.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LayoutTargetTypeEnum
        {
            
            /// <summary>
            /// Enum Inner for "Inner"
            /// </summary>
            Inner,
            
            /// <summary>
            /// Enum Outer for "Outer"
            /// </summary>
            Outer
        }

        /// <summary>
        /// If layout of the plot area is defined manually specifies whether to layout the plot area by its inside (not including axis and axis labels) or outside.
        /// </summary>
        public LayoutTargetTypeEnum? LayoutTargetType { get; set; }

        /// <summary>
        /// the X location
        /// </summary>
        public double? X { get; set; }

        /// <summary>
        /// the Y location
        /// </summary>
        public double? Y { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        public double? Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Get or sets the fill format.
        /// </summary>
        public FillFormat FillFormat { get; set; }

        /// <summary>
        /// Get or sets the effect format.
        /// </summary>
        public EffectFormat EffectFormat { get; set; }

        /// <summary>
        /// Get or sets the line format.
        /// </summary>
        public LineFormat LineFormat { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public PlotArea() : base()
        {
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PlotArea {\n");
            sb.Append("  X: ").Append(this.X).Append("\n");
            sb.Append("  Y: ").Append(this.Y).Append("\n");
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  LayoutTargetType: ").Append(this.LayoutTargetType).Append("\n");
            sb.Append("  FillFormat: ").Append(this.FillFormat).Append("\n");
            sb.Append("  EffectFormat: ").Append(this.EffectFormat).Append("\n");
            sb.Append("  LineFormat: ").Append(this.LineFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
