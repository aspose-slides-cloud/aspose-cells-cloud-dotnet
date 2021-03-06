// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ShapeTests.cs">
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

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;
using Aspose.Slides.Cloud.Sdk.Tests.Utils;
using NUnit.Framework;
using System.Collections.Generic;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing Timeout config parameter
    /// </summary>
    [TestFixture]
    public class ShapeTests
    {
        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public void ShapeAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Shape { ShapeType = GeometryShape.ShapeTypeEnum.Callout1 }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<Shape>(shape);
        }

        [Test]
        public void ShapeEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Shape()
            }; //Cannot create shape with no ShapeType specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void GraphicalObjectEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new GraphicalObject()
            }; //Cannot create a graphical object
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void PictureFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new PictureFrame
                {
                    PictureFillFormat = new PictureFill
                    {
                        Base64Data = "iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAYAAAAfFcSJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsQAAA7EAZUrDhsAAAANSURBVBhXY5g+ffp/AAZTAsWGL27gAAAAAElFTkSuQmCC"
                    }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<PictureFrame>(shape);
        }

        [Test]
        public void PictureFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new PictureFrame()
            }; //Cannot create picture with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void AudioFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new AudioFrame { Base64Data = "bXAzc2FtcGxl" }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<AudioFrame>(shape);
        }

        [Test]
        public void AudioFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new AudioFrame()
            }; //Cannot create audio with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void VideoFrameAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new VideoFrame { Base64Data = "bXAzc2FtcGxl" }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<VideoFrame>(shape);
        }

        [Test]
        public void VideoFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new VideoFrame()
            }; //Cannot create video with no data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void OleObjectFrameEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new OleObjectFrame()
            }; //Cannot create an OleObjectFrame
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void SmartArtAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new SmartArt
                {
                    X = 0,
                    Y = 0,
                    Width = 300,
                    Height = 200,
                    Layout = SmartArt.LayoutEnum.BasicProcess,
                    QuickStyle = SmartArt.QuickStyleEnum.SimpleFill,
                    ColorStyle = SmartArt.ColorStyleEnum.ColoredFillAccent1,
                    Nodes = new List<SmartArtNode>
                    {
                        new SmartArtNode
                        {
                            Text = "First",
                            OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial,
                            Nodes = new List<SmartArtNode>
                            {
                                new SmartArtNode { Text = "SubFirst", OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial }
                            }
                        },
                        new SmartArtNode { Text = "Second", OrgChartLayout = SmartArtNode.OrgChartLayoutEnum.Initial }
                    }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<SmartArt>(shape);
        }

        [Test]
        public void SmartArtEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new SmartArt()
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<SmartArt>(shape);
        }

        [Test] //See ChartTests for non-empty chart examples
        public void ChartEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Chart()
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<Chart>(shape);
        }

        [Test]
        public void TableAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Table
                {
                    X = 30,
                    Y = 20,
                    Style = Table.StyleEnum.MediumStyle2Accent1,
                    Rows = new List<TableRow>
                    {
                        new TableRow
                        {
                            Cells = new List<TableCell>
                            {
                                new TableCell { Text = "0.1" },
                                new TableCell { Text = "0.2" },
                                new TableCell { Text = "0.3" },
                                new TableCell { Text = "0.4" }
                            }
                        },
                        new TableRow
                        {
                            MinimalHeight = 60,
                            Cells = new List<TableCell>
                            {
                                new TableCell { Text = "1" },
                                new TableCell { Text = "2-3", ColSpan = 2, RowSpan = 2 },
                                new TableCell { Text = "4" }
                            }
                        },
                        new TableRow { Cells = new List<TableCell> { new TableCell { Text = "first" }, new TableCell { Text = "last" } } },
                        new TableRow
                        {
                            Cells = new List<TableCell>
                            {
                                new TableCell { Text = "3.1" },
                                new TableCell { Text = "3.2" },
                                new TableCell { Text = "3.3" },
                                new TableCell { Text = "3.4" }
                            }
                        },
                        new TableRow
                        {
                            Cells = new List<TableCell>
                            {
                                new TableCell { Text = "4.1" },
                                new TableCell { Text = "4.2" },
                                new TableCell { Text = "4.3" },
                                new TableCell { Text = "4.4" }
                            }
                        }
                    },
                                Columns = new List<TableColumn>
                    {
                        new TableColumn { Width = 100 },
                        new TableColumn { Width = 100 },
                        new TableColumn { Width = 100 },
                        new TableColumn { Width = 100 }
                    },
                    FirstRow = true,
                    HorizontalBanding = true
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<Table>(shape);
        }

        [Test]
        public void TableEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Table()
            }; //Cannot create table with no cell data specified
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void GroupShapeEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new GroupShape()
            }; //Cannot create a group shape
            Assert.Throws<ApiException>(() => TestUtils.SlidesApi.PostAddNewShape(request));
        }

        [Test]
        public void ConnectorAdd()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Connector
                {
                    ShapeType = GeometryShape.ShapeTypeEnum.BentConnector3,
                    StartShapeConnectedTo = new ResourceUri { Href = "https://api.aspose.cloud/v3.0/slides/myPresentation.pptx/slides/1/shapes/1" },
                    EndShapeConnectedTo = new ResourceUri { Href = "https://api.aspose.cloud/v3.0/slides/myPresentation.pptx/slides/1/shapes/2" }
                }
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<Connector>(shape);
        }

        [Test]
        public void ConnectorEmpty()
        {
            TestUtils.Upload(c_fileName, c_folderName + "/" + c_fileName);
            PostAddNewShapeRequest request = new PostAddNewShapeRequest
            {
                Name = c_fileName,
                Folder = c_folderName,
                Password = c_password,
                SlideIndex = c_slideIndex,
                Dto = new Connector()
            };
            ShapeBase shape = TestUtils.SlidesApi.PostAddNewShape(request);
            Assert.IsInstanceOf<Connector>(shape);
        }

        const string c_folderName = "TempSlidesSDK";
        const string c_fileName = "test.pptx";
        const string c_password = "password";
        const int c_slideIndex = 3;
    }
}
