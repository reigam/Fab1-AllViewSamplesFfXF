// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleEdit =
    let sampleEdit (style: MyStyle) = [
        {   Name = "Entry";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Entry",                         
                    content = 
                        View.Entry
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                text = "Entry"
                            )
                )
        }
        {   Name = "Editor";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Editor",                         
                    content = 
                        View.Editor
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                text = "Editor"
                            )
                )
        }
    ]