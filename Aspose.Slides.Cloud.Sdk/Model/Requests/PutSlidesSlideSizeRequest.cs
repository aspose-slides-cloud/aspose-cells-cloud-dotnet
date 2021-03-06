// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesSlideSizeRequest.cs">
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

using System.Collections.Generic;
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Model.Requests 
{
  /// <summary>
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.SlidesApi.PutSlidesSlideSize" /> operation.
  /// </summary>  
  public class PutSlidesSlideSizeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSlideSizeRequest"/> class.
        /// </summary>        
        public PutSlidesSlideSizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesSlideSizeRequest"/> class.
        /// </summary>
        /// <param name="name">Document name.</param>
        /// <param name="password">Document password.</param>
        /// <param name="storage">Document storage.</param>
        /// <param name="folder">Document folder.</param>
        /// <param name="width">Slide width.</param>
        /// <param name="height">Slide height.</param>
        /// <param name="sizeType">Standard slide size type.</param>
        /// <param name="scaleType">Standard slide scale type.</param>
        public PutSlidesSlideSizeRequest(string name, string password = null, string storage = null, string folder = null, int? width = null, int? height = null, SizeType? sizeType = null, ScaleType? scaleType = null)
        {
            this.Name = name;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
            this.Width = width;
            this.Height = height;
            this.SizeType = sizeType;
            this.ScaleType = scaleType;
        }

        /// <summary>
        /// Document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Document password.
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Slide width.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Slide height.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Standard slide size type.
        /// </summary>  
        public SizeType? SizeType { get; set; }

        /// <summary>
        /// Standard slide scale type.
        /// </summary>  
        public ScaleType? ScaleType { get; set; }
  }
}
