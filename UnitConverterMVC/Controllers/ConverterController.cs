using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC.Models;

namespace UnitConverterMVC.Controllers
{
    public class ConverterController : Controller
    {
        
        public string Index(string type, string unitvalue)
        {


            switch(type)
            {
                case "CtoF":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = (1.8*val) + 32;
            
                    return $"Celsius to Fahreneit Conversion\n  {unitvalue} Celsius is {val} Fahrenheit";
                    
                }
                case "FtoC":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = (val - 32) / 1.8;
            
                    return $"Fahrenheit to Celsius Conversion\n {unitvalue} Fahrenheit is {val} Celsius";
                    
                }
                case "CtoK":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val + 273;
            
                    return $"Celsius to Kelvin Conversion\n {unitvalue} Celsius is {val} Kelvin";
                    
                }
                case "KtoC":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val - 273;
            
                    return $"Kelvin to Celsius Conversion\n {unitvalue} Kelvin is {val} Celsius";
                    
                }
                case "FtoK":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = (val + 460) / 1.8;
            
                    return $"Fahrenheit to Kelvin Conversion\n {unitvalue} Fahrenheit is {val} Kelvin";
                    
                }
                case "KtoF":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = (val * 1.8) - 460;
            
                    return $"Kelvin to Fahrenheit Conversion\n {unitvalue} Kelvin is {val} Fahrenheit";
                    
                }
                case "MeterstoFeet":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 0.3048;
            
                    return $"Meters to Feet Conversion\n {unitvalue} Meters is {val} Feet";
                    
                }
                case "FeettoMeters":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 0.3048;
            
                    return $"Feet to Meters Conversion\n {unitvalue} Feet is {val} Meters";
                    
                }
                case "FeettoYards":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 3;
            
                    return $"Feet to Yards Conversion\n {unitvalue} Feet is {val} Yards";
                    
                }
                case "YardstoFeet":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 0.3048;
            
                    return $"Yards to Feet Conversion\n {unitvalue} Yards is {val} Feet";
                    
                }
                case "YardstoMeters":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 1.0936;
            
                    return $"Yards to Meters Conversion\n {unitvalue} Yards is {val} Meters";
                    
                }
                case "MeterstoYards":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 1.0936;
            
                    return $"Meters to Yards Conversion\n {unitvalue} Meters is {val} Yards";
                    
                }
                case "OuncetoPound":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 16;
            
                    return $"Ounce to Pound Conversion\n {unitvalue} Ounces is {val} Pounds";
                    
                }
                case "PoundtoOunce":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 16;
            
                    return $"Pound to Ounce Conversion\n {unitvalue} Pounds is {val} Ounces";
                
                }
                case "PoundtoGram":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 454.6;
            
                    return $"Pound to Gram Conversion\n {unitvalue} Pounds is {val} Grams";
                    
                }
                case "GramtoPound":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 454.6;
            
                    return $"Gram to Pound Conversion\n {unitvalue} Grams is {val} Pounds";
                    
                }
                case "GramtoOunce":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 28.3;
            
                    return $"Gram to Ounce Conversion\n {unitvalue} Grams is {val} Ounces";
                    
                }
                case "OuncetoGram":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 28.3;
            
                    return $"Ounce to Gram Conversion\n {unitvalue} Ounces is {val} Grams";
                    
                }
                case "GramtoKilogram":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 1000;
            
                    return $"Gram to Kilogram Conversion\n {unitvalue} Grams is {val} Kilograms";
                    
                }
                case "KilogramtoGram":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 1000;
            
                    return $"Kilogram to Gram Conversion\n {unitvalue} Kilograms is {val} Grams";
                    
                }
                case "KilogramtoPound":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val / 0.454;
            
                    return $"Kilogram to Pound Conversion\n {unitvalue} Kilograms is {val} Pounds";
                    
                }
                case "PoundtoKilogram":
                {
                    double val = Convert.ToDouble(unitvalue);
                    val = val * 0.454;
            
                    return $"Pound to Kilogram Conversion\n {unitvalue} Pounds is {val} Kilograms";
                    
                }
                default:
                {
                    return $"You screwed up.";
                    
                }

                
            }
        }

        
    }
}
