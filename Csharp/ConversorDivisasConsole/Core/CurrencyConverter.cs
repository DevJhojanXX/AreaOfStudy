﻿using ConversorDivisasConsole.Conn;
using ConversorDivisasConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDivisasConsole.Core
{
    public class CurrencyConverter
    {
        private Connect _connect = new Connect(); 
        
        public decimal Converter(string cCurrenDivisa, string cConvertionDivisa, decimal cAmount, string cApiKey)
        {
            _connect.ApiKey = cApiKey;
            _connect.EndPoint = $"https://v6.exchangerate-api.com/v6/ffcfcb0afd4c36587e0a6da3/latest/{cCurrenDivisa}";
            Divisa divisa = _connect.GET().Result;
            switch (cConvertionDivisa)
            {
                case "AED": return divisa.conversion_rates.AED * cAmount;
                case "AFN": return divisa.conversion_rates.AFN * cAmount;
                case "ALL": return divisa.conversion_rates.ALL * cAmount;
                case "AMD": return divisa.conversion_rates.AMD * cAmount;
                case "ANG": return divisa.conversion_rates.ANG * cAmount;
                case "AOA": return divisa.conversion_rates.AOA * cAmount;
                case "ARS": return divisa.conversion_rates.ARS * cAmount;
                case "AUD": return divisa.conversion_rates.AUD * cAmount;
                case "AWG": return divisa.conversion_rates.AWG * cAmount;
                case "AZN": return divisa.conversion_rates.AZN * cAmount;
                case "BAM": return divisa.conversion_rates.BAM * cAmount;
                case "BBD": return divisa.conversion_rates.BBD * cAmount;
                case "BDT": return divisa.conversion_rates.BDT * cAmount;
                case "BGN": return divisa.conversion_rates.BGN * cAmount;
                case "BHD": return divisa.conversion_rates.BHD * cAmount;
                case "BIF": return divisa.conversion_rates.BIF * cAmount;
                case "BMD": return divisa.conversion_rates.BMD * cAmount;
                case "BND": return divisa.conversion_rates.BND * cAmount;
                case "BOB": return divisa.conversion_rates.BOB * cAmount;
                case "BRL": return divisa.conversion_rates.BRL * cAmount;
                case "BSD": return divisa.conversion_rates.BSD * cAmount;
                case "BTN": return divisa.conversion_rates.BTN * cAmount;
                case "BWP": return divisa.conversion_rates.BWP * cAmount;
                case "BYN": return divisa.conversion_rates.BYN * cAmount;
                case "BZD": return divisa.conversion_rates.BZD * cAmount;
                case "CAD": return divisa.conversion_rates.CAD * cAmount;
                case "CDF": return divisa.conversion_rates.CDF * cAmount;
                case "CHF": return divisa.conversion_rates.CHF * cAmount;
                case "CLP": return divisa.conversion_rates.CLP * cAmount;
                case "CNY": return divisa.conversion_rates.CNY * cAmount;
                case "COP": return divisa.conversion_rates.COP * cAmount;
                case "CRC": return divisa.conversion_rates.CRC * cAmount;
                case "CUP": return divisa.conversion_rates.CUP * cAmount;
                case "CVE": return divisa.conversion_rates.CVE * cAmount;
                case "CZK": return divisa.conversion_rates.CZK * cAmount;
                case "DJF": return divisa.conversion_rates.DJF * cAmount;
                case "DKK": return divisa.conversion_rates.DKK * cAmount;
                case "DOP": return divisa.conversion_rates.DOP * cAmount;
                case "DZD": return divisa.conversion_rates.DZD * cAmount;
                case "EGP": return divisa.conversion_rates.EGP * cAmount;
                case "ERN": return divisa.conversion_rates.ERN * cAmount;
                case "ETB": return divisa.conversion_rates.ETB * cAmount;
                case "EUR": return divisa.conversion_rates.EUR * cAmount;
                case "FJD": return divisa.conversion_rates.FJD * cAmount;
                case "FKP": return divisa.conversion_rates.FKP * cAmount;
                case "FOK": return divisa.conversion_rates.FOK * cAmount;
                case "GBP": return divisa.conversion_rates.GBP * cAmount;
                case "GEL": return divisa.conversion_rates.GEL * cAmount;
                case "GGP": return divisa.conversion_rates.GGP * cAmount;
                case "GHS": return divisa.conversion_rates.GHS * cAmount;
                case "GIP": return divisa.conversion_rates.GIP * cAmount;
                case "GMD": return divisa.conversion_rates.GMD * cAmount;
                case "GNF": return divisa.conversion_rates.GNF * cAmount;
                case "GTQ": return divisa.conversion_rates.GTQ * cAmount;
                case "GYD": return divisa.conversion_rates.GYD * cAmount;
                case "HKD": return divisa.conversion_rates.HKD * cAmount;
                case "HNL": return divisa.conversion_rates.HNL * cAmount;
                case "HRK": return divisa.conversion_rates.HRK * cAmount;
                case "HTG": return divisa.conversion_rates.HTG * cAmount;
                case "HUF": return divisa.conversion_rates.HUF * cAmount;
                case "IDR": return divisa.conversion_rates.IDR * cAmount;
                case "ILS": return divisa.conversion_rates.ILS * cAmount;
                case "IMP": return divisa.conversion_rates.IMP * cAmount;
                case "INR": return divisa.conversion_rates.INR * cAmount;
                case "IQD": return divisa.conversion_rates.IQD * cAmount;
                case "IRR": return divisa.conversion_rates.IRR * cAmount;
                case "ISK": return divisa.conversion_rates.ISK * cAmount;
                case "JEP": return divisa.conversion_rates.JEP * cAmount;
                case "JMD": return divisa.conversion_rates.JMD * cAmount;
                case "JOD": return divisa.conversion_rates.JOD * cAmount;
                case "JPY": return divisa.conversion_rates.JPY * cAmount;
                case "KES": return divisa.conversion_rates.KES * cAmount;
                case "KGS": return divisa.conversion_rates.KGS * cAmount;
                case "KHR": return divisa.conversion_rates.KHR * cAmount;
                case "KID": return divisa.conversion_rates.KID * cAmount;
                case "KMF": return divisa.conversion_rates.KMF * cAmount;
                case "KRW": return divisa.conversion_rates.KRW * cAmount;
                case "KWD": return divisa.conversion_rates.KWD * cAmount;
                case "KYD": return divisa.conversion_rates.KYD * cAmount;
                case "KZT": return divisa.conversion_rates.KZT * cAmount;
                case "LAK": return divisa.conversion_rates.LAK * cAmount;
                case "LBP": return divisa.conversion_rates.LBP * cAmount;
                case "LKR": return divisa.conversion_rates.LKR * cAmount;
                case "LRD": return divisa.conversion_rates.LRD * cAmount;
                case "LSL": return divisa.conversion_rates.LSL * cAmount;
                case "LYD": return divisa.conversion_rates.LYD * cAmount;
                case "MAD": return divisa.conversion_rates.MAD * cAmount;
                case "MDL": return divisa.conversion_rates.MDL * cAmount;
                case "MGA": return divisa.conversion_rates.MGA * cAmount;
                case "MKD": return divisa.conversion_rates.MKD * cAmount;
                case "MMK": return divisa.conversion_rates.MMK * cAmount;
                case "MNT": return divisa.conversion_rates.MNT * cAmount;
                case "MOP": return divisa.conversion_rates.MOP * cAmount;
                case "MRU": return divisa.conversion_rates.MRU * cAmount;
                case "MUR": return divisa.conversion_rates.MUR * cAmount;
                case "MVR": return divisa.conversion_rates.MVR * cAmount;
                case "MWK": return divisa.conversion_rates.MWK * cAmount;
                case "MXN": return divisa.conversion_rates.MXN * cAmount;
                case "MYR": return divisa.conversion_rates.MYR * cAmount;
                case "MZN": return divisa.conversion_rates.MZN * cAmount;
                case "NAD": return divisa.conversion_rates.NAD * cAmount;
                case "NGN": return divisa.conversion_rates.NGN * cAmount;
                case "NIO": return divisa.conversion_rates.NIO * cAmount;
                case "NOK": return divisa.conversion_rates.NOK * cAmount;
                case "NPR": return divisa.conversion_rates.NPR * cAmount;
                case "NZD": return divisa.conversion_rates.NZD * cAmount;
                case "OMR": return divisa.conversion_rates.OMR * cAmount;
                case "PAB": return divisa.conversion_rates.PAB * cAmount;
                case "PEN": return divisa.conversion_rates.PEN * cAmount;
                case "PGK": return divisa.conversion_rates.PGK * cAmount;
                case "PHP": return divisa.conversion_rates.PHP * cAmount;
                case "PKR": return divisa.conversion_rates.PKR * cAmount;
                case "PLN": return divisa.conversion_rates.PLN * cAmount;
                case "PYG": return divisa.conversion_rates.PYG * cAmount;
                case "QAR": return divisa.conversion_rates.QAR * cAmount;
                case "RON": return divisa.conversion_rates.RON * cAmount;
                case "RSD": return divisa.conversion_rates.RSD * cAmount;
                case "RUB": return divisa.conversion_rates.RUB * cAmount;
                case "RWF": return divisa.conversion_rates.RWF * cAmount;
                case "SAR": return divisa.conversion_rates.SAR * cAmount;
                case "SBD": return divisa.conversion_rates.SBD * cAmount;
                case "SCR": return divisa.conversion_rates.SCR * cAmount;
                case "SDG": return divisa.conversion_rates.SDG * cAmount;
                case "SEK": return divisa.conversion_rates.SEK * cAmount;
                case "SGD": return divisa.conversion_rates.SGD * cAmount;
                case "SHP": return divisa.conversion_rates.SHP * cAmount;
                case "SLE": return divisa.conversion_rates.SLE * cAmount;
                case "SLL": return divisa.conversion_rates.SLL * cAmount;
                case "SOS": return divisa.conversion_rates.SOS * cAmount;
                case "SRD": return divisa.conversion_rates.SRD * cAmount;
                case "SSP": return divisa.conversion_rates.SSP * cAmount;
                case "STN": return divisa.conversion_rates.STN * cAmount;
                case "SYP": return divisa.conversion_rates.SYP * cAmount;
                case "SZL": return divisa.conversion_rates.SZL * cAmount;
                case "THB": return divisa.conversion_rates.THB * cAmount;
                case "TJS": return divisa.conversion_rates.TJS * cAmount;
                case "TMT": return divisa.conversion_rates.TMT * cAmount;
                case "TND": return divisa.conversion_rates.TND * cAmount;
                case "TOP": return divisa.conversion_rates.TOP * cAmount;
                case "TRY": return divisa.conversion_rates.TRY * cAmount;
                case "TTD": return divisa.conversion_rates.TTD * cAmount;
                case "TVD": return divisa.conversion_rates.TVD * cAmount;
                case "TWD": return divisa.conversion_rates.TWD * cAmount;
                case "TZS": return divisa.conversion_rates.TZS * cAmount;
                case "UAH": return divisa.conversion_rates.UAH * cAmount;
                case "UGX": return divisa.conversion_rates.UGX * cAmount;
                case "USD": return divisa.conversion_rates.USD * cAmount;
                case "UYU": return divisa.conversion_rates.UYU * cAmount;
                case "UZS": return divisa.conversion_rates.UZS * cAmount;
                case "VES": return divisa.conversion_rates.VES * cAmount;
                case "VND": return divisa.conversion_rates.VND * cAmount;
                case "VUV": return divisa.conversion_rates.VUV * cAmount;
                case "WST": return divisa.conversion_rates.WST * cAmount;
                case "XAF": return divisa.conversion_rates.XAF * cAmount;
                case "XCD": return divisa.conversion_rates.XCD * cAmount;
                case "XDR": return divisa.conversion_rates.XDR * cAmount;
                case "XOF": return divisa.conversion_rates.XOF * cAmount;
                case "XPF": return divisa.conversion_rates.XPF * cAmount;
                case "YER": return divisa.conversion_rates.YER * cAmount;
                case "ZAR": return divisa.conversion_rates.ZAR * cAmount;
                case "ZMW": return divisa.conversion_rates.ZMW * cAmount;
                case "ZWL": return divisa.conversion_rates.ZWL * cAmount;
                default: return 0;
            }
            
        }
    }
}