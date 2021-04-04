// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Helpers

module SampleDisplays =
    let sampleDisplays (style: MyStyle) = [
        {   Name = "CarouselView";  
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title = "CarouselView", 
                    content = 
                        View.CarouselView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewRootColor,
                                items = [
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,
                                        text="First Carousel View"
                                    ) 
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor2,
                                        padding = style.Padding,
                                        text="Second Carousel View"
                                    )
                                View.Label
                                    (   
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor3,
                                        padding = style.Padding,
                                        text="Third Carousel View"
                                    )
                                ] 
                            )
                )
        }
        {   Name = "CollectionView";  
            Page = 
                View.ContentPage
                    (
                        title ="CollectionView", 
                        content = 
                            View.CollectionView(
                                items = [
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor,
                                        padding = style.Padding,
                                        text="First Collection View"
                                    ) 
                                View.Label
                                    (
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor2,
                                        padding = style.Padding,
                                        text="Second Collection View"
                                    )
                                View.Label
                                    (   
                                        horizontalOptions = style.Position,
                                        verticalOptions = style.Position,
                                        backgroundColor = style.ViewColor3,
                                        padding = style.Padding,
                                        text="Third Collection View"
                                    )
                                ] 
                            )
                )
        }        
        {   Name = "IndicatorView";  
            Page = 
                let indicatorRef = ViewRef<IndicatorView>()
                View.ContentPage( 
                    backgroundColor = style.PageColor,
                    title = "IndicatorView", 
                    content = 
                        View.StackLayout
                            ( 
                                children = [
                                    View.IndicatorView( 
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewRootColor,
                                            padding = style.Padding,
                                            ref = indicatorRef, 
                                            indicatorColor = Color.Red, 
                                            selectedIndicatorColor = Color.Blue, 
                                            indicatorsShape = IndicatorShape.Square
                                    )
                    
                                    View.CarouselView
                                        (
                                            indicatorView = indicatorRef, items = [
                                                for i = 0 to 15 do
                                                    yield View.StackLayout( children = [
                                                        View.Label
                                                            (
                                                                horizontalOptions = style.Position,
                                                                verticalOptions = style.Position,
                                                                backgroundColor = style.ViewColor,
                                                                padding = style.Padding,   
                                                                text = sprintf "Item %i in CarouselView with IndicatorView above" i
                                                            )
                                                    ] )
                                            ] 
                                        )
                    ] )
                )
        }
        {   Name = "ListView";  
            Page = 
                View.TabbedPage
                    (
                        backgroundColor = style.PageColor,    
                        title ="ListView",
                        children = [
                            View.ContentPage
                                (
                                    backgroundColor = style.PageColor,
                                    title = "ListView", 
                                    content = 
                                        View.ListView
                                            (
                                                horizontalOptions = style.Position,
                                                verticalOptions = style.Position,
                                                backgroundColor = style.ViewRootColor,
                                                items = [
                                                    View.TextCell "ListView Item One"
                                                    View.TextCell "ListView Item Two"
                                                    View.TextCell "ListView Item Three"
                                                    View.TextCell "ListView Item Four"
                                                ](*, itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx)) )*) ) )         
                            View.ContentPage
                                (
                                    backgroundColor = style.PageColor,
                                    title = "ListViewGrouped", 
                                    content = 
                                        View.ListViewGrouped
                                            (
                                                horizontalOptions = style.Position,
                                                verticalOptions = style.Position,
                                                backgroundColor = style.ViewRootColor,
                                                items = [
                                                    "Group 1", View.TextCell "Group 1", [View.TextCell "ListView Item One"; View.TextCell "ListView Item Two"]
                                                    "Group 2", View.TextCell "Group 2", [View.TextCell "ListView Item Three"; View.TextCell "ListView Item Four"]                                     
       
                                                ](*, itemSelected = (fun idx -> dispatch (ListViewSelectedItemChanged idx)) )*) 
                                            ) 
                                )
                        ] 
                    )
        }
        {   Name = "Picker";  
            Page = 
                let pickerItems = [
                    ("Picker Item One", style.ViewColor)                    
                    ("Picker Item Two", style.ViewColor2)
                    ("Picker Item Three", style.ViewColor3)
                    ("Picker Item Fourth", style.ViewColor4)
                ]
                    
                
                let pickerIndex = 0 // placeholder for testing purposes 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="Picker", 
                    content =                     
                        View.Picker
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = snd pickerItems.[pickerIndex], //to be changed by function
                                title = "Choose Color:",
                                selectedIndex = pickerIndex,
                                items = List.map fst pickerItems
                                //selectedIndexChanged = (fun (i, item) -> dispatch (PickerItemChanged i))
                            )
                )
        }
        {   Name = "TableView";  
            Page = 
                View.ContentPage(
                    backgroundColor = style.PageColor,
                    title ="TableView", 
                    content = 
                        View.TableView
                            ( 
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                root = 
                                    View.TableRoot( items = [
                                        View.TableSection
                                            (
                                                title = "TextCell in TableView",
                                                items = [
                                                    View.TextCell(text = "one") 
                                                    View.TextCell(text = "two")
                                                ]
                                            )
                                        View.TableSection
                                            (
                                                title = "ImageCell TableView",
                                                items = [
                                                    View.ImageCell(text = "image one")
                                                    View.ImageCell(text = "image two")
                                                ]
                                            )
                                        View.TableSection
                                            (
                                                title = "SwitchCell TableView",
                                                items = [
                                                    View.SwitchCell(on = true, text = "one") 
                                                    View.SwitchCell(on = true, text = "two")
                                                ]
                                            )
                                        View.TableSection
                                            (
                                                title = "EntryCell TableView",
                                                items = [
                                                    View.EntryCell(label = "one", placeholder = "1")
                                                    View.EntryCell(label = "two", placeholder = "2")
                                                ]
                                            )

                                    ] )
                            )
                )
        }
    ]