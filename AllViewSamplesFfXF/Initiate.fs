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
                                //horizontalOptions = style.Position,
                                //verticalOptions = style.Position,
                                //backgroundColor = style.ButtonColor,
                                //padding = style.Padding,
                                (*source = *)Image.ImagePath "icon.png"

                            )
                )
        }
        {   Name = "RadioButton";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="RadioButton",                         
                    content = 
                        View.StackLayout
                            (                                   
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                children = [                                
                                    View.RadioButton
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,
                                            isChecked = true,                                            
                                            content = Content.String "RadioButton 1"
                                        )
                                    View.RadioButton
                                        (
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            padding = style.Padding,
                                            isChecked = false,
                                            content = Content.String "RadioButton 2"
                                        )
                                ]
                            )

                )
        }
        {   Name = "RefreshView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="RefreshView",                         
                    content = 
                        View.RefreshView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,
                                content = 
                                    View.ListView
                                        (
                                            
                                            horizontalOptions = style.Position,
                                            verticalOptions = style.Position,
                                            backgroundColor = style.ViewColor,
                                            items = [
                                                View.TextCell "First ListView"; 
                                                View.TextCell "Second ListView"; 
                                                View.TextCell "Third ListView"
                                    ] ) 
                            )
                )
        }
        {   Name = "SearchBar";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="SearchBar",                         
                    content = 
                        View.SearchBar
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.ViewColor,
                                placeholder = "SearchBar"
                            )
                )
        }
        {   Name = "SwipeView";  
            SampleType = "basic";
            Page = 
                View.ContentPage(                    
                    backgroundColor = style.PageColor,
                    title ="SwipeView",                         
                    content = 
                        View.SwipeView
                            (
                                horizontalOptions = style.Position,
                                verticalOptions = style.Position,
                                backgroundColor = style.LayoutColor,
                                padding = style.Padding,
                                leftItems =                                 
                                    View.SwipeItems
                                        (
                                            items = [
                                                View.SwipeItem
                                                    (
                                                        backgroundColor = style.ViewColor,
                                                        text = "Left 1"
                                                    )
                                                View.SwipeItem
                                                    (
                                                        backgroundColor = style.ViewColor2,
                                                        text = "Left 2"
                                                    )
                                            ]
                                        ),
                                rightItems =                                 
                                    View.SwipeItems
                                        (
                                            items = [
                                                View.SwipeItem
                                                    (
                                                        backgroundColor = style.ViewColor3,
                                                        text = "Right 1"
                                                    )
                                                View.SwipeItem
                                                    (
                                                        backgroundColor = style.ViewColor4,
                                                        text = "Right 2"
                                                    )
                                            ]
                                        ),
                                content = View.Grid
                                    (
                                        height = 60.,
                                        width = 300.,
                                        children = [
                                            View.Label
                                                (   
                                                    horizontalOptions = style.Position,
                                                    verticalOptions = style.Position,
                                                    backgroundColor = style.ViewColor,
                                                    padding = style.Padding,
                                                    text = "test"
                                                )
                                        ]
                                    )


                                //content = 
                                //    View.Label( "SwipeContent" ),
                                //leftItems =                                 
                                //    View.SwipeItems
                                //        (
                                //            items = [
                                //                View.SwipeItem
                                //                    (
                                //                        backgroundColor = style.ViewColor,
                                //                        text = "Left SwipeItem 1"
                                //                    )
                                //                View.SwipeItem
                                //                    (
                                //                        backgroundColor = style.ViewColor2,
                                //                        text = "Left SwipeItem 2"
                                //                    )
                                //            ]
                                //        ),
                                //rightItems =                                 
                                //    View.SwipeItems
                                //        (
                                //            items = [
                                //                View.SwipeItem
                                //                    (
                                //                        backgroundColor = style.ViewColor,
                                //                        text = "Right SwipeItem 1"
                                //                    )
                                //                View.SwipeItem
                                //                    (
                                //                        backgroundColor = style.ViewColor2,
                                //                        text = "Right SwipeItem 2"
                                //                    )
                                //            ]
                                //        )
                            )
                )
        }
    ]