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
                                backgroundColor = style.ViewColor
                            )
                )
        }
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
        //{   Name = "Sample";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="Sample",                         
        //            content = 
        //                View.Sample
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding,
        //                        text = "Sample"
        //                    )
        //        )
        //}
    ]