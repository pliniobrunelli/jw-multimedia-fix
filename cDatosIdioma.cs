using System;
using System.Globalization;

namespace JWMultimedia
{
    // Token: 0x0200000C RID: 12
    [Serializable]
    public class cDatosIdioma : IComparable
    {
        // Token: 0x17000025 RID: 37
        // (get) Token: 0x06000064 RID: 100 RVA: 0x00054CCC File Offset: 0x000530CC
        // (set) Token: 0x06000065 RID: 101 RVA: 0x00054CE0 File Offset: 0x000530E0
        public int Index
        {
            get
            {
                return this.m_Index;
            }
            set
            {
                this.m_Index = value;
            }
        }

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x06000066 RID: 102 RVA: 0x00054CEC File Offset: 0x000530EC
        // (set) Token: 0x06000067 RID: 103 RVA: 0x00054D00 File Offset: 0x00053100
        public string NombreEspañol
        {
            get
            {
                return this.m_NombreEspañol;
            }
            set
            {
                this.m_NombreEspañol = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
            }
        }

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000068 RID: 104 RVA: 0x00054D18 File Offset: 0x00053118
        // (set) Token: 0x06000069 RID: 105 RVA: 0x00054D2C File Offset: 0x0005312C
        public string NombreIngles
        {
            get
            {
                return this.m_NombreIngles;
            }
            set
            {
                this.m_NombreIngles = value;
            }
        }

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x0600006A RID: 106 RVA: 0x00054D38 File Offset: 0x00053138
        // (set) Token: 0x0600006B RID: 107 RVA: 0x00054D4C File Offset: 0x0005314C
        public string NombreOriginal
        {
            get
            {
                return this.m_NombreOriginal;
            }
            set
            {
                this.m_NombreOriginal = value;
            }
        }

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x0600006C RID: 108 RVA: 0x00054D58 File Offset: 0x00053158
        // (set) Token: 0x0600006D RID: 109 RVA: 0x00054D6C File Offset: 0x0005316C
        public string IdIdioma
        {
            get
            {
                return this.m_idIdioma;
            }
            set
            {
                this.m_idIdioma = value;
            }
        }

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x0600006E RID: 110 RVA: 0x00054D78 File Offset: 0x00053178
        // (set) Token: 0x0600006F RID: 111 RVA: 0x00054D8C File Offset: 0x0005318C
        public string R
        {
            get
            {
                return this.m_R;
            }
            set
            {
                this.m_R = value;
            }
        }

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x06000070 RID: 112 RVA: 0x00054D98 File Offset: 0x00053198
        // (set) Token: 0x06000071 RID: 113 RVA: 0x00054DAC File Offset: 0x000531AC
        public string Lp
        {
            get
            {
                return this.m_Lp;
            }
            set
            {
                this.m_Lp = value;
            }
        }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x06000072 RID: 114 RVA: 0x00054DB8 File Offset: 0x000531B8
        // (set) Token: 0x06000073 RID: 115 RVA: 0x00054DCC File Offset: 0x000531CC
        public string Publicaciones
        {
            get
            {
                return this.m_Publicaciones;
            }
            set
            {
                this.m_Publicaciones = value;
            }
        }

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x06000074 RID: 116 RVA: 0x00054DD8 File Offset: 0x000531D8
        // (set) Token: 0x06000075 RID: 117 RVA: 0x00054DEC File Offset: 0x000531EC
        public string Biblia
        {
            get
            {
                return this.m_Biblia;
            }
            set
            {
                this.m_Biblia = value;
            }
        }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x06000076 RID: 118 RVA: 0x00054DF8 File Offset: 0x000531F8
        // (set) Token: 0x06000077 RID: 119 RVA: 0x00054E0C File Offset: 0x0005320C
        public string TextoAnual1
        {
            get
            {
                return this.m_TextoAnual1;
            }
            set
            {
                this.m_TextoAnual1 = value;
            }
        }

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000078 RID: 120 RVA: 0x00054E18 File Offset: 0x00053218
        // (set) Token: 0x06000079 RID: 121 RVA: 0x00054E2C File Offset: 0x0005322C
        public string TextoAnual2
        {
            get
            {
                return this.m_TextoAnual2;
            }
            set
            {
                this.m_TextoAnual2 = value;
            }
        }

