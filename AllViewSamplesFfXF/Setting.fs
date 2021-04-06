// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleSetting =
    let sampleSetting (style: MyStyle) = [
        {   Name = "CheckBox";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="CheckBox",                         
                    content = 
                        View.CheckBox
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                isChecked = true
                            )
                )
        }
        {   Name = "Slider";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Slider",                         
                    content = 
                        View.Slider
                            (
                                //horizontalOptions = style.Position,
                                //verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                minimumMaximum = (0.0, 10.0),
                                value = 5.0
                            )
                )
        }
    ]