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
                                backgroundColor = style.ViewColor,
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
                                backgroundColor = style.ViewColor,
                                minimumMaximum = (0.0, 10.0),
                                value = 5.0
                            )
                )
        }
        {   Name = "Stepper";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Stepper",                         
                    content = 
                        View.Stepper
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                minimumMaximum = (0.0, 10.0),
                                value = 5.0
                            )
                )
        }
        {   Name = "Switch";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="Switch",                         
                    content = 
                        View.Switch
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                isToggled = false
                            )
                )
        }
        {   Name = "DatePicker";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="DatePicker",                         
                    content = 
                        View.DatePicker
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor
                            )
                )
        }
        {   Name = "TimePicker";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="TimePicker",                         
                    content = 
                        View.TimePicker
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor
                            )
                )
        }
    ]