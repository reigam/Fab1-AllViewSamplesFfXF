// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SamplePages =
    let samplePages (style: MyStyle) = [
        {   Name = "ContentPage";
            SampleType = "basic";
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title = "ContentPage",
                    content = 
                        View.Label
                            (   
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                padding = style.Padding,
                                text = sprintf "ContentPage with a single Label" 
                            )
                )
        }        

        // Sample Flyout Page: see main program 
    
        // Sample Navigation Page: see main program 

        {   Name = "TabbedPage";            
            SampleType = "basic";
            Page = 
                View.TabbedPage(
                    backgroundColor = style.PageColor,
                    title ="TabbedPage",
                    children = [
                        View.ContentPage( title ="First Tab", content = View.Label
                            (                                 
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                padding = style.Padding,
                                text = "TabbedPage 1" 
                            ) 
                        )
                        View.ContentPage( title ="Second Tab", content = View.Label
                            (                                
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor2,
                                padding = style.Padding,
                                text = "TabbedPage 2"
                            ) 
                        )                
                    ] )
        }
        {   Name = "CarouselPage";
            SampleType = "basic";
            Page = 
                View.CarouselPage(
                    backgroundColor = style.PageColor,
                    title = "CarouselPage",
                    children = [
                        View.ContentPage(title ="carousel1", content = View.Label
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                padding = style.Padding,
                                text = "carousel page 1"
                            )
                        )                
                        View.ContentPage(title ="carousel1", content = View.Label
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor2,
                                padding = style.Padding,
                                text = "carousel page 2"
                            )
                        )
                    ]
                )
        }
    ]

