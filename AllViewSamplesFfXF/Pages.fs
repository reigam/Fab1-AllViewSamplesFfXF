// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SamplePages =
    let samplePages = [
        {   Name = "ContentPage";
            Page = View.ContentPage(
                        title = "ContentPage",
                        content = View.Label( text = sprintf "ContentPage" )
                    )
        }        

        // Sample Flyout Page: see main program 
    
        // Sample Navigation Page: see main program 

        {   Name = "TabbedPage";
            Page = 
                View.TabbedPage(
                    title ="TabbedPage",
                    children = [
                        View.ContentPage( title ="First Tab", content = View.Label( "TabbedPage 1" ) )            
                        View.ContentPage( title ="Second Tab", content = View.Label( "TabbedPage 2") )                
                    ] )
        }
        

        {   Name = "CarouselPage";
            Page = 
                View.CarouselPage(
                    title = "CarouselPage",
                    children = [
                        View.ContentPage(title ="carousel1", content = View.Label("carousel page 1"))                
                        View.ContentPage(title ="carousel1", content = View.Label("carousel page 2"))
                    ]
                )
        }
    ]

