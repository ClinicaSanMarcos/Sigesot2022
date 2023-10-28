﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sigesoft.Common
{
    public static class Constants
    {
        #region HISTORIA_CLINICA_SAN_MARCOS
        public const string HISTORIA_CLINICA_SAN_MARCOS = "N009-ME000001143";
        public const string HISTORIA_CLINICA_SAN_MARCOS_ANAMNESIS = "N009-MF000004958";
        public const string HISTORIA_CLINICA_SAN_MARCOS_DETALLES = "N009-MF000004959";
        public const string HISTORIA_CLINICA_SAN_MARCOS_PLAN_TRABAJO = "N009-MF000004960";
        public const string HISTORIA_CLINICA_SAN_MARCOS_TIPO_CONSULTA = "N009-MF000004961";
        #endregion


        #region LABORATORIO CASTA

        public const string INFORME_LABORATORIO_ID_CASTA = "N001-ME000000003";
        public const string INFORME_LABORATORIO_CASTA_ATENCION = "N009-MF000005134";
        public const string INFORME_LABORATORIO_CASTA_SERVICIO = "N009-MF000005135";
        public const string INFORME_LABORATORIO_CASTA_RESULTADO = "N009-MF000005136";



        #region BIOQUIMICA

        #region GLUOSA BASAL - LAB
        public const string GLUCOSA_BASAL_ID = "N009-ME000000008";
        public const string GLUCOSA_BASAL_VALOR = "N009-MF000000261";
        public const string GLUCOSA_BASAL_VALOR_DESEABLE = "N009-MF000005117";
        #endregion

        #region GLUOSA COLEST TRIG
        public const string GLUCOSA_COLES_TRIG_ID= "N009-ME000001466";
        
        public const string GLUCOSA_VALOR = "N009-MF000005118";
        public const string GLUCOSA_VALOR_DESEABLE = "N009-MF000005119";

        public const string COLEST_BASAL_VALOR = "N009-MF000005120";
        public const string COLEST_BASAL_VALOR_DESEABLE = "N009-MF000005121";

        public const string TRIGL_VALOR = "N009-MF000005122";
        public const string TRIGL_VALOR_DESEABLE = "N009-MF000005123";

        public const string OBSERVACIONES_GLUC_COL_TR = "N009-MF000005124";

        #endregion

        #region GAMMA GLUTAMIL TRANSPEPTIDASA GGTP - LAB
        public const string GGTP_ID_ASIST = "N009-ME000000532";
        public const string GGTP_VALOR = "N009-MF000004921";
        public const string GGTP_DESEABLE = "N009-MF000004922";
        #endregion

        #region AMILASA - LAB
        public const string AMILASA_ID = "N022-ME000000346";
        public const string AMILASA_VALOR = "N009-MF000005125";
        public const string AMILASA_DESEABLE = "N009-MF000005126";
        #endregion

        #region PERFIL LIPIDICO - LAB

        public const string PERFIL_LIPIDICO_ID = "N009-ME000000114";

        public const string PL_COLESTEROL_TOTAL = "N009-MF000001904";
        public const string PL_COLESTEROL_TOTAL_DESEABLE = "N009-MF000001905";
        public const string PL_COLESTEROL_HDL = "N009-MF000000254";
        public const string PL_COLESTEROL_HDL_DESEABLE = "N009-MF000000414";
        public const string PL_REL_COLESTEROL_HDL = "N009-MF000005085";
        public const string PL_REL_COLESTEROL_HDL_DESEABLE = "N009-MF000005086";
        public const string PL_COLESTEROL_LDL = "N009-MF000001073";
        public const string PL_COLESTEROL_LDL_DESEABLE = "N009-MF000001074";
        public const string PL_COLESTEROL_VLDL = "N009-MF000001075";
        public const string PL_COLESTEROL_VLDL_DESEABLE = "N009-MF000001076";
        public const string PL_TRIGLICERIDOS = "N009-MF000001906";     
        public const string PL_TRIGLICERIDOS_DESEABLE = "N009-MF000001907";
     
        public const string PL_observaciones= "N009-MF000005087";

        
        
        #endregion

        #region  PERFIL HEPATICO
        public const string PERFIL_HEPATICO_ID_LC = "N009-ME000000096";

        public const string PH_FOSFATASA_ALCALINA_VALOR = "N009-MF000001802";
        public const string PH_FOSFATASA_ALCALINA_DESEABLE = "N009-MF000001803";
        public const string PH_TGO_VALOR = "N009-MF000001798";
        public const string PH_TGO_DESEABLE = "N009-MF000001799";
        public const string PH_TGP_VALOR = "N009-MF000001800";
        public const string PH_TGP_DESEABLE = "N009-MF000001801";

        public const string PH_BILIRRUBINA_TOTAL_VALOR = "N009-MF000001806";
        public const string PH_BILIRRUBINA_TOTAL_DESEABLE = "N009-MF000001807";
        public const string PH_BILIRRUBINA_DIRECTA_VALOR = "N009-MF000001808";
        public const string PH_BILIRRUBINA_DIRECTA_DESEABLE = "N009-MF000001809";
        public const string PH_BILIRRUBINA_INDIRECTA_VALOR = "N009-MF000001810";
        public const string PH_BILIRRUBINA_INDIRECTA_DESEABLE = "N009-MF000001811";

        public const string PH_PROTEINAS_TOTALES_VALOR = "N009-MF000001792";
        public const string PH_PROTEINAS_TOTALES_DESEABLE = "N009-MF000001793";
        public const string PH_ALBUMINA_VALOR = "N009-MF000001794";
        public const string PH_ALBUMINA_DESEABLE = "N009-MF000001795";
        public const string PH_GLOBULINA_VALOR = "N009-MF000001796";
        public const string PH_GLOBULINA_DESEABLE = "N009-MF000001797";

        public const string PH_OBSERVACIONES = "N009-MF000001804";
        #endregion
        
        #region PERFIL RENAL - LAB

        public const string PERFIL_RENAL_ID = "N009-ME000001463";

        public const string PR_UREA = "N009-MF000005088";
        public const string PR_UREA_DESEABLE = "N009-MF000005089";
        public const string PR_CREATININA = "N009-MF000005090";
        public const string PR_CREATININA_DESEABLE = "N009-MF000005091";

        public const string PR_observaciones = "N009-MF000005092";



        #endregion

        #endregion

        #region HEMATOLOGIA

        #region GRUPO SANGUINEO Y FACTOR RH - LAB
        public const string GRUPO_SANGUINEO_Y_FACTOR_RH_ID = "N010-ME000000288";
        public const string GRUPO_SANGUINEO_VALOR = "N009-MF000005112";
        public const string FACTOR_RH_VALOR = "N009-MF000005113";
        #endregion
        #region PRUEBA CRUZADA - LAB

        public const string PRUEBA_CRUZADA_ID = "N009-ME000001465";
        public const string GRUPO_SANGUINEO_VALOR_PC = "N009-MF000005114";
        public const string FACTOR_RH_VALOR_PC = "N009-MF000005115";
        public const string COMPATIBILIDAD_VALOR_PC = "N009-MF000005116";

        #endregion

        #region HEMOGLOBINA  Y HEMATOCRITO- LAB
        public const string HEMOGLOBINA_HEMATOCRITO_ID = "N009-ME000000006";

        public const string HH_HEMOGLOBINA_VALOR = "N009-MF000000265";
        public const string HH_HEMOGLOBINA_VALOR_DESEABLE = "N009-MF000000420";
        public const string HH_HEMATOCRITO_VALOR = "N009-MF000005137";
        public const string HH_HEMATOCRITO_VALOR_DESEABLE = "N009-MF000005079";
        #endregion

        #region HEMOGRAMA AUTOMATIZADO - LAB
        public const string HEMOGRAMAA_ID = "N009-ME000000113";

        public const string HA_LEUCOCITOS_VALOR = "N009-MF000001890";
        public const string HA_LEUCOCITOS_VALOR_DESEABLE = "N009-MF000001891";

        public const string HA_LINFOCITOS_VALOR = "N009-MF000001892";
        public const string HA_LINFOCITOS_VALOR_DESEABLE = "N009-MF000001893";
        public const string HA_MONOCITOS_VALOR = "N009-MF000001902";
        public const string HA_MONOCITOS_VALOR_DESEABLE = "N009-MF000001903";
        public const string HA_ABASTONADOS_VALOR = "N009-MF000003207";
        public const string HA_ABASTONADOS_VALOR_DESEABLE = "N009-MF000003208";
        public const string HA_SEGMENTADOS_VALOR = "N009-MF000001898";
        public const string HA_SEGMENTADOS_VALOR_DESEABLE = "N009-MF000001899";
        public const string HA_EOSINOFILOS_VALOR = "N009-MF000001894";
        public const string HA_EOSINOFILOS_VALOR_DESEABLE = "N009-MF000001895";
        public const string HA_BASOFILOS_VALOR = "N009-MF000001900";
        public const string HA_BASOFILOS_VALOR_DESEABLE = "N009-MF000001901";

        public const string HA_LINFOCITOS_VALOR_3 = "N009-MF000005065";
        public const string HA_LINFOCITOS_VALOR_DESEABLE_3 = "N009-MF000005066";
        public const string HA_MONOCITOS_VALOR_3 = "N009-MF000005067";
        public const string HA_MONOCITOS_VALOR_DESEABLE_3 = "N009-MF000005068";
        public const string HA_ABASTONADOS_VALOR_3 = "N009-MF000005069";
        public const string HA_ABASTONADOS_VALOR_DESEABLE_3 = "N009-MF000005070";
        public const string HA_SEGMENTADOS_VALOR_3 = "N009-MF000005071";
        public const string HA_SEGMENTADOS_VALOR_DESEABLE_3 = "N009-MF000005072";
        public const string HA_EOSINOFILOS_VALOR_3 = "N009-MF000005073";
        public const string HA_EOSINOFILOS_VALOR_DESEABLE_3 = "N009-MF000005074";
        public const string HA_BASOFILOS_VALOR_3 = "N009-MF000005075";
        public const string HA_BASOFILOS_VALOR_DESEABLE_3 = "N009-MF000005076";


        public const string HA_HEMATIES_VALOR = "N009-MF000001878";
        public const string HA_HEMATIES_VALOR_DESEABLE = "N009-MF000001879";
        public const string HA_HEMOGLOBINA_VALOR = "N009-MF000001874";
        public const string HA_HEMOGLOBINA_VALOR_DESEABLE = "N009-MF000001875";
        public const string HA_HEMATOCRITO_VALOR = "N009-MF000001876";
        public const string HA_HEMATOCRITO_VALOR_DESEABLE = "N009-MF000001877";

        public const string HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR = "N009-MF000001880";
        public const string HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_DESEABLE = "N009-MF000001881";
        public const string HA_HB_CORPUSCULAR_MEDIO_VALOR = "N009-MF000001882";
        public const string HA_HB_CORPUSCULAR_MEDIO_VALOR_DESEABLE = "N009-MF000001883";
        public const string HA_CONCENTRACION_HB_CORPUSCULAR_VALOR = "N009-MF000001884";
        public const string HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_DESEABLE = "N009-MF000001885";
        public const string HA_RDW_VALOR = "N009-MF000005077";
        public const string HA_RDW_VALOR_DESEABLE = "N009-MF000005078";

        public const string HA_RECUENTO_PLAQUETAS_VALOR = "N009-MF000001886";
        public const string HA_RECUENTO_PLAQUETAS_VALOR_DESEABLE = "N009-MF000001887";
        public const string HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR = "N009-MF000003205";
        public const string HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_DESEABLE = "N009-MF000003206";
        public const string HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR = "N009-MF000001888";
        public const string HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_DESEABLE = "N009-MF000001889";
        public const string HA_PLAQUETOCRITO_VALOR = "N009-MF000001897";
        public const string HA_PLAQUETOCRITO_VALOR_DESEABLE = "N009-MF000001896";
        
        public const string HA_OTROS = "N009-MF000004441";
        #endregion


        #endregion

        #region URIANALISIS

        #region EXAMEN ORINA COMPLETO - LAB
        public const string EXAMEN_ORINA_COMPLETO_ID = "N009-ME000000046";

        public const string ECO_COLOR_CL = "N009-MF000000444";
        public const string ECO_ASPECTO_CL = "N009-MF000001041";
        public const string ECO_DENSIDAD_CL = "N009-MF000001043";
        public const string ECO_DENSIDAD_DESEABLE_CL = "N009-MF000003224";
        public const string ECO_REACCION_PH_CL = "N009-MF000001045";


        public const string ECO_PROTEINAS_CL = "N009-MF000001053";
        public const string ECO_GLUCOSA_CL = "N009-MF000001313";
        public const string ECO_CETONAS_CL = "N009-MF000001057";
        public const string ECO_BILIRRUBINAS_CL = "N009-MF000003439";
        public const string ECO_UROBILINOGENO_CL = "N009-MF000001049";
        public const string ECO_SANGRE_ORINA_CL = "N009-MF000001315";
        public const string ECO_NITRITOS_CL = "N009-MF000001055";
        public const string ECO_LEUCOCITOS_CL = "N009-MF000001061";
        public const string ECO_ACIDO_ASCORBICO_CL = "N009-MF000001071";

        public const string ECO_CELULAS_EPITELIALES_CL = "N009-MF000001059";
        public const string ECO_CELULAS_EPITELIALES_DESEADO_CL = "N009-MF000001065";
        public const string ECO_LEUCOCITOS_2_CL = "N009-MF000003438";
        public const string ECO_LEUCOCITOS_DESEADO_CL = "N009-MF000003242";
        public const string ECO_HEMATIES_CL = "N009-MF000001063";
        public const string ECO_HEMATIES_DESEADO_CL = "N009-MF000003244";
        public const string ECO_GERMENES_CL = "N009-MF000001067";
        public const string ECO_GERMENES_DESEADO_CL = "N009-MF000003243";
        public const string ECO_CILINDROS_CL = "N009-MF000001069";
        public const string ECO_CILINDROS_DESEADO_CL = "N009-MF000003245";
        public const string ECO_CRISTALES_CL = "N009-MF000003246";
        public const string ECO_CRISTALES_DESEADO_CL = "N009-MF000003247";
        public const string ECO_FILAMENTOS_MUCOIDES_CL = "N009-MF000003440";

        public const string ECO_RESULTADO_CL = "N009-MF000003210";

        #endregion

        #endregion

        #region MICROBIOLOGIA

        #region PARASITOLOGICO SERIADO
        public const string PARASITOLOGICO_SERIADO_LC = "N009-ME000000049";

        public const string PSER_COLOR_1 = "N009-MF000000515";
        public const string PSER_ASPECTO_1 = "N009-MF000005063";
        public const string PSER_CONSISTENCIA_1 = "N009-MF000001329";
        public const string PSER_RESULTADO_1 = "N009-MF000003261";

        public const string PSER_COLOR_2 = "N009-MF000001330";
        public const string PSER_ASPECTO_2 = "N009-MF000001340";
        public const string PSER_CONSISTENCIA_2 = "N009-MF000001345";
        public const string PSER_RESULTADO_2 = "N009-MF000003262";

        public const string PSER_COLOR_3 = "N009-MF000001346";
        public const string PSER_ASPECTO_3 = "N009-MF000003259";
        public const string PSER_CONSISTENCIA_3 = "N009-MF000003260";
        public const string PSER_RESULTADO_3 = "N009-MF000005064";
        #endregion

        #region PARASITOLOGICO SIMPLE
        public const string PARASITOLOGICO_SIMPLE_LC = "N002-ME000000016";

        public const string PSIM_COLOR_1 = "N009-MF000005130";
        public const string PSIM_ASPECTO_1 = "N009-MF000005131";
        public const string PSIM_CONSISTENCIA_1 = "N009-MF000005132";
        public const string PSIM_RESULTADO_1 = "N009-MF000005133";
        #endregion

        #region THEVENON SIMPLE - LAB
        public const string THEVENON_SIMPLE_ID = "N022-ME000000421";

        public const string T_SIMPLE = "N009-MF000005081";
       
        #endregion

        #region REACCION INFLAMATORIA - LAB
        public const string REACCION_INFLAMATORIA_ID_ = "N009-ME000001464";

        public const string RIN_COLOR = "N009-MF000005093";
        public const string RIN_CONSISTENCIA = "N009-MF000005094";
        public const string RIN_MOCO = "N009-MF000005095";
        public const string RIN_SANGRE = "N009-MF000005096";

        public const string RIN_HEMATIES= "N009-MF000005097";
        public const string RIN_HEMATIES_VD = "N009-MF000005098";

        public const string RIN_LEUCOCITOS = "N009-MF000005099";
        public const string RIN_LEUCOCITOS_VD = "N009-MF000005100";

        public const string RIN_MONONUCLEARES= "N009-MF000005101";
        public const string RIN_POLIMORFONUCLEAR = "N009-MF000005103";

        public const string RIN_OBSERVACIONES= "N009-MF000005104";
        #endregion

        #region KOH
        public const string KOH_ID = "N009-ME000001300";

        public const string KOH_VALOR = "N009-MF000005082";

        #endregion

        #region TEST DE GRAHAM - LAB
        public const string TEST_GRAHAM_ID = "N022-ME000000416";

        public const string TEST_GRAHAM_RESULTADO = "N009-MF000005127";
        public const string TEST_GRAHAM_OBS = "N009-MF000005128";

        #endregion

        #endregion


        #region INMUNOLOGIA

        #region SUBUNIDAD BETA HCG CUALITATIVO - LAB
        public const string BHCG_CUALITATIVO_ID = "N009-ME000000507";
        public const string BHCG_CUALITATIVO_VALOR = "N009-MF000005080";
        #endregion

        #region HEMOGLOBINA GLICOSILADA - LAB
        public const string HEMOGLOBINA_GLICOSILADA_ID_LC = "N010-ME000000381";
        public const string HEMOGLOBINA_GLICOSILADA_V = "N009-MF000005083";
        public const string HEMOGLOBINA_GLICOSILADA__VALOR_DESEABLE = "N009-MF000005084";
        #endregion

        #region AGLUTINACIONES - LAB
        public const string AGLUTINACIONES_LAMINA_LC = "N009-ME000001443";
        public const string AGLUTINACIONES_LAMINA_O = "N009-MF000005105";
        public const string AGLUTINACIONES_LAMINA_H = "N009-MF000005106";
        public const string AGLUTINACIONES_LAMINA_A = "N009-MF000005107";
        public const string AGLUTINACIONES_LAMINA_B = "N009-MF000005108";
        public const string AGLUTINACIONES_LAMINA_BRUCELLA = "N009-MF000005109";
        #endregion

        #region VDRL - LAB
        public const string VDRL_LC = "N010-ME000000309";
        public const string VDRL_VALOR_LC = "N009-MF000005110";
        #endregion

        #region PCR - PROTEINA C REACTIVA CUANTITATIVA
        public const string PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_ID = "N009-ME000001009";
        public const string PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR = "N009-MF000005111";
        #endregion



        #endregion


        #endregion



        public const string Select = "--Seleccionar--";
        public const string SelectValue = "-1";
        public const string All = "--Todos--";
        public const string AllValue = "-1";
        public const int WIDTH_MAX_SIZE_IMAGE = 4000;
        public const int HEIGHT_MAX_SIZE_IMAGE = 7000;
        public const int COLUMNAS_POR_CONTROL = 3;

        #region Controles

        public const string cbServiceType = "Tipo de Servicio";
        #endregion

          #region DECLARACION JURADA SINTOMATICO RESPIRATORIO
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_ID = "N009-ME000001137";

        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_TUBERCULOSIS = "N009-MF000004944";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_TOS_15_DIAS = "N009-MF000004945";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_BAJA_PESO = "N009-MF000004946";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_SUDORACION = "N009-MF000004947";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_EXPECTORACION = "N009-MF000004948";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_FAMILIA_TBC = "N009-MF000004949";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_CONTACTO_TBC = "N009-MF000004950";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_I_SOSPECHA_TBC = "N009-MF000004954";

        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_II_OBSERVACIONES = "N009-MF000004951";

        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_III_SINTOMATICO = "N009-MF000004955";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_III_BK_1 = "N009-MF000004952";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_III_BK_2 = "N009-MF000004953";
        public const string DECLARACION_JURADA_SINTOMATICO_RESPIRATORIO_III_TORAX = "N009-MF000004956";
        //public const string INFORME_RADIOLOGICO_DESCRIPCION = "N009-MF000004936";
        //public const string INFORME_RADIOLOGICO_CONCLUSIONES = "N009-MF000004937";


        #endregion

        #region AUTORIZACION LIBERACION - SAN MARTIN
        public const string AUTORIZACION_LIBERACION_SAN_MARTIN = "AUT_LIB_INF_SAN_MARTIN";
        #endregion

        #region
        public const string ACTA_DE_ENTREGA_Y_LECTURA_RESULTADOS_EMO = "N009-ME000001142";
        #endregion

        #region consentimiento coimolache
        public const string AUTORIZACION_REALIZACION_EXAMEN_MEDICO_LIBERACION_INFORMACION = "AUT_REAL_EX_MED_LIBER_INF";
        #endregion

        public const string AUTORIZACION_REALIZACION_EXAMEN_MEDICO_LIBERACION_INFORMACION_TODOS = "AUT_REAL_EX_MED_LIBER_INF_TODOS";


        #region consentimiento coimolache
        public const string CONSENTIMIENTO_INFORMADO_EXAMEN_MEDICO_COIMOLACHE = "C_I_EX_NED_COIMO";
        #endregion

        #region IDS LUMINA FICHA MEDICA - AUTORIZACION DE REALIZACION DE EXAMEN MEDICO Y LIBERACION DE INFORMACION MEDICA - LUMINA COPPER RESUMEN

        public const string FICHA_MEDICA_OCUPACIONAL = "FICH_MED_OCP";
        public const string AUTORIZACION_REALIZACION_EX_LIB_INF_MED = "AUT_REAL_EXM_LIB_INF_MED";
        public const string LUMINA_RESUMEN = "LUMINA_RESUMEN";
        #endregion
        #region INFORME RADIOLOGICO LUMINA
        public const string INFORME_RADIOLOGICO_ID = "N009-ME000000538";

        public const string INFORME_RADIOLOGICO_N_PLACA = "N009-MF000004938";
        public const string INFORME_RADIOLOGICO_DESCRIPCION = "N009-MF000004936";
        public const string INFORME_RADIOLOGICO_CONCLUSIONES = "N009-MF000004937";


        #endregion

        #region
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_ID = "N009-ME000000533";

        public const string FACTORES_PSICOSOCIALES_MI_BANCO_1_ESTADO = "N009-MF000004925";
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_1_PUNTAJE = "N009-MF000004926";

        public const string FACTORES_PSICOSOCIALES_MI_BANCO_2_ESTADO = "N009-MF000004927";
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_2_PUNTAJE = "N009-MF000004928";

        public const string FACTORES_PSICOSOCIALES_MI_BANCO_3_ESTADO = "N009-MF000004929";
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_3_PUNTAJE = "N009-MF000004930";

        public const string FACTORES_PSICOSOCIALES_MI_BANCO_4_ESTADO = "N009-MF000004931";
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_4_PUNTAJE = "N009-MF000004932";

        public const string FACTORES_PSICOSOCIALES_MI_BANCO_T_ESTADO = "N009-MF000004933";
        public const string FACTORES_PSICOSOCIALES_MI_BANCO_T_PUNTAJE = "N009-MF000004934";

        #endregion

        #region EXOGRAFIAS - JUAN PABLO
        /// <summary>
        /// IE OBSTETRICO
        /// </summary>
        public const string IE_OBSTETRICO_ID = "N007-ME000000471";
        public const string IE_OBSTETRICO_MOTIVO_EXAMEN = "N007-MF000004241";
        public const string IE_OBSTETRICO_FUR = "N007-MF000004233";

        public const string IE_OBSTETRICO_FETO_EMB_UNICO = "N007-MF000004234";	
        public const string IE_OBSTETRICO_FETO_EMB_MULTIPLE = "N007-MF000004235";
        public const string IE_OBSTETRICO_FETO_EMB_MULTIPLE_DESC = "N007-MF000004237";
        public const string IE_OBSTETRICO_FETO_EMB_LONGITUDINAL = "N007-MF000004238";
        public const string IE_OBSTETRICO_FETO_EMB_TRANSVERSAL = "N007-MF000004239";
        public const string IE_OBSTETRICO_FETO_EMB_OBLICUA = "N007-MF000004240";
        public const string IE_OBSTETRICO_FETO_EMB_OBLICUA_DESC = "N007-MF000004242";
        public const string IE_OBSTETRICO_FETO_EMB_CEFALICO = "N007-MF000004243";
        public const string IE_OBSTETRICO_FETO_EMB_PODALICO = "N007-MF000004244";
        public const string IE_OBSTETRICO_FETO_EMB_OTROS = "N007-MF000004245";
        public const string IE_OBSTETRICO_FETO_EMB_OTROS_DESC = "N007-MF000004246";
        public const string IE_OBSTETRICO_FETO_EMB_IZQUIERDA = "N007-MF000004247";
        public const string IE_OBSTETRICO_FETO_EMB_DERECHA = "N007-MF000004248";
        public const string IE_OBSTETRICO_FETO_EMB_ANTERIOR = "N007-MF000004249";
        public const string IE_OBSTETRICO_FETO_EMB_POSTERIOR = "N007-MF000004250";
        public const string IE_OBSTETRICO_FETO_EMB_DBP = "N007-MF000004251";
        public const string IE_OBSTETRICO_FETO_EMB_LF = "N007-MF000004252";
        public const string IE_OBSTETRICO_FETO_EMB_CA = "N007-MF000004253";
        public const string IE_OBSTETRICO_FETO_EMB_CC = "N007-MF000004254";
        public const string IE_OBSTETRICO_FETO_EMB_SG = "N007-MF000004255";
        public const string IE_OBSTETRICO_FETO_EMB_LCN = "N007-MF000004256";
        public const string IE_OBSTETRICO_FETO_EMB_COLUMNA_VERT = "N007-MF000004257";
        public const string IE_OBSTETRICO_FETO_EMB_CAMARA_GAST = "N007-MF000004258";
        public const string IE_OBSTETRICO_FETO_EMB_RIÑONES = "N007-MF000004259";
        public const string IE_OBSTETRICO_FETO_EMB_VEJIGA = "N007-MF000004260";
        public const string IE_OBSTETRICO_FETO_EMB_ACT_CARDIACA = "N007-MF000004261";
        public const string IE_OBSTETRICO_FETO_EMB_LCF = "N007-MF000004262";
        public const string IE_OBSTETRICO_FETO_EMB_OTRO = "N007-MF000004263";
        public const string IE_OBSTETRICO_FETO_EMB_OTRO_DESC = "N007-MF000004264";
        public const string IE_OBSTETRICO_FETO_EMB_MOV_FETALES = "N007-MF000004265";
        public const string IE_OBSTETRICO_FETO_EMB_OTRO_MOV = "N007-MF000004266";
        public const string IE_OBSTETRICO_FETO_EMB_OTRO_MOV_DESC = "N007-MF000004267";
        public const string IE_OBSTETRICO_FETO_EMB_DESCRIPCION = "N007-MF000004268";

        public const string IE_OBSTETRICO_PLACENTA_LOCALIZACION = "N007-MF000004269";
        public const string IE_OBSTETRICO_PLACENTA_OTROS = "N007-MF000004270";
        public const string IE_OBSTETRICO_PLACENTA_GRADO = "N007-MF000004271";
        public const string IE_OBSTETRICO_PLACENTA_ESP_PLACENTARIO = "N007-MF000004272";
        public const string IE_OBSTETRICO_PLACENTA_DESC_OTROS = "N007-MF000004273";

        public const string IE_OBSTETRICO_LIQ_AMNIOTICO_VOL = "N007-MF000004274";
        public const string IE_OBSTETRICO_LIQ_AMNIOTICO_ESTADO = "N007-MF000004275";
        public const string IE_OBSTETRICO_LIQ_AMNIOTICO_DESC_OTROS = "N007-MF000004276";

        public const string IE_OBSTETRICO_COR_UMBILICAL_CIRC_SI_NO = "N007-MF000004277";
        public const string IE_OBSTETRICO_COR_UMBILICAL_CIRC_SI_DESC = "N007-MF000004278";
        public const string IE_OBSTETRICO_COR_UMBILICAL_CIRC_ARTERIAS = "N007-MF000004279";
        public const string IE_OBSTETRICO_COR_UMBILICAL_CIRC_VENAS = "N007-MF000004280";
        public const string IE_OBSTETRICO_OBSERVACIONES = "N007-MF000004281";
        public const string IE_OBSTETRICO_CONCLUSIONES = "N007-MF000004282";

        /// <summary>
        /// IE GINECOLOGICO
        /// </summary>
        public const string IE_GINECOLOGICO_ID = "N007-ME000000472";

        public const string IE_GINECOLOGICO_MOT_EXAM = "N007-MF000004283";
        public const string IE_GINECOLOGICO_FUR = "N007-MF00000428";

        public const string IE_GINECOLOGICO_UTERO_POSICION = "N007-MF000004285";
        public const string IE_GINECOLOGICO_UTERO_CONTORNO = "N007-MF000004286";
        public const string IE_GINECOLOGICO_UTERO_ECOESTRUCTURA = "N007-MF000004287";
        public const string IE_GINECOLOGICO_UTERO_LONGITUDINAL = "N007-MF000004288";
        public const string IE_GINECOLOGICO_UTERO_TRANSVERSAL = "N007-MF000004289";
        public const string IE_GINECOLOGICO_UTERO_ANTERO_POST = "N007-MF000004290";
        public const string IE_GINECOLOGICO_UTERO_ENDOMETRIO = "N007-MF000004291”";
        public const string IE_GINECOLOGICO_UTERO_DESCRIPCION = "N007-MF000004292";

        public const string IE_GINECOLOGICO_ANEXO_DER_MEDIDAS = "N007-MF000004293";
        public const string IE_GINECOLOGICO_ANEXO_DER_MEDIDA_DESC = "N007-MF000004294";
        public const string IE_GINECOLOGICO_ANEXO_DER_MASAS_OVARICO = "N007-MF000004295";
        public const string IE_GINECOLOGICO_ANEXO_DER_DESC_OTROS = "N007-MF000004296";

        public const string IE_GINECOLOGICO_ANEXO_IZQ_MEDIDAS = "N007-MF000004297";
        public const string IE_GINECOLOGICO_ANEXO_IZQ_MEDIDA_DESC = "N007-MF000004298";
        public const string IE_GINECOLOGICO_ANEXO_IZQ_MASAS_OVARICO = "N007-MF000004299";
        public const string IE_GINECOLOGICO_ANEXO_IZQ_DESC_OTROS = "N007-MF000004300";

        public const string IE_GINECOLOGICO_SACO_DOUGLAS_LIQ_LIBRE = "N007-MF000004301";

        public const string IE_GINECOLOGICO_OBSERVACIONES = "N007-MF000004302";
        public const string IE_GINECOLOGICO_CONCLUSIONES = "N007-MF000004303";

        /// <summary>
        /// IE ABDOMINAL
        /// </summary>
        public const string IE_ADOMINAL_ID = "N007-ME000000473";
        public const string IEABDOMINAL_MOT_EXAM = "N007-MF000004304";

        public const string IE_ADOMINAL_HIGADO_MORF_MOVILIDAD = "N007-MF000004305";
        public const string IE_ADOMINAL_HIGADO_MORF_MOVILIDAD_DESC = "N007-MF000004306";
        public const string IE_ADOMINAL_HIGADO_BORDES = "N007-MF000004307";
        public const string IE_ADOMINAL_HIGADO_BORDES_DESC = "N007-MF000004308";
        public const string IE_ADOMINAL_HIGADO_DIMENSIONES = "N007-MF000004309";
        public const string IE_ADOMINAL_HIGADO_DIMENSIONES_DESC = "N007-MF000004310";
        public const string IE_ADOMINAL_HIGADO_PARENQUIMA = "N007-MF000004311";
        public const string IE_ADOMINAL_HIGADO_PARENQUIMA_DESC = "N007-MF000004312";
        public const string IE_ADOMINAL_HIGADO_ECOGENICIDAD = "N007-MF000004313";
        public const string IE_ADOMINAL_HIGADO_IMG_EXPANSIVAS = "N007-MF000004314";
        public const string IE_ADOMINAL_HIGADO_DIL_BILIARES = "N007-MF000004315";
        public const string IE_ADOMINAL_HIGADO_COLEDOCO = "N007-MF000004316";

        public const string IE_ADOMINAL_VESICULA_BIL_FORMA = "N007-MF000004317";
        public const string IE_ADOMINAL_VESICULA_BIL_OTROS = "N007-MF000004318";
        public const string IE_ADOMINAL_VESICULA_BIL_PAREDES = "N007-MF000004319";
        public const string IE_ADOMINAL_VESICULA_BIL_CONT_ANECOICO = "N007-MF000004320";
        public const string IE_ADOMINAL_VESICULA_BIL_BARRO_BILIAR = "N007-MF000004321";
        public const string IE_ADOMINAL_VESICULA_BIL_CALC_INTERIOR = "N007-MF000004322";
        public const string IE_ADOMINAL_VESICULA_BIL_CALC_INTERIOR_DESC = "N007-MF000004323";
        public const string IE_ADOMINAL_VESICULA_BIL_DIAMETRO_TRANSV = "N007-MF000004324";

        public const string IE_ADOMINAL_PANCREAS_MORF_ECOGENICIDAD = "N007-MF000004325";
        public const string IE_ADOMINAL_PANCREAS_ANORMAL = "N007-MF000004326";
        public const string IE_ADOMINAL_PANCREAS_MEDIDAS = "N007-MF000004327";
        public const string IE_ADOMINAL_PANCREAS_OTROS = "N007-MF000004328";
        public const string IE_ADOMINAL_PANCREAS_CABEZA = "N007-MF000004329";
        public const string IE_ADOMINAL_PANCREAS_CUELLO = "N007-MF000004330";
        public const string IE_ADOMINAL_PANCREAS_CUERPO = "N007-MF000004331";
        public const string IE_ADOMINAL_PANCREAS_COLA = "N007-MF000004332";

        public const string IE_ADOMINAL_BAZO_MORF_MOV_ECO = "N007-MF000004333";
        public const string IE_ADOMINAL_BAZO_DESCRIPCION = "N007-MF000004334";
        public const string IE_ADOMINAL_BAZO_MEDIDAS = "N007-MF000004335";
        public const string IE_ADOMINAL_BAZO_LONGITUD = "N007-MF000004336";

        public const string IE_ADOMINAL_AORTA_CAVA_PORTA_CALIBRES = "N007-MF000004337";
        public const string IE_ADOMINAL_AORTA_CAVA_PORTA_DESCRIPCION = "N007-MF000004338";

        public const string IE_ADOMINAL_LIQ_LIBRE_ABDOMINAL_SI_NO = "N007-MF000004339";
        public const string IE_ADOMINAL_LIQ_LIBRE_ABDOMINAL_SI_NO_DESC = "N007-MF000004440";

        public const string IE_ADOMINAL_OBSERVACIONES = "N007-MF000004340";
        public const string IE_ADOMINAL_CONCLUSIONES = "N007-MF000004341";
 
        /// <summary>
        /// IE RENAL
        /// </summary>
        public const string IE_RENAL_ID = "N007-ME000000474";
        public const string IE_RENAL_MOT_EXAM = "N007-MF000004342";

        public const string IE_RENAL_RIÑON_DER_MORF_MOV = "N007-MF000004343";
        public const string IE_RENAL_RIÑON_DER_MORF_MOV_DESC = "N007-MF000004344";
        public const string IE_RENAL_RIÑON_DER_ECOGENICIDAD = "N007-MF000004345";
        public const string IE_RENAL_RIÑON_DER_MEDIDA_LONG = "N007-MF000004347";
        public const string IE_RENAL_RIÑON_DER_MEDIDA_PARENQUIMA = "N007-MF000004348";
        public const string IE_RENAL_RIÑON_DER_SOLIDAS = "N007-MF000004349";
        public const string IE_RENAL_RIÑON_DER_QUISTICAS = "N007-MF00000435";
        public const string IE_RENAL_RIÑON_DER_HIDRONEFROSIS = "N007-MF000004351";
        public const string IE_RENAL_RIÑON_DER_HIDRONEFROSIS_SI_DESC = "N007-MF000004352";
        public const string IE_RENAL_RIÑON_DER_MICROLITIASES = "N007-MF000004353";
        public const string IE_RENAL_RIÑON_DER_CALCULOS = "N007-MF000004355";
        public const string IE_RENAL_RIÑON_DER_CALCULOS_SI_DESC = "N007-MF000004356";
        public const string IE_RENAL_RIÑON_DER_DESC_OTROS = "N007-MF000004357";

        public const string IE_RENAL_RIÑON_IZQ_MORF_MOV = "N007-MF000004358";
        public const string IE_RENAL_RIÑON_IZQ_MORF_MOV_DESC = "N007-MF000004359";
        public const string IE_RENAL_RIÑON_IZQ_ECOGENICIDAD = "N007-MF000004360";
        public const string IE_RENAL_RIÑON_IZQ_MEDIDA_LONG = "N007-MF000004361";
        public const string IE_RENAL_RIÑON_IZQ_MEDIDA_PARENQUIMA = "N007-MF000004362";
        public const string IE_RENAL_RIÑON_IZQ_SOLIDAS = "N007-MF000004363";
        public const string IE_RENAL_RIÑON_IZQ_QUISTICAS = "N007-MF000004364";
        public const string IE_RENAL_RIÑON_IZQ_HIDRONEFROSIS = "N007-MF000004365";
        public const string IE_RENAL_RIÑON_IZQ_HIDRONEFROSIS_SI_DESC = "N007-MF000004366";
        public const string IE_RENAL_RIÑON_IZQ_MICROLITIASES = "N007-MF000004367";
        public const string IE_RENAL_RIÑON_IZQ_CALCULOS = "N007-MF000004368";
        public const string IE_RENAL_RIÑON_IZQ_CALCULOS_SI_DESC = "N007-MF000004369";
        public const string IE_RENAL_RIÑON_IZQ_DESC_OTROS = "N007-MF000004370";

        public const string IE_RENAL_VEJIGA_REPLECION = "N007-MF000004371";
        public const string IE_RENAL_VEJIGA_PAREDES = "N007-MF000004372";
        public const string IE_RENAL_VEJIGA_CONT_ANECOICO = "N007-MF000004373";
        public const string IE_RENAL_VEJIGA_CONT_ANECOICO_DESC = "N007-MF000004374";
        public const string IE_RENAL_VEJIGA_IMG_EXPANSIVAS = "N007-MF000004375";
        public const string IE_RENAL_VEJIGA_IMG_EXPANSIVAS_DESC = "N007-MF000004376";
        public const string IE_RENAL_VEJIGA_CALCULOS_INTERIOR = "N007-MF000004377";
        public const string IE_RENAL_VEJIGA_CALCULOS_INTERIOR_DESC = "N007-MF000004378";
        public const string IE_RENAL_VEJIGA_VOL_PRE_MICCIONAL = "N007-MF000004379";
        public const string IE_RENAL_VEJIGA_POST_MICCIONAL = "N007-MF000004380";
        public const string IE_RENAL_VEJIGA_RETENCION = "N007-MF000004381";
        public const string IE_RENAL_VEJIGA_DESC_OTROS = "N007-MF000004382";

        public const string IE_RENAL_OBSERVACIONES = "N007-MF000004383";
        public const string IE_RENAL_CONCLUSIONES = "N007-MF000004384";
        
        /// <summary>
        /// IE MAMAS
        /// </summary>

        public const string IE_MAMAS_ID = "N007-ME000000475";
        public const string IE_MAMAS_MOT_EXAM = "N007-MF000004385";

        public const string IE_MAMAS_IZQ_TEJIDO_GLANDULAR = "N007-MF000004386";
        public const string IE_MAMAS_IZQ_BORDES = "N007-MF000004387";
        public const string IE_MAMAS_IZQ_ECOGENICIDAD = "N007-MF000004388";
        public const string IE_MAMAS_IZQ_TEJIDO_GRASO = "N007-MF000004389";
        public const string IE_MAMAS_IZQ_IMG_EXPANSIVAS = "N007-MF00000439";
        public const string IE_MAMAS_IZQ_PEZON = "N007-MF000004392";
        public const string IE_MAMAS_IZQ_PROFUNDIDAD = "N007-MF000004393";
        public const string IE_MAMAS_IZQ_DESC_OTROS = "N007-MF000004394";

        public const string IE_MAMAS_DER_TEJIDO_GLANDULAR = "N007-MF000004395";
        public const string IE_MAMAS_DER_BORDES = "N007-MF000004396";
        public const string IE_MAMAS_DER_ECOGENICIDAD = "N007-MF000004397";
        public const string IE_MAMAS_DER_TEJIDO_GRASO = "N007-MF000004398";
        public const string IE_MAMAS_DER_IMG_EXPANSIVAS = "N007-MF00000439";
        public const string IE_MAMAS_DER_PEZON = "N007-MF000004401";
        public const string IE_MAMAS_DER_PROFUNDIDAD = "N007-MF000004402";
        public const string IE_MAMAS_DER_DESC_OTROS = "N007-MF000004403";

        public const string IE_MAMAS_OBSERVACIONES = "N007-MF000004404";
        public const string IE_MAMAS_CONCLUSIONES = "N007-MF000004405";

        /// <summary>
        /// IE PROSTATA
        /// </summary>
        public const string IE_PROSTATA_ID = "N007-ME000000476";
        public const string IE_PROSTATA_MOT_EXAM = "N007-MF000004406";

        public const string IE_PROSTATA_VEJIGA_REPLECION = "N007-MF000004407";
        public const string IE_PROSTATA_VEJIGA_PAREDES = "N007-MF000004408";
        public const string IE_PROSTATA_VEJIGA_CONTENIDO_ANECOICO = "N007-MF000004409";
        public const string IE_PROSTATA_VEJIGA_CONTENIDO_ANECOICO_DESC = "N007-MF000004410";
        public const string IE_PROSTATA_VEJIGA_IMG_EXPANSIVAS = "N007-MF000004411";
        public const string IE_PROSTATA_VEJIGA_IMG_EXPANSIVAS_DESC = "N007-MF000004412";
        public const string IE_PROSTATA_VEJIGA_CALC_INTERIO = "N007-MF000004413";
        public const string IE_PROSTATA_VEJIGA_CALC_INTERIO_DESC = "N007-MF000004414";
        public const string IE_PROSTATA_VEJIGA_VOL_PRE_MICCIONAL = "N007-MF000004415";
        public const string IE_PROSTATA_VEJIGA_VOL_POST_MICCIONAL = "N007-MF000004416";
        public const string IE_PROSTATA_VEJIGA_VOL_RETENCIÓN = "N007-MF000004417";
        public const string IE_PROSTATA_VEJIGA_VOL_DESC_OTROS = "N007-MF000004418";

        public const string IE_PROSTATA_PROSTATA_BORDES = "N007-MF000004419";
        public const string IE_PROSTATA_PROSTATA_BORDES_DESC = "N007-MF000004420";
        public const string IE_PROSTATA_PROSTATA_TRANSVERSO = "N007-MF000004421";
        public const string IE_PROSTATA_PROSTATA_ANTERO_POSTERIOR = "N007-MF000004422";
        public const string IE_PROSTATA_PROSTATA_LONGITUDINAL = "N007-MF000004423";
        public const string IE_PROSTATA_PROSTATA_VOLUMEN = "N007-MF000004425";
        public const string IE_PROSTATA_PROSTATA_V_N = "N007-MF000004426";
        public const string IE_PROSTATA_PROSTATA_ECOESTRUCTURA = "N007-MF000004427";

        public const string IE_PROSTATA_OBSERVACIONES = "N007-MF000004428";
        public const string IE_PROSTATA_CONCLUSIONES = "N007-MF000004429";

        /// <summary>
        /// IE PARTES BLANDAS
        /// </summary>
        public const string IE_PARTES_BLANDAS_ID = "N007-ME000000477";

        public const string IE_PARTES_BLANDAS_MOT_EXAM = "N007-MF000004430";
        public const string IE_PARTES_BLANDAS_ESPECIFICACION = "N007-MF000004431";

        /// <summary>
        /// IE OBSTETRICO PELVICO
        /// </summary>
        public const string IE_OBSTETRICO_PELVICO_ID = "N007-ME000000478";
        public const string IE_OBSTETRICO_PELVICO_MOT_EXAM = "N007-MF000004432";
        public const string IE_OBSTETRICO_PELVICO_FUR = "N007-MF000004433";

        public const string IE_OBSTETRICO_PELVICO_EXAM_VEJIGA = "N007-MF000004434";
        public const string IE_OBSTETRICO_PELVICO_EXAM_UTERO = "N007-MF000004435";
        public const string IE_OBSTETRICO_PELVICO_EXAM_UTERO_CAVIDAD = "N007-MF000004436";
        public const string IE_OBSTETRICO_PELVICO_EXAM_ANEXOS_OVARIOS = "N007-MF000004437";
        public const string IE_OBSTETRICO_PELVICO_EXAM_SACO_DOUGLAS = "N007-MF000004438";
        public const string IE_OBSTETRICO_PELVICO_EXAM_CONCLUSION = "N007-MF000004439";

        #endregion
        #region SUFICIENCIA MEDICA BRIGADISTAS
        public const string SUF_MED_BRIGADISTAS_ID = "N009-ME000000487";

        public const string SUF_MED_BRIGADISTAS_AREA = "N009-MF000004324";

        public const string SUF_MED_BRIGADISTAS_PERSONAL_1 = "N009-MF000004325";
        public const string SUF_MED_BRIGADISTAS_PERSONAL_2 = "N009-MF000004326";
        public const string SUF_MED_BRIGADISTAS_PERSONAL_3 = "N009-MF000004327";
        public const string SUF_MED_BRIGADISTAS_PERSONAL_4 = "N009-MF000004328";

        public const string SUF_MED_BRIGADISTAS_FAMILIAR_1 = "N009-MF000004329";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_2 = "N009-MF000004330";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_3 = "N009-MF000004331";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_4 = "N009-MF000004332";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_5 = "N009-MF000004333";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_6 = "N009-MF000004334";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_7 = "N009-MF000004335";
        public const string SUF_MED_BRIGADISTAS_FAMILIAR_8 = "N009-MF000004336";

        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_1 = "N009-MF000004337";
        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_2 = "N009-MF000004338";
        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_3 = "N009-MF000004339";
        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_4 = "N009-MF000004340";
        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_5 = "N009-MF000004341";
        public const string SUF_MED_BRIGADISTAS_PSIQUIATRICOS_6 = "N009-MF000004342";

        public const string SUF_MED_BRIGADISTAS_OCUPACIONAL_1 = "N009-MF000004343";
        public const string SUF_MED_BRIGADISTAS_OCUPACIONAL_2 = "N009-MF000004344";
        public const string SUF_MED_BRIGADISTAS_OCUPACIONAL_3 = "N009-MF000004345";
        public const string SUF_MED_BRIGADISTAS_OCUPACIONAL_4 = "N009-MF000004346";

        public const string SUF_MED_BRIGADISTAS_PSICOLOGICO_1 = "N009-MF000004347";

        public const string SUF_MED_BRIGADISTAS_APTO_SI = "N009-MF000004348";
        public const string SUF_MED_BRIGADISTAS_APTO_NO = "N009-MF000004349";



        #endregion

        #region
        public const string ODONTO_SIMPLE_ID = "N009-ME000000472";
        public const string ODONTO_SIMPLE_PIEZAS_FALTANTES = "N009-MF000004323";
        public const string LABORATORIO_TGO_PIEZAS_MAL_ESTADO = "N009-MF000004322";
        #endregion

        #region TGO
        public const string LABORATORIO_TGO_ID = "N009-ME000000471";
        public const string LABORATORIO_TGO_VALOR = "N009-MF000004318";
        public const string LABORATORIO_TGO_VALORDESEABLE_VALOR = "N009-MF000004319";
        #endregion
        #region Declaracion Jurada SECURITAS
        public const string REGISTRO_ENTREGA_INFORME_RESULTADOS_BUENAVENTURA = "REGISTRO_ENTREGA_INFORME_BUENAVENTURA";
        #endregion

        #region TGP
        public const string LABORATORIO_TGP_ID = "N009-ME000000470";
        public const string LABORATORIO_TGP_VALOR = "N009-MF000004320";
        public const string LABORATORIO_TGP_VALORDESEABLE_VALOR = "N009-MF000004321";
        #endregion
        #region INFORME_PSICOLOGICO_RESUMEN_ID
        public const string INFORME_PSICOLOGICO_RESUMEN_ID = "N009-ME000000469";

        public const string INFORME_PSICOLOGICO_RESUMEN_EVALUACION = "N009-MF000004308";
        public const string INFORME_PSICOLOGICO_RESUMEN_PRUEBAS_APLICADAS = "N009-MF000004309";
        public const string INFORME_PSICOLOGICO_RESUMEN_RESULTADOS = "N009-MF000004310";
        public const string INFORME_PSICOLOGICO_RESUMEN_CONCLUSIONES = "N009-MF000004311";
        public const string INFORME_PSICOLOGICO_RESUMEN_APTO = "N009-MF000004312";
        public const string INFORME_PSICOLOGICO_RESUMEN_NOAPTO = "N009-MF000004313";
        public const string INFORME_PSICOLOGICO_RESUMEN_OBSERVADO = "N009-MF000004314";

        #endregion
        #region EVALUACION_OTEOMUSCULAR_GOLDFIELDS_ID
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_ID = "N009-ME000000468";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_2 = "N009-MF000004108";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_5 = "N009-MF000004111";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_6 = "N009-MF000004112";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_7 = "N009-MF000004113";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_8 = "N009-MF000004114";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_9 = "N009-MF000004115";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_10 = "N009-MF000004116";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_11 = "N009-MF000004117";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_12 = "N009-MF000004118";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_13 = "N009-MF000004119";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_14 = "N009-MF000004120";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_17 = "N009-MF000004123";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_18 = "N009-MF000004124";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_19 = "N009-MF000004125";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_20 = "N009-MF000004126";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_21 = "N009-MF000004127";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_TRABAJO_22 = "N009-MF000004128";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_CERVICAL_1 = "N009-MF000004133";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_CERVICAL_2 = "N009-MF000004134";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_CERVICAL_3 = "N009-MF000004135";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_CERVICAL_4 = "N009-MF000004136";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_DORSAL_1 = "N009-MF000004137";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_DORSAL_2 = "N009-MF000004138";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_DORSAL_3 = "N009-MF000004139";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_DORSAL_4 = "N009-MF000004140";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_LUMBAR_1 = "N009-MF000004141";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_LUMBAR_2 = "N009-MF000004142";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_LUMBAR_3 = "N009-MF000004143";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_CV_COLUMNA_LUMBAR_4 = "N009-MF000004144";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_1 = "N009-MF000004153";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_2 = "N009-MF000004154";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_3 = "N009-MF000004155";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_4 = "N009-MF000004156";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_5 = "N009-MF000004157";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_6 = "N009-MF000004158";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_7 = "N009-MF000004159";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_CERVICAL_8 = "N009-MF000004160";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_1 = "N009-MF000004161";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_2 = "N009-MF000004162";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_3 = "N009-MF000004163";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_4 = "N009-MF000004164";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_5 = "N009-MF000004165";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_6 = "N009-MF000004166";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_7 = "N009-MF000004167";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_DORSAL_8 = "N009-MF000004168";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_1 = "N009-MF000004169";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_2 = "N009-MF000004170";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_3 = "N009-MF000004171";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_4 = "N009-MF000004172";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_5 = "N009-MF000004173";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_6 = "N009-MF000004174";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_7 = "N009-MF000004175";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_COLUMNA_LUMBAR_8 = "N009-MF000004176";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_1 = "N009-MF000004185";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_2 = "N009-MF000004186";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_3 = "N009-MF000004187";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_4 = "N009-MF000004188";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_5 = "N009-MF000004189";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_6 = "N009-MF000004190";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_7 = "N009-MF000004191";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_DCH_8 = "N009-MF000004192";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_1 = "N009-MF000004193";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_2 = "N009-MF000004194";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_3 = "N009-MF000004195";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_4 = "N009-MF000004196";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_5 = "N009-MF000004197";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_6 = "N009-MF000004198";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_7 = "N009-MF000004199";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_HOMBRO_IZQ_8 = "N009-MF000004200";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_1 = "N009-MF000004200";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_2 = "N009-MF000004201";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_3 = "N009-MF000004202";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_4 = "N009-MF000004203";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_5 = "N009-MF000004204";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_6 = "N009-MF000004205";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_7 = "N009-MF000004207";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_DCH_8 = "N009-MF000004208";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_1 = "N009-MF000004209";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_2 = "N009-MF000004210";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_3 = "N009-MF000004211";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_4 = "N009-MF000004212";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_5 = "N009-MF000004213";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_6 = "N009-MF000004214";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_7 = "N009-MF000004215";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CODO_IZQ_8 = "N009-MF000004216";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_1 = "N009-MF000004217";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_2 = "N009-MF000004218";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_3 = "N009-MF000004219";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_4 = "N009-MF000004220";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_5 = "N009-MF000004221";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_6 = "N009-MF000004222";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_7 = "N009-MF000004223";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_DCH_8 = "N009-MF000004224";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_1 = "N009-MF000004225";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_2 = "N009-MF000004226";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_3 = "N009-MF000004227";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_4 = "N009-MF000004228";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_5 = "N009-MF000004229";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_6 = "N009-MF000004230";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_7 = "N009-MF000004231";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MUÑECA_IZQ_8 = "N009-MF000004232";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_1 = "N009-MF000004233";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_2 = "N009-MF000004234";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_3 = "N009-MF000004235";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_4 = "N009-MF000004236";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_5 = "N009-MF000004237";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_6 = "N009-MF000004238";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_7 = "N009-MF000004239";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_DCH_8 = "N009-MF000004240";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_1 = "N009-MF000004241";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_2 = "N009-MF000004242";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_3 = "N009-MF000004243";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_4 = "N009-MF000004244";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_5 = "N009-MF000004245";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_6 = "N009-MF000004246";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_7 = "N009-MF000004247";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_MANO_IZQ_8 = "N009-MF000004248";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_1 = "N009-MF000004249";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_2 = "N009-MF000004250";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_3 = "N009-MF000004251";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_4 = "N009-MF000004252";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_5 = "N009-MF000004253";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_6 = "N009-MF000004254";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_7 = "N009-MF000004255";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_DCH_8 = "N009-MF000004256";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_1 = "N009-MF000004257";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_2 = "N009-MF000004258";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_3 = "N009-MF000004259";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_4 = "N009-MF000004260";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_5 = "N009-MF000004261";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_6 = "N009-MF000004262";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_7 = "N009-MF000004263";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_CADERA_IZQ_8 = "N009-MF000004264";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_1 = "N009-MF000004265";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_2 = "N009-MF000004266";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_3 = "N009-MF000004267";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_4 = "N009-MF000004268";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_5 = "N009-MF000004269";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_6 = "N009-MF000004270";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_7 = "N009-MF000004271";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_DCH_8 = "N009-MF000004272";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_1 = "N009-MF000004273";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_2 = "N009-MF000004274";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_3 = "N009-MF000004275";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_4 = "N009-MF000004276";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_5 = "N009-MF000004277";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_6 = "N009-MF000004278";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_7 = "N009-MF000004279";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_RODILLA_IZQ_8 = "N009-MF000004280";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_1 = "N009-MF000004281";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_2 = "N009-MF000004282";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_3 = "N009-MF000004283";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_4 = "N009-MF000004284";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_5 = "N009-MF000004285";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_6 = "N009-MF000004286";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_7 = "N009-MF000004287";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_DCH_8 = "N009-MF000004288";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_1 = "N009-MF000004289";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_2 = "N009-MF000004290";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_3 = "N009-MF000004291";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_4 = "N009-MF000004292";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_5 = "N009-MF000004293";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_6 = "N009-MF000004294";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_7 = "N009-MF000004295";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_MD_TOBILLO_IZQ_8 = "N009-MF000004296";

        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_DESC_HALLAZGOS= "N009-MF000004297";
        public const string EVALUACION_OTEOMUSCULAR_GOLDFIELDS_APTITUD = "N009-MF000004298";


        #endregion

        #region EVALUACION OSTEOMUSCULAR - MI BANCO
        public const string OSTEO_MB_ID = "N009-ME000000531";

        public const string OSTEO_MB_TRABAJO_AREA = "N009-MF000004672";
        public const string OSTEO_MB_TRABAJO_MANIPULACCION = "N009-MF000004673";
        public const string OSTEO_MB_TRABAJO_POSTURA_SENTADO = "N009-MF000004674";
        public const string OSTEO_MB_TRABAJO_POSTURA_PIE = "N009-MF000004675";
        public const string OSTEO_MB_TRABAJO_MOVIMIENTO_CABEZA = "N009-MF000004676";
        public const string OSTEO_MB_TRABAJO_MOVIMIENTO_TRONCO = "N009-MF000004677";
        public const string OSTEO_MB_TRABAJO_MOVIMIENTO_MMSS = "N009-MF000004678";
        public const string OSTEO_MB_TRABAJO_MOVIMIENTO_MMII = "N009-MF000004679";
        public const string OSTEO_MB_TRABAJO_PERIODO = "N009-MF000004680";

        public const string OSTEO_MB_CUESTIONARIO_P1_1 = "N009-MF000004682";
        public const string OSTEO_MB_CUESTIONARIO_P1_2 = "N009-MF000004684";
        public const string OSTEO_MB_CUESTIONARIO_P1_3 = "N009-MF000004685";
        public const string OSTEO_MB_CUESTIONARIO_P1_4 = "N009-MF000004686";
        public const string OSTEO_MB_CUESTIONARIO_P1_5 = "N009-MF000004687";
        public const string OSTEO_MB_CUESTIONARIO_P1_6 = "N009-MF000004688";
        public const string OSTEO_MB_CUESTIONARIO_P1_7 = "N009-MF000004689";
        public const string OSTEO_MB_CUESTIONARIO_P1_8 = "N009-MF000004690";
        public const string OSTEO_MB_CUESTIONARIO_P1_9 = "N009-MF000004691";
        public const string OSTEO_MB_CUESTIONARIO_P1_10 = "N009-MF000004692";
        public const string OSTEO_MB_CUESTIONARIO_P1_11 = "N009-MF000004693";
        public const string OSTEO_MB_CUESTIONARIO_P1_12 = "N009-MF000004694";
        public const string OSTEO_MB_CUESTIONARIO_P1_13 = "N009-MF000004695";
        public const string OSTEO_MB_CUESTIONARIO_P1_14 = "N009-MF000004696";
        public const string OSTEO_MB_CUESTIONARIO_P1_15 = "N009-MF000004697";

        public const string OSTEO_MB_CUESTIONARIO_P2_1 = "N009-MF000004698";
        public const string OSTEO_MB_CUESTIONARIO_P2_2 = "N009-MF000004700";
        public const string OSTEO_MB_CUESTIONARIO_P2_3 = "N009-MF000004701";
        public const string OSTEO_MB_CUESTIONARIO_P2_4 = "N009-MF000004702";
        public const string OSTEO_MB_CUESTIONARIO_P2_5 = "N009-MF000004703";
        public const string OSTEO_MB_CUESTIONARIO_P2_6 = "N009-MF000004704";
        public const string OSTEO_MB_CUESTIONARIO_P2_7 = "N009-MF000004705";
        public const string OSTEO_MB_CUESTIONARIO_P2_8 = "N009-MF000004706";
        public const string OSTEO_MB_CUESTIONARIO_P2_9 = "N009-MF000004707";
        public const string OSTEO_MB_CUESTIONARIO_P2_10 = "N009-MF000004708";
        public const string OSTEO_MB_CUESTIONARIO_P2_11 = "N009-MF000004709";
        public const string OSTEO_MB_CUESTIONARIO_P2_12 = "N009-MF000004710";
        public const string OSTEO_MB_CUESTIONARIO_P2_13 = "N009-MF000004711";
        public const string OSTEO_MB_CUESTIONARIO_P2_14 = "N009-MF000004712";
        public const string OSTEO_MB_CUESTIONARIO_P2_15 = "N009-MF000004713";

        public const string OSTEO_MB_CUESTIONARIO_P3_1 = "N009-MF000004714";
        public const string OSTEO_MB_CUESTIONARIO_P3_2 = "N009-MF000004716";
        public const string OSTEO_MB_CUESTIONARIO_P3_3 = "N009-MF000004717";
        public const string OSTEO_MB_CUESTIONARIO_P3_4 = "N009-MF000004718";
        public const string OSTEO_MB_CUESTIONARIO_P3_5 = "N009-MF000004719";
        public const string OSTEO_MB_CUESTIONARIO_P3_6 = "N009-MF000004720";
        public const string OSTEO_MB_CUESTIONARIO_P3_7 = "N009-MF000004721";
        public const string OSTEO_MB_CUESTIONARIO_P3_8 = "N009-MF000004722";
        public const string OSTEO_MB_CUESTIONARIO_P3_9 = "N009-MF000004723";
        public const string OSTEO_MB_CUESTIONARIO_P3_10 = "N009-MF000004724";
        public const string OSTEO_MB_CUESTIONARIO_P3_11 = "N009-MF000004725";
        public const string OSTEO_MB_CUESTIONARIO_P3_12 = "N009-MF000004726";
        public const string OSTEO_MB_CUESTIONARIO_P3_13 = "N009-MF000004727";
        public const string OSTEO_MB_CUESTIONARIO_P3_14 = "N009-MF000004728";
        public const string OSTEO_MB_CUESTIONARIO_P3_15 = "N009-MF000004729";

        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_1 = "N009-MF000004740";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_2 = "N009-MF000004741";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_3 = "N009-MF000004742";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_4 = "N009-MF000004743";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_5 = "N009-MF000004744";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_6 = "N009-MF000004745";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_7 = "N009-MF000004746";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_8 = "N009-MF000004747";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_D_9 = "N009-MF000004748";

        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_1 = "N009-MF000004749";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_2 = "N009-MF000004750";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_3 = "N009-MF000004751";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_4 = "N009-MF000004752";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_5 = "N009-MF000004753";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_6 = "N009-MF000004754";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_7 = "N009-MF000004755";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_8 = "N009-MF000004756";
        public const string OSTEO_MB_ARTICULACIONES_HOMBRO_I_9 = "N009-MF000004757";

        public const string OSTEO_MB_ARTICULACIONES_CODO_D_1 = "N009-MF000004758";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_2 = "N009-MF000004759";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_3 = "N009-MF000004760";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_4 = "N009-MF000004761";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_5 = "N009-MF000004762";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_6 = "N009-MF000004763";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_7 = "N009-MF000004764";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_8 = "N009-MF000004765";
        public const string OSTEO_MB_ARTICULACIONES_CODO_D_9 = "N009-MF000004766";

        public const string OSTEO_MB_ARTICULACIONES_CODO_I_1 = "N009-MF000004767";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_2 = "N009-MF000004768";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_3 = "N009-MF000004769";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_4 = "N009-MF000004770";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_5 = "N009-MF000004771";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_6 = "N009-MF000004772";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_7 = "N009-MF000004773";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_8 = "N009-MF000004774";
        public const string OSTEO_MB_ARTICULACIONES_CODO_I_9 = "N009-MF000004775";

        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_1 = "N009-MF000004776";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_2 = "N009-MF000004777";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_3 = "N009-MF000004778";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_4 = "N009-MF000004779";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_5 = "N009-MF000004780";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_6 = "N009-MF000004781";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_7 = "N009-MF000004782";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_8 = "N009-MF000004783";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_D_9 = "N009-MF000004784";

        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_1 = "N009-MF000004785";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_2 = "N009-MF000004786";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_3 = "N009-MF000004787";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_4 = "N009-MF000004788";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_5 = "N009-MF000004789";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_6 = "N009-MF000004790";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_7 = "N009-MF000004791";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_8 = "N009-MF000004792";
        public const string OSTEO_MB_ARTICULACIONES_MUÑECA_I_9 = "N009-MF000004793";
        
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_1 = "N009-MF000004794";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_2 = "N009-MF000004795";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_3 = "N009-MF000004796";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_4 = "N009-MF000004797";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_5 = "N009-MF000004798";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_6 = "N009-MF000004799";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_7 = "N009-MF000004800";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_8 = "N009-MF000004801";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_D_9 = "N009-MF000004802";

        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_1 = "N009-MF000004803";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_2 = "N009-MF000004804";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_3 = "N009-MF000004805";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_4 = "N009-MF000004806";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_5 = "N009-MF000004807";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_6 = "N009-MF000004808";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_7 = "N009-MF000004809";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_8 = "N009-MF000004810";
        public const string OSTEO_MB_ARTICULACIONES_MANO_DEDOS_I_9 = "N009-MF000004811";

        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_1 = "N009-MF000004812";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_2 = "N009-MF000004813";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_3 = "N009-MF000004814";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_4 = "N009-MF000004815";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_5 = "N009-MF000004816";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_6 = "N009-MF000004817";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_7 = "N009-MF000004818";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_8 = "N009-MF000004819";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_D_9 = "N009-MF000004820";

        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_1 = "N009-MF000004821";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_2 = "N009-MF000004822";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_3 = "N009-MF000004823";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_4 = "N009-MF000004824";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_5 = "N009-MF000004825";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_6 = "N009-MF000004826";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_7 = "N009-MF000004827";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_8 = "N009-MF000004828";
        public const string OSTEO_MB_ARTICULACIONES_CADERA_I_9 = "N009-MF000004829";

        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_1 = "N009-MF000004830";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_2 = "N009-MF000004831";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_3 = "N009-MF000004832";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_4 = "N009-MF000004833";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_5 = "N009-MF000004834";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_6 = "N009-MF000004835";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_7 = "N009-MF000004836";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_8 = "N009-MF000004837";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_D_9 = "N009-MF000004838";

        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_1 = "N009-MF000004839";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_2 = "N009-MF000004840";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_3 = "N009-MF000004841";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_4 = "N009-MF000004842";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_5 = "N009-MF000004843";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_6 = "N009-MF000004844";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_7 = "N009-MF000004845";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_8 = "N009-MF000004846";
        public const string OSTEO_MB_ARTICULACIONES_RODILLA_I_9 = "N009-MF000004847";

        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_1 = "N009-MF000004848";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_2 = "N009-MF000004849";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_3 = "N009-MF000004850";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_4 = "N009-MF000004851";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_5 = "N009-MF000004852";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_6 = "N009-MF000004853";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_7 = "N009-MF000004854";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_8 = "N009-MF000004855";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_D_9 = "N009-MF000004856";

        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_1 = "N009-MF000004857";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_2 = "N009-MF000004858";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_3 = "N009-MF000004859";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_4 = "N009-MF000004860";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_5 = "N009-MF000004861";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_6 = "N009-MF000004862";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_7 = "N009-MF000004863";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_8 = "N009-MF000004864";
        public const string OSTEO_MB_ARTICULACIONES_TOBILLO_I_9 = "N009-MF000004865";

        public const string OSTEO_MB_TEST_PHALEN_D = "N009-MF000004871";
        public const string OSTEO_MB_TEST_PHALEN_I = "N009-MF000004872";

        public const string OSTEO_MB_TEST_TINEL_D = "N009-MF000004873";
        public const string OSTEO_MB_TEST_TINEL_I = "N009-MF000004874";

        public const string OSTEO_MB_TEST_FINKELSTEIN_D = "N009-MF000004875";
        public const string OSTEO_MB_TEST_FINKELSTEIN_I = "N009-MF000004876";

        public const string OSTEO_MB_TEST_NEER_D = "N009-MF000004877";
        public const string OSTEO_MB_TEST_NEER_I = "N009-MF000004878";

        public const string OSTEO_MB_TEST_BRAZO_CAIDO_D = "N009-MF000004879";
        public const string OSTEO_MB_TEST_BRAZO_CAIDO_I = "N009-MF000004880";

        public const string OSTEO_MB_SIMETRIA_MMSS_1 = "N009-MF000004881";
        public const string OSTEO_MB_SIMETRIA_MMSS_2 = "N009-MF000004882";

        public const string OSTEO_MB_SIMETRIA_MMI_1 = "N009-MF000004883";
        public const string OSTEO_MB_SIMETRIA_MMI_2 = "N009-MF000004884";

        public const string OSTEO_MB_CV_INSPECCION_EJE_ANTERO_CERVICAL = "N009-MF000004885";
        public const string OSTEO_MB_CV_INSPECCION_EJE_ANTERO_DORSAL = "N009-MF000004886";
        public const string OSTEO_MB_CV_INSPECCION_EJE_ANTERO_LUMBAR = "N009-MF000004887";

        public const string OSTEO_MB_CV_INSPECCION_EJE_LATERAL_DORSAL = "N009-MF000004888";
        public const string OSTEO_MB_CV_INSPECCION_EJE_LATERAL_LUMBAR = "N009-MF000004889";

        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_1 = "N009-MF000004898";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_2 = "N009-MF000004899";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_3 = "N009-MF000004900";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_4 = "N009-MF000004901";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_5 = "N009-MF000004902";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_6 = "N009-MF000004903";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_7 = "N009-MF000004904";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_CERVICAL_8 = "N009-MF000004905";

        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_1 = "N009-MF000004906";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_2 = "N009-MF000004907";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_3 = "N009-MF000004908";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_4 = "N009-MF000004909";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_5 = "N009-MF000004910";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_6 = "N009-MF000004911";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_7 = "N009-MF000004912";
        public const string OSTEO_MB_CV_EX_F_MOV_DOLOR_LUMBAR_8 = "N009-MF000004913";

        public const string OSTEO_MB_CV_EX_F_TEST_LASEGUE_D = "N009-MF000004914";
        public const string OSTEO_MB_CV_EX_F_TEST_LASEGUE_I = "N009-MF000004915";
        public const string OSTEO_MB_CV_EX_F_TEST_SCHOBER = "N009-MF000004916";

        public const string OSTEO_MB_CV_EX_F_PALPACION_CERVICAL = "N009-MF000004917"; 
        public const string OSTEO_MB_CV_EX_F_PALPACION_DORSAL = "N009-MF000004918";
        public const string OSTEO_MB_CV_EX_F_PALPACION_LUMBAR = "N009-MF000004919";

        public const string OSTEO_MB_COMENTARIOS_OBSERVACIONES = "N009-MF000004920";

        #endregion


        #region EXAMEN MEDICO PARA TRABAJOS EN ALTURA MAYOR A 1.8 Mts - FORMATO YANACOCHA
        public const string T_A_1_8_ID = "N009-ME000000530";

        public const string T_A_1_8_I_ANTECEDENTES = "N009-MF000004634";

        public const string T_A_1_8_II_AGOROFOBIA = "N009-MF000004635";
        public const string T_A_1_8_II_CONVULSIONES = "N009-MF000004636";
        public const string T_A_1_8_II_HTA = "N009-MF000004637";
        public const string T_A_1_8_II_ACROFOBIA = "N009-MF000004638";
        public const string T_A_1_8_II_CEFALEA = "N009-MF000004639";
        public const string T_A_1_8_II_ASMA = "N009-MF000004640";
        public const string T_A_1_8_II_MAREOS = "N009-MF000004641";
        public const string T_A_1_8_II_ALCOHOL = "N009-MF000004642";
        public const string T_A_1_8_II_DIABETES = "N009-MF000004643";
        public const string T_A_1_8_II_VERTIGO = "N009-MF000004644";
        public const string T_A_1_8_II_DROGAS = "N009-MF000004645";
        public const string T_A_1_8_II_TEC = "N009-MF000004646";
        public const string T_A_1_8_II_MIOCLONIAS = "N009-MF000004647";
        public const string T_A_1_8_II_PSIQUIATRIA = "N009-MF000004648";
        public const string T_A_1_8_II_FARMACOS = "N009-MF000004679";
        public const string T_A_1_8_II_ACATISIA = "N009-MF000004650";
        public const string T_A_1_8_II_CARDIO = "N009-MF000004651";

        public const string T_A_1_8_III_ENTRENAMIENTO_ALTURA = "N009-MF000004652";
        public const string T_A_1_8_III_ENTRENAMIENTO_PRIMEROS_AUXILIOS = "N009-MF000004653";

        public const string T_A_1_8_IV_IMC = "N009-MF000004654";
        public const string T_A_1_8_IV_DEFICIT_M_SUPERIORES = "N009-MF000004655";
        public const string T_A_1_8_IV_DEFICIT_M_INFERIORES = "N009-MF000004656";
        public const string T_A_1_8_IV_TIMPANOS = "N009-MF000004657";
        public const string T_A_1_8_IV_HIPOACUSIA = "N009-MF000004658";
        public const string T_A_1_8_IV_SUSTENTACION_PIE_15S = "N009-MF000004659";
        public const string T_A_1_8_IV_CAMINAR_LIBRE_3M = "N009-MF000004660";
        public const string T_A_1_8_IV_CAMINAR_LIBRE_OJOS_VENDADOS_3M = "N009-MF000004661";
        public const string T_A_1_8_IV_CAMINAR_LIBRE_OJOS_VENDADOS_PUNTA_TALON_3M = "N009-MF000004662";
        public const string T_A_1_8_IV_NISTAGMUS = "N009-MF000004663";
        public const string T_A_1_8_IV_ROMBERG = "N009-MF000004664";
        public const string T_A_1_8_IV_ADIADOCOQUINESIA_DIRECTA = "N009-MF000004665";
        public const string T_A_1_8_IV_ADIADOCOQUINESIA_CRUZADA = "N009-MF000004666";
        public const string T_A_1_8_IV_COMENTARIO = "N009-MF000004667";

        public const string T_A_1_8_V_APTO = "N009-MF000004668";
        public const string T_A_1_8_V_NO_APTO = "N009-MF000004669";

        #endregion

        #region ACCIDENTES DE TRABAJO - F1 - NOTIFICACIÓN DE LOS ACCIDENTES DE TRABAJO MORTALES E INCIDENTES PELIGROSOS
        public const string ACCIDENTES_DE_TRABAJO_F1 = "N009-ME000000527";

        public const string F1_I_AÑO = "N009-MF000004461";
        public const string F1_I_MES = "N009-MF000004462";
        public const string F1_I_ACCIDENTE_NO_MORTAL = "N009-MF000004463";
        public const string F1_I_INCIDENTE_PELIGROSO = "N009-MF000004464";
        public const string F1_I_FECHA_PRES = "N009-MF000004465";

        //
        public const string F1_II_1_RUC = "N009-MF000004466";
        public const string F1_II_1_DENOMINACION_SOCIAL = "N009-MF000004467";

        public const string F1_II_2_NOMBRE_CONCESIONARIA_MINERA = "N009-MF000004468";
        public const string F1_II_2_CODIGO_CONCESIONARIA_MINERA = "N009-MF000004469";

        public const string F1_II_3_CODIGO_OSINERMING = "N009-MF000004470";
        public const string F1_II_3_REGISTRO_DGH = "N009-MF000004471";

        public const string F1_II_4_TAMAÑO_EMPRESA = "N009-MF000004472";
        public const string F1_II_4_DOMICILIO_PRINCIPAL = "N009-MF000004473";
        public const string F1_II_4_DEPARTAMENTO = "N009-MF000004474";
        public const string F1_II_4_PROVINCIA = "N009-MF000004475";
        public const string F1_II_4_DISTRITO = "N009-MF000004476";
        public const string F1_II_4_UBIGEO = "N009-MF000004477";
        public const string F1_II_4_ACTIVIDAD_ECONOMICA_P = "N009-MF000004478";
        public const string F1_II_4_CIIU = "N009-MF000004479";
        public const string F1_II_4_ER = "N009-MF000004480";
        public const string F1_II_4_N_HOMBRES = "N009-MF000004482";
        public const string F1_II_4_N_MUJERES = "N009-MF000004483";
        public const string F1_II_4_CODIGO_TELEFONO = "N009-MF000004484";

        //
        public const string F1_III_1_RUC = "N009-MF000004485";
        public const string F1_III_1_DENOMINACION_SOCIAL = "N009-MF000004486";

        public const string F1_III_2_NOMBRE_CONCESIONARIA_MINERA = "N009-MF000004487";
        public const string F1_III_2_CODIGO_CONCESIONARIA_MINERA = "N009-MF000004488";

        public const string F1_III_3_CODIGO_OSINERMING = "N009-MF000004489";
        public const string F1_III_3_REGISTRO_DGH = "N009-MF000004490";

        public const string F1_III_4_TAMAÑO_EMPRESA = "N009-MF000004491";
        public const string F1_III_4_DOMICILIO_PRINCIPAL = "N009-MF000004492";
        public const string F1_III_4_DEPARTAMENTO = "N009-MF000004493";
        public const string F1_III_4_PROVINCIA = "N009-MF000004494";
        public const string F1_III_4_DISTRITO = "N009-MF000004495";
        public const string F1_III_4_UBIGEO = "N009-MF000004496";
        public const string F1_III_4_ACTIVIDAD_ECONOMICA_P = "N009-MF000004497";
        public const string F1_III_4_CIIU = "N009-MF000004498";
        public const string F1_III_4_ER = "N009-MF000004499";
        public const string F1_III_4_N_HOMBRES = "N009-MF000004501";
        public const string F1_III_4_N_MUJERES = "N009-MF000004502";
        public const string F1_III_4_CODIGO_TELEFONO = "N009-MF000004503";

        public const string F1_IV_DNI_CE = "N009-MF000004504";
        public const string F1_IV_APELLIDOS = "N009-MF000004505";
        public const string F1_IV_NOMBRES = "N009-MF000004506";
        public const string F1_IV_DOMICILIO = "N009-MF000004507";
        public const string F1_IV_DEPARTAMENTO = "N009-MF000004508";
        public const string F1_IV_PROVINCIA = "N009-MF000004509";
        public const string F1_IV_DISTRITO = "N009-MF000004510";
        public const string F1_IV_UBIGEO = "N009-MF000004511";
        public const string F1_IV_CODIGO_TELEFONO = "N009-MF000004512";
        public const string F1_IV_CATEGORIA_OCUPACIONAL = "N009-MF000004513";
        public const string F1_IV_ASEGURADO = "N009-MF000004514";
        public const string F1_IV_ESSALUD = "N009-MF000004516";
        public const string F1_IV_EPS = "N009-MF000004517";
        public const string F1_IV_EDAD = "N009-MF000004518";
        public const string F1_IV_SCTR = "N009-MF000004519";
        public const string F1_IV_FECHA_ACCIDENTE = "N009-MF000004520";
        public const string F1_IV_HORA_ACCIDENTE = "N009-MF000004521";
        public const string F1_IV_LUGAR_ACCIDENTE = "N009-MF000004522";
        public const string F1_IV_GENERO = "N009-MF000004523";

        public const string F1_IV_1_TIPO_ACCIDENTE_1 = "N009-MF000004524";
        public const string F1_IV_1_TIPO_ACCIDENTE_2 = "N009-MF000004525";
        public const string F1_IV_1_AGENTE_CAUSANTE_1 = "N009-MF000004526";
        public const string F1_IV_1_AGENTE_CAUSANTE_2 = "N009-MF000004527";
        public const string F1_IV_1_AGENTE_CAUSANTE_3 = "N009-MF000004528";
        public const string F1_IV_1_DESCRIPCION_ACCIDENTE = "N009-MF000004529";

        public const string F1_V_FECHA = "N009-MF000004530";
        public const string F1_V_HORA_ACCIDENTE = "N009-MF000004531";
        public const string F1_V_TIPO_INCIDENTE = "N009-MF000004532";
        public const string F1_V_DESCRIPCION_INCIDENTE = "N009-MF000004533";
        public const string F1_V_DAÑOS_MATERIALES = "N009-MF000004535";
        public const string F1_V_CUANTIFICACION_PRELIMINAR = "N009-MF000004536";
        #endregion

        #region ACCIDENTES DE TRABAJO - F2 - NOTIFICACIÓN DE LOS ACCIDENTES DE TRABAJO NO MORTALES Y ENFERMEDADES OCUPACIONALES
        public const string ACCIDENTES_DE_TRABAJO_F2 = "N009-ME000000528";

        public const string F2_I_AÑO = "N009-MF000004537";
        public const string F2_I_MES = "N009-MF000004538";
        public const string F2_I_ACCIDENTE_NO_MORTAL = "N009-MF000004539";
        public const string F2_I_ENFERMEDADES_OCUPACIONALES = "N009-MF000004540";
        public const string F2_I_FECHA_PRES = "N009-MF000004541";

        //
        public const string F2_II_1_RUC = "N009-MF000004542";
        public const string F2_II_1_DENOMINACION_SOCIAL = "N009-MF000004543";

        public const string F2_II_2_NOMBRE_CONCESIONARIA_MINERA = "N009-MF000004544";
        public const string F2_II_2_CODIGO_CONCESIONARIA_MINERA = "N009-MF000004545";

        public const string F2_II_3_CODIGO_OSINERMING = "N009-MF000004546";
        public const string F2_II_3_REGISTRO_DGH = "N009-MF000004547";

        public const string F2_II_4_TAMAÑO_EMPRESA = "N009-MF000004548";
        public const string F2_II_4_DOMICILIO_PRINCIPAL = "N009-MF000004549";
        public const string F2_II_4_DEPARTAMENTO = "N009-MF000004550";
        public const string F2_II_4_PROVINCIA = "N009-MF000004551";
        public const string F2_II_4_DISTRITO = "N009-MF000004552";
        public const string F2_II_4_UBIGEO = "N009-MF000004553";
        public const string F2_II_4_ACTIVIDAD_ECONOMICA_P = "N009-MF000004554";
        public const string F2_II_4_CIIU = "N009-MF000004555";
        public const string F2_II_4_ER = "N009-MF000004556";
        public const string F2_II_4_N_HOMBRES = "N009-MF000004558";
        public const string F2_II_4_N_MUJERES = "N009-MF000004559";
        public const string F2_II_4_CODIGO_TELEFONO = "N009-MF000004560";

        //
        public const string F2_III_1_RUC = "N009-MF000004561";
        public const string F2_III_1_DENOMINACION_SOCIAL = "N009-MF000004562";

        public const string F2_III_2_NOMBRE_CONCESIONARIA_MINERA = "N009-MF000004563";
        public const string F2_III_2_CODIGO_CONCESIONARIA_MINERA = "N009-MF000004564";

        public const string F2_III_3_CODIGO_OSINERMING = "N009-MF000004565";
        public const string F2_III_3_REGISTRO_DGH = "N009-MF000004566";

        public const string F2_III_4_TAMAÑO_EMPRESA = "N009-MF000004567";
        public const string F2_III_4_DOMICILIO_PRINCIPAL = "N009-MF000004568";
        public const string F2_III_4_DEPARTAMENTO = "N009-MF000004569";
        public const string F2_III_4_PROVINCIA = "N009-MF000004570";
        public const string F2_III_4_DISTRITO = "N009-MF000004571";
        public const string F2_III_4_UBIGEO = "N009-MF000004572";
        public const string F2_III_4_ACTIVIDAD_ECONOMICA_P = "N009-MF000004573";
        public const string F2_III_4_CIIU = "N009-MF000004574";
        public const string F2_III_4_ER = "N009-MF000004575";
        public const string F2_III_4_N_HOMBRES = "N009-MF000004577";
        public const string F2_III_4_N_MUJERES = "N009-MF000004578";
        public const string F2_III_4_CODIGO_TELEFONO = "N009-MF000004579";

        public const string F2_IV_DNI_CE = "N009-MF000004581";
        public const string F2_IV_APELLIDOS = "N009-MF000004582";
        public const string F2_IV_NOMBRES = "N009-MF000004583";
        public const string F2_IV_DOMICILIO = "N009-MF000004584";
        public const string F2_IV_DEPARTAMENTO = "N009-MF000004585";
        public const string F2_IV_PROVINCIA = "N009-MF000004586";
        public const string F2_IV_DISTRITO = "N009-MF000004557";
        public const string F2_IV_UBIGEO = "N009-MF000004587";
        public const string F2_IV_CATEGORIA_OCUPACIONAL = "N009-MF000004588";
        public const string F2_IV_ASEGURADO = "N009-MF000004589";
        public const string F2_IV_ESSALUD = "N009-MF000004591";
        public const string F2_IV_EPS = "N009-MF000004592";
        public const string F2_IV_EDAD = "N009-MF000004593";
        public const string F2_IV_SCTR = "N009-MF000004594";
        public const string F2_IV_GENERO = "N009-MF000004595";

        public const string F2_V_1_FECHA_ACCIDENTE = "N009-MF000004596";
        public const string F2_V_1_HORA_ACCIDENTE = "N009-MF000004597";
        public const string F2_V_1_TIPO_ACCIDENTE_1 = "N009-MF000004598";
        public const string F2_V_1_TIPO_ACCIDENTE_2 = "N009-MF000004599";
        public const string F2_V_1_AGENTE_CAUSANTE_1 = "N009-MF000004600";
        public const string F2_V_1_AGENTE_CAUSANTE_2 = "N009-MF000004601";
        public const string F2_V_1_AGENTE_CAUSANTE_3 = "N009-MF000004602";

        public const string F2_V_2_RUC = "N009-MF000004603";
        public const string F2_V_2_FECHA_INGRESO = "N009-MF000004604";
        public const string F2_V_2_CENTRO_MEDICO_ASISTENCIAL = "N009-MF000004605";
        public const string F2_V_2_TIPO_CENTRO_MEDICO = "N009-MF000004606";
        public const string F2_V_2_PARTE_CUERPO_AFECTADO = "N009-MF000004607";
        public const string F2_V_2_NATURALEZA_LESION = "N009-MF000004608";

        public const string F2_V_3_ACCIDENTE_LEVE = "N009-MF000004609";
        public const string F2_V_3_TOTAL_TEMPORAL = "N009-MF000004613";
        public const string F2_V_3_PARCIAL_TEMPORAL = "N009-MF000004614";
        public const string F2_V_3_PARCIAL_PERMANENTE = "N009-MF000004615";
        public const string F2_V_3_TOTAL_PERMANENTE = "N009-MF000004616";
        public const string F2_V_3_ACCIDENTE_MORTAL = "N009-MF000004617";
        public const string F2_V_3_FECHA_FALLECIMIENTO = "N009-MF000004618";

        public const string F2_VI_FISICOS = "N009-MF000004619";
        public const string F2_VI_QUIMICOS = "N009-MF000004620";
        public const string F2_VI_BIOLOGICOS = "N009-MF000004621";
        public const string F2_VI_DISERGONOMICOS = "N009-MF000004622";
        public const string F2_VI_PSICO_SOCIALES = "N009-MF000004623";
        public const string F2_VI_NOMBRE_NATURALEZA_ENFERMEDAD_PROFESIONAL_U_OCUPACIONAL = "N009-MF000004625";
        public const string F2_VI_CIE_10 = "N009-MF000004626";

        public const string F2_VI_1_RUC = "N009-MF000004627";
        public const string F2_VI_1_FECHA_INGRESO = "N009-MF000004628";
        public const string F2_VI_1_CENTRO_MEDICO = "N009-MF000004629";
        public const string F2_VI_1_TIPO_CENTRO_MEDICO = "N009-MF000004630";

        public const string F2_VI_2_ENFERMEDAD_PROFESIONAL_U_OCUPACIONAL = "N009-MF000004631";

        #endregion


        #region CERTIFICADO SUFICIENcIA MÉDICA PARA TRABAJO EN ALTURA
        public const string CERT_SUF_MED_ALTURA_ID = "N009-ME000000467";

        public const string CERT_SUF_MED_ALTURA_AREA = "N009-MF000004000";

        public const string CERT_SUF_MED_ALTURA_ANT_PERS_1 = "N009-MF000004001";
        public const string CERT_SUF_MED_ALTURA_ANT_PERS_2 = "N009-MF000004002";
        public const string CERT_SUF_MED_ALTURA_ANT_PERS_3 = "N009-MF000004003";
        public const string CERT_SUF_MED_ALTURA_ANT_PERS_4 = "N009-MF000004004";

        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_1 = "N009-MF000004005";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_2 = "N009-MF000004006";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_3 = "N009-MF000004007";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_4 = "N009-MF000004008";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_5 = "N009-MF000004009";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_6 = "N009-MF000004010";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_7 = "N009-MF000004011";
        public const string CERT_SUF_MED_ALTURA_ANT_NEUROLOGICOS_8 = "N009-MF000004012";

        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_1 = "N009-MF000004013";
        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_2 = "N009-MF000004014";
        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_3 = "N009-MF000004015";
        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_4 = "N009-MF000004016";
        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_5 = "N009-MF000004017";
        public const string CERT_SUF_MED_ALTURA_ANT_PSIQUIATRICOS_6 = "N009-MF000004018";

        public const string CERT_SUF_MED_ALTURA_EXAMEN_OCUPACIONAL_1 = "N009-MF000004019";
        public const string CERT_SUF_MED_ALTURA_EXAMEN_OCUPACIONAL_2 = "N009-MF000004020";
        public const string CERT_SUF_MED_ALTURA_EXAMEN_OCUPACIONAL_3 = "N009-MF000004021";
        public const string CERT_SUF_MED_ALTURA_EXAMEN_OCUPACIONAL_4 = "N009-MF000004022";

        public const string CERT_SUF_MED_ALTURA_ORIENTACION_1_0 = "N009-MF000004023";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_1_1 = "N009-MF000004024";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_2_0 = "N009-MF000004025";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_2_1 = "N009-MF000004026";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_3_0 = "N009-MF000004027";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_3_1 = "N009-MF000004028";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_4_0 = "N009-MF000004029";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_4_1 = "N009-MF000004030";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_5_0 = "N009-MF000004031";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_5_1 = "N009-MF000004032";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_6_0 = "N009-MF000004033";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_6_1 = "N009-MF000004034";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_7_0 = "N009-MF000004035";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_7_1 = "N009-MF000004036";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_8_0 = "N009-MF000004037";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_8_1 = "N009-MF000004038";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_9_0 = "N009-MF000004039";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_9_1 = "N009-MF000004040";
        public const string CERT_SUF_MED_ALTURA_ORIENTACION_TOTAL = "N009-MF000004041";

        public const string CERT_SUF_MED_ALTURA_FIJACION_0 = "N009-MF000004042";
        public const string CERT_SUF_MED_ALTURA_FIJACION_1 = "N009-MF000004043";
        public const string CERT_SUF_MED_ALTURA_FIJACION_2 = "N009-MF000004044";
        public const string CERT_SUF_MED_ALTURA_FIJACION_3 = "N009-MF000004045";
        public const string CERT_SUF_MED_ALTURA_FIJACION_TOTAL = "N009-MF000004059";

        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_0 = "N009-MF000004046";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_1 = "N009-MF000004047";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_2 = "N009-MF000004048";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_3 = "N009-MF000004049";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_4 = "N009-MF000004050";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_1_5 = "N009-MF000004051";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_2_0 = "N009-MF000004052";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_2_1 = "N009-MF000004053";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_2_2 = "N009-MF000004054";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_2_3 = "N009-MF000004055";
        public const string CERT_SUF_MED_ALTURA_ATENCION_CALCULO_TOTAL = "N009-MF000004058";

        public const string CERT_SUF_MED_ALTURA_MEMORIA_CORTO_PLAZO_0 = "N009-MF000004060";
        public const string CERT_SUF_MED_ALTURA_MEMORIA_CORTO_PLAZO_1 = "N009-MF000004061";
        public const string CERT_SUF_MED_ALTURA_MEMORIA_CORTO_PLAZO_2 = "N009-MF000004062";
        public const string CERT_SUF_MED_ALTURA_MEMORIA_CORTO_PLAZO_3 = "N009-MF000004063";
        public const string CERT_SUF_MED_ALTURA_MEMORIA_CORTO_PLAZO_TOTAL = "N009-MF000004070";

        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_1_0 = "N009-MF000004064";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_1_1 = "N009-MF000004065";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_2_0 = "N009-MF000004068";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_2_1 = "N009-MF000004069";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_3_0 = "N009-MF000004073";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_3_1 = "N009-MF000004074";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_4_0 = "N009-MF000004077";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_4_1 = "N009-MF000004078";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_5_0 = "N009-MF000004081";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_5_1 = "N009-MF000004082";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_6_0 = "N009-MF000004085";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_6_1 = "N009-MF000004086";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_6_2 = "N009-MF000004087";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_6_3 = "N009-MF000004088";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_7_0 = "N009-MF000004089";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_7_1 = "N009-MF000004090";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_8_0 = "N009-MF000004093";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_8_1 = "N009-MF000004094";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_9_0 = "N009-MF000004097";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_9_1 = "N009-MF000004098";
        public const string CERT_SUF_MED_ALTURA_LENGUAJE_CONSTRUCCION_TOTAL = "N009-MF000004101";

        public const string CERT_SUF_MED_ALTURA_CALIFICACION = "N009-MF000004102";
        public const string CERT_SUF_MED_ALTURA_APTITUD_SI= "N009-MF000004104";
        public const string CERT_SUF_MED_ALTURA_APTITUD_NO = "N009-MF000004105";


        #endregion

        #region EVALUACION DERMATOLOGICA OC
        public const string EVALUACION_DERMATOLOGICA_OC_ID = "N009-ME000000466";

        public const string EVALUACION_DERMATOLOGICA_OC_ANAMNESIS_1 = "N009-MF000003954";
        public const string EVALUACION_DERMATOLOGICA_OC_ANAMNESIS_2 = "N009-MF000003955";
        public const string EVALUACION_DERMATOLOGICA_OC_ANAMNESIS_3 = "N009-MF000003956";
        public const string EVALUACION_DERMATOLOGICA_OC_ANAMNESIS_5 = "N009-MF000003958";

        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_1 = "N009-MF000003959";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_2 = "N009-MF000003960";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_3 = "N009-MF000003961";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_4 = "N009-MF000003962";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_5 = "N009-MF000003963";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_6 = "N009-MF000003964";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_7 = "N009-MF000003965";
        public const string EVALUACION_DERMATOLOGICA_OC_ENFERMEDADES_SISTÉMICAS_PIEL_ANEXOS_9 = "N009-MF000003967";

        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_1 = "N009-MF000003968";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_2 = "N009-MF000003969";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_3 = "N009-MF000003970";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_4 = "N009-MF000003971";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_5 = "N009-MF000003972";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_6 = "N009-MF000003973";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_7 = "N009-MF000003974";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_8 = "N009-MF000003975";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_9 = "N009-MF000003976";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_10 = "N009-MF000003977";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_11 = "N009-MF000003978";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_12 = "N009-MF000003979";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_13 = "N009-MF000003980";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_14 = "N009-MF000003981";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_15 = "N009-MF000003982";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_16 = "N009-MF000003983";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_17 = "N009-MF000003984";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_18 = "N009-MF000003985";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_19 = "N009-MF000003986";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_PRIMARIAS_21 = "N009-MF000003987";

        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_1 = "N009-MF000003988";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_2 = "N009-MF000003989";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_3 = "N009-MF000003990";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_4 = "N009-MF000003991";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_5 = "N009-MF000003992";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_6 = "N009-MF000003993";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_7 = "N009-MF000003994";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_8 = "N009-MF000003995";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_9 = "N009-MF000003996";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_10 = "N009-MF000003997";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_11 = "N009-MF000003998";
        public const string EVALUACION_DERMATOLOGICA_OC_LESIONES_SECUNDARIAS_13 = "N009-MF000003999";
        #endregion

        #region ENTREGA DE EXAMEN MEDICO OCUPACIONAL
        public const string EVALUACION_MEDICO_SAN_MARTIN_INFORME = "EV-MED-INF-RESULTADOS";
        #endregion
        #region Declaracion Jurada SECURITAS
        public const string Declaracion_Jurada_EMO_SECURITAS = "DJ-EMO_SECURITAS";
        #endregion

        #region Declaracion Jurada Yanacocha
        public const string Declaracion_Jurada_EMPO_YANACOCHA = "DJ-EMPO_YANACOCHA";
        #endregion
        #region ALTURA FISICA - SHAHUINDO

        public const string ALTURA_FISICA_SHAHUINDO_ID = "N009-ME000000465";

        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_1 = "N009-MF000003914";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_2 = "N009-MF000003915";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_3 = "N009-MF000003916";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_4 = "N009-MF000003917";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_5 = "N009-MF000003918";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_6 = "N009-MF000003919";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_7 = "N009-MF000003920";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_8 = "N009-MF000003921";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_9 = "N009-MF000003922";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_10 = "N009-MF000003923";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_11 = "N009-MF000003924";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_12 = "N009-MF000003925";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_13 = "N009-MF000003926";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_14 = "N009-MF000003927";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_15 = "N009-MF000003928";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_16 = "N009-MF000003929";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_17 = "N009-MF000003930";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_18 = "N009-MF000003931";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_19 = "N009-MF000003932";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_20 = "N009-MF000003933";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_21 = "N009-MF000003934";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_22 = "N009-MF000003935";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_23 = "N009-MF000003936";
        public const string ALTURA_FISICA_SHAHUINDO_ANTECEDENTES_25 = "N009-MF000003938";

        public const string ALTURA_FISICA_SHAHUINDO_IMC_SI = "N009-MF000003939";
        public const string ALTURA_FISICA_SHAHUINDO_IMC_NO = "N009-MF000003940";

        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_1= "N009-MF000003941";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_2 = "N009-MF000003942";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_3 = "N009-MF000003943";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_4 = "N009-MF000003944";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_5 = "N009-MF000003945";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_6 = "N009-MF000003946";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_7 = "N009-MF000003947";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_8 = "N009-MF000003948";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_9 = "N009-MF000003949";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_10 = "N009-MF000003950";
        public const string ALTURA_FISICA_SHAHUINDO_EXAMEN_ESPECIFICO_11 = "N009-MF000003951";

        public const string ALTURA_FISICA_SHAHUINDO_APTITUD_SI = "N009-MF000003952";
        public const string ALTURA_FISICA_SHAHUINDO_APTITUD_NO = "N009-MF000003953";

        #endregion
        #region DECLARACION JURADA - CUESTIONARIO
        public const string DECLARACION_JURADA_CUESTIONARIO = "N009-ME000000464";

        public const string DECLARACION_JURADA_CUESTIONARIO_1 = "N009-MF000003768";
        public const string DECLARACION_JURADA_CUESTIONARIO_1A = "N009-MF000003769";
        public const string DECLARACION_JURADA_CUESTIONARIO_1B = "N009-MF000003770";
        public const string DECLARACION_JURADA_CUESTIONARIO_1C = "N009-MF000003771";

        public const string DECLARACION_JURADA_CUESTIONARIO_2 = "N009-MF000003772";
        public const string DECLARACION_JURADA_CUESTIONARIO_2A = "N009-MF000003773";
        public const string DECLARACION_JURADA_CUESTIONARIO_2B = "N009-MF000003774";
        public const string DECLARACION_JURADA_CUESTIONARIO_2C = "N009-MF000003775";

        public const string DECLARACION_JURADA_CUESTIONARIO_3 = "N009-MF000003776";
        public const string DECLARACION_JURADA_CUESTIONARIO_3A = "N009-MF000003777";
        public const string DECLARACION_JURADA_CUESTIONARIO_3B = "N009-MF000003778";
        public const string DECLARACION_JURADA_CUESTIONARIO_3C = "N009-MF000003779";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_1 = "N009-MF000003780";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_1A = "N009-MF000003781";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_1B = "N009-MF000003782";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_1C = "N009-MF000003783";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_2 = "N009-MF000003784";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_2A = "N009-MF000003785";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_2B = "N009-MF000003786";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_2C = "N009-MF000003787";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_3 = "N009-MF000003788";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_3A = "N009-MF000003789";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_3B = "N009-MF000003790";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_3C = "N009-MF000003791";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_4 = "N009-MF000003792";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_4A = "N009-MF000003793";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_4B = "N009-MF000003794";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_4C = "N009-MF000003795";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_5 = "N009-MF000003796";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_5A = "N009-MF000003797";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_5B = "N009-MF000003798";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_5C = "N009-MF000003799";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_6 = "N009-MF000003800";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_6A = "N009-MF000003801";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_6B = "N009-MF000003802";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_6C = "N009-MF000003803";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_7 = "N009-MF000003804";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_7A = "N009-MF000003805";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_7B = "N009-MF000003806";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_7C = "N009-MF000003807";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_8 = "N009-MF000003808";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_8A = "N009-MF000003809";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_8B = "N009-MF000003810";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_8C = "N009-MF000003811";

        public const string DECLARACION_JURADA_CUESTIONARIO_3_9 = "N009-MF000003812";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_9A = "N009-MF000003813";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_9B = "N009-MF000003814";
        public const string DECLARACION_JURADA_CUESTIONARIO_3_9C = "N009-MF000003815";

        public const string DECLARACION_JURADA_CUESTIONARIO_4 = "N009-MF000003816";
        public const string DECLARACION_JURADA_CUESTIONARIO_4A = "N009-MF000003817";
        public const string DECLARACION_JURADA_CUESTIONARIO_4B = "N009-MF000003818";
        public const string DECLARACION_JURADA_CUESTIONARIO_4C = "N009-MF000003819";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_1 = "N009-MF000003820";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_1A = "N009-MF000003821";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_1B = "N009-MF000003822";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_1C = "N009-MF000003823";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_2 = "N009-MF000003824";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_2A = "N009-MF000003825";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_2B = "N009-MF000003826";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_2C = "N009-MF000003827";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_3 = "N009-MF000003828";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_3A = "N009-MF000003829";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_3B = "N009-MF000003830";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_3C = "N009-MF000003831";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_4 = "N009-MF000003832";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_4A = "N009-MF000003833";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_4B = "N009-MF000003834";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_4C = "N009-MF000003835";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_5 = "N009-MF000003836";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_5A = "N009-MF000003837";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_5B = "N009-MF000003838";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_5C = "N009-MF000003839";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_6 = "N009-MF000003840";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_6A = "N009-MF000003841";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_6B = "N009-MF000003842";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_6C = "N009-MF000003843";

        public const string DECLARACION_JURADA_CUESTIONARIO_4_7 = "N009-MF000003844";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_7A = "N009-MF000003845";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_7B = "N009-MF000003846";
        public const string DECLARACION_JURADA_CUESTIONARIO_4_7C = "N009-MF000003847";

        public const string DECLARACION_JURADA_CUESTIONARIO_5 = "N009-MF000003848";
        public const string DECLARACION_JURADA_CUESTIONARIO_5A = "N009-MF000003849";
        public const string DECLARACION_JURADA_CUESTIONARIO_5B = "N009-MF0000038450";
        public const string DECLARACION_JURADA_CUESTIONARIO_5C = "N009-MF0000038451";

        public const string DECLARACION_JURADA_CUESTIONARIO_6 = "N009-MF000003852";
        public const string DECLARACION_JURADA_CUESTIONARIO_6A = "N009-MF000003853";
        public const string DECLARACION_JURADA_CUESTIONARIO_6B = "N009-MF000003854";
        public const string DECLARACION_JURADA_CUESTIONARIO_6C = "N009-MF000003855";

        public const string DECLARACION_JURADA_CUESTIONARIO_7 = "N009-MF000003856";
        public const string DECLARACION_JURADA_CUESTIONARIO_7A = "N009-MF000003857";
        public const string DECLARACION_JURADA_CUESTIONARIO_7B = "N009-MF000003858";
        public const string DECLARACION_JURADA_CUESTIONARIO_7C = "N009-MF000003859";

        public const string DECLARACION_JURADA_CUESTIONARIO_8 = "N009-MF000003860";
        public const string DECLARACION_JURADA_CUESTIONARIO_8A = "N009-MF000003861";
        public const string DECLARACION_JURADA_CUESTIONARIO_8B = "N009-MF000003862";
        public const string DECLARACION_JURADA_CUESTIONARIO_8C = "N009-MF000003863";

        public const string DECLARACION_JURADA_CUESTIONARIO_9 = "N009-MF000003864";
        public const string DECLARACION_JURADA_CUESTIONARIO_9A = "N009-MF000003865";
        public const string DECLARACION_JURADA_CUESTIONARIO_9B = "N009-MF000003866";
        public const string DECLARACION_JURADA_CUESTIONARIO_9C = "N009-MF000003867";

        public const string DECLARACION_JURADA_CUESTIONARIO_10 = "N009-MF000003868";
        public const string DECLARACION_JURADA_CUESTIONARIO_10A = "N009-MF000003869";
        public const string DECLARACION_JURADA_CUESTIONARIO_10B = "N009-MF000003870";
        public const string DECLARACION_JURADA_CUESTIONARIO_10C = "N009-MF000003871";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_1 = "N009-MF000003872";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_1A = "N009-MF000003873";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_1B = "N009-MF000003874";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_1C = "N009-MF000003875";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_2 = "N009-MF000003876";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_2A = "N009-MF000003877";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_2B = "N009-MF000003878";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_2C = "N009-MF000003879";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_3 = "N009-MF000003906";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_3A = "N009-MF000003907";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_3B = "N009-MF000003908";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_3C = "N009-MF000003909";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_4 = "N009-MF000003880";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_4A = "N009-MF000003881";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_4B = "N009-MF000003882";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_4C = "N009-MF000003883";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_5 = "N009-MF000003884";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_5A = "N009-MF000003885";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_5B = "N009-MF000003886";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_5C = "N009-MF000003887";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_6 = "N009-MF000003888";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_6A = "N009-MF000003889";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_6B = "N009-MF000003890";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_6C = "N009-MF000003891";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_7 = "N009-MF000003892";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_7A = "N009-MF000003893";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_7B = "N009-MF000003894";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_7C = "N009-MF000003895";

        public const string DECLARACION_JURADA_CUESTIONARIO_10_8 = "N009-MF000003896";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_8A = "N009-MF000003897";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_8B = "N009-MF000003898";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_8C = "N009-MF000003899";
        
        // HOMBROS
        public const string DECLARACION_JURADA_CUESTIONARIO_10_9 = "N009-MF000003910";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_9A = "N009-MF000003911";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_9B = "N009-MF000003912";
        public const string DECLARACION_JURADA_CUESTIONARIO_10_9C = "N009-MF000003913";
        //

        public const string DECLARACION_JURADA_CUESTIONARIO_11 = "N009-MF000003900";
        public const string DECLARACION_JURADA_CUESTIONARIO_11A = "N009-MF000003901";
        public const string DECLARACION_JURADA_CUESTIONARIO_11B = "N009-MF000003902";
        public const string DECLARACION_JURADA_CUESTIONARIO_11C = "N009-MF000003903";
        #endregion

        #region ENTREGA DE EXAMEN MEDICO OCUPACIONAL
        public const string ENTREGA_DE_XAMEN_MEDICO_OCUPACIONAL = "ENTREGA-EMO";
        #endregion

        #region INFORME OTORRINOLARINGOLOGO
        public const string INFORME_OTORRINOLARINGOLOGICO = "N009-ME000000463";

        public const string INFORME_OTORRINOLARINGOLOGICO_ANAMNESIS = "N009-MF000003757";
        public const string INFORME_OTORRINOLARINGOLOGICO_ANTECEDENTES = "N009-MF000003758";
        public const string INFORME_OTORRINOLARINGOLOGICO_TIMPANO_DERECHO = "N009-MF000003759";
        public const string INFORME_OTORRINOLARINGOLOGICO_TIMPANO_IZQUIERDO = "N009-MF000003760";
        public const string INFORME_OTORRINOLARINGOLOGICO_NARIZ = "N009-MF000003761";
        public const string INFORME_OTORRINOLARINGOLOGICO_FARINGE = "N009-MF000003762";
        public const string INFORME_OTORRINOLARINGOLOGICO_CONCLUSIONES = "N009-MF000003763";

        #endregion
        #region DECLARACIÓN JURADA ANTECEDENTES PERSONALES

        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_ID = "N009-ME000000462";

        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_1 = "N009-MF000003741";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_2 = "N009-MF000003742";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_3 = "N009-MF000003743";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_4 = "N009-MF000003744";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_5 = "N009-MF000003745";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_6 = "N009-MF000003746";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_7 = "N009-MF000003747";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_8 = "N009-MF000003748";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_9 = "N009-MF000003749";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_10 = "N009-MF000003750";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_11 = "N009-MF000003751";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_12 = "N009-MF000003752";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_13 = "N009-MF000003753";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_14 = "N009-MF000003754";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_15 = "N009-MF000003755";
        public const string DECLARACION_JURADA_ANTECEDENTES_PERSONALES_espc = "N009-MF000003756";

        #endregion
        #region marcobre
        public const string MARCOBRE_PASE_MEDICO = "MARCOBRE-PASE-MEDICO";
        #endregion
        #region Declaracion Jurada
        public const string DECLARACION_JURADA = "DECLARACION-JURADA";
        #endregion
        #region  anexo 3 - exoneracion
        public const string ANEXO_3_EXO_RESP_YANACOCHA = "N009-ME000000458";
        #endregion
        #region PETRINOVIC
        public const string PETRINOVIC_ID = "N009-ME000000098";

        public const string PETRINOVIC_RESULTADO_ID = "N009-MF000001834";
        #endregion

        #region EVALUACIÓN CARDIOLÓGICA

        public const string EVA_CARDIOLOGICA_ID = "N009-ME000000092";

        public const string EVA_CARDIOLOGICA_SOPLO_CARDIACO = "N009-MF000001749";
        public const string EVA_CARDIOLOGICA_PRESION_ALTA = "N009-MF000001750";
        public const string EVA_CARDIOLOGICA_CANSANCIO_RAPIDO = "N009-MF000001751";
        public const string EVA_CARDIOLOGICA_MAREOS = "N009-MF000001752";
        public const string EVA_CARDIOLOGICA_DOLOR_PRECORDIAL = "N009-MF000001753";
        public const string EVA_CARDIOLOGICA_PALPITACIONES = "N009-MF000001754";
        public const string EVA_CARDIOLOGICA_ATAQUE_CORAZON = "N009-MF000001755";
        public const string EVA_CARDIOLOGICA_PERDIDA_CONCIENCIA = "N009-MF000001756";
        public const string EVA_CARDIOLOGICA_OBESIDAD = "N009-MF000001757";
        public const string EVA_CARDIOLOGICA_TABAQUISMO = "N009-MF000001758";
        public const string EVA_CARDIOLOGICA_DIABETES = "N009-MF000001759";
        public const string EVA_CARDIOLOGICA_DISLIPIDEMIA = "N009-MF000001760";
        public const string EVA_CARDIOLOGICA_VARICES_PIERNAS = "N009-MF000001761";
        public const string EVA_CARDIOLOGICA_SEDENTARISMO = "N009-MF000001762";
        public const string EVA_CARDIOLOGICA_OTROS = "N009-MF000001763";

        public const string EVA_CARDIOLOGICA_PRECORDIAL_1 = "N009-MF000001764";
        public const string EVA_CARDIOLOGICA_DESMAYOS = "N009-MF000001765";
        public const string EVA_CARDIOLOGICA_PALPITACIONES_1 = "N009-MF000001766";
        public const string EVA_CARDIOLOGICA_DISNEA_PAROXISTICA = "N009-MF000001767";
        public const string EVA_CARDIOLOGICA_MAREOS_1 = "N009-MF000001768";
        public const string EVA_CARDIOLOGICA_CLAUDICACION = "N009-MF000001769";
        public const string EVA_CARDIOLOGICA_OTROS_1 = "N009-MF000001770";


        public const string EVA_CARDIOLOGICA_FREC_CARDIACA = "N009-MF000001771";
        public const string EVA_CARDIOLOGICA_PRESION_ARTERIAL = "N009-MF000001772";
        public const string EVA_CARDIOLOGICA_CHOQUE_PUNTA = "N009-MF000001773";

        public const string EVA_CARDIOLOGICA_RITMO = "N009-MF000001774";
        public const string EVA_CARDIOLOGICA_EJE = "N009-MF000001775";
        public const string EVA_CARDIOLOGICA_FC = "N009-MF000001776";
        public const string EVA_CARDIOLOGICA_PR = "N009-MF000001777";
        public const string EVA_CARDIOLOGICA_QRS = "N009-MF000001778";
        public const string EVA_CARDIOLOGICA_QT = "N009-MF000001779";
        public const string EVA_CARDIOLOGICA_ONDA_Q = "N009-MF000001780";
        public const string EVA_CARDIOLOGICA_ONDA_P = "N009-MF000001781";
        public const string EVA_CARDIOLOGICA_ONDA_R = "N009-MF000001782";
        public const string EVA_CARDIOLOGICA_ONDA_S = "N009-MF000001783";
        public const string EVA_CARDIOLOGICA_ONDA_T = "N009-MF000001784";
        public const string EVA_CARDIOLOGICA_ONDA_U = "N009-MF000001785";


        #endregion

        #region Realizado
        public const string GRUPO_Y_FACTOR_SANGUINEO_ID_REALIZADO = "N009-MF000001452";
        public const string LABORATORIO_HEMATOCRITO_ID_REALIZADO = "N009-MF000001454";
        public const string VDRL_ID_REALIZADO = "N009-MF000001467";

        public const string HEPATITIS_A_ID_REALIZADO = "N009-MF000001453";
        public const string HEPATITIS_C_ID_REALIZADO = "N009-MF000001457";
        public const string LABORATORIO_HEMOGLOBINA_ID_REALIZADO = "N009-MF000001455";

        public const string GLUCOSA_ID_REALIZADO = "N009-MF000001451";
        public const string ANTIGENO_PROSTATICO_ID_REALIZADO = "N009-MF000001440";
        public const string PARASITOLOGICO_SIMPLE_ID_REALIZADO = "N009-MF000001459";

        public const string ACIDO_URICO_ID_REALIZADO = "N009-MF000001438";
        public const string COLESTEROL_ID_REALIZADO = "N009-MF000001446";
        public const string TRIGLICERIDOS_ID_REALIZADO = "N009-MF000001465";

        public const string AGLUTINACIONES_LAMINA_ID_REALIZADO = "N009-MF000001439";
        public const string SUB_UNIDAD_BETA_CUALITATIVO_ID_REALIZADO = "N009-MF000001461";
        public const string CREATININA_ID_REALIZADO = "N009-MF000001448";

        public const string EXAMEN_ELISA_ID_REALIZADO = "N009-MF000001450";
        public const string HEMOGRAMA_COMPLETO_ID_REALIZADO = "N009-MF000001456";
        public const string EXAMEN_COMPLETO_DE_ORINA_ID_REALIZADO = "N009-MF000001449";

        public const string PARASITOLOGICO_SERIADO_ID_REALIZADO = "N009-MF000001458";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_ID_REALIZADO = "N009-MF000001464";
        public const string TGO_ID_REALIZADO = "N009-MF000001462";

        public const string TGP_ID_REALIZADO = "N009-MF000001463";
        public const string PLOMO_SANGRE_ID_REALIZADO = "N009-MF000001460";
        public const string UREA_ID_REALIZADO = "N009-MF000001466";

        public const string COLESTEROL_HDL_ID_REALIZADO = "N009-MF000001444";
        public const string COLESTEROL_LDL_ID_REALIZADO = "N009-MF000001445";
        public const string COLESTEROL_VLDL_ID_REALIZADO = "N009-MF000001447";




        #region EVALUACIÓN OSTEOMUSCULAR


        public const string EVA_OSTEO_ID = "N009-ME000000091";

        public const string EVA_OSTEO_ESCOLIOSIS_ID = "N009-MF000001673";
        public const string EVA_OSTEO_CIFOSIS_ID = "N009-MF000001674";
        public const string EVA_OSTEO_LORDOSIS_ID = "N009-MF000001675";
        public const string EVA_OSTEO_COMENTARIOS_1_ID = "N009-MF000001676";

        public const string EVA_OSTEO_FLEXION_HACIA_DELANTE_ID = "N009-MF000001679";
        public const string EVA_OSTEO_FLEXION_HACIA_DELANTE_DESC_ID = "N009-MF000001680";

        public const string EVA_OSTEO_HIPERTENSION_ID = "N009-MF000001681";
        public const string EVA_OSTEO_HIPERTENSION_DESC_ID = "N009-MF000001682";

        public const string EVA_OSTEO_FLEXION_LATERAL_IZQ_ID = "N009-MF000001683";
        public const string EVA_OSTEO_FLEXION_LATERAL_IZQ_DESC_ID = "N009-MF000001684";

        public const string EVA_OSTEO_FLEXION_LATERAL_DER_ID = "N009-MF000001685";
        public const string EVA_OSTEO_FLEXION_LATERAL_DER_DESC_ID = "N009-MF000001686";

        public const string EVA_OSTEO_ROTACION_IZQUIERDO_ID = "N009-MF000001687";
        public const string EVA_OSTEO_ROTACION_IZQUIERDO_DESC_ID = "N009-MF000001688";

        public const string EVA_OSTEO_ROTACION_DERECHO_ID = "N009-MF000001689";
        public const string EVA_OSTEO_ROTACION_DERECHO_DESC_ID = "N009-MF000001690";

        public const string EVA_OSTEO_COMENTARIOS_2_ID = "N009-MF000001691";


        public const string EVA_OSTEO_CORRIENDO_ID = "N009-MF000001694";
        public const string EVA_OSTEO_CORRIENDO_DESC_ID = "N009-MF000001695";
        public const string EVA_OSTEO_CAMINANDO_ID = "N009-MF000001696";
        public const string EVA_OSTEO_CAMINANDO_DESC_ID = "N009-MF000001697";

        public const string EVA_OSTEO_CUNCLILLA_3_MIN_ID = "N009-MF000001698";
        public const string EVA_OSTEO_CUNCLILLA_3_MIN_DESC_ID = "N009-MF000001699";


        public const string EVA_OSTEO_CODO_DER_ID = "N009-MF000001703";
        public const string EVA_OSTEO_CODO_IZQ_ID = "N009-MF000001704";
        public const string EVA_OSTEO_CODO_DESC_ID = "N009-MF000001705";

        public const string EVA_OSTEO_RODILLA_DER_ID = "N009-MF000001706";
        public const string EVA_OSTEO_RODILLA_IZQ_ID = "N009-MF000001707";
        public const string EVA_OSTEO_RODILLA_DESC_ID = "N009-MF000001708";

        public const string EVA_OSTEO_FUERZA_ID = "N009-MF000001712";
        public const string EVA_OSTEO_FUERZA_DESC_ID = "N009-MF000001713";


        public const string EVA_OSTEO_ABDOMINAL_EXC_ID = "N009-MF000001721";
        public const string EVA_OSTEO_ABDOMINAL_BUE_ID = "N009-MF000001722";
        public const string EVA_OSTEO_ABDOMINAL_REG_ID = "N009-MF000001723";
        public const string EVA_OSTEO_ABDOMINAL_POB_ID = "N009-MF000001724";
        public const string EVA_OSTEO_ABDOMINAL_DESC_ID = "N009-MF000001725";

        public const string EVA_OSTEO_CADERA_EXC_ID = "N009-MF000001728";
        public const string EVA_OSTEO_CADERA_BUE_ID = "N009-MF000001729";
        public const string EVA_OSTEO_CADERA_REG_ID = "N009-MF000001730";
        public const string EVA_OSTEO_CADERA_POB_ID = "N009-MF000001731";
        public const string EVA_OSTEO_CADERA_DESC_ID = "N009-MF000001732";

        public const string EVA_OSTEO_MUSLO_EXC_ID = "N009-MF000001734";
        public const string EVA_OSTEO_MUSLO_BUE_ID = "N009-MF000001735";
        public const string EVA_OSTEO_MUSLO_REG_ID = "N009-MF000001736";
        public const string EVA_OSTEO_MUSLO_POB_ID = "N009-MF000001737";
        public const string EVA_OSTEO_MUSLO_DESC_ID = "N009-MF000001738";

        public const string EVA_OSTEO_LATERAL_EXC_ID = "N009-MF000001740";
        public const string EVA_OSTEO_LATERAL_BUE_ID = "N009-MF000001741";
        public const string EVA_OSTEO_LATERAL_REG_ID = "N009-MF000001742";
        public const string EVA_OSTEO_LATERAL_POB_ID = "N009-MF000001743";
        public const string EVA_OSTEO_LATERAL_DESC_ID = "N009-MF000001744";


        public const string EVA_OSTEO_RESULTADO_1_ID = "N009-MF000001746";
        public const string EVA_OSTEO_RESULTADO_2_ID = "N009-MF000001747";

        public const string EVA_OSTEO_COMENTARIOS_ID = "N009-MF000001748";
        #endregion



        #endregion

        #region Vertigo

        public const string TEST_VERTIGO_ID = "N009-ME000000090";

        public const string TEST_VERTIGO_1 = "N009-MF000001665";
        public const string TEST_VERTIGO_2 = "N009-MF000001666";
        public const string TEST_VERTIGO_3 = "N009-MF000001667";
        public const string TEST_VERTIGO_4 = "N009-MF000001668";
        public const string TEST_VERTIGO_5 = "N009-MF000001669";
        public const string TEST_VERTIGO_6 = "N009-MF000001670";
        public const string TEST_VERTIGO_7 = "N009-MF000001671";
        public const string TEST_VERTIGO_8 = "N009-MF000001672";
        #endregion

        #region ECOGRAFICO RENAL
        public const string ECOGRAFIA_RENAL_ID = "N009-ME000000019";

        public const string ECOGRAFIA_RENAL_MOTIVO_EXAMEN = "N009-MF000000456";

        public const string ECOGRAFIA_RENAL_MORFOLOGIA_MOVILIDAD_RINION_DERECHO = "N009-MF000001537";
        public const string ECOGRAFIA_RENAL_DESCRIPCION_ANORMAL_RINION_DERECHO = "N009-MF000001538";
        public const string ECOGRAFIA_RENAL_ECOGENICIDAD_RINION_DERECHO = "N009-MF000001539";
        //public const string ECOGRAFIA_RENAL_ = "N009-MF000001540";
        public const string ECOGRAFIA_RENAL_LONGITUD_RINION_DERECHO = "N009-MF000001541";
        public const string ECOGRAFIA_RENAL_PARENQUIMA_RINION_DERECHO = "N009-MF000001542";
        public const string ECOGRAFIA_RENAL_IMG_EXP_SOLIDAS_RINION_DERECHO = "N009-MF000001543";
        public const string ECOGRAFIA_RENAL_QUISTICAS_RINION_DERECHO = "N009-MF000001544";
        public const string ECOGRAFIA_RENAL_HIDRONEFROSIS_RINION_DERECHO = "N009-MF000001545";
        public const string ECOGRAFIA_RENAL_MICROLITIAS_RINION_DERECHO = "N009-MF000001546";
        public const string ECOGRAFIA_RENAL_HIDRONEFROSIS_MEDIDAD_RINION_DERECHO = "N009-MF000001547";
        //public const string ECOGRAFIA_RENAL_ = "N009-MF000001548";
        public const string ECOGRAFIA_RENAL_CALCULOS_RINION_DERECHO = "N009-MF000001549";
        public const string ECOGRAFIA_RENAL_CALCULOS_MEDIDA_RINION_DERECHO = "N009-MF000001550";
        public const string ECOGRAFIA_RENAL_MORFOLOGIA_MOVILIDAD_RINION_IZQUIERDO = "N009-MF000001551";
        public const string ECOGRAFIA_RENAL_DESCRIPCION_ANORMAL_RINION_IZQUIERDO = "N009-MF000001552";
        public const string ECOGRAFIA_RENAL_ECOGENICIDAD_RINION_IZQUIERDO = "N009-MF000001553";
        //public const string ECOGRAFIA_RENAL_ = "N009-MF000001554";
        public const string ECOGRAFIA_RENAL_LONGITUD_RINION_IZQUIERDO = "N009-MF000001555";
        public const string ECOGRAFIA_RENAL_PARENQUIMA_RINION_IZQUIERDO = "N009-MF000001556";
        public const string ECOGRAFIA_RENAL_IMG_EXP_SOLIDAS_RINION_IZQUIERDO = "N009-MF000001557";
        public const string ECOGRAFIA_RENAL_QUISTICAS_RINION_IZQUIERDO = "N009-MF000001558";
        public const string ECOGRAFIA_RENAL_MICROLITIAS_RINION_IZQUIERDO = "N009-MF000001559";
        //public const string ECOGRAFIA_RENAL_ = "N009-MF000001560";
        public const string ECOGRAFIA_RENAL_CALCULOS_RINION_IZQUIERDO = "N009-MF000001561";
        public const string ECOGRAFIA_RENAL_HIDRONEFROSIS_MEDIDAD_RINION_IZQUIERDO = "N009-MF000001562";
        public const string ECOGRAFIA_RENAL_CALCULOS_MEDIDA_RINION_IZQUIERDO = "N009-MF000001563";
        public const string ECOGRAFIA_RENAL_DESCRIPCION_OTROS_RIÑON_DERECHO = "N009-MF000001564";
        public const string ECOGRAFIA_RENAL_DESCRIPCION_OTROS_RIÑON_IZQUIERDO = "N009-MF000001565";
        public const string ECOGRAFIA_RENAL_REPLICACION = "N009-MF000001566";
        public const string ECOGRAFIA_RENAL_PAREDES = "N009-MF000001567";
        public const string ECOGRAFIA_RENAL_CONT_ANECOICO = "N009-MF000001568";
        public const string ECOGRAFIA_RENAL_IMG_EXPANSIVAS = "N009-MF000001569";
        public const string ECOGRAFIA_RENAL_CALCULOS_INTERIOR = "N009-MF000001570";
        public const string ECOGRAFIA_RENAL_CALCULOS_INTERIOR_MEDIDA = "N009-MF000001571";
        public const string ECOGRAFIA_RENAL_VOL_PREMICCIONAL = "N009-MF000001572";
        public const string ECOGRAFIA_RENAL_VOL_POSMICCIONAL = "N009-MF000001573";
        public const string ECOGRAFIA_RENAL_RETENCION = "N009-MF000001574";
        public const string ECOGRAFIA_RENAL_DESCRIPCION_VEGIGA = "N009-MF000001575";
        public const string ECOGRAFIA_RENAL_NIGUNA = "N009-MF000001576";
        public const string ECOGRAFIA_RENAL_OBSERVACIONES = "N009-MF000001577";
        public const string ECOGRAFIA_RENAL_CONCLUSIONES = "N009-MF000001578";
        public const string ECOGRAFIA_RENAL_HIDRONEFROSIS_RINION_IZQUIERDO = "N009-MF000001579";
        #endregion

        #region ECOGRAFICO ABDOMINAL

        public const string ECOGRAFIA_ABDOMINAL_ID = "N009-ME000000051";
        public const string ECOGRAFIA_ABDOMINAL_MOTIVO_EXAMEN = "N009-MF000000535";
        public const string ECOGRAFIA_ABDOMINAL_MORFOLOGIA_MOVILIDAD = "N009-MF000001580";
        public const string ECOGRAFIA_ABDOMINAL_BORDES = "N009-MF000001581";
        public const string ECOGRAFIA_ABDOMINAL_MORFOLOGIA_MOVILIDAD_DESCRIPCION = "N009-MF000001582";
        public const string ECOGRAFIA_ABDOMINAL_BORDES_DESCRIPCION = "N009-MF000001583";
        public const string ECOGRAFIA_ABDOMINAL_DIMENSIONES = "N009-MF000001584";
        public const string ECOGRAFIA_ABDOMINAL_PAREMQUIMA = "N009-MF000001585";
        public const string ECOGRAFIA_ABDOMINAL_DIMENSIONES_DESCRIPCION = "N009-MF000001586";
        public const string ECOGRAFIA_ABDOMINAL_ECOGENICIDA = "N009-MF000001587";
        public const string ECOGRAFIA_ABDOMINAL_IMAGENES_EXPANSIVAS = "N009-MF000001588";
        public const string ECOGRAFIA_ABDOMINAL_DILATACION_VIAS_BILIARES = "N009-MF000001589";
        public const string ECOGRAFIA_ABDOMINAL_DIAMETRO_COLEDOCO = "N009-MF000001590";
        public const string ECOGRAFIA_ABDOMINAL_FORMA = "N009-MF000001591";
        public const string ECOGRAFIA_ABDOMINAL_FORMA_DESCRIPCION = "N009-MF000001592";
        public const string ECOGRAFIA_ABDOMINAL_PAREDES1 = "N009-MF000001593";
        public const string ECOGRAFIA_ABDOMINAL_PAREDES2 = "N009-MF000001594";
        public const string ECOGRAFIA_ABDOMINAL_CONT_ANECOICO = "N009-MF000001595";
        public const string ECOGRAFIA_ABDOMINAL_BARRO_BILIAR = "N009-MF000001596";
        public const string ECOGRAFIA_ABDOMINAL_CALCULOS_INTERIOR = "N009-MF000001597";
        public const string ECOGRAFIA_ABDOMINAL_CALCULOS_TAMAÑO = "N009-MF000001598";
        public const string ECOGRAFIA_ABDOMINAL_DIAMETRO_TRANSVERSO = "N009-MF000001599";
        public const string ECOGRAFIA_ABDOMINAL_DIAMETRO_LOGITUDINAL = "N009-MF000001600";
        public const string ECOGRAFIA_ABDOMINAL_PANCREAS_MORFOLOGIA_MOVILIDAD = "N009-MF000001601";
        public const string ECOGRAFIA_ABDOMINAL_PANCREAS_MEDIDAS = "N009-MF000001603";
        public const string ECOGRAFIA_ABDOMINAL_PANCREAS_MEDIDAS_DESCRIPCION = "N009-MF000001604";
        public const string ECOGRAFIA_ABDOMINAL_CABEZA = "N009-MF000001605";
        public const string ECOGRAFIA_ABDOMINAL_CUELLO = "N009-MF000001606";
        public const string ECOGRAFIA_ABDOMINAL_CUERNO = "N009-MF000001607";
        public const string ECOGRAFIA_ABDOMINAL_COLA = "N009-MF000001608";
        public const string ECOGRAFIA_ABDOMINAL_MEDIDAD_NO_EVALUABLES = "N009-MF000001609";
        public const string ECOGRAFIA_ABDOMINAL_ANORMAL = "N009-MF000001611";
        public const string ECOGRAFIA_ABDOMINAL_DIAMETRO_ANTOPOSTERIOR = "N009-MF000001612";
        public const string ECOGRAFIA_ABDOMINAL_LONGUITUD = "N009-MF000001613";
        public const string ECOGRAFIA_ABDOMINAL_CALIBRES_VASOS = "N009-MF000001614";
        public const string ECOGRAFIA_ABDOMINAL_CALIBRES_VASOS_DESCRIPCION = "N009-MF000001615";
        public const string ECOGRAFIA_ABDOMINAL_LIQUIDO_LIBRE_ANDOMINAL = "N009-MF000001616";
        public const string ECOGRAFIA_ABDOMINAL_NINGUNA = "N009-MF000001617";
        public const string ECOGRAFIA_ABDOMINAL_OBSERVACIONES = "N009-MF000001618";
        public const string ECOGRAFIA_ABDOMINAL_CONCLUSIONES = "N009-MF000001619";
        public const string ECOGRAFIA_ABDOMINAL_PAREMQUIMA_DESCRIPCION = "N009-MF000001620";
        public const string ECOGRAFIA_ABDOMINAL_LIQUIDO_LIBRE_ANDOMINAL_DESCRIPCION = "N009-MF000001621";
        #endregion

        #region ECOGRAFICO DE PROSTATA
        public const string INFORME_ECOGRAFICO_PROSTATA_ID = "N009-ME000000020";

        public const string INFORME_ECOGRAFICO_PROSTATA_MOTIVO_EXAMEN = "N009-MF000000455";
        public const string INFORME_ECOGRAFICO_PROSTATA_RECEPCION = "N009-MF000001622";
        public const string INFORME_ECOGRAFICO_PROSTATA_PAREDES1 = "N009-MF000001623";
        public const string INFORME_ECOGRAFICO_PROSTATA_PAREDES2 = "N009-MF000001624";
        public const string INFORME_ECOGRAFICO_PROSTATA_CONT_ANECOICO = "N009-MF000001625";
        public const string INFORME_ECOGRAFICO_PROSTATA_IAMGENES_EXPANSIVAS = "N009-MF000001626";
        public const string INFORME_ECOGRAFICO_PROSTATA_CALCULOS_INTERIOR = "N009-MF000001627";

        public const string INFORME_ECOGRAFICO_PROSTATA_TAMAÑO = "N009-MF000001629";
        public const string INFORME_ECOGRAFICO_PROSTATA_VOL_PREMICCIONAL = "N009-MF000001630";
        public const string INFORME_ECOGRAFICO_PROSTATA_VOL_POSMICCIONAL = "N009-MF000001631";
        public const string INFORME_ECOGRAFICO_PROSTATA_RETECION = "N009-MF000001632";

        public const string INFORME_ECOGRAFICO_PROSTATA_BORDES = "N009-MF000001635";
        public const string INFORME_ECOGRAFICO_PROSTATA_DIAMETRO_TRANSVERSO = "N009-MF000001636";
        public const string INFORME_ECOGRAFICO_PROSTATA_ANTERO = "N009-MF000001637";
        public const string INFORME_ECOGRAFICO_PROSTATA_DIAMETRO_LONGITUDINAL = "N009-MF000001638";
        public const string INFORME_ECOGRAFICO_PROSTATA_VOLUMEN = "N009-MF000001639";
        public const string INFORME_ECOGRAFICO_PROSTATA_VOLUMEN_VN = "N009-MF000001640";
        public const string INFORME_ECOGRAFICO_PROSTATA_ECOESTRUCTURA = "N009-MF000001641";
        public const string INFORME_ECOGRAFICO_PROSTATA_DESCRIPCION_OTROS = "N009-MF000001642";
        public const string INFORME_ECOGRAFICO_PROSTATA_NINGUNA = "N009-MF000001643";
        public const string INFORME_ECOGRAFICO_PROSTATA_OBSERVACIONES = "N009-MF000001644";
        public const string INFORME_ECOGRAFICO_PROSTATA_CONCLUSIONES = "N009-MF000001645";

        #endregion

        #region CUESTIONARIO DE ACTIVIDAD FÍSICA
        public const string CUESTIONARIO_ACTIVIDAD_FISICA = "N009-ME000000018";

        public const string CUESTIONARIO_ACTIVIDAD_FISICA_1 = "N009-MF000000440";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_2 = "N009-MF000001646";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_3 = "N009-MF000001647";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_4 = "N009-MF000001648";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_5 = "N009-MF000001649";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_6 = "N009-MF000001650";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_7 = "N009-MF000001651";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_8 = "N009-MF000001652";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_9 = "N009-MF000001653";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_10 = "N009-MF000001654";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_11 = "N009-MF000001655";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_12 = "N009-MF000001656";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_13 = "N009-MF000001661";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_14 = "N009-MF000001662";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_15 = "N009-MF000001663";
        public const string CUESTIONARIO_ACTIVIDAD_FISICA_16 = "N009-MF000001664";


        #endregion

        #region CUESTIONARIO NORDICO

        public const string C_N_ID = "N009-ME000000089";

        //CABECERA REPORTE
        public const string C_N_CABECERA_TIPO_TRABAJO_REALIZA_ID = "N009-MF000001468";
        public const string C_N_CABECERA_TIEMPO_LABOR_ID = "N009-MF000001469";
        public const string C_N_CABECERA_HORAS_TRABAJO_SEMANAL_ID = "N009-MF000001470";
        public const string C_N_CABECERA_DIESTRO_ID = "N009-MF000001471";
        public const string C_N_CABECERA_ZURDO_ID = "N009-MF000001472";


        //RESPONDIDOS POR TODOS
        public const string C_N_LOCOMOCION_TODOS_CUELLOS_ID = "N009-MF000001473";
        public const string C_N_LOCOMOCION_TODOS_HOMBROS_ID = "N009-MF000001474";
        public const string C_N_LOCOMOCION_TODOS_CODOS_ID = "N009-MF000001475";
        public const string C_N_LOCOMOCION_TODOS_MUÑECA_ID = "N009-MF000001476";
        public const string C_N_LOCOMOCION_TODOS_ESPALDA_ALTA_ID = "N009-MF000001477";
        public const string C_N_LOCOMOCION_TODOS_ESPALDA_BAJA_ID = "N009-MF000001478";
        public const string C_N_LOCOMOCION_TODOS_CADERAS_MUSLOS_ID = "N009-MF000001479";
        public const string C_N_LOCOMOCION_TODOS_RODILLAS_ID = "N009-MF000001480";
        public const string C_N_LOCOMOCION_TODOS_TOBILLOS_PIES_ID = "N009-MF000001481";



        // PROBLEMAS 12 MESES
        public const string C_N_LOCOMOCION_12_MESES_CUELLO_ID = "N009-MF000001519";
        public const string C_N_LOCOMOCION_12_MESES_HOMBROS_ID = "N009-MF000001520";
        public const string C_N_LOCOMOCION_12_MESES_CODOS_ID = "N009-MF000001521";
        public const string C_N_LOCOMOCION_12_MESES_MUÑECA_ID = "N009-MF000001522";
        public const string C_N_LOCOMOCION_12_MESES_ESPALDA_ALTA_ID = "N009-MF000001523";
        public const string C_N_LOCOMOCION_12_MESES_ESPALDA_BAJA_ID = "N009-MF000001524";
        public const string C_N_LOCOMOCION_12_MESES_CADERAS_MUSLOS_ID = "N009-MF000001525";
        public const string C_N_LOCOMOCION_12_MESES_RODILLAS_ID = "N009-MF000001526";
        public const string C_N_LOCOMOCION_12_MESES_TOBILLOS_ID = "N009-MF000001527";


        //PROBLEMAS 7 DIAS
        public const string C_N_LOCOMOCION_7_DIAS_CUELLO_ID = "N009-MF000001528";
        public const string C_N_LOCOMOCION_7_DIAS_HOMBROS_ID = "N009-MF000001529";
        public const string C_N_LOCOMOCION_7_DIAS_CODOS_ID = "N009-MF000001530";
        public const string C_N_LOCOMOCION_7_DIAS_MUÑECA_ID = "N009-MF000001531";
        public const string C_N_LOCOMOCION_7_DIAS_ESPALDA_ALTA_ID = "N009-MF000001532";
        public const string C_N_LOCOMOCION_7_DIAS_ESPALDA_BAJA_ID = "N009-MF000001533";
        public const string C_N_LOCOMOCION_7_DIAS_CADERA_ID = "N009-MF000001534";
        public const string C_N_LOCOMOCION_7_DIAS_RODILLAS_ID = "N009-MF000001535";
        public const string C_N_LOCOMOCION_7_DIAS_TOBILLOS_ID = "N009-MF000001536";


        //PROBLEMAS ESPALDA BAJA
        public const string C_N_ESPALDA_BAJA_PROBLEMAS_ESPALDA_BAJA_ID = "N009-MF000001483";
        public const string C_N_ESPALDA_BAJA_HOSPITALIZADO_PROBLEMA_ESPALDA_BAJA_ID = "N009-MF000001485";
        public const string C_N_ESPALDA_BAJA_CAMBIOS_TRABAJO_ACTIVIDAD_PROBLEMA_ESPALDA_BAJA_ID = "N009-MF000001486";
        public const string C_N_ESPALDA_BAJA_CURACION_TOTAL_ESPALDA_BAJA_ID = "N009-MF000001487";
        public const string C_N_ESPALDA_BAJA_ACTIVIDAD_TRABAJO_1_ID = "N009-MF000001489";
        public const string C_N_ESPALDA_BAJA_ACTIVIDAD_RECREATIVA_1_ID = "N009-MF000001490";

        //CABECERA SEGUNDA HOJA
        public const string C_N_DURACION_PRBLEMAS_IMPEDIR_RUTINA_1_ID = "N009-MF000001491";
        public const string C_N_VISTO_PROFESIONAL_ESPALDA_BAJA_ID = "N009-MF000001492";
        public const string C_N_PROBLEMAS_ESPALDA_BAJA_7_DIAS_ID = "N009-MF000001493";


        //PROBLEMAS CON LOS HOMBROS
        public const string C_N_PROBLEMAS_HOMBROS_PROBLEMAS_HOMBROS_ID = "N009-MF000001494";
        public const string C_N_PROBLEMAS_HOMBROS_LESION_HOMBROS_ACCIDENTES_ID = "N009-MF000001496";
        public const string C_N_PROBLEMAS_HOMBROS_CAMBIO_TRABAJO_ACTIVIDAD_HOMBROS_ID = "N009-MF000001497";
        public const string C_N_PROBLEMAS_HOMBROS_PROBLEMAS_HOMBROS_ULTIMOS_12_MESES_ID = "N009-MF000001498";
        public const string C_N_PROBLEMAS_HOMBROS_TIEMPO_TOTAL_PROBLEMAS_HOMBROS_ID = "N009-MF000001500";

        public const string C_N_PROBLEMAS_HOMBROS_ACTIVIDAD_TRABAJO_2_ID = "N009-MF000001502";
        public const string C_N_PROBLEMAS_HOMBROS_ACTIVIDAD_RECREATIVA_2_ID = "N009-MF000001503";
        public const string C_N_PROBLEMAS_HOMBROS_DURACION_PRBLEMAS_IMPEDIR_RUTINA_2_ID = "N009-MF000001504";
        public const string C_N_PROBLEMAS_HOMBROS_VISTO_PROFESIONAL_HOMBROS_ID = "N009-MF000001505";
        public const string C_N_PROBLEMAS_HOMBROS_PROBLEMAS_HOMBROS_DURANTE_7_DIAS_ID = "N009-MF000001518";

        //PROBLEMAS CON CUELLO
        public const string C_N_PROBLEMA_CUELLO_PROBLEMA_CUELLO_ID = "N009-MF000001506";
        public const string C_N_PROBLEMA_CUELLO_LESIONADO_CUELLO_ACCIDENTE_ID = "N009-MF000001508";
        public const string C_N_PROBLEMA_CUELLO_CAMBIO_TRABAJO_PROBLEMA_CUELLO_ID = "N009-MF000001509";
        public const string C_N_PROBLEMA_CUELLO_DURACION_TOTAL_TIEMPO_PROBLEMA_CUELLO_ID = "N009-MF000001510";

        public const string C_N_PROBLEMA_CUELLO_DURACION_PRBLEMAS_IMPEDIR_RUTINA_3_ID = "N009-MF000001513";
        public const string C_N_PROBLEMA_CUELLO_VISTO_PROFESIONAL_CUELLO_ID = "N009-MF000001514";
        public const string C_N_PROBLEMA_CUELLO_PROBLEMAS_CUELLO_DURANTE_7_DIAS_ID = "N009-MF000001515";
        public const string C_N_PROBLEMA_CUELLO_ACTIVIDAD_TRABAJO_3_ID = "N009-MF000001516";
        public const string C_N_PROBLEMA_CUELLO_ACTIVIDAD_RECREATIVA_3_ID = "N009-MF000001517";






        #endregion

        #region LABORATORIO

        #region HEMOGRAMA_COMPLETO

        public const string HEMOGRAMA_COMPLETO_ID = "N009-ME000000045";
        public const string HEMOGRAMA_COMPLETO_HEMOGRAMA_CONCLUSION_ID = "N009-MF000001152";
        public const string HEMOGRAMA_COMPLETO_CONCLUSIONES_DE_HEMOGRAMA = "N009-MF000000516";
        // 
        public const string HEMOGRAMA_COMPLETO_HEMATOCRITO = "N009-MF000001280";
        public const string HEMOGRAMA_COMPLETO_HEMOGLOBINA = "N009-MF000001282";
        public const string HEMOGRAMA_COMPLETO_HEMATIES = "N009-MF000000422";
        public const string HEMOGRAMA_COMPLETO_HEMATIES_VALOR_REF = "N009-MF000000423";
        public const string HEMOGRAMA_COMPLETO_LEUCOCITOS = "N009-MF000000424";
        public const string HEMOGRAMA_COMPLETO_PLAQUETAS = "N009-MF000001284";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_ABASTONADOS = "N009-MF000000426";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_SEGMENTADOS = "N009-MF000000428";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_EOSINOFILOS = "N009-MF000000430";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_BASOFILOS = "N009-MF000000432";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_MONOCITOS = "N009-MF000000434";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_LINFOCITOS = "N009-MF000000436";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_OBSERVACIONES = "N009-MF000000516";

        // Valores deseables
        public const string HEMOGRAMA_COMPLETO_HEMATOCRITO_DESEABLE = "N009-MF000001281";
        public const string HEMOGRAMA_COMPLETO_HEMOGLOBINA_DESEABLE = "N009-MF000001283";
        public const string HEMOGRAMA_COMPLETO_HEMATIES_DESEABLE = "N009-MF000000423";
        public const string HEMOGRAMA_COMPLETO_LEUCOCITOS_DESEABLE = "N009-MF000000425";
        public const string HEMOGRAMA_COMPLETO_PLAQUETAS_DESEABLE = "N009-MF000001285";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_ABASTONADOS_DESEABLE = "N009-MF000000427";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_SEGMENTADOS_DESEABLE = "N009-MF000000429";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_EOSINOFILOS_DESEABLE = "N009-MF000000431";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_BASOFILOS_DESEABLE = "N009-MF000000433";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_MONOCITOS_DESEABLE = "N009-MF000000435";
        public const string HEMOGRAMA_COMPLETO_FORMULA_LEUCOCITARIA_LINFOCITOS_DESEABLE = "N009-MF000000437";


        #endregion

        #region HEMOGRAMA

        public const string HEMATOCRITO_HEMOGRAMA_HEMATOCRITO = "N009-MF000000266";
        public const string HEMOGLOBINA_HEMOGRAMA_HEMOGLOBINA = "N009-MF000000265";

        //
        public const string HEMATOCRITO_HEMOGRAMA_HEMATOCRITO_DESEABLE = "N009-MF000000421";
        public const string HEMOGLOBINA_HEMOGRAMA_HEMOGLOBINA_DESEABLE = "N009-MF000000420";


        #endregion

        #region EXAMEN COMPLETO DE ORINA

        public const string EXAMEN_COMPLETO_DE_ORINA_ID = "N009-ME000000046";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_COLOR = "N009-MF000000444";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_ASPECTO = "N009-MF000001041";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_DENSIDAD = "N009-MF000001043";
        public const string EXAMEN_COMP_ORINA_MACROSCOPICO_DENSIDAD_DESEABLE = "N009-MF000003224";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_PH = "N009-MF000001045";
        public const string EXAMEN_COMP_ORINA_MACROSCOPICO_PH_DESEABLE = "N009-MF000003225";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CELULAS_EPITELIALES = "N009-MF000001059";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_LEUCOCITOS = "N009-MF000001061";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_HEMATIES = "N009-MF000001063";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_GERMENES = "N009-MF000001067";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CILINDROS = "N009-MF000001069";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CRISTALES = "N009-MF000001065";

        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_LEUCOCITOS = "N009-MF000003438";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_LEVADURAS = "N009-MF000003437";

        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_BILIRRUBINA = "N009-MF000003439";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_FILAMENTOS_MUCOIDES = "N009-MF000003440";

        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_FILAMENTO_MUCOIDE = "N009-MF000001071";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_NITRITOS = "N009-MF000001055";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_PROTEINAS = "N009-MF000001053";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_GLUCOSA = "N009-MF000001313";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_CETONAS = "N009-MF000001057";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_UROBILINOGENO = "N009-MF000001049";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_PIGMENTOS_BILIARES = "N009-MF000001051";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_SANGRE = "N009-MF000001047";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_HEMOGLOBINA = "N009-MF000001315";
        public const string EXAMEN_COMPLETO_DE_ORINA_CONCLUSIONES_ID = "N009-MF000001154";
        public const string EXAMEN_COMPLETO_DE_ORINA_ALBUMINA_ORINA_ID = "N009-MF000003209";
        public const string EXAMEN_COMPLETO_DE_ORINA_RESULTADO_ID = "N009-MF000003211";
        public const string EXAMEN_COMPLETO_DE_ORINA_RESULTADOS_ID = "N009-MF000003210";

        // Valor deseable
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_COLOR_DESEABLE = "N009-MF000001040";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_ASPECTO_DESEABLE = "N009-MF000001042";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_DENSIDAD_DESEABLE = "N009-MF000001044";
        public const string EXAMEN_COMPLETO_ORINA_MACROSCOPICO_PH_DESEABLE = "N009-MF000001046";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CELULAS_EPITELIALES_DESEABLE = "N009-MF000001060";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_LEUCOCITOS_DESEABLE = "N009-MF000001062";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_HEMATIES_DESEABLE = "N009-MF000001064";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_GERMENES_DESEABLE = "N009-MF000001068";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CILINDROS_DESEABLE = "N009-MF000001070";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_CRISTALES_DESEABLE = "N009-MF000001066";
        public const string EXAMEN_COMPLETO_ORINA_MICROSCOPICO_FILAMENTO_MUCOIDE_DESEABLE = "N009-MF000001072";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_NITRITOS_DESEABLE = "N009-MF000001056";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_PROTEINAS_DESEABLE = "N009-MF000001054";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_GLUCOSA_DESEABLE = "N009-MF000001314";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_CETONAS_DESEABLE = "N009-MF000001058";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_UROBILINOGENO_DESEABLE = "N009-MF000001050";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_BILIRRUBINA_DESEABLE = "N009-MF000001052";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_SANGRE_DESEABLE = "N009-MF000001048";
        public const string EXAMEN_COMPLETO_ORINA_BIOQUIMICO_HEMOGLOBINA_DESEABLE = "N009-MF000001316";
        public const string EXAMEN_COMPLETO_ORINA_CRISTALES_DEURATOS_AMORFOS = "N009-MF000003242";
        public const string EXAMEN_COMPLETO_ORINA_CRISTALES_FOSFATOS_AMORFOS = "N009-MF000003243";
        public const string EXAMEN_COMPLETO_ORINA_CRISTALES_FOSFATOS_TRIPLES = "N009-MF000003244";
        public const string EXAMEN_COMPLETO_ORINA_CILINDROS_GRANULOSOS = "N009-MF000003245";
        public const string EXAMEN_COMPLETO_ORINA_CILINDROS_LEUCOCITARIOS = "N009-MF000003246";
        public const string EXAMEN_COMPLETO_ORINA_CILINDROS_HEMATICOS = "N009-MF000003247";

        #endregion

        #region GRUPO Y FACTOR SANGUÍNEO

        public const string GRUPO_Y_FACTOR_SANGUINEO_ID = "N009-ME000000000";
        public const string GRUPO_SANGUINEO_ID = "N009-MF000000262";
        public const string FACTOR_SANGUINEO_ID = "N009-MF000000263";

        #endregion

        #region GAMMA GLUTAMIL TRANSPEPTIDASA

        public const string GAMMA_GLUTAMIL_ID = "N009-ME000000532";

        public const string GAMMA_GLUTAMIL_VALOR_RESULTADO = "N009-MF000004921";
        public const string GAMMA_GLUTAMIL_VALOR_DESEABLE = "N009-MF000004922";

        #endregion

        #region GLUCOSA

        public const string GLUCOSA_GLUCOSA_VALOR_RESULTADO_ID = "N009-MF000000261";
        public const string GLUCOSA_GLUCOSA_VALOR_DESEABLE_ID = "N009-MF000000418";

        #endregion

        #region COLESTEROL

        public const string COLESTEROL_ID = "N009-ME000000016";
        public const string COLESTEROL_COLESTEROL_TOTAL_ID = "N009-MF000001086";
        public const string COLESTEROL_COLESTEROL_TOTAL_DESEABLE_ID = "N009-MF000001087";

        #endregion

        #region TRIGLICERIDOS

        public const string TRIGLICERIDOS_ID = "N009-ME000000017";
        public const string TRIGLICERIDOS_BIOQUIMICA_TRIGLICERIDOS = "N009-MF000001296";
        public const string TRIGLICERIDOS_BIOQUIMICA_TRIGLICERIDOS_DESEABLE = "N009-MF000001297";

        #endregion

        #region COLESTEROL HDL

        public const string COLESTEROL_HDL_ID = "N009-ME000000074";
        public const string COLESTEROL_HDL_BIOQUIMICA_COLESTEROL_HDL = "N009-MF000000254";
        public const string COLESTEROL_HDL_BIOQUIMICA_COLESTEROL_TOTAL_HDL = "N009-MF000001077";

        public const string COLESTEROL_HDL_BIOQUIMICA_COLESTEROL_HDL_DESEABLE = "N009-MF000000414";
        public const string COLESTEROL_HDL_BIOQUIMICA_COLESTEROL_TOTAL_HDL_DESEABLE = "N009-MF000001078";

        #endregion

        #region COLESTEROL  LDL

        public const string COLESTEROL_LDL_ID = "N009-ME000000075";
        public const string COLESTEROL_LDL_BIOQUIMICA_COLESTEROL_LDL = "N009-MF000001073";
        public const string COLESTEROL_LDL_BIOQUIMICA_COLESTEROL_LDL_HDL = "N009-MF000001079";

        public const string COLESTEROL_LDL_BIOQUIMICA_COLESTEROL_LDL_DESEABLE = "N009-MF000001074";
        public const string COLESTEROL_LDL_BIOQUIMICA_COLESTEROL_LDL_HDL_DESEABLE = "N009-MF000001080";

        #endregion

        #region COLESTEROL VLDL

        public const string COLESTEROL_VLDL_ID = "N009-ME000000076";
        public const string COLESTEROL_VLDL_BIOQUIMICA_COLESTEROL_VLDL = "N009-MF000001075";

        public const string COLESTEROL_VLDL_BIOQUIMICA_COLESTEROL_VLDL_DESEABLE = "N009-MF000001076";

        #endregion

        #region CREATININA

        public const string CREATININA_ID = "N009-ME000000028";
        public const string CREATININA_BIOQUIMICA_CREATININA = "N009-MF000000518";

        public const string CREATININA_BIOQUIMICA_CREATININA_DESEABLE = "N009-MF000000519";

        #endregion

        #region ACIDO_URICO
        public const string ACIDO_URICO_BIOQUIMICA_ACIDO_URICO = "N009-MF000001425";
        public const string ACIDO_URICO_BIOQUIMICA_ACIDO_URICO_DESEABLE = "N009-MF000001426";

        #endregion

        #region ANTIGENO_PROSTATICO

        public const string ANTIGENO_PROSTATICO_ID = "N009-ME000000009";
        public const string ANTIGENO_PROSTATICO_ANTIGENO_PROSTATICO_VALOR = "N009-MF000000443";

        public const string ANTIGENO_PROSTATICO_VALOR_DESEABLE = "N009-MF000001287";

        #endregion

        #region BIOQUIMICA 01

        public const string BIOQUIMICA01_ID = "N009-ME000000086";
        public const string BIOQUIMICA01_VALOR = "N009-MF000001425";
        public const string BIOQUIMICA01_VALOR_DESEABLE = "N009-MF000001426";

        #endregion

        #region BIOQUIMICA 02

        public const string BIOQUIMICA02_ID = "N009-ME000000087";
        public const string BIOQUIMICA02_VALOR = "N009-MF000001427";
        public const string BIOQUIMICA02_VALOR_DESEABLE = "N009-MF000001428";

        #endregion

        #region BIOQUIMICA 03

        public const string BIOQUIMICA03_ID = "N009-ME000000088";
        public const string BIOQUIMICA03_VALOR = "N009-MF000001429";
        public const string BIOQUIMICA03_VALOR_DESEABLE = "N009-MF0000014330";

        #endregion

        #region PROTOMBINA
        public const string PROTOMBINA_ID = "N009-ME000000147";
        public const string PROTOMBINA_VALOR = "N009-MF000002182";
        public const string PROTOMBINA_VALOR_DESEABLE = "N009-MF000002183";
        #endregion

        #region INR
        public const string INR_ID = "N009-ME000000431";
        public const string INR_VALOR = "N009-MF000003238";
        public const string INR_VALOR_DESEABLE = "N009-MF000003239";
        #endregion

        #region METALES PESADOS

        public const string PLOMO_SANGRE_ID = "N009-ME000000060";
        public const string PLOMO_SANGRE_BIOQUIMICA_PLOMO_SANGRE = "N009-MF000001158";
        public const string PLOMO_SANGRE_BIOQUIMICA_PLOMO_SANGRE_DESEABLE = "N009-MF000001291";

        public const string CADMIO_ID = "N009-ME000000429";
        public const string CADMIO_RESULTADO = "N009-MF000003228";
        public const string CADMIO_DESEABLE = "N009-MF000003229";

        public const string PLOMO_SANGRE_MAGNESIO_ID = "N009-ME000000430";
        public const string PLOMO_SANGRE_MAGNESIO_RESULTADO_ID = "N009-MF000003230";
        public const string PLOMO_SANGRE_MAGNESIO_DESEABLE_ID = "N009-MF000003231";

        public const string COBRE_ID = "N009-ME000000426";
        public const string COBRE_RESULTADO_ID = "N009-MF000003222";
        public const string COBRE_DESEABLE_ID = "N009-MF000003223";
        #endregion

        #region TGO

        public const string TGO_ID = "N009-ME000000054";
        public const string TGO_BIOQUIMICA_TGO = "N009-MF000000706";

        public const string TGO_BIOQUIMICA_TGO_DESEABLE = "N009-MF000001292";

        #endregion

        #region TGP

        public const string TGP_ID = "N009-ME000000055";
        public const string TGP_BIOQUIMICA_TGP = "N009-MF000000707";

        public const string TGP_BIOQUIMICA_TGP_DESEABLE = "N009-MF000001293";

        #endregion

        #region UREA

        public const string UREA_ID = "N009-ME000000073";

        public const string UREA_BIOQUIMICA_UREA = "N009-MF000000253";
        public const string UREA_BIOQUIMICA_UREA_DESEABLE = "N009-MF000000256";

        #endregion

        #region AGLUTINACIONES_LAMINA

        public const string AGLUTINACIONES_LAMINA_ID = "N009-ME000000025";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_TIFICO_O = "N009-MF000001318";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_TIFICO_O_DESEABLE = "N009-MF000001319";

        public const string AGLUTINACIONES_LAMINA_REACTIVOS_TIFICO_H = "N009-MF000001320";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_TIFICO_H_DESEABLE = "N009-MF000001321";

        public const string AGLUTINACIONES_LAMINA_REACTIVOS_PARATIFICO_A = "N009-MF000000445";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_PARATIFICO_A_DESEABLE = "N009-MF000001322";

        public const string AGLUTINACIONES_LAMINA_REACTIVOS_PARATIFICO_B = "N009-MF000001323";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_PARATIFICO_B_DESEABLE = "N009-MF000001324";

        public const string AGLUTINACIONES_LAMINA_REACTIVOS_BRUCELLA = "N009-MF000001431";
        public const string AGLUTINACIONES_LAMINA_REACTIVOS_BRUCELLA_DESEABLE = "N009-MF000001432";


        #endregion

        #region  SUB UNIDAD BETA CUALITATIVO
        public const string SUB_UNIDAD_BETA_CUALITATIVO_ID = "N009-ME000000027";
        public const string SUB_UNIDAD_BETA_CUALITATIVO_RESULTADO = "N009-MF000000270";
        public const string SUB_UNIDAD_BETA_CUALITATIVO_DESEABLE = "N009-MF000001436";
        public const string SUB_UNIDAD_BETA_CUALITATIVO_OBSERVACION = "N009-MF000001437";


        #endregion

        #region  EXAMEN_ELISA




        public const string EXAMEN_ELISA__REACTIVOS_EXAMEN_ELISA_OBSERVACION = "N009-MF000001433";
        #endregion

        #region FACTOR REMATOIDEO
        public const string FACTOR_REMATOIDEO_ID = "N009-ME000000432";
        public const string FACTOR_REMATOIDEO_VALOR = "N009-MF000003240";
        #endregion

        #region PROTEINA C REACTIVA
        public const string PCR_ID = "N009-ME000000433";
        public const string PCR_VALOR = "N009-MF000003241";
        #endregion

        #region HEPATITIS A

        public const string HEPATITIS_A_ID = "N009-ME000000004";
        public const string HEPATITIS_A_REACTIVOS_HEPATITIS_A = "N009-MF000000264";

        public const string HEPATITIS_A_REACTIVOS_HEPATITIS_A_DESEABLE = "N009-MF000001289";
        public const string HEPATITIS_A_REACTIVOS_HEPATITIS_A_OBSERVACION = "N009-MF000001434";


        #endregion

        #region HEPATITIS C

        public const string HEPATITIS_C_ID = "N009-ME000000005";
        public const string HEPATITIS_C_REACTIVOS_HEPATITIS_C = "N009-MF000000267";

        public const string HEPATITIS_C_REACTIVOS_HEPATITIS_C_DESEABLE = "N009-MF000001290";
        public const string HEPATITIS_C_REACTIVOS_HEPATITIS_C_OBSERVACION = "N009-MF000001435";


        #endregion

        #region VDRL

        public const string VDRL_ID = "N009-ME000000003";
        public const string VDRL_REACTIVOS_VDRL = "N009-MF000000267";

        public const string LABORATORIO_VDRL_ID = "N009-MF000000269";

        public const string VDRL_REACTIVOS_VDRL_DESEABLE = "N009-MF000001290";
        public const string VDRL_REACTIVOS_VDRL_OBSERVACION = "N009-MF000001290";
        #endregion

        #region PARASITOLOGICO_SIMPLE

        public const string PARASITOLOGICO_SIMPLE_ID = "N009-ME000000010";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_COLOR = "N009-MF000000260";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_CONSISTENCIA = "N009-MF000001325";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_RESTOS_ALIMENTICIOS = "N009-MF000001326";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_SANGRE = "N009-MF000001327";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_MOCO = "N009-MF000001328";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_QUISTES = "N009-MF000001333";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_HUEVOS = "N009-MF000001334";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_TROFOZOITOS = "N009-MF000001335";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_HEMATIES = "N009-MF000001336";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_LEUCOCITOS = "N009-MF000001337";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_RESULTADOS = "N009-MF000001339";


        #endregion

        #region PARASITOLOGICO_SERIADO

        public const string PARASITOLOGICO_SERIADO_ID = "N009-ME000000049";
        // 1era Muestra
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_COLOR = "N009-MF000000515";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_CONSISTENCIA = "N009-MF000001329";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_RESTOS_ALIMENTICIOS = "N009-MF000001330";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_SANGRE = "N009-MF000001331";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_MOCO = "N009-MF000001340";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_QUISTES = "N009-MF000001343";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_HUEVOS = "N009-MF000001342";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_TROFOZOITOS = "N009-MF000001344";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_HEMATIES = "N009-MF000001345";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_LEUCOCITOS = "N009-MF000001346";
        // 2da Muestra
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_COLOR = "N009-MF000001347";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_CONSISTENCIA = "N009-MF000001348";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_RESTOS_ALIMENTICIOS = "N009-MF000001349";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_SANGRE = "N009-MF000001350";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_MOCO = "N009-MF000001351";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_QUISTES = "N009-MF000001353";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_HUEVOS = "N009-MF000001354";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_TROFOZOITOS = "N009-MF000001355";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_HEMATIES = "N009-MF000001356";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_SEGUNDA_LEUCOCITOS = "N009-MF000001357";
        // 3era Muestra
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_COLOR = "N009-MF000001358";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_CONSISTENCIA = "N009-MF000001359";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_RESTOS_ALIMENTICIOS = "N009-MF000001360";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_SANGRE = "N009-MF000001361";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_MOCO = "N009-MF000001362";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_QUISTES = "N009-MF000001364";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_HUEVOS = "N009-MF000001365";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_TROFOZOITOS = "N009-MF000001366";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_HEMATIES = "N009-MF000001367";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_LEUCOCITOS = "N009-MF000001368";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_TERCERA_RESULTADOS = "N009-MF000001370";

        #endregion

        #region BK_DIRECTO

        public const string BK_DIRECTO_ID = "N009-ME000000081";

        public const string BK_DIRECTO_MICROBIOLOGICO_MUESTRA = "N009-MF000001371";
        public const string BK_DIRECTO_MICROBIOLOGICO_COLORACION = "N009-MF000001372";
        public const string BK_DIRECTO_MICROBIOLOGICO_RESULTADOS = "N009-MF000001373";


        #endregion

        public const string INMUNIZACIONES_ID = "N009-ME000000407";

        #region TOXICOLOGIA

        public const string SALMONELLA_ID = "N009-ME000000427";
        public const string SALMONELLA_RESULTADO_ID = "N009-MF000003226";

        public const string PLOMO_ID = "N009-ME000000408";
        public const string PLOMO_RESULTADO = "N009-MF000003104";
        public const string PLOMO_DESEABLE = "N009-MF000003105";

        public const string CADMIO_EN_ORINA_ID = "N009-ME000000409";
        public const string CADMIO_EN_ORINA_RESULTADO_ID = "N009-MF000003106";
        public const string CADMIO_EN_ORINA_DESEABLE_ID = "N009-MF000003107";

        public const string MAGNESIO_ID = "N009-ME000000410";
        public const string MAGNESIO_RESULTADO_ID = "N009-MF000003108";
        public const string MAGNESIO_DESEABLE_ID = "N009-MF000003109";

        public const string BARBITURICOS_ID = "N009-ME000000417";
        public const string BARBITURICOS_RESULTADO_ID = "N009-MF000003213";

        public const string METANFETAMINAS_ID = "N009-ME000000338";
        public const string METANFETAMINAS_RESULTADO_ID = "N009-MF000003215";

        public const string MORFINA_ID = "N009-ME000000420";
        public const string MORFINA_RESULTADO_ID = "N009-MF000003216";

        public const string OPIACEOS_ID = "N009-ME000000421";
        public const string OPIACEOS_RESULTADO_ID = "N009-MF000003217";

        public const string METADONA_ID = "N009-ME000000418";
        public const string METADONA_RESULTADO_ID = "N009-MF000003214";

        public const string FENCICLIDINA_ID = "N009-ME000000423";
        public const string FENCICLIDINA_RESULTADO_ID = "N009-MF000003219";

        public const string ALCOHOL_EN_SALIVA_ID = "N009-ME000000416";
        public const string ALCOHOL_EN_SALIVA_RESULTADO_ID = "N009-MF000003212";

        public const string EXTASIS_ID = "N009-ME000000422";
        public const string EXTASIS_RESULTADO_ID = "N009-MF000003218";
        #endregion

        #region
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T = "N009-ME000000461";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_ENFERMEDAD = "N009-MF000003731";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_ENFERMEDAD_CUAL = "N009-MF000003732";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_CONSUME_MED = "N009-MF000003733";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_CONSUME_MED_CUAL = "N009-MF000003734";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_TOMA_MATE_COCA = "N009-MF000003735";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_TOMA_MATE_COCA_ULTIMA_VEZ = "N009-MF000003736";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_CHACCHA_COCA = "N009-MF000003737";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_CHACCHA_COCA_ULTIMA_VEZ = "N009-MF000003738";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_MARIHUANA = "N009-MF000003739";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_COCAINA = "N009-MF000003740";

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_LOTE= "N009-MF000003904";
        public const string TOXICOLOGICO_COCAINA_MARIHUANA_T_FECHA_VENC = "N009-MF000003905";


        #endregion
        #region TOXICOLOGICO_COCAINA_MARIHUANA_YANACOCHA

        public const string TOXICOLOGICO_COCAINA_MARIHUANA_ID = "N009-ME000000053";


        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_MUESTRA = "N009-MF000001374";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_METODO = "N009-MF000001375";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_COCAINA = "N009-MF000000705";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_MARIHUANA = "N009-MF000001294";


        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_CONSUME_ALGUN_MEDICAMENTO = "N009-MF000001398";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_CONSUME_ALGUN_MEDICAMENTO_CUAL = "N009-MF000001399";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_TOMA_MATECOCA = "N009-MF000001400";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_TOMA_MATECOCA_CUANTAS_VECES_SEMANA1 = "N009-MF000001401";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_TOMA_MATECOCA_ULTIMA_VEZ = "N009-MF000001403";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_CONSUME_HABITUALMENTE_PROD_COCA = "N009-MF000001404";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_CONSUME_HABITUALMENTE_PROD_COCA_CONSUMIO_ULTIMA_VEZ = "N009-MF000001405";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_TRATAMIENTO_ANESTESIA = "N009-MF000001406";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_SUFRE_ENFER = "N009-MF000001407";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_SUFRE_ENFER_CUAL = "N009-MF000001408";
        public const string COCAINA_MARIHUANA_TOXICOLOGICOS_CUANTAS_VECES_SEMANA2 = "N009-MF000001409";


        #endregion

        public const string LABORATORIO_HEMOGLOBINA_ID = "N009-ME000000006";
        public const string HEMOGLOBINA_ID = "N009-MF000000265";
        public const string LABORATORIO_HEMOGLOBINA_VALOR_DESEABLE_ID = "N009-MF000000420";

        public const string LABORATORIO_HEMATOCRITO_ID = "N009-ME000000001";
        public const string HEMATOCRITO_ID = "N009-MF000000266";


        public const string PERFIL_HIPIDICO_ID = "N009-ME000000007";
        public const string PERFIL_HIPIDICO_COLESTEROL_HDL_ID = "N009-MF000000254";
        public const string PERFIL_HIPIDICO_COLESTEROL_HDL_DESEABLE_ID = "N009-MF000000414";
        public const string PERFIL_HIPIDICO_TRIGLICERIDO_ID = "N009-MF000000268";
        public const string PERFIL_HIPIDICO_TRIGLICERIDO_DESEABLE_ID = "N009-MF000000419";



        public const string EXAMEN_D_HECES_ID = "N009-ME000000049";
        public const string EXAMEN_D_HECES_THENEVON_EXAMEN_DE_HECES_ID = "N009-MF000000515";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_LEVADURAS = "N009-MF000003256";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_GRASAS = "N009-MF000003257";
        public const string PARASITOLOGICO_SIMPLE_EXAMEN_HECES_RESULTADOS_SEDIM = "N009-MF000003258";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_LEVADURAS = "N009-MF000003259";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_GRASAS = "N009-MF000003260";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_DIRECTO = "N009-MF000003261";
        public const string PARASITOLOGICO_SERIADO_EXAMEN_HECES_PRIMERA_SEDIMENTACION = "N009-MF000003262";
        #endregion

        #region Test OjoSeco
        public const string TESTOJOSECO_ID = "N009-ME000000083";

        public const string TESTOJOSECO_ENROJECIMIENTO_OCULAR = "N009-MF000001380";
        public const string TESTOJOSECO_BORDE_PARPADOS_IMFLAMADOS = "N009-MF000001381";
        public const string TESTOJOSECO_COSTRAS_PARPADOS = "N009-MF000001382";
        public const string TESTOJOSECO_OJO_PEGADOS_LEVANTARSE = "N009-MF000001383";
        public const string TESTOJOSECO_SECRECION = "N009-MF000001384";
        public const string TESTOJOSECO_SEQUEDAD_OJO = "N009-MF000001385";
        public const string TESTOJOSECO_SEMSACION_ARENILLA = "N009-MF000001386";
        public const string TESTOJOSECO_SENSACION_CUERPO_EXTRANO = "N009-MF000001387";
        public const string TESTOJOSECO_ARDOR = "N009-MF000001388";
        public const string TESTOJOSECO_PICOR = "N009-MF000001389";
        public const string TESTOJOSECO_MALESTAR_OJO = "N009-MF000001390";
        public const string TESTOJOSECO_DOLO_AGUDO = "N009-MF000001391";
        public const string TESTOJOSECO_LAGRIMEO = "N009-MF000001392";
        public const string TESTOJOSECO_OJOS_LLOROSOS = "N009-MF000001393";
        public const string TESTOJOSECO_SENSIBILIDAD_LUZ = "N009-MF000001394";
        public const string TESTOJOSECO_VISION_BORROSA = "N009-MF000001395";
        public const string TESTOJOSECO_CANSANCIO_OJOS = "N009-MF000001396";
        public const string TESTOJOSECO_SENSACION_PESADEZ = "N009-MF000001397";
        #endregion

        #region MyRegion
        public const string ELECTROENCEFALOGRAMA_ID = "N009-ME000000099";
        public const string ELECTROENCEFALOGRAMA_OBSERVACIONES_ID = "N009-MF000001826";
        public const string ELECTROENCEFALOGRAMA_CONCLUSIONES_ID = "N009-MF000001827";
        #endregion

        public const string ELECTROCARDIOGRAMA_CONCLUSION_DESCRIPCION = "N009-MF000000227";
        public const string PAPANICOLAU_RADIOGRAFIA_RESULTADO_DE_LA_EVALUACION = "N009-MF000001138";

        public const string ECOGRAFIA_PELVICA_ID = "N009-ME000000019";
        public const string ECOGRAFIA_PELVICA_HALLAZGOS = "N009-MF000000456";

        public const string ECOGRAFIA_TRANSVAGINAL_ID = "N009-ME000000050";
        public const string ECOGRAFIA_TRANSVAGINAL_HALLAZGOS = "N009-MF000000517";
        public const string RESULTADOS_DE_ECOGRAFIA_HALLAZGOS = "N009-MF000001163";

        public const string COLONOSCOPIA_ID = "N009-ME000000020";
        public const string COLONOSCOPIA_HALLAZGOS = "N009-MF000000455";

        public const string DENSITOMETRIA_OSEA_ID = "N009-ME000000018";


        public const string DENSITOMETRIA_OSEA_HALLAZGOS = "N009-MF000000440";

        public const string ECOGRAFIA_MAMA_ID = "N009-ME000000061";


        public const string R_P_R_ID = "N009-ME000000425";
        public const string INMUNOLOGIA_R_P_R_ID = "N009-MF000003221";

        public const string HBSAG_ID = "N009-ME000000301";

        public const string GGTP_ID = "N009-ME000000424";
        public const string GGTP_REACTIVOS = "N009-MF000003220";

        


        #region IDs Informes

        public const string CERTIFICADO_APTITUD_MEDICO_OCUPACIONAL = "CAMO";

        public const string INFORME_ANEXO_312 = "312";
        public const string INFORME_ANEXO_7C = "7C";
        public const string INFORME_FICHA_MEDICA_TRABAJADOR = "FMT";
        public const string INFORME_FICHA_MEDICA_TRABAJADOR_2 = "FMT2";
        public const string INFORME_FICHA_MEDICA_TRABAJADOR_3 = "FMT3";
        public const string INFORME_HISTORIA_OCUPACIONAL = "HOC";
        public const string INFORME_RADIOGRAFICO_OIT = "ROIT";
        public const string INFORME_CLINICO = "IC";
        public const string INFORME_MEDICO_RESUMEN = "IMR";
        public const string INFORME_LABORATORIO_CLINICO = "ILAB_CLINICO";
        public const string INFORME_EXAMENES_ESPECIALES = "EXAM_ESP";

        public const string INFORME_CERTIFICADO_APTITUD = "CAP";
        public const string INFORME_CERTIFICADO_APTITUD_EMPRESARIAL = "CAPE";
        public const string INFORME_CERTIFICADO_APTITUD_SM = "CAPSM";
        public const string INFORME_CERTIFICADO_APTITUD_COMPLETO = "CAPC";
        public const string INFORME_CERTIFICADO_APTITUD_SIN_DX = "CAPSD";
        public const string CONSENTIMIENTO_INFORMADO = "CI";

        public const string INFORME_FICHA_MEDICA_TRABAJADOR_CI = "FMT_CI";
        public const string HISTORIA_CLINICA = "HIST_CLI";
        public const string ATENCION_INTEGRAL = "ATENCION_INTEGRAL";

        public const string MI_EXAMEN = "N009-ME000000434";
        public const string Campo_2 = "N009-MF000003293";
        public const string Campo_1 = "N009-MF000003294";

        public const string FORMATO_ATENCION_INTEGRAL_ADULTO_MAYOR = "ATE_ADULT_MAYOR";
        public const string FORMATO_ATENCION_INTEGRAL_ADULTO = "ATE_ADULTO";
        public const string FORMATO_ATENCION_INTEGRAL_ADOLESCENTE = "ATE_ADOLE";
        public const string FORMATO_ATENCION_NINIO = "FA_NINIO";
        public const string INFORME_ANEXO_16_COIMOLACHE = "7C-COIMOLACHE";
        public const string INFORME_ANEXO_16_PACASMAYO = "7C-PACASMAYO";
        public const string INFORME_ANEXO_16_MINSURSANRAFAEL = "7C-MINSURSANRAFAEL";
        public const string INFORME_ANEXO_16_YANACOCHA = "7C-YANACOCHA";
        public const string INFORME_ANEXO_16_SHAHUINDO = "7C-SHAHUINDO";
        public const string INFORME_ANEXO_16_GOLD_FIELD = "7C-GOLD_FIELD";
        public const string INFORME_ANTECEDENTE_PATOLOGICO = "ANTECEDENTE_PATL";

        public const string INFORME_DECLARACION_CI = "DECLARACION_CI";
        public const string INFORME_ESPIROMETRIA = "INFORME_ESPIRO";

        public const string APTITUD_YANACOCHA = "APT_YANA";
        #endregion
        #region Nazca

        public const string ANSIEDAD_ZUNG = "ANS-ZUNG";
        public const string ESCALA_FATIGA = "ESC-FATIGA";
        public const string INV_MASLACH = "INV-MASLACH";
        public const string TEST_SOMNOLENCIA = "TEST-SOMNO";
        #endregion
        #region DECLARACION JURADA PSICOLOGIA COIMOLACHE - LA ZANJA
        public const string D_J_PSICOLOGIA_COIMOLACHE_LA_ZANJA_ID= "N009-ME000000457";

        public const string D_J_P_COIMOLACHE_LA_ZANJA_ENFERMEDAD_MENTAL = "N009-MF000003673";
        public const string D_J_P_COIMOLACHE_LA_ZANJA_SI_DESCRIPCION = "N009-MF000003676";
        public const string D_J_P_COIMOLACHE_LA_ZANJA_OTRAS_ENFERMEDADES= "N009-MF000003677";
        #endregion

        #region TOTTUS
        public const string REACCION_INFLAMATORIA_ID_T = "N009-ME000000525";

        public const string REACCION_INFLAMATORIA_HEMATIES = "N009-MF000004442";
        public const string REACCION_INFLAMATORIA_LEVADURAS = "N009-MF000004443";
        public const string REACCION_INFLAMATORIA_GRASAS = "N009-MF000004444";
        public const string REACCION_INFLAMATORIA_LEUCOCITOS = "N009-MF000004445";
        public const string REACCION_INFLAMATORIA_POLIMORFONUCLEARES = "N009-MF000004446";
        public const string REACCION_INFLAMATORIA_MONONUCLEARES = "N009-MF000004447";
        public const string REACCION_INFLAMATORIA_RESULTADO = "N009-MF000004448";
        public const string REACCION_INFLAMATORIA_OBSERVACION = "N009-MF000004449";

        #endregion

        #region ADICIONALES CIELO AZUL

        public const string PARASITOLOGICO_COPROCULTIVO_CIELO_AZUL = "PAR-COP-CIELO_AZUL";
        public const string AGLUTINACIONES_KOH_SECRECION = "AGLU-KOH-SEC-CIELO_AZUL";
        
        public const string ADICIONALES_CIELO_AZUL = "N009-ME000000454";
        public const string CABECERA_DATOS_IDENTIFICACION = "N009-MF000003253";
        public const string CABECERA_DATOS_FECHA_EMISION = "N009-MF000003254";
        public const string CABECERA_DATOS_MEDICO = "N009-MF000003255";

        public const string MICROBIOLOGIA_ID = "N009-ME000000097";
        public const string MICROBIOLOGIA_C_A_COLOR = "N009-MF000001812";
        public const string MICROBIOLOGIA_C_A_CONSISTENCIA = "N009-MF000002069";
        public const string MICROBIOLOGIA_C_A_MOCO = "N009-MF000002070";
        public const string MICROBIOLOGIA_C_A_RESTOS_ALIMENTICIOS = "N009-MF000003251";
        public const string MICROBIOLOGIA_C_A_LEUCOCITOS = "N009-MF000003252";
        public const string MICROBIOLOGIA_C_A_THEVENON = "N009-MF000003662";

        public const string PARASITOLOGICO_SERIADO_CIELO_AZUL_ID = "N009-ME000000452";
        public const string METODO_DIRECTO_C_A = "N009-MF000003663";
        public const string METODO_SEDIMENTACION_C_A = "N009-MF000003664";
        public const string CANTIDAD_DE_EXAMENES = "N009-MF000004633";

        public const string COPROCULTIVO_ID = "N009-ME000000453";
        public const string COPROCULTIVO = "N009-MF000003665";

        public const string INMUNOLOGIA_ID_CA = "N009-ME000000455";
        public const string INMUNOLOGIA_A_CA = "N009-MF000003666";
        public const string INMUNOLOGIA_B_CA = "N009-MF000003667";
        public const string INMUNOLOGIA_O_CA = "N009-MF000003668";
        public const string INMUNOLOGIA_H_CA= "N009-MF000003669";
        public const string BRUCELLS_SBORTUS_CA = "N009-MF000003670";

        public const string RASPADO_UÑAS_ID= "N009-ME000000451";
        public const string RASPADO_UÑAS = "N009-MF000003661";

        public const string SECRECION_FARINGEA_ID = "N009-ME000000456";
        public const string MUESTRA_SECRECION_FARINGEA = "N009-MF000003671";
        public const string GERMEN_AISLADO_SECRECION_FARINGEA = "N009-MF000003672";


        #endregion

        #region EXAMEN DE SUFICIENCIA MÉDICA PARA OPERADORES DE EQUIPOS MÓVILES V 2.0
        public const string EXAMEN_SUF_MED__OPERADORES_ID = "N009-ME000000439";

        public const string EXAMEN_SUF_MED__OPERADORES_1_CRISIS_CONV = "N009-MF000003390";
        public const string EXAMEN_SUF_MED__OPERADORES_1_CRISIS_AUSEN = "N009-MF000003391";
        public const string EXAMEN_SUF_MED__OPERADORES_1_MOV_INVOLUNTARIO = "N009-MF000003392";
        public const string EXAMEN_SUF_MED__OPERADORES_1_MEDITACION_PCOTROP= "N009-MF000003393";
        public const string EXAMEN_SUF_MED__OPERADORES_1_DIABETES_MELITUS = "N009-MF000003394";
        public const string EXAMEN_SUF_MED__OPERADORES_1_INSUFICIENCIA_RENAL_CRO = "N009-MF000003395";
        public const string EXAMEN_SUF_MED__OPERADORES_1_INSUF_CARDIACA_CONG = "N009-MF000003396";
        public const string EXAMEN_SUF_MED__OPERADORES_1_INSUF_CORONARIA_CRON = "N009-MF000003397";
        public const string EXAMEN_SUF_MED__OPERADORES_1_CONSUMO_DROGAS_ILEGALES = "N009-MF000003398";
        public const string EXAMEN_SUF_MED__OPERADORES_1_DIPOPIA_NO_CORREGIDA = "N009-MF000003399";
        public const string EXAMEN_SUF_MED__OPERADORES_1_ARRITMIA_CARDIACA = "N009-MF000003400";
        public const string EXAMEN_SUF_MED__OPERADORES_1_HIPERTENSION_MALIGNA= "N009-MF000003401";
        public const string EXAMEN_SUF_MED__OPERADORES_1_PORTADOR_MARCAPASO_CARDIACO = "N009-MF000003402";
        public const string EXAMEN_SUF_MED__OPERADORES_1_PORTADOR_PROTESIS_VALVULAR = "N009-MF000003403";

        public const string EXAMEN_SUF_MED__OPERADORES_2_INTRANQUILIDAD = "N009-MF000003404";
        public const string EXAMEN_SUF_MED__OPERADORES_2_PROBLEMAS_SUEÑO = "N009-MF000003405";
        public const string EXAMEN_SUF_MED__OPERADORES_2_LABILIDAD_EMOCIONAL = "N009-MF000003406";
        public const string EXAMEN_SUF_MED__OPERADORES_2_BAJA_PESO_RECIENTE = "N009-MF000003407";
        public const string EXAMEN_SUF_MED__OPERADORES_2_FOBIAS_ALTURA = "N009-MF000003408";
        public const string EXAMEN_SUF_MED__OPERADORES_2_CONSUMO_DROGAS = "N009-MF000003409";

        public const string EXAMEN_SUF_MED__OPERADORES_3_FUNCIONES_VITALES = "N009-MF000003410";
        public const string EXAMEN_SUF_MED__OPERADORES_3_APARATO_LOCOMOTOR = "N009-MF000003411";
        public const string EXAMEN_SUF_MED__OPERADORES_3_FUERZA_MUSCULAR = "N009-MF000003412";
        public const string EXAMEN_SUF_MED__OPERADORES_3_PRUEBAS_VESTIBULARES = "N009-MF000003413";
        public const string EXAMEN_SUF_MED__OPERADORES_3_AGUDEZA_VISUAL= "N009-MF000003414";
        public const string EXAMEN_SUF_MED__OPERADORES_3_VISION_CROMATICA = "N009-MF000003415";
        public const string EXAMEN_SUF_MED__OPERADORES_3_VISION_ESTEREOSCOPICA = "N009-MF000003416";
        public const string EXAMEN_SUF_MED__OPERADORES_3_UMBRAL_AUDITIVO = "N009-MF000003417";

        public const string EXAMEN_SUF_MED__OPERADORES_4_APTO_TRABAJO_SI = "N009-MF000003419";
        public const string EXAMEN_SUF_MED__OPERADORES_4_APTO_TRABAJO_NO = "N009-MF000003420";
        #endregion
        #region PSICOSENSOMETRICO DATOS
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_ID = "N009-ME000000438";

        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_N_LICENCIA = "N009-MF000003366";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_LICENCIA_CLASE_CATEGORIA = "N009-MF000003367";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_EQUIPO_VEHICULO = "N009-MF000003368";

        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_1_EVALUACION = "N009-MF000003369";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_1_RE_EVALUACION = "N009-MF000003370";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_2_RE_EVALUACION = "N009-MF000003371";

        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_AGUDEZA_VISUAL = "N009-MF000003372";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_PALANCAS = "N009-MF000003373";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_VISION_PROFUNDIDAD = "N009-MF000003374";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_PUNTEO = "N009-MF000003375";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_DISCRIMINACION_COLORES = "N009-MF000003376";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_REACCION_SIMPLE = "N009-MF000003377";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_FORIA = "N009-MF000003378";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_ANTICIPACION = "N009-MF000003379";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_VISION_NOCTURNA = "N009-MF000003380";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_REACCIONES_MULTIPLES = "N009-MF000003381";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_ENCANDILAMIENTO= "N009-MF000003382";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_REACCION_MONOTONIA_CANSANCIO = "N009-MF000003383";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_PERIMETRIA = "N009-MF000003384";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_TEST_COORDINACION_BIMANUAL = "N009-MF000003385";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_OIDO_DERECHO = "N009-MF000003386";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_OIDO_IZQUIERDO = "N009-MF000003387";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_RESULTADO_FINAL = "N009-MF000003388";
        public const string CERTIFICADO_PSICOSENSOMETRICO_DATOS_RESTRICCIONES = "N009-MF000003389";
        #endregion

        #region OFTALMOLOGIA
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_ID = "N009-ME000000447";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_DESCRIPCION_LAB = "N009-MF000003541";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_DESCRIPCION_PAT = "N009-MF000003542";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VCSCOD = "N009-MF000003547";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VCSCOI = "N009-MF000003548";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VCCCOD = "N009-MF000003549";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VCCCOI = "N009-MF000003550";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VLSCOD = "N009-MF000003551";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VLSCOI = "N009-MF000003552";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VLCCOD = "N009-MF000003553";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VLCCOI = "N009-MF000003554";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_VISION_COLORES = "N009-MF000003555";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_ENFERMEDADES_OCULARES = "N009-MF000003556";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_REFLEJOS_PUPILARES = "N009-MF000003557";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_TEST_VISION_ESTEREOSCOPICA = "N009-MF000004316";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_APTITUD_SI = "N009-MF000003558";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_APTITUD_NO = "N009-MF000003559";

        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_EXAMENES_AUXILIARES = "N009-MF000003560";
        public const string EXAMEN_OFTALMOLOGICO_SIMPLE_CORRECTORES = "N009-MF000004357";

        ///

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_ID = "N009-ME000000448";

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VLSCOD = "N009-MF000003565";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VLSCOI = "N009-MF000003566";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VLCCOD = "N009-MF000003567";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VLCCOI = "N009-MF000003568";

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VCSCOD = "N009-MF000003569";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VCSCOI = "N009-MF000003570";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VCCCOD = "N009-MF000003571";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_VCCCOI = "N009-MF000003572";

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_TEST_ISHIHARA = "N009-MF000003573";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_TEST_WAGGONER = "N009-MF000003574";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_TEST_LEGRAND = "N009-MF000003575";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_FLY_TEST = "N009-MF000003576";

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_MEO = "N009-MF000003577";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_SA = "N009-MF000003578";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_ANEXOS = "N009-MF000003579";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_FONDO_OJO = "N009-MF000003580";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_TONOMETRIA_OD = "N009-MF000003581";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_TONOMETRIA_OI = "N009-MF000003582";

        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_REFRACCION = "N009-MF000003583";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_REFLEJOS_PUPILARES = "N009-MF000003584";

        //public const string EXAMEN_OFTALMOLOGICO_COMPLETO_DIAGNOSTICO = "N009-MF000003585";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_RP = "N009-MF000003586";
        public const string EXAMEN_OFTALMOLOGICO_COMPLETO_CORRECTORES = "N009-MF000004358";

        //public const string EXAMEN_OFTALMOLOGICO_COMPLETO_RECOMENDACION = "N009-MF000003587";
        
        ///

        public const string APENDICE_N_2_EVALUACION_OFTALMOLOGICA_YANACOCHA_ID = "N009-ME000000449";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VCSCOD = "N009-MF000003614";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VCSCOI = "N009-MF000003615";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VCCCOD = "N009-MF000003616";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VCCCOI = "N009-MF000003617";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VLSCOD = "N009-MF000003618";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VLSCOI = "N009-MF000003619";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VLCCOD = "N009-MF000003620";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_VLCCOI = "N009-MF000003621";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_ENFERMEDADES_OCULARES = "N009-MF000003592";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_TEST_ISHIHARA = "N009-MF000003593";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_REFLEJOS_PUPILARES = "N009-MF000003594";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_PRESION_INTRAOCULAR_OD = "N009-MF000003595";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_PRESION_INTRAOCULAR_OI = "N009-MF000003596";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_MACULA_OD = "N009-MF000003597";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_MACULA_OI = "N009-MF000003598";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_NERVIO_OPTICO_OD = "N009-MF000003599";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_NERVIO_OPTICO_OI = "N009-MF000003600";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_RETINA_OD = "N009-MF000003601";
        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_RETINA_OI = "N009-MF000003602";

        public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_CORRECTORES = "N009-MF000004359";


        //public const string EVALUACION_OFTALMOLOGICA_APENDICE_N_2_YANACOCHA_OBSERVACIONES = "N009-MF000003603";

        ///
        public const string INFORME_OFTALMOLOGICO_HUDBAY_ID = "N009-ME000000450";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_AREA = "N009-MF000003604";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_RESULTADOS_ULTIMO_EXAM_MED = "N009-MF000003605";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_EXAM_CLIN_EXTERNO = "N009-MF000003606";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_CORRECTORES_OCULARES_SI = "N009-MF000003608";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_CORRECTORES_OCULARES_NO = "N009-MF000003609";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_VCSCOD = "N009-MF000003622";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VCSCOI = "N009-MF000003623";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VCCCOD = "N009-MF000003624";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VCCCOI = "N009-MF000003625";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_VLSCOD = "N009-MF000003626";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VLSCOI = "N009-MF000003627";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VLCCOD = "N009-MF000003628";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VLCCOI = "N009-MF000003629";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_MOVIMIENTOS_OCULARES_OD = "N009-MF000003632";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_MOVIMIENTOS_OCULARES_OI = "N009-MF000003633";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_FONDO_OJO_OD = "N009-MF000003634";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_FONDO_OJO_OI = "N009-MF000003635";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_POLO_ANTERIOR_OD = "N009-MF000003636";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_POLO_ANTERIOR_OI = "N009-MF000003637";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_CAMARA_ANTERIOR_OD = "N009-MF000003638";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_CAMARA_ANTERIOR_OI = "N009-MF000003639";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_CRISTALINO_OD = "N009-MF000003640";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_CRISTALINO_OI = "N009-MF000003641";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_VITREO_OD = "N009-MF000003642";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VITREO_OI = "N009-MF000003643";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_NERVIO_OPTICO_OD = "N009-MF000003644";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_NERVIO_OPTICO_OI = "N009-MF000003645";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_VASOS_RETINALES_OD = "N009-MF000003646";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VASOS_RETINALES_OI = "N009-MF000003647";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_RETINA_OD = "N009-MF000003648";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_RETINA_OI = "N009-MF000003649";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_CAMPOS_VISUALES_OD = "N009-MF000003650";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_CAMPOS_VISUALES_OI = "N009-MF000003651";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_TONOMETRIA_OD = "N009-MF000003656";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_TONOMETRIA_OI = "N009-MF000003657";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_TEST_ISHIHARA = "N009-MF000003652";
        public const string INFORME_OFTALMOLOGICO_HUDBAY_VISION_ESTEREOSCOPICA = "N009-MF000003653";

        public const string INFORME_OFTALMOLOGICO_HUDBAY_CORRECTORES = "N009-MF000004360";
        //public const string INFORME_OFTALMOLOGICO_HUDBAY_DIAGNOSTICO = "N009-MF000003654";
        //public const string INFORME_OFTALMOLOGICO_HUDBAY_INDICACIONES = "N009-MF000003655";

        #endregion

        public const string INFORME_MEDICO_SALUD_OCUPACIONAL_EXAMEN_MEDICO_ANUAL = "INF-MED-SO-EX-MED-ANUAL";
        public const string ANEXO_8_INFORME_MEDICO_OCUPACIONAL = "ANEXO-8-INF-MED-OC";
        public const string INFORME_RESULTADOS_EVALUACION_MEDICA = "INFRES-EVALUACION-MED-AUT";

        #region
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_ID = "N009-ME000000459";

        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_TIPO_VISITA = "N009-MF000003678";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_PERMANENCIA_CERRO_CORONA = "N009-MF000003679";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_ESTANCIA_FRECUENTES= "N009-MF000003680";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_ESTANCIA_OCASIONALES = "N009-MF000003681";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_ESTANCIA_NUNCA = "N009-MF000003682";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP1 = "N009-MF000003684";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP2 = "N009-MF000003685";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP3 = "N009-MF000003686";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP4 = "N009-MF000003687";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP5 = "N009-MF000003688";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP6 = "N009-MF000003689";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP7 = "N009-MF000003690";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP8 = "N009-MF000003691";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP9 = "N009-MF000003692";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP10 = "N009-MF000003693";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP11 = "N009-MF000003694";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP12 = "N009-MF000003695";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP13 = "N009-MF000003696";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP14 = "N009-MF000003697";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP15 = "N009-MF000003698";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP16 = "N009-MF000003699";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP17 = "N009-MF000003700";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP18 = "N009-MF000003701";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP19 = "N009-MF000003702";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_RP20 = "N009-MF000003703";

        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_PIEL_FANERAS = "N009-MF000003704";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_CV = "N009-MF000003705";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_CABEZA_CUELLO = "N009-MF000003706";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_SOMA = "N009-MF000003707";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_TYP = "N009-MF000003708";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_SNC = "N009-MF000003709";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_OBSERVACIONES = "N009-MF000003710";
        public const string EXAMEN_MEDICO_VISITANTES_GOLDFIELDS_DIAS_AUTORIZADOS = "N009-MF000003711";

        

        #endregion
        #region FICHA PSICOLÓGICA GOLDFIES
        public const string FICHA_PSICOLOGICA_OCUPACIONAL_GOLDFIELDS = "N009-ME000000443";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_EMPRESA_ACTUAL = "N009-MF000003441";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_AREA_LUGAR = "N009-MF000003442";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PROVINCIA_DEPARTAMENTO = "N009-MF000003443";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_TIEMPO_TOTAL_LAB = "N009-MF000003444";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_EXPERIENCIA_PUESTO = "N009-MF000003445";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PRINCIPALES_RIESGOS = "N009-MF000003447";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_MEDIDAS_SEGURIDAD = "N009-MF000003448";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_FECHA_INGRESO1 = "N009-MF000003456";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_NOMBRE_EMPRESA1 = "N009-MF000003457";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_ACTIVIDAD_EMPRESA1 = "N009-MF000003458";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PUESTO_EMPRESA1 = "N009-MF000003459";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PERMANENCIA_TIEMPO1 = "N009-MF000003460";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PERMANENCIA_FECHA_SALIDA1 = "N009-MF000003461";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_CAUSA_CESE1 = "N009-MF000003462";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_FECHA_INGRESO2 = "N009-MF000003463";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_NOMBRE_EMPRESA2 = "N009-MF000003464";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_ACTIVIDAD_EMPRESA2 = "N009-MF000003465";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PUESTO_EMPRESA2 = "N009-MF000003466";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PERMANENCIA_TIEMPO2 = "N009-MF000003467";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_PERMANENCIA_FECHA_SALIDA2 = "N009-MF000003468";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_CAUSA_CESE2 = "N009-MF000003469";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_HISTORIA_FAMILIAR = "N009-MF000003470";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_ENFERMEDADES_ACCIDENTES = "N009-MF000003471";

        public const string FICHA_PSICOLOGICA_GOLDFIELDS_ENFERMEDAD_SALUD_MENTAL = "N009-MF000003472";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_DESCRIPCION_SALUD_MENTAL = "N009-MF000003474";
        public const string FICHA_PSICOLOGICA_GOLDFIELDS_OTRAS_ENFEREMDADES= "N009-MF000003475";
        #endregion

        #region INFORME PSICOLÓGICO GOLDFIES
       
        public const string INFORME_PSICOLOGICO_OCUPACIONAL_GOLDFIELDS = "N009-ME000000444";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_SUPERVISOR = "N009-MF000003476";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PUESTO_TRABAJO = "N009-MF000003477";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_LUGAR_TRABAJO = "N009-MF000003478";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_BREVETE = "N009-MF000003479";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_SI_BREVETE = "N009-MF000003480";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONDUCIRA = "N009-MF000003481";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONDUCTA_OBS = "N009-MF000003482";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_COEFICIENTE_INTELECTUAL = "N009-MF000003486";


        //SEC INCOMPLETA
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ORIENTACION = "N009-MF000003487";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ATENCION_CONCENTRACION = "N009-MF000003488";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_MEMORIA = "N009-MF000003489";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_COMPRENSION = "N009-MF000003490";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_STROOP = "N009-MF000003491";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONCLUSION_FUNC_COG_COMPROMETIDAS = "N009-MF000003492";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONCLUSION_FUNC_COG_NORMALES = "N009-MF000003493";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_TRABAJO_EQUIPO = "N009-MF000003495";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_COMUNICACION = "N009-MF000003496";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_COMPROMISO = "N009-MF000003497";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_MOTIVACION = "N009-MF000003498";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_DESCRIP_ASP_INTRAE_INTER_1 = "N009-MF000003499";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PERFIL_PERSONALIDAD_TEST_COLORES = "N009-MF000003500";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ADAPTABILIDAD_CAPACIDAD_AFRONTE = "N009-MF000003501";
        //SEC COMPLETA
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ORIENTACION1 = "N009-MF000003533";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ATENCION_CONCENTRACION1 = "N009-MF000003534";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_MEMORIA1 = "N009-MF000003535";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_COMPRENSION1 = "N009-MF000003537";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_HABILIDADES_VISIOCONSTRUCTIVAS1 = "N009-MF000003536";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONCLUSION_FUNC_COG_COMPROMETIDAS1 = "N009-MF000003539";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_CONCLUSION_FUNC_COG_NORMALES1 = "N009-MF000003540";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_DESCRIP_ASP_INTRAE_INTER_2 = "N009-MF000003502";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ESCALA_SIG_1_PERFIL_PERSONALIDAD = "N009-MF000003503";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ESCALA_SIG_2_PERFIL_PERSONALIDAD = "N009-MF000003504";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ESCALA_SIG_3_PERFIL_PERSONALIDAD = "N009-MF000003505";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ESCALA_SIG_4_PERFIL_PERSONALIDAD = "N009-MF000003506";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PUNTAJE_1_PERFIL_PERSONALIDAD = "N009-MF000003507";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PUNTAJE_2_PERFIL_PERSONALIDAD = "N009-MF000003508";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PUNTAJE_3_PERFIL_PERSONALIDAD = "N009-MF000003509";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PUNTAJE_4_PERFIL_PERSONALIDAD = "N009-MF000003510";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_DESC_PERFIL_PERSONALIDAD = "N009-MF000003511";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ADAPTABILIDAD_RELACIONES1 = "N009-MF000003515";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ADAPTABILIDAD_AUTORRELACIONES1 = "N009-MF000003516";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ADAPTABILIDAD_ESTABILIDAD_CAMBIOS = "N009-MF000003517";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ADAPTABILIDAD_DESC = "N009-MF000003518";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_EVALUACIONES_COMPLEMENTARIAS_MASLACH = "N009-MF000003519";

        //
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ESENCIA_TAREA = "N009-MF000003520";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_SISTEMA_TRABAJO = "N009-MF000003521";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_INTERACCION_SOCIAL = "N009-MF000003522";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_ORGANIZACIONALES = "N009-MF000003523";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_RIESGOS_PSICOSOCIALES = "N009-MF000004317";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_PSICOSENSOMETRICO_DESC = "N009-MF000003524";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_APTITUD_PSICO = "N009-MF000003525";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_APTITUD_PSICO_DESC = "N009-MF000003526";

        public const string INFORME_PSICOLOGICO_GOLDFIELDS_RECOMEN_INTERVENCION_TERAPEUTICA = "N009-MF000003527";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_RECOMEN_CONSEJERIA_REFORZAMIENTO = "N009-MF000003528";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_RECOMEN_DESC = "N009-MF000003529";

        //VALIDAR INFO A IMPRIMIR
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_SEC_INCOMP = "N009-MF000003530";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_SEC_COMP = "N009-MF000003531";
        public const string INFORME_PSICOLOGICO_GOLDFIELDS_GERENTE = "N009-MF000003532";

        #endregion
        #region COSAPI

        public const string INFORME_MEDICO_OCUPACIONAL_COSAPI = "IMO-COSAPI";
        public const string CERTIFICADO_APTITUD_MEDICO = "CAM-COSAPI";

              
        #region FICHA DETECCIÓN S.A.S.
        public const string FICHA_SAS_ID = "N009-ME000000435";

        public const string FICHA_SAS_TIPO_LICENCIA = "N009-MF000003295";
        public const string FICHA_SAS_N_LICENCIA = "N009-MF000003296";
        public const string FICHA_SAS_TRABAJA_NOCHE = "N009-MF000003297";
        public const string FICHA_SAS_N_DIAS_TRABAJO_DESCANSO = "N009-MF000003298";

        public const string FICHA_SAS_APNEA_SUEÑO_DIAGNOSTICADA = "N009-MF000003299";
        public const string FICHA_SAS_ULTIMO_CONTROL = "N009-MF000003300";
        public const string FICHA_SAS_HTA = "N009-MF000003301";
        public const string FICHA_SAS_OBSERVACION_HTA = "N009-MF000003337"; //
        public const string FICHA_SAS_RONCA_DORMIR = "N009-MF000003302";
        public const string FICHA_SAS_OBSERVACION_RONQUIDO = "N009-MF000003338"; //
        public const string FICHA_SAS_ANTECEDENTE_CHOQUE = "N009-MF000003303";
        public const string FICHA_SAS_CHOQUE_SOMNOLENCIA = "N009-MF000003304";
        public const string FICHA_SAS_PAUSAS_RESPIRACION_SUEÑO = "N009-MF000003305";
        public const string FICHA_SAS_OBSERVACION_RESPIRACION = "N009-MF000003339"; //
        public const string FICHA_SAS_FATIGA_DIA = "N009-MF000003306";
        public const string FICHA_SAS_OBSERVACION_FATIGA = "N009-MF000003340"; //

        public const string FICHA_SAS_MAYOR_10= "N009-MF000003307";
        public const string FICHA_SAS_MENOR_10 = "N009-MF000003308";
        public const string FICHA_SAS_PUNTUACION = "N009-MF000003309";

        public const string FICHA_SAS_CIRCUNFERENCIA_CUELLO= "N009-MF000003310";
        public const string FICHA_SAS_NORMAL = "N009-MF000003311";

        public const string FICHA_SAS_I = "N009-MF000003314";
        public const string FICHA_SAS_II = "N009-MF000003315";
        public const string FICHA_SAS_III = "N009-MF000003316";
        public const string FICHA_SAS_IV = "N009-MF000003317";

        public const string FICHA_SAS_RIESGO_ALTO = "N009-MF000003318";

        public const string FICHA_SAS_PUNTAJE_EPWORTH_MAY_10 = "N009-MF000003319";
        public const string FICHA_SAS_ANTECEDENTES_ACCIDENTE_VEHICULAR = "N009-MF000003320";
        public const string FICHA_SAS_MALLAMPATI_CLSE_III = "N009-MF000003321";
        public const string FICHA_SAS_ANTECEDENTES_SAS = "N009-MF000003322";

        public const string FICHA_SAS_RIESGO_MEDIO = "N009-MF000003323";

        public const string FICHA_SAS_HISTORIA_HIGIENE_SUEÑO = "N009-MF000003324";
        public const string FICHA_SAS_OBESIDAD_GRADO_II = "N009-MF000003325";
        public const string FICHA_SAS_CIRCUNFERENCIA_CUELLO_ANORMAL= "N009-MF000003326";
        public const string FICHA_SAS_HTA_DIAGNOSTICO_NUEVO = "N009-MF000003327";

        public const string FICHA_SAS_RIESGO_BAJO = "N009-MF000003328";

        public const string FICHA_SAS_APTO = "N009-MF000003329";
        public const string FICHA_SAS_OBSERVADO = "N009-MF000003331";
        public const string FICHA_SAS_NO_APTO = "N009-MF000003333";
        public const string FICHA_SAS_VIGENCIA_DESDE = "N009-MF000003335";
        public const string FICHA_SAS_VIGENCIA_HASTA = "N009-MF000003336";
        #endregion

        #region SUFICIENCIA MEDICA - TRABAJOS EN ESPACIOS CONFINADOS
        public const string FICHA_SUFICIENCIA_MEDICA_ID = "N009-ME000000436";

        public const string FICHA_SUFICIENCIA_MEDICA_DESCRIPCION = "N009-MF000003341";

        public const string FICHA_SUFICIENCIA_MEDICA_P_T_INSPIRACION = "N009-MF000003342";
        public const string FICHA_SUFICIENCIA_MEDICA_P_T_ESPIRACION = "N009-MF000003343";

        public const string FICHA_SUFICIENCIA_MEDICA_EVALUACION_CLINICA_EC = "N009-MF000003345";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA = "N009-MF000003346";
        public const string FICHA_SUFICIENCIA_MEDICA_EKG_EC = "N009-MF000003347";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA_EKG = "N009-MF000003348";

        public const string FICHA_SUFICIENCIA_MEDICA_EVALUACION_CLINICA_EP = "N009-MF000003349";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA_EC = "N009-MF000003350";
        public const string FICHA_SUFICIENCIA_MEDICA_ESPIROMETRIA_EP = "N009-MF000003351";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA_E = "N009-MF000003352";
        public const string FICHA_SUFICIENCIA_MEDICA_RADIOGRAFIA_TORAX_EP = "N009-MF000003353";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA_RT = "N009-MF000003354";

        public const string FICHA_SUFICIENCIA_MEDICA_EVALUACION_CLINICA_EN = "N009-MF000003355";
        public const string FICHA_SUFICIENCIA_MEDICA_PRECISAR_ANOMALIA_EP = "N009-MF000003356";

        public const string FICHA_SUFICIENCIA_MEDICA_RESULTADO_EVALUACION = "N009-MF000003357";

        public const string FICHA_SUFICIENCIA_MEDICA_DESCRIPCION_C = "N009-MF000003358";

        public const string FICHA_SUFICIENCIA_MEDICA_APTO = "N009-MF000003359";
        public const string FICHA_SUFICIENCIA_MEDICA_NO_APTO = "N009-MF000003360";
        public const string FICHA_SUFICIENCIA_MEDICA_DESDE = "N009-MF000003361";
        public const string FICHA_SUFICIENCIA_MEDICA_HASTA = "N009-MF000003362";
        #endregion

        #endregion

        #region HUDBAY
        public const string CONSENTIMIENTO_INFORMADO_HUDBAY = "CONSINF-HUDBAY";
        public const string INFORME_MEDICO_APTITUD_OCUPACIONAL_EMPRESA_HUDBAY = "INFMEDAPTOC-HUDBAY";

        #endregion
        #region EXONERACIONES SAN LORENZO
        public const string EXONERACION_EXAMEN_LABORATORIO = "EXO-LAB-SL";
        public const string EXONERACION_PLACA_TORAXICA = "EXO-RX-SL";
        public const string DECLARACION_JURADA_EMBARAZADAS_RX = "DJ-EMB-RX-SL";

        public const string EXCEPCIONES_RX_ID = "N009-ME000000440";
        public const string EXCEPCIONES_RX_EXO_SI = "N009-MF000003429";
        public const string EXCEPCIONES_RX_EXO_NO = "N009-MF000003430";
        public const string EXCEPCIONES_RX_EXO_MOTIVO = "N009-MF000003431";

        public const string EXCEPCIONES_RX_AUTORIZACION_ID = "N009-ME000000442";
        public const string EXCEPCIONES_RX_AUTORIZACION_SI = "N009-MF000003432";
        public const string EXCEPCIONES_RX_AUTORIZACION_NO = "N009-MF000003433";
        public const string EXCEPCIONES_RX_FECHA_ULTIMA_REGLA = "N009-MF000003434";

        public const string EXCEPCIONES_LABORATORIO_ID = "N009-ME000000441";
        public const string EXCEPCIONES_LABORATORIO_EXO_SI = "N009-MF000003435";
        public const string EXCEPCIONES_LABORATORIO_EXO_NO = "N009-MF000003436";

        public const string EXCEPCIONES_ESPIROMETRIA_ID = "N009-ME000000513";
        public const string EXCEPCIONES_ESPIROMETRIA_SI = "N009-MF000004351";
        public const string EXCEPCIONES_ESPIROMETRIA_NO = "N009-MF000004352";
        public const string EXCEPCIONES_ESPIROMETRIA_MOTIVO = "N009-MF000004353";
        #endregion
        #region EXAMEN_FISICO


        public const string EXAMEN_FISICO_ID = "N002-ME000000022";
        public const string EXAMEN_FISICO_HALLAZGOS_ID = "N002-MF000000138";
        public const string EXAMEN_FISICO_OIDOS_ID = "N002-MF000000121";
        public const string EXAMEN_FISICO_OJOSANEXOS_ID = "N002-MF000000122";
        public const string EXAMEN_FISICO_APARATORESPIRATORIO_ID = "N002-MF000000123";
        public const string EXAMEN_FISICO_GENITOURINARIO_ID = "N002-MF000000124";
        public const string EXAMEN_FISICO_MARCHA_ID = "N002-MF000000125";
        public const string EXAMEN_FISICO_FARINGE_ID = "N002-MF000000126";
        public const string EXAMEN_FISICO_CARDIO_VASCULAR_ID = "N002-MF000000127";
        public const string EXAMEN_FISICO_COLMNA_ID = "N002-MF000000128";
        public const string EXAMEN_FISICO_NARIZ_ID = "N002-MF000000129";
        public const string EXAMEN_FISICO_EXTREMIDADE_SUPERIORES_ID = "N002-MF000000130";
        public const string EXAMEN_FISICO_PIEL_ID = "N002-MF000000131";
        public const string EXAMEN_FISICO_CABELLO_ID = "N002-MF000000132";
        public const string EXAMEN_FISICO_APARATO_DIGESTIVO_ID = "N002-MF000000133";
        public const string EXAMEN_FISICO_EXTREMIDADES_INFERIORES_ID = "N002-MF000000134";
        public const string EXAMEN_FISICO_CUELLO_ID = "N002-MF000000135";
        public const string EXAMEN_FISICO_BOCA_ID = "N002-MF000000136";
        public const string EXAMEN_FISICO_APARATO_LOCOMOTOR_ID = "N002-MF000000137";
        public const string EXAMEN_FISICO_LINFATICOS_ID = "N002-MF000000176";
        public const string EXAMEN_FISICO_SISTEMA_NERVIOSO_ID = "N002-MF000000177";
        public const string EXAMEN_FISICO_ECTOSCOPIA_ID = "N009-MF000000003";
        // Descripcion
        public const string EXAMEN_FISICO_PIEL_DESCRIPCION_ID = "N009-MF000000601";
        public const string EXAMEN_FISICO_CABELLO_DESCRIPCION_ID = "N009-MF000000602";
        public const string EXAMEN_FISICO_OIDOS_DESCRIPCION_ID = "N009-MF000000603";
        public const string EXAMEN_FISICO_OJOSANEXOS_DESCRIPCION_ID = "N009-MF000000604";
        public const string EXAMEN_FISICO_NARIZ_DESCRIPCION_ID = "N009-MF000000605";
        public const string EXAMEN_FISICO_BOCA_DESCRIPCION_ID = "N009-MF000000606";
        public const string EXAMEN_FISICO_FARINGE_DESCRIPCION_ID = "N009-MF000000607";
        public const string EXAMEN_FISICO_CUELLO_DESCRIPCION_ID = "N009-MF000000608";
        public const string EXAMEN_FISICO_APARATO_RESPIRATORIO_DESCRIPCION_ID = "N009-MF000000609";
        public const string EXAMEN_FISICO_CARDIO_VASCULAR_DESCRIPCION_ID = "N009-MF000000610";
        public const string EXAMEN_FISICO_APARATO_DIGESTIVO_DESCRIPCION_ID = "N009-MF000000611";
        public const string EXAMEN_FISICO_APARATO_GENITOURINARIO_DESCRIPCION_ID = "N009-MF000000612";
        public const string EXAMEN_FISICO_APARATO_LOCOMOTOR_DESCRIPCION_ID = "N009-MF000000613";
        public const string EXAMEN_FISICO_MARCHA_DESCRIPCION_ID = "N009-MF000000614";
        public const string EXAMEN_FISICO_COLUMNA_DESCRIPCION_ID = "N009-MF000000615";
        public const string EXAMEN_FISICO_EXTREMIDADES_SUPERIORES_DESCRIPCION_ID = "N009-MF000000616";
        public const string EXAMEN_FISICO_EXTREMIDADES_INFERIORES_DESCRIPCION_ID = "N009-MF000000617";
        public const string EXAMEN_FISICO_LINFATICOS_DESCRIPCION_ID = "N009-MF000000618";
        public const string EXAMEN_FISICO_SISTEMA_NERVIOSO_DESCRIPCION_ID = "N009-MF000000619";
        public const string EXAMEN_FISICO_ECTOSCOPIA_GENERAL_DESCRIPCION_ID = "N009-MF000000620";
        public const string EXAMEN_FISICO_ESTADO_METAL_ID = "N009-MF000000624";
        public const string EXAMEN_FISICO_ESTADO_METAL_DESCRIPCION_ID = "N009-MF000000625";
        public const string EXAMEN_FISICO_DESCRIPCION_ID = "N009-MF000000439";

        public const string EXAMEN_FISICO_MEDICACION = "N009-MF000004355";



        #endregion

        #region RX

        public const string RX_TORAX_ID = "N002-ME000000032";
        public const string RX_HALLAZGOS = "N002-MF000000166";
        public const string RX_CONCLUSIONES_RADIOGRAFICAS_ID = "N009-MF000000224";
        public const string RX_CONCLUSIONES_RADIOGRAFICAS_DESCRIPCION_ID = "N009-MF000000233";
        public const string RX_EXPOSICION_POLVO_ID = "N009-MF000000598";
        public const string RX_EXPOSICION_POLVO_DESCRIPCION_ID = "N009-MF000000599";


        public const string RX_VERTICES_COMBO_ID = "N002-MF000000212";
        public const string RX_VERTICES_ID = "N009-MF000000590";

        public const string RX_CAMPOS_PULMONARES_COMBO_ID = "N002-MF000000214";
        public const string RX_CAMPOS_PULMONARES_ID = "N009-MF000000591";

        public const string RX_HILOS_COMBO_ID = "N002-MF000000215";
        public const string RX_HILOS_ID = "N009-MF000000592";

        public const string RX_COSTO_ODIAFRAGMATICO_COMBO_ID = "N002-MF000000218";
        public const string RX_COSTO_ODIAFRAGMATICO_ID = "N009-MF000000593";


        public const string RX_SENOS_CARDIOFRENICOS_COMBO_ID = "N002-MF000000219";
        public const string RX_SENOS_CARDIOFRENICOS_DESCRIPCION_ID = "N009-MF000000883";

        public const string RX_CODIGO_PLACA_ID = "N009-MF000001788";

        public const string RX_MEDIASTINOS_COMBO_ID = "N002-MF000000213";
        public const string RX_MEDIASTINOS_DESCRIPCION_ID = "N009-MF000000594";


        public const string RX_SILUETA_CARDIACA_COMBO_ID = "N002-MF000000216";
        public const string RX_SILUETA_CARDIACA_DESCRIPCION_ID = "N009-MF000000595";


        public const string RX_INDICE_CARDIACO_ID = "N002-MF000000217";
        public const string RX_INDICE_CARDIACO_DESCRIPCION_ID = "N009-MF000000884";

        public const string RX_PARTES_BLANDAS_OSEAS_COMBO_ID = "N009-MF000000885";
        public const string RX_PARTES_BLANDAS_OSEAS_ID = "N009-MF000000886";

        public const string RX_SENOS_CARDIOFRENICOS_ID = "N009-MF000000219";




        //MARQUE LA RESPUESTA ADECUADA
        public const string RX_AA_ID = "N009-MF000000762";
        public const string RX_AT_ID = "N009-MF000000763";
        public const string RX_AX_ID = "N009-MF000000764";
        public const string RX_BU_ID = "N009-MF000000765";
        public const string RX_CA_ID = "N009-MF000000766";
        public const string RX_CG_ID = "N009-MF000000767";
        public const string RX_CN_ID = "N009-MF000000768";
        public const string RX_CO_ID = "N009-MF000000770";
        public const string RX_CP_ID = "N009-MF000000771";
        public const string RX_CV_ID = "N009-MF000000772";

        public const string RX_DI_ID = "N009-MF000001017";
        public const string RX_EF_ID = "N009-MF000001018";

        public const string RX_EM_ID = "N009-MF000001019";
        public const string RX_ES_ID = "N009-MF000001020";
        public const string RX_FR_ID = "N009-MF000001022";
        public const string RX_HI_ID = "N009-MF000001023";
        public const string RX_HO_ID = "N009-MF000001024";
        public const string RX_ID_ID = "N009-MF000001025";
        public const string RX_IH_ID = "N009-MF000001026";
        public const string RX_KL_ID = "N009-MF000001027";
        public const string RX_ME_ID = "N009-MF000001028";
        public const string RX_OD_ID = "N009-MF000001037";
        public const string RX_PA_ID = "N009-MF000001030";
        public const string RX_PB_ID = "N009-MF000001031";
        public const string RX_PI_ID = "N009-MF000001032";
        public const string RX_PX_ID = "N009-MF000001033";
        public const string RX_RA_ID = "N009-MF000001034";
        public const string RX_RP_ID = "N009-MF000001035";
        public const string RX_TB_ID = "N009-MF000001036";
        public const string RX_COMENTARIO_OD_ID = "N009-MF000001039";


        //SIMBOLO
        public const string RX_SIMBOLO_SI_ID = "N009-MF000000761";
        public const string RX_SIMBOLO_NO_ID = "N009-MF000000760";
        //OPACIDADES GRANDES
        public const string RX_A_ID = "N009-MF000000757";
        public const string RX_B_ID = "N009-MF000000758";
        public const string RX_C_ID = "N009-MF000000759";
        public const string RX_D_ID = "N009-MF000000756";
        //ZONAS AFECTADAS
        public const string RX_INFERIOR_DERECHO_ID = "N009-MF000000222";
        public const string RX_INFERIOR_IZQUIERDO_ID = "N009-MF000000223";
        public const string RX_MEDIO_DERECHO_ID = "N009-MF000000220";
        public const string RX_MEDIO_IZQUIERDO_ID = "N009-MF000000221";
        public const string RX_SUPERIOR_DERECHO_ID = "N009-MF000000218";
        public const string RX_SUPERIOR_IZQUIERDO_ID = "N009-MF000000219";
        //PROFUSION
        public const string RX_0_NADA_ID = "N002-MF000000221";
        public const string RX_0_0_ID = "N002-MF000000222";
        public const string RX_0_1_ID = "N002-MF000000223";

        public const string RX_1_0_ID = "N002-MF000000220";
        public const string RX_1_1_ID = "N009-MF000000720";
        public const string RX_1_2_ID = "N009-MF000000721";

        public const string RX_2_1_ID = "N009-MF000000722";
        public const string RX_2_2_ID = "N009-MF000000723";
        public const string RX_2_3_ID = "N009-MF000000724";

        public const string RX_3_2_ID = "N009-MF000000725";
        public const string RX_3_3_ID = "N009-MF000000726";
        public const string RX_3_MAS_ID = "N009-MF000000727";

        //Placa Radiografica
        public const string RX_CALIDAD_ID = "N002-MF000000184";
        public const string RX_CAUSAS_ID = "N002-MF000000210";
        public const string RX_FECHA_LECTURA_ID = "N009-MF000000587";
        public const string RX_FECHA_TOMA_ID = "N009-MF000000588";
        public const string RX_COMENTARIOS_ID = "N009-MF000000589";
        public const string RX_NRO_PLACA_ID = "N002-MF000000211";
        //ddd
        public const string RX_P_ID = "N009-MF000000733";
        public const string RX_P1_ID = "N009-MF000000736";

        public const string RX_Q_ID = "N009-MF000000742";
        public const string RX_Q1_ID = "N009-MF000000746";

        public const string RX_R_ID = "N009-MF000000749";
        public const string RX_R1_ID = "N009-MF000000753";

        public const string RX_S_ID = "N009-MF000000734";
        public const string RX_S1_ID = "N009-MF000000737";

        public const string RX_T_ID = "N009-MF000000744";
        public const string RX_T1_ID = "N009-MF000000748";

        public const string RX_U_ID = "N009-MF000000751";
        public const string RX_U1_ID = "N009-MF000000755";
        #endregion

        public const string INFORME_LABORATORIO_ID = "N001-ME000000000";

        public const string INFORME_LABORATORIO_OBSERVACIONES = "N009-MF000000272";
        public const string INFORME_LABORATORIO_NORMAL = "N009-MF000002132";
        #region OFTALMOLOGIA

        public const string OFTALMOLOGIA_CORRECTORES_OCULARES_SI_ID = "N002-MF000000224";
        public const string OFTALMOLOGIA_CORRECTORES_OCULARES_NO_ID = "N009-MF000000719";
        public const string OFTALMOLOGIA_CORRECTORES_OCULARES_ULTIMA_REFRACCION_ID = "N002-MF000000225";
        public const string OFTALMOLOGIA_HIPERTENSION_ID = "N009-MF000000175";
        public const string OFTALMOLOGIA_DIABETES_ID = "N009-MF000000176";
        public const string OFTALMOLOGIA_GLAUCOMA_ID = "N009-MF000000177";
        public const string OFTALMOLOGIA_TRAUMATISMO_ID = "N009-MF000000178";
        public const string OFTALMOLOGIA_AMBLIOPIA_ID = "N009-MF000000179";
        public const string OFTALMOLOGIA_SUST_QUIMICAS_ID = "N009-MF000000180";
        public const string OFTALMOLOGIA_SOLDADURA_ID = "N009-MF000000181";
        public const string OFTALMOLOGIA_CATARATAS_ID = "N009-MF000000182";
        public const string OFTALMOLOGIA_OTROS_ESPECIFICAR_ID = "N009-MF000000710";

        public const string OFTALMOLOGIA_TEST_ESTEREOPSIS_A = "N002-MF000000226";
        public const string OFTALMOLOGIA_SC_CERCA_OJO_IZQUIERDO_ID = "N002-MF000000227";
        public const string OFTALMOLOGIA_AE_LEJOS_OJO_IZQUIERDO_ID = "N002-MF000000228";
        public const string OFTALMOLOGIA_SC_LEJOS_OJO_IZQUIERDO_ID = "N002-MF000000230";
        public const string OFTALMOLOGIA_CC_LEJOS_OJO_DERECHO_ID = "N002-MF000000231";
        public const string OFTALMOLOGIA_SC_CERCA_OJO_DERECHO_ID = "N002-MF000000233";
        public const string OFTALMOLOGIA_SC_LEJOS_OJO_DERECHO_ID = "N002-MF000000234";
        public const string OFTALMOLOGIA_CC_CERCA_OJO_DERECHO_ID = "N002-MF000000235";
        public const string OFTALMOLOGIA_CC_LEJOS_OJO_IZQUIERDO_ID = "N002-MF000000236";
        public const string OFTALMOLOGIA_AE_CERCA_OJO_IZQUIERDO_ID = "N002-MF000000237";
        public const string OFTALMOLOGIA_AE_CERCA_OJO_DERECHO_ID = "N009-MF000000641";
        public const string OFTALMOLOGIA_CC_CERCA_OJO_IZQUIERDO_ID = "N009-MF000000646";

        public const string OFTALMOLOGIA_MACULA_OJO_DERECHO_ID = "N002-MF000000238";
        public const string OFTALMOLOGIA_MACULA_OJO_IZQUIERDO_ID = "N002-MF000000239";
        public const string OFTALMOLOGIA_RETINA_OJO_DERECHO_ID = "N002-MF000000240";
        public const string OFTALMOLOGIA_RETINA_OJO_IZQUIERDO_ID = "N002-MF000000241";
        public const string OFTALMOLOGIA_NERVIO_OPTICO_DERECHO_ID = "N002-MF000000246";
        public const string OFTALMOLOGIA_NERVIO_OPTICO_IZQUIERDO_ID = "N002-MF000000247";
        public const string OFTALMOLOGIA_PARPADO_OJO_DERECHO_ID = "N002-MF000000251";
        public const string OFTALMOLOGIA_PARPADO_OJO_IZQUIERDO_ID = "N002-MF000000252";
        public const string OFTALMOLOGIA_CONJUNTIVA_OJO_DERECHO_ID = "N002-MF000000254";
        public const string OFTALMOLOGIA_CONJUNTIVA_OJO_IZQUIERDO_ID = "N002-MF000000255";
        public const string OFTALMOLOGIA_CORNEA_OJO_DERECHO_ID = "N009-MF000000524";
        public const string OFTALMOLOGIA_CORNEA_OJO_IZQUIERDO_ID = "N009-MF000000525";
        public const string OFTALMOLOGIA_CRISTALINO_OJO_DERECHO_ID = "N009-MF000000527";
        public const string OFTALMOLOGIA_CRISTALINO_OJO_IZQUIERDO_ID = "N009-MF000000528";
        public const string OFTALMOLOGIA_IRIS_OJO_DERECHO_ID = "N009-MF000000530";
        public const string OFTALMOLOGIA_IRIS_OJO_IZQUIERDO_ID = "N009-MF000000531";
        public const string OFTALMOLOGIA_MOV_OCULARES_OJO_DERECHO_ID = "N009-MF000000533";
        public const string OFTALMOLOGIA_MOV_OCULARES_OJO_IZQUIERDO_ID = "N009-MF000000534";


        public const string OFTALMOLOGIA_CONFRONTACION_CAMPO_COMPLETO_OJO_IZQUIERDO_ID = "N009-MF000000713";
        public const string OFTALMOLOGIA_CONFRONTACION_CAMPO_RESTRINGIDO_OJO_IZQUIERDO_ID = "N009-MF000000714";

        public const string OFTALMOLOGIA_DICROMATOPSIA_ID = "N009-MF000000522";
        public const string OFTALMOLOGIA_TEST_ESTEREOPSIS_TIEMPO_ID = "N002-MF000000258";
        public const string OFTALMOLOGIA_TEST_ESTEREOPSIS_NORMAL_ID = "N002-MF000000343";
        public const string OFTALMOLOGIA_TEST_ESTEREOPSIS_ANORMAL_ID = "N002-MF000000342";
        public const string OFTALMOLOGIA_PRESION_INTRAOCULAR_OJO_DERECHO_ID = "N002-MF000000261";
        public const string OFTALMOLOGIA_PRESION_INTRAOCULAR_OJO_IZQUIERDO_ID = "N002-MF000000262";
        public const string OFTALMOLOGIA_HALLAZGOS_ID = "N009-MF000000356";
        public const string OFTALMOLOGIA_CONCLUSIONES = "N009-MF000000231";
        public const string OFTALMOLOGIA_AGUDEZA_VISUAL_CERCA_SC_OJO_DERECHO = "N002-MF000000233";
        public const string OFTALMOLOGIA_AGUDEZA_VISUAL_CERCA_SC_OJO_IZQUIERDO = "N002-MF000000227";  // 234
        public const string OFTALMOLOGIA_AGUDEZA_VISUAL_CERCA_CC_OJO_DERECHO = "N002-MF000000235";  //231 antes
        public const string OFTALMOLOGIA_AGUDEZA_VISUAL_CERCA_CC_OJO_IZQUIERDO = "N009-MF000000646";
        public const string OFTALMOLOGIA_TEST_ESTEREOPSIS = "N002-MF000000257";
        public const string OFTALMOLOGIA_TEST_ISHIHARA = "N002-MF000000256";

        public const string AE_CERCA_OJO_IZQUIERDO = "N009-MF000002083";
        public const string AE_CERCA_OJO_DERECHO = "N009-MF000002082";
        public const string AE_LEJOS_OJO_IZQUIERDO = "N009-MF000002081";
        public const string AE_LEJOS_OJO_DERECHO = "N009-MF000002080";
        public const string MIOPIA = "N009-MF000000709";
        public const string TONOMETRIA_O_I = "N009-MF000002097";
        public const string TONOMETRIA_O_D = "N009-MF000002096";
        public const string CAMPIMETRIA_O_I = "N009-MF000002095";
        public const string CAMPIMETRIA_O_D = "N009-MF000002094";
        public const string RECUPERACION = "N009-MF000002093";
        public const string SIN_PATOLOGIAS = "N009-MF000002092";
        public const string OTRAS_PATOLOGIA = "N009-MF000002091";
        public const string CHALAZION = "N009-MF000002090";
        public const string CATARATAS = "N009-MF000002089";
        public const string TRANS_DE_CORNEA = "N009-MF000002088";
        public const string ESTRABISMO = "N009-MF000002087";
        public const string PTERIGIUM = "N009-MF000002086";
        public const string CONJUNTIVITIS = "N009-MF000002085";
        public const string PTOSIS_PALPEBRAL = "N009-MF000002084";


        #endregion

        public const string OFTALMOLOGIA_ID = "N002-ME000000028";
        public const string OFTALMOLOGIA_NORMAL = "N009-MF000000717";
        public const string OFTALMOLOGIA_ANORMAL = "N009-MF000000718";
        public const string OFTALMOLOGIA_DESCRIPCION = "N009-MF000000261";
        public const string OFTALMOLOGIA_EMETROPE = "N009-MF000002071";
        public const string OFTALMOLOGIA_PRESBICIA_CORREGIDA = "N009-MF000002073";
        public const string OFTALMOLOGIA_AMETROPIA_CORREGIDA = "N009-MF000002072";
        public const string OFTALMOLOGIA_PRESBICIA_NO_CORREGIDA = "N009-MF000002074";
        public const string OFTALMOLOGIA_AMETROPIA_NO_CORREGIDA = "N009-MF000002075";
        public const string OFTALMOLOGIA_AMBLIOPIA = "N009-MF000002076";
        public const string OFTALMOLOGIA_AMETROPIA_CORREGIDA_PARCIAL = "N009-MF000002077";
        public const string OFTALMOLOGIA_DISMINUCION_VISION_UN_OJO = "N009-MF000002152";
        public const string OFTALMOLOGIA_DISMINUCION_VISION_BILATERAL = "N009-MF000002153";

        public const string OFTALMOLOGIA_CORRECTORES = "N009-MF000004356";
        #region Fondo de Ojo
        public const string FONDO_OJO_ID = "N009-ME000000132";

        public const string FONDO_OJO_OD = "N002-MF000000243";
        public const string FONDO_OJO_OI = "N002-MF000000244";
        public const string FONDO_OJO_ANORMAL_1 = "N002-MF000000248";
        public const string FONDO_OJO_ANORMAL_2 = "N002-MF000000249";
        public const string FONDO_OJO_MACULOPATIA = "N002-MF000000250";
        public const string FONDO_OJO_PARPADO_OD = "N002-MF000000251";
        public const string FONDO_OJO_PARPADO_OI = "N002-MF000000252";
        public const string FONDO_OJO_NEURITIS = "N002-MF000000253";
        public const string FONDO_OJO_CONJ_OD = "N002-MF000000254";
        public const string FONDO_OJO_CONJ_OI = "N002-MF000000255";

        public const string FONDO_OJO_RETINOPATIA = "N009-MF000000523";
        public const string FONDO_OJO_CORNEA_OD = "N009-MF000000524";
        public const string FONDO_OJO_CORNEA_OI = "N009-MF000000525";
        public const string FONDO_OJO_EDEMA_PAPILA = "N009-MF000000526";
        public const string FONDO_OJO_CRISTALINO_OD = "N009-MF000000527";
        public const string FONDO_OJO_CRISTALINO_OI = "N009-MF000000528";
        public const string FONDO_OJO_ANGIOPATIA = "N009-MF000000529";
        public const string FONDO_OJO_IRIS_OD = "N009-MF000000530";
        public const string FONDO_OJO_IRIS_OI = "N009-MF000000531";
        public const string FONDO_OJO_ATROFIA = "N009-MF000000532";
        public const string FONDO_OJO_MOV_OCULAR_OD = "N009-MF000000533";
        public const string FONDO_OJO_MOV_OCULAR_OI = "N009-MF000000534";



        #endregion

        #region Test Ishihara
        public const string TEST_ISHIHARA_ID = "N009-ME000000093";

        public const string TEST_ISHIHARA_TEST = "N002-MF000000256";
        public const string TEST_ISHIHARA_DESC = "N009-MF000000522";

        public const string TEST_ISHIHARA_NORMAL = "N009-MF000000711";
        public const string TEST_ISHIHARA_ANORMAL = "N009-MF000000712";
        #endregion

        #region Test Estereopsis
        public const string TEST_ESTEREOPSIS_ID = "N009-ME000000011";

        public const string TEST_ESTEREOPSIS_ENCANDILAMIENTO = "N002-MF000000256";
        public const string TEST_ESTEREOPSIS_TEST = "N002-MF000000257";
        public const string TEST_ESTEREOPSIS_TIEMPO = "N002-MF000000258";
        public const string TEST_ESTEREOPSIS_ANORMAL = "N002-MF000000342";
        public const string TEST_ESTEREOPSIS_NORMAL = "N002-MF000000343";
        public const string TEST_ESTEREOPSIS_RECUPERACION = "N009-MF000002093";

        #endregion

        #region Campimetria
        public const string CAMPIMETRIA_ID = "N009-ME000000133";

        public const string CAMPIMETRIA_OD = "N009-MF000002094";
        public const string CAMPIMETRIA_OI = "N009-MF000002095";
        #endregion

        #region Tonometria
        public const string TONOMETRIA_ID = "N009-ME000000134";

        public const string TONOMETRIA_OD = "N009-MF000002096";
        public const string TONOMETRIA_OI = "N009-MF000002097";
        #endregion

        #region ALTURA_ESTRUCTURAL

        public const string ALTURA_ESTRUCTURAL_ID = "N009-ME000000015";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_SI_ID = "N009-MF000000781";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_NO_ID = "N009-MF000000782";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_OBS_ID = "N009-MF000000783";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_SI_ID = "N009-MF000000785";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_NO_ID = "N009-MF000000786";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_OBS_ID = "N009-MF000000787";
        public const string ALTURA_ESTRUCTURAL_MAREOS_SI_ID = "N009-MF000000789";
        public const string ALTURA_ESTRUCTURAL_MAREOS_NO_ID = "N009-MF000000790";
        public const string ALTURA_ESTRUCTURAL_MAREOS_OBS_ID = "N009-MF000000791";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_SI_ID = "N009-MF000000793";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_NO_ID = "N009-MF000000794";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_OBS_ID = "N009-MF000000795";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_SI_ID = "N009-MF000000797";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_NO_ID = "N009-MF000000798";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_OBS_ID = "N009-MF000000799";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_SI_ID = "N009-MF000000801";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_NO_ID = "N009-MF000000802";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_OBS_ID = "N009-MF000000803";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_SI_ID = "N009-MF000000805";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_NO_ID = "N009-MF000000806";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_OBS_ID = "N009-MF000000807";
        public const string ALTURA_ESTRUCTURAL_NISTAGMUS_ESPONTANEO_ID = "N009-MF000000026";
        public const string ALTURA_ESTRUCTURAL_NISTAGMUS_PROVOCADO_ID = "N009-MF000000027";
        public const string ALTURA_ESTRUCTURAL_PRIMEROS_AUXILIOS_ID = "N009-MF000000028";
        public const string ALTURA_ESTRUCTURAL_TRABAJO_SOBRE_NIVEL_ID = "N009-MF000000029";
        public const string ALTURA_ESTRUCTURAL_TIMPANOS_ID = "N009-MF000000030";
        public const string ALTURA_ESTRUCTURAL_EQUILIBRIO_ID = "N009-MF000000031";
        public const string ALTURA_ESTRUCTURAL_SUST_PIE_20_ID = "N009-MF000000036";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_RECTA_3_ID = "N009-MF000000035";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_OJOS_VENDADOS_3_ID = "N009-MF000000034";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_OJOS_VENDADOS_PUNTA_TALON_3_ID = "N009-MF000000032";
        public const string ALTURA_ESTRUCTURAL_ROTAR_SILLA_GIRATORIA_ID = "N009-MF000000033";
        public const string ALTURA_ESTRUCTURAL_ADIADOCOQUINESIA_DIRECTA_ID = "N009-MF000000037";
        public const string ALTURA_ESTRUCTURAL_ADIADOCOQUINESIA_CRUZADA_ID = "N009-MF000000038";
        public const string ALTURA_ESTRUCTURAL_APTO_ID = "N009-MF000000039";
        public const string ALTURA_ESTRUCTURAL_DESCRIPCION_ID = "N009-MF000000357";

        #endregion

        public const string TACTO_RECTAL_ID = "N009-ME000000031";
        public const string TACTO_RECTAL_HALLAZGOS = "N009-MF000000358";

        public const string EVAL_NEUROLOGICA_ID = "N009-ME000000037";
        public const string EVAL_NEUROLOGICA_HALLAZGOS = "N009-MF000000359";
        public const string EVAL_NEUROLOGICA_DESCRIPCION_ID = "N009-MF000000354";

        public const string OWNER_ORGNIZATION_ID = "N009-OO000000052";

        public const string GenericErrorMessage = "Se generó un error al procesar los datos. Por favor verificar el LOG y comunicarse con el administrador del sistema.";
        public const string GOOGLE_IP_ADDRESS = "74.125.229.247";
        public const string IMAGE_PREVIEW_DIRECTORY = @"Images\Preview\";

        #region ANTROPOMETRIA

        public const string ANTROPOMETRIA_ID = "N002-ME000000002";
        public const string ANTROPOMETRIA_TALLA_ID = "N002-MF000000007";
        public const string ANTROPOMETRIA_PESO_ID = "N002-MF000000008";
        public const string ANTROPOMETRIA_IMC_ID = "N002-MF000000009";
        public const string ANTROPOMETRIA_PERIMETRO_ABDOMINAL_ID = "N002-MF000000010";
        public const string ANTROPOMETRIA_PERIMETRO_CADERA_ID = "N002-MF000000011";
        public const string ANTROPOMETRIA_INDICE_CINTURA_ID = "N002-MF000000012";
        public const string ANTROPOMETRIA_PORCENTAJE_GRASA_CORPORAL_ID = "N002-MF000000013";

        #endregion


        #region FUNCIONES_VITALES

        public const string FUNCIONES_VITALES_ID = "N002-ME000000001";
        public const string FUNCIONES_VITALES_PAS_ID = "N002-MF000000001";
        public const string FUNCIONES_VITALES_PAD_ID = "N002-MF000000002";
        public const string FUNCIONES_VITALES_FREC_CARDIACA_ID = "N002-MF000000003";
        public const string FUNCIONES_VITALES_TEMPERATURA_ID = "N002-MF000000004";
        public const string FUNCIONES_VITALES_FREC_RESPIRATORIA_ID = "N002-MF000000005";
        public const string FUNCIONES_VITALES_SAT_O2_ID = "N002-MF000000006";

        #endregion

        #region ATENCIÓN  INTEGRAL
        public const string ATENCION_INTEGRAL_ID = "N009-ME000000405";

        public const string ATENCION_INTEGRAL_SIGNOS_SINTOMAS = "N009-MF000002938";
        public const string ATENCION_INTEGRAL_ENFERMEDAD_ACTUAL = "N009-MF000003421";
        public const string ATENCION_INTEGRAL_TIEMPO_EMF = "N009-MF000002939";

        public const string ATENCION_INTEGRAL_RELATO_PATOLOGICO_DESC = "N009-MF000003422";

        public const string ATENCION_INTEGRAL_APETITO = "N009-MF000002940";
        public const string ATENCION_INTEGRAL_SED = "N009-MF000002941";
        public const string ATENCION_INTEGRAL_SUEÑO = "N009-MF000002942";
        public const string ATENCION_INTEGRAL_EST_ANIMO = "N009-MF000002943";
        public const string ATENCION_INTEGRAL_ORINA = "N009-MF000002944";
        public const string ATENCION_INTEGRAL_DEPOSICIONES = "N009-MF000002945";

        public const string ATENCION_INTEGRAL_ANTECEDENTES = "N009-MF000004935";

        public const string ATENCION_INTEGRAL_PIEL_FANERAS_TEJIDO_SUBCUTANEO = "N009-MF000002946";
        public const string ATENCION_INTEGRAL_APARATO_RESPIRATORIO = "N009-MF000003423";
        public const string ATENCION_INTEGRAL_APARATO_CARDIOVASCULAR = "N009-MF000003424";
        public const string ATENCION_INTEGRAL_ABDOMEN = "N009-MF000003425";
        public const string ATENCION_INTEGRAL_APARATO_GENITOURINARIO = "N009-MF000003426";
        public const string ATENCION_INTEGRAL_SISTEMA_NERVIOSO = "N009-MF000003427";
        public const string ATENCION_INTEGRAL_OSTEMUSCULAR = "N009-MF000003428";

        public const string ATENCION_INTEGRAL_PROX_CITA = "N009-MF000003236";
        
        public const string ATENCION_INTEGRAL_OBSERVACIONES = "N009-MF000003237";

        #endregion
        
        #region NIÑO
        public const string ATENCION_INTEGRAL_NIÑO_ID = "N009-ME000000406";
        public const string ATENCION_INTEGRAL_NIÑO_NO_MAMAR_2M = "N009-MF000003060";
        public const string ATENCION_INTEGRAL_NIÑO_CONVULSIONES_2M = "N009-MF000003061";
        public const string ATENCION_INTEGRAL_NIÑO_FONTANELA_ABOMB_2M = "N009-MF000003062";
        public const string ATENCION_INTEGRAL_NIÑO_ENROJ_OMBLIGO_EXT_PIEL_2M = "N009-MF000003063";
        public const string ATENCION_INTEGRAL_NIÑO_FIEBRE_TEMP_BAJA_2M = "N009-MF000003064";
        public const string ATENCION_INTEGRAL_NIÑO_RIGIDEZ_NUNCA_2M = "N009-MF000003065";
        public const string ATENCION_INTEGRAL_NIÑO_POSTULAS_MUCHAS_EXT_2M = "N009-MF000003066";
        public const string ATENCION_INTEGRAL_NIÑO_LETAR_COMATOSO_2M = "N009-MF000003067";

        public const string ATENCION_INTEGRAL_NIÑO_NO_BEBER_TOMAR_PECHO_2_4M = "N009-MF000003068";
        public const string ATENCION_INTEGRAL_NIÑO_CONVULSIONES_2_4M = "N009-MF000003069";
        public const string ATENCION_INTEGRAL_NIÑO_LETAR_COMAT_2_4M = "N009-MF000003070";
        public const string ATENCION_INTEGRAL_NIÑO_VOMITO_2_4M = "N009-MF000003071";
        public const string ATENCION_INTEGRAL_NIÑO_ESTRIDOR_REPOSO_2_4M = "N009-MF000003072";
        
        public const string ATENCION_INTEGRAL_NIÑO_EMACIACION_VISIBLE_GRAVE_T = "N009-MF000003073";
        public const string ATENCION_INTEGRAL_NIÑO_PIEL_VUELVE_LENTO_T = "N009-MF000003074";
        public const string ATENCION_INTEGRAL_NIÑO_TRAUMATISMO_QUEMADURAS_T = "N009-MF000003075";
        public const string ATENCION_INTEGRAL_NIÑO_ENVENENAMIENTO_T = "N009-MF000003076";
        public const string ATENCION_INTEGRAL_NIÑO_PALIDEZ_PALMAR_T = "N009-MF000003077";

        public const string ATENCION_INTEGRAL_NIÑO_RESPIRACION_RAPIDA_TOS = "N009-MF000003078";
        public const string ATENCION_INTEGRAL_NIÑO_OBSERVAR_TIRAJE_SUBCOSTAL_TOS = "N009-MF000003079";
        public const string ATENCION_INTEGRAL_NIÑO_ESCUCHAR_ESTRIDOR_REPOSO_TOS = "N009-MF000003080";
        public const string ATENCION_INTEGRAL_NIÑO_ESCUCHAR_SIBILANCIAS_TOS = "N009-MF000003081";
        public const string ATENCION_INTEGRAL_NIÑO_OBSERVAR_TRIAJE_SUBCOSTAL_GRAVE_TOS = "N009-MF000003082";
        public const string ATENCION_INTEGRAL_NIÑO_SIBILANCIAS_1RA_VEZ_TOS = "N009-MF000003083";
        public const string ATENCION_INTEGRAL_NIÑO_SIBILANCIAS_RECURRENTE_TOS = "N009-MF000003084";

        public const string ATENCION_INTEGRAL_NIÑO_SANGRE_HECES_DIARREA = "N009-MF000003085";
        public const string ATENCION_INTEGRAL_NIÑO_LETARGICO_COMATOSO_DIARREA = "N009-MF000003086";
        public const string ATENCION_INTEGRAL_NIÑO_INTRANQUILO_IRRITABLE_DIARREA = "N009-MF000003087";
        public const string ATENCION_INTEGRAL_NIÑO_OJOS_HUNDIDOS_DIARREA = "N009-MF000003088";
        public const string ATENCION_INTEGRAL_NIÑO_PUEDE_BEBER_DIARREA = "N009-MF000003089";
        public const string ATENCION_INTEGRAL_NIÑO_BEBE_AVIDAMENTE_SED_DIARREA = "N009-MF000003090";
        public const string ATENCION_INTEGRAL_NIÑO_SIG_PLIEGUE_PIEL_DIARREA = "N009-MF000003091";
        public const string ATENCION_INTEGRAL_NIÑO_SIGNO_PLIEGUE_CUTANEO_DIARREA = "N009-MF000003092";

      
        
        #endregion

        #region ADULTO MAYOR
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_ID = "N009-ME000000404";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_SALUDABLE = "N009-MF000003232";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_FRAGIL = "N009-MF000003233";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_ENFERMO = "N009-MF000003234";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_GERIATRICO_COMPLEJO = "N009-MF000003235";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_DEPENDIENTE = "N009-MF000003268";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_INDEPENDIENTE = "N009-MF000003267";
        // EC = ESTADO COGNITIVO // EA = ESTADO AFECTIVO
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_TOTAL = "N009-MF000003269";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_E_C_NORMAL = "N009-MF000003270";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_E_C_LEVE = "N009-MF000003271";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_E_C_MODERADO = "N009-MF000003272";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_E_A_SIN_MD = "N009-MF000003273";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_E_A_CON_MD = "N009-MF000003274";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_BUENA = "N009-MF000003275";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_RIESGO_SOCIAL = "N009-MF000003276";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_PROBLEMA_SOCIAL = "N009-MF000003277";

        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_SEVERO = "N009-MF000003278";

        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_FECHA_DE_HOY = "N009-MF000003279";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_DIA_DE_SEMANA = "N009-MF000003280";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_LUGAR_ESTAMOS = "N009-MF000003281";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR__NUMERO_TELEFONO_DIRECCION = "N009-MF000003282";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_AÑOS_TIENE = "N009-MF000003283";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_DONDE_NACIO = "N009-MF000003284";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_NOMBRE_PRESIDENTE = "N009-MF000003285";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_NOMBRE_ANTERIOR_PRESIDENTE = "N009-MF000003286";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_PRIMER_APELLIDO_MADRE = "N009-MF000003287";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_RESTAR_3 = "N009-MF000003288";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_SATISFECHO_VIDA = "N009-MF000003289";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_IMPOTENTE_INDEFENSO = "N009-MF000003290";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_PROBLEMAS_MEMORIA = "N009-MF000003291";
        public const string ATENCION_INTEGRAL_ADULTO_MAYOR_DESGANO_IMPOSIBILITADO = "N009-MF000003292";

        
        
        
        

        
        #endregion
        #region Evaluación Neurológica

        public const string EVA_NEUROLOGICA_ID = "N009-ME000000085";

        public const string EVA_NEUROLOGICA_TEST_ROMBERG_ID = "N009-MF000001417";
        public const string EVA_NEUROLOGICA_PRUEBA_MARCHA_ID = "N009-MF000001418";
        public const string EVA_NEUROLOGICA_PRUEBA_INDICE_NARIZ_ID = "N009-MF000001419";
        public const string EVA_NEUROLOGICA_MIEMBRO_SUP_ID = "N009-MF000001420";
        public const string EVA_NEUROLOGICA_MIEMBRO_INF_ID = "N009-MF000001421";
        public const string EVA_NEUROLOGICA_POSITIVO_ID = "N009-MF000001422";
        public const string EVA_NEUROLOGICA_FLEXION_ID = "N009-MF000001423";

        public const string EVA_NEUROLOGICA_CONCLUSION_ID = "N009-MF000001424";
        #endregion



        public const string TEST_ROMBERG_ID = "N009-ME000000038";
        public const string TEST_ROMBERG_HALLAZGOS_ID = "N009-MF000000363";
        public const string TEST_ROMBERG_DESCRIPCION_ID = "N009-MF000000375";


        #region Tamizaje Dermatológico
        public const string TAMIZAJE_DERMATOLOGIO_ID = "N009-ME000000044";
        public const string TAMIZAJE_DERMATOLOGIO_HALLAZGOS_ID = "N009-MF000000405";

        public const string TAMIZAJE_DERMATOLOGIO_SUFRE_UD_ENFERMEDAD_PIEL_ID = "N009-MF000000399";
        public const string TAMIZAJE_DERMATOLOGIO_SI_QUE_DX_TIENE_ID = "N009-MF000000400";
        public const string TAMIZAJE_DERMATOLOGIO_ACTUALMENTE_LESION_ID = "N009-MF000000401";
        public const string TAMIZAJE_DERMATOLOGIO_SI_DONDE_LOCALIZA_ID = "N009-MF000000402";
        public const string TAMIZAJE_DERMATOLOGIO_CUANTO_TIENE_LESION_ID = "N009-MF000000403";
        public const string TAMIZAJE_DERMATOLOGIO_PRESENTA_COLORACION_PIEL_ID = "N009-MF000000404";
        public const string TAMIZAJE_DERMATOLOGIO_LESIONES_REPITE_VARIAS_ANIOS_ID = "N009-MF000000405";
        public const string TAMIZAJE_DERMATOLOGIO_ENRROJECIMIENTO_PARTE_CUERPO_ID = "N009-MF000000406";
        public const string TAMIZAJE_DERMATOLOGIO_ENRROJECIMIENTO_SI_DONDE_LOCALIZA_ID = "N009-MF000000407";
        public const string TAMIZAJE_DERMATOLOGIO_TIENE_COMEZON_ID = "N009-MF000000408";
        public const string TAMIZAJE_DERMATOLOGIO_COMEZON_LOCALIZA_ID = "N009-MF000000409";
        public const string TAMIZAJE_DERMATOLOGIO_HINCHAZON_PARTE_CUERPO_ID = "N009-MF000000410";
        public const string TAMIZAJE_DERMATOLOGIO_HINCHAZON_PARTE_CUERPO_DONDE_LOCALIZA_ID = "N009-MF000000411";
        public const string TAMIZAJE_DERMATOLOGIO_ALERGIA_ASMA_ID = "N009-MF000000412";
        public const string TAMIZAJE_DERMATOLOGIO_USA_EPP_ID = "N009-MF000000413";

        public const string TAMIZAJE_DERMATOLOGIO_SI_TIPO_PROTECCION_USA_ID = "N009-MF000001009";
        public const string TAMIZAJE_DERMATOLOGIO_PRESENTA_CAMBIO_UNAS_ID = "N009-MF000001010";
        public const string TAMIZAJE_DERMATOLOGIO_TOMANDO_ALGUNA_MEDICACION_ID = "N009-MF000001011";
        public const string TAMIZAJE_DERMATOLOGIO_SI_COMO_SE_LLAMA_ID = "N009-MF000001012";
        public const string TAMIZAJE_DERMATOLOGIO_DOSIS_FRECUENCIA_ID = "N009-MF000001013";
        public const string TAMIZAJE_DERMATOLOGIO_DESCRIPCION1_ID = "N009-MF000001014";
        public const string TAMIZAJE_DERMATOLOGIO_DERMATOPIA_ID = "N009-MF000001015";
        public const string TAMIZAJE_DERMATOLOGIO_NIKOLSKY_ID = "N009-MF000001016";
        #endregion


        public const string EXAMEN_MAMA_ID = "N009-ME000000012";
        public const string EXAMEN_MAMA_HALLAZGOS_ID = "N009-MF000000511";

        public const string AUDIOMETRIA_OTOSCOPIA_OD = "N002-MF000000178";
        public const string AUDIOMETRIA_OTOSCOPIA_OI = "N002-MF000000179";
        public const string AUDIOMETRIA_ID = "N002-ME000000005";

        #region Espirometria

        public const string AUDIOMETRIA_CONCLUSIONES_ID = "N009-MF000000226";

        public const string ESPIROMETRIA_ID = "N002-ME000000031";
        public const string ESPIROMETRIA_CUESTIONARIO_ID = "CE";

        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_CVF = "N002-MF000000286";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_VEF_1 = "N002-MF000000287";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_VEF_1_CVF = "N002-MF000000169";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_FEF_25_75 = "N002-MF000000171";

        public const string ESPIROMETRIA_FUNCIÓN_RESPIRATORIA_ABS_RESULTADOS = "N009-MF000000205";
        public const string ESPIROMETRIA_FUNCIÓN_RESPIRATORIA_ABS_OBSERVACION = "N009-MF000000228";


        public const string ESPIROMETRIA_CVF_ID = "N009-ME000000578";
        public const string ESPIROMETRIA_VEF1_ID = "N009-ME000000579";
        public const string ESPIROMETRIA_VEF_CVF_ID = "N009-ME000000580";
        //public const string ESPIROMETRIA_VEF_CVF_ID = "N002-ME000000171";
        public const string ESPIROMETRIA_ORIGEN_ETNICO = "N009-MF000000622";
        public const string ESPIROMETRIA_TABAQUISMO = "N009-MF000000623";

        public const string ESPIROMETRIA_RESULTADO_ID = "N009-MF000000205";
        public const string ESPIROMETRIA_OBSERVACION_ID = "N009-MF000000228";

        public const string ESPIROMETRIA_TIEMPO_TRABAJO_ID = "N009-MF000001038";

        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_FET = "N002-MF000000170";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_PEF = "N002-MF000000168";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_CVF = "N009-MF000000578";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_VEF_1 = "N009-MF000000579";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_VEF_1_CVF = "N009-MF000000580";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_FET = "N009-MF000000582";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_F_25_75 = "N009-MF000000581";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_PEF = "N009-MF000000583";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_EDAD_PULMONAR_ESTIMADA = "N009-MF000000600";


        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_1 = "N002-MF000000199";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_2 = "N002-MF000000200";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_3 = "N002-MF000000201";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_4 = "N002-MF000000202";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_5 = "N002-MF000000203";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_6 = "N002-MF000000205";
        public const string ESPIROMETRIA_CUESTIONARIO_DE_EXCLUSION_7 = "N002-MF000000285";



        public const string PIROMETRIA_ANTECEDENTES_HEMOSTISIS = "N009-MF000000112";
        public const string ESPIROMETRIA_ANTECEDENTES_PNEUMOTORAX = "N009-MF000000113";
        public const string ESPIROMETRIA_ANTECEDENTES_TRAQUEOSTOMIA = "N009-MF000000114";
        public const string ESPIROMETRIA_ANTECEDENTES_SONDA_PLEURAL = "N009-MF000000115";
        public const string ESPIROMETRIA_ANTECEDENTES_ANEURISMA_CEREBRAL = "N009-MF000000118";
        public const string ESPIROMETRIA_ANTECEDENTES_EMBOLIA_PULMONAR = "N009-MF000000119";
        public const string ESPIROMETRIA_ANTECEDENTES_INFARTO_RECIENTE = "N009-MF000000116";
        public const string ESPIROMETRIA_ANTECEDENTES_INESTABILIDAD_CV = "N009-MF000000574";
        public const string ESPIROMETRIA_ANTECEDENTES_FIEBRE_NAUSEAS = "N009-MF000000117";
        public const string ESPIROMETRIA_ANTECEDENTES_EMBARAZO_AVANZADO = "N009-MF000000120";
        public const string ESPIROMETRIA_ANTECEDENTES_EMBARAZO_COMPLICADO = "N009-MF000000121";


        public const string ESESPIROMETRIA_CUESTIONARIO_PARA_1 = "N002-MF000000207";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_2 = "N002-MF000000284";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_3 = "N002-MF000000204";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_4 = "N002-MF000000206";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_5 = "N002-MF000000208";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_6 = "N002-MF000000205";
        public const string ESPIROMETRIA_CUESTIONARIO_PARA_7 = "N002-MF000000285";

        //ASMA
        public const string ESPIROMETRIA_OBSERVACIONES_ASMA = "N009-MF000004940";
        public const string ESPIROMETRIA_OBSERVACIONES_ASMA_TIEMPO = "N009-MF000004941";
        public const string ESPIROMETRIA_OBSERVACIONES_ASMA_CRISIS = "N009-MF000004942";

        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_F_50 = "N009-MF000000576";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_MEF = "N009-MF000000575";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_R_50 = "N009-MF000000576";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_MVV = "N009-MF000000577";

        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_FVC = "N009-MF000000578";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_DES_VEF_1 = "N009-MF000000579";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_DES_PEF = "N009-MF000000580";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_FER = "N009-MF000000581";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_F_25 = "N009-MF000000582";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_F_50 = "N009-MF000000585";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_MEF = "N009-MF000000584";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_R_50 = "N009-MF000000585";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_DESCRIPCION_MVV = "N009-MF000000586";

        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_Normal = "N009-MF000002131";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_SindromeRestrictivo = "N009-MF000002155";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_SindromeObtructivo = "N009-MF000002154";
        public const string ESPIROMETRIA_FUNCION_RESPIRATORIA_ABS_Observacion = "N009-MF000003135";
        #endregion Apendice
        public const string APENDICE_ID = "N009-ME000000413";
        public const string APENDICE_ST = "N009-MF000003133";
        public const string APENDICE_OTRAS_ALTERACIONES = "N009-MF000003134";
        #region

        #endregion

        #region Electrocardiograma
        public const string ELECTROCARDIOGRAMA_ID = "N002-ME000000025";
        //Antecedentes
        public const string ELECTROCARDIOGRAMA_ATAQUE_CORAZON_ID = "N009-MF000000128";
        public const string ELECTROCARDIOGRAMA_CANSANCIO_RAPIDO_ID = "N009-MF000000123";
        public const string ELECTROCARDIOGRAMA_DIABETES_ID = "N009-MF000000132";
        public const string ELECTROCARDIOGRAMA_DISLIPIDEMIA_ID = "N009-MF000000133";
        public const string ELECTROCARDIOGRAMA_DOLOR_PRECORDIAL_ID = "N009-MF000000126";
        public const string ELECTROCARDIOGRAMA_MAREOS_ID = "N009-MF000000125";
        public const string ELECTROCARDIOGRAMA_OBESIDAD_ID = "N009-MF000000130";
        public const string ELECTROCARDIOGRAMA_OTROS1_ESPECIFICAR_ID = "N009-MF000000136";
        public const string ELECTROCARDIOGRAMA_PALPITACIONES_ID = "N009-MF000000127";
        public const string ELECTROCARDIOGRAMA_PERDIDA_CONCIENCIA_ID = "N009-MF000000129";
        public const string ELECTROCARDIOGRAMA_PRESION_ALTA_ID = "N009-MF000000124";
        public const string ELECTROCARDIOGRAMA_SEDENTARISMO_ID = "N009-MF000000135";
        public const string ELECTROCARDIOGRAMA_SOPLO_CARDIACO_ID = "N009-MF000000122";
        public const string ELECTROCARDIOGRAMA_TABAQUISMO_ID = "N009-MF000000131";
        //

        //SINTOMAS
        public const string ELECTROCARDIOGRAMA_CLAUDICAC_INTERMITENTE_ID = "N009-MF000000142";
        public const string ELECTROCARDIOGRAMA_DESMAYOS_ID = "N009-MF000000138";
        public const string ELECTROCARDIOGRAMA_DISNEA_PAROXISTICA_ID = "N009-MF000000140";
        public const string ELECTROCARDIOGRAMA_DOLOR_PRECORDIAL1_ID = "N009-MF000000137";
        public const string ELECTROCARDIOGRAMA_MAREOS1_ID = "N009-MF000000141";
        public const string ELECTROCARDIOGRAMA_OTROS2_ID = "N009-MF000000143";
        public const string ELECTROCARDIOGRAMA_PALPITACIONES2_ID = "N009-MF000000139";
        public const string ELECTROCARDIOGRAMA_VARICES_PIERNAS_ID = "N009-MF000000134";
        //VALORES NUMERICOS
        public const string ELECTROCARDIOGRAMA_INTERVALO_PR_ID = "N002-MF000000187";
        public const string ELECTROCARDIOGRAMA_INTERVALO_QRS_ID = "N002-MF000000188";
        public const string ELECTROCARDIOGRAMA_INTERVALO_QT_ID = "N002-MF000000189";
        public const string ELECTROCARDIOGRAMA_RITMO_SINUAL_ID = "N002-MF000000186";
        //INFORME DESCRIPTIVO
        public const string ELECTROCARDIOGRAMA_COMPLEJO_QRS_ID = "N002-MF000000197";
        public const string ELECTROCARDIOGRAMA_COMPLEJO_QRS_ANORMAL_ID = "N009-MF000000225";
        public const string ELECTROCARDIOGRAMA_OBSERVACION_ID = "N009-MF000001008";
        public const string ELECTROCARDIOGRAMA_ONDA_P_ID = "N002-MF000000190";
        public const string ELECTROCARDIOGRAMA_ONDA_P_ANORMAL_ID = "N002-MF000000195";
        public const string ELECTROCARDIOGRAMA_ONDA_T_ID = "N002-MF000000194";
        public const string ELECTROCARDIOGRAMA_ONDA_T_ANORMAL_ID = "N002-MF000000193";
        public const string ELECTROCARDIOGRAMA_SEGMENTO_ST_ID = "N002-MF000000196";
        public const string ELECTROCARDIOGRAMA_SEGMENTO_ST_ANORMAL_ID = "N009-MF000001006";
        //INFORME DESCRIPTIVO1
        public const string ELECTROCARDIOGRAMA_TRANSTORNOS_CONDUCCION_ID = "N002-MF000000192";
        public const string ELECTROCARDIOGRAMA_TRANSTORNOS_RITMO_ID = "N002-MF000000191";
        //CONCLUSION
        public const string ELECTROCARDIOGRAMA_DESCRIPCION_ID = "N009-MF000000227";
        #endregion

        #region PRUEBA ESFUERZO


        public const string PRUEBA_ESFUERZO_ID = "N002-ME000000029";
        public const string PRUEBA_ESFUERZO_DESCRIPCION_ID = "N002-MF000000370";
        //Antecedentes
        public const string PRUEBA_ESFUERZO_FUMADOR_ID = "N002-MF000000344";
        public const string PRUEBA_ESFUERZO_DIABETICO_ID = "N002-MF000000345";
        public const string PRUEBA_ESFUERZO_INFARTO_ID = "N002-MF000000346";
        public const string PRUEBA_ESFUERZO_ANTECEDENTE_FAMILIAR_ID = "N002-MF000000347";
        public const string PRUEBA_ESFUERZO_PRIOR_ID = "N002-MF000000348";
        public const string PRUEBA_ESFUERZO_ANGINA_ID = "N002-MF000000349";


        //RESUMEN
        public const string PRUEBA_ESFUERZO_CPVS_ID = "N002-MF000000363";
        public const string PRUEBA_ESFUERZO_TIEMPO_EJERCICIO_ID = "N002-MF000000364";
        public const string PRUEBA_ESFUERZO_DERIV_100_UVST_ID = "N002-MF000000365";
        //VALORES MAXIMOS
        public const string PRUEBA_ESFUERZO_VELOCIDAD_ID = "N002-MF000000366";
        public const string PRUEBA_ESFUERZO_PENDIENTE_ID = "N002-MF000000367";
        public const string PRUEBA_ESFUERZO_METS_ID = "N002-MF000000368";
        public const string PRUEBA_ESFUERZO_F_CARDIACA_ID = "N009-MF000000974";
        public const string PRUEBA_ESFUERZO_P_SISTOLICA_ID = "N009-MF000000975";
        public const string PRUEBA_ESFUERZO_DIASTOLICA_ID = "N009-MF000000976";
        public const string PRUEBA_ESFUERZO_FCXTA_ID = "N009-MF000000977";
        public const string PRUEBA_ESFUERZO_INDICE_STFC_ID = "N009-MF000000978";
        public const string PRUEBA_ESFUERZO_OBJETIVO_ID = "N009-MF000000979";
        //CONCLUSIONES
        public const string PRUEBA_ESFUERZO_RAZONES_FINALIZAR_ID = "N002-MF000000369";
        public const string PRUEBA_ESFUERZO_CONCLUSIONES_ID = "N002-MF000000370";
        public const string PRUEBA_ESFUERZO_SINTOMAS_ID = "N009-MF000000992";
        //PRUEBA DE ESFUERZO


        public const string PRUEBA_ESFUERZO_P_REPOSO_INICIO_ID = "N002-MF000000357";
        public const string PRUEBA_ESFUERZO_P_REPOSO_DURACION_ID = "N002-MF000000358";
        public const string PRUEBA_ESFUERZO_P_REPOSO_VELOCIDAD_ID = "N002-MF000000359";
        public const string PRUEBA_ESFUERZO_P_REPOSO_INCLINACION_ID = "N002-MF000000360";
        public const string PRUEBA_ESFUERZO_P_REPOSO_MTS_ID = "N009-MF000000927";
        public const string PRUEBA_ESFUERZO_P_REPOSO_FC_ID = "N009-MF000000928";
        public const string PRUEBA_ESFUERZO_P_REPOSO_PAS_ID = "N009-MF000000929";
        public const string PRUEBA_ESFUERZO_P_REPOSO_PRODUCTO_ID = "N009-MF000000930";
        public const string PRUEBA_ESFUERZO_P_REPOSO_COMENTARIO_ID = "N009-MF000000931";


        public const string PRUEBA_ESFUERZO_P_ESFUERZO_INICIO_ID = "N002-MF000000362";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_DURACION_ID = "N009-MF000000887";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_VELOCIDAD_ID = "N009-MF000000888";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_INCLINACION_ID = "N009-MF000000889";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_MTS_ID = "N009-MF000000933";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_FC_ID = "N009-MF000000934";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_PAS_ID = "N009-MF000000935";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_PRODUCTO_ID = "N009-MF000000936";
        public const string PRUEBA_ESFUERZO_P_ESFUERZO_COMENTARIO_ID = "N009-MF000000937";

        public const string PRUEBA_ESFUERZO_S_ESFUERZO_INICIO_ID = "N009-MF000000891";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_DURACION_ID = "N009-MF000000892";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_VELOCIDAD_ID = "N009-MF000000893";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_INCLINACION_ID = "N009-MF000000894";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_MTS_ID = "N009-MF000000939";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_FC_ID = "N009-MF000000940";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_PAS_ID = "N009-MF000000941";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_PRODUCTO_ID = "N009-MF000000942";
        public const string PRUEBA_ESFUERZO_S_ESFUERZO_COMENTARIO_ID = "N009-MF000000943";

        public const string PRUEBA_ESFUERZO_T_ESFUERZO_INICIO_ID = "N009-MF000000896";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_DURACION_ID = "N009-MF000000897";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_VELOCIDAD_ID = "N009-MF000000898";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_INCLINACION_ID = "N009-MF000000899";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_MTS_ID = "N009-MF000000945";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_FC_ID = "N009-MF000000946";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_PAS_ID = "N009-MF000000947";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_PRODUCTO_ID = "N009-MF000000948";
        public const string PRUEBA_ESFUERZO_T_ESFUERZO_COMENTARIO_ID = "N009-MF000000949";

        public const string PRUEBA_ESFUERZO_C_ESFUERZO_INICIO_ID = "N009-MF000000901";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_DURACION_ID = "N009-MF000000902";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_VELOCIDAD_ID = "N009-MF000000903";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_INCLINACION_ID = "N009-MF000000904";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_MTS_ID = "N009-MF000000951";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_FC_ID = "N009-MF000000952";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_PAS_ID = "N009-MF000000953";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_PRODUCTO_ID = "N009-MF000000954";
        public const string PRUEBA_ESFUERZO_C_ESFUERZO_COMENTARIO_ID = "N009-MF000000955";

        public const string PRUEBA_ESFUERZO_P_RECUPERACION_INICIO_ID = "N009-MF000000906";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_DURACION_ID = "N009-MF000000907";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_VELOCIDAD_ID = "N009-MF000000908";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_INCLINACION_ID = "N009-MF000000909";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_MTS_ID = "N009-MF000000957";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_FC_ID = "N009-MF000000958";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_PAS_ID = "N009-MF000000959";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_PRODUCTO_ID = "N009-MF000000960";
        public const string PRUEBA_ESFUERZO_P_RECUPERACION_COMENTARIO_ID = "N009-MF000000961";

        public const string PRUEBA_ESFUERZO_S_RECUPERACION_INICIO_ID = "N009-MF000000911";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_DURACION_ID = "N009-MF000000912";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_VELOCIDAD_ID = "N009-MF000000913";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_INCLINACION_ID = "N009-MF000000914";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_MTS_ID = "N009-MF000000963";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_FC_ID = "N009-MF000000964";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_PAS_ID = "N009-MF000000965";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_PRODUCTO_ID = "N009-MF000000966";
        public const string PRUEBA_ESFUERZO_S_RECUPERACION_COMENTARIO_ID = "N009-MF000000967";

        public const string PRUEBA_ESFUERZO_S_REPOSO_INICIO_ID = "N009-MF000000916";
        public const string PRUEBA_ESFUERZO_S_REPOSO_DURACION_ID = "N009-MF000000917";
        public const string PRUEBA_ESFUERZO_S_REPOSO_VELOCIDAD_ID = "N009-MF000000918";
        public const string PRUEBA_ESFUERZO_S_REPOSO_INCLINACION_ID = "N009-MF000000919";
        public const string PRUEBA_ESFUERZO_S_REPOSO_MTS_ID = "N009-MF000000969";
        public const string PRUEBA_ESFUERZO_S_REPOSO_FC_ID = "N009-MF000000970";
        public const string PRUEBA_ESFUERZO_S_REPOSO_PAS_ID = "N009-MF000000971";
        public const string PRUEBA_ESFUERZO_S_REPOSO_PRODUCTO_ID = "N009-MF000000972";
        public const string PRUEBA_ESFUERZO_S_REPOSO_COMENTARIO_ID = "N009-MF000000973";

        //MAXIMO ST
        public const string PRUEBA_ESFUERZO_ELEVACION_ST_ID = "N009-MF000000980";
        public const string PRUEBA_ESFUERZO_ELEVACION_ST_EN_ID = "N009-MF000000981";
        public const string PRUEBA_ESFUERZO_ELEVACION_ST_ALOS_ID = "N009-MF000000982";

        public const string PRUEBA_ESFUERZO_DEPRESION_ST_ID = "N009-MF000000983";
        public const string PRUEBA_ESFUERZO_DEPRESION_ST_EN_ID = "N009-MF000000984";
        public const string PRUEBA_ESFUERZO_DEPRESION_ST_ALOS_ID = "N009-MF000000985";

        //MAXIMO CAMBIOS
        public const string PRUEBA_ESFUERZO_CAMBIO_ELEVACION_ST_ID = "N009-MF000000986";
        public const string PRUEBA_ESFUERZO_CAMBIO_ELEVACION_ST_EN_ID = "N009-MF000000987";
        public const string PRUEBA_ESFUERZO_CAMBIO_ELEVACION_ST_ALOS_ID = "N009-MF000000988";

        public const string PRUEBA_ESFUERZO_CAMBIO_DEPRESION_ST_ID = "N009-MF000000989";
        public const string PRUEBA_ESFUERZO_CAMBIO_DEPRESION_ST_EN_ID = "N009-MF000000990";
        public const string PRUEBA_ESFUERZO_CAMBIO_DEPRESION_ST_ALOS_ID = "N009-MF000000991";

        #endregion

        public const string AUDIOMETRIA_AUDIOMAX_ID = "N009-ME000000135";

        #region ASCENSO GRANDES ALTURAS 7D


        public const string ALTURA_7D_ID = "N002-ME000000045";

        public const string ASCENSO_GRANDES_ALTURAS_ACTIVIDAD = "N002-MF000000306"; 
        public const string ASCENSO_GRANDES_ALTURAS_PROBLEMAS_CARDIACOS_ID = "N002-MF000000307";
        public const string ASCENSO_GRANDES_ALTURAS_PROBLEMAS_OFTALMOLOGICOS_ID = "N002-MF000000308";
        public const string ASCENSO_GRANDES_ALTURAS_PROBLEMAS_DIGESTIVOS_ID = "N002-MF000000309";
        public const string ASCENSO_GRANDES_ALTURAS_DESORDENES_COAGULACION_ID = "N002-MF000000310";
        public const string ASCENSO_GRANDES_ALTURAS_PROBLEMAS_RESPIRATORIOS_ID = "N002-MF000000311";
        public const string ASCENSO_GRANDES_ALTURAS_PROBLEMAS_NEUROLOGICOS_ID = "N002-MF000000312";
        public const string ASCENSO_GRANDES_ALTURAS_CIRUGIA_MAYOR_CRECIENTE_ID = "N002-MF000000313";
        public const string ASCENSO_GRANDES_ALTURAS_INFECCIONES_RECIENTES_ID = "N002-MF000000314";
        public const string ASCENSO_GRANDES_ALTURAS_HIPERTENSION_ARTERIAL_ID = "N002-MF000000315";
        public const string ASCENSO_GRANDES_ALTURAS_OBESIDAD_MORBIDA_ID = "N002-MF000000316";
        public const string ASCENSO_GRANDES_ALTURAS_DIABETES_MELLITUS_ID = "N002-MF000000317";
        public const string ASCENSO_GRANDES_ALTURAS_APNEA_SUEÑO_ID = "N002-MF000000318";
        public const string ASCENSO_GRANDES_ALTURAS_EMBARAZO_ID = "N002-MF000000319";
        public const string ASCENSO_GRANDES_ALTURAS_ALERGIAS_ID = "N002-MF000000320";
        public const string ALTURA_7D_ANEMIA_ID = "N002-MF000000321";
        public const string ASCENSO_GRANDES_ALTURAS_USO_MEDICACION_ACTUAL_ID = "N002-MF000000322";

        public const string ASCENSO_GRANDES_ALTURAS_APTO_ASCENDER_GRANDES_ALTURAS_ID = "N002-MF000000323";
        public const string ASCENSO_GRANDES_ALTURAS_OTRA_CONDICON_ID = "N002-MF000000325";
        public const string ALTURA_7D_DESCRIPCION_ID = "N009-MF000000230";

        public const string ASCENSO_GRANDES_ALTURAS_ACTIVIDAD_REALIZAR_DESCRIPCION_ID = "N002-MF000000306";

        #endregion


        #region ODONTOGRAMA


        //public const string ODONTOGRAMA_OTROS_ANTECEDENTES_ID = "N002-MF000000027";
        public const string ODONTOGRAMA_PIEZAS_CURACION_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_CORONA_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_EXODONCIA_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_IMPLANTE_ID = "N002-MF000000027";

        //public const string ODONTOGRAMA_PPR_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_PROTESIS_TOTAL_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_PLACA_BACTERIANA_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_REMANENTES_RETICULARES_ID = "N002-MF000000027";
        //public const string ODONTOGRAMA_DIAGNOSTICOS_ID = "N002-MF000000027";
        public const string ODONTOGRAMA_APTITUD_ID = "N002-ODO00000198";
        public const string ODONTOGRAMA_OTROS_EXAMEN_ID = "N002-ODO00000195";
        public const string ODONTOGRAMA_PIEZAS_CARIES_ID = "N002-ODO00000193";
        public const string ODONTOGRAMA_PIEZAS_AUSENTES_ID = "N002-ODO00000194";

        public const string ODONTOGRAMA_ID = "N002-ME000000027";
        public const string ODONTOGRAMA_TABACO_ID = "N009-MF000000040";
        public const string ODONTOGRAMA_DIABETES_ID = "N009-MF000000210";
        public const string ODONTOGRAMA_TBC_ID = "N009-MF000000208";
        public const string ODONTOGRAMA_ETS_ID = "N009-MF000000211";
        public const string ODONTOGRAMA_HEMATOPATIAS_ID = "N009-MF000000209";
        public const string ODONTOGRAMA_OBESIDAD_ID = "N009-MF000000212";
        public const string ODONTOGRAMA_PERIODONTITIS_ID = "N009-MF000000213";
        public const string ODONTOGRAMA_MOVILIDAD_ID = "N009-MF000000216";
        public const string ODONTOGRAMA_RECESION_ID = "N009-MF000000214";
        public const string ODONTOGRAMA_EXUDACION_ID = "N009-MF000000217";
        public const string ODONTOGRAMA_GINGIVITIS_ID = "N002-MF000000185";
        public const string ODONTOGRAMA_BOLSA_PERIODONTALES_ID = "N009-MF000000215";
        public const string ODONTOGRAMA_PLACA_BACTERIANA_ID = "N002-ODO00000196";
        public const string ODONTOGRAMA_REMANENTES_RETICULARES_ID = "N002-ODO00000197";
        public const string ODONTOGRAMA_CONCLUSIONES_DESCRIPCION_ID = "N009-MF000000377";

        #endregion

        public const string EVALUACION_ERGONOMICA_ID = "N009-ME000000036";
        public const string EVALUACION_ERGONOMICA_CONCLUSION_ID = "N009-MF000000317";
        public const string EVALUACION_ERGONOMICA_DESCRIPCION_ID = "N009-MF000000316";

        public const string ALTURA_GEOGRAFICA_ID = "N002-ME000000045";
        public const string ALTURA_GEOGRAFICA_APTO_ID = "N002-MF000000323";
        public const string ALTURA_GEOGRAFICA_DESCRIPCION_ID = "N009-MF000000230";

        #region EXAMEN FISICO 7C


        public const string EXAMEN_FISICO_7C_ID = "N009-ME000000052";
        public const string EXAMEN_FISICO_7C_RUIDO_ID = "N009-MF000000667";
        public const string EXAMEN_FISICO_7C_CANCERIGENOS_ID = "N009-MF000000668";
        public const string EXAMEN_FISICO_7C_TEMPERATURA_ID = "N009-MF000000669";
        public const string EXAMEN_FISICO_7C_CARGAS_ID = "N009-MF000000670";
        public const string EXAMEN_FISICO_7C_POLVO_ID = "N009-MF000000671";
        public const string EXAMEN_FISICO_7C_MUTAGENICOS_ID = "N009-MF000000672";
        public const string EXAMEN_FISICO_7C_BIOLOGICOS_ID = "N009-MF000000673";
        public const string EXAMEN_FISICO_7C_MOV_REPETITIVOS_ID = "N009-MF000000674";
        public const string EXAMEN_FISICO_7C_VIG_SEGMENTARIA_ID = "N009-MF000000675";
        public const string EXAMEN_FISICO_7C_SOLVENTES_ID = "N009-MF000000676";
        public const string EXAMEN_FISICO_7C_POSTURAS_ID = "N009-MF000000677";
        public const string EXAMEN_FISICO_7C_PVD_ID = "N009-MF000000678";
        public const string EXAMEN_FISICO_7C_Vid_Total_ID = "N009-MF000000679";

        public const string EXAMEN_FISICO_7C_METAL_PESADO_ID = "N009-MF000000683";
        public const string EXAMEN_FISICO_7C_TURNOS_ID = "N009-MF000000684";
        public const string EXAMEN_FISICO_7C_OTROS_ID = "N009-MF000000685";
        public const string EXAMEN_FISICO_7C_DESCRIBIR_ID = "N009-MF000000686";

        public const string EXAMEN_FISICO_7C_EXAMENFISICO_ABDOMEN_DESCRIPCION = "N009-MF000000697";
        public const string EXAMEN_FISICO_7C_EXAMENFISICO_ANILLOS_INGUINALES_DESCRIPCION = "N009-MF000000698";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_BOCA_ADMIGDALA_FARINGE_LARINGE_DESCRIPCION = "N009-MF000000690";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_CABEZA_DESCRIPCION = "N009-MF000000687";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_COLUMNA_DESCRIPCION = "N009-MF000000696";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_CUELLO_DESCRIPCION = "N009-MF000000688";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_GANGLIOS_DESCRIPCION = "N009-MF000000702";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_HERNIAS_DESCRIPCION = "N009-MF000000699";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_MARCHA_DESCRIPCION = "N009-MF000000695";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_MIEMBROS_INFERIORES_DESCRIPCION = "N009-MF000000693";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_MIEMBROS_SUPERIORES_DESCRIPCION = "N009-MF000000692";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_NARIZ_DESCRIPCION = "N009-MF000000689";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_ORGANOS_GENITALES_DESCRIPCION = "N009-MF000000701";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_REFLEJOS_OSTEO_TENDINOSOS_DESCRIPCION = "N009-MF000000694";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_REFLEJOS_PUPILARES_DESCRIPCION = "N009-MF000000691";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_VARICES_DESCRIPCION = "N009-MF000000700";

        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_PULMONES_NORMAL = "N009-MF000000660";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_PULMONES_ANORMAL = "N009-MF000000661";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_PULMONES_DESCRIPCION = "N009-MF000000662";


        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_TACTO_RECTAL_NORMAL = "N009-MF000000663";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_TACTO_RECTAL_ANORMAL = "N009-MF000000664";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_TACTO_RECTAL_DESCRIPCION = "N009-MF000000665";
        public const string EXAMEN_FISICO_7C_EXAMEN_FISICO_TACTO_RECTAL_NO_RELIZADO = "N009-MF000000666";

        // COMBOS ***
        public const string EXAMEN_FISICO_7C_CABEZA_ID = "N009-MF000000626";
        public const string EXAMEN_FISICO_7C_CUELLO_ID = "N009-MF000000627";
        public const string EXAMEN_FISICO_7C_NARIZ_ID = "N009-MF000000628";
        public const string EXAMEN_FISICO_7C_BOCA_ID = "N009-MF000000629";
        public const string EXAMEN_FISICO_7C_REFLEJOS_PUPILARES_ID = "N009-MF000000648";
        public const string EXAMEN_FISICO_7C_MIEMBROS_SUPERIORES = "N009-MF000000649";
        public const string EXAMEN_FISICO_7C_MIEMBROS_INFERIORES = "N009-MF000000650";
        public const string EXAMEN_FISICO_7C_REFLEJOS_OSTEO = "N009-MF000000651";
        public const string EXAMEN_FISICO_7C_MARCHA = "N009-MF000000652";
        public const string EXAMEN_FISICO_7C_COLUMNA = "N009-MF000000653";
        public const string EXAMEN_FISICO_7C_ABDOMEN = "N009-MF000000654";
        public const string EXAMEN_FISICO_7C_ANILLOS_IMGUINALES = "N009-MF000000655";
        public const string EXAMEN_FISICO_7C_HERNIAS = "N009-MF000000656";
        public const string EXAMEN_FISICO_7C_VARICES = "N009-MF000000657";
        public const string EXAMEN_FISICO_7C_ORGANOS_GENITALES = "N009-MF000000658";
        public const string EXAMEN_FISICO_7C_GANGLIOS = "N009-MF000000659";

        public const string EXAMEN_FISICO_7C_MEDICACION = "N009-MF000004354";

        //***

        public const string EXAMEN_FISICO_7C_HALLAZGOS_ID = "N009-MF000000703";


        public const string EXAMEN_FISICO_7C_RIESGO_FISICO = "N009-MF000001828";
        public const string EXAMEN_FISICO_7C_RIESGO_QUIMICO = "N009-MF000001829";
        public const string EXAMEN_FISICO_7C_RIESGO_BIOLOGICO = "N009-MF000001830";
        public const string EXAMEN_FISICO_7C_RIESGO_ERGONOMICO = "N009-MF000001831";
        public const string EXAMEN_FISICO_7C_RIESGO_PSICOLABORAL = "N009-MF000001832";
        public const string EXAMEN_FISICO_7C_PSICOLOGIA = "N009-MF000003264";
        #endregion

        public const string MAMOGRAFIA_ID = "N009-ME000000014";
        public const string MAMOGRAFIA_DERECHA_ID = "N009-MF000000023";
        public const string MAMOGRAFIA_IZQUIERDA_ID = "N009-MF000000024";

        #region Papanicolao

        public const string PAPANICOLAU_ID = "N009-ME000000013";
        public const string PAPANICOLAU_HALLAZGOS = "N009-MF000000446";
        public const string PAPANICOLAU_RADIOGRAFIA_HALLAZGOS = "N009-MF000001139";

        #endregion

        #region MyRegion

        // Cuadrante 1
        public const string D11_1 = "N002-ODO00000001";
        public const string D11_2 = "N002-ODO00000002";
        public const string D11_3 = "N002-ODO00000003";
        public const string D11_4 = "N002-ODO00000004";
        public const string D11_5 = "N002-ODO00000005";
        public const string D11_6 = "N002-ODO00000006";

        public const string D12_1 = "N002-ODO00000007";
        public const string D12_2 = "N002-ODO00000008";
        public const string D12_3 = "N002-ODO00000009";
        public const string D12_4 = "N002-ODO00000010";
        public const string D12_5 = "N002-ODO00000011";
        public const string D12_6 = "N002-ODO00000012";

        public const string D13_1 = "N002-ODO00000013";
        public const string D13_2 = "N002-ODO00000014";
        public const string D13_3 = "N002-ODO00000015";
        public const string D13_4 = "N002-ODO00000016";
        public const string D13_5 = "N002-ODO00000017";
        public const string D13_6 = "N002-ODO00000018";

        public const string D14_1 = "N002-ODO00000019";
        public const string D14_2 = "N002-ODO00000020";
        public const string D14_3 = "N002-ODO00000021";
        public const string D14_4 = "N002-ODO00000022";
        public const string D14_5 = "N002-ODO00000023";
        public const string D14_6 = "N002-ODO00000024";

        public const string D15_1 = "N002-ODO00000025";
        public const string D15_2 = "N002-ODO00000026";
        public const string D15_3 = "N002-ODO00000027";
        public const string D15_4 = "N002-ODO00000028";
        public const string D15_5 = "N002-ODO00000029";
        public const string D15_6 = "N002-ODO00000030";

        public const string D16_1 = "N002-ODO00000031";
        public const string D16_2 = "N002-ODO00000032";
        public const string D16_3 = "N002-ODO00000033";
        public const string D16_4 = "N002-ODO00000034";
        public const string D16_5 = "N002-ODO00000035";
        public const string D16_6 = "N002-ODO00000036";

        public const string D17_1 = "N002-ODO00000037";
        public const string D17_2 = "N002-ODO00000038";
        public const string D17_3 = "N002-ODO00000039";
        public const string D17_4 = "N002-ODO00000040";
        public const string D17_5 = "N002-ODO00000041";
        public const string D17_6 = "N002-ODO00000042";

        public const string D18_1 = "N002-ODO00000043";
        public const string D18_2 = "N002-ODO00000044";
        public const string D18_3 = "N002-ODO00000045";
        public const string D18_4 = "N002-ODO00000046";
        public const string D18_5 = "N002-ODO00000047";
        public const string D18_6 = "N002-ODO00000048";


        // Cuandrante 2

        public const string D21_1 = "N002-ODO00000049";
        public const string D21_2 = "N002-ODO00000050";
        public const string D21_3 = "N002-ODO00000051";
        public const string D21_4 = "N002-ODO00000052";
        public const string D21_5 = "N002-ODO00000053";
        public const string D21_6 = "N002-ODO00000054";

        public const string D22_1 = "N002-ODO00000055";
        public const string D22_2 = "N002-ODO00000056";
        public const string D22_3 = "N002-ODO00000057";
        public const string D22_4 = "N002-ODO00000058";
        public const string D22_5 = "N002-ODO00000059";
        public const string D22_6 = "N002-ODO00000060";

        public const string D23_1 = "N002-ODO00000061";
        public const string D23_2 = "N002-ODO00000062";
        public const string D23_3 = "N002-ODO00000063";
        public const string D23_4 = "N002-ODO00000064";
        public const string D23_5 = "N002-ODO00000065";
        public const string D23_6 = "N002-ODO00000066";

        public const string D24_1 = "N002-ODO00000067";
        public const string D24_2 = "N002-ODO00000068";
        public const string D24_3 = "N002-ODO00000069";
        public const string D24_4 = "N002-ODO00000070";
        public const string D24_5 = "N002-ODO00000071";
        public const string D24_6 = "N002-ODO00000072";

        public const string D25_1 = "N002-ODO00000073";
        public const string D25_2 = "N002-ODO00000074";
        public const string D25_3 = "N002-ODO00000075";
        public const string D25_4 = "N002-ODO00000076";
        public const string D25_5 = "N002-ODO00000077";
        public const string D25_6 = "N002-ODO00000078";

        public const string D26_1 = "N002-ODO00000079";
        public const string D26_2 = "N002-ODO00000080";
        public const string D26_3 = "N002-ODO00000081";
        public const string D26_4 = "N002-ODO00000082";
        public const string D26_5 = "N002-ODO00000083";
        public const string D26_6 = "N002-ODO00000084";

        public const string D27_1 = "N002-ODO00000085";
        public const string D27_2 = "N002-ODO00000086";
        public const string D27_3 = "N002-ODO00000087";
        public const string D27_4 = "N002-ODO00000088";
        public const string D27_5 = "N002-ODO00000089";
        public const string D27_6 = "N002-ODO00000090";

        public const string D28_1 = "N002-ODO00000091";
        public const string D28_2 = "N002-ODO00000092";
        public const string D28_3 = "N002-ODO00000093";
        public const string D28_4 = "N002-ODO00000094";
        public const string D28_5 = "N002-ODO00000095";
        public const string D28_6 = "N002-ODO00000096";

        // Cuandrante 3

        public const string D31_1 = "N002-ODO00000097";
        public const string D31_2 = "N002-ODO00000098";
        public const string D31_3 = "N002-ODO00000099";
        public const string D31_4 = "N002-ODO00000100";
        public const string D31_5 = "N002-ODO00000101";
        public const string D31_6 = "N002-ODO00000102";

        public const string D32_1 = "N002-ODO00000103";
        public const string D32_2 = "N002-ODO00000104";
        public const string D32_3 = "N002-ODO00000105";
        public const string D32_4 = "N002-ODO00000106";
        public const string D32_5 = "N002-ODO00000107";
        public const string D32_6 = "N002-ODO00000108";

        public const string D33_1 = "N002-ODO00000109";
        public const string D33_2 = "N002-ODO00000110";
        public const string D33_3 = "N002-ODO00000111";
        public const string D33_4 = "N002-ODO00000112";
        public const string D33_5 = "N002-ODO00000113";
        public const string D33_6 = "N002-ODO00000114";

        public const string D34_1 = "N002-ODO00000115";
        public const string D34_2 = "N002-ODO00000116";
        public const string D34_3 = "N002-ODO00000117";
        public const string D34_4 = "N002-ODO00000118";
        public const string D34_5 = "N002-ODO00000119";
        public const string D34_6 = "N002-ODO00000120";

        public const string D35_1 = "N002-ODO00000121";
        public const string D35_2 = "N002-ODO00000122";
        public const string D35_3 = "N002-ODO00000123";
        public const string D35_4 = "N002-ODO00000124";
        public const string D35_5 = "N002-ODO00000125";
        public const string D35_6 = "N002-ODO00000126";

        public const string D36_1 = "N002-ODO00000127";
        public const string D36_2 = "N002-ODO00000128";
        public const string D36_3 = "N002-ODO00000129";
        public const string D36_4 = "N002-ODO00000130";
        public const string D36_5 = "N002-ODO00000131";
        public const string D36_6 = "N002-ODO00000132";

        public const string D37_1 = "N002-ODO00000133";
        public const string D37_2 = "N002-ODO00000134";
        public const string D37_3 = "N002-ODO00000135";
        public const string D37_4 = "N002-ODO00000136";
        public const string D37_5 = "N002-ODO00000137";
        public const string D37_6 = "N002-ODO00000138";

        public const string D38_1 = "N002-ODO00000139";
        public const string D38_2 = "N002-ODO00000140";
        public const string D38_3 = "N002-ODO00000141";
        public const string D38_4 = "N002-ODO00000142";
        public const string D38_5 = "N002-ODO00000143";
        public const string D38_6 = "N002-ODO00000144";

        // Cuandrante 4

        public const string D41_1 = "N002-ODO00000145";
        public const string D41_2 = "N002-ODO00000146";
        public const string D41_3 = "N002-ODO00000147";
        public const string D41_4 = "N002-ODO00000148";
        public const string D41_5 = "N002-ODO00000149";
        public const string D41_6 = "N002-ODO00000150";

        public const string D42_1 = "N002-ODO00000151";
        public const string D42_2 = "N002-ODO00000152";
        public const string D42_3 = "N002-ODO00000153";
        public const string D42_4 = "N002-ODO00000154";
        public const string D42_5 = "N002-ODO00000155";
        public const string D42_6 = "N002-ODO00000156";

        public const string D43_1 = "N002-ODO00000157";
        public const string D43_2 = "N002-ODO00000158";
        public const string D43_3 = "N002-ODO00000159";
        public const string D43_4 = "N002-ODO00000160";
        public const string D43_5 = "N002-ODO00000161";
        public const string D43_6 = "N002-ODO00000162";

        public const string D44_1 = "N002-ODO00000163";
        public const string D44_2 = "N002-ODO00000164";
        public const string D44_3 = "N002-ODO00000165";
        public const string D44_4 = "N002-ODO00000166";
        public const string D44_5 = "N002-ODO00000167";
        public const string D44_6 = "N002-ODO00000168";

        public const string D45_1 = "N002-ODO00000169";
        public const string D45_2 = "N002-ODO00000170";
        public const string D45_3 = "N002-ODO00000171";
        public const string D45_4 = "N002-ODO00000172";
        public const string D45_5 = "N002-ODO00000173";
        public const string D45_6 = "N002-ODO00000174";

        public const string D46_1 = "N002-ODO00000175";
        public const string D46_2 = "N002-ODO00000176";
        public const string D46_3 = "N002-ODO00000177";
        public const string D46_4 = "N002-ODO00000178";
        public const string D46_5 = "N002-ODO00000179";
        public const string D46_6 = "N002-ODO00000180";

        public const string D47_1 = "N002-ODO00000181";
        public const string D47_2 = "N002-ODO00000182";
        public const string D47_3 = "N002-ODO00000183";
        public const string D47_4 = "N002-ODO00000184";
        public const string D47_5 = "N002-ODO00000185";
        public const string D47_6 = "N002-ODO00000186";

        public const string D48_1 = "N002-ODO00000187";
        public const string D48_2 = "N002-ODO00000188";
        public const string D48_3 = "N002-ODO00000189";
        public const string D48_4 = "N002-ODO00000190";
        public const string D48_5 = "N002-ODO00000191";
        public const string D48_6 = "N002-ODO00000192";


        public const string PiezaCaries = "N002-ODO00000193";
        public const string PiezaAusentes = "N002-ODO00000194";
        public const string Otros = "N002-ODO00000195";
        public const string chkBacteriana = "N002-ODO00000196";
        public const string chkRadiculares = "N002-ODO00000197";
        public const string Aptitud = "N002-ODO00000198";


        #endregion

        public const string CONSULTAMEDICA = "N009-PR000000044";

        #region Ginecología

        public const string GINECOLOGIA_ID = "N009-ME000000029";
        public const string GINECOLOGIA_HALLAZGOS_ID = "N009-MF000000492";

        public const string GINECOLOGIA_SINTOMAS_LEUCORREA = "N009-MF000000441";
        public const string GINECOLOGIA_SINTOMAS_DISPAREUNIA = "N009-MF000000485";
        public const string GINECOLOGIA_SINTOMAS_INCONTINENCIA_URINARIA = "N009-MF000000486";
        public const string GINECOLOGIA_SINTOMAS_OTROS = "N009-MF000000487";

        // Descripciones ****************************************************
        public const string GINECOLOGIA_SINTOMAS_LEUCORREA_COMENTARIO = "N009-MF000001125";
        public const string GINECOLOGIA_SINTOMAS_DISPAREUNIA_COMENTARIO = "N009-MF000001126";
        public const string GINECOLOGIA_SINTOMAS_INCONTINENCIA_URINARIA_COMENTARIO = "N009-MF000001127";
        public const string GINECOLOGIA_SINTOMAS_OTROS_COMENTARIO = "N009-MF000001128";

        //**********************************************************************

        public const string ISTAS_21_ABREVIADA = "N009-ME000000059";
        public const string GINECOLOGIA_HALLAZGOS_HALLAZGOS = "N009-MF000000492";
        public const string GINECOLOGIA_EX_MAMA_HALLAZGOS_HALLAZGOS = "N009-MF000000511";

        public const string ANTECEDENTES_PERSONALES_FECHA_ULTIMA_MAMOGRAFIA = "N009-MF000001156";
        public const string GINECOLOGIA_ANTECEDENTES_FAMILIARES = "N009-MF000001159";
        public const string GINECOLOGIA_ANTECEDENTES_PERSONALES_FECHA_ULTIMO_PAP = "N009-MF000001155";

        public const string GINECOLOGIA_ANTECEDENTES_PERSONALES_ANTECEDENTES = "N009-MF000001143";

        public const string EVALUACION_GINECOLOGICA_ANTECEDENTES_FECHA_ULTIMO_PAP = "N009-MF000001160";
        public const string EVALUACION_GINECOLOGICA_ANTECEDENTES_FECHA_ULTIMA_MAMOGRAFIA = "N009-MF000001161";
        //RESULTADOS_DE_MAMOGRAFIA_HALLAZGOS = N009-MF000001139;

        #endregion

        #region Resultados de Mamografia

        public const string RESULTADOS_MAMOGRAFIA_ID = "N009-ME000000056";

        #endregion

        #region CAMPOS UC AUDIOMETRIA

        // Audiometría

        public const string UserControlAudimetria = "N002-MF000000175";

        //Vía Aérea OD
        public const string txt_VA_OD_125 = "N002-AUD00000043";
        public const string txt_VA_OD_250 = "N002-AUD00000044";
        public const string txt_VA_OD_500 = "N002-AUD00000001";
        public const string txt_VA_OD_1000 = "N002-AUD00000002";
        public const string txt_VA_OD_2000 = "N002-AUD00000003";
        public const string txt_VA_OD_3000 = "N002-AUD00000004";
        public const string txt_VA_OD_4000 = "N002-AUD00000005";
        public const string txt_VA_OD_6000 = "N002-AUD00000006";
        public const string txt_VA_OD_8000 = "N002-AUD00000007";

        //Vía Ósea OD
        public const string txt_VO_OD_125 = "N002-AUD00000045";
        public const string txt_VO_OD_250 = "N002-AUD00000046";
        public const string txt_VO_OD_500 = "N002-AUD00000008";
        public const string txt_VO_OD_1000 = "N002-AUD00000009";
        public const string txt_VO_OD_2000 = "N002-AUD00000010";
        public const string txt_VO_OD_3000 = "N002-AUD00000011";
        public const string txt_VO_OD_4000 = "N002-AUD00000012";
        public const string txt_VO_OD_6000 = "N002-AUD00000013";
        public const string txt_VO_OD_8000 = "N002-AUD00000014";

        //Vía Aérea OI
        public const string txt_VA_OI_125 = "N002-AUD00000047";
        public const string txt_VA_OI_250 = "N002-AUD00000048";
        public const string txt_VA_OI_500 = "N002-AUD00000015";
        public const string txt_VA_OI_1000 = "N002-AUD00000016";
        public const string txt_VA_OI_2000 = "N002-AUD00000017";
        public const string txt_VA_OI_3000 = "N002-AUD00000018";
        public const string txt_VA_OI_4000 = "N002-AUD00000019";
        public const string txt_VA_OI_6000 = "N002-AUD00000020";
        public const string txt_VA_OI_8000 = "N002-AUD00000021";

        //Vía Ósea OI
        public const string txt_VO_OI_125 = "N002-AUD00000049";
        public const string txt_VO_OI_250 = "N002-AUD00000050";
        public const string txt_VO_OI_500 = "N002-AUD00000022";
        public const string txt_VO_OI_1000 = "N002-AUD00000023";
        public const string txt_VO_OI_2000 = "N002-AUD00000024";
        public const string txt_VO_OI_3000 = "N002-AUD00000025";
        public const string txt_VO_OI_4000 = "N002-AUD00000026";
        public const string txt_VO_OI_6000 = "N002-AUD00000027";
        public const string txt_VO_OI_8000 = "N002-AUD00000028";


        // ENMASCARAMIENTO OD
        public const string txt_EM_OD_125 = "N002-AUD00000051";
        public const string txt_EM_OD_250 = "N002-AUD00000052";
        public const string txt_EM_OD_500 = "N002-AUD00000029";
        public const string txt_EM_OD_1000 = "N002-AUD00000030";
        public const string txt_EM_OD_2000 = "N002-AUD00000059";
        public const string txt_EM_OD_3000 = "N002-AUD00000060";
        public const string txt_EM_OD_4000 = "N002-AUD00000055";
        public const string txt_EM_OD_6000 = "N002-AUD00000056";
        public const string txt_EM_OD_8000 = "N002-AUD00000057";

        // ENMASCARAMIENTO OI
        public const string txt_EM_OI_125 = "N002-AUD00000053";
        public const string txt_EM_OI_250 = "N002-AUD00000054";
        public const string txt_EM_OI_500 = "N002-AUD00000058";
        public const string txt_EM_OI_1000 = "N002-AUD00000037";
        public const string txt_EM_OI_2000 = "N002-AUD00000038";
        public const string txt_EM_OI_3000 = "N002-AUD00000039";
        public const string txt_EM_OI_4000 = "N002-AUD00000040";
        public const string txt_EM_OI_6000 = "N002-AUD00000041";
        public const string txt_EM_OI_8000 = "N002-AUD00000042";

        // ANACUSIA OD
        public const string txt_AN_OD_125 = "N002-AUD00000061";
        public const string txt_AN_OD_250 = "N002-AUD00000062";
        public const string txt_AN_OD_500 = "N002-AUD00000063";
        public const string txt_AN_OD_1000 = "N002-AUD00000064";
        public const string txt_AN_OD_2000 = "N002-AUD00000065";
        public const string txt_AN_OD_3000 = "N002-AUD00000066";
        public const string txt_AN_OD_4000 = "N002-AUD00000067";
        public const string txt_AN_OD_6000 = "N002-AUD00000068";
        public const string txt_AN_OD_8000 = "N002-AUD00000069";

        public const string txt_AN_OI_125 = "N002-AUD00000070";
        public const string txt_AN_OI_250 = "N002-AUD00000071";
        public const string txt_AN_OI_500 = "N002-AUD00000072";
        public const string txt_AN_OI_1000 = "N002-AUD00000073";
        public const string txt_AN_OI_2000 = "N002-AUD00000074";
        public const string txt_AN_OI_3000 = "N002-AUD00000075";
        public const string txt_AN_OI_4000 = "N002-AUD00000076";
        public const string txt_AN_OI_6000 = "N002-AUD00000077";
        public const string txt_AN_OI_8000 = "N002-AUD00000078";


        // Dx automatico
        public const string txt_AUD_DX_OCUPACIONAL_AUTO_OD = "N009-MF000001311";
        public const string txt_AUD_DX_OCUPACIONAL_AUTO_OI = "N009-MF000001312";

        public const string txt_AUD_DX_CLINICO_AUTO_OD = "N002-AUD00000031";
        public const string txt_AUD_DX_CLINICO_AUTO_OI = "N002-AUD00000032";


        //
        public const string txt_MULTIMEDIA_FILE_OD = "N002-AUD00000033";
        public const string txt_MULTIMEDIA_FILE_OI = "N002-AUD00000034";

        public const string txt_SERVICE_COMPONENT_MULTIMEDIA_OD = "N002-AUD00000035";
        public const string txt_SERVICE_COMPONENT_MULTIMEDIA_OI = "N002-AUD00000036";

        // Campos dinamicos (Manager componentes)      
        // Requisitos para la audiometria
        public const string AUDIOMETRIA_REQUISITOS_CAMBIOS_ALTITUD = "N009-MF000001299";
        public const string AUDIOMETRIA_REQUISITOS_EXPUESTO_RUIDO = "N009-MF000001300";
        public const string AUDIOMETRIA_REQUISITOS_PROCESO_INFECCIOSO = "N009-MF000001301";
        public const string AUDIOMETRIA_REQUISITOS_DURMIO_NOCHE_PREVIA = "N009-MF000001302";
        public const string AUDIOMETRIA_REQUISITOS_CONSUMIO_ALCOHOL_DIA_PREVIO = "N009-MF000001303";
        public const string AUDIOMETRIA_REQUISITOS_TIEMPO_DE_TRABAJO = "N009-MF000001378";

        // Antecedentes Medicos de importancia
        public const string AUDIOMETRIA_ANTECEDENTES_RINITIS_SINUSITIS = "N009-MF000000089";
        public const string AUDIOMETRIA_ANTECEDENTES_USO_MEDICAMENTOS = "N009-MF000000090";
        public const string AUDIOMETRIA_ANTECEDENTES_SARAMPION = "N009-MF000000098";
        public const string AUDIOMETRIA_ANTECEDENTES_TEC = "N009-MF000001305";
        public const string AUDIOMETRIA_ANTECEDENTES_OTITIS_MEDIA_CRONICA = "N009-MF000000091";
        public const string AUDIOMETRIA_ANTECEDENTES_DIABETES_MELLITUS = "N009-MF000000095";
        public const string AUDIOMETRIA_ANTECEDENTES_SORDERA = "N009-MF000000101";
        public const string AUDIOMETRIA_ANTECEDENTES_SORDERA_FAMILIAR = "N009-MF000001306";
        public const string AUDIOMETRIA_ANTECEDENTES_MENINGITIS = "N009-MF000000097";
        public const string AUDIOMETRIA_ANTECEDENTES_DISLIPIDEMIA = "N009-MF000000100";
        public const string AUDIOMETRIA_ANTECEDENTES_ENF_TIROIDEA = "N009-MF000001304";
        public const string AUDIOMETRIA_ANTECEDENTES_SUST_QUIMICAS = "N009-MF000001307";

        // Hobbies
        public const string AUDIOMETRIA_HOBBIES_USO_MP3 = "N009-MF000001308";
        public const string AUDIOMETRIA_HOBBIES_PRACTICA_TIRO = "N009-MF000001309";
        public const string AUDIOMETRIA_HOBBIES_OTROS = "N009-MF000001310";

        // Sintomas actuales
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_SORDERA = "N009-MF000000092";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_OTALGIA = "N009-MF000000096";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_ACUFENOS = "N009-MF000000093";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_SECRECION_OTICA = "N009-MF000000099";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_VERTIGOS = "N009-MF000000094";

        // Otoscopia
        public const string AUDIOMETRIA_OTOSCOPIA_OIDO_IZQUIERDO = "N002-MF000000178";
        public const string AUDIOMETRIA_OTOSCOPIA_OIDO_DERECHO = "N002-MF000000179";


        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_MARCA = "N009-MF000000082";
        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_MODELO = "N009-MF000000083";
        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_CALIBRACION = "N009-MF000000084";



        #endregion


        #region CIE10
        public const string ALERGIA_DERIVADOS_LACTEOS = "N009-DD000001728";
        public const string ALERGIA_FRUTOS_SECOS = "N009-DD000001729";
        public const string ALERGIA_PELO_ANIMAL = "N009-DD000001730";

        public const string ALERGIA_NO_ESPECIFICADA = "N009-DD000000633";
        public const string DIABETES_MELLITUS = "N009-DD000000642";
        public const string TUBERCULOSIS = "N009-DD000000540";
        public const string HEPATITISB = "N009-DD000000420";
        public const string ASMA = "N009-DD000000599";
        public const string HTA = "N009-DD000000436";
        public const string ITS = "N009-DD000000650";
        public const string TIFOIDEA = "N009-DD000000636";
        public const string BRONQUITIS = "N009-DD000000641";

        public const string NEOPLASIAS = "N009-DD000000638";
        public const string CONVULSIONES = "N009-DD000000639";

        public const string QUEMADURAS = "N009-DD000000145";
        public const string CIRUGIAS = "N009-DD000000637";
        public const string INTOXICACIONES = "N009-DD000000640";

        // Dx que expresan normalidad
        public const string NORMOACUSIA_OIDO_IZQUIERDO = "N009-DD000000305";
        public const string NORMOACUSIA_OIDO_DERECHO = "N009-DD000000304";
        public const string EMETROPE = "N009-DD000000181";
        public const string NORMOPESO = "N002-DD000000146";
        public const string NORMOACUSIA = "N002-DD000000145";
        public const string EXAMEN_DE_SALUD_SIN_ALTERACION = "N009-DD000000190";

        public const string NORMOACUSIA_UC_AUDIOMETRIA_OIDO_IZQUIERDO = "N009-DD000000422";
        public const string NORMOACUSIA_UC_AUDIOMETRIA_OIDO_DERECHO = "N009-DD000000423";

        public const string DISEASES_RECOMENDACIONES = "N009-DD000000029";
        #region Audiometria



        #region OÍDO DERECHO

        public const string TRAUMA_ACUSTICO_LEVE_OD = "N009-DD000000370";
        public const string TRAUMA_ACUSTICO_AVANZADO_OD = "N009-DD000000371";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_LEVE_OD = "N009-DD000000372";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_MODERADA_OD = "N009-DD000000373";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_AVANZADA_OD = "N009-DD000000374";

        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_CONDUCTIVA_OD = "N009-DD000000375";
        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_NEUROSENSORIAL_OD = "N009-DD000000376";
        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_MIXTA_OD = "N009-DD000000377";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_CONDUCTIVA_OD = "N009-DD000000378";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_NEUROSENSORIAL_OD = "N009-DD000000379";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_MIXTA_OD = "N009-DD000000380";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_CONDUCTIVA_OD = "N009-DD000000381";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_NEUROSENSORIAL_OD = "N009-DD000000382";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_MIXTA_OD = "N009-DD000000383";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_CONDUCTIVA_OD = "N009-DD000000384";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_NEUROSENSORIAL_OD = "N009-DD000000385";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_MIXTA_OD = "N009-DD000000386";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_CONDUCTIVA_OD = "N009-DD000000387";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_NEUROSENSORIAL_OD = "N009-DD000000388";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_MIXTA_OD = "N009-DD000000389";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_CONDUCTIVA_OD = "N009-DD000000390";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_NEUROSENSORIAL_OD = "N009-DD000000391";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_MIXTA_OD = "N009-DD000000392";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_CONDUCTIVA_OD = "N009-DD000000393";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_NEUROSENSORIAL_OD = "N009-DD000000394";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_MIXTA_OD = "N009-DD000000395";


        #endregion

        #region OÍDO IZQUIERDO

        public const string TRAUMA_ACUSTICO_LEVE_OI = "N009-DD000000416";
        public const string TRAUMA_ACUSTICO_AVANZADO_OI = "N009-DD000000417";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_LEVE_OI = "N009-DD000000418";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_MODERADA_OI = "N009-DD000000419";
        public const string HIPOACUSIA_INDUCIDA_POR_RUIDO_AVANZADA_OI = "N009-DD000000420";

        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_CONDUCTIVA_OI = "N009-DD000000396";
        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_NEUROSENSORIAL_OI = "N009-DD000000397";
        public const string OTRAS_ALTERACIONES_NDR_AUDICIÓN_INFRANORMAL_MIXTA_OI = "N009-DD000000398";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_CONDUCTIVA_OI = "N009-DD000000399";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_NEUROSENSORIAL_OI = "N009-DD000000400";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_LIGERA_MIXTA_OI = "N009-DD000000401";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_CONDUCTIVA_OI = "N009-DD000000402";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_NEUROSENSORIAL_OI = "N009-DD000000403";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_1ER_GRADO_MIXTA_OI = "N009-DD000000404";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_CONDUCTIVA_OI = "N009-DD000000405";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_NEUROSENSORIAL_OI = "N009-DD000000406";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_MEDIANA_2DO_GRADO_MIXTA_OI = "N009-DD000000407";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_CONDUCTIVA_OI = "N009-DD000000408";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_NEUROSENSORIAL_OI = "N009-DD000000409";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_1ER_GRADO_MIXTA_OI = "N009-DD000000410";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_CONDUCTIVA_OI = "N009-DD000000411";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_NEUROSENSORIAL_OI = "N009-DD000000421";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_SEVERA_2DO_GRADO_MIXTA_OI = "N009-DD000000412";

        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_CONDUCTIVA_OI = "N009-DD000000413";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_NEUROSENSORIAL_OI = "N009-DD000000414";
        public const string OTRAS_ALTERACIONES_NDR_DEFICIENCIA_AUDITIVA_PROFUNDA_MIXTA_OI = "N009-DD000000415";


        #endregion

        #endregion

        #endregion

        #region OIT

        public const string OIT_ID = "N009-ME000000062";
        public const string RX_CONCLUSIONES_OIT_ID = "N009-MF000000596";
        public const string RX_NEUMOCONIOSIS_CHECK = "N009-MF000002142";
        public const string RX_CONCLUSIONES_OIT_DESCRIPCION_ID = "N009-MF000000597";

        public const string LOCALIZACION_PERFIL = "N009-MF000002120";
        public const string LOCALIZACION_FRENTE = "N009-MF000002121";
        public const string CLACIFICACION_PERFIL = "N009-MF000002122";
        public const string CLACIFICACION_FRENTE = "N009-MF000002123";
        public const string EXTENSION_DER_ENGROSAMIENTO = "N009-MF000002124";
        public const string EXTENSION_IZQ_ENGROSAMIENTO = "N009-MF000002125";
        public const string ANCHURA_DER_ENGROSAMIENTO = "N009-MF000002126";
        public const string ANCHURA_IZQ_ENGROSAMIENTO = "N009-MF000002127";




        public const string DE_PERFIL = "N009-MF000002102";
        public const string DE_FRENTE = "N009-MF000002103";
        public const string DIAFRAGMA = "N009-MF000002104";
        public const string OTROS_SITIOS = "N009-MF000002105";
        public const string DE_PERFIL_CLASF = "N009-MF000002110";
        public const string DE_FRENTE_CLASF = "N009-MF000002111";
        public const string DIAFRAGMA_CLASF = "N009-MF000002112";
        public const string OTROS_SITIOS_CLASF = "N009-MF000002113";
        public const string EXTENSION_DER_PLACA = "N009-MF000002114";
        public const string EXTENSION_IZQ_PLACA = "N009-MF000002115";
        public const string ANCHURA_DER_PLACA = "N009-MF000002116";
        public const string ANCHURA_IZQ_PLACA = "N009-MF000002117";
        public const string OBLITANG_DER_PLACA = "N009-MF000002113";
        public const string OBLITANG_IZQ_PLACA = "N009-MF000002119";


        public const string CAMPOS_PULMONARES = "N009-MF000002497";
        public const string HILOS = "N009-MF000002499";
        public const string MEDIASTINOS = "N009-MF000002498";
        public const string SENOS = "N009-MF000002496";
        public const string SILUETA_CARDIOVASCULAR = "N009-MF000002500";
        public const string VERTICES = "N009-MF000002501";
        #endregion

        #region Ostio Coimalache

        public const string ESCOLIOSIS = "N009-MF000003136";
        public const string CIFOSIS = "N009-MF000003137";
        public const string LORDOSIS = "N009-MF000003138";
        public const string ESCOLIOSIS_COMEN = "N009-MF000003139";
        public const string CIFOSIS_COMEN = "N009-MF000003140";
        public const string LORDOSIS_COMEN = "N009-MF000003141";
        public const string FLEXIONADELANTE = "N009-MF000003142";
        public const string HIPEREXTESION = "N009-MF000003144";
        public const string FLEXIONIZQUIERDO = "N009-MF000003146";
        public const string FLEXIONDERECHO = "N009-MF000003148";
        public const string ROTACIONIZQUIERDO = "N009-MF000003150";
        public const string ROTACIONDERECHO = "N009-MF000003152";
        public const string FUERZALEVANTASE = "N009-MF000003154";
        public const string FLEXIONADELANTE_COMEN = "N009-MF000003143";
        public const string HIPEREXTESION_COMEN = "N009-MF000003145";
        public const string FLEXIONIZQUIERDO_COMEN = "N009-MF000003147";
        public const string FLEXIONDERECHO_COMEN = "N009-MF000003149";
        public const string ROTACIONIZQUIERDO_COMEN = "N009-MF000003151";
        public const string ROTACIONDERECHO_COMEN = "N009-MF000003153";
        public const string FUERZALEVANTASE_COMEN = "N009-MF000003155";
        public const string CORRIENDO = "N009-MF000003156";
        public const string CAMINANDO = "N009-MF000003158";
        public const string PONERSECUCLILLA = "N009-MF000003160";
        public const string CORRIENDO_COMEN = "N009-MF000003157";
        public const string CAMINANDO_COMEN = "N009-MF000003159";
        public const string PONERSECUCLILLA_COMEN = "N009-MF000003161";
        public const string CODOIZQUIERDO = "N009-MF000003162";
        public const string CODODERECHO = "N009-MF000003163";
        public const string RODILLAIZQUIERDO = "N009-MF000003164";
        public const string RODILLADERECHO = "N009-MF000003165";
        public const string ABDOMEN_ID = "N009-MF000003166";
        public const string CADERA_ID = "N009-MF000003168";
        public const string MUSLO_ID = "N009-MF000003170";
        public const string LATERAL = "N009-MF000003172";
        public const string ABDOMEN_COMEN = "N009-MF000003167";
        public const string CADERA_COMEN = "N009-MF000003169";
        public const string MUSLO_COMEN = "N009-MF000003171";
        public const string LATERAL_COMEN = "N009-MF000003173";

        #endregion

        #region Vacunas

        public const string VACUNA_ANTIRRABICA = "N009-ME000000068";
        //**************************************************
        public const string VACUNA_DIFTERIA = "N009-ME000000065";
        public const string VACUNA_DIFTERIA_FECHA = "N009-MF000001170";
        public const string VACUNA_DIFTERIA_FECHA_2 = "N009-MF000001171";
        public const string VACUNA_DIFTERIA_FECHA_3 = "N009-MF000001172";

        //**************************************************
        public const string VACUNA_FIEBRE_AMARILLA = "N009-ME000000063";
        public const string VACUNA_FIEBRE_AMARILLA_FECHA = "N009-MF000001164";

        //**************************************************
        public const string VACUNA_HEPATITIS_A = "N009-ME000000066";
        public const string VACUNA_HEPATITIS_A_FECHA = "N009-MF000001182";
        public const string VACUNA_HEPATITIS_A_FECHA_2 = "N009-MF000001184";

        //**************************************************
        public const string VACUNAS_HEPATITIS_B = "N009-ME000000067";
        public const string VACUNAS_HEPATITIS_B_FECHA = "N009-MF000001188";
        public const string VACUNAS_HEPATITIS_B_FECHA_2 = "N009-MF000001189";
        public const string VACUNAS_HEPATITIS_B_FECHA_3 = "N009-MF000001190";
        //**************************************************
        public const string VACUNA_INFLUENZA = "N009-ME000000064";
        public const string VACUNA_INFLUENZA_FECHA = "N009-MF000001167";

        //**************************************************
        public const string VACUNA_TIFOIDEA = "N009-ME000000069";
        public const string VACUNA_TIFOIDEA_FECHA = "N009-MF000001206";
        //**************************************************
        public const string VACUNA_TRIPLE = "N009-ME000000070";
        public const string VACUNA_VARICELA = "N009-ME000000071";
        #endregion


        #region Evaluacion PsicoLaboral
        public const string EVALUACION_PSICOLABORAL = "N009-ME000000072";

        public const string _1 = "N009-MF000001243";
        public const string _2 = "N009-MF000001244";
        public const string _3 = "N009-MF000001245";
        public const string _4 = "N009-MF000001246";
        public const string _5 = "N009-MF000001247";
        public const string _6 = "N009-MF000001248";
        public const string _7 = "N009-MF000001249";
        public const string _8 = "N009-MF000001251";
        public const string _9 = "N009-MF000001252";
        public const string _10 = "N009-MF000001253";
        public const string _11 = "N009-MF000001254";
        public const string _12 = "N009-MF000001255";
        public const string _13 = "N009-MF000001256";
        public const string _14 = "N009-MF000001257";
        public const string _15 = "N009-MF000001259";
        public const string _16 = "N009-MF000001260";
        public const string _17 = "N009-MF000001261";
        public const string _18 = "N009-MF000001262";
        public const string _19 = "N009-MF000001263";
        public const string _20 = "N009-MF000001264";
        public const string _21 = "N009-MF000001265";
        public const string _22 = "N009-MF000001267";
        public const string _23 = "N009-MF000001268";
        public const string _24 = "N009-MF000001269";
        public const string _25 = "N009-MF000001270";
        public const string _26 = "N009-MF000001271";
        public const string _27 = "N009-MF000001272";
        public const string _28 = "N009-MF000001273";


        public const string EVALUACION_PSICOLABORAL_ESCALA_FATIGA_OBSERVACIONES = "N009-MF000001275";

        public const string EVALUACION_PSICOLABORAL_ESCALA_FATIGA_RECOMENDACIONES = "N009-MF000001276";

        public const string EVALUACION_PSICOLABORAL_ESCALA_SOMNOLENCIA = "N009-MF000001277";

        public const string EVALUACION_PSICOLABORAL_CONCLUSION_FINAL_CONCLUSION = "N009-MF000001279";

        public const string EVALUACION_PSICOLABORAL_CONCLUSION_FINAL_APTITUD = "N009-MF000001278";

        public const string EVALUACION_PSICOLABORAL_RIESGO_ESTRES = "N009-MF000001274";
        #endregion

        #region Osteo

        #endregion


        #region Categoría Actividad Crítica


        public const string RAC1_ID = "N009-ME000000100";
        public const string RAC1_RESULTADO_ID = "N009-MF000001815";

        public const string RAC2_ID = "N009-ME000000101";
        public const string RAC2_RESULTADO_ID = "N009-MF000001816";

        public const string RAC3_ID = "N009-ME000000102";
        public const string RAC3_RESULTADO_ID = "N009-MF000001817";

        public const string RAC4_ID = "N009-ME000000103";
        public const string RAC4_RESULTADO_ID = "N009-MF000001833";

        public const string RAC5_ID = "N009-ME000000104";
        public const string RAC5_RESULTADO_ID = "N009-MF000001818";

        public const string RAC6_ID = "N009-ME000000105";
        public const string RAC6_RESULTADO_ID = "N009-MF000001819";

        public const string RAC7_ID = "N009-ME000000106";
        public const string RAC7_RESULTADO_ID = "N009-MF000001820";

        public const string RAC8_ID = "N009-ME000000107";
        public const string RAC8_RESULTADO_ID = "N009-MF000001821";

        public const string RAC9_ID = "N009-ME000000108";
        public const string RAC9_RESULTADO_ID = "N009-MF000001822";

        public const string RAC10_ID = "N009-ME000000109";
        public const string RAC10_RESULTADO_ID = "N009-MF000001823";

        public const string RAC11_ID = "N009-ME000000110";
        public const string RAC11_RESULTADO_ID = "N009-MF000001824";

        public const string RAC12_ID = "N009-ME000000111";
        public const string RAC12_RESULTADO_ID = "N009-MF000001825";


        #endregion


        #region HISTORIA CLÍNICA PSICOLÓGICA


        public const string HISTORIA_CLINICA_PSICOLOGICA_ID = "N009-ME000000112";
        public const string HISTORIA_CLINICA_PSICOLOGICA_motivo_evaluacion_ID = "N009-MF000001835";

        public const string HISTORIA_CLINICA_PSICOLOGICA_superficie_ID = "N009-MF000001836";
        public const string HISTORIA_CLINICA_PSICOLOGICA_subsuelo_ID = "N009-MF000001837";
        public const string HISTORIA_CLINICA_PSICOLOGICA_tiempo_total_laborando_ID = "N009-MF000001838";
        public const string HISTORIA_CLINICA_PSICOLOGICA_principales_riesgos_ID = "N009-MF000001839";
        public const string HISTORIA_CLINICA_PSICOLOGICA_medidas_seguridad_ID = "N009-MF000001840";
        public const string HISTORIA_CLINICA_PSICOLOGICA_fecha_1ID = "N009-MF000001848";
        public const string HISTORIA_CLINICA_PSICOLOGICA_nombre_1_ID = "N009-MF000001849";
        public const string HISTORIA_CLINICA_PSICOLOGICA_actividad_1_ID = "N009-MF000001850";

        public const string HISTORIA_CLINICA_PSICOLOGICA_puesto_1_ID = "N009-MF000001851";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sup_1_ID = "N009-MF000001852";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sub_1ID = "N009-MF000001853";
        public const string HISTORIA_CLINICA_PSICOLOGICA_causa_1_ID = "N009-MF000001854";
        public const string HISTORIA_CLINICA_PSICOLOGICA_fecha_2_ID = "N009-MF000001855";
        public const string HISTORIA_CLINICA_PSICOLOGICA_nombre_2_ID = "N009-MF000001856";
        public const string HISTORIA_CLINICA_PSICOLOGICA_actividad_2_ID = "N009-MF000001857";
        public const string HISTORIA_CLINICA_PSICOLOGICA_puesto_2_ID = "N009-MF000001858";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sup_2_ID = "N009-MF000001859";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sub_2_ID = "N009-MF000001860";


        public const string HISTORIA_CLINICA_PSICOLOGICA_fecha_3_ID = "N009-MF000001862";
        public const string HISTORIA_CLINICA_PSICOLOGICA_nombre_3_ID = "N009-MF000001863";
        public const string HISTORIA_CLINICA_PSICOLOGICA_actividad_3_ID = "N009-MF000001864";
        public const string HISTORIA_CLINICA_PSICOLOGICA_puesto_3_ID = "N009-MF000001865";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sup_3_ID = "N009-MF000001866";
        public const string HISTORIA_CLINICA_PSICOLOGICA_sub_3_ID = "N009-MF000001867";
        public const string HISTORIA_CLINICA_PSICOLOGICA_causa_3_ID = "N009-MF000001868";
        public const string HISTORIA_CLINICA_PSICOLOGICA_historia_familiar_ID = "N009-MF000001869";
        public const string HISTORIA_CLINICA_PSICOLOGICA_accidentes_enf_ID = "N009-MF000001870";

        public const string HISTORIA_CLINICA_PSICOLOGICA_habitos_ID = "N009-MF000001871";
        public const string HISTORIA_CLINICA_PSICOLOGICA_obs_ID = "N009-MF000001872";
        #endregion

        #region PSICOLOGIA

        public const string PSICOLOGIA_ID = "N002-ME000000033";
        public const string PSICOLOGIA_AREA_COGNITIVA_ID = "N002-MF000000336";
        public const string PSICOLOGIA_AREA_EMOCIONAL_ID = "N002-MF000000337";
        public const string PSICOLOGIA_AREA_CONCLUSIONES_ID = "N002-MF000000338";
        public const string PSICOLOGIA_AREA_PERSONAL_ID = "N009-MF000001298";

        public const string PSICOLOGIA_APTITUD_PSICOLOGICA_ID = "N009-MF000000076";
        public const string PSICOLOGIA_RECOMENDACIONES_ESPECIFICAS_ID = "N009-MF000000081";
        public const string PSICOLOGIA_NIVEL_ACTUAL = "N009-MF000000630";
        public const string PSICOLOGIA_CoordinacionVisomotriz = "N009-MF000000631";
        public const string PSICOLOGIA_NivelMemoria = "N009-MF000000632";
        public const string PSICOLOGIA_PERSONALIDAD = "N009-MF000000633";
        public const string PSICOLOGIA_Afectividad = "N009-MF000000634";

        public const string EXAMEN_MENTAL_discurso_articulacion_ID = "N002-MF000000279";
        public const string EXAMEN_MENTAL_discuerso_ritmo_ID = "N002-MF000000280";
        public const string EXAMEN_MENTAL_discurso_tono_ID = "N002-MF000000281";
        public const string EXAMEN_MENTAL_orientacion_espacio_ID = "N009-MF000000078";
        public const string EXAMEN_MENTAL_orientacion_persona_ID = "N009-MF000000079";
        public const string EXAMEN_MENTAL_orientacion_tiempo_ID = "N009-MF000000077";
        public const string EXAMEN_MENTAL_postura_ID = "N002-MF000000282";
        public const string EXAMEN_MENTAL_presentacion_ID = "N002-MF000000283";
        public const string EXAMEN_MENTAL_lucido_atento_ID = "N002-MF000000326";
        public const string EXAMEN_MENTAL_afectividad_ID = "N002-MF000000333";

        public const string EXAMEN_MENTAL_apetito_ID = "N002-MF000000263";
        public const string EXAMEN_MENTAL_conducta_sexual_ID = "N002-MF000000335";
        public const string EXAMEN_MENTAL_inteligencia_ID = "N002-MF000000331";
        public const string EXAMEN_MENTAL_fobias_ID = "N009-MF000003265";
        public const string EXAMEN_MENTAL_RAVEN_ID = "N009-MF000003266";
        public const string EXAMEN_MENTAL_memoria_corto_plazo_ID = "N002-MF000000327";
        public const string EXAMEN_MENTAL_memoria_largo_plazo_ID = "N002-MF000000332";
        public const string EXAMEN_MENTAL_memoria_mediano_plazo_ID = "N002-MF000000330";
        public const string EXAMEN_MENTAL_pensamiento_ID = "N002-MF000000328";
        public const string EXAMEN_MENTAL_percepcion_ID = "N002-MF000000329";
        public const string EXAMEN_MENTAL_personalidad_ID = "N002-MF000000334";
        public const string EXAMEN_MENTAL_sueño_ID = "N002-MF000000269";

        public const string EXAMEN_MENTAL_batetia_conductores_ID = "N002-MF000000270";
        public const string EXAMEN_MENTAL_clima_laboral_ID = "N002-MF000000265";
        public const string EXAMEN_MENTAL_escala_apre_estres_ID = "N009-MF000000635";
        public const string EXAMEN_MENTAL_escala_memoria_vvechsler_ID = "N002-MF000000276";
        public const string EXAMEN_MENTAL_escala_motivacion_psicolo_ID = "N002-MF000000263";
        public const string EXAMEN_MENTAL_inventario_burnoutde_ID = "N002-MF000000264";
        public const string EXAMEN_MENTAL_inventario_ansiedad_ID = "N002-MF000000274";
        public const string EXAMEN_MENTAL_inventario_millon_estilos_pers_ID = "N002-MF000000266";
        public const string EXAMEN_MENTAL_inventario_depresion_zung_ID = "N002-MF000000275";
        public const string EXAMEN_MENTAL_luria_dna_ID = "N002-MF000000267";

        public const string EXAMEN_MENTAL_test_bender_ID = "N002-MF000000273";
        public const string EXAMEN_MENTAL_test_benton_ID = "N002-MF000000272";
        public const string EXAMEN_MENTAL_wais_ID = "N002-MF000000277";
        public const string EXAMEN_MENTAL_otros_ID = "N002-MF000000278";
        public const string EXAMEN_MENTAL_aptitud_psico_ID = "N009-MF000000076";
        public const string EXAMEN_MENTAL_area_psicolo_ID = "N002-MF000000336";
        public const string EXAMEN_MENTAL_area_emocianal_ID = "N002-MF000000337";
        public const string EXAMEN_MENTAL_area_personal_ID = "N009-MF000001298";
        public const string EXAMEN_MENTAL_conclusiones_ID = "N002-MF000000338";
        public const string EXAMEN_MENTAL_recomendaciones_ID = "N009-MF000000080";
        public const string EXAMEN_MENTAL_restriccion_ID = "N009-MF000000081";
        #endregion


        public const string ADJUNTOS_PSICOLOGIA = "N009-ME000000082";

        //
        #region Perfil Lipidico
        public const string PERFIL_LIPIDICO = "N009-ME000000114";

        public const string COLESTEROL_TOTAL = "N009-MF000001904";
        public const string COLESTEROL_TOTAL_DESEABLE = "N009-MF000001905";
        public const string TRIGLICERIDOS = "N009-MF000001906";
        public const string TRIGLICERIDOS_DESEABLE = "N009-MF000001907";
        public const string COLESTEROL_LDL = "N009-MF000001073";
        public const string COLESTEROL_LDL_DESEABLE = "N009-MF000001074";
        public const string COLESTEROL_HDL = "N009-MF000000254";
        public const string COLESTEROL_HDL_DESEABLE = "N009-MF000000414";
        public const string COLESTEROL_VLDL = "N009-MF000001075";
        public const string COLESTEROL_VLDL_DESEABLE = "N009-MF000001076";

        #endregion

        #region Perfil Hepático
        public const string PERFIL_HEPATICO_ID = "N009-ME000000096";

        public const string PERFIL_HEPATICO_PROTEINAS_TOTALES_ID = "N009-MF000001792";
        public const string PERFIL_HEPATICO_PROTEINA_TOTALES_DESEABLE_ID = "N009-MF000001793";

        public const string PERFIL_HEPATICO_ALBUMINA_ID = "N009-MF000001794";
        public const string PERFIL_HEPATICO_ALBUMINA_DESEABLE_ID = "N009-MF000001795";

        public const string PERFIL_HEPATICO_GLOBULINA_ID = "N009-MF000001796";
        public const string PERFIL_HEPATICO_GLOBULINA_DESEABLE_ID = "N009-MF000001797";

        public const string PERFIL_HEPATICO_TGO_ID = "N009-MF000001798";
        public const string PERFIL_HEPATICO_TGO_DESEABLE_ID = "N009-MF000001799";

        public const string PERFIL_HEPATICO_TGP_ID = "N009-MF000001800";
        public const string PERFIL_HEPATICO_TGP_DESEABLE_ID = "N009-MF000001801";

        public const string PERFIL_HEPATICO_FOSFATASA_ALCALINA_ID = "N009-MF000001802";
        public const string PERFIL_HEPATICO_FOSFATASA_ALCALINA_DESEABLE_ID = "N009-MF000001803";

        public const string PERFIL_HEPATICO_GAMMA_GLUTAMIL_TRANSPEPTIDASA_ID = "N009-MF000001804";
        public const string PERFIL_HEPATICO_GGTP_DESEABLE_ID = "N009-MF000001805";

        public const string PERFIL_HEPATICO_BILIRRUBINA_TOTAL_ID = "N009-MF000001806";
        public const string PERFIL_HEPATICO_BILIRRUBINA_TOTAL_DESEABLE_ID = "N009-MF000001807";

        public const string PERFIL_HEPATICO_BILIRRUBINA_DIRECTA_ID = "N009-MF000001808";
        public const string PERFIL_HEPATICO_BILIRRUBINA_DIRECTA_DESEABLE_ID = "N009-MF000001809";

        public const string PERFIL_HEPATICO_BILIRRUBINA_INDIRECTA_ID = "N009-MF000001810";
        public const string PERFIL_HEPATICO_BILIRRUBINA_INDIRECTA_DESEABLE_ID = "N009-MF000001811";
        #endregion 

        #region VSG
        public const string VSG_ID = "N009-ME000000137";
        public const string VSG_RESUL = "N009-MF000002162";
        public const string VSG_DESEABLE = "N009-MF000002163";
        #endregion

        #region HEMOGRAMA
        public const string HEMOGRAMA = "N009-ME000000113";

        public const string HEMOGLOBINA = "N009-MF000001874";
        public const string HEMOGLOBINA_DESEABLE = "N009-MF000001875";

        public const string HEMATOCRITO = "N009-MF000001876";
        public const string HEMATOCRITO_DESEABLE = "N009-MF000001877";

        public const string HEMATIES = "N009-MF000001878";
        public const string HEMATIES_DESEABLE = "N009-MF000001879";

        public const string VOL_CORP_MEDIO = "N009-MF000001880";
        public const string VOL_CORP_MEDIO_DESEABLE = "N009-MF000001881";

        public const string HB_CORP_MEDIO = "N009-MF000001882";
        public const string HB_CORP_MEDIO_DESEABLE = "N009-MF000001883";

        public const string CE_HB_MEDIO = "N009-MF000001884";
        public const string CE_HB_MEDIO_DESEABLE = "N009-MF000001885";

        public const string PLAQUETAS = "N009-MF000001886";
        public const string PLAQUETAS_DESEABLE = "N009-MF000001887";

        public const string JUVENILES = "N009-MF000003205";
        public const string JUVENILES_DESEABLE = "N009-MF000003206";

        public const string ABASTONADOS = "N009-MF000003207";
        public const string ABASTONADOS_DESEABLE = "N009-MF000003208";

        public const string VOL_PLAQUETARIO_MEDIO = "N009-MF000001888";
        public const string VOL_PLAQUETARIO_MEDIO_DESEABLE = "N009-MF000001889";

        public const string LEUCOCITOS_TOTALES = "N009-MF000001890";
        public const string LEUCOCITOS_TOTALES_DESEABLE = "N009-MF000001891";

        public const string LINFOCITOS = "N009-MF000001892";
        public const string LINFOCITOS_DESEABLE = "N009-MF000001893";

        public const string MID = "N009-MF000001894";
        public const string MID_DESEABLE = "N009-MF000001895";

        public const string NEUTROFILOS_SEG = "N009-MF000001896";
        public const string NEUTROFILOS_SEG_DESEABLE = "N009-MF000001897";

        public const string LINFOCITOS_10_9 = "N009-MF000001898";
        public const string LINFOCITOS_10_9_DESEABLE = "N009-MF000001899";

        public const string MID_10_9 = "N009-MF000001900";
        public const string MID_10_9_DESEABLE = "N009-MF000001901";

        public const string NEUTROFILOS_10_9 = "N009-MF000001902";
        public const string NEUTROFILOS_10_9_DESEABLE = "N009-MF000001903";

        public const string Hemograma_Otros = "N009-MF000004441";
        #endregion

        #region OSTEO_MUSCULAR

        public const string OSTEO_MUSCULAR_ID_1 = "N002-ME000000046";
        public const string OSTEO_MUSCULAR_ID_2 = "N009-ME000000084";


























        public const string OSTEO_MUSCULAR_ADUCCION_HOMBRO_NORMAL_LIMITADO_ID = "N009-MF000000168";



        public const string OSTEO_MUSCULAR_ADUCCION_HOMBRO_OPTIMO_ID = "N009-MF000000173";

        public const string OSTEO_MUSCULAR_ADUCCION_HOMBRO_MUY_LIMITADO_ID = "N009-MF000000831";




        public const string OSTEO_MUSCULAR_ROTACION_EXTERNA_MUY_LIMITADO_ID = "N009-MF000000837";

        public const string OSTEO_MUSCULAR_ROTACION_EXTERNA_DOLOR_ID = "N009-MF000000839";








        public const string OSTEO_MUSCULAR_2_APTITUD_ID = "N009-MF000001411";
        // GRUPBOX ANTECEDENTES MUSCULOESQUELÉTICOS
        public const string OSTEO_MUSCULAR_PRESENTA_ANTECEDENTES = "N009-MF000000520";
        public const string OSTEO_MUSCULAR_DESCRIPCION = "N009-MF000000521";
        //Analisis de Dolor
        public const string OSTEO_MUSCULAR_COLUMNA_CERVICAL = "N009-MF000000871";
        public const string OSTEO_MUSCULAR_COLUMNA_CERVICAL_DESCRIPCION = "N009-MF000000872";

        public const string OSTEO_MUSCULAR_COLUMNA_DORSAL = "N009-MF000000873";
        public const string OSTEO_MUSCULAR_COLUMNA_DORSAL_DESCRIPCION = "N009-MF000000874";

        public const string OSTEO_MUSCULAR_COLUMNA_DORSO_LUMBAR = "N009-MF000000879";
        public const string OSTEO_MUSCULAR_COLUMNA_DORSO_LUMBAR_DESCRIPCION = "N009-MF000000880";

        public const string OSTEO_MUSCULAR_COLUMNA_LUMBOSACRA = "N009-MF000000881";
        public const string OSTEO_MUSCULAR_COLUMNA_LUMBOSACRA_DESCRIPCION = "N009-MF000000882";

        public const string OSTEO_MUSCULAR_COSTO_CONDRALES = "N009-MF000000877";
        public const string OSTEO_MUSCULAR_COSTO_CONDRALES_DESCRIPCION = "N009-MF000000878";

        public const string OSTEO_MUSCULAR_COSTO_ESTERNALES = "N009-MF000000875";
        public const string OSTEO_MUSCULAR_COSTO_ESTERNALES_DESCRIPCION = "N009-MF000000876";
        //ARTICULACION

        public const string OSTEO_MUSCULAR_TEMPERO_MANDIBULAR = "N009-MF000000853";
        public const string OSTEO_MUSCULAR_TEMPERO_MANDIBULAR_DESCRIPCION = "N009-MF000000854";

        public const string OSTEO_MUSCULAR_HOMBRO = "N009-MF000000855";
        public const string OSTEO_MUSCULAR_HOMBRO_DESCRIPCION = "N009-MF000000856";

        public const string OSTEO_MUSCULAR_CODO = "N009-MF000000857";
        public const string OSTEO_MUSCULAR_CODO_DESCRIPCION = "N009-MF000000858";

        public const string OSTEO_MUSCULAR_MUNECA = "N009-MF000000859";
        public const string OSTEO_MUSCULAR_MUNECA_DESCRIPCION = "N009-MF000000860";

        public const string OSTEO_MUSCULAR_INTERFALANGICAS = "N009-MF000000861";
        public const string OSTEO_MUSCULAR_INTERFALANGICAS_DESCRIPCION = "N009-MF000000862";

        public const string OSTEO_MUSCULAR_COXOFEMORAL = "N009-MF000000863";
        public const string OSTEO_MUSCULAR_COXOFEMORAL_DESCRIPCION = "N009-MF000000864";

        public const string OSTEO_MUSCULAR_RODILLA = "N009-MF000000865";
        public const string OSTEO_MUSCULAR_RODILLA_DESCRIPCION = "N009-MF000000866";

        public const string OSTEO_MUSCULAR_TOBILLO_PIE = "N009-MF000000867";
        public const string OSTEO_MUSCULAR_TOBILLO_PIE_DESCRIPCION = "N009-MF000000868";






























        // GRUPBOX ANALISIS DE LABOR QUE REALIZA
        public const string OSTEO_MUSCULAR_MOVIMIENTOS_REPETITIVOS = "N002-MF000000372";
        public const string OSTEO_MUSCULAR_MOVIMIENTO_MANUAL_CARGA = "N002-MF000000373";
        public const string OSTEO_MUSCULAR_POSTURA_FORZADA = "N002-MF000000374";
        public const string OSTEO_MUSCULAR_USUARIO_PANTALLA_PVD = "N002-MF000000377";
        public const string OSTEO_MUSCULAR_HORAS_DIA = "N002-MF000000378";
        public const string OSTEO_MUSCULAR_POSTURA_SENTADO = "N009-MF000000041";
        public const string OSTEO_MUSCULAR_POSTURA_PIE = "N002-MF000000371";
        //B. Curvaturas Columna Vertebral Bipedestación




        public const string OSTEO_MUSCULAR_ESCOLIOSIS_LUMBAR = "N009-MF000000045";
        public const string OSTEO_MUSCULAR_ESCOLIOSIS_DORSAL = "N009-MF000000046";
        public const string OSTEO_MUSCULAR_OBSERVACIONES = "N009-MF000000047";



        //C. Extremidades Inferiores - Eje
        public const string OSTEO_MUSCULAR_RODILLA_DERECHA_VARO = "N009-MF000000556";
        public const string OSTEO_MUSCULAR_RODILLA_DERECHA_VALGO = "N009-MF000000557";
        public const string OSTEO_MUSCULAR_RODILLA_IZQUIERDA_VARO = "N009-MF000000559";
        public const string OSTEO_MUSCULAR_RODILLA_IZQUIERDA_VALGO = "N009-MF000000560";
        public const string OSTEO_MUSCULAR_PIE_DERECHO_CAVO = "N009-MF000000565";
        public const string OSTEO_MUSCULAR_PIE_DERECHO_PLANO = "N009-MF000000566";
        public const string OSTEO_MUSCULAR_PIE_IZQUIERDO_CAVO = "N009-MF000000568";
        public const string OSTEO_MUSCULAR_PIE_IZQUIERDO_PLANO = "N009-MF000000569";
        //C. Extremidades Inferiores - Relfejos




        //C. Extremidades Test y Signos








        //D. Aptitud de Espalda: Flexibilidad / Fuerza


        public const string OSTEO_MUSCULAR_PESO_CARGA = "N002-MF000000375";
        public const string OSTEO_MUSCULAR_METODO_CARGA = "N002-MF000000376";







        //public const string OSTEO_MUSCULAR_COLUMNA_LATERAL_CERVICAL = "N009-MF000001412";
        //public const string OSTEO_MUSCULAR_COLUMNA_LATERAL_DORSAL = "N009-MF000001413";
        //public const string OSTEO_MUSCULAR_COLUMNA_LATERAL_LUMBAR = "N009-MF000001414";


        #endregion

        #region NUEVO OSTEOMUSCULAR
        public const string LEVANTAMIENTO_ENCIMA_DEL_HOMBRO = "N009-MF000000048";
        public const string POSTURA_SEDENTARIA_DESCRIPCION = "N009-MF000000540";
        public const string MANIPULACION_JALAR_CARGAS = "N009-MF000001220";
        public const string MANIPULACION_LEVANTAR_CARGAS_DESCRIPCION = "N009-MF000001221";
        public const string MANIPULACION_EMPUJAR_CARGA_DESCRIPCION = "N009-MF000001222";
        public const string PESOS_SUPERIORES_A_25KGDESCRIPCION = "N009-MF000001223";
        public const string PMANIPULACIÓN_JALAR_CARGAS_DESCRIPCION = "N009-MF000001224";
        public const string PESOS_SUPERIORES_A_25KG = "N009-MF000001225";


        public const string MANIPULACION_LEVANTAR_CARGAS = "N009-MF000001226";
        public const string OSTEO_MUSCULAR_TAREAS_CARGA = "N009-MF000001227";
        public const string LEVANTAMIENTO_POR_ENCIMA_DELHOMBRODESCRIPCION = "N009-MF000001228";
        public const string MANIPULACION_DE_VALVULAS_ = "N009-MF000001229";

        public const string MANIPULACION_DE_VALVULAS_DESCRIPCION = "N009-MF000001230";
        public const string POSTURA_FORZADA__ = "N009-MF000001412";
        public const string POSTURA_FORZADA_DESCRIPCION_ = "N009-MF000001413";

        public const string POSTURA_SEDENTARIA__ = "N009-MF000001414";
        public const string MOVIMIENTOS_REPETITIVOS__ = "N009-MF000001415";
        public const string MOVIMIENTOS_REPETITIVOS_DESCRIPCION_ = "N009-MF000001416";
        public const string SINTOMAS = "N009-MF000000549";
        public const string CADERA_POBRE = "N009-MF000000808";
        public const string CADERA_PUNTOS = "N009-MF000000809";
        public const string CADRA_OBSERVACIONES = "N009-MF000000810";
        public const string MUSLO = "N009-MF000000811";
        public const string MUSLO_EXCELENTE = "N009-MF000000812";
        public const string _MUSLO_PROMEDIO = "N009-MF000000813";
        public const string MUSLO_REGULAR = "N009-MF000000814";
        public const string MUSLO_POBRE = "N009-MF000000815";
        public const string MUSLO_PUNTOS = "N009-MF000000816";
        public const string MUSLO_OBSERVACIONES = "N009-MF000000817";
        public const string ABDOMEN_LAT = "N009-MF000000818";
        public const string ABDOMEN_LAT_EXCELENTE = "N009-MF000000819";
        public const string ABDOMEN_LAT_PROMEDIO = "N009-MF000000820";
        public const string ABDOMEN_LAT_REGULAR = "N009-MF000000821";
        public const string ABDOMEN_LAT_POBRE = "N009-MF000000822";
        public const string ABDOMEN_LAT_PUNTOS = "N009-MF000000823";
        public const string ABDOMEN_LAT_OBSERVACIONES = "N009-MF000000824";
        public const string TOTAL = "N009-MF000000829";
        public const string ABDOMEN = "N009-MF000000145";
        public const string CADERA_EXCELENTE = "N009-MF000000146";
        public const string PUNTOS_ABDOMEN = "N009-MF000000147";
        public const string CADERA_PROMEDIO = "N009-MF000000152";
        public const string ABDOMEN_EXCELENTE = "N009-MF000000153";
        public const string ABDOMEN_PROMEDIO = "N009-MF000000154";
        public const string ABDOMEN_REGULAR = "N009-MF000000155";
        public const string ABDOMEN_POBRE = "N009-MF000000156";
        public const string CADERA_REGULAR = "N009-MF000000157";
        public const string ABDOMEN_OBSERVACIONES = "N009-MF000000158";
        public const string CADERA = "N009-MF000000159";
        public const string FLEXION = "N009-MF000000161";
        public const string HOMBRO_IZQFLEXION = "N009-MF000001908";
        public const string HOMBRO_IZQEXTENSION = "N009-MF000001909";
        public const string HOMBRO_IZQROTDER = "N009-MF000001910";
        public const string HOMBRO_IZQROTIZQ = "N009-MF000001911";
        public const string HOMBRO_IZQFUERZA = "N009-MF000001912";
        public const string HOMBRO_IZQDOLOR = "N009-MF000001913";
        public const string CODO_DCH = "N009-MF000001914";
        public const string CODO_DCHABDUCC = "N009-MF000001915";
        public const string CODO_DCHFELXION = "N009-MF000001916";
        public const string CODO_DCHEXTENSION = "N009-MF000001917";
        public const string CODO_DCHROTDER = "N009-MF000001918";
        public const string CODO_DCHROTIZQ = "N009-MF000001919";
        public const string CODO_DCHDOLOR = "N009-MF000001920";
        public const string CODO_DCHFUERZA = "N009-MF000001921";
        public const string CODO_IZQ = "N009-MF000001922";
        public const string CODO_IZQABDUCC = "N009-MF000001923";
        public const string CODO_IZQFLEXION = "N009-MF000001924";
        public const string CODO_IZQEXTENSION = "N009-MF000001925";

        public const string CODO_IZQROTEXT = "N009-MF000001926";
        public const string CODO_IZQROT_INT = "N009-MF000001927";
        public const string CODO_IZQFUERZA = "N009-MF000001928";
        public const string CODO_IZQDOLOR = "N009-MF000001929";
        public const string MUNIECA_DCH = "N009-MF000001930";
        public const string MUNIEECA_DCHABDUCC = "N009-MF000001931";
        public const string MUNIEECA_DCHFLEXION = "N009-MF000001932";
        public const string MUNIEECA_DCHEXTENSION = "N009-MF000001933";
        public const string MUNIEECA_DCHROTEXT = "N009-MF000001934";
        public const string MUNIEECA_DCHROTINT = "N009-MF000001935";

        public const string MUNIEECA_DCHFUERZA = "N009-MF000001936";
        public const string MUNIEECA_DCHDOLOR = "N009-MF000001937";
        public const string MUNIEECA_IZQ = "N009-MF000001938";
        public const string MUNIEECA_IZQABDUCC = "N009-MF000001939";
        public const string MUNIEECA_IZQFLEXION = "N009-MF000001940";
        public const string MUNIEECA_IZQEXTENSION = "N009-MF000001941";
        public const string MUNIEECA_IZQROTEXT = "N009-MF000001942";
        public const string MUNIEECA_IZQROTINT = "N009-MF000001943";
        public const string MUNIEECA_IZQFUERZA = "N009-MF000001944";
        public const string MUNIEECA_IZQDOLOR = "N009-MF000001945";

        public const string CADERA_DCH = "N009-MF000001946";
        public const string CADERA_DCHABDUCC = "N009-MF000001947";
        public const string CADERA_DCHFLEXION = "N009-MF000001948";
        public const string CADERA_DCHEXTENSION = "N009-MF000001949";
        public const string CADERA_DCHROTEXT = "N009-MF000001950";
        public const string CADERA_DCHROTINT = "N009-MF000001951";
        public const string CADERA_DCHFUERZA = "N009-MF000001952";
        public const string CADERA_DCHDOLOR = "N009-MF000001953";
        public const string CADERA_IZQ = "N009-MF000001954";
        public const string CADERA_IZQABDUC = "N009-MF000001955";

        public const string CADERA_IZQFLEXION = "N009-MF000001956";
        public const string CADERA_IZQROTEXT = "N009-MF000001957";
        public const string CADERA_IZQROTINT = "N009-MF000001958";
        public const string CADERA_IZQEXTENSION = "N009-MF000001959";
        public const string CADERA_IZQFUERZA = "N009-MF000001960";
        public const string CADERA_IZQDOLOR = "N009-MF000001961";
        public const string RODILLA_DCH = "N009-MF000001962";
        public const string RODILLA_DCHABDUCC = "N009-MF000001963";
        public const string RODILLA_DCHFLEXION = "N009-MF000001964";
        public const string RODILLA_DCHEXTENSION = "N009-MF000001965";

        public const string RODILLA_DCHROTEXT = "N009-MF000001966";
        public const string RODILLA_DCHROTINT = "N009-MF000001967";
        public const string RODILLA_DCHFUERZA = "N009-MF000001968";
        public const string RODILLA_DCHDOLOR = "N009-MF000001969";
        public const string RODILLA_IZQ = "N009-MF000001970";
        public const string RODILLA_IZQABDUCC = "N009-MF000001971";
        public const string RODILLA_IZQFLEXION = "N009-MF000001972";
        public const string RODILLA_IZQEXTENSION = "N009-MF000001973";
        public const string RODILLA_IZQROTEXT = "N009-MF000001974";
        public const string RODILLA_IZQINT = "N009-MF000001975";

        public const string RODILLA_IZQFUERZA = "N009-MF000001976";
        public const string RODILLA_IZQDOLOR = "N009-MF000001977";
        public const string TOBILLO_DCH = "N009-MF000001978";
        public const string TOBILLO_DCHABDUCC = "N009-MF000001979";
        public const string TOBILLO_DCHFLEXION = "N009-MF000001980";
        public const string TOBILLO_DCHEXTENSION = "N009-MF000001981";
        public const string TOBILLO_DCHROTEXT = "N009-MF000001982";
        public const string TOBILLO_DCHROTINT = "N009-MF000001983";
        public const string TOBILLO_DCHFUERZA = "N009-MF000001984";
        public const string TOBILLO_DCHDOLOR = "N009-MF000001985";

        public const string TOBILLO_IZQ = "N009-MF000001986";
        public const string TOBILLO_IZQABDUCC = "N009-MF000001987";
        public const string TOBILLO_IZQFLEXION = "N009-MF000001988";
        public const string TOBILLO_IZQROTEXT = "N009-MF000001989";
        public const string TOBILLO_IZQEXTENSION = "N009-MF000001990";
        public const string TOBILLO_IZQROTINT = "N009-MF000001991";
        public const string TOBILLO_IZQFUERZA = "N009-MF000001992";
        public const string TOBILLO_IZQDOLOR = "N009-MF000001993";

        public const string HOMBRO_IZQABDUCC = "N009-MF000000850";
        public const string HOMBRO_DCHABDUCC = "N009-MF000000835";
        public const string HOMBRO_DCH = "N009-MF000000836";
        public const string HOMBRO_DCHFLEXION = "N009-MF000000838";
        public const string HOMBRO_DCHROTEXT = "N009-MF000000840";
        public const string HOMBRO_DCHDOLOR = "N009-MF000000841";
        public const string HOMBRO_DCHFUERZATONO = "N009-MF000000842";
        public const string HOMBRO_DCHEXTENSION = "N009-MF000000843";
        public const string HOMBRO_IZQ = "N009-MF000000844";
        public const string HOMBRO_DCHROTINT = "N009-MF000000845";
        public const string OBSERVACION = "N009-MF000001994";
        public const string TINEL_DERECHO = "N009-MF000000062";
        public const string TINEL_IZQUIERDO = "N009-MF000000063";
        public const string LASEGUE_DERECHO = "N009-MF000000064";
        public const string LASEGUE_IZQUIERDO = "N009-MF000000065";
        public const string FINKELSTEIN_DERECHO = "N009-MF000000066";
        public const string ADAM_DERECHO = "N009-MF000000144";
        public const string FINKELSTEIN_IZQUIERDO = "N009-MF000000051";
        public const string ADAM_IZQUIERDO = "N009-MF000000536";
        public const string PHALEN_DERECHO = "N009-MF000000059";
        public const string PHALEN_IZQUIERDO = "N009-MF000000060";
        public const string PIE_CAVO_DERECHO = "N009-MF000000546";
        public const string PIE_CAVO_IZQUIERDO = "N009-MF000000547";
        public const string PIE_PLANO_DERECHO = "N009-MF000000548";
        public const string PIE_PLANO_IZQUIERDO = "N009-MF000000544";
        public const string CERVICAL_AP = "N009-MF000001995";
        public const string DORSAL_AP = "N009-MF000000551";
        public const string LUMBAR_AP = "N009-MF000000541";
        public const string DORSAL_LATERAL = "N009-MF000000542";
        public const string LUMBAR_LATERAL = "N009-MF000000543";
        public const string CERVICAL_LATERALIZACION_DERECHA = "N009-MF000000537";
        public const string CERVICAL_LATERALIZACION_IZQUIERDA = "N009-MF000000538";
        public const string DORSAL_LUMBAR_LATERAL_IZQUIERDA = "N009-MF000000061";
        public const string DORSAL_LUMBAR_ROACION_DERECHA = "N009-MF000000172";
        public const string CERVICAL_EXTENXION__ = "N009-MF000000052";
        public const string DORSAL_LUMBAR = "N009-MF000000053";
        public const string DORSAL_LUMBAR_EXTENSION = "N009-MF000000054";
        public const string CERVICAL_ROTACION_DERECHA = "N009-MF000000055";
        public const string CERVICAL_ROTACION_IZQUIERDA = "N009-MF000000056";
        public const string CERVICAL_IRRADIACION = "N009-MF000000057";
        public const string DORSAL_LUMBAR_LATERAL_DERECHA = "N009-MF000000058";
        public const string CERVICAL_FLEXION = "N009-MF000000545";
        public const string DORSAL_LUMBAR_IRRADIACION = "N009-MF000000174";
        public const string DORSAL_LUMBAR_ROACION_IZQUIERDA = "N009-MF000000833";
        public const string COLUMNA_CERVICAL_CONTRACTURA = "N009-MF000000166";
        public const string COLUMNA_LUMBAR = "N009-MF000000167";
        public const string COLUMNA_DORSAL_CONTRACTURA = "N009-MF000000169";
        public const string COLUMNA_LUMBAR_CONTACTURA = "N009-MF000000170";
        public const string COLUMNA_DORSAL = "N009-MF000000171";
        public const string COLUMNA_CERVICAL = "N009-MF000000832";
        public const string DESCRIPCION = "N009-MF000000232";
        public const string APTITUDESPALDA = "N009-MF000003174";
        public const string APTITUD = "N009-MF000000621";
        #endregion


        #region SINTOMATICO_RESPIRATORIO
        public const string SINTOMATICO_RESPIRATORIO = "N009-ME000000116";

        public const string TUBERCULOSIS1 = "N009-MF000002015";
        public const string TOS_POR_MAS_15_DIAS = "N009-MF000002016";
        public const string BAJO_PESO = "N009-MF000002017";
        public const string SUDORACION_NOCTURNA = "N009-MF000002018";
        public const string EXPECTORACION_CON_SANGRE = "N009-MF000002019";
        public const string FAMILIARES_AMIGOS = "N009-MF000002020";
        public const string SOSPECHA_TUBERCULOSIS = "N009-MF000002021";
        public const string OBSERVACIONES = "N009-MF000002022";
        public const string ES_SINTOMATICO_RESPIRATORIO = "N009-MF000002023";
        public const string RESULTADOS_BK_1 = "N009-MF000002024";
        public const string RESULTADOS_BK_2 = "N009-MF000002025";
        public const string RADIOGRAFIA_TORAX = "N009-MF000002026";

        #endregion



        #region FICHA_OTOSCOPIA
        public const string FICHA_OTOSCOPIA = "N009-ME000000115";

        public const string ANTECEDENTES_OTOLOGICOS = "N009-MF000002003";
        public const string ZUMBIDOS = "N009-MF000002004";
        public const string SECRECION_DEL_OIDO = "N009-MF000002005";
        public const string MAREOS = "N009-MF000002006";
        public const string OTALGIA = "N009-MF000002007";
        public const string DISMIUCION_DE_AUDICION = "N009-MF000002008";
        public const string OTROS = "N009-MF000002009";
        public const string ENF_TRACTO_RASPIRATORIO_ACTUAL = "N009-MF000002010";
        public const string MEMBRAMA_TIMPANICA_OIDO_DERECHO = "N009-MF000002011";
        public const string CONDUCTO_AUDITIVO_OIDO_DERECHO = "N009-MF000002012";
        public const string MEMBRANA_TIMPANICA_OIDO_IZQUIERDO = "N009-MF000002013";
        public const string CONDUCTO_AUDITIVO_OIDO_IZQUIERDO = "N009-MF000002014";

        #endregion

        public const string EXAMEN_SEREADO_EN_HECES_ID = "N009-ME000000428";
        public const string EXAMEN_SEREADO_EN_HECES_REACTIVOS = "N009-MF000003227";

        public const string MICROALBUMINURIA_ID = "N009-ME000000117";
        public const string CAMPO_MICROALBUMINURIA = "N009-MF000002027";
        public const string CAMPO_MICROALBUMINURIA_DESABLE = "N009-MF000002028";

        public const string EXAMEN_ELISA_ID = "N009-ME000000030";
        public const string CAMPO_HIV = "N009-MF000000257";
        public const string EXAMEN_ELISA__REACTIVOS_EXAMEN_ELISA_DESEABLE = "N009-MF000001288";


        public const string HBsAg_ID = "N009-ME000000121";
        public const string CAMPO_HBsAg = "N009-MF000002055";
        public const string CAMPO_HBsAg_DESEABLE = "N009-MF000002056";


        public const string HCV_ID = "N009-ME000000120";
        public const string CAMPO_HCV = "N009-MF000002053";
        public const string CAMPO_HCV_DESEABLE = "N009-MF000002054";




        public const string GLUCOSA_ID = "N009-ME000000008";
        public const string GLUCOSA_POST_PANDRIAL = "N009-MF000002059";
        public const string GLUCOSA_POST_DESEABLE = "N009-MF000002060";


        public const string INSULINA_BASAL_ID = "N009-ME000000125";
        public const string CAMPO_INSULINA_BASAL = "N009-MF000002067";
        public const string CAMPO_INSULINA_BASAL_DESEABLE = "N009-MF000002068";








        public const string HISOPADO_NASOFARINGEO_ID = "N009-ME000000118";
        public const string TIPO_MUESTRA = "N009-MF000002029";
        public const string FROTIS_GRAM = "N009-MF000002030";
        public const string LEVADURAS = "N009-MF000002031";
        public const string ANTIBIOGRAMA = "N009-MF000002032";


        public const string REACCION_INFLAMATORIA_ID = "N009-ME000000119";
        public const string REACCION_INFLAMATORIA_RESULTADO_ID = "N009-MF000002033";
        public const string REACCION_INFLAMATORIA_COLOR = "N009-MF000002033";
        public const string REACCION_INFLAMATORIA_ph = "N009-MF000002034";
        public const string REACCION_INFLAMATORIA_Consistencia = "N009-MF000002035";
        public const string REACCION_INFLAMATORIA_sangre = "N009-MF000002036";
        public const string REACCION_INFLAMATORIA_Celulas = "N009-MF000002037";
        public const string REACCION_INFLAMATORIA_Fibras_musculares = "N009-MF000002038";
        public const string REACCION_INFLAMATORIA_Leucocitos = "N009-MF000002039";
        public const string REACCION_INFLAMATORIA_Levaduras_de_hongos = "N009-MF000002040";
        public const string REACCION_INFLAMATORIA_Piocitos = "N009-MF000002041";
        public const string REACCION_INFLAMATORIA_Fibras_vegetales = "N009-MF000002042";
        public const string REACCION_INFLAMATORIA_Hematies = "N009-MF000002043";
        public const string REACCION_INFLAMATORIA_Cristales = "N009-MF000002044";
        public const string REACCION_INFLAMATORIA_Gotas_de_grasa = "N009-MF000002045";
        public const string REACCION_INFLAMATORIA_Fibras_Algodon = "N009-MF000002046";
        public const string REACCION_INFLAMATORIA_Granulos_de_almidon = "N009-MF000002047";



        public const string Hisopado_Faringeo_ID = "N009-ME000000095";
        public const string Hisopado_Faringeo_COLOR = "N009-MF000001791";
        public const string Hisopado_Faringeo_ASPECTO = "N009-MF000002048";
        public const string Hisopado_Faringeo_LEUCOCITOS = "N009-MF000002049";
        public const string Hisopado_Faringeo_HEMATIES = "N009-MF000002050";
        public const string Hisopado_Faringeo_CELULAS_EPITELIALES = "N009-MF000002051";
        public const string Hisopado_BACTERIAS_GRAM = "N009-MF000002052";


        public const string RASPADO_SUPERFICIE_UNIA_ID = "N009-ME000000122";
        public const string RASPADO_SUPERFICIE_TIPO_MUESTRA = "N009-MF000002057";
        public const string RASPADO_SUPERFICIE_RESULTADO = "N009-MF000002058";


        public const string TIPO_DE_SANGRIA_ID = "N009-ME000000123";
        public const string TIPO_DE_SANGRIA_TIEMPO = "N009-MF000002063";
        public const string TIPO_DE_SANGRIA_DESEABLE = "N009-MF000002064";


        public const string TIEMPO_COAGULACION_ID = "N009-ME000000124";
        public const string TIEMPO_COAGULACION_TIEMPO = "N009-MF000002065";
        public const string TIEMPO_COAGULACION_DESEABLE = "N009-MF000002066";

        public const string FECATEST_ID = "N009-ME000000097";
        public const string FECATEST_COLOR = "N009-MF000001812";
        public const string FECATEST_CONSISTENCIA = "N009-MF000002069";
        public const string FECATEST_MOCO = "N009-MF000002070";
        public const string FECATEST_HEMATIES = "N009-MF000003249";
        public const string FECATEST_LEVADURAS = "N009-MF000003250";
        public const string FECATEST_GRASAS = "N009-MF000003251";
        public const string FECATEST_LEUCOCITOS = "N009-MF000003252";
        public const string FECATEST_POLIMORFO_NUCLEARES = "N009-MF000003253";
        public const string FECATEST_MONONUCLEARES = "N009-MF000003254";
        public const string FECATEST_REACCION_INFLAMATORIA = "N009-MF000003255";

        public const string CUESTIONARIO_ISTAS = "N009-ME000000311";



        #region MyRegion

        #endregion

        #region CAMPOS UC OFTALMOLOGIA

        public const string AGUDEZA_VISUAL = "N002-ME000000145";
        public const string TXT_OFT_SC_OD = "N002-OFT00000001";
        public const string TXT_OFT_CC_OD = "N002-OFT00000002";
        public const string TXT_OFT_SC_OI = "N002-OFT00000003";
        public const string TXT_OFT_CC_OI = "N002-OFT00000004";
        public const string TXT_OFT_AE_OD = "N002-OFT00000005";
        public const string TXT_OFT_AE_OI = "N002-OFT00000006";
        public const string TXT_OFT_SC_ODC = "N002-OFT00000007";
        public const string TXT_OFT_CC_ODC = "N002-OFT00000008";
        public const string TXT_OFT_CC_ODC2 = "N002-OFT00000011";
        public const string TXT_OFT_SC_OIC = "N002-OFT00000009";
        public const string TXT_OFT_CC_OIC = "N002-OFT00000010";
        public const string TXT_OFT_CC_OIC2 = "N002-OFT00000012";
        public const string CHK_OFT_FIGURAS = "N002-OFT00000014";

        // Dx automatico
        public const string txt_OFT_DX_AUTO = "N002-MF000000813";
        #endregion

        #region CAMPOS UC ESPIROMETRIA

        public const string TXT_ESP_CVF = "N002-ESP00000001";
        public const string TXT_ESP_VEF1 = "N002-ESP00000002";
        public const string TXT_ESP_CVF_VEF1 = "N002-ESP00000003";
        // Dx automatico
        public const string txt_ESP_DX_AUTO = "N002-MF000000812";


        #endregion

        #region UCSomnolencia
        public const string SOMNOLENCIA_ID = "N009-ME000000126";
        public const string SOMNOLENCIA_1_SENTADO_ID = "N009-SOM00000001";
        public const string SOMNOLENCIA_2_MIRANDO_TV_ID = "N009-SOM00000002";
        public const string SOMNOLENCIA_3_SENTADO_INACTIVO_ID = "N009-SOM00000003";
        public const string SOMNOLENCIA_4_PASAJERO_ID = "N009-SOM00000004";
        public const string SOMNOLENCIA_5_ACOSTADO_DESC_ID = "N009-SOM00000005";
        public const string SOMNOLENCIA_6_ACOSTADO_CONVER_ID = "N009-SOM00000006";
        public const string SOMNOLENCIA_7_SENTADO_TRANQUILO_ID = "N009-SOM00000007";
        public const string SOMNOLENCIA_8_CARRO_TRACON_ID = "N009-SOM00000008";
        public const string SOMNOLENCIA_1_RESULTADO_ID = "N009-SOM00000009";
        public const string SOMNOLENCIA_2_RESULTADO_ID = "N009-SOM00000010";
        public const string SOMNOLENCIA_3_RESULTADO_ID = "N009-SOM00000011";
        public const string SOMNOLENCIA_4_RESULTADO_ID = "N009-SOM00000012";
        public const string SOMNOLENCIA_5_RESULTADO_ID = "N009-SOM00000013";
        public const string SOMNOLENCIA_6_RESULTADO_ID = "N009-SOM00000014";
        public const string SOMNOLENCIA_7_RESULTADO_ID = "N009-SOM00000015";
        public const string SOMNOLENCIA_8_RESULTADO_ID = "N009-SOM00000016";
        public const string SOMNOLENCIA_TOTAL_ID = "N009-SOM00000017";
        #endregion

        #region Acumetria
        public const string ACUMETRIA_ID = "N009-ME000000127";
        public const string ACUMETRIA_PRUEBA_WEBER = "N009-ACU00000001";
        public const string ACUMETRIA_OD_RINNER = "N009-ACU00000002";
        public const string ACUMETRIA_OI_RINNER = "N009-ACU00000003";

        public const string ACUMETRIA_WEBER = "N009-ACU00000004";

        public const string ACUMETRIA_OD_RINNE = "N009-ACU00000005";
        public const string ACUMETRIA_OI_RINNE = "N009-ACU00000006";

        public const string ACUMETRIA_CONCLUSIONES = "N009-ACU00000007";
        #endregion

        #region FOTOTIPO
        public const string FOTO_TIPO_ID = "N009-ME000000411";
        public const string FOTO_TIPO_LUNARES = "N009-FOT00000001";
        public const string FOTO_TIPO_MANCHAS = "N009-FOT00000002";
        public const string FOTO_TIPO_PECAS = "N009-FOT00000003";
        public const string FOTO_TIPO_CICATRICES = "N009-FOT00000004";

        public const string txt_MULTIMEDIA_FILE_FOTO_TIPO = "N009-FOT00000005";
        public const string txt_SERVICE_COMPONENT_MULTIMEDIA_FOTO_TIPO = "N009-FOT00000006";


        #endregion

        #region Ergonomia
        public const string EVA_ERGONOMICA_ID = "N009-ME000000128";

        public const string EVA_ERGONOMICA_HOMBORS = "N009-EVA00000001";
        public const string EVA_ERGONOMICA_CUELLO = "N009-EVA00000002";
        public const string EVA_ERGONOMICA_ESPALDA = "N009-EVA00000003";
        public const string EVA_ERGONOMICA_RODILLAS = "N009-EVA00000004";
        public const string EVA_ERGONOMICA_RODILLAS_2 = "N009-EVA00000005";

        public const string EVA_ERGONOMICA_BRAZO_MUNE = "N009-EVA00000006";
        public const string EVA_ERGONOMICA_BRAZO_MUNE_2 = "N009-EVA00000007";
        public const string EVA_ERGONOMICA_MANOS = "N009-EVA00000008";
        public const string EVA_ERGONOMICA_RODILLAS_3 = "N009-EVA00000009";

        public const string EVA_ERGONOMICA_CUELLOS_HOMB = "N009-EVA00000010";
        public const string EVA_ERGONOMICA_CUELLOS_HOMB_2 = "N009-EVA00000011";

        public const string EVA_ERGONOMICA_ZONA_LUMBAR = "N009-EVA00000012";
        public const string EVA_ERGONOMICA_ZONA_LUMBAR_2 = "N009-EVA00000013";

        public const string EVA_ERGONOMICA_MANOS_BRAZOS = "N009-EVA00000014";
        public const string EVA_ERGONOMICA_MANOS_BRAZOS_2 = "N009-EVA00000015";

        public const string EVA_ERGONOMICA_CONCLUSIONES = "N009-EVA00000016";

        #endregion

        #region Otoscopia

        public const string OTOSCOPIA_ID = "N009-ME000000129";

        public const string OTOSCOPIA_RUIDO = "N009-OTO00000001";
        public const string OTOSCOPIA_QUIMICO = "N009-OTO00000002";
        public const string OTOSCOPIA_DEPORTE = "N009-OTO00000003";
        public const string OTOSCOPIA_RUIDO_EXCE = "N009-OTO00000004";
        public const string OTOSCOPIA_MUSICA = "N009-OTO00000005";
        public const string OTOSCOPIA_OTOXICOS = "N009-OTO00000006";
        public const string OTOSCOPIA_MANIPULACION = "N009-OTO00000007";
        public const string OTOSCOPIA_OTOLOGICOS = "N009-OTO00000008";

        public const string OTOSCOPIA_ZUMBIDOS = "N009-OTO00000009";
        public const string OTOSCOPIA_SECRECION = "N009-OTO00000010";
        public const string OTOSCOPIA_MAREOS = "N009-OTO00000011";
        public const string OTOSCOPIA_OTALGIA = "N009-OTO00000012";
        public const string OTOSCOPIA_DISMINUCION = "N009-OTO00000013";
        public const string OTOSCOPIA_TRACTO = "N009-OTO00000014";
        public const string OTOSCOPIA_OTROS = "N009-OTO00000015";

        public const string OTOSCOPIA_OD_1 = "N009-OTO00000016";
        public const string OTOSCOPIA_OD_2 = "N009-OTO00000017";
        public const string OTOSCOPIA_OD_3 = "N009-OTO00000018";
        public const string OTOSCOPIA_OD_4 = "N009-OTO00000019";
        public const string OTOSCOPIA_OI_1 = "N009-OTO00000020";
        public const string OTOSCOPIA_OI_2 = "N009-OTO00000021";
        public const string OTOSCOPIA_OI_3 = "N009-OTO00000022";
        public const string OTOSCOPIA_OI_4 = "N009-OTO00000023";
        public const string OTOSCOPIA_OD_DESC = "N009-OTO00000024";
        public const string OTOSCOPIA_OI_DESC = "N009-OTO00000025";

        #endregion

        #region Sintomatico Respi
        public const string SINTOMATICO_ID = "N009-ME000000131";

        public const string SINTOMATICO_1 = "N009-RES00000001";
        public const string SINTOMATICO_2 = "N009-RES00000002";
        public const string SINTOMATICO_3 = "N009-RES00000003";
        public const string SINTOMATICO_4 = "N009-RES00000004";
        public const string SINTOMATICO_5 = "N009-RES00000005";
        public const string SINTOMATICO_6 = "N009-RES00000006";
        public const string SINTOMATICO_7 = "N009-RES00000007";
        public const string SINTOMATICO_OBS = "N009-RES00000008";
        public const string SINTOMATICO_SI_NO = "N009-RES00000009";
        public const string SINTOMATICO_BK_1 = "N009-RES00000010";
        public const string SINTOMATICO_BK_2 = "N009-RES00000011";
        public const string SINTOMATICO_RX = "N009-RES00000012";

        #endregion

        #region LumboSacra
        public const string LUMBOSACRA_ID = "N009-ME000000130";

        public const string LUMBOSACRA_1 = "N009-RXL00000001";
        public const string LUMBOSACRA_2 = "N009-RXL00000002";
        public const string LUMBOSACRA_3 = "N009-RXL00000003";
        public const string LUMBOSACRA_4 = "N009-RXL00000004";
        public const string LUMBOSACRA_5 = "N009-RXL00000005";
        public const string LUMBOSACRA_6 = "N009-RXL00000006";
        public const string LUMBOSACRA_7 = "N009-RXL00000007";
        public const string LUMBOSACRA_8 = "N009-RXL00000008";
        #endregion

        #region uc osteo


        public const string UC_OSTEO_FLEXIBILIDAD = "N009-OTS00000001";
        public const string UC_OSTEO_FLEXIBILIDAD_PTJ = "N009-OTS00000002";
        public const string UC_OSTEO_FLEXIBILIDAD_OBS = "N009-OTS00000003";

        public const string UC_OSTEO_CADERA = "N009-OTS00000004";
        public const string UC_OSTEO_CADERA_PTJ = "N009-OTS00000005";
        public const string UC_OSTEO_CADERA_OBS = "N009-OTS00000006";

        public const string UC_OSTEO_MUSLO = "N009-OTS00000007";
        public const string UC_OSTEO_MUSLO_PTJ = "N009-OTS00000008";
        public const string UC_OSTEO_MUSLO_OBS = "N009-OTS00000009";

        public const string UC_OSTEO_ABDOMEN = "N009-OTS00000010";
        public const string UC_OSTEO_ABDOMEN_PTJ = "N009-OTS00000011";
        public const string UC_OSTEO_ABDOMEN_OBS = "N009-OTS00000012";

        public const string UC_OSTEO_ABD_180 = "N009-OTS00000013";
        public const string UC_OSTEO_ABD_180_PTJ = "N009-OTS00000014";
        public const string UC_OSTEO_ABD_180_SINO = "N009-OTS00000015";

        public const string UC_OSTEO_ABD_60 = "N009-OTS00000016";
        public const string UC_OSTEO_ABD_60_PTJ = "N009-OTS00000017";
        public const string UC_OSTEO_ABD_60_SINO = "N009-OTS00000018";

        public const string UC_OSTEO_ABD_90 = "N009-OTS00000019";
        public const string UC_OSTEO_ABD_90_PTJ = "N009-OTS00000020";
        public const string UC_OSTEO_ABD_90_SINO = "N009-OTS00000021";

        public const string UC_OSTEO_ROTACION = "N009-OTS00000022";
        public const string UC_OSTEO_ROTACION_PTJ = "N009-OTS00000023";
        public const string UC_OSTEO_ROTACION_SINO = "N009-OTS00000024";

        public const string UC_OSTEO_OBS = "N009-OTS00000025";

        public const string UC_OSTEO_TOTAL1 = "N009-OTS00000026";
        public const string UC_OSTEO_TOTAL2 = "N009-OTS00000027";
        #endregion

        #region uc ojo seco
        public const string OJO_SECO_ID = "N009-ME000000133";

        public const string OJO_SECO_ENROJECIMIENTO = "N009-OJS00000001";
        public const string OJO_SECO_ENROJECIMIENTO_PTJ_1 = "N009-OJS00000006";

        public const string OJO_SECO_BORDE = "N009-OJS00000007";
        public const string OJO_SECO_BORDE_PTJ_2 = "N009-OJS00000012";

        public const string OJO_SECO_ESCAMAS = "N009-OJS00000013";
        public const string OJO_SECO_ESCAMAS_PTJ_3 = "N009-OJS00000018";

        public const string OJO_SECO_OJOS = "N009-OJS00000019";
        public const string OJO_SECO_OJOS_PTJ_4 = "N009-OJS00000024";

        public const string OJO_SECO_SECRE = "N009-OJS00000025";
        public const string OJO_SECO_SECRE_PTJ_5 = "N009-OJS00000030";

        public const string OJO_SECO_SEQUEDAD = "N009-OJS00000031";
        public const string OJO_SECO_SEQUEDAD_PTJ_6 = "N009-OJS00000036";

        public const string OJO_SECO_ARENILLA = "N009-OJS00000037";
        public const string OJO_SECO_ARENILLA_PTJ_7 = "N009-OJS00000042";

        public const string OJO_SECO_EXTRANO = "N009-OJS00000043";
        public const string OJO_SECO_EXTRANO_PTJ_8 = "N009-OJS00000048";

        public const string OJO_SECO_ARDOR = "N009-OJS00000049";
        public const string OJO_SECO_ARDOR_PTJ_9 = "N009-OJS00000054";

        public const string OJO_SECO_PICOR = "N009-OJS00000055";
        public const string OJO_SECO_PICOR_PTJ_10 = "N009-OJS00000060";

        public const string OJO_SECO_MALESTAR = "N009-OJS00000061";
        public const string OJO_SECO_MALESTAR_PTJ_11 = "N009-OJS00000066";

        public const string OJO_SECO_DOLOR = "N009-OJS00000067";
        public const string OJO_SECO_DOLOR_PTJ_12 = "N009-OJS00000072";

        public const string OJO_SECO_LAGRIMEO = "N009-OJS00000073";
        public const string OJO_SECO_LAGRIMEO_PTJ_13 = "N009-OJS00000078";

        public const string OJO_SECO_LLOROSOS = "N009-OJS00000079";
        public const string OJO_SECO_LLOROSOS_PTJ_14 = "N009-OJS00000084";

        public const string OJO_SECO_SENSIBILIDAD = "N009-OJS00000085";
        public const string OJO_SECO_SENSIBILIDAD_PTJ_15 = "N009-OJS00000090";

        public const string OJO_SECO_VISION = "N009-OJS00000091";
        public const string OJO_SECO_VISION_PTJ_16 = "N009-OJS00000096";

        public const string OJO_SECO_CANSANCION = "N009-OJS00000097";
        public const string OJO_SECO_CANSANCION_PTJ_17 = "N009-OJS00000102";

        public const string OJO_SECO_PESADEZ = "N009-OJS00000103";
        public const string OJO_SECO_PESADEZ_PTJ_18 = "N009-OJS00000108";

        public const string OJO_SECO_TOTAL = "N009-OJS00000109";

        #endregion



        public const string TOXICOLOGICO_ALCOHOLEMIA = "N009-ME000000041";
        public const string TOXICOLOGICO_ALCOHOLEMIA_RESULTADO = "N009-MF000000397";
        public const string TOXICOLOGICO_ALCOHOLEMIA_DESEABLE = "N009-MF000002061";


        public const string TOXICOLOGICO_ANFETAMINAS = "N009-ME000000043";
        public const string TOXICOLOGICO_ANFETAMINAS_RESULTADO = "N009-MF000000391";
        public const string TOXICOLOGICO_ANFETAMINAS_DESEABLE = "N009-MF000000392";


        public const string TOXICOLOGICO_BENZODIAZEPINAS = "N009-ME000000040";
        public const string TOXICOLOGICO_BENZODIAZEPINAS_RESULTADO = "N009-MF000000395";
        public const string TOXICOLOGICO_BENZODIAZEPINAS_DESEABLE = "N009-MF000000396";


        public const string TOXICOLOGICO_CARBOXIHEMOGLOBINA = "N002-ME000000042";
        public const string TOXICOLOGICO_CARBOXIHEMOGLOBINA_RESULTADO = "N009-MF000000201";
        public const string TOXICOLOGICO_CARBOXIHEMOGLOBINA_DESEABLE = "N009-MF000002062";



        public const string TOXICOLOGICO_COLINESTERASA = "N009-ME000000042";
        public const string TOXICOLOGICO_COLINESTERASA_RESULTADO = "N009-MF000000393";
        public const string TOXICOLOGICO_COLINESTERASA_DESEABLE = "N009-MF000000394";

        public const string ELECTRO_GOLD = "N009-ME000000412";

        public const string TOXICOLOGICO_ID = "N009-ME000000303";

        public const string AUDIO_COIMOLACHE = "N009-ME000000415";

        public const string AutoevaTrabEquipo_ID = "N009-ME000000309";
        public const string Cuestionariogradodeafectividad_ID = "N009-ME000000304";
        public const string Fobiasocial01_ID = "N009-ME000000305";
        public const string Fobiasocial02_ID = "N009-ME000000306";
        public const string Testdepersonalldad_ID = "N009-ME000000307";
        public const string FobiasocialAdmin_ID = "N009-ME000000308";
        public const string Testdefatiga_ID = "N002-ME000000034";
        public const string Maslachestres_ID = "N002-ME000000036";
        public const string Testdeansiedad_ID = "N002-ME000000039";
        public const string Testdedepresion_ID = "N002-ME000000037";
        public const string CuestionarioAutoeva_ID = "N009-ME000000310";

        #region INMUNIZACIONES ANEXO16

        public const string TETANO_ANEXO16_ID = "N009-MF000003190";
        public const string INFLUENZA_ANEXO16_ID = "N009-MF000003191";
        public const string HEPATITISB_ANEXO16_ID = "N009-MF000003192";
        public const string FIEBAMARILLA_ANEXO16_ID = "N009-MF000003193";
        #endregion

        #region Internacional IDS

        #region Altura
        #region ALTURA_ESTRUCTURAL

        public const string ALTURA_ESTRUCTURAL_ID_CI = "N005-ME000000015";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_SI_ID_CI = "N005-MF000000781";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_NO_ID_CI = "N005-MF000000782";
        public const string ALTURA_ESTRUCTURAL_ANTECEDENTE_TEC_OBS_ID_CI = "N005-MF000000783";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_SI_ID_CI = "N005-MF000000785";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_NO_ID_CI = "N005-MF000000786";
        public const string ALTURA_ESTRUCTURAL_CONVULSIONES_EPILEPSIA_OBS_ID_CI = "N005-MF000000787";
        public const string ALTURA_ESTRUCTURAL_MAREOS_SI_ID_CI = "N005-MF000000789";
        public const string ALTURA_ESTRUCTURAL_MAREOS_NO_ID_CI = "N005-MF000000790";
        public const string ALTURA_ESTRUCTURAL_MAREOS_OBS_ID_CI = "N005-MF000000791";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_SI_ID_CI = "N005-MF000000793";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_NO_ID_CI = "N005-MF000000794";
        public const string ALTURA_ESTRUCTURAL_AGORAFOBIA_OBS_ID_CI = "N005-MF000000795";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_SI_ID_CI = "N005-MF000000797";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_NO_ID_CI = "N005-MF000000798";
        public const string ALTURA_ESTRUCTURAL_ACROFOBIA_OBS_ID_CI = "N005-MF000000799";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_SI_ID_CI = "N005-MF000000801";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_NO_ID_CI = "N005-MF000000802";
        public const string ALTURA_ESTRUCTURAL_INSUFICIENCIA_CARDIACA_OBS_ID_CI = "N005-MF000000803";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_SI_ID_CI = "N005-MF000000805";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_NO_ID_CI = "N005-MF000000806";
        public const string ALTURA_ESTRUCTURAL_ESTEREOPSIA_OBS_ID_CI = "N005-MF000000807";
        public const string ALTURA_ESTRUCTURAL_NISTAGMUS_ESPONTANEO_ID_CI = "N005-MF000000026";
        public const string ALTURA_ESTRUCTURAL_NISTAGMUS_PROVOCADO_ID_CI = "N005-MF000000027";
        public const string ALTURA_ESTRUCTURAL_PRIMEROS_AUXILIOS_ID_CI = "N005-MF000000028";
        public const string ALTURA_ESTRUCTURAL_TRABAJO_SOBRE_NIVEL_ID_CI = "N005-MF000000029";
        public const string ALTURA_ESTRUCTURAL_TIMPANOS_ID_CI = "N005-MF000000030";
        public const string ALTURA_ESTRUCTURAL_EQUILIBRIO_ID_CI = "N005-MF000000031";
        public const string ALTURA_ESTRUCTURAL_SUST_PIE_20_ID_CI = "N005-MF000000036";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_RECTA_3_ID_CI = "N005-MF000000035";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_OJOS_VENDADOS_3_ID_CI = "N005-MF000000034";
        public const string ALTURA_ESTRUCTURAL_CAMINAR_LIBRE_OJOS_VENDADOS_PUNTA_TALON_3_ID_CI = "N005-MF000000032";
        public const string ALTURA_ESTRUCTURAL_ROTAR_SILLA_GIRATORIA_ID_CI = "N005-MF000000033";
        public const string ALTURA_ESTRUCTURAL_ADIADOCOQUINESIA_DIRECTA_ID_CI = "N005-MF000000037";
        public const string ALTURA_ESTRUCTURAL_ADIADOCOQUINESIA_CRUZADA_ID_CI = "N005-MF000000038";
        public const string ALTURA_ESTRUCTURAL_APTO_ID_CI = "N005-MF000000039";
        public const string ALTURA_ESTRUCTURAL_DESCRIPCION_ID_CI = "N005-MF000000357";

        #endregion
        #endregion
        #region Audiometria


        // Campos dinamicos (Manager componentes)     

        // Requisitos para la audiometria
        public const string AUDIOMETRIA_REQUISITOS_CAMBIOS_ALTITUD_CI = "N005-MF000001299";
        public const string AUDIOMETRIA_REQUISITOS_EXPUESTO_RUIDO_CI = "N005-MF000001300";
        public const string AUDIOMETRIA_REQUISITOS_PROCESO_INFECCIOSO_CI = "N005-MF000001301";
        public const string AUDIOMETRIA_REQUISITOS_DURMIO_NOCHE_PREVIA_CI = "N005-MF000001302";
        public const string AUDIOMETRIA_REQUISITOS_CONSUMIO_ALCOHOL_DIA_PREVIO_CI = "N005-MF000001303";
        public const string AUDIOMETRIA_REQUISITOS_TIEMPO_DE_TRABAJO_CI = "N005-MF000001378";

        // Antecedentes Medicos de importancia
        public const string AUDIOMETRIA_ANTECEDENTES_RINITIS_SINUSITIS_CI = "N005-MF000000089";
        public const string AUDIOMETRIA_ANTECEDENTES_USO_MEDICAMENTOS_CI = "N005-MF000000090";
        public const string AUDIOMETRIA_ANTECEDENTES_SARAMPION_CI = "N005-MF000000098";
        public const string AUDIOMETRIA_ANTECEDENTES_TEC_CI = "N005-MF000001305";
        public const string AUDIOMETRIA_ANTECEDENTES_OTITIS_MEDIA_CRONICA_CI = "N005-MF000000091";
        public const string AUDIOMETRIA_ANTECEDENTES_DIABETES_MELLITUS_CI = "N005-MF000000095";
        public const string AUDIOMETRIA_ANTECEDENTES_SORDERA_CI = "N005-MF000000101";
        public const string AUDIOMETRIA_ANTECEDENTES_SORDERA_FAMILIAR_CI = "N005-MF000001306";
        public const string AUDIOMETRIA_ANTECEDENTES_MENINGITIS_CI = "N005-MF000000097";
        public const string AUDIOMETRIA_ANTECEDENTES_DISLIPIDEMIA_CI = "N005-MF000000100";
        public const string AUDIOMETRIA_ANTECEDENTES_ENF_TIROIDEA_CI = "N005-MF000001304";
        public const string AUDIOMETRIA_ANTECEDENTES_SUST_QUIMICAS_CI = "N005-MF000001307";

        // Hobbies
        public const string AUDIOMETRIA_HOBBIES_USO_MP3_CI = "N005-MF000001308";
        public const string AUDIOMETRIA_HOBBIES_PRACTICA_TIRO_CI = "N005-MF000001309";
        public const string AUDIOMETRIA_HOBBIES_OTROS_CI = "N005-MF000001310";

        // Sintomas actuales
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_SORDERA_CI = "N005-MF000000092";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_OTALGIA_CI = "N005-MF000000096";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_ACUFENOS_CI = "N005-MF000000093";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_SECRECION_OTICA_CI = "N005-MF000000099";
        public const string AUDIOMETRIA_SINTOMAS_ACTUALES_VERTIGOS_CI = "N005-MF000000094";

        // Otoscopia
        public const string AUDIOMETRIA_OTOSCOPIA_OIDO_IZQUIERDO_CI = "N002-MF000000178";
        public const string AUDIOMETRIA_OTOSCOPIA_OIDO_DERECHO_CI = "N002-MF000000179";


        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_MARCA_CI = "N005-MF000000082";
        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_MODELO_CI = "N005-MF000000083";
        public const string AUDIOMETRIA_DATOS_DEL_AUDIOMETRO_CALIBRACION_CI = "N005-MF000000084";


        public const string AUDIO_NIVEL_AMB_RUIDO_ID_CI = "N005-MF000001874";
        public const string AUDIO_RUIDO_EXTRA_LABO_ID_CI = "N005-MF000001875";
        public const string AUDIO_ANIOS_ID_CI = "N005-MF000001876";

        public const string AUDIO_ANIOS_SERVICIO_MILITAR_ID_CI = "N005-MF000001878";

        public const string AUDIO_FREC_SERC_MILI_ID_CI = "N005-MF000001879";
        public const string AUDIO_ANIOS_DEP_AERO_ID_CI = "N005-MF000001880";
        public const string AUDIO_FREC_DEP_AEREO_ID_CI = "N005-MF000001881";
        public const string AUDIO_ANIOS_DEP_SUB_MARINOS_ID_CI = "N005-MF000001882";
        public const string AUDIO_FRE_DEP_SUB_MARINOS_ID_CI = "N005-MF000001883";
        public const string AUDIO_ANIOS_MANI_ARMAS_FUE_ID_CI = "N005-MF000001884";
        public const string AUDIO_FRE_MANI_ARMAS_ID_CI = "N005-MF000001885";

        public const string AUDIO_ANIOS_EXPO_MUSICA_ALTA_ID_CI = "N005-MF000001886";
        public const string AUDIO_FRE_MUSICA_ALTA_ID_CI = "N005-MF000001887";
        public const string AUDIO_ANIOS_USO_AUDIF_ID_CI = "N005-MF000001888";
        public const string AUDIO_FRE_USO_AUDIF_ID_CI = "N005-MF000001889";
        public const string AUDIO_ANIOS_MOTO_ID_CI = "N005-MF000001890";
        public const string AUDIO_FRE_MOTO_ID_CI = "N005-MF000001891";
        public const string AUDIO_ANIOS_OTRO_ID_CI = "N005-MF000001892";
        public const string AUDIO_FRE_OTROS_ID_CI = "N005-MF000001893";
        public const string AUDIO_HORAS_ID_CI = "N005-MF000001894";
        public const string AUDIO_AMBOS_ID_CI = "N005-MF000001895";

        public const string AUDIO_UMBRAL_DETEC_PALABRA_ID_CI = "N005-MF000001898";
        public const string AUDIO_UMBRAL_DETEC_O_I_ID_CI = "N005-MF000001899";
        public const string AUDIO_UMBRAL_RECO_PALABRA_ID_CI = "N005-MF000001900";
        public const string AUDIO_UMBRAL_RECO_O_I_ID_CI = "N005-MF000001901";
        public const string AUDIO_UMBRAL_MAX_DISC_ID_CI = "N005-MF000001902";
        public const string AUDIO_UMBRAL_MAX_O_I_ID_CI = "N005-MF000001903";
        public const string AUDIO_PORCENTAJE_DISC_ID_CI = "N005-MF000001904";
        public const string AUDIO_PORCENTAJE_DISC_OI_ID_CI = "N005-MF000001905";
        public const string AUDIO_DIAPASONES_ID_CI = "N005-MF000001906";
        public const string AUDIO_DIAPASONES_2_ID_CI = "N005-MF000001907";


        public const string AUDIO_DIAPASONES_3_ID_CI = "N005-MF000001908";
        public const string AUDIO_DIAPASONES_4_ID_CI = "N005-MF000001909";
        public const string AUDIO_RINNER_ID_CI = "N005-MF000001912";
        public const string AUDIO_RINNER_2_ID_CI = "N005-MF000001913";
        public const string AUDIO_RINNER_3_ID_CI = "N005-MF000001914";
        public const string AUDIO_RINNER_4_ID_CI = "N005-MF000001915";
        public const string AUDIO_RINNER_OD_ID_CI = "N005-MF000001916";
        public const string AUDIO_RINNER_OI_ID_CI = "N005-MF000001917";
        public const string AUDIO_WEBER_ID_CI = "N005-MF000001918";
        public const string AUDIO_WEBER_2_ID_CI = "N005-MF000001919";

        public const string AUDIO_WEBER_3_ID_CI = "N005-MF000001920";
        public const string AUDIO_WEBER_4_ID_CI = "N005-MF000001921";
        public const string AUDIO_WEBER_OD_ID_CI = "N005-MF000001922";
        public const string AUDIO_WEBER_OI_ID_CI = "N005-MF000001923";
        public const string AUDIO_BASE_ID_CI = "N005-MF000001927";
        public const string AUDIO_BASE_OD_ID_CI = "N005-MF000001928";
        public const string AUDIO_BASE_OI_ID_CI = "N005-MF000001929";
        public const string AUDIO_REFERENCIAL_ID_CI = "N005-MF000001930";
        public const string AUDIO_REFERENCIAL_OD_ID_CI = "N005-MF000001931";
        public const string AUDIO_REFERENCIAL_OI_ID_CI = "N005-MF000001932";


        public const string AUDIO_ACTUAL_ID_CI = "N005-MF000001933";
        public const string AUDIO_ACTUAL_OD_ID_CI = "N005-MF000001934";
        public const string AUDIO_ACTUAL_OI_ID_CI = "N005-MF000001935";

        public const string MENOSCABO_AUDITIVO_CI = "N005-MF000001979";


        #endregion

        #region Tamizaje Dermatológico CI
        public const string TAMIZAJE_DERMATOLOGIO_ID_CI = "N005-ME000000116";
        public const string TAMIZAJE_DERMATOLOGIO_HALLAZGOS_ID_CI = "N005-MF000000405";

        public const string TAMIZAJE_DERMATOLOGIO_SUFRE_UD_ENFERMEDAD_PIEL_ID_CI = "N005-MF000000399";
        public const string TAMIZAJE_DERMATOLOGIO_SI_QUE_DX_TIENE_ID_CI = "N005-MF000000400";
        public const string TAMIZAJE_DERMATOLOGIO_ACTUALMENTE_LESION_ID_CI = "N005-MF000000401";
        public const string TAMIZAJE_DERMATOLOGIO_SI_DONDE_LOCALIZA_ID_CI = "N005-MF000000402";
        public const string TAMIZAJE_DERMATOLOGIO_CUANTO_TIENE_LESION_ID_CI = "N005-MF000000403";
        public const string TAMIZAJE_DERMATOLOGIO_PRESENTA_COLORACION_PIEL_ID_CI = "N005-MF000000404";
        public const string TAMIZAJE_DERMATOLOGIO_LESIONES_REPITE_VARIAS_ANIOS_ID_CI = "N005-MF000000405";
        public const string TAMIZAJE_DERMATOLOGIO_ENRROJECIMIENTO_PARTE_CUERPO_ID_CI = "N005-MF000000406";
        public const string TAMIZAJE_DERMATOLOGIO_ENRROJECIMIENTO_SI_DONDE_LOCALIZA_ID_CI = "N005-MF000000407";
        public const string TAMIZAJE_DERMATOLOGIO_TIENE_COMEZON_ID_CI = "N005-MF000000408";
        public const string TAMIZAJE_DERMATOLOGIO_COMEZON_LOCALIZA_ID_CI = "N005-MF000000409";
        public const string TAMIZAJE_DERMATOLOGIO_HINCHAZON_PARTE_CUERPO_ID_CI = "N005-MF000000410";
        public const string TAMIZAJE_DERMATOLOGIO_HINCHAZON_PARTE_CUERPO_DONDE_LOCALIZA_ID_CI = "N005-MF000000411";
        public const string TAMIZAJE_DERMATOLOGIO_ALERGIA_ASMA_ID_CI = "N005-MF000000412";
        public const string TAMIZAJE_DERMATOLOGIO_USA_EPP_ID_CI = "N005-MF000000413";

        public const string TAMIZAJE_DERMATOLOGIO_SI_TIPO_PROTECCION_USA_ID_CI = "N005-MF000001009";
        public const string TAMIZAJE_DERMATOLOGIO_PRESENTA_CAMBIO_UNAS_ID_CI = "N005-MF000001010";
        public const string TAMIZAJE_DERMATOLOGIO_TOMANDO_ALGUNA_MEDICACION_ID_CI = "N005-MF000001011";
        public const string TAMIZAJE_DERMATOLOGIO_SI_COMO_SE_LLAMA_ID_CI = "N005-MF000001012";
        public const string TAMIZAJE_DERMATOLOGIO_DOSIS_FRECUENCIA_ID_CI = "N005-MF000001013";
        public const string TAMIZAJE_DERMATOLOGIO_DESCRIPCION1_ID_CI = "N005-MF000001014";
        public const string TAMIZAJE_DERMATOLOGIO_DERMATOPIA_ID_CI = "N005-MF000001015";
        public const string TAMIZAJE_DERMATOLOGIO_NIKOLSKY_ID_CI = "N005-MF000001016";
        #endregion


        #region OSTEO
        public const string OSTEO_MUSCULAR_ID_1_CI = "N005-ME000000046";
        public const string AMBAS_MANOS_CI = "N005-MF000001535";
        public const string AMBAS_MANOS_12MESES_CI = "N005-MF000001536";
        public const string AMBAS_MANOS_7DIAS_CI = "N005-MF000001485";
        public const string AMBOS_CODOS_CI = "N005-MF000001526";
        public const string AMBOS_CODOS_12_MESES_CI = "N005-MF000001527";
        public const string AMBOS_CODOS_7_DIAS_CI = "N005-MF000001530";
        public const string AMBOS_HOMBROS_CI = "N005-MF000001480";
        public const string AMBOS_HOMBROS_12_MESES_CI = "N005-MF000001481";
        public const string AMBOS_HOMBROS_7_DIAS_CI = "N005-MF000001521";
        public const string CADERA_DERECHA_CI = "N005-MF000001489";
        public const string CADERA_DERECHA_12_MESES_CI = "N005-MF000001483";
        public const string CADERA_DERECHA_7_DIAS_CI = "N005-MF000001490";
        public const string CODO_DERECHO_CI = "N005-MF000001520";
        public const string CODO_DERECHO_12_MESES_CI = "N005-MF000001522";
        public const string CODO_DERECHO_7_DIAS_CI = "N005-MF000001525";
        public const string CODO_IZQUIERDO_CI = "N005-MF000001519";
        public const string CODO_IZQUIERDO_12_MESES_CI = "N005-MF000001523";
        public const string CODO_IZQUIERDO_7DIAS_CI = "N005-MF000001524";
        public const string COLUMNA_DORSAL_CI = "N005-MF000001486";
        public const string COLUMNA_DORSAL_12MESE_CI = "N005-MF000001487";
        public const string COLUMNA_DORSAI_7DIAS_CI = "N005-MF000001482";
        public const string COLUMNA_LUMBAR_CI = "N005-MF000001491";
        public const string COLUMNA_LUMBAR_12MESES_CI = "N005-MF000001492";
        public const string COLUMNA_LUMBAR_7DIAS_CI = "N005-MF000001493";
        public const string HOMBRO_DERECHO_CI = "N005-MF000001473";
        public const string HOMBRO_DERECHO_12_MESES_CI = "N005-MF000001477";
        public const string HOMBRO_DERECHO_7_DIAS_CI = "N005-MF000001478";
        public const string HOMBRO_IZQUIERDO_CI = "N005-MF000001474";
        public const string HOMBRO_IZQUIERDO_12_MES_CI = "N005-MF000001476";
        public const string HOMBRO_IZQUIERDO_7_DIAS_CI = "N005-MF000001479";
        public const string MANO_DERECHA_CI = "N005-MF000001528";
        public const string MANO_DERECHA_12_MESES_CI = "N005-MF000001532";
        public const string MANO_DERECHA_7DIAS_CI = "N005-MF000001533";
        public const string MANO_IZQUIERDA_CI = "N005-MF000001529";
        public const string MANO_IZQUIERDA_12_MESES_CI = "N005-MF000001531";
        public const string MANO_IZQUIERDA_7DAS_CI = "N005-MF000001534";
        public const string NUCA_CUELLO_CI = "N005-MF000001471";
        public const string NUCA_CUELLO_12_MESES_CI = "N005-MF000001472";
        public const string NUCA_CUELLO_7DIAS_CI = "N005-MF000001475";
        public const string RODILLA_DERECHA_CI = "N005-MF000001488";
        public const string RODILLA_DERECHA_12MESES_CI = "N005-MF000001484";
        public const string RODILLA_DERECHA_7DIAS_CI = "N005-MF000001496";
        public const string RODILLA_IZQUIERDA_CI = "N005-MF000001497";
        public const string RODILLA_LZQUIERDA12MESES_CI = "N005-MF000001498";
        public const string CERVICAL_AP_CI = "N005-MF000001501";
        public const string DORSAL_AP_CI = "N005-MF000001504";
        public const string LUMBAR_AP_CI = "N005-MF000001505";
        public const string CERVICAL_MOV_DOL_CI = "N005-MF000001502";
        public const string CERVICAL_EXTENSION_MOV_DOL_CI = "N005-MF000001506";
        public const string CERVICAL_IRRADIACION_MOV_DOL_CI = "N005-MF000001508";
        public const string CERVICAL_LATERALIZACION_DERECHA_MOV_DOL_CI = "N005-MF000001503";
        public const string CERVICAL_LATERALIZACION_IZQUIERDA_MOV_DOL_CI = "N005-MF000001470";
        public const string CERVICAL_ROTACION_DERECHA_MOV_DOL_CI = "N005-MF000001499";
        public const string CERVICAL_ROTACION_IZQUIERDA_MOV_DOL_CI = "N005-MF000001495";
        public const string DORSO_LUMBAR_MOV_DOL_CI = "N005-MF000001509";
        public const string DORSO_LUMBAREXTENSION_MOV_DOL_CI = "N005-MF000001510";
        public const string DORSO_LUMBARLRRADIACION_MOV_DOL_CI = "N005-MF000001516";
        public const string DORSO_LUMBARLATERALIZACION_DERECHA_MOV_DOL_CI = "N005-MF000001512";
        public const string DORSO_LUMBARLATERALIZACION_IZQUIERDA_MOV_DOL_CI = "N005-MF000001513";
        public const string DORSO_LUMBARROTACION_DERECHA_MOV_DOL_CI = "N005-MF000001514";
        public const string DORSO_LUMBARROTACION_IZQUIERDA_MOV_DOL_CI = "N005-MF000001515";
        public const string LASEGUE_DERECHA_CI = "N005-MF000001517";
        public const string LASEGUE_IZQUIERDA_CI = "N005-MF000001511";
        public const string SCHOBER_DERECHA_CI = "N005-MF000001469";
        public const string SCHOBER_IZQUIERDA_CI = "N005-MF000001468";
        public const string COLUMNA_CERVICAL_PALP_CI = "N005-MF000001226";
        public const string COLUMNA_CERVCALCONTRACTURA_MUSCULAR_PALP_CI = "N005-MF000001221";
        public const string COLUMNA_DORSAL_PALP_CI = "N005-MF000001227";
        public const string COLUMNA_DORSALCONTRACTURA_MUSCULAR_PALP_CI = "N005-MF000001222";
        public const string COLUMNA_LUMBAR_PALP_CI = "N005-MF000001220";
        public const string COLUMNA_LUMBARCONTRACTURA_MUSCULAR_PALP_CI = "N005-MF000001224";
        public const string CONTRACTURA_MUSCULAR_PALP_CI = "N005-MF000000541";
        public const string CADERA_DER_AB_CI = "N005-MF000000171";
        public const string CADERA_DER_ADDUCION_CI = "N005-MF000000169";
        public const string CADERA_DER_ALTER_MASA_MUSCULAR__CI = "N005-MF000000835";
        public const string CADERA_DER_EXTENSION_CI = "N005-MF000000170";
        public const string CADERA_DER_IRRAD_CI = "N005-MF000000836";
        public const string CADERA_DER_ROTACIÓN_EXTEMA_CI = "N005-MF000000837";
        public const string CADERA_DER_ROTACIÓN_INTERNA_CI = "N005-MF000000839";
        public const string CADERA_DERFLEXION_CI = "N005-MF000000167";
        public const string CADERA_IZQ_AB_CI = "N005-MF000000838";
        public const string CADERA_IZQ_ADDUCION_CI = "N005-MF000000845";
        public const string CADERA_IZQ_AHER_MASA_MUSCULAR_CI = "N005-MF000000621";
        public const string CADERA_IZQ_EXTENSION_CI = "N005-MF000000843";
        public const string CADERA_IZQ_FLEXION_CI = "N005-MF000000842";
        public const string CADERA_IZQ_IRRAD_CI = "N005-MF000000850";
        public const string CADERA_IZQ_ROTACION_EXTEMA_CI = "N005-MF000000841";
        public const string CADERA_IZQ_ROTACION_INTERNA_CI = "N005-MF000000844";
        public const string CODO_DER_AB_CI = "N005-MF000000065";
        public const string CODO_DERAHER_MASA_MUSCULAR_CI = "N005-MF000000819";
        public const string CODO_DER_FLEXION_CI = "N005-MF000000060";
        public const string CODO_DER_IRRAD_CI = "N005-MF000000153";
        public const string CODO_DER_ROTACION_EXTERNA_CI = "N005-MF000000063";
        public const string CODO_DER_ROTACION_INTERNA_CI = "N005-MF000000813";
        public const string CODO_DER_ADDUCION_CI = "N005-MF000000059";
        public const string CODO_DER_EXTENSION_CI = "N005-MF000000062";
        public const string CODO_IZQ_AB_CI = "N005-MF000000822";
        public const string CODO_IZQ_ADDUCION_CI = "N005-MF000000820";
        public const string CODO_IZQ_AHER_MASA_MUSCULAR_CI = "N005-MF000000146";
        public const string CODO_IZQ_EXTENSION_CI = "N005-MF000000821";
        public const string CODO_IZQ_FLEXION_CI = "N005-MF000000823";
        public const string CODO_IZQ_IRRAD_CI = "N005-MF000000155";
        public const string CODO_IZQ_ROTACION_EXTERNA_CI = "N005-MF000000156";
        public const string CODO_IZQ_ROTACION_INTERNA_CI = "N005-MF000000154";
        public const string HOMBRO_DER_AB_CI = "N005-MF000001223";
        public const string HOMBRO_DER_ADDUCION_CI = "N005-MF000001228";
        public const string HOMBRO_DER_AHER_MASA_MUSCULAR_CI = "N005-MF000001413";
        public const string HOMBRO_DER_EXTENSION_CI = "N005-MF000001230";
        public const string HOMBRO_DER_FLEXION_CI = "N005-MF000001229";
        public const string HOMBRO_DER_IRRAD_CI = "N005-MF000001412";
        public const string HOMBRO_DER_ROTACION_INTERNA_CI = "N005-MF000001416";
        public const string HOMBRO_DERROTACION_EXTEMA_CI = "N005-MF000001415";
        public const string HOMBRO_IZQ_AB_CI = "N005-MF000001414";
        public const string HOMBRO_IZQADDUCION_CI = "N005-MF000000547";
        public const string HOMBRO_IZQ_ALTER_MASA_MUSCULAR_CI = "N005-MF000000064";
        public const string HOMBRO_IZQ_EXTENSION_CI = "N005-MF000000544";
        public const string HOMBRO_IZQ_FLEXION_CI = "N005-MF000000548";
        public const string HOMBRO_IZQ_IRRAD_CI = "N005-MF000000536";
        public const string HOMBRO_IZQ_ROTACION_EXTEMA_CI = "N005-MF000000545";
        public const string HOMBRO_IZQ_ROTACION_INTERNA_CI = "N005-MF000000144";
        public const string MUNECAS_DER_AB_CI = "N005-MF000000808";
        public const string MUNECAS_DER_AB_DERADDUCION_CI = "N005-MF000000152";
        public const string MUNECAS_DER_EXTENSION_CI = "N005-MF000000157";
        public const string MUNECAS_DER_FLEXION_CI = "N005-MF000000809";
        public const string MUNECAS_DER_IRRAD_CI = "N005-MF000000816";
        public const string MUNECAS_DER_ROTACION_EXTEMA_CI = "N005-MF000000812";
        public const string MUNECAS_DER_ROTACION_INTERNA_CI = "N005-MF000000815";
        public const string MUNECAS_DER_ALTER_MASA_MUSCULAR_CI = "N005-MF000000814";
        public const string MUNECAS_IZQ_AB_CI = "N005-MF000000147";
        public const string MUNECAS_IZQ_ALTER_MASA_MUSCULAR_CI = "N005-MF000000832";
        public const string MUNECAS_IZQ_EXTENSION_CI = "N005-MF000000833";
        public const string MUNECAS_IZQ_FLEXION_CI = "N005-MF000000168";
        public const string MUNECAS_IZQ_IRRAD_CI = "N005-MF000000173";
        public const string MUNECAS_IZQ_ROTACION_EXTEMA_CI = "N005-MF000000174";
        public const string MUNECAS_IZQ_ROTACION_INTERNA_CI = "N005-MF000000831";
        public const string MUNECAS_IZQADDUCION_CI = "N005-MF000000829";
        public const string RODILLA_DER_AB_CI = "N005-MF000000207";
        public const string RODILLA_DERADDUCION_CI = "N005-MF000001104";
        public const string RODILLA_DERAHER_MASA_MUSCULAR_CI = "N005-MF000000055";
        public const string RODILLA_DER_FLEXION_CI = "N005-MF000001103";
        public const string RODILLA_DER_IRRAD_CI = "N005-MF000000543";
        public const string RODILLA_DER_ROTACION_EXTEMA_CI = "N005-MF000000048";
        public const string RODILLA_DEREXTENSION_CI = "N005-MF000001102";
        public const string RODILLA_DERROTACION_INTERNA_CI = "N005-MF000000546";
        public const string RODILLA_IZQ_AB_CI = "N005-MF000000056";
        public const string RODILLA_IZQ_ADDUCION_CI = "N005-MF000000057";
        public const string RODILLA_IZQ_AHER_MASA_MUSCULAR_CI = "N005-MF000000061";
        public const string RODILLA_IZQ_EXTENSION_CI = "N005-MF000000054";
        public const string RODILLA_IZQ_IRRAD_CI = "N005-MF000000058";
        public const string RODILLA_IZQ_ROTACION_EXTEMA_CI = "N005-MF000000066";
        public const string RODILLA_IZQ_ROTACION_INTERNA_CI = "N005-MF000000051";
        public const string RODILLA_IZQ_FLEXION_CI = "N005-MF000000053";
        public const string TOBILLO_DER_AB_CI = "N005-MF000000773";
        public const string TOBILLO_DERADDUCION_CI = "N005-MF000000825";
        public const string TOBILLO_DERAHER_MASA_MUSCULAR_CI = "N005-MF000000818";
        public const string TOBILLO_DER_EXTENSION_CI = "N005-MFOO0000827";
        public const string TOBILLO_DER_FLEXION_CI = "N005-MF000000826";
        public const string TOBILLO_DER_IRRAD_CI = "N005-MF000000145";
        public const string TOBILLO_DER_ROTACION_EXTEMA_CI = "N005-MF000000828";
        public const string TOBILLO_DER_ROTACION_INTERNA_CI = "N005-MF000000830";
        public const string TOBILLO_IZQ_AB_CI = "N005-MF000000824";
        public const string TOBILLO_IZQ_ADDUCION_CI = "N005-MF000000158";
        public const string TOBILLO_IZQ_AHER_MAS3_MUSCULAR_CI = "N005-MF000000817";
        public const string TOBILLO_IZQ_EXTENSION_CI = "N005-MF000000159";
        public const string TOBILLO_IZQ_FLEXION_CI = "N005-MF000000810";
        public const string TOBILLO_IZQ_IRRAD_CI = "N005-MF000000811";
        public const string TOBILLO_IZQ_ROTACION_EXTEMA_CI = "N005-MF000000160";
        public const string TOBILLO_IZQ_ROTACION_INTERNA_CI = "N005-MF000000846";
        public const string CODO_DERECHO_VAR_VAL_CI = "N005-MF000000166";
        public const string CODO_IZQUIERDO_VAR_VAL_CI = "N005-MF000000834";
        public const string PIE_DERECHO_VAR_VAL_CI = "N005-MF000000840";
        public const string PIE_IZQUIERDO_VAR_VAL_CI = "N005-MF000000539";
        public const string TEST_DE_PHALEN_DERECHO_CI = "N005-MF000000847";
        public const string TEST_DE_PHALEN_IZQUIERDO_CI = "N005-MF000000848";
        public const string TEST_DE_TINEL_DERECHO_CI = "N005-MF000000849";
        public const string TEST_DE_TINEL_IZQUIERDO_CI = "N005-MF000000172";


        public const string CADERA_IZQUIERDA_CI = "N005-MF000001970";
        public const string CADERA_IZQUIERDA_12MESES_CI = "N005-MF000001971";
        public const string CADERA_IZQUIERDA_7_DIAS_CI = "N005-MF000000172";
        public const string TOB_DERECHO_CI = "N005-MF000001973";
        public const string TOB_DERECHO_12MESES_CI = "N005-MF000001974";
        public const string TOB_DERECHO_7_DIAS_CI = "N005-MF000001975";
        public const string TOB_IZQUIERDO_CI = "N005-MF000001976";
        public const string TOB_IZQUIERDO_12MESES_CI = "N005-MF000001977";
        public const string TOB_IZQUIERDO_7DIAS_CI = "N005-MF000001978";
        //public const string MENOSCABO_AUDITIVO_CI = "N005-MF000001979";
        public const string DORSAL_LATERAL_CI = "N005-MF000001518";
        public const string LUMBAR_LATERAL_CI = "N005-MF000001494";




        #endregion

        #region OSTEO_COIMO

        public const string OSTEO_COIMO = "N009-ME000000414";

        #endregion
        #endregion


        #region Protocol HardCode

        public const string Prot_Hospi_Adic= "N009-PR000000636";

        #endregion
    }



}
