// Copyright Fabulous contributors. See LICENSE.md for license.
namespace AllViewSamplesFfXF

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms

module Helpers = 

    type MyStyle = {
        PageColor: Color
        LayoutColor: Color
        ViewColor: Color
        CellColor: Color
        ButtonColor: Color
        Position: LayoutOptions
        Padding: Thickness
    }

    let myStyle = {
        PageColor = Color.Red
        LayoutColor = Color.Blue
        ViewColor = Color.AntiqueWhite
        CellColor = Color.Green
        ButtonColor = Color.Gray
        Position = LayoutOptions.Center
        Padding = Thickness 20.
    }

    let noStyle= {
           PageColor = Color.White
           LayoutColor = Color.White
           ViewColor = Color.White
           CellColor = Color.White
           ButtonColor = Color.White
           Position = LayoutOptions.Start
           Padding = Thickness 0.
       }

    
    type SamplePage = {
        Name : string
        SampleType : string
        Page : ViewElement
    }