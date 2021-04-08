// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleInitiate =
    let sampleInitiate (style: MyStyle) = [
        {   Name = "Button";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Button",                         
                    content = 
                        View.Button
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ButtonColor,
                                padding = style.Padding,
                                text = "Button"
                            )
                )
        }
        {   Name = "ImageButton";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="ImageButton",                         
                    content = 
                        View.ImageButton
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ButtonColor,
                                padding = style.Padding,
                                source = Image.ImagePath "icon.png"

                            )
                )
        }
        //{   Name = "CheckBox";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="CheckBox",                         
        //            content = 
        //                View.CheckBox
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding
        //                    )
        //        )
        //}
        //{   Name = "CheckBox";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="CheckBox",                         
        //            content = 
        //                View.CheckBox
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding
        //                    )
        //        )
        //}
        //{   Name = "CheckBox";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="CheckBox",                         
        //            content = 
        //                View.CheckBox
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding
        //                    )
        //        )
        //}
        //{   Name = "CheckBox";  
        //    SampleType = "basic";
        //    Page = 
        //        View.ContentPage(                    
        //            backgroundColor = style.PageColor,
        //            title ="CheckBox",                         
        //            content = 
        //                View.CheckBox
        //                    (
        //                        horizontalOptions = style.Position,
        //                        verticalOptions = style.Position,
        //                        backgroundColor = style.ViewColor,
        //                        padding = style.Padding
        //                    )
        //        )
        //}
    ]