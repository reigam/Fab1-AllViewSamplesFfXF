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
        {   Name = "Polygon";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Polygon",                         
                    content = 
                        View.Polygon
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,                                
                                points = Points.fromString "40,10 70,80 10,50",
                                fill = View.SolidColorBrush(Color.Black),
                                stroke = View.SolidColorBrush(Color.Orange),
                                strokeThickness = 5.
                                   
                            )
                )
        }
        {   Name = "Polyline";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Polyline",                         
                    content = 
                        View.Polyline
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                points = Points.fromString "0,0 10,30, 15,0 18,60 23,30 35,30 40,0 43,60 48,30 100,30",
                                stroke = View.SolidColorBrush(Color.Black),
                                strokeThickness = 1.
                            )
                )
        }
        {   Name = "Rectangle";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Rectangle",                         
                    content = 
                        View.Rectangle
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,                                
                                fill = View.SolidColorBrush(Color.Black),
                                stroke = View.SolidColorBrush(Color.Orange),
                                strokeThickness = 5.,                                
                                width = 150.,
                                height = 50.
                            )
                )
        }        
        {   Name = "WebView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="WebView",                         
                    content = 
                        View.WebView
                            (
                                backgroundColor = style.ViewColor,
                                margin = style.Padding,                                
                                source = UrlWebViewSource.op_Implicit "https://fsprojects.github.io/Fabulous/Fabulous.XamarinForms/"
                            )
                )
        }
        {   Name = "OpenGLView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="OpenGLView",                         
                    content = 
                        View.OpenGLView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                margin = style.Padding,
                                hasRenderLoop = true                                                    
                            )
                )
        }
    ]