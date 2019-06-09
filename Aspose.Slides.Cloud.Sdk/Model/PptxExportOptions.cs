// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PptxExportOptions.cs">
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
  /// 
  /// </summary>  
  public class PptxExportOptions : ExportOptions 
  {                       
        /// <summary>
        /// The conformance class to which the PresentationML document conforms. Read/write Conformance.
        /// </summary>
        /// <value>The conformance class to which the PresentationML document conforms. Read/write Conformance.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConformanceEnum
        {
            
            /// <summary>
            /// Enum Ecma3762006 for "Ecma376_2006"
            /// </summary>
            Ecma3762006,
            
            /// <summary>
            /// Enum Iso295002008Transitional for "Iso29500_2008_Transitional"
            /// </summary>
            Iso295002008Transitional,
            
            /// <summary>
            /// Enum Iso295002008Strict for "Iso29500_2008_Strict"
            /// </summary>
            Iso295002008Strict
        }

        /// <summary>
        /// The conformance class to which the PresentationML document conforms. Read/write Conformance.
        /// </summary>
        public ConformanceEnum? Conformance { get; set; }

        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public PptxExportOptions() : base()
        {
          Format = "pptx";
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PptxExportOptions {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  Conformance: ").Append(this.Conformance).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
