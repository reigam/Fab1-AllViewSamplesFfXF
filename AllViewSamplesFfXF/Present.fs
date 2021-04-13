// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SamplePresent =
    let samplePresent (style: MyStyle) = [
        {   Name = "BoxView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="BoxView",                         
                    content = 
                        View.BoxView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                color = Color.Black
                            )
                )
        }
        {   Name = "Image";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Image",                         
                    content = 
                        View.Image
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                source = Image.ImagePath "icon.png"
                            )
                )
        }
        {   Name = "Label";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Label",                         
                    content = 
                        View.Label
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                padding = style.Padding,
                                text = "Label"
                            )
                )
        }
        //{   Name = "Map";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Map",                         
        //            content = 
        //                View.Map
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Map"
        //                    )
        //        )
        //}
        {   Name = "Ellipse";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Ellipse",                         
                    content = 
                        View.Ellipse
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                fill = View.SolidColorBrush(Color.Black),
                                width = 50.,
                                height = 50.
                            )
                )
        }
        {   Name = "Line";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Line",                         
                    content = 
                        View.Line
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                stroke = View.SolidColorBrush(Color.Black),
                                x1 = 40., 
                                y1 = 0., 
                                x2 = 0., 
                                y2 = 120.
                            )
                )
        }
        {   Name = "Path";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Path",                         
                    content = 
                        View.Path
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,                                
                                stroke = View.SolidColorBrush(Color.Black),
                                data = Content.fromString "M 10,100 C 100,0 200,200 300,100"
                            )
                )
        }
        //{   Name = "Sample2";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample2",                         
        //            content = 
        //                View.Sample2
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample2"
        //                    )
        //        )
        //}
        //{   Name = "Sample2";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample2",                         
        //            content = 
        //                View.Sample2
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample2"
        //                    )
        //        )
        //}
        //{   Name = "Sample2";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample2",                         
        //            content = 
        //                View.Sample2
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample2"
        //                    )
        //        )
        //}
        //{   Name = "Sample2";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample2",                         
        //            content = 
        //                View.Sample2
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample2"
        //                    )
        //        )
        //}
        //{   Name = "Sample2";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample2",                         
        //            content = 
        //                View.Sample2
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample2"
        //                    )
        //        )
        //}
    ]