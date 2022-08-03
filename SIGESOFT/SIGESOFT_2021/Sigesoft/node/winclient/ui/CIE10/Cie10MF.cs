﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigesoft.Node.WinClient.UI.CIE10
{
    public class Cie10MF
    {
        public string[] Femeninos =
        {
            "D06.0", "D06.1", "D06.7", "D06.9", "C79.6", "B37.3", "A34.X", "E89.4", "F52.5",
            "I86.3", "P54.6", "M83.0", "Z31.2", "Z01.4", "Z12.4", "Z30.1", "Z30.3", "Z30.5",
            "Z31.1", "Z43.7", "Z87.5", "Z97.5", "S31.4", "T83.3", "L29.2", "L70.5", "R87.0",
            "R87.1", "R87.2", "R87.3", "R87.4", "R87.5", "R87.7", "R87.8", "R87.9", "C51.0", 
            "C51.1", "C51.2", "C51.8", "C51.9", "C52.X", "C53.0", "C53.1", "C53.8", "C53.9",
            "C54.0", "C54.1", "C54.2", "C54.3", "C54.8", "C54.9", "C55.X", "C56.X", "C57.0", 
            "C57.1", "C57.2", "C57.3", "C57.4", "C57.7", "C57.8", "C57.9", "C58.X", "D07.0", 
            "D07.1", "D07.2", "D07.3", "D25.0", "D25.1", "D25.2", "D25.9", "D26.0", "D26.1", 
            "D26.7", "D26.9", "D27.X", "D28.0", "D28.1", "D28.2", "D28.7", "D28.9", "D39.0", 
            "D39.1", "D39.2", "D39.7", "D39.9", "E28.0", "E28.1", "E28.2", "E28.3", "E28.8", 
            "E28.9", "F53.0", "F53.1", "F53.8", "F53.9", "M80.0", "M80.1", "M81.0", "M81.1",            
            "N70.0", "N70.1", "N70.9", "N71.0", "N71.1", "N71.9", "N72.X", "N73.0", "N73.1", 
            "N73.2", "N73.3", "N73.4", "N73.5", "N73.6", "N73.8", "N73.9", "N74.0", "N74.1", 
            "N74.2", "N74.3", "N74.4", "N74.8", "N75.0", "N75.1", "N75.8", "N75.9", "N76.0", 
            "N76.1", "N76.2", "N76.3", "N76.4", "N76.5", "N76.6", "N76.8", "N77.0", "N77.1", 
            "N77.8", "N80.0", "N80.1", "N80.2", "N80.3", "N80.4", "N80.5", "N80.6", "N80.8", 
            "N80.9", "N81.0", "N81.1", "N81.2", "N81.3", "N81.4", "N81.5", "N81.6", "N81.8",
            "N81.9", "N82.0", "N82.1", "N82.2", "N82.3", "N82.4", "N82.5", "N82.8", "N82.9",
            "N83.0", "N83.1", "N83.2", "N83.3", "N83.4", "N83.5", "N83.6", "N83.7", "N83.8",
            "N83.9", "N84.0", "N84.1", "N84.2", "N84.3", "N84.8", "N84.9", "N85.0", "N85.1",
            "N85.2", "N85.3", "N85.4", "N85.5", "N85.6", "N85.7", "N85.8", "N85.9", "N86.X",
            "N87.0", "N87.1", "N87.2", "N87.9", "N88.0", "N88.1", "N88.2", "N88.3", "N88.4",
            "N88.8", "N88.9", "N89.0", "N89.1", "N89.2", "N89.3", "N89.4", "N89.5", "N89.6",
            "N89.7", "N89.8", "N89.9", "N90.0", "N90.1", "N90.2", "N90.3", "N90.4", "N90.5",
            "N90.6", "N90.7", "N90.8", "N90.9", "N91.0", "N91.1", "N91.2", "N91.3", "N91.4",
            "N91.5", "N92.0", "N92.1", "N92.2", "N92.3", "N92.4", "N92.5", "N92.6", "N93.0",
            "N93.8", "N93.9", "N94.0", "N94.1", "N94.2", "N94.3", "N94.4", "N94.5", "N94.6",
            "N94.8", "N94.9", "N95.0", "N95.1", "N95.2", "N95.3", "N95.8", "N95.9", "N96.X",
            "N97.0", "N97.1", "N97.2", "N97.3", "N97.4", "N97.8", "N97.9", "N98.0", "N98.1",
            "N98.2", "N98.3", "N98.8", "N98.9", "N99.2", "N99.3", "O00.0", "O00.1", "O00.2",
            "O00.8", "O00.9", "O01.0", "O01.1", "O01.9", "O02.0", "O02.1", "O02.8", "O02.9",
            "O03.0", "O03.1", "O03.2", "O03.3", "O03.4", "O03.5", "O03.6", "O03.7", "O03.8",
            "O03.9", "O04.0", "O04.1", "O04.2", "O04.3", "O04.4", "O04.5", "O04.6", "O04.7",
            "O04.8", "O04.9", "O05.0", "O05.1", "O05.2", "O05.3", "O05.4", "O05.5", "O05.6",
            "O05.7", "O05.8", "O05.9", "O06.0", "O06.1", "O06.2", "O06.3", "O06.4", "O06.5",
            "O06.6", "O06.7", "O06.8", "O06.9", "O07.0", "O07.1", "O07.2", "O07.3", "O07.4",
            "O07.5", "O07.6", "O07.7", "O07.8", "O07.9", "O08.0", "O08.1", "O08.2", "O08.3",
            "O08.4", "O08.5", "O08.6", "O08.7", "O08.8", "O08.9", "O10.0", "O10.1", "O10.2",
            "O10.3", "O10.4", "O10.9", "O11.X", "O12.0", "O12.1", "O12.2", "O13.X", "O14.0",
            "O14.1", "O14.9", "O15.0", "O15.1", "O15.2", "O15.9", "O16.X", "O20.0", "O20.8",
            "O20.9", "O21.0", "O21.1", "O21.2", "O21.8", "O21.9", "O22.0", "O22.1", "O22.2",
            "O22.3", "O22.4", "O22.5", "O22.8", "O22.9", "O23.0", "O23.1", "O23.2", "O23.3",
            "O23.4", "O23.5", "O23.9", "O24.0", "O24.1", "O24.2", "O24.3", "O24.4", "O24.9",
            "O25.X", "O26.0", "O26.1", "O26.2", "O26.3", "O26.5", "O26.6", "O26.7", "O26.8",
            "O26.9", "O28.0", "O28.1", "O28.2", "O28.3", "O28.4", "O28.5", "O28.8", "O28.9",
            "O29.0", "O29.1", "O29.2", "O29.3", "O29.4", "O29.5", "O29.6", "O29.8", "O29.9",
            "O30.0", "O30.1", "O30.2", "O30.8", "O30.9", "O31.0", "O31.1", "O31.2", "O31.8",
            "O32.0", "O32.1", "O32.2", "O32.3", "O32.4", "O32.5", "O32.6", "O32.8", "O32.9",
            "O33.0", "O33.1", "O33.2", "O33.3", "O33.4", "O33.5", "O33.6", "O33.7", "O33.8",
            "O33.9", "O34.0", "O34.1", "O34.2", "O34.3", "O34.4", "O34.5", "O34.6", "O34.7",
            "O34.8", "O34.9", "O35.0", "O35.1", "O35.2", "O35.3", "O35.4", "O35.5", "O35.6",
            "O35.7", "O35.8", "O35.9", "O36.0", "O36.1", "O36.2", "O36.3", "O36.4", "O36.5",
            "O36.6", "O36.7", "O36.8", "O36.9", "O40.X", "O41.0", "O41.1", "O41.8", "O41.9",
            "O42.0", "O42.1", "O42.2", "O42.9", "O43.0", "O43.1", "O43.8", "O43.9", "O44.0",
            "O44.1", "O45.0", "O45.8", "O45.9", "O46.0", "O46.8", "O46.9", "O47.0", "O47.1",
            "O47.9", "O48.X", "O60.X", "O61.0", "O61.1", "O61.8", "O61.9", "O62.0", "O62.1",
            "O62.2", "O62.3", "O62.4", "O62.8", "O62.9", "O63.0", "O63.1", "O63.2", "O63.9",
            "O64.0", "O64.1", "O64.2", "O64.3", "O64.4", "O64.5", "O64.8", "O64.9", "O65.0",
            "O65.1", "O65.2", "O65.3", "O65.4", "O65.5", "O65.8", "O65.9", "O66.0", "O66.1",
            "O66.2", "O66.3", "O66.4", "O66.5", "O66.8", "O66.9", "O67.0", "O67.8", "O67.9",
            "O68.0", "O68.1", "O68.2", "O68.3", "O68.8", "O68.9", "O69.0", "O69.1", "O69.2",
            "O69.3", "O69.4", "O69.5", "O69.8", "O69.9", "O70.0", "O70.1", "O70.2", "O70.3",
            "O70.9", "O71.0", "O71.1", "O71.2", "O71.3", "O71.4", "O71.5", "O71.6", "O71.7",
            "O71.8", "O71.9", "O72.0", "O72.1", "O72.2", "O72.3", "O73.0", "O73.1", "O74.0",
            "O74.1", "O74.2", "O74.3", "O74.4", "O74.5", "O74.6", "O74.7", "O74.8", "O74.9",
            "O75.0", "O75.1", "O75.2", "O75.3", "O75.4", "O75.5", "O75.6", "O75.7", "O75.8",
            "O75.9", "O80.0", "O80.1", "O80.8", "O80.9", "O81.0", "O81.1", "O81.2", "O81.3",
            "O81.4", "O81.5", "O82.0", "O82.1", "O82.2", "O82.8", "O82.9", "O83.0", "O83.1",
            "O83.2", "O83.3", "O83.4", "O83.8", "O83.9", "O84.0", "O84.1", "O84.2", "O84.8",
            "O84.9", "O85.X", "O86.0", "O86.1", "O86.2", "O86.3", "O86.4", "O86.8", "O87.0",
            "O87.1", "O87.2", "O87.3", "O87.8", "O87.9", "O88.0", "O88.1", "O88.2", "O88.3",
            "O88.8", "O89.0", "O89.1", "O89.2", "O89.3", "O89.4", "O89.5", "O89.6", "O89.8",
            "O89.9", "O90.0", "O90.1", "O90.2", "O90.3", "O90.4", "O90.5", "O90.8", "O90.9",
            "O91.0", "O91.1", "O91.2", "O92.0", "O92.1", "O92.2", "O92.3", "O92.4", "O92.5",
            "O92.6", "O92.7", "O95.X", "O96.X", "O97.X", "O98.0", "O98.1", "O98.2", "O98.3",
            "O98.4", "O98.5", "O98.6", "O98.8", "O98.9", "O99.0", "Q50.0", "Q50.1", "Q50.2",
            "Q50.3", "Q50.4", "Q50.5", "Q50.6", "Q51.0", "Q51.1", "Q51.2", "Q51.3", "Q51.4", 
            "Q51.5", "Q51.6", "Q51.7", "Q51.8", "Q51.9", "Q52.0", "Q52.1", "Q52.2", "Q52.3",
            "Q52.4", "Q52.5", "Q52.6", "Q52.7", "Q52.8", "Q52.9", "S37.4", "S37.5", "S37.6",
            "T19.2", "T19.3", "Y76.0", "Y76.1", "Y76.2", "Y76.3", "Y76.8", "Z32.0", "Z32.1",
            "Z33.X", "Z34.0", "Z34.8", "Z34.9", "Z35.0", "Z35.1", "Z35.2", "Z35.3", "Z35.4",
            "Z35.5", "Z35.6", "Z35.7", "Z35.8", "Z35.9", "Z36.0", "Z36.1", "Z36.2", "Z36.3",
            "Z36.4", "Z36.5", "Z36.8", "Z36.9", "Z39.0", "Z39.1", "Z39.2",  
        };


        public string[] Masculinos =
        {
            "B26.0", "D17.6", "E89.5", "F52.4", "Z12.5", "L29.1", "I86.1", "R86.0", "R86.1",
            "R86.2", "R86.3", "R86.4", "R86.5", "R86.6", "R86.7", "R86.8", "R86.9", "C60.0", 
            "C60.1", "C60.2", "C60.8", "C60.9", "C61.X", "C62.0", "C62.1", "C62.9", "C63.0", 
            "C63.1", "C63.2", "C63.7", "C63.8", "C63.9", "D07.4", "D07.5", "D07.6", "D29.0", 
            "D29.1", "D29.2", "D29.3", "D29.4", "D29.7", "D29.9", "D40.0", "D40.1", "D40.7",
            "D40.9", "E29.0", "E29.1", "E29.8", "E29.9", "N40.X", "N41.0", "N41.1", "N41.2", 
            "N41.3", "N41.8", "N41.9", "N42.0", "N42.1", "N42.2", "N42.8", "N42.9", "N43.0", 
            "N43.1", "N43.2", "N43.3", "N43.4", "N44.X", "N45.0", "N45.9", "N46.X", "N47.X",
            "N48.0", "N48.1", "N48.2", "N48.3", "N48.4", "N48.5", "N48.6", "N48.8", "N48.9", 
            "N49.0", "N49.1", "N49.2", "N49.8", "N49.9", "N50.0", "N50.1", "N50.8", "N50.9", 
            "N51.0", "N51.1", "N51.2", "N51.8", "Q53.0", "Q53.1", "Q53.2", "Q53.9", "Q54.0",
            "Q54.1", "Q54.2", "Q54.3", "Q54.4", "Q54.8", "Q54.9", "Q55.0", "Q55.1", "Q55.2",
            "Q55.3", "Q55.4", "Q55.5", "Q55.6", "Q55.8", "Q55.9", "S31.22", "S31.3"
        };
    }
}