        // Token: 0x17000030 RID: 48
        // (get) Token: 0x0600007A RID: 122 RVA: 0x00054E38 File Offset: 0x00053238
        // (set) Token: 0x0600007B RID: 123 RVA: 0x00054E4C File Offset: 0x0005324C
        public string Cantico
        {
            get
            {
                return this.m_Cantico;
            }
            set
            {
                this.m_Cantico = value;
            }
        }

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x0600007C RID: 124 RVA: 0x00054E58 File Offset: 0x00053258
        // (set) Token: 0x0600007D RID: 125 RVA: 0x00054E6C File Offset: 0x0005326C
        public string id_LS
        {
            get
            {
                return this.m_id_LS;
            }
            set
            {
                this.m_id_LS = value;
            }
        }

        // Token: 0x0600007E RID: 126 RVA: 0x00054E78 File Offset: 0x00053278
        public cDatosIdioma()
        {
            this.m_Index = -1;
            this.m_NombreEspañol = string.Empty;
            this.m_NombreIngles = string.Empty;
            this.m_NombreOriginal = string.Empty;
            this.m_idIdioma = string.Empty;
            this.m_R = string.Empty;
            this.m_Lp = string.Empty;
            this.m_Publicaciones = string.Empty;
            this.m_Biblia = string.Empty;
            this.m_TextoAnual1 = string.Empty;
            this.m_TextoAnual2 = string.Empty;
            this.m_Cantico = string.Empty;
            this.m_id_LS = string.Empty;
        }

        // Token: 0x0600007F RID: 127 RVA: 0x00054F18 File Offset: 0x00053318
        public cDatosIdioma(int intIndex, string strNombreEspañol, string strNombreIngles, string strNombreOriginal, string strIdIdioma, string strR, string strLP, string strPublicaciones, string strBiblia, string strid_ls)
        {
            this.m_Index = -1;
            this.m_NombreEspañol = string.Empty;
            this.m_NombreIngles = string.Empty;
            this.m_NombreOriginal = string.Empty;
            this.m_idIdioma = string.Empty;
            this.m_R = string.Empty;
            this.m_Lp = string.Empty;
            this.m_Publicaciones = string.Empty;
            this.m_Biblia = string.Empty;
            this.m_TextoAnual1 = string.Empty;
            this.m_TextoAnual2 = string.Empty;
            this.m_Cantico = string.Empty;
            this.m_id_LS = string.Empty;
            this.m_Index = intIndex;
            this.m_NombreEspañol = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strNombreEspañol);
            this.m_NombreIngles = strNombreIngles;
            this.m_NombreOriginal = strNombreOriginal;
            this.m_idIdioma = strIdIdioma;
            this.m_R = strR;
            this.m_Lp = strLP;
            this.m_Publicaciones = strPublicaciones;
            this.m_Biblia = strBiblia;
            this.m_id_LS = strid_ls;
        }

        // Token: 0x06000080 RID: 128 RVA: 0x00055014 File Offset: 0x00053414
        public override string ToString()
        {
            if (this.m_NombreEspañol.Length > 0)
            {
                return string.Concat(new string[]
                {
                    this.m_NombreOriginal,
                    " (",
                    this.m_NombreIngles,
                    " - ",
                    this.m_NombreEspañol,
                    ")"
                });
            }
            return this.m_NombreOriginal + " (" + this.m_NombreIngles + ")";
        }

        // Token: 0x06000081 RID: 129 RVA: 0x0005508C File Offset: 0x0005348C
        public string NombrePorDefecto()
        {
            if (this.m_NombreEspañol.Length > 0)
            {
                return this.m_NombreEspañol;
            }
            return this.m_NombreIngles;
        }

        // Token: 0x06000082 RID: 130 RVA: 0x000550B4 File Offset: 0x000534B4
        public int CompareTo(object obj)
        {
            return string.Compare(this.NombrePorDefecto(), ((cDatosIdioma)obj).NombrePorDefecto(), true);
        }

        // Token: 0x04000069 RID: 105
        private int m_Index;

        // Token: 0x0400006A RID: 106
        private string m_NombreEspañol;

        // Token: 0x0400006B RID: 107
        private string m_NombreIngles;

        // Token: 0x0400006C RID: 108
        private string m_NombreOriginal;

        // Token: 0x0400006D RID: 109
        private string m_idIdioma;

        // Token: 0x0400006E RID: 110
        private string m_R;

        // Token: 0x0400006F RID: 111
        private string m_Lp;

        // Token: 0x04000070 RID: 112
        private string m_Publicaciones;

        // Token: 0x04000071 RID: 113
        private string m_Biblia;

        // Token: 0x04000072 RID: 114
        private string m_TextoAnual1;

        // Token: 0x04000073 RID: 115
        private string m_TextoAnual2;

        // Token: 0x04000074 RID: 116
        private string m_Cantico;

        // Token: 0x04000075 RID: 117
        private string m_id_LS;
    }
}
