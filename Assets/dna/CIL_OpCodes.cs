// Copyright (c) 2012 DotNetAnywhere
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace DnaUnity
{

    public enum OpCodes : uint
    {
        NOP           = 0x00,

        LDARG_0       = 0x02,
        LDARG_1       = 0x03,
        LDARG_2       = 0x04,
        LDARG_3       = 0x05,
        LDLOC_0       = 0x06,
        LDLOC_1       = 0x07,
        LDLOC_2       = 0x08,
        LDLOC_3       = 0x09,
        STLOC_0       = 0x0a,
        STLOC_1       = 0x0b,
        STLOC_2       = 0x0c,
        STLOC_3       = 0x0d,
        LDARG_S       = 0x0e,
        LDARGA_S      = 0x0f,
        STARG_S       = 0x10,
        LDLOC_S       = 0x11,
        LDLOCA_S      = 0x12,
        STLOC_S       = 0x13,
        LDNULL        = 0x14,
        LDC_I4_M1     = 0x15,
        LDC_I4_0      = 0x16,
        LDC_I4_1      = 0x17,
        LDC_I4_2      = 0x18,
        LDC_I4_3      = 0x19,
        LDC_I4_4      = 0x1a,
        LDC_I4_5      = 0x1b,
        LDC_I4_6      = 0x1c,
        LDC_I4_7      = 0x1d,
        LDC_I4_8      = 0x1e,
        LDC_I4_S      = 0x1f,
        LDC_I4        = 0x20,
        LDC_I8        = 0x21,
        LDC_R4        = 0x22,
        LDC_R8        = 0x23,

        DUP           = 0x25,
        POP           = 0x26,

        CALL          = 0x28,

        RET           = 0x2a,
        BR_S          = 0x2b,
        BRFALSE_S     = 0x2c,
        BRTRUE_S      = 0x2d,
        BEQ_S         = 0x2e,
        BGE_S         = 0x2f,
        BGT_S         = 0x30,
        BLE_S         = 0x31,
        BLT_S         = 0x32,
        BNE_UN_S      = 0x33,
        BGE_UN_S      = 0x34,
        BGT_UN_S      = 0x35,
        BLE_UN_S      = 0x36,
        BLT_UN_S      = 0x37,
        BR            = 0x38,
        BRFALSE       = 0x39,
        BRTRUE        = 0x3a,
        BEQ           = 0x3b,
        BGE           = 0x3c,
        BGT           = 0x3d,
        BLE           = 0x3e,
        BLT           = 0x3f,
        BNE_UN        = 0x40,
        BGE_UN        = 0x41,
        BGT_UN        = 0x42,
        BLE_UN        = 0x43,
        BLT_UN        = 0x44,
        SWITCH        = 0x45,
        LDIND_I1      = 0x46,
        LDIND_U1      = 0x47,
        LDIND_I2      = 0x48,
        LDIND_U2      = 0x49,
        LDIND_I4      = 0x4a,
        LDIND_U4      = 0x4b,
        LDIND_I8      = 0x4c,
        LDIND_I       = 0x4d,
        LDIND_R4      = 0x4e,
        LDIND_R8      = 0x4f,
        LDIND_REF     = 0x50,
        STIND_REF     = 0x51,
        STIND_I1      = 0x52,
        STIND_I2      = 0x53,
        STIND_I4      = 0x54,

        ADD           = 0x58,
        SUB           = 0x59,
        MUL           = 0x5a,
        DIV           = 0x5b,
        DIV_UN        = 0x5c,
        REM           = 0x5d,
        REM_UN        = 0x5e,
        AND           = 0x5f,
        OR            = 0x60,
        XOR           = 0x61,
        SHL           = 0x62,
        SHR           = 0x63,
        SHR_UN        = 0x64,
        NEG           = 0x65,
        NOT           = 0x66,
        CONV_I1       = 0x67,
        CONV_I2       = 0x68,
        CONV_I4       = 0x69,
        CONV_I8       = 0x6a,
        CONV_R4       = 0x6b,
        CONV_R8       = 0x6c,
        CONV_U4       = 0x6d,
        CONV_U8       = 0x6e,
        CALLVIRT      = 0x6f,

        LDOBJ         = 0x71,
        LDSTR         = 0x72,
        NEWOBJ        = 0x73,
        CASTCLASS     = 0x74,
        ISINST        = 0x75,
        CONV_R_UN     = 0x76,

        THROW             = 0x7a,
        LDFLD             = 0x7b,
        LDFLDA            = 0x7c,
        STFLD             = 0x7d,
        LDSFLD            = 0x7e,
        LDSFLDA           = 0x7f,
        STSFLD            = 0x80,
        STOBJ             = 0x81,
        CONV_OVF_I1_UN    = 0x82,
        CONV_OVF_I2_UN    = 0x83,
        CONV_OVF_I4_UN    = 0x84,
        CONV_OVF_I8_UN    = 0x85,
        CONV_OVF_U1_UN    = 0x86,
        CONV_OVF_U2_UN    = 0x87,
        CONV_OVF_U4_UN    = 0x88,
        CONV_OVF_U8_UN    = 0x89,
        CONV_OVF_I_UN     = 0x8a,
        CONV_OVF_U_UN     = 0x8b,
        BOX               = 0x8c,
        NEWARR            = 0x8d,
        LDLEN             = 0x8e,
        LDELEMA           = 0x8f,
        LDELEM_I1         = 0x90,
        LDELEM_U1         = 0x91,
        LDELEM_I2         = 0x92,
        LDELEM_U2         = 0x93,
        LDELEM_I4         = 0x94,
        LDELEM_U4         = 0x95,
        LDELEM_I8         = 0x96,

        LDELEM_R4     = 0x98,
        LDELEM_R8     = 0x99,
        LDELEM_REF    = 0x9a,

        STELEM_I1     = 0x9c,
        STELEM_I2     = 0x9d,
        STELEM_I4     = 0x9e,
        STELEM_I8     = 0x9f,
        STELEM_R4     = 0xa0,
        STELEM_R8     = 0xa1,
        STELEM_REF    = 0xa2,
        LDELEM_ANY    = 0xa3,
        STELEM_ANY    = 0xa4,
        UNBOX_ANY     = 0xa5,

        CONV_OVF_I1   = 0xb3,
        CONV_OVF_U1   = 0xb4,
        CONV_OVF_I2   = 0xb5,
        CONV_OVF_U2   = 0xb6,
        CONV_OVF_I4   = 0xb7,
        CONV_OVF_U4   = 0xb8,
        CONV_OVF_I8   = 0xb9,
        CONV_OVF_U8   = 0xba,

        LDTOKEN       = 0xd0,
        CONV_U2       = 0xd1,
        CONV_U1       = 0xd2,
        CONV_I        = 0xd3,

        ADD_OVF       = 0xd6,
        ADD_OVF_UN    = 0xd7,
        MUL_OVF       = 0xd8,
        MUL_OVF_UN    = 0xd9,
        SUB_OVF       = 0xda,
        SUB_OVF_UN    = 0xdb,
        ENDFINALLY    = 0xdc,
        LEAVE         = 0xdd,
        LEAVE_S       = 0xde,

        CONV_U        = 0xe0,

        EXTENDED      = 0xfe,


        // Extended op-codes

        X_CEQ          = 0x01,
        X_CGT          = 0x02,
        X_CGT_UN       = 0x03,
        X_CLT          = 0x04,
        X_CLT_UN       = 0x05,
        X_LOADFUNCTION = 0x06,

        X_INITOBJ      = 0x15,
        X_CONSTRAINED  = 0x16,

        X_RETHROW      = 0x1a,

        X_READONLY     = 0x1e
    }
}