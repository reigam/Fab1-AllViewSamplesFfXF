// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module App =  
 
    /// The messages dispatched by the view
    type Msg =        
        | IsFlyoutPresentedChanged of bool
        | ListViewSelectedItemChanged of (int * int)
        | StateChanged
 
    /// The model from which the view is generated
    type Model =
        {   SelectedPage : (int * int)
            IsFlyoutPresented : bool
            StateChanged : bool 
        }
 
    /// Returns the initial state
    let init() = 
        {   SelectedPage = (0, 0)
            IsFlyoutPresented = false
            StateChanged = false 
        }, Cmd.none
 
    /// The function to update the view
    let update (msg: Msg) (model: Model) =
        match msg with
        | IsFlyoutPresentedChanged b -> 
            {model with IsFlyoutPresented = b}, Cmd.none
        | ListViewSelectedItemChanged i -> 
            {model with SelectedPage = i; IsFlyoutPresented = false}, Cmd.none
        | StateChanged -> 
            { model with StateChanged = true }, Cmd.none
 
    /// The view function giving updated content for the page
    let view (model: Model) dispatch =        

        let introductionPages = [
            {   Name = "Introduction";
                Page = 
                    View.ContentPage
                        (
                            backgroundColor = Color.Red,
                            content = 
                                View.Label
                                    (
                                        text = "Welcome",
                                        horizontalOptions = LayoutOptions.Center,
                                        verticalOptions = LayoutOptions.Center,
                                        backgroundColor = Color.Blue
                                    )                        
                    )            
            }
        ]

        let pagesToNavigateName (p : list<SamplePage>) = p |> List.map (fun x -> View.TextCell(text = x.Name))
        let activePage x = 
            let activeCategory =
                match fst(x) with                
                | 0 -> introductionPages
                | 1 -> SamplePages.samplePages
                | 2 -> SampleLayouts.sampleLayouts
                | 3 -> SampleDisplays.sampleDisplays
                | _ -> []
            activeCategory.Item(snd(x)).Page
        

        View.FlyoutPage(   
            flyoutLayoutBehavior = FlyoutLayoutBehavior.Default,
            isPresented = model.IsFlyoutPresented,
            isPresentedChanged = (fun () -> dispatch (IsFlyoutPresentedChanged (not model.IsFlyoutPresented))),

            flyout = View.ContentPage
                (   title ="flyoutPage",    
                    content = 
                        View.StackLayout( children = [
                            View.ListViewGrouped(
                                items = [ 
                                    "Introduction Pages", View.TextCell("Introduction Pages"), pagesToNavigateName introductionPages
                                    "Sample Pages", View.TextCell("Sample Pages"), pagesToNavigateName SamplePages.samplePages
                                    "Sample Layouts", View.TextCell("Sample Layouts"), pagesToNavigateName SampleLayouts.sampleLayouts
                                    "Sample Displays", View.TextCell("Sample Displays"), pagesToNavigateName SampleDisplays.sampleDisplays
                                ], 
                                itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx.Value))
                            )
                        ])
                ), 
            detail = View.NavigationPage
                (   title = "details", pages = [
                        activePage model.SelectedPage
                ] )
        )
    
type App () as app =
    inherit Application ()
 
    let runner =        
        Program.mkProgram App.init App.update App.view
        |> Program.withConsoleTrace
        |> XamarinFormsProgram.run app
