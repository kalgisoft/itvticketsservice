using System;
using System.Collections.Generic;
using System.Text;

namespace ItvTicketsService.Shared.Models
{
    public class DeviceInfo
    {
        public string Code { get; set; }
        public string TipoMacchina { get; set; }
        public string SensoDiMarcia { get; set; }
        public string Matricola { get; set; }
        public string Cliente { get; set; }
        public string CommessaNr { get; set; }
        public DateTime DataCollaudo { get; set; }
        public DateTime DataConsegna { get; set; }
        public string CompilatoDa { get; set; }
        public DateTime Data { get; set; }
        public string TipoPC { get; set; }
        public string HardDisk { get; set; }
        public string RAM { get; set; }
        public string Grabber { get; set; }
        public int NumLed { get; set; }
        public string TipoLedD { get; set; }
        public string TipoLedN { get; set; }
        public int DistanzaIlluminatore { get; set; }
        public string Note1 { get; set; }
        public string RealizzatoDa { get; set; }
        public DateTime Data1 { get; set; }
        public string QuadroRealDa { get; set; }
        public int NumSchemaEl { get; set; }
        public string installRealDa { get; set; }
        public string GruppoCont { get; set; }
        public string CollaudoRealDa { get; set; }
        public string Condizionatore { get; set; }
        public string Note2 { get; set; }
        public string VerSWTilevision { get; set; }
        public string VerSWCalibroPlanar { get; set; }
        public int NumSensPlanar { get; set; }
        public string TipoSens { get; set; }
        public string NoteAggiuntive { get; set; }
        public string NomePC { get; set; }
        public string TipoCinghia { get; set; }
        public string LargCinghia { get; set; }
        public string TipoMotori { get; set; }
        public string TipoRiduttori { get; set; }
        public string TipoMarcatura { get; set; }
        public string Centratore { get; set; }
        public string MotoreMovTraverse { get; set; }
        public string TipoEncoder { get; set; } 
        public string TipoAzionamenti { get; set; }
        public int MassimoFormato { get; set; }
        public int MinimoFormato { get; set; }
        public string TipoMotoriTLC { get; set; }
        public int AltezzaTlcN { get; set; }
        public string TipoTlcN { get; set; }
        public string TipoTlcD { get; set; }
        public string TipoObjN { get; set; }
        public string TipoObjD { get; set; }
        public string AperturaObjN { get; set; }
        public string AperturaObjD { get; set; }
        public string Note3 { get; set; }
        public string MontaggioDa { get; set; }
        public DateTime Data2 { get; set; }
    }
}
