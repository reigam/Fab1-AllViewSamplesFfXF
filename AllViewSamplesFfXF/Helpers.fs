// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms

module Helpers = 

    type MyStyle = {
        PageColor: Color
        LayoutColor: Color
        ViewRootColor : Color
        ViewColor: Color
        ViewColor2 : Color
        ViewColor3 : Color
        ViewColor4 : Color
        CellColor: Color
        ButtonColor: Color
        Position: LayoutOptions
        Padding: Thickness
    }

    let myStyle = {
        PageColor = Color.Red
        LayoutColor = Color.Blue
        ViewColor = Color.AntiqueWhite
        ViewRootColor = Color.LightBlue
        ViewColor2 = Color.LightCyan
        ViewColor3 = Color.LightCoral
        ViewColor4 = Color.LightSeaGreen
        CellColor = Color.Green
        ButtonColor = Color.Gray
        Position = LayoutOptions.Center
        Padding = Thickness 20.
    }

    let noStyle= {
           PageColor = Color.White
           LayoutColor = Color.White
           ViewColor = Color.White
           ViewRootColor = Color.White
           ViewColor2 = Color.White
           ViewColor3 = Color.White
           ViewColor4 = Color.White
           CellColor = Color.White
           ButtonColor = Color.White
           Position = LayoutOptions.Start
           Padding = Thickness 0.
       }

    
    type SamplePage = {
        Name : string
        Page : ViewElement
    }