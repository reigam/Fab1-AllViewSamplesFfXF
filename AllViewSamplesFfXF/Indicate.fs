// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleIndicate =
    let sampleIndicate (style: MyStyle) = [
        {   Name = "ActivityIndicator";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="ActivityIndicator",                         
                    content = 
                        View.ActivityIndicator
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                isRunning = true
                            )
                )
        }
        {   Name = "ProgressBar";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="ProgressBar",                         
                    content = 
                        View.ProgressBar
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                progress = 0.5
                            )
                )
        }
    ]