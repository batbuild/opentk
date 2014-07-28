//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



using System;

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AccumOp : int
    {
        Accum = ((int)0x0100)        ,
        Load = ((int)0x0101)        ,
        Return = ((int)0x0102)        ,
        Mult = ((int)0x0103)        ,
        Add = ((int)0x0104)        ,
    }

    /// <summary>
    /// Used in GL.Apple.FenceSync, GL.Apple.GetInteger64 and 163 other functions
    /// </summary>
    public enum All : int
    {
        False = ((int)0)        ,
        LayoutDefaultIntel = ((int)0)        ,
        NoError = ((int)0)        ,
        None = ((int)0)        ,
        NoneOes = ((int)0)        ,
        Zero = ((int)0)        ,
        Points = ((int)0X0000)        ,
        ClientPixelStoreBit = ((int)0x00000001)        ,
        ColorBufferBit0Qcom = ((int)0x00000001)        ,
        ContextCoreProfileBit = ((int)0x00000001)        ,
        ContextFlagForwardCompatibleBit = ((int)0x00000001)        ,
        CurrentBit = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBitExt = ((int)0x00000001)        ,
        VertexShaderBit = ((int)0x00000001)        ,
        VertexShaderBitExt = ((int)0x00000001)        ,
        ClientVertexArrayBit = ((int)0x00000002)        ,
        ColorBufferBit1Qcom = ((int)0x00000002)        ,
        ContextCompatibilityProfileBit = ((int)0x00000002)        ,
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ContextFlagDebugBitKhr = ((int)0x00000002)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        ElementArrayBarrierBitExt = ((int)0x00000002)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        PointBit = ((int)0x00000002)        ,
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002)        ,
        ColorBufferBit2Qcom = ((int)0x00000004)        ,
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        LineBit = ((int)0x00000004)        ,
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004)        ,
        UniformBarrierBit = ((int)0x00000004)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
        ColorBufferBit3Qcom = ((int)0x00000008)        ,
        PolygonBit = ((int)0x00000008)        ,
        /// </summary>
        QueryDepthBoundsFailEventBitAmd = ((int)0x00000008)        ,
        TessControlShaderBit = ((int)0x00000008)        ,
        TextureFetchBarrierBit = ((int)0x00000008)        ,
        TextureFetchBarrierBitExt = ((int)0x00000008)        ,
        ColorBufferBit4Qcom = ((int)0x00000010)        ,
        PolygonStippleBit = ((int)0x00000010)        ,
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ColorBufferBit5Qcom = ((int)0x00000020)        ,
        ComputeShaderBit = ((int)0x00000020)        ,
        PixelModeBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBitExt = ((int)0x00000020)        ,
        ColorBufferBit6Qcom = ((int)0x00000040)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        CommandBarrierBitExt = ((int)0x00000040)        ,
        LightingBit = ((int)0x00000040)        ,
        ColorBufferBit7Qcom = ((int)0x00000080)        ,
        FogBit = ((int)0x00000080)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        PixelBufferBarrierBitExt = ((int)0x00000080)        ,
        DepthBufferBit = ((int)0x00000100)        ,
        DepthBufferBit0Qcom = ((int)0x00000100)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        TextureUpdateBarrierBitExt = ((int)0x00000100)        ,
        AccumBufferBit = ((int)0x00000200)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        BufferUpdateBarrierBitExt = ((int)0x00000200)        ,
        DepthBufferBit1Qcom = ((int)0x00000200)        ,
        DepthBufferBit2Qcom = ((int)0x00000400)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        FramebufferBarrierBitExt = ((int)0x00000400)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        DepthBufferBit3Qcom = ((int)0x00000800)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        TransformFeedbackBarrierBitExt = ((int)0x00000800)        ,
        ViewportBit = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        AtomicCounterBarrierBitExt = ((int)0x00001000)        ,
        DepthBufferBit4Qcom = ((int)0x00001000)        ,
        TransformBit = ((int)0x00001000)        ,
        DepthBufferBit5Qcom = ((int)0x00002000)        ,
        EnableBit = ((int)0x00002000)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        DepthBufferBit6Qcom = ((int)0x00004000)        ,
        CoverageBufferBitNv = ((int)0x00008000)        ,
        DepthBufferBit7Qcom = ((int)0x00008000)        ,
        HintBit = ((int)0x00008000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        MapReadBit = ((int)0x0001)        ,
        MapReadBitExt = ((int)0x0001)        ,
        Lines = ((int)0X0001)        ,
        EvalBit = ((int)0x00010000)        ,
        StencilBufferBit0Qcom = ((int)0x00010000)        ,
        LineLoop = ((int)0x0002)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapWriteBitExt = ((int)0x0002)        ,
        ListBit = ((int)0x00020000)        ,
        StencilBufferBit1Qcom = ((int)0x00020000)        ,
        LineStrip = ((int)0x0003)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateRangeBitExt = ((int)0x0004)        ,
        Triangles = ((int)0X0004)        ,
        StencilBufferBit2Qcom = ((int)0x00040000)        ,
        TextureBit = ((int)0x00040000)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Quads = ((int)0x0007)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapInvalidateBufferBitExt = ((int)0x0008)        ,
        QuadStrip = ((int)0x0008)        ,
        ScissorBit = ((int)0x00080000)        ,
        StencilBufferBit3Qcom = ((int)0x00080000)        ,
        Polygon = ((int)0x0009)        ,
        LinesAdjacency = ((int)0x000A)        ,
        LinesAdjacencyArb = ((int)0x000A)        ,
        LinesAdjacencyExt = ((int)0x000A)        ,
        LineStripAdjacency = ((int)0x000B)        ,
        LineStripAdjacencyArb = ((int)0x000B)        ,
        LineStripAdjacencyExt = ((int)0x000B)        ,
        TrianglesAdjacency = ((int)0x000C)        ,
        TrianglesAdjacencyArb = ((int)0x000C)        ,
        TrianglesAdjacencyExt = ((int)0x000C)        ,
        TriangleStripAdjacency = ((int)0x000D)        ,
        TriangleStripAdjacencyArb = ((int)0x000D)        ,
        TriangleStripAdjacencyExt = ((int)0x000D)        ,
        Patches = ((int)0x000E)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapFlushExplicitBitExt = ((int)0x0010)        ,
        StencilBufferBit4Qcom = ((int)0x00100000)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        MapUnsynchronizedBitExt = ((int)0x0020)        ,
        StencilBufferBit5Qcom = ((int)0x00200000)        ,
        MapPersistentBit = ((int)0x0040)        ,
        StencilBufferBit6Qcom = ((int)0x00400000)        ,
        MapCoherentBit = ((int)0x0080)        ,
        StencilBufferBit7Qcom = ((int)0x00800000)        ,
        Accum = ((int)0x0100)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        MultisampleBufferBit0Qcom = ((int)0x01000000)        ,
        Load = ((int)0x0101)        ,
        Return = ((int)0x0102)        ,
        Mult = ((int)0x0103)        ,
        Add = ((int)0x0104)        ,
        ClientStorageBit = ((int)0x0200)        ,
        Never = ((int)0x0200)        ,
        MultisampleBufferBit1Qcom = ((int)0x02000000)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        FrontLeft = ((int)0x0400)        ,
        MultisampleBufferBit2Qcom = ((int)0x04000000)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        Left = ((int)0x0406)        ,
        Right = ((int)0x0407)        ,
        FrontAndBack = ((int)0x0408)        ,
        Aux0 = ((int)0x0409)        ,
        Aux1 = ((int)0x040A)        ,
        Aux2 = ((int)0x040B)        ,
        Aux3 = ((int)0x040C)        ,
        InvalidEnum = ((int)0x0500)        ,
        InvalidValue = ((int)0x0501)        ,
        InvalidOperation = ((int)0x0502)        ,
        StackOverflow = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        OutOfMemory = ((int)0x0505)        ,
        InvalidFramebufferOperation = ((int)0x0506)        ,
        InvalidFramebufferOperationExt = ((int)0x0506)        ,
        InvalidFramebufferOperationOes = ((int)0x0506)        ,
        Gl2D = ((int)0x0600)        ,
        Gl3D = ((int)0x0601)        ,
        Gl3DColor = ((int)0x0602)        ,
        Gl3DColorTexture = ((int)0x0603)        ,
        Gl4DColorTexture = ((int)0x0604)        ,
        PassThroughToken = ((int)0x0700)        ,
        PointToken = ((int)0x0701)        ,
        LineToken = ((int)0x0702)        ,
        PolygonToken = ((int)0x0703)        ,
        BitmapToken = ((int)0x0704)        ,
        DrawPixelToken = ((int)0x0705)        ,
        CopyPixelToken = ((int)0x0706)        ,
        LineResetToken = ((int)0x0707)        ,
        Exp = ((int)0x0800)        ,
        MultisampleBufferBit3Qcom = ((int)0x08000000)        ,
        Exp2 = ((int)0x0801)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        Coeff = ((int)0x0A00)        ,
        Order = ((int)0x0A01)        ,
        Domain = ((int)0x0A02)        ,
        CurrentColor = ((int)0x0B00)        ,
        CurrentIndex = ((int)0x0B01)        ,
        CurrentNormal = ((int)0x0B02)        ,
        CurrentTextureCoords = ((int)0x0B03)        ,
        CurrentRasterColor = ((int)0x0B04)        ,
        CurrentRasterIndex = ((int)0x0B05)        ,
        CurrentRasterTextureCoords = ((int)0x0B06)        ,
        CurrentRasterPosition = ((int)0x0B07)        ,
        CurrentRasterPositionValid = ((int)0x0B08)        ,
        CurrentRasterDistance = ((int)0x0B09)        ,
        PointSmooth = ((int)0x0B10)        ,
        PointSize = ((int)0x0B11)        ,
        PointSizeRange = ((int)0x0B12)        ,
        SmoothPointSizeRange = ((int)0x0B12)        ,
        PointSizeGranularity = ((int)0x0B13)        ,
        SmoothPointSizeGranularity = ((int)0x0B13)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineWidth = ((int)0x0B21)        ,
        LineWidthRange = ((int)0x0B22)        ,
        SmoothLineWidthRange = ((int)0x0B22)        ,
        LineWidthGranularity = ((int)0x0B23)        ,
        SmoothLineWidthGranularity = ((int)0x0B23)        ,
        LineStipple = ((int)0x0B24)        ,
        LineStipplePattern = ((int)0x0B25)        ,
        LineStippleRepeat = ((int)0x0B26)        ,
        ListMode = ((int)0x0B30)        ,
        MaxListNesting = ((int)0x0B31)        ,
        ListBase = ((int)0x0B32)        ,
        ListIndex = ((int)0x0B33)        ,
        PolygonMode = ((int)0x0B40)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        PolygonStipple = ((int)0x0B42)        ,
        EdgeFlag = ((int)0x0B43)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
        Lighting = ((int)0x0B50)        ,
        LightModelLocalViewer = ((int)0x0B51)        ,
        LightModelTwoSide = ((int)0x0B52)        ,
        LightModelAmbient = ((int)0x0B53)        ,
        ShadeModel = ((int)0x0B54)        ,
        ColorMaterialFace = ((int)0x0B55)        ,
        ColorMaterialParameter = ((int)0x0B56)        ,
        ColorMaterial = ((int)0x0B57)        ,
        Fog = ((int)0x0B60)        ,
        FogIndex = ((int)0x0B61)        ,
        FogDensity = ((int)0x0B62)        ,
        FogStart = ((int)0x0B63)        ,
        FogEnd = ((int)0x0B64)        ,
        FogMode = ((int)0x0B65)        ,
        FogColor = ((int)0x0B66)        ,
        DepthRange = ((int)0x0B70)        ,
        DepthTest = ((int)0x0B71)        ,
        DepthWritemask = ((int)0x0B72)        ,
        DepthClearValue = ((int)0x0B73)        ,
        DepthFunc = ((int)0x0B74)        ,
        AccumClearValue = ((int)0x0B80)        ,
        StencilTest = ((int)0x0B90)        ,
        StencilClearValue = ((int)0x0B91)        ,
        StencilFunc = ((int)0x0B92)        ,
        StencilValueMask = ((int)0x0B93)        ,
        StencilFail = ((int)0x0B94)        ,
        StencilPassDepthFail = ((int)0x0B95)        ,
        StencilPassDepthPass = ((int)0x0B96)        ,
        StencilRef = ((int)0x0B97)        ,
        StencilWritemask = ((int)0x0B98)        ,
        MatrixMode = ((int)0x0BA0)        ,
        Normalize = ((int)0x0BA1)        ,
        Viewport = ((int)0x0BA2)        ,
        Modelview0StackDepthExt = ((int)0x0BA3)        ,
        ModelviewStackDepth = ((int)0x0BA3)        ,
        ProjectionStackDepth = ((int)0x0BA4)        ,
        TextureStackDepth = ((int)0x0BA5)        ,
        Modelview0MatrixExt = ((int)0x0BA6)        ,
        ModelviewMatrix = ((int)0x0BA6)        ,
        ProjectionMatrix = ((int)0x0BA7)        ,
        TextureMatrix = ((int)0x0BA8)        ,
        AttribStackDepth = ((int)0x0BB0)        ,
        ClientAttribStackDepth = ((int)0x0BB1)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestQcom = ((int)0x0BC0)        ,
        AlphaTestFunc = ((int)0x0BC1)        ,
        AlphaTestFuncQcom = ((int)0x0BC1)        ,
        AlphaTestRef = ((int)0x0BC2)        ,
        AlphaTestRefQcom = ((int)0x0BC2)        ,
        Dither = ((int)0x0BD0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        IndexLogicOp = ((int)0x0BF1)        ,
        LogicOp = ((int)0x0BF1)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        AuxBuffers = ((int)0x0C00)        ,
        DrawBuffer = ((int)0x0C01)        ,
        DrawBufferExt = ((int)0x0C01)        ,
        ReadBuffer = ((int)0x0C02)        ,
        ReadBufferExt = ((int)0x0C02)        ,
        ReadBufferNv = ((int)0x0C02)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        IndexClearValue = ((int)0x0C20)        ,
        IndexWritemask = ((int)0x0C21)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        IndexMode = ((int)0x0C30)        ,
        RgbaMode = ((int)0x0C31)        ,
        Doublebuffer = ((int)0x0C32)        ,
        Stereo = ((int)0x0C33)        ,
        RenderMode = ((int)0x0C40)        ,
        PerspectiveCorrectionHint = ((int)0x0C50)        ,
        PointSmoothHint = ((int)0x0C51)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        PolygonSmoothHint = ((int)0x0C53)        ,
        FogHint = ((int)0x0C54)        ,
        TextureGenS = ((int)0x0C60)        ,
        TextureGenT = ((int)0x0C61)        ,
        TextureGenR = ((int)0x0C62)        ,
        TextureGenQ = ((int)0x0C63)        ,
        PixelMapIToI = ((int)0x0C70)        ,
        PixelMapSToS = ((int)0x0C71)        ,
        PixelMapIToR = ((int)0x0C72)        ,
        PixelMapIToG = ((int)0x0C73)        ,
        PixelMapIToB = ((int)0x0C74)        ,
        PixelMapIToA = ((int)0x0C75)        ,
        PixelMapRToR = ((int)0x0C76)        ,
        PixelMapGToG = ((int)0x0C77)        ,
        PixelMapBToB = ((int)0x0C78)        ,
        PixelMapAToA = ((int)0x0C79)        ,
        PixelMapIToISize = ((int)0x0CB0)        ,
        PixelMapSToSSize = ((int)0x0CB1)        ,
        PixelMapIToRSize = ((int)0x0CB2)        ,
        PixelMapIToGSize = ((int)0x0CB3)        ,
        PixelMapIToBSize = ((int)0x0CB4)        ,
        PixelMapIToASize = ((int)0x0CB5)        ,
        PixelMapRToRSize = ((int)0x0CB6)        ,
        PixelMapGToGSize = ((int)0x0CB7)        ,
        PixelMapBToBSize = ((int)0x0CB8)        ,
        PixelMapAToASize = ((int)0x0CB9)        ,
        UnpackSwapBytes = ((int)0x0CF0)        ,
        UnpackLsbFirst = ((int)0x0CF1)        ,
        UnpackRowLength = ((int)0x0CF2)        ,
        UnpackRowLengthExt = ((int)0x0CF2)        ,
        UnpackSkipRows = ((int)0x0CF3)        ,
        UnpackSkipRowsExt = ((int)0x0CF3)        ,
        UnpackSkipPixels = ((int)0x0CF4)        ,
        UnpackSkipPixelsExt = ((int)0x0CF4)        ,
        UnpackAlignment = ((int)0x0CF5)        ,
        PackSwapBytes = ((int)0x0D00)        ,
        PackLsbFirst = ((int)0x0D01)        ,
        PackRowLength = ((int)0x0D02)        ,
        PackSkipRows = ((int)0x0D03)        ,
        PackSkipPixels = ((int)0x0D04)        ,
        PackAlignment = ((int)0x0D05)        ,
        MapColor = ((int)0x0D10)        ,
        MapStencil = ((int)0x0D11)        ,
        IndexShift = ((int)0x0D12)        ,
        IndexOffset = ((int)0x0D13)        ,
        RedScale = ((int)0x0D14)        ,
        RedBias = ((int)0x0D15)        ,
        ZoomX = ((int)0x0D16)        ,
        ZoomY = ((int)0x0D17)        ,
        GreenScale = ((int)0x0D18)        ,
        GreenBias = ((int)0x0D19)        ,
        BlueScale = ((int)0x0D1A)        ,
        BlueBias = ((int)0x0D1B)        ,
        AlphaScale = ((int)0x0D1C)        ,
        AlphaBias = ((int)0x0D1D)        ,
        DepthScale = ((int)0x0D1E)        ,
        DepthBias = ((int)0x0D1F)        ,
        MaxEvalOrder = ((int)0x0D30)        ,
        MaxLights = ((int)0x0D31)        ,
        MaxClipDistances = ((int)0x0D32)        ,
        MaxClipPlanes = ((int)0x0D32)        ,
        MaxClipPlanesImg = ((int)0x0D32)        ,
        MaxTextureSize = ((int)0x0D33)        ,
        MaxPixelMapTable = ((int)0x0D34)        ,
        MaxAttribStackDepth = ((int)0x0D35)        ,
        MaxModelviewStackDepth = ((int)0x0D36)        ,
        MaxNameStackDepth = ((int)0x0D37)        ,
        MaxProjectionStackDepth = ((int)0x0D38)        ,
        MaxTextureStackDepth = ((int)0x0D39)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        MaxClientAttribStackDepth = ((int)0x0D3B)        ,
        SubpixelBits = ((int)0x0D50)        ,
        IndexBits = ((int)0x0D51)        ,
        RedBits = ((int)0x0D52)        ,
        GreenBits = ((int)0x0D53)        ,
        BlueBits = ((int)0x0D54)        ,
        AlphaBits = ((int)0x0D55)        ,
        DepthBits = ((int)0x0D56)        ,
        StencilBits = ((int)0x0D57)        ,
        AccumRedBits = ((int)0x0D58)        ,
        AccumGreenBits = ((int)0x0D59)        ,
        AccumBlueBits = ((int)0x0D5A)        ,
        AccumAlphaBits = ((int)0x0D5B)        ,
        NameStackDepth = ((int)0x0D70)        ,
        AutoNormal = ((int)0x0D80)        ,
        Map1Color4 = ((int)0x0D90)        ,
        Map1Index = ((int)0x0D91)        ,
        Map1Normal = ((int)0x0D92)        ,
        Map1TextureCoord1 = ((int)0x0D93)        ,
        Map1TextureCoord2 = ((int)0x0D94)        ,
        Map1TextureCoord3 = ((int)0x0D95)        ,
        Map1TextureCoord4 = ((int)0x0D96)        ,
        Map1Vertex3 = ((int)0x0D97)        ,
        Map1Vertex4 = ((int)0x0D98)        ,
        Map2Color4 = ((int)0x0DB0)        ,
        Map2Index = ((int)0x0DB1)        ,
        Map2Normal = ((int)0x0DB2)        ,
        Map2TextureCoord1 = ((int)0x0DB3)        ,
        Map2TextureCoord2 = ((int)0x0DB4)        ,
        Map2TextureCoord3 = ((int)0x0DB5)        ,
        Map2TextureCoord4 = ((int)0x0DB6)        ,
        Map2Vertex3 = ((int)0x0DB7)        ,
        Map2Vertex4 = ((int)0x0DB8)        ,
        Map1GridDomain = ((int)0x0DD0)        ,
        Map1GridSegments = ((int)0x0DD1)        ,
        Map2GridDomain = ((int)0x0DD2)        ,
        Map2GridSegments = ((int)0x0DD3)        ,
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        FeedbackBufferPointer = ((int)0x0DF0)        ,
        FeedbackBufferSize = ((int)0x0DF1)        ,
        FeedbackBufferType = ((int)0x0DF2)        ,
        SelectionBufferPointer = ((int)0x0DF3)        ,
        SelectionBufferSize = ((int)0x0DF4)        ,
        TextureWidth = ((int)0x1000)        ,
        MultisampleBufferBit4Qcom = ((int)0x10000000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureComponents = ((int)0x1003)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
        TextureBorderColorNv = ((int)0x1004)        ,
        TextureBorder = ((int)0x1005)        ,
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0x1101)        ,
        Nicest = ((int)0x1102)        ,
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Position = ((int)0x1203)        ,
        SpotDirection = ((int)0x1204)        ,
        SpotExponent = ((int)0x1205)        ,
        SpotCutoff = ((int)0x1206)        ,
        ConstantAttenuation = ((int)0x1207)        ,
        LinearAttenuation = ((int)0x1208)        ,
        QuadraticAttenuation = ((int)0x1209)        ,
        Compile = ((int)0x1300)        ,
        CompileAndExecute = ((int)0x1301)        ,
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Gl2Bytes = ((int)0x1407)        ,
        Gl3Bytes = ((int)0x1408)        ,
        Gl4Bytes = ((int)0x1409)        ,
        Double = ((int)0x140A)        ,
        Fixed = ((int)0x140C)        ,
        FixedOes = ((int)0x140C)        ,
        Clear = ((int)0x1500)        ,
        And = ((int)0x1501)        ,
        AndReverse = ((int)0x1502)        ,
        Copy = ((int)0x1503)        ,
        AndInverted = ((int)0x1504)        ,
        Noop = ((int)0x1505)        ,
        Xor = ((int)0x1506)        ,
        Or = ((int)0x1507)        ,
        Nor = ((int)0x1508)        ,
        Equiv = ((int)0x1509)        ,
        Invert = ((int)0x150A)        ,
        OrReverse = ((int)0x150B)        ,
        CopyInverted = ((int)0x150C)        ,
        OrInverted = ((int)0x150D)        ,
        Nand = ((int)0x150E)        ,
        Set = ((int)0x150F)        ,
        Emission = ((int)0x1600)        ,
        Shininess = ((int)0x1601)        ,
        AmbientAndDiffuse = ((int)0x1602)        ,
        ColorIndexes = ((int)0x1603)        ,
        Modelview = ((int)0x1700)        ,
        Modelview0Ext = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
        ColorExt = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        DepthExt = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        StencilExt = ((int)0x1802)        ,
        ColorIndex = ((int)0x1900)        ,
        StencilIndex = ((int)0x1901)        ,
        DepthComponent = ((int)0x1902)        ,
        Red = ((int)0x1903)        ,
        RedExt = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        Bitmap = ((int)0x1A00)        ,
        PreferDoublebufferHintPgi = ((int)0x1A1F8)        ,
        ConserveMemoryHintPgi = ((int)0x1A1FD)        ,
        ReclaimMemoryHintPgi = ((int)0x1A1FE)        ,
        NativeGraphicsBeginHintPgi = ((int)0x1A203)        ,
        NativeGraphicsEndHintPgi = ((int)0x1A204)        ,
        AlwaysFastHintPgi = ((int)0x1A20C)        ,
        AlwaysSoftHintPgi = ((int)0x1A20D)        ,
        AllowDrawObjHintPgi = ((int)0x1A20E)        ,
        AllowDrawWinHintPgi = ((int)0x1A20F)        ,
        AllowDrawFrgHintPgi = ((int)0x1A210)        ,
        AllowDrawMemHintPgi = ((int)0x1A211)        ,
        StrictDepthfuncHintPgi = ((int)0x1A216)        ,
        StrictLightingHintPgi = ((int)0x1A217)        ,
        StrictScissorHintPgi = ((int)0x1A218)        ,
        FullStippleHintPgi = ((int)0x1A219)        ,
        ClipNearHintPgi = ((int)0x1A220)        ,
        ClipFarHintPgi = ((int)0x1A221)        ,
        WideLineHintPgi = ((int)0x1A222)        ,
        BackNormalsHintPgi = ((int)0x1A223)        ,
        VertexDataHintPgi = ((int)0x1A22A)        ,
        VertexConsistentHintPgi = ((int)0x1A22B)        ,
        MaterialSideHintPgi = ((int)0x1A22C)        ,
        MaxVertexHintPgi = ((int)0x1A22D)        ,
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
        Fill = ((int)0x1B02)        ,
        Render = ((int)0x1C00)        ,
        Feedback = ((int)0x1C01)        ,
        Select = ((int)0x1C02)        ,
        Flat = ((int)0x1D00)        ,
        Smooth = ((int)0x1D01)        ,
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
        Vendor = ((int)0x1F00)        ,
        Renderer = ((int)0x1F01)        ,
        Version = ((int)0x1F02)        ,
        Extensions = ((int)0x1F03)        ,
        S = ((int)0x2000)        ,
        MultisampleBit = ((int)0x20000000)        ,
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleBitExt = ((int)0x20000000)        ,
        MultisampleBufferBit5Qcom = ((int)0x20000000)        ,
        T = ((int)0x2001)        ,
        R = ((int)0x2002)        ,
        Q = ((int)0x2003)        ,
        Modulate = ((int)0x2100)        ,
        Decal = ((int)0x2101)        ,
        TextureEnvMode = ((int)0x2200)        ,
        TextureEnvColor = ((int)0x2201)        ,
        TextureEnv = ((int)0x2300)        ,
        EyeLinear = ((int)0x2400)        ,
        ObjectLinear = ((int)0x2401)        ,
        SphereMap = ((int)0x2402)        ,
        TextureGenMode = ((int)0x2500)        ,
        TextureGenModeOes = ((int)0x2500)        ,
        ObjectPlane = ((int)0x2501)        ,
        EyePlane = ((int)0x2502)        ,
        Nearest = ((int)0x2600)        ,
        Linear = ((int)0x2601)        ,
        NearestMipmapNearest = ((int)0x2700)        ,
        LinearMipmapNearest = ((int)0x2701)        ,
        NearestMipmapLinear = ((int)0x2702)        ,
        LinearMipmapLinear = ((int)0x2703)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        Clamp = ((int)0x2900)        ,
        Repeat = ((int)0x2901)        ,
        PolygonOffsetUnits = ((int)0x2A00)        ,
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
        R3G3B2 = ((int)0x2A10)        ,
        V2f = ((int)0x2A20)        ,
        V3f = ((int)0x2A21)        ,
        C4ubV2f = ((int)0x2A22)        ,
        C4ubV3f = ((int)0x2A23)        ,
        C3fV3f = ((int)0x2A24)        ,
        N3fV3f = ((int)0x2A25)        ,
        C4fN3fV3f = ((int)0x2A26)        ,
        T2fV3f = ((int)0x2A27)        ,
        T4fV4f = ((int)0x2A28)        ,
        T2fC4ubV3f = ((int)0x2A29)        ,
        T2fC3fV3f = ((int)0x2A2A)        ,
        T2fN3fV3f = ((int)0x2A2B)        ,
        T2fC4fN3fV3f = ((int)0x2A2C)        ,
        T4fC4fN3fV4f = ((int)0x2A2D)        ,
        ClipDistance0 = ((int)0x3000)        ,
        ClipPlane0 = ((int)0x3000)        ,
        ClipPlane0Img = ((int)0x3000)        ,
        ClipDistance1 = ((int)0x3001)        ,
        ClipPlane1 = ((int)0x3001)        ,
        ClipPlane1Img = ((int)0x3001)        ,
        ClipDistance2 = ((int)0x3002)        ,
        ClipPlane2 = ((int)0x3002)        ,
        ClipPlane2Img = ((int)0x3002)        ,
        ClipDistance3 = ((int)0x3003)        ,
        ClipPlane3 = ((int)0x3003)        ,
        ClipPlane3Img = ((int)0x3003)        ,
        ClipDistance4 = ((int)0x3004)        ,
        ClipPlane4 = ((int)0x3004)        ,
        ClipPlane4Img = ((int)0x3004)        ,
        ClipDistance5 = ((int)0x3005)        ,
        ClipPlane5 = ((int)0x3005)        ,
        ClipPlane5Img = ((int)0x3005)        ,
        ClipDistance6 = ((int)0x3006)        ,
        ClipDistance7 = ((int)0x3007)        ,
        Light0 = ((int)0x4000)        ,
        MultisampleBufferBit6Qcom = ((int)0x40000000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        AbgrExt = ((int)0x8000)        ,
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000)        ,
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        BlendColorExt = ((int)0x8005)        ,
        FuncAddExt = ((int)0x8006)        ,
        FuncAddOes = ((int)0x8006)        ,
        MinExt = ((int)0x8007)        ,
        MaxExt = ((int)0x8008)        ,
        BlendEquationExt = ((int)0x8009)        ,
        BlendEquationOes = ((int)0x8009)        ,
        BlendEquationRgbOes = ((int)0x8009)        ,
        FuncSubtractExt = ((int)0x800A)        ,
        FuncSubtractOes = ((int)0x800A)        ,
        FuncReverseSubtractExt = ((int)0x800B)        ,
        FuncReverseSubtractOes = ((int)0x800B)        ,
        CmykExt = ((int)0x800C)        ,
        CmykaExt = ((int)0x800D)        ,
        PackCmykHintExt = ((int)0x800E)        ,
        UnpackCmykHintExt = ((int)0x800F)        ,
        Convolution1D = ((int)0x8010)        ,
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2D = ((int)0x8011)        ,
        Convolution2DExt = ((int)0x8011)        ,
        Separable2D = ((int)0x8012)        ,
        Separable2DExt = ((int)0x8012)        ,
        ConvolutionBorderMode = ((int)0x8013)        ,
        ConvolutionBorderModeExt = ((int)0x8013)        ,
        ConvolutionFilterScale = ((int)0x8014)        ,
        ConvolutionFilterScaleExt = ((int)0x8014)        ,
        ConvolutionFilterBias = ((int)0x8015)        ,
        ConvolutionFilterBiasExt = ((int)0x8015)        ,
        Reduce = ((int)0x8016)        ,
        ReduceExt = ((int)0x8016)        ,
        ConvolutionFormatExt = ((int)0x8017)        ,
        ConvolutionWidthExt = ((int)0x8018)        ,
        ConvolutionHeightExt = ((int)0x8019)        ,
        MaxConvolutionWidthExt = ((int)0x801A)        ,
        MaxConvolutionHeightExt = ((int)0x801B)        ,
        PostConvolutionRedScale = ((int)0x801C)        ,
        PostConvolutionRedScaleExt = ((int)0x801C)        ,
        PostConvolutionGreenScale = ((int)0x801D)        ,
        PostConvolutionGreenScaleExt = ((int)0x801D)        ,
        PostConvolutionBlueScale = ((int)0x801E)        ,
        PostConvolutionBlueScaleExt = ((int)0x801E)        ,
        PostConvolutionAlphaScale = ((int)0x801F)        ,
        PostConvolutionAlphaScaleExt = ((int)0x801F)        ,
        PostConvolutionRedBias = ((int)0x8020)        ,
        PostConvolutionRedBiasExt = ((int)0x8020)        ,
        PostConvolutionGreenBias = ((int)0x8021)        ,
        PostConvolutionGreenBiasExt = ((int)0x8021)        ,
        PostConvolutionBlueBias = ((int)0x8022)        ,
        PostConvolutionBlueBiasExt = ((int)0x8022)        ,
        PostConvolutionAlphaBias = ((int)0x8023)        ,
        PostConvolutionAlphaBiasExt = ((int)0x8023)        ,
        Histogram = ((int)0x8024)        ,
        HistogramExt = ((int)0x8024)        ,
        ProxyHistogram = ((int)0x8025)        ,
        ProxyHistogramExt = ((int)0x8025)        ,
        HistogramWidthExt = ((int)0x8026)        ,
        HistogramFormatExt = ((int)0x8027)        ,
        HistogramRedSizeExt = ((int)0x8028)        ,
        HistogramGreenSizeExt = ((int)0x8029)        ,
        HistogramBlueSizeExt = ((int)0x802A)        ,
        HistogramAlphaSizeExt = ((int)0x802B)        ,
        HistogramLuminanceSizeExt = ((int)0x802C)        ,
        HistogramSinkExt = ((int)0x802D)        ,
        Minmax = ((int)0x802E)        ,
        MinmaxExt = ((int)0x802E)        ,
        MinmaxFormat = ((int)0x802F)        ,
        MinmaxFormatExt = ((int)0x802F)        ,
        MinmaxSink = ((int)0x8030)        ,
        MinmaxSinkExt = ((int)0x8030)        ,
        TableTooLarge = ((int)0x8031)        ,
        TableTooLargeExt = ((int)0x8031)        ,
        UnsignedByte332 = ((int)0x8032)        ,
        UnsignedByte332Ext = ((int)0x8032)        ,
        UnsignedShort4444 = ((int)0x8033)        ,
        UnsignedShort4444Ext = ((int)0x8033)        ,
        UnsignedShort5551 = ((int)0x8034)        ,
        UnsignedShort5551Ext = ((int)0x8034)        ,
        UnsignedInt8888 = ((int)0x8035)        ,
        UnsignedInt8888Ext = ((int)0x8035)        ,
        UnsignedInt1010102 = ((int)0x8036)        ,
        UnsignedInt1010102Ext = ((int)0x8036)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
        PolygonOffsetBiasExt = ((int)0x8039)        ,
        RescaleNormal = ((int)0x803A)        ,
        RescaleNormalExt = ((int)0x803A)        ,
        Alpha4 = ((int)0x803B)        ,
        Alpha8 = ((int)0x803C)        ,
        Alpha8Ext = ((int)0x803C)        ,
        Alpha8Oes = ((int)0x803C)        ,
        Alpha12 = ((int)0x803D)        ,
        Alpha16 = ((int)0x803E)        ,
        Luminance4 = ((int)0x803F)        ,
        Luminance8 = ((int)0x8040)        ,
        Luminance8Ext = ((int)0x8040)        ,
        Luminance8Oes = ((int)0x8040)        ,
        Luminance12 = ((int)0x8041)        ,
        Luminance16 = ((int)0x8042)        ,
        Luminance4Alpha4 = ((int)0x8043)        ,
        Luminance4Alpha4Oes = ((int)0x8043)        ,
        Luminance6Alpha2 = ((int)0x8044)        ,
        Luminance8Alpha8 = ((int)0x8045)        ,
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        Luminance8Alpha8Oes = ((int)0x8045)        ,
        Luminance12Alpha4 = ((int)0x8046)        ,
        Luminance12Alpha12 = ((int)0x8047)        ,
        Luminance16Alpha16 = ((int)0x8048)        ,
        Intensity = ((int)0x8049)        ,
        Intensity4 = ((int)0x804A)        ,
        Intensity8 = ((int)0x804B)        ,
        Intensity12 = ((int)0x804C)        ,
        Intensity16 = ((int)0x804D)        ,
        Rgb2Ext = ((int)0x804E)        ,
        Rgb4 = ((int)0x804F)        ,
        Rgb5 = ((int)0x8050)        ,
        Rgb8 = ((int)0x8051)        ,
        Rgb8Oes = ((int)0x8051)        ,
        Rgb10 = ((int)0x8052)        ,
        Rgb10Ext = ((int)0x8052)        ,
        Rgb12 = ((int)0x8053)        ,
        Rgb16 = ((int)0x8054)        ,
        Rgba2 = ((int)0x8055)        ,
        Rgba4 = ((int)0x8056)        ,
        Rgba4Oes = ((int)0x8056)        ,
        Rgb5A1 = ((int)0x8057)        ,
        Rgb5A1Oes = ((int)0x8057)        ,
        Rgba8 = ((int)0x8058)        ,
        Rgba8Oes = ((int)0x8058)        ,
        Rgb10A2 = ((int)0x8059)        ,
        Rgb10A2Ext = ((int)0x8059)        ,
        Rgba12 = ((int)0x805A)        ,
        Rgba16 = ((int)0x805B)        ,
        TextureRedSize = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        TextureLuminanceSize = ((int)0x8060)        ,
        TextureIntensitySize = ((int)0x8061)        ,
        ReplaceExt = ((int)0x8062)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture1DExt = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        ProxyTexture2DExt = ((int)0x8064)        ,
        TextureTooLargeExt = ((int)0x8065)        ,
        TexturePriority = ((int)0x8066)        ,
        TexturePriorityExt = ((int)0x8066)        ,
        TextureResident = ((int)0x8067)        ,
        TextureBinding1D = ((int)0x8068)        ,
        TextureBinding2D = ((int)0x8069)        ,
        Texture3DBindingExt = ((int)0x806A)        ,
        TextureBinding3D = ((int)0x806A)        ,
        PackSkipImages = ((int)0x806B)        ,
        PackSkipImagesExt = ((int)0x806B)        ,
        PackImageHeight = ((int)0x806C)        ,
        PackImageHeightExt = ((int)0x806C)        ,
        UnpackSkipImages = ((int)0x806D)        ,
        UnpackSkipImagesExt = ((int)0x806D)        ,
        UnpackImageHeight = ((int)0x806E)        ,
        UnpackImageHeightExt = ((int)0x806E)        ,
        Texture3D = ((int)0x806F)        ,
        Texture3DExt = ((int)0x806F)        ,
        Texture3DOes = ((int)0x806F)        ,
        ProxyTexture3D = ((int)0x8070)        ,
        ProxyTexture3DExt = ((int)0x8070)        ,
        TextureDepthExt = ((int)0x8071)        ,
        TextureWrapR = ((int)0x8072)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        TextureWrapROes = ((int)0x8072)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        VertexArraySize = ((int)0x807A)        ,
        VertexArrayType = ((int)0x807B)        ,
        VertexArrayStride = ((int)0x807C)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayType = ((int)0x807E)        ,
        NormalArrayStride = ((int)0x807F)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArraySize = ((int)0x8081)        ,
        ColorArrayType = ((int)0x8082)        ,
        ColorArrayStride = ((int)0x8083)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayType = ((int)0x8085)        ,
        IndexArrayStride = ((int)0x8086)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArraySize = ((int)0x8088)        ,
        TextureCoordArrayType = ((int)0x8089)        ,
        TextureCoordArrayStride = ((int)0x808A)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayStride = ((int)0x808C)        ,
        EdgeFlagArrayCountExt = ((int)0x808D)        ,
        VertexArrayPointer = ((int)0x808E)        ,
        VertexArrayPointerExt = ((int)0x808E)        ,
        NormalArrayPointer = ((int)0x808F)        ,
        NormalArrayPointerExt = ((int)0x808F)        ,
        ColorArrayPointer = ((int)0x8090)        ,
        ColorArrayPointerExt = ((int)0x8090)        ,
        IndexArrayPointer = ((int)0x8091)        ,
        IndexArrayPointerExt = ((int)0x8091)        ,
        TextureCoordArrayPointer = ((int)0x8092)        ,
        TextureCoordArrayPointerExt = ((int)0x8092)        ,
        EdgeFlagArrayPointer = ((int)0x8093)        ,
        EdgeFlagArrayPointerExt = ((int)0x8093)        ,
        InterlaceSgix = ((int)0x8094)        ,
        DetailTexture2DSgis = ((int)0x8095)        ,
        DetailTexture2DBindingSgis = ((int)0x8096)        ,
        LinearDetailSgis = ((int)0x8097)        ,
        LinearDetailAlphaSgis = ((int)0x8098)        ,
        LinearDetailColorSgis = ((int)0x8099)        ,
        DetailTextureLevelSgis = ((int)0x809A)        ,
        DetailTextureModeSgis = ((int)0x809B)        ,
        DetailTextureFuncPointsSgis = ((int)0x809C)        ,
        Multisample = ((int)0x809D)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        Gl1PassExt = ((int)0x80A1)        ,
        Gl1PassSgis = ((int)0x80A1)        ,
        Gl2Pass0Ext = ((int)0x80A2)        ,
        Gl2Pass0Sgis = ((int)0x80A2)        ,
        Gl2Pass1Ext = ((int)0x80A3)        ,
        Gl2Pass1Sgis = ((int)0x80A3)        ,
        Gl4Pass0Ext = ((int)0x80A4)        ,
        Gl4Pass0Sgis = ((int)0x80A4)        ,
        Gl4Pass1Ext = ((int)0x80A5)        ,
        Gl4Pass1Sgis = ((int)0x80A5)        ,
        Gl4Pass2Ext = ((int)0x80A6)        ,
        Gl4Pass2Sgis = ((int)0x80A6)        ,
        Gl4Pass3Ext = ((int)0x80A7)        ,
        Gl4Pass3Sgis = ((int)0x80A7)        ,
        SampleBuffers = ((int)0x80A8)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SamplesSgis = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleMaskValueSgis = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
        SampleMaskInvertSgis = ((int)0x80AB)        ,
        SamplePatternSgis = ((int)0x80AC)        ,
        LinearSharpenSgis = ((int)0x80AD)        ,
        LinearSharpenAlphaSgis = ((int)0x80AE)        ,
        LinearSharpenColorSgis = ((int)0x80AF)        ,
        SharpenTextureFuncPointsSgis = ((int)0x80B0)        ,
        ColorMatrixSgi = ((int)0x80B1)        ,
        ColorMatrixStackDepthSgi = ((int)0x80B2)        ,
        MaxColorMatrixStackDepthSgi = ((int)0x80B3)        ,
        PostColorMatrixRedScale = ((int)0x80B4)        ,
        PostColorMatrixRedScaleSgi = ((int)0x80B4)        ,
        PostColorMatrixGreenScale = ((int)0x80B5)        ,
        PostColorMatrixGreenScaleSgi = ((int)0x80B5)        ,
        PostColorMatrixBlueScale = ((int)0x80B6)        ,
        PostColorMatrixBlueScaleSgi = ((int)0x80B6)        ,
        PostColorMatrixAlphaScale = ((int)0x80B7)        ,
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7)        ,
        PostColorMatrixRedBias = ((int)0x80B8)        ,
        PostColorMatrixRedBiasSgi = ((int)0x80B8)        ,
        PostColorMatrixGreenBias = ((int)0x80B9)        ,
        PostColorMatrixGreenBiasSgi = ((int)0x80B9)        ,
        PostColorMatrixBlueBias = ((int)0x80BA)        ,
        PostColorMatrixBlueBiasSgi = ((int)0x80BA)        ,
        PostColorMatrixAlphaBias = ((int)0x80BB)        ,
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB)        ,
        TextureColorTableSgi = ((int)0x80BC)        ,
        ProxyTextureColorTableSgi = ((int)0x80BD)        ,
        TextureEnvBiasSgix = ((int)0x80BE)        ,
        ShadowAmbientSgix = ((int)0x80BF)        ,
        BlendDstRgbOes = ((int)0x80C8)        ,
        BlendSrcRgbOes = ((int)0x80C9)        ,
        BlendDstAlphaOes = ((int)0x80CA)        ,
        BlendSrcAlphaOes = ((int)0x80CB)        ,
        ColorTable = ((int)0x80D0)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTable = ((int)0x80D1)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTable = ((int)0x80D2)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        ProxyColorTable = ((int)0x80D3)        ,
        ProxyColorTableSgi = ((int)0x80D3)        ,
        ProxyPostConvolutionColorTable = ((int)0x80D4)        ,
        ProxyPostConvolutionColorTableSgi = ((int)0x80D4)        ,
        ProxyPostColorMatrixColorTable = ((int)0x80D5)        ,
        ProxyPostColorMatrixColorTableSgi = ((int)0x80D5)        ,
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableScaleSgi = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
        ColorTableBiasSgi = ((int)0x80D7)        ,
        ColorTableFormatSgi = ((int)0x80D8)        ,
        ColorTableWidthSgi = ((int)0x80D9)        ,
        ColorTableRedSizeSgi = ((int)0x80DA)        ,
        ColorTableGreenSizeSgi = ((int)0x80DB)        ,
        ColorTableBlueSizeSgi = ((int)0x80DC)        ,
        ColorTableAlphaSizeSgi = ((int)0x80DD)        ,
        ColorTableLuminanceSizeSgi = ((int)0x80DE)        ,
        ColorTableIntensitySizeSgi = ((int)0x80DF)        ,
        /// </summary>
        Bgra = ((int)0x80E1)        ,
        BgraExt = ((int)0x80E1)        ,
        BgraImg = ((int)0x80E1)        ,
        PhongHintWin = ((int)0x80EB)        ,
        ClipVolumeClippingHintExt = ((int)0x80F0)        ,
        DualAlpha4Sgis = ((int)0x8110)        ,
        DualAlpha8Sgis = ((int)0x8111)        ,
        DualAlpha12Sgis = ((int)0x8112)        ,
        DualAlpha16Sgis = ((int)0x8113)        ,
        DualLuminance4Sgis = ((int)0x8114)        ,
        DualLuminance8Sgis = ((int)0x8115)        ,
        DualLuminance12Sgis = ((int)0x8116)        ,
        DualLuminance16Sgis = ((int)0x8117)        ,
        DualIntensity4Sgis = ((int)0x8118)        ,
        DualIntensity8Sgis = ((int)0x8119)        ,
        DualIntensity12Sgis = ((int)0x811A)        ,
        DualIntensity16Sgis = ((int)0x811B)        ,
        DualLuminanceAlpha4Sgis = ((int)0x811C)        ,
        DualLuminanceAlpha8Sgis = ((int)0x811D)        ,
        QuadAlpha4Sgis = ((int)0x811E)        ,
        QuadAlpha8Sgis = ((int)0x811F)        ,
        QuadLuminance4Sgis = ((int)0x8120)        ,
        QuadLuminance8Sgis = ((int)0x8121)        ,
        QuadIntensity4Sgis = ((int)0x8122)        ,
        QuadIntensity8Sgis = ((int)0x8123)        ,
        DualTextureSelectSgis = ((int)0x8124)        ,
        QuadTextureSelectSgis = ((int)0x8125)        ,
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMinArb = ((int)0x8126)        ,
        PointSizeMinExt = ((int)0x8126)        ,
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointSizeMaxArb = ((int)0x8127)        ,
        PointSizeMaxExt = ((int)0x8127)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointFadeThresholdSizeArb = ((int)0x8128)        ,
        PointFadeThresholdSizeExt = ((int)0x8128)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationExt = ((int)0x8129)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
        PointDistanceAttenuationArb = ((int)0x8129)        ,
        FogFuncSgis = ((int)0x812A)        ,
        FogFuncPointsSgis = ((int)0x812B)        ,
        MaxFogFuncPointsSgis = ((int)0x812C)        ,
        ClampToBorder = ((int)0x812D)        ,
        ClampToBorderArb = ((int)0x812D)        ,
        ClampToBorderNv = ((int)0x812D)        ,
        ClampToBorderSgis = ((int)0x812D)        ,
        TextureMultiBufferHintSgix = ((int)0x812E)        ,
        ClampToEdge = ((int)0x812F)        ,
        ClampToEdgeSgis = ((int)0x812F)        ,
        PackSkipVolumesSgis = ((int)0x8130)        ,
        PackImageDepthSgis = ((int)0x8131)        ,
        UnpackSkipVolumesSgis = ((int)0x8132)        ,
        UnpackImageDepthSgis = ((int)0x8133)        ,
        Texture4DSgis = ((int)0x8134)        ,
        ProxyTexture4DSgis = ((int)0x8135)        ,
        Texture4DsizeSgis = ((int)0x8136)        ,
        TextureWrapQSgis = ((int)0x8137)        ,
        Max4DTextureSizeSgis = ((int)0x8138)        ,
        PixelTexGenSgix = ((int)0x8139)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMinLodSgis = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureMaxLodSgis = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureBaseLevelSgis = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
        TextureMaxLevelApple = ((int)0x813D)        ,
        TextureMaxLevelSgis = ((int)0x813D)        ,
        PixelTileBestAlignmentSgix = ((int)0x813E)        ,
        PixelTileCacheIncrementSgix = ((int)0x813F)        ,
        PixelTileWidthSgix = ((int)0x8140)        ,
        PixelTileHeightSgix = ((int)0x8141)        ,
        PixelTileGridWidthSgix = ((int)0x8142)        ,
        PixelTileGridHeightSgix = ((int)0x8143)        ,
        PixelTileGridDepthSgix = ((int)0x8144)        ,
        PixelTileCacheSizeSgix = ((int)0x8145)        ,
        Filter4Sgis = ((int)0x8146)        ,
        TextureFilter4SizeSgis = ((int)0x8147)        ,
        SpriteSgix = ((int)0x8148)        ,
        SpriteModeSgix = ((int)0x8149)        ,
        SpriteAxisSgix = ((int)0x814A)        ,
        SpriteTranslationSgix = ((int)0x814B)        ,
        Texture4DBindingSgis = ((int)0x814F)        ,
        LinearClipmapLinearSgix = ((int)0x8170)        ,
        TextureClipmapCenterSgix = ((int)0x8171)        ,
        TextureClipmapFrameSgix = ((int)0x8172)        ,
        TextureClipmapOffsetSgix = ((int)0x8173)        ,
        TextureClipmapVirtualDepthSgix = ((int)0x8174)        ,
        TextureClipmapLodOffsetSgix = ((int)0x8175)        ,
        TextureClipmapDepthSgix = ((int)0x8176)        ,
        MaxClipmapDepthSgix = ((int)0x8177)        ,
        MaxClipmapVirtualDepthSgix = ((int)0x8178)        ,
        PostTextureFilterBiasSgix = ((int)0x8179)        ,
        PostTextureFilterScaleSgix = ((int)0x817A)        ,
        PostTextureFilterBiasRangeSgix = ((int)0x817B)        ,
        PostTextureFilterScaleRangeSgix = ((int)0x817C)        ,
        ReferencePlaneSgix = ((int)0x817D)        ,
        ReferencePlaneEquationSgix = ((int)0x817E)        ,
        IrInstrument1Sgix = ((int)0x817F)        ,
        InstrumentBufferPointerSgix = ((int)0x8180)        ,
        InstrumentMeasurementsSgix = ((int)0x8181)        ,
        ListPrioritySgix = ((int)0x8182)        ,
        CalligraphicFragmentSgix = ((int)0x8183)        ,
        PixelTexGenQCeilingSgix = ((int)0x8184)        ,
        PixelTexGenQRoundSgix = ((int)0x8185)        ,
        PixelTexGenQFloorSgix = ((int)0x8186)        ,
        PixelTexGenAlphaReplaceSgix = ((int)0x8187)        ,
        PixelTexGenAlphaNoReplaceSgix = ((int)0x8188)        ,
        PixelTexGenAlphaLsSgix = ((int)0x8189)        ,
        PixelTexGenAlphaMsSgix = ((int)0x818A)        ,
        FramezoomSgix = ((int)0x818B)        ,
        FramezoomFactorSgix = ((int)0x818C)        ,
        MaxFramezoomFactorSgix = ((int)0x818D)        ,
        TextureLodBiasSSgix = ((int)0x818E)        ,
        TextureLodBiasTSgix = ((int)0x818F)        ,
        TextureLodBiasRSgix = ((int)0x8190)        ,
        GenerateMipmap = ((int)0x8191)        ,
        GenerateMipmapSgis = ((int)0x8191)        ,
        GenerateMipmapHint = ((int)0x8192)        ,
        GenerateMipmapHintSgis = ((int)0x8192)        ,
        GeometryDeformationSgix = ((int)0x8194)        ,
        TextureDeformationSgix = ((int)0x8195)        ,
        DeformationsMaskSgix = ((int)0x8196)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
        TextureCompareSgix = ((int)0x819A)        ,
        TextureCompareOperatorSgix = ((int)0x819B)        ,
        TextureLequalRSgix = ((int)0x819C)        ,
        TextureGequalRSgix = ((int)0x819D)        ,
        DepthComponent16Oes = ((int)0x81A5)        ,
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24Oes = ((int)0x81A6)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32Oes = ((int)0x81A7)        ,
        DepthComponent32Sgix = ((int)0x81A7)        ,
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
        EyeDistanceToPointSgis = ((int)0x81F0)        ,
        ObjectDistanceToPointSgis = ((int)0x81F1)        ,
        EyeDistanceToLineSgis = ((int)0x81F2)        ,
        ObjectDistanceToLineSgis = ((int)0x81F3)        ,
        EyePointSgis = ((int)0x81F4)        ,
        ObjectPointSgis = ((int)0x81F5)        ,
        EyeLineSgis = ((int)0x81F6)        ,
        ObjectLineSgis = ((int)0x81F7)        ,
        LightModelColorControl = ((int)0x81F8)        ,
        LightModelColorControlExt = ((int)0x81F8)        ,
        SingleColor = ((int)0x81F9)        ,
        SingleColorExt = ((int)0x81F9)        ,
        SeparateSpecularColor = ((int)0x81FA)        ,
        SeparateSpecularColorExt = ((int)0x81FA)        ,
        SharedTexturePaletteExt = ((int)0x81FB)        ,
        FramebufferAttachmentColorEncodingExt = ((int)0x8210)        ,
        R8Ext = ((int)0x8229)        ,
        Rg8Ext = ((int)0x822B)        ,
        R16fExt = ((int)0x822D)        ,
        R32fExt = ((int)0x822E)        ,
        Rg16fExt = ((int)0x822F)        ,
        Rg32fExt = ((int)0x8230)        ,
        LoseContextOnResetExt = ((int)0x8252)        ,
        GuiltyContextResetExt = ((int)0x8253)        ,
        InnocentContextResetExt = ((int)0x8254)        ,
        UnknownContextResetExt = ((int)0x8255)        ,
        ResetNotificationStrategyExt = ((int)0x8256)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        NoResetNotificationExt = ((int)0x8261)        ,
        ConvolutionHintSgix = ((int)0x8316)        ,
        AlphaMinSgix = ((int)0x8320)        ,
        AlphaMaxSgix = ((int)0x8321)        ,
        ScalebiasHintSgix = ((int)0x8322)        ,
        AsyncMarkerSgix = ((int)0x8329)        ,
        PixelTexGenModeSgix = ((int)0x832B)        ,
        AsyncHistogramSgix = ((int)0x832C)        ,
        MaxAsyncHistogramSgix = ((int)0x832D)        ,
        PixelTextureSgis = ((int)0x8353)        ,
        PixelFragmentRgbSourceSgis = ((int)0x8354)        ,
        PixelFragmentAlphaSourceSgis = ((int)0x8355)        ,
        LineQualityHintSgix = ((int)0x835B)        ,
        AsyncTexImageSgix = ((int)0x835C)        ,
        AsyncDrawPixelsSgix = ((int)0x835D)        ,
        AsyncReadPixelsSgix = ((int)0x835E)        ,
        MaxAsyncTexImageSgix = ((int)0x835F)        ,
        MaxAsyncDrawPixelsSgix = ((int)0x8360)        ,
        MaxAsyncReadPixelsSgix = ((int)0x8361)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        /// </summary>
        UnsignedShort4444Rev = ((int)0x8365)        ,
        UnsignedShort4444RevExt = ((int)0x8365)        ,
        UnsignedShort4444RevImg = ((int)0x8365)        ,
        /// </summary>
        UnsignedShort1555Rev = ((int)0x8366)        ,
        UnsignedShort1555RevExt = ((int)0x8366)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
        MirroredRepeatOes = ((int)0x8370)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        FragmentLightingSgix = ((int)0x8400)        ,
        FragmentColorMaterialSgix = ((int)0x8401)        ,
        FragmentColorMaterialFaceSgix = ((int)0x8402)        ,
        FragmentColorMaterialParameterSgix = ((int)0x8403)        ,
        MaxFragmentLightsSgix = ((int)0x8404)        ,
        MaxActiveLightsSgix = ((int)0x8405)        ,
        LightEnvModeSgix = ((int)0x8407)        ,
        FragmentLightModelLocalViewerSgix = ((int)0x8408)        ,
        FragmentLightModelTwoSideSgix = ((int)0x8409)        ,
        FragmentLightModelAmbientSgix = ((int)0x840A)        ,
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B)        ,
        FragmentLight0Sgix = ((int)0x840C)        ,
        FragmentLight1Sgix = ((int)0x840D)        ,
        FragmentLight2Sgix = ((int)0x840E)        ,
        FragmentLight3Sgix = ((int)0x840F)        ,
        FragmentLight4Sgix = ((int)0x8410)        ,
        FragmentLight5Sgix = ((int)0x8411)        ,
        FragmentLight6Sgix = ((int)0x8412)        ,
        FragmentLight7Sgix = ((int)0x8413)        ,
        PackResampleSgix = ((int)0x842C)        ,
        UnpackResampleSgix = ((int)0x842D)        ,
        ResampleReplicateSgix = ((int)0x842E)        ,
        ResampleZeroFillSgix = ((int)0x842F)        ,
        ResampleDecimateSgix = ((int)0x8430)        ,
        NearestClipmapNearestSgix = ((int)0x844D)        ,
        NearestClipmapLinearSgix = ((int)0x844E)        ,
        LinearClipmapNearestSgix = ((int)0x844F)        ,
        AliasedPointSizeRange = ((int)0x846D)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
        Texture0 = ((int)0x84C0)        ,
        Texture1 = ((int)0x84C1)        ,
        Texture2 = ((int)0x84C2)        ,
        Texture3 = ((int)0x84C3)        ,
        Texture4 = ((int)0x84C4)        ,
        Texture5 = ((int)0x84C5)        ,
        Texture6 = ((int)0x84C6)        ,
        Texture7 = ((int)0x84C7)        ,
        Texture8 = ((int)0x84C8)        ,
        Texture9 = ((int)0x84C9)        ,
        Texture10 = ((int)0x84CA)        ,
        Texture11 = ((int)0x84CB)        ,
        Texture12 = ((int)0x84CC)        ,
        Texture13 = ((int)0x84CD)        ,
        Texture14 = ((int)0x84CE)        ,
        Texture15 = ((int)0x84CF)        ,
        Texture16 = ((int)0x84D0)        ,
        Texture17 = ((int)0x84D1)        ,
        Texture18 = ((int)0x84D2)        ,
        Texture19 = ((int)0x84D3)        ,
        Texture20 = ((int)0x84D4)        ,
        Texture21 = ((int)0x84D5)        ,
        Texture22 = ((int)0x84D6)        ,
        Texture23 = ((int)0x84D7)        ,
        Texture24 = ((int)0x84D8)        ,
        Texture25 = ((int)0x84D9)        ,
        Texture26 = ((int)0x84DA)        ,
        Texture27 = ((int)0x84DB)        ,
        Texture28 = ((int)0x84DC)        ,
        Texture29 = ((int)0x84DD)        ,
        Texture30 = ((int)0x84DE)        ,
        Texture31 = ((int)0x84DF)        ,
        ActiveTexture = ((int)0x84E0)        ,
        ClientActiveTexture = ((int)0x84E1)        ,
        MaxTextureUnits = ((int)0x84E2)        ,
        Subtract = ((int)0x84E7)        ,
        MaxRenderbufferSizeOes = ((int)0x84E8)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        AllCompletedNv = ((int)0x84F2)        ,
        FenceStatusNv = ((int)0x84F3)        ,
        FenceConditionNv = ((int)0x84F4)        ,
        DepthStencilOes = ((int)0x84F9)        ,
        UnsignedInt248Oes = ((int)0x84FA)        ,
        MaxTextureLodBiasExt = ((int)0x84FD)        ,
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        TextureFilterControlExt = ((int)0x8500)        ,
        TextureLodBiasExt = ((int)0x8501)        ,
        IncrWrapOes = ((int)0x8507)        ,
        DecrWrapOes = ((int)0x8508)        ,
        NormalMapOes = ((int)0x8511)        ,
        ReflectionMapOes = ((int)0x8512)        ,
        TextureCubeMapOes = ((int)0x8513)        ,
        TextureBindingCubeMapOes = ((int)0x8514)        ,
        TextureCubeMapPositiveXOes = ((int)0x8515)        ,
        TextureCubeMapNegativeXOes = ((int)0x8516)        ,
        TextureCubeMapPositiveYOes = ((int)0x8517)        ,
        TextureCubeMapNegativeYOes = ((int)0x8518)        ,
        TextureCubeMapPositiveZOes = ((int)0x8519)        ,
        TextureCubeMapNegativeZOes = ((int)0x851A)        ,
        MaxCubeMapTextureSizeOes = ((int)0x851C)        ,
        VertexArrayStorageHintApple = ((int)0x851F)        ,
        MultisampleFilterHintNv = ((int)0x8534)        ,
        Combine = ((int)0x8570)        ,
        CombineRgb = ((int)0x8571)        ,
        CombineAlpha = ((int)0x8572)        ,
        RgbScale = ((int)0x8573)        ,
        AddSigned = ((int)0x8574)        ,
        Interpolate = ((int)0x8575)        ,
        Constant = ((int)0x8576)        ,
        PrimaryColor = ((int)0x8577)        ,
        Previous = ((int)0x8578)        ,
        Src0Rgb = ((int)0x8580)        ,
        Src1Rgb = ((int)0x8581)        ,
        Src2Rgb = ((int)0x8582)        ,
        Src0Alpha = ((int)0x8588)        ,
        Src1Alpha = ((int)0x8589)        ,
        Src2Alpha = ((int)0x858A)        ,
        Operand0Rgb = ((int)0x8590)        ,
        Operand1Rgb = ((int)0x8591)        ,
        Operand2Rgb = ((int)0x8592)        ,
        Operand0Alpha = ((int)0x8598)        ,
        Operand1Alpha = ((int)0x8599)        ,
        Operand2Alpha = ((int)0x859A)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        PixelSubsample4444Sgix = ((int)0x85A2)        ,
        PixelSubsample2424Sgix = ((int)0x85A3)        ,
        PixelSubsample4242Sgix = ((int)0x85A4)        ,
        TransformHintApple = ((int)0x85B1)        ,
        VertexArrayBindingOes = ((int)0x85B5)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        MaxVertexUnitsOes = ((int)0x86A4)        ,
        WeightArrayTypeOes = ((int)0x86A9)        ,
        WeightArrayStrideOes = ((int)0x86AA)        ,
        WeightArraySizeOes = ((int)0x86AB)        ,
        WeightArrayPointerOes = ((int)0x86AC)        ,
        WeightArrayOes = ((int)0x86AD)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
        Dot3RgbaImg = ((int)0x86AF)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        Gl3DcXAmd = ((int)0x87F9)        ,
        Gl3DcXyAmd = ((int)0x87FA)        ,
        Rgba32fExt = ((int)0x8814)        ,
        Rgb32fExt = ((int)0x8815)        ,
        Alpha32fExt = ((int)0x8816)        ,
        Luminance32fExt = ((int)0x8818)        ,
        LuminanceAlpha32fExt = ((int)0x8819)        ,
        Rgba16fExt = ((int)0x881A)        ,
        Rgb16fExt = ((int)0x881B)        ,
        Alpha16fExt = ((int)0x881C)        ,
        Luminance16fExt = ((int)0x881E)        ,
        LuminanceAlpha16fExt = ((int)0x881F)        ,
        WriteonlyRenderingQcom = ((int)0x8823)        ,
        BlendEquationAlphaOes = ((int)0x883D)        ,
        MatrixPaletteOes = ((int)0x8840)        ,
        MaxPaletteMatricesOes = ((int)0x8842)        ,
        CurrentPaletteMatrixOes = ((int)0x8843)        ,
        MatrixIndexArrayOes = ((int)0x8844)        ,
        MatrixIndexArraySizeOes = ((int)0x8846)        ,
        MatrixIndexArrayTypeOes = ((int)0x8847)        ,
        MatrixIndexArrayStrideOes = ((int)0x8848)        ,
        MatrixIndexArrayPointerOes = ((int)0x8849)        ,
        PointSpriteOes = ((int)0x8861)        ,
        CoordReplaceOes = ((int)0x8862)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexArrayBufferBinding = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        WeightArrayBufferBindingOes = ((int)0x889E)        ,
        WriteOnlyOes = ((int)0x88B9)        ,
        BufferAccessOes = ((int)0x88BB)        ,
        BufferMappedOes = ((int)0x88BC)        ,
        BufferMapPointerOes = ((int)0x88BD)        ,
        StaticDraw = ((int)0x88E4)        ,
        DynamicDraw = ((int)0x88E8)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
        PointSizeArrayTypeOes = ((int)0x898A)        ,
        PointSizeArrayStrideOes = ((int)0x898B)        ,
        PointSizeArrayPointerOes = ((int)0x898C)        ,
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D)        ,
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E)        ,
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F)        ,
        SyncObjectApple = ((int)0x8A53)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintArb = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        Palette4Rgb8Oes = ((int)0x8B90)        ,
        Palette4Rgba8Oes = ((int)0x8B91)        ,
        Palette4R5G6B5Oes = ((int)0x8B92)        ,
        Palette4Rgba4Oes = ((int)0x8B93)        ,
        Palette4Rgb5A1Oes = ((int)0x8B94)        ,
        Palette8Rgb8Oes = ((int)0x8B95)        ,
        Palette8Rgba8Oes = ((int)0x8B96)        ,
        Palette8R5G6B5Oes = ((int)0x8B97)        ,
        Palette8Rgba4Oes = ((int)0x8B98)        ,
        Palette8Rgb5A1Oes = ((int)0x8B99)        ,
        ImplementationColorReadTypeOes = ((int)0x8B9A)        ,
        ImplementationColorReadFormatOes = ((int)0x8B9B)        ,
        PointSizeArrayOes = ((int)0x8B9C)        ,
        TextureCropRectOes = ((int)0x8B9D)        ,
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E)        ,
        PointSizeArrayBufferBindingOes = ((int)0x8B9F)        ,
        TextureWidthQcom = ((int)0x8BD2)        ,
        TextureHeightQcom = ((int)0x8BD3)        ,
        TextureDepthQcom = ((int)0x8BD4)        ,
        TextureInternalFormatQcom = ((int)0x8BD5)        ,
        TextureFormatQcom = ((int)0x8BD6)        ,
        TextureTypeQcom = ((int)0x8BD7)        ,
        TextureImageValidQcom = ((int)0x8BD8)        ,
        TextureNumLevelsQcom = ((int)0x8BD9)        ,
        TextureTargetQcom = ((int)0x8BDA)        ,
        TextureObjectValidQcom = ((int)0x8BDB)        ,
        StateRestore = ((int)0x8BDC)        ,
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)        ,
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)        ,
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)        ,
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)        ,
        ModulateColorImg = ((int)0x8C04)        ,
        RecipAddSignedAlphaImg = ((int)0x8C05)        ,
        TextureAlphaModulateImg = ((int)0x8C06)        ,
        FactorAlphaModulateImg = ((int)0x8C07)        ,
        FragmentAlphaModulateImg = ((int)0x8C08)        ,
        AddBlendImg = ((int)0x8C09)        ,
        SrgbExt = ((int)0x8C40)        ,
        SrgbAlphaExt = ((int)0x8C42)        ,
        Srgb8Alpha8Ext = ((int)0x8C43)        ,
        AtcRgbAmd = ((int)0x8C92)        ,
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
        DrawFramebufferBindingApple = ((int)0x8CA6)        ,
        FramebufferBindingOes = ((int)0x8CA6)        ,
        RenderbufferBindingOes = ((int)0x8CA7)        ,
        ReadFramebufferApple = ((int)0x8CA8)        ,
        DrawFramebufferApple = ((int)0x8CA9)        ,
        ReadFramebufferBindingApple = ((int)0x8CAA)        ,
        RenderbufferSamplesApple = ((int)0x8CAB)        ,
        RenderbufferSamplesExt = ((int)0x8CAB)        ,
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3)        ,
        FramebufferCompleteOes = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9)        ,
        FramebufferIncompleteFormatsOes = ((int)0x8CDA)        ,
        FramebufferUnsupportedOes = ((int)0x8CDD)        ,
        ColorAttachment0Oes = ((int)0x8CE0)        ,
        DepthAttachmentOes = ((int)0x8D00)        ,
        StencilAttachmentOes = ((int)0x8D20)        ,
        FramebufferOes = ((int)0x8D40)        ,
        RenderbufferOes = ((int)0x8D41)        ,
        RenderbufferWidthOes = ((int)0x8D42)        ,
        RenderbufferHeightOes = ((int)0x8D43)        ,
        RenderbufferInternalFormatOes = ((int)0x8D44)        ,
        StencilIndex1Oes = ((int)0x8D46)        ,
        StencilIndex4Oes = ((int)0x8D47)        ,
        StencilIndex8Oes = ((int)0x8D48)        ,
        RenderbufferRedSizeOes = ((int)0x8D50)        ,
        RenderbufferGreenSizeOes = ((int)0x8D51)        ,
        RenderbufferBlueSizeOes = ((int)0x8D52)        ,
        RenderbufferAlphaSizeOes = ((int)0x8D53)        ,
        RenderbufferDepthSizeOes = ((int)0x8D54)        ,
        RenderbufferStencilSizeOes = ((int)0x8D55)        ,
        FramebufferIncompleteMultisampleApple = ((int)0x8D56)        ,
        FramebufferIncompleteMultisampleExt = ((int)0x8D56)        ,
        MaxSamplesApple = ((int)0x8D57)        ,
        MaxSamplesExt = ((int)0x8D57)        ,
        TextureGenStrOes = ((int)0x8D60)        ,
        Rgb565Oes = ((int)0x8D62)        ,
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        TextureExternalOes = ((int)0x8D65)        ,
        SamplerExternalOes = ((int)0x8D66)        ,
        TextureBindingExternalOes = ((int)0x8D67)        ,
        RequiredTextureImageUnitsOes = ((int)0x8D68)        ,
        FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C)        ,
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
        BinningControlHintQcom = ((int)0x8FB0)        ,
        ContextRobustAccessExt = ((int)0x90F3)        ,
        MaxServerWaitTimeoutApple = ((int)0x9111)        ,
        ObjectTypeApple = ((int)0x9112)        ,
        SyncConditionApple = ((int)0x9113)        ,
        SyncStatusApple = ((int)0x9114)        ,
        SyncFlagsApple = ((int)0x9115)        ,
        SyncFenceApple = ((int)0x9116)        ,
        SyncGpuCommandsCompleteApple = ((int)0x9117)        ,
        UnsignaledApple = ((int)0x9118)        ,
        SignaledApple = ((int)0x9119)        ,
        AlreadySignaledApple = ((int)0x911A)        ,
        TimeoutExpiredApple = ((int)0x911B)        ,
        ConditionSatisfiedApple = ((int)0x911C)        ,
        WaitFailedApple = ((int)0x911D)        ,
        TextureImmutableFormatExt = ((int)0x912F)        ,
        RenderbufferSamplesImg = ((int)0x9133)        ,
        FramebufferIncompleteMultisampleImg = ((int)0x9134)        ,
        MaxSamplesImg = ((int)0x9135)        ,
        TextureSamplesImg = ((int)0x9136)        ,
        Bgra8Ext = ((int)0x93A1)        ,
        AllAttribBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED_APPLE = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = ((int)1)        ,
        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = ((int)1)        ,
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = ((int)1)        ,
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1)        ,
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1)        ,
        VersionEsCl10 = ((int)1)        ,
        VersionEsCl11 = ((int)1)        ,
        /// </summary>
        VersionEsCm10 = ((int)1)        ,
        VersionEsCm11 = ((int)1)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
    }

    /// <summary>
    /// Used in GL.AlphaFunc
    /// </summary>
    public enum AlphaFunction : int
    {
        Never = ((int)0x0200)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Amdcompressed3Dctexture : int
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9)        ,
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressed3DcTexture : int
    {
        Gl3DcXAmd = ((int)0x87F9)        ,
        Gl3DcXyAmd = ((int)0x87FA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdcompressedAtctexture : int
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92)        ,
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressedAtcTexture : int
    {
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        AtcRgbAmd = ((int)0x8C92)        ,
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleCopyTextureLevels : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFramebufferMultisample : int
    {
        DrawFramebufferBindingApple = ((int)0x8CA6)        ,
        ReadFramebufferApple = ((int)0x8CA8)        ,
        DrawFramebufferApple = ((int)0x8CA9)        ,
        ReadFramebufferBindingApple = ((int)0x8CAA)        ,
        RenderbufferSamplesApple = ((int)0x8CAB)        ,
        FramebufferIncompleteMultisampleApple = ((int)0x8D56)        ,
        MaxSamplesApple = ((int)0x8D57)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleSync : int
    {
        SyncFlushCommandsBitApple = ((int)0x00000001)        ,
        SyncObjectApple = ((int)0x8A53)        ,
        MaxServerWaitTimeoutApple = ((int)0x9111)        ,
        ObjectTypeApple = ((int)0x9112)        ,
        SyncConditionApple = ((int)0x9113)        ,
        SyncStatusApple = ((int)0x9114)        ,
        SyncFlagsApple = ((int)0x9115)        ,
        SyncFenceApple = ((int)0x9116)        ,
        SyncGpuCommandsCompleteApple = ((int)0x9117)        ,
        UnsignaledApple = ((int)0x9118)        ,
        SignaledApple = ((int)0x9119)        ,
        AlreadySignaledApple = ((int)0x911A)        ,
        TimeoutExpiredApple = ((int)0x911B)        ,
        ConditionSatisfiedApple = ((int)0x911C)        ,
        WaitFailedApple = ((int)0x911D)        ,
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTexture2DLimitedNpot : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureFormatBgra8888 : int
    {
        BgraExt = ((int)0x80E1)        ,
        Bgra8Ext = ((int)0x93A1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureMaxLevel : int
    {
        TextureMaxLevelApple = ((int)0x813D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmRgba8 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum AttribMask : int
    {
        CurrentBit = ((int)0x00000001)        ,
        PointBit = ((int)0x00000002)        ,
        LineBit = ((int)0x00000004)        ,
        PolygonBit = ((int)0x00000008)        ,
        PolygonStippleBit = ((int)0x00000010)        ,
        PixelModeBit = ((int)0x00000020)        ,
        LightingBit = ((int)0x00000040)        ,
        FogBit = ((int)0x00000080)        ,
        DepthBufferBit = ((int)0x00000100)        ,
        AccumBufferBit = ((int)0x00000200)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        ViewportBit = ((int)0x00000800)        ,
        TransformBit = ((int)0x00001000)        ,
        EnableBit = ((int)0x00002000)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        HintBit = ((int)0x00008000)        ,
        EvalBit = ((int)0x00010000)        ,
        ListBit = ((int)0x00020000)        ,
        TextureBit = ((int)0x00040000)        ,
        ScissorBit = ((int)0x00080000)        ,
        MultisampleBit = ((int)0x20000000)        ,
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleBitExt = ((int)0x20000000)        ,
        AllAttribBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements
    /// </summary>
    public enum BeginMode : int
    {
        Points = ((int)0X0000)        ,
        Lines = ((int)0X0001)        ,
        LineLoop = ((int)0X0002)        ,
        LineStrip = ((int)0X0003)        ,
        Triangles = ((int)0X0004)        ,
        TriangleStrip = ((int)0X0005)        ,
        TriangleFan = ((int)0X0006)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BlendEquation
    /// </summary>
    public enum BlendEquationModeExt : int
    {
        LogicOp = ((int)0x0BF1)        ,
        FuncAddExt = ((int)0x8006)        ,
        MinExt = ((int)0x8007)        ,
        MaxExt = ((int)0x8008)        ,
        FuncSubtractExt = ((int)0x800A)        ,
        FuncReverseSubtractExt = ((int)0x800B)        ,
        AlphaMinSgix = ((int)0x8320)        ,
        AlphaMaxSgix = ((int)0x8321)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc
    /// </summary>
    public enum BlendingFactorDest : int
    {
        Zero = ((int)0)        ,
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc
    /// </summary>
    public enum BlendingFactorSrc : int
    {
        Zero = ((int)0)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        One = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Boolean : int
    {
        False = ((int)0)        ,
        True = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferObjects : int
    {
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764)        ,
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895)        ,
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BUFFER_BINDING = 0x8896
        /// </summary>
        VertexArrayBufferBinding = ((int)0x8896)        ,
        /// <summary>
        /// Original was GL_NORMAL_ARRAY_BUFFER_BINDING = 0x8897
        /// </summary>
        NormalArrayBufferBinding = ((int)0x8897)        ,
        /// <summary>
        /// Original was GL_COLOR_ARRAY_BUFFER_BINDING = 0x8898
        /// </summary>
        ColorArrayBufferBinding = ((int)0x8898)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A
        /// </summary>
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4)        ,
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8)        ,
    }

    /// <summary>
    /// Used in GL.Clear
    /// </summary>
    [Flags]
    public enum ClearBufferMask : int
    {
        DepthBufferBit = ((int)0x00000100)        ,
        AccumBufferBit = ((int)0x00000200)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        CoverageBufferBitNv = ((int)0x00008000)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ClientAttribMask : int
    {
        ClientPixelStoreBit = ((int)0x00000001)        ,
        ClientVertexArrayBit = ((int)0x00000002)        ,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipPlaneName : int
    {
        ClipDistance0 = ((int)0x3000)        ,
        ClipPlane0 = ((int)0x3000)        ,
        ClipDistance1 = ((int)0x3001)        ,
        ClipPlane1 = ((int)0x3001)        ,
        ClipDistance2 = ((int)0x3002)        ,
        ClipPlane2 = ((int)0x3002)        ,
        ClipDistance3 = ((int)0x3003)        ,
        ClipPlane3 = ((int)0x3003)        ,
        ClipDistance4 = ((int)0x3004)        ,
        ClipPlane4 = ((int)0x3004)        ,
        ClipDistance5 = ((int)0x3005)        ,
        ClipPlane5 = ((int)0x3005)        ,
        ClipDistance6 = ((int)0x3006)        ,
        ClipDistance7 = ((int)0x3007)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialFace : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorMaterialParameter : int
    {
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Emission = ((int)0x1600)        ,
        AmbientAndDiffuse = ((int)0x1602)        ,
    }

    /// <summary>
    /// Used in GL.ColorPointer
    /// </summary>
    public enum ColorPointerType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableParameterPNameSgi : int
    {
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableScaleSgi = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
        ColorTableBiasSgi = ((int)0x80D7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ColorTableTargetSgi : int
    {
        TextureColorTableSgi = ((int)0x80BC)        ,
        ProxyTextureColorTableSgi = ((int)0x80BD)        ,
        ColorTable = ((int)0x80D0)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTable = ((int)0x80D1)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTable = ((int)0x80D2)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        ProxyColorTable = ((int)0x80D3)        ,
        ProxyColorTableSgi = ((int)0x80D3)        ,
        ProxyPostConvolutionColorTable = ((int)0x80D4)        ,
        ProxyPostConvolutionColorTableSgi = ((int)0x80D4)        ,
        ProxyPostColorMatrixColorTable = ((int)0x80D5)        ,
        ProxyPostColorMatrixColorTableSgi = ((int)0x80D5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ContextFlagMask : int
    {
        ContextFlagForwardCompatibleBit = ((int)0x00000001)        ,
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ContextFlagDebugBitKhr = ((int)0x00000002)        ,
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ContextProfileMask : int
    {
        ContextCoreProfileBit = ((int)0x00000001)        ,
        ContextCompatibilityProfileBit = ((int)0x00000002)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionBorderModeExt : int
    {
        Reduce = ((int)0x8016)        ,
        ReduceExt = ((int)0x8016)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionParameterExt : int
    {
        ConvolutionBorderMode = ((int)0x8013)        ,
        ConvolutionBorderModeExt = ((int)0x8013)        ,
        ConvolutionFilterScale = ((int)0x8014)        ,
        ConvolutionFilterScaleExt = ((int)0x8014)        ,
        ConvolutionFilterBias = ((int)0x8015)        ,
        ConvolutionFilterBiasExt = ((int)0x8015)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ConvolutionTargetExt : int
    {
        Convolution1D = ((int)0x8010)        ,
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2D = ((int)0x8011)        ,
        Convolution2DExt = ((int)0x8011)        ,
    }

    /// <summary>
    /// Used in GL.CullFace
    /// </summary>
    public enum CullFaceMode : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DataType : int
    {
    }

    /// <summary>
    /// Used in GL.DepthFunc
    /// </summary>
    public enum DepthFunction : int
    {
        Never = ((int)0x0200)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DrawBufferMode : int
    {
        None = ((int)0)        ,
        NoneOes = ((int)0)        ,
        FrontLeft = ((int)0x0400)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        Left = ((int)0x0406)        ,
        Right = ((int)0x0407)        ,
        FrontAndBack = ((int)0x0408)        ,
        Aux0 = ((int)0x0409)        ,
        Aux1 = ((int)0x040A)        ,
        Aux2 = ((int)0x040B)        ,
        Aux3 = ((int)0x040C)        ,
    }

    /// <summary>
    /// Used in GL.Disable, GL.DisableClientState and 3 other functions
    /// </summary>
    public enum EnableCap : int
    {
        PointSmooth = ((int)0x0B10)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineStipple = ((int)0x0B24)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        PolygonStipple = ((int)0x0B42)        ,
        CullFace = ((int)0x0B44)        ,
        Lighting = ((int)0x0B50)        ,
        ColorMaterial = ((int)0x0B57)        ,
        Fog = ((int)0x0B60)        ,
        DepthTest = ((int)0x0B71)        ,
        StencilTest = ((int)0x0B90)        ,
        Normalize = ((int)0x0BA1)        ,
        AlphaTest = ((int)0x0BC0)        ,
        Dither = ((int)0x0BD0)        ,
        Blend = ((int)0x0BE2)        ,
        IndexLogicOp = ((int)0x0BF1)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        ScissorTest = ((int)0x0C11)        ,
        TextureGenS = ((int)0x0C60)        ,
        TextureGenT = ((int)0x0C61)        ,
        TextureGenR = ((int)0x0C62)        ,
        TextureGenQ = ((int)0x0C63)        ,
        AutoNormal = ((int)0x0D80)        ,
        Map1Color4 = ((int)0x0D90)        ,
        Map1Index = ((int)0x0D91)        ,
        Map1Normal = ((int)0x0D92)        ,
        Map1TextureCoord1 = ((int)0x0D93)        ,
        Map1TextureCoord2 = ((int)0x0D94)        ,
        Map1TextureCoord3 = ((int)0x0D95)        ,
        Map1TextureCoord4 = ((int)0x0D96)        ,
        Map1Vertex3 = ((int)0x0D97)        ,
        Map1Vertex4 = ((int)0x0D98)        ,
        Map2Color4 = ((int)0x0DB0)        ,
        Map2Index = ((int)0x0DB1)        ,
        Map2Normal = ((int)0x0DB2)        ,
        Map2TextureCoord1 = ((int)0x0DB3)        ,
        Map2TextureCoord2 = ((int)0x0DB4)        ,
        Map2TextureCoord3 = ((int)0x0DB5)        ,
        Map2TextureCoord4 = ((int)0x0DB6)        ,
        Map2Vertex3 = ((int)0x0DB7)        ,
        Map2Vertex4 = ((int)0x0DB8)        ,
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
        ClipPlane0 = ((int)0x3000)        ,
        ClipPlane1 = ((int)0x3001)        ,
        ClipPlane2 = ((int)0x3002)        ,
        ClipPlane3 = ((int)0x3003)        ,
        ClipPlane4 = ((int)0x3004)        ,
        ClipPlane5 = ((int)0x3005)        ,
        Light0 = ((int)0x4000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2DExt = ((int)0x8011)        ,
        Separable2DExt = ((int)0x8012)        ,
        HistogramExt = ((int)0x8024)        ,
        MinmaxExt = ((int)0x802E)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        RescaleNormalExt = ((int)0x803A)        ,
        Texture3DExt = ((int)0x806F)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        InterlaceSgix = ((int)0x8094)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        TextureColorTableSgi = ((int)0x80BC)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        Texture4DSgis = ((int)0x8134)        ,
        PixelTexGenSgix = ((int)0x8139)        ,
        SpriteSgix = ((int)0x8148)        ,
        ReferencePlaneSgix = ((int)0x817D)        ,
        IrInstrument1Sgix = ((int)0x817F)        ,
        CalligraphicFragmentSgix = ((int)0x8183)        ,
        FramezoomSgix = ((int)0x818B)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        SharedTexturePaletteExt = ((int)0x81FB)        ,
        AsyncHistogramSgix = ((int)0x832C)        ,
        PixelTextureSgis = ((int)0x8353)        ,
        AsyncTexImageSgix = ((int)0x835C)        ,
        AsyncDrawPixelsSgix = ((int)0x835D)        ,
        AsyncReadPixelsSgix = ((int)0x835E)        ,
        FragmentLightingSgix = ((int)0x8400)        ,
        FragmentColorMaterialSgix = ((int)0x8401)        ,
        FragmentLight0Sgix = ((int)0x840C)        ,
        FragmentLight1Sgix = ((int)0x840D)        ,
        FragmentLight2Sgix = ((int)0x840E)        ,
        FragmentLight3Sgix = ((int)0x840F)        ,
        FragmentLight4Sgix = ((int)0x8410)        ,
        FragmentLight5Sgix = ((int)0x8411)        ,
        FragmentLight6Sgix = ((int)0x8412)        ,
        FragmentLight7Sgix = ((int)0x8413)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode : int
    {
        NoError = ((int)0)        ,
        InvalidEnum = ((int)0x0500)        ,
        InvalidValue = ((int)0x0501)        ,
        InvalidOperation = ((int)0x0502)        ,
        StackOverflow = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        OutOfMemory = ((int)0x0505)        ,
        InvalidFramebufferOperation = ((int)0x0506)        ,
        InvalidFramebufferOperationExt = ((int)0x0506)        ,
        InvalidFramebufferOperationOes = ((int)0x0506)        ,
        TableTooLarge = ((int)0x8031)        ,
        TableTooLargeExt = ((int)0x8031)        ,
        TextureTooLargeExt = ((int)0x8065)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendMinmax : int
    {
        FuncAddExt = ((int)0x8006)        ,
        MinExt = ((int)0x8007)        ,
        MaxExt = ((int)0x8008)        ,
        BlendEquationExt = ((int)0x8009)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDiscardFramebuffer : int
    {
        ColorExt = ((int)0x1800)        ,
        DepthExt = ((int)0x1801)        ,
        StencilExt = ((int)0x1802)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMapBufferRange : int
    {
        MapReadBitExt = ((int)0x0001)        ,
        MapWriteBitExt = ((int)0x0002)        ,
        MapInvalidateRangeBitExt = ((int)0x0004)        ,
        MapInvalidateBufferBitExt = ((int)0x0008)        ,
        MapFlushExplicitBitExt = ((int)0x0010)        ,
        MapUnsynchronizedBitExt = ((int)0x0020)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultiDrawArrays : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultisampledRenderToTexture : int
    {
        RenderbufferSamplesExt = ((int)0x8CAB)        ,
        FramebufferIncompleteMultisampleExt = ((int)0x8D56)        ,
        MaxSamplesExt = ((int)0x8D57)        ,
        FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtReadFormatBgra : int
    {
        BgraExt = ((int)0x80E1)        ,
        UnsignedShort4444RevExt = ((int)0x8365)        ,
        UnsignedShort1555RevExt = ((int)0x8366)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtRobustness : int
    {
        NoError = ((int)0)        ,
        LoseContextOnResetExt = ((int)0x8252)        ,
        GuiltyContextResetExt = ((int)0x8253)        ,
        InnocentContextResetExt = ((int)0x8254)        ,
        UnknownContextResetExt = ((int)0x8255)        ,
        ResetNotificationStrategyExt = ((int)0x8256)        ,
        NoResetNotificationExt = ((int)0x8261)        ,
        ContextRobustAccessExt = ((int)0x90F3)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSrgb : int
    {
        FramebufferAttachmentColorEncodingExt = ((int)0x8210)        ,
        SrgbExt = ((int)0x8C40)        ,
        SrgbAlphaExt = ((int)0x8C42)        ,
        Srgb8Alpha8Ext = ((int)0x8C43)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionDxt1 : int
    {
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExttextureFilterAnisotropic : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFilterAnisotropic : int
    {
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExttextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFormatBgra8888 : int
    {
        BgraExt = ((int)0x80E1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureLodBias : int
    {
        MaxTextureLodBiasExt = ((int)0x84FD)        ,
        TextureFilterControlExt = ((int)0x8500)        ,
        TextureLodBiasExt = ((int)0x8501)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureStorage : int
    {
        Alpha8Ext = ((int)0x803C)        ,
        Luminance8Ext = ((int)0x8040)        ,
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        Rgb10Ext = ((int)0x8052)        ,
        Rgb10A2Ext = ((int)0x8059)        ,
        R8Ext = ((int)0x8229)        ,
        Rg8Ext = ((int)0x822B)        ,
        R16fExt = ((int)0x822D)        ,
        R32fExt = ((int)0x822E)        ,
        Rg16fExt = ((int)0x822F)        ,
        Rg32fExt = ((int)0x8230)        ,
        Rgba32fExt = ((int)0x8814)        ,
        Rgb32fExt = ((int)0x8815)        ,
        Alpha32fExt = ((int)0x8816)        ,
        Luminance32fExt = ((int)0x8818)        ,
        LuminanceAlpha32fExt = ((int)0x8819)        ,
        Rgba16fExt = ((int)0x881A)        ,
        Rgb16fExt = ((int)0x881B)        ,
        Alpha16fExt = ((int)0x881C)        ,
        Luminance16fExt = ((int)0x881E)        ,
        LuminanceAlpha16fExt = ((int)0x881F)        ,
        TextureImmutableFormatExt = ((int)0x912F)        ,
        Bgra8Ext = ((int)0x93A1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedBackToken : int
    {
        PassThroughToken = ((int)0x0700)        ,
        PointToken = ((int)0x0701)        ,
        LineToken = ((int)0x0702)        ,
        PolygonToken = ((int)0x0703)        ,
        BitmapToken = ((int)0x0704)        ,
        DrawPixelToken = ((int)0x0705)        ,
        CopyPixelToken = ((int)0x0706)        ,
        LineResetToken = ((int)0x0707)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedbackType : int
    {
        Gl2D = ((int)0x0600)        ,
        Gl3D = ((int)0x0601)        ,
        Gl3DColor = ((int)0x0602)        ,
        Gl3DColorTexture = ((int)0x0603)        ,
        Gl4DColorTexture = ((int)0x0604)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum FfdMaskSgix : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FfdTargetSgix : int
    {
        GeometryDeformationSgix = ((int)0x8194)        ,
        TextureDeformationSgix = ((int)0x8195)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogCoordinatePointerType : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406)        ,
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogMode : int
    {
        Exp = ((int)0x0800)        ,
        Exp2 = ((int)0x0801)        ,
        Linear = ((int)0x2601)        ,
        FogFuncSgis = ((int)0x812A)        ,
    }

    /// <summary>
    /// Used in GL.Fog
    /// </summary>
    public enum FogParameter : int
    {
        FogIndex = ((int)0x0B61)        ,
        FogDensity = ((int)0x0B62)        ,
        FogStart = ((int)0x0B63)        ,
        FogEnd = ((int)0x0B64)        ,
        FogMode = ((int)0x0B65)        ,
        FogColor = ((int)0x0B66)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeExt : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406)        ,
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeIbm : int
    {
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406)        ,
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FragmentLightModelParameterSgix : int
    {
        FragmentLightModelLocalViewerSgix = ((int)0x8408)        ,
        FragmentLightModelTwoSideSgix = ((int)0x8409)        ,
        FragmentLightModelAmbientSgix = ((int)0x840A)        ,
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B)        ,
    }

    /// <summary>
    /// Used in GL.FrontFace
    /// </summary>
    public enum FrontFaceDirection : int
    {
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetColorTableParameterPNameSgi : int
    {
        ColorTableScaleSgi = ((int)0x80D6)        ,
        ColorTableBiasSgi = ((int)0x80D7)        ,
        ColorTableFormatSgi = ((int)0x80D8)        ,
        ColorTableWidthSgi = ((int)0x80D9)        ,
        ColorTableRedSizeSgi = ((int)0x80DA)        ,
        ColorTableGreenSizeSgi = ((int)0x80DB)        ,
        ColorTableBlueSizeSgi = ((int)0x80DC)        ,
        ColorTableAlphaSizeSgi = ((int)0x80DD)        ,
        ColorTableLuminanceSizeSgi = ((int)0x80DE)        ,
        ColorTableIntensitySizeSgi = ((int)0x80DF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetConvolutionParameter : int
    {
        ConvolutionBorderModeExt = ((int)0x8013)        ,
        ConvolutionFilterScaleExt = ((int)0x8014)        ,
        ConvolutionFilterBiasExt = ((int)0x8015)        ,
        ConvolutionFormatExt = ((int)0x8017)        ,
        ConvolutionWidthExt = ((int)0x8018)        ,
        ConvolutionHeightExt = ((int)0x8019)        ,
        MaxConvolutionWidthExt = ((int)0x801A)        ,
        MaxConvolutionHeightExt = ((int)0x801B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetHistogramParameterPNameExt : int
    {
        HistogramWidthExt = ((int)0x8026)        ,
        HistogramFormatExt = ((int)0x8027)        ,
        HistogramRedSizeExt = ((int)0x8028)        ,
        HistogramGreenSizeExt = ((int)0x8029)        ,
        HistogramBlueSizeExt = ((int)0x802A)        ,
        HistogramAlphaSizeExt = ((int)0x802B)        ,
        HistogramLuminanceSizeExt = ((int)0x802C)        ,
        HistogramSinkExt = ((int)0x802D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetMapQuery : int
    {
        Coeff = ((int)0x0A00)        ,
        Order = ((int)0x0A01)        ,
        Domain = ((int)0x0A02)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetMinmaxParameterPNameExt : int
    {
        MinmaxFormat = ((int)0x802F)        ,
        MinmaxFormatExt = ((int)0x802F)        ,
        MinmaxSink = ((int)0x8030)        ,
        MinmaxSinkExt = ((int)0x8030)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetPixelMap : int
    {
        PixelMapIToI = ((int)0x0C70)        ,
        PixelMapSToS = ((int)0x0C71)        ,
        PixelMapIToR = ((int)0x0C72)        ,
        PixelMapIToG = ((int)0x0C73)        ,
        PixelMapIToB = ((int)0x0C74)        ,
        PixelMapIToA = ((int)0x0C75)        ,
        PixelMapRToR = ((int)0x0C76)        ,
        PixelMapGToG = ((int)0x0C77)        ,
        PixelMapBToB = ((int)0x0C78)        ,
        PixelMapAToA = ((int)0x0C79)        ,
    }

    /// <summary>
    /// Used in GL.GetBoolean, GL.GetFloat and 1 other function
    /// </summary>
    public enum GetPName : int
    {
        CurrentColor = ((int)0x0B00)        ,
        CurrentIndex = ((int)0x0B01)        ,
        CurrentNormal = ((int)0x0B02)        ,
        CurrentTextureCoords = ((int)0x0B03)        ,
        CurrentRasterColor = ((int)0x0B04)        ,
        CurrentRasterIndex = ((int)0x0B05)        ,
        CurrentRasterTextureCoords = ((int)0x0B06)        ,
        CurrentRasterPosition = ((int)0x0B07)        ,
        CurrentRasterPositionValid = ((int)0x0B08)        ,
        CurrentRasterDistance = ((int)0x0B09)        ,
        PointSmooth = ((int)0x0B10)        ,
        PointSize = ((int)0x0B11)        ,
        PointSizeRange = ((int)0x0B12)        ,
        SmoothPointSizeRange = ((int)0x0B12)        ,
        PointSizeGranularity = ((int)0x0B13)        ,
        SmoothPointSizeGranularity = ((int)0x0B13)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineWidth = ((int)0x0B21)        ,
        LineWidthRange = ((int)0x0B22)        ,
        SmoothLineWidthRange = ((int)0x0B22)        ,
        LineWidthGranularity = ((int)0x0B23)        ,
        SmoothLineWidthGranularity = ((int)0x0B23)        ,
        LineStipple = ((int)0x0B24)        ,
        LineStipplePattern = ((int)0x0B25)        ,
        LineStippleRepeat = ((int)0x0B26)        ,
        ListMode = ((int)0x0B30)        ,
        MaxListNesting = ((int)0x0B31)        ,
        ListBase = ((int)0x0B32)        ,
        ListIndex = ((int)0x0B33)        ,
        PolygonMode = ((int)0x0B40)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        PolygonStipple = ((int)0x0B42)        ,
        EdgeFlag = ((int)0x0B43)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
        Lighting = ((int)0x0B50)        ,
        LightModelLocalViewer = ((int)0x0B51)        ,
        LightModelTwoSide = ((int)0x0B52)        ,
        LightModelAmbient = ((int)0x0B53)        ,
        ShadeModel = ((int)0x0B54)        ,
        ColorMaterialFace = ((int)0x0B55)        ,
        ColorMaterialParameter = ((int)0x0B56)        ,
        ColorMaterial = ((int)0x0B57)        ,
        Fog = ((int)0x0B60)        ,
        FogIndex = ((int)0x0B61)        ,
        FogDensity = ((int)0x0B62)        ,
        FogStart = ((int)0x0B63)        ,
        FogEnd = ((int)0x0B64)        ,
        FogMode = ((int)0x0B65)        ,
        FogColor = ((int)0x0B66)        ,
        DepthRange = ((int)0x0B70)        ,
        DepthTest = ((int)0x0B71)        ,
        DepthWritemask = ((int)0x0B72)        ,
        DepthClearValue = ((int)0x0B73)        ,
        DepthFunc = ((int)0x0B74)        ,
        AccumClearValue = ((int)0x0B80)        ,
        StencilTest = ((int)0x0B90)        ,
        StencilClearValue = ((int)0x0B91)        ,
        StencilFunc = ((int)0x0B92)        ,
        StencilValueMask = ((int)0x0B93)        ,
        StencilFail = ((int)0x0B94)        ,
        StencilPassDepthFail = ((int)0x0B95)        ,
        StencilPassDepthPass = ((int)0x0B96)        ,
        StencilRef = ((int)0x0B97)        ,
        StencilWritemask = ((int)0x0B98)        ,
        MatrixMode = ((int)0x0BA0)        ,
        Normalize = ((int)0x0BA1)        ,
        Viewport = ((int)0x0BA2)        ,
        Modelview0StackDepthExt = ((int)0x0BA3)        ,
        ModelviewStackDepth = ((int)0x0BA3)        ,
        ProjectionStackDepth = ((int)0x0BA4)        ,
        TextureStackDepth = ((int)0x0BA5)        ,
        Modelview0MatrixExt = ((int)0x0BA6)        ,
        ModelviewMatrix = ((int)0x0BA6)        ,
        ProjectionMatrix = ((int)0x0BA7)        ,
        TextureMatrix = ((int)0x0BA8)        ,
        AttribStackDepth = ((int)0x0BB0)        ,
        ClientAttribStackDepth = ((int)0x0BB1)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestQcom = ((int)0x0BC0)        ,
        AlphaTestFunc = ((int)0x0BC1)        ,
        AlphaTestFuncQcom = ((int)0x0BC1)        ,
        AlphaTestRef = ((int)0x0BC2)        ,
        AlphaTestRefQcom = ((int)0x0BC2)        ,
        Dither = ((int)0x0BD0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        IndexLogicOp = ((int)0x0BF1)        ,
        LogicOp = ((int)0x0BF1)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        AuxBuffers = ((int)0x0C00)        ,
        DrawBuffer = ((int)0x0C01)        ,
        DrawBufferExt = ((int)0x0C01)        ,
        ReadBuffer = ((int)0x0C02)        ,
        ReadBufferExt = ((int)0x0C02)        ,
        ReadBufferNv = ((int)0x0C02)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        IndexClearValue = ((int)0x0C20)        ,
        IndexWritemask = ((int)0x0C21)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        IndexMode = ((int)0x0C30)        ,
        RgbaMode = ((int)0x0C31)        ,
        Doublebuffer = ((int)0x0C32)        ,
        Stereo = ((int)0x0C33)        ,
        RenderMode = ((int)0x0C40)        ,
        PerspectiveCorrectionHint = ((int)0x0C50)        ,
        PointSmoothHint = ((int)0x0C51)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        PolygonSmoothHint = ((int)0x0C53)        ,
        FogHint = ((int)0x0C54)        ,
        TextureGenS = ((int)0x0C60)        ,
        TextureGenT = ((int)0x0C61)        ,
        TextureGenR = ((int)0x0C62)        ,
        TextureGenQ = ((int)0x0C63)        ,
        PixelMapIToISize = ((int)0x0CB0)        ,
        PixelMapSToSSize = ((int)0x0CB1)        ,
        PixelMapIToRSize = ((int)0x0CB2)        ,
        PixelMapIToGSize = ((int)0x0CB3)        ,
        PixelMapIToBSize = ((int)0x0CB4)        ,
        PixelMapIToASize = ((int)0x0CB5)        ,
        PixelMapRToRSize = ((int)0x0CB6)        ,
        PixelMapGToGSize = ((int)0x0CB7)        ,
        PixelMapBToBSize = ((int)0x0CB8)        ,
        PixelMapAToASize = ((int)0x0CB9)        ,
        UnpackSwapBytes = ((int)0x0CF0)        ,
        UnpackLsbFirst = ((int)0x0CF1)        ,
        UnpackRowLength = ((int)0x0CF2)        ,
        UnpackSkipRows = ((int)0x0CF3)        ,
        UnpackSkipPixels = ((int)0x0CF4)        ,
        UnpackAlignment = ((int)0x0CF5)        ,
        PackSwapBytes = ((int)0x0D00)        ,
        PackLsbFirst = ((int)0x0D01)        ,
        PackRowLength = ((int)0x0D02)        ,
        PackSkipRows = ((int)0x0D03)        ,
        PackSkipPixels = ((int)0x0D04)        ,
        PackAlignment = ((int)0x0D05)        ,
        MapColor = ((int)0x0D10)        ,
        MapStencil = ((int)0x0D11)        ,
        IndexShift = ((int)0x0D12)        ,
        IndexOffset = ((int)0x0D13)        ,
        RedScale = ((int)0x0D14)        ,
        RedBias = ((int)0x0D15)        ,
        ZoomX = ((int)0x0D16)        ,
        ZoomY = ((int)0x0D17)        ,
        GreenScale = ((int)0x0D18)        ,
        GreenBias = ((int)0x0D19)        ,
        BlueScale = ((int)0x0D1A)        ,
        BlueBias = ((int)0x0D1B)        ,
        AlphaScale = ((int)0x0D1C)        ,
        AlphaBias = ((int)0x0D1D)        ,
        DepthScale = ((int)0x0D1E)        ,
        DepthBias = ((int)0x0D1F)        ,
        MaxEvalOrder = ((int)0x0D30)        ,
        MaxLights = ((int)0x0D31)        ,
        MaxClipDistances = ((int)0x0D32)        ,
        MaxClipPlanes = ((int)0x0D32)        ,
        MaxTextureSize = ((int)0x0D33)        ,
        MaxPixelMapTable = ((int)0x0D34)        ,
        MaxAttribStackDepth = ((int)0x0D35)        ,
        MaxModelviewStackDepth = ((int)0x0D36)        ,
        MaxNameStackDepth = ((int)0x0D37)        ,
        MaxProjectionStackDepth = ((int)0x0D38)        ,
        MaxTextureStackDepth = ((int)0x0D39)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        MaxClientAttribStackDepth = ((int)0x0D3B)        ,
        SubpixelBits = ((int)0x0D50)        ,
        IndexBits = ((int)0x0D51)        ,
        RedBits = ((int)0x0D52)        ,
        GreenBits = ((int)0x0D53)        ,
        BlueBits = ((int)0x0D54)        ,
        AlphaBits = ((int)0x0D55)        ,
        DepthBits = ((int)0x0D56)        ,
        StencilBits = ((int)0x0D57)        ,
        AccumRedBits = ((int)0x0D58)        ,
        AccumGreenBits = ((int)0x0D59)        ,
        AccumBlueBits = ((int)0x0D5A)        ,
        AccumAlphaBits = ((int)0x0D5B)        ,
        NameStackDepth = ((int)0x0D70)        ,
        AutoNormal = ((int)0x0D80)        ,
        Map1Color4 = ((int)0x0D90)        ,
        Map1Index = ((int)0x0D91)        ,
        Map1Normal = ((int)0x0D92)        ,
        Map1TextureCoord1 = ((int)0x0D93)        ,
        Map1TextureCoord2 = ((int)0x0D94)        ,
        Map1TextureCoord3 = ((int)0x0D95)        ,
        Map1TextureCoord4 = ((int)0x0D96)        ,
        Map1Vertex3 = ((int)0x0D97)        ,
        Map1Vertex4 = ((int)0x0D98)        ,
        Map2Color4 = ((int)0x0DB0)        ,
        Map2Index = ((int)0x0DB1)        ,
        Map2Normal = ((int)0x0DB2)        ,
        Map2TextureCoord1 = ((int)0x0DB3)        ,
        Map2TextureCoord2 = ((int)0x0DB4)        ,
        Map2TextureCoord3 = ((int)0x0DB5)        ,
        Map2TextureCoord4 = ((int)0x0DB6)        ,
        Map2Vertex3 = ((int)0x0DB7)        ,
        Map2Vertex4 = ((int)0x0DB8)        ,
        Map1GridDomain = ((int)0x0DD0)        ,
        Map1GridSegments = ((int)0x0DD1)        ,
        Map2GridDomain = ((int)0x0DD2)        ,
        Map2GridSegments = ((int)0x0DD3)        ,
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        FeedbackBufferSize = ((int)0x0DF1)        ,
        FeedbackBufferType = ((int)0x0DF2)        ,
        SelectionBufferSize = ((int)0x0DF4)        ,
        PolygonOffsetUnits = ((int)0x2A00)        ,
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
        ClipPlane0 = ((int)0x3000)        ,
        ClipPlane1 = ((int)0x3001)        ,
        ClipPlane2 = ((int)0x3002)        ,
        ClipPlane3 = ((int)0x3003)        ,
        ClipPlane4 = ((int)0x3004)        ,
        ClipPlane5 = ((int)0x3005)        ,
        Light0 = ((int)0x4000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        BlendColorExt = ((int)0x8005)        ,
        BlendEquationExt = ((int)0x8009)        ,
        PackCmykHintExt = ((int)0x800E)        ,
        UnpackCmykHintExt = ((int)0x800F)        ,
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2DExt = ((int)0x8011)        ,
        Separable2DExt = ((int)0x8012)        ,
        PostConvolutionRedScaleExt = ((int)0x801C)        ,
        PostConvolutionGreenScaleExt = ((int)0x801D)        ,
        PostConvolutionBlueScaleExt = ((int)0x801E)        ,
        PostConvolutionAlphaScaleExt = ((int)0x801F)        ,
        PostConvolutionRedBiasExt = ((int)0x8020)        ,
        PostConvolutionGreenBiasExt = ((int)0x8021)        ,
        PostConvolutionBlueBiasExt = ((int)0x8022)        ,
        PostConvolutionAlphaBiasExt = ((int)0x8023)        ,
        HistogramExt = ((int)0x8024)        ,
        MinmaxExt = ((int)0x802E)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
        PolygonOffsetBiasExt = ((int)0x8039)        ,
        RescaleNormalExt = ((int)0x803A)        ,
        TextureBinding1D = ((int)0x8068)        ,
        TextureBinding2D = ((int)0x8069)        ,
        Texture3DBindingExt = ((int)0x806A)        ,
        TextureBinding3D = ((int)0x806A)        ,
        PackSkipImagesExt = ((int)0x806B)        ,
        PackImageHeightExt = ((int)0x806C)        ,
        UnpackSkipImagesExt = ((int)0x806D)        ,
        UnpackImageHeightExt = ((int)0x806E)        ,
        Texture3DExt = ((int)0x806F)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        VertexArraySize = ((int)0x807A)        ,
        VertexArrayType = ((int)0x807B)        ,
        VertexArrayStride = ((int)0x807C)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayType = ((int)0x807E)        ,
        NormalArrayStride = ((int)0x807F)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArraySize = ((int)0x8081)        ,
        ColorArrayType = ((int)0x8082)        ,
        ColorArrayStride = ((int)0x8083)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayType = ((int)0x8085)        ,
        IndexArrayStride = ((int)0x8086)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArraySize = ((int)0x8088)        ,
        TextureCoordArrayType = ((int)0x8089)        ,
        TextureCoordArrayStride = ((int)0x808A)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayStride = ((int)0x808C)        ,
        EdgeFlagArrayCountExt = ((int)0x808D)        ,
        InterlaceSgix = ((int)0x8094)        ,
        DetailTexture2DBindingSgis = ((int)0x8096)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        SamplesSgis = ((int)0x80A9)        ,
        SampleMaskValueSgis = ((int)0x80AA)        ,
        SampleMaskInvertSgis = ((int)0x80AB)        ,
        SamplePatternSgis = ((int)0x80AC)        ,
        ColorMatrixSgi = ((int)0x80B1)        ,
        ColorMatrixStackDepthSgi = ((int)0x80B2)        ,
        MaxColorMatrixStackDepthSgi = ((int)0x80B3)        ,
        PostColorMatrixRedScaleSgi = ((int)0x80B4)        ,
        PostColorMatrixGreenScaleSgi = ((int)0x80B5)        ,
        PostColorMatrixBlueScaleSgi = ((int)0x80B6)        ,
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7)        ,
        PostColorMatrixRedBiasSgi = ((int)0x80B8)        ,
        PostColorMatrixGreenBiasSgi = ((int)0x80B9)        ,
        PostColorMatrixBlueBiasSgi = ((int)0x80BA)        ,
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB)        ,
        TextureColorTableSgi = ((int)0x80BC)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
        FogFuncPointsSgis = ((int)0x812B)        ,
        MaxFogFuncPointsSgis = ((int)0x812C)        ,
        PackSkipVolumesSgis = ((int)0x8130)        ,
        PackImageDepthSgis = ((int)0x8131)        ,
        UnpackSkipVolumesSgis = ((int)0x8132)        ,
        UnpackImageDepthSgis = ((int)0x8133)        ,
        Texture4DSgis = ((int)0x8134)        ,
        Max4DTextureSizeSgis = ((int)0x8138)        ,
        PixelTexGenSgix = ((int)0x8139)        ,
        PixelTileBestAlignmentSgix = ((int)0x813E)        ,
        PixelTileCacheIncrementSgix = ((int)0x813F)        ,
        PixelTileWidthSgix = ((int)0x8140)        ,
        PixelTileHeightSgix = ((int)0x8141)        ,
        PixelTileGridWidthSgix = ((int)0x8142)        ,
        PixelTileGridHeightSgix = ((int)0x8143)        ,
        PixelTileGridDepthSgix = ((int)0x8144)        ,
        PixelTileCacheSizeSgix = ((int)0x8145)        ,
        SpriteSgix = ((int)0x8148)        ,
        SpriteModeSgix = ((int)0x8149)        ,
        SpriteAxisSgix = ((int)0x814A)        ,
        SpriteTranslationSgix = ((int)0x814B)        ,
        Texture4DBindingSgis = ((int)0x814F)        ,
        MaxClipmapDepthSgix = ((int)0x8177)        ,
        MaxClipmapVirtualDepthSgix = ((int)0x8178)        ,
        PostTextureFilterBiasRangeSgix = ((int)0x817B)        ,
        PostTextureFilterScaleRangeSgix = ((int)0x817C)        ,
        ReferencePlaneSgix = ((int)0x817D)        ,
        ReferencePlaneEquationSgix = ((int)0x817E)        ,
        IrInstrument1Sgix = ((int)0x817F)        ,
        InstrumentMeasurementsSgix = ((int)0x8181)        ,
        CalligraphicFragmentSgix = ((int)0x8183)        ,
        FramezoomSgix = ((int)0x818B)        ,
        FramezoomFactorSgix = ((int)0x818C)        ,
        MaxFramezoomFactorSgix = ((int)0x818D)        ,
        GenerateMipmapHintSgis = ((int)0x8192)        ,
        DeformationsMaskSgix = ((int)0x8196)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
        LightModelColorControl = ((int)0x81F8)        ,
        SharedTexturePaletteExt = ((int)0x81FB)        ,
        ConvolutionHintSgix = ((int)0x8316)        ,
        AsyncMarkerSgix = ((int)0x8329)        ,
        PixelTexGenModeSgix = ((int)0x832B)        ,
        AsyncHistogramSgix = ((int)0x832C)        ,
        MaxAsyncHistogramSgix = ((int)0x832D)        ,
        PixelTextureSgis = ((int)0x8353)        ,
        AsyncTexImageSgix = ((int)0x835C)        ,
        AsyncDrawPixelsSgix = ((int)0x835D)        ,
        AsyncReadPixelsSgix = ((int)0x835E)        ,
        MaxAsyncTexImageSgix = ((int)0x835F)        ,
        MaxAsyncDrawPixelsSgix = ((int)0x8360)        ,
        MaxAsyncReadPixelsSgix = ((int)0x8361)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        FragmentLightingSgix = ((int)0x8400)        ,
        FragmentColorMaterialSgix = ((int)0x8401)        ,
        FragmentColorMaterialFaceSgix = ((int)0x8402)        ,
        FragmentColorMaterialParameterSgix = ((int)0x8403)        ,
        MaxFragmentLightsSgix = ((int)0x8404)        ,
        MaxActiveLightsSgix = ((int)0x8405)        ,
        LightEnvModeSgix = ((int)0x8407)        ,
        FragmentLightModelLocalViewerSgix = ((int)0x8408)        ,
        FragmentLightModelTwoSideSgix = ((int)0x8409)        ,
        FragmentLightModelAmbientSgix = ((int)0x840A)        ,
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B)        ,
        FragmentLight0Sgix = ((int)0x840C)        ,
        PackResampleSgix = ((int)0x842C)        ,
        UnpackResampleSgix = ((int)0x842D)        ,
        AliasedPointSizeRange = ((int)0x846D)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
    }

    /// <summary>
    /// Used in GL.GetPointer
    /// </summary>
    public enum GetPointervPName : int
    {
        FeedbackBufferPointer = ((int)0x0DF0)        ,
        SelectionBufferPointer = ((int)0x0DF3)        ,
        VertexArrayPointer = ((int)0x808E)        ,
        VertexArrayPointerExt = ((int)0x808E)        ,
        NormalArrayPointer = ((int)0x808F)        ,
        NormalArrayPointerExt = ((int)0x808F)        ,
        ColorArrayPointer = ((int)0x8090)        ,
        ColorArrayPointerExt = ((int)0x8090)        ,
        IndexArrayPointer = ((int)0x8091)        ,
        IndexArrayPointerExt = ((int)0x8091)        ,
        TextureCoordArrayPointer = ((int)0x8092)        ,
        TextureCoordArrayPointerExt = ((int)0x8092)        ,
        EdgeFlagArrayPointer = ((int)0x8093)        ,
        EdgeFlagArrayPointerExt = ((int)0x8093)        ,
        InstrumentBufferPointerSgix = ((int)0x8180)        ,
    }

    /// <summary>
    /// Used in GL.GetTexParameter
    /// </summary>
    public enum GetTextureParameter : int
    {
        TextureWidth = ((int)0x1000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureComponents = ((int)0x1003)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
        TextureBorderColorNv = ((int)0x1004)        ,
        TextureBorder = ((int)0x1005)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        TextureRedSize = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        TextureLuminanceSize = ((int)0x8060)        ,
        TextureIntensitySize = ((int)0x8061)        ,
        TexturePriority = ((int)0x8066)        ,
        TextureResident = ((int)0x8067)        ,
        TextureDepthExt = ((int)0x8071)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        DetailTextureLevelSgis = ((int)0x809A)        ,
        DetailTextureModeSgis = ((int)0x809B)        ,
        DetailTextureFuncPointsSgis = ((int)0x809C)        ,
        SharpenTextureFuncPointsSgis = ((int)0x80B0)        ,
        ShadowAmbientSgix = ((int)0x80BF)        ,
        DualTextureSelectSgis = ((int)0x8124)        ,
        QuadTextureSelectSgis = ((int)0x8125)        ,
        Texture4DsizeSgis = ((int)0x8136)        ,
        TextureWrapQSgis = ((int)0x8137)        ,
        TextureMinLodSgis = ((int)0x813A)        ,
        TextureMaxLodSgis = ((int)0x813B)        ,
        TextureBaseLevelSgis = ((int)0x813C)        ,
        TextureMaxLevelSgis = ((int)0x813D)        ,
        TextureFilter4SizeSgis = ((int)0x8147)        ,
        TextureClipmapCenterSgix = ((int)0x8171)        ,
        TextureClipmapFrameSgix = ((int)0x8172)        ,
        TextureClipmapOffsetSgix = ((int)0x8173)        ,
        TextureClipmapVirtualDepthSgix = ((int)0x8174)        ,
        TextureClipmapLodOffsetSgix = ((int)0x8175)        ,
        TextureClipmapDepthSgix = ((int)0x8176)        ,
        PostTextureFilterBiasSgix = ((int)0x8179)        ,
        PostTextureFilterScaleSgix = ((int)0x817A)        ,
        TextureLodBiasSSgix = ((int)0x818E)        ,
        TextureLodBiasTSgix = ((int)0x818F)        ,
        TextureLodBiasRSgix = ((int)0x8190)        ,
        GenerateMipmapSgis = ((int)0x8191)        ,
        TextureCompareSgix = ((int)0x819A)        ,
        TextureCompareOperatorSgix = ((int)0x819B)        ,
        TextureLequalRSgix = ((int)0x819C)        ,
        TextureGequalRSgix = ((int)0x819D)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintMode : int
    {
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0x1101)        ,
        Nicest = ((int)0x1102)        ,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintTarget : int
    {
        PerspectiveCorrectionHint = ((int)0x0C50)        ,
        PointSmoothHint = ((int)0x0C51)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        PolygonSmoothHint = ((int)0x0C53)        ,
        FogHint = ((int)0x0C54)        ,
        PreferDoublebufferHintPgi = ((int)0x1A1F8)        ,
        ConserveMemoryHintPgi = ((int)0x1A1FD)        ,
        ReclaimMemoryHintPgi = ((int)0x1A1FE)        ,
        NativeGraphicsBeginHintPgi = ((int)0x1A203)        ,
        NativeGraphicsEndHintPgi = ((int)0x1A204)        ,
        AlwaysFastHintPgi = ((int)0x1A20C)        ,
        AlwaysSoftHintPgi = ((int)0x1A20D)        ,
        AllowDrawObjHintPgi = ((int)0x1A20E)        ,
        AllowDrawWinHintPgi = ((int)0x1A20F)        ,
        AllowDrawFrgHintPgi = ((int)0x1A210)        ,
        AllowDrawMemHintPgi = ((int)0x1A211)        ,
        StrictDepthfuncHintPgi = ((int)0x1A216)        ,
        StrictLightingHintPgi = ((int)0x1A217)        ,
        StrictScissorHintPgi = ((int)0x1A218)        ,
        FullStippleHintPgi = ((int)0x1A219)        ,
        ClipNearHintPgi = ((int)0x1A220)        ,
        ClipFarHintPgi = ((int)0x1A221)        ,
        WideLineHintPgi = ((int)0x1A222)        ,
        BackNormalsHintPgi = ((int)0x1A223)        ,
        VertexDataHintPgi = ((int)0x1A22A)        ,
        VertexConsistentHintPgi = ((int)0x1A22B)        ,
        MaterialSideHintPgi = ((int)0x1A22C)        ,
        MaxVertexHintPgi = ((int)0x1A22D)        ,
        PackCmykHintExt = ((int)0x800E)        ,
        UnpackCmykHintExt = ((int)0x800F)        ,
        PhongHintWin = ((int)0x80EB)        ,
        ClipVolumeClippingHintExt = ((int)0x80F0)        ,
        TextureMultiBufferHintSgix = ((int)0x812E)        ,
        GenerateMipmapHint = ((int)0x8192)        ,
        GenerateMipmapHintSgis = ((int)0x8192)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ConvolutionHintSgix = ((int)0x8316)        ,
        ScalebiasHintSgix = ((int)0x8322)        ,
        LineQualityHintSgix = ((int)0x835B)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        VertexArrayStorageHintApple = ((int)0x851F)        ,
        MultisampleFilterHintNv = ((int)0x8534)        ,
        TransformHintApple = ((int)0x85B1)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintArb = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        BinningControlHintQcom = ((int)0x8FB0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum HistogramTargetExt : int
    {
        Histogram = ((int)0x8024)        ,
        HistogramExt = ((int)0x8024)        ,
        ProxyHistogram = ((int)0x8025)        ,
        ProxyHistogramExt = ((int)0x8025)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgMultisampledRenderToTexture : int
    {
        RenderbufferSamplesImg = ((int)0x9133)        ,
        FramebufferIncompleteMultisampleImg = ((int)0x9134)        ,
        MaxSamplesImg = ((int)0x9135)        ,
        TextureSamplesImg = ((int)0x9136)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgreadFormat : int
    {
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365
        /// </summary>
        UnsignedShort4444Rev = ((int)0x8365)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366
        /// </summary>
        UnsignedShort1555Rev = ((int)0x8366)        ,
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgReadFormat : int
    {
        BgraImg = ((int)0x80E1)        ,
        UnsignedShort4444RevImg = ((int)0x8365)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgtextureCompressionPvrtc : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)        ,
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgTextureCompressionPvrtc : int
    {
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)        ,
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)        ,
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)        ,
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgtextureEnvEnhancedFixedFunction : int
    {
        /// <summary>
        /// Original was GL_DOT3_RGBA_IMG = 0x86AF
        /// </summary>
        Dot3RgbaImg = ((int)0x86AF)        ,
        /// <summary>
        /// Original was GL_MODULATE_COLOR_IMG = 0x8C04
        /// </summary>
        ModulateColorImg = ((int)0x8C04)        ,
        /// <summary>
        /// Original was GL_RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05
        /// </summary>
        RecipAddSignedAlphaImg = ((int)0x8C05)        ,
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_MODULATE_IMG = 0x8C06
        /// </summary>
        TextureAlphaModulateImg = ((int)0x8C06)        ,
        /// <summary>
        /// Original was GL_FACTOR_ALPHA_MODULATE_IMG = 0x8C07
        /// </summary>
        FactorAlphaModulateImg = ((int)0x8C07)        ,
        /// <summary>
        /// Original was GL_FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08
        /// </summary>
        FragmentAlphaModulateImg = ((int)0x8C08)        ,
        /// <summary>
        /// Original was GL_ADD_BLEND_IMG = 0x8C09
        /// </summary>
        AddBlendImg = ((int)0x8C09)        ,
        /// <summary>
        /// Original was GL_IMG_texture_env_enhanced_fixed_function = 1
        /// </summary>
        ImgTextureEnvEnhancedFixedFunction = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgTextureEnvEnhancedFixedFunction : int
    {
        Dot3RgbaImg = ((int)0x86AF)        ,
        ModulateColorImg = ((int)0x8C04)        ,
        RecipAddSignedAlphaImg = ((int)0x8C05)        ,
        TextureAlphaModulateImg = ((int)0x8C06)        ,
        FactorAlphaModulateImg = ((int)0x8C07)        ,
        FragmentAlphaModulateImg = ((int)0x8C08)        ,
        AddBlendImg = ((int)0x8C09)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImguserClipPlane : int
    {
        /// <summary>
        /// Original was GL_MAX_CLIP_PLANES_IMG = 0x0D32
        /// </summary>
        MaxClipPlanesImg = ((int)0x0D32)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE0_IMG = 0x3000
        /// </summary>
        ClipPlane0Img = ((int)0x3000)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE1_IMG = 0x3001
        /// </summary>
        ClipPlane1Img = ((int)0x3001)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE2_IMG = 0x3002
        /// </summary>
        ClipPlane2Img = ((int)0x3002)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE3_IMG = 0x3003
        /// </summary>
        ClipPlane3Img = ((int)0x3003)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE4_IMG = 0x3004
        /// </summary>
        ClipPlane4Img = ((int)0x3004)        ,
        /// <summary>
        /// Original was GL_CLIP_PLANE5_IMG = 0x3005
        /// </summary>
        ClipPlane5Img = ((int)0x3005)        ,
        /// <summary>
        /// Original was GL_IMG_user_clip_plane = 1
        /// </summary>
        ImgUserClipPlane = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgUserClipPlane : int
    {
        MaxClipPlanesImg = ((int)0x0D32)        ,
        ClipPlane0Img = ((int)0x3000)        ,
        ClipPlane1Img = ((int)0x3001)        ,
        ClipPlane2Img = ((int)0x3002)        ,
        ClipPlane3Img = ((int)0x3003)        ,
        ClipPlane4Img = ((int)0x3004)        ,
        ClipPlane5Img = ((int)0x3005)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IndexPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InterleavedArrayFormat : int
    {
        V2f = ((int)0x2A20)        ,
        V3f = ((int)0x2A21)        ,
        C4ubV2f = ((int)0x2A22)        ,
        C4ubV3f = ((int)0x2A23)        ,
        C3fV3f = ((int)0x2A24)        ,
        N3fV3f = ((int)0x2A25)        ,
        C4fN3fV3f = ((int)0x2A26)        ,
        T2fV3f = ((int)0x2A27)        ,
        T4fV4f = ((int)0x2A28)        ,
        T2fC4ubV3f = ((int)0x2A29)        ,
        T2fC3fV3f = ((int)0x2A2A)        ,
        T2fN3fV3f = ((int)0x2A2B)        ,
        T2fC4fN3fV3f = ((int)0x2A2C)        ,
        T4fC4fN3fV4f = ((int)0x2A2D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InternalFormat : int
    {
        R3G3B2 = ((int)0x2A10)        ,
        Alpha4 = ((int)0x803B)        ,
        Alpha8 = ((int)0x803C)        ,
        Alpha12 = ((int)0x803D)        ,
        Alpha16 = ((int)0x803E)        ,
        Luminance4 = ((int)0x803F)        ,
        Luminance8 = ((int)0x8040)        ,
        Luminance12 = ((int)0x8041)        ,
        Luminance16 = ((int)0x8042)        ,
        Luminance4Alpha4 = ((int)0x8043)        ,
        Luminance6Alpha2 = ((int)0x8044)        ,
        Luminance8Alpha8 = ((int)0x8045)        ,
        Luminance12Alpha4 = ((int)0x8046)        ,
        Luminance12Alpha12 = ((int)0x8047)        ,
        Luminance16Alpha16 = ((int)0x8048)        ,
        Intensity = ((int)0x8049)        ,
        Intensity4 = ((int)0x804A)        ,
        Intensity8 = ((int)0x804B)        ,
        Intensity12 = ((int)0x804C)        ,
        Intensity16 = ((int)0x804D)        ,
        Rgb2Ext = ((int)0x804E)        ,
        Rgb4 = ((int)0x804F)        ,
        Rgb5 = ((int)0x8050)        ,
        Rgb8 = ((int)0x8051)        ,
        Rgb10 = ((int)0x8052)        ,
        Rgb12 = ((int)0x8053)        ,
        Rgb16 = ((int)0x8054)        ,
        Rgba2 = ((int)0x8055)        ,
        Rgba4 = ((int)0x8056)        ,
        Rgb5A1 = ((int)0x8057)        ,
        Rgba8 = ((int)0x8058)        ,
        Rgb10A2 = ((int)0x8059)        ,
        Rgba12 = ((int)0x805A)        ,
        Rgba16 = ((int)0x805B)        ,
        DualAlpha4Sgis = ((int)0x8110)        ,
        DualAlpha8Sgis = ((int)0x8111)        ,
        DualAlpha12Sgis = ((int)0x8112)        ,
        DualAlpha16Sgis = ((int)0x8113)        ,
        DualLuminance4Sgis = ((int)0x8114)        ,
        DualLuminance8Sgis = ((int)0x8115)        ,
        DualLuminance12Sgis = ((int)0x8116)        ,
        DualLuminance16Sgis = ((int)0x8117)        ,
        DualIntensity4Sgis = ((int)0x8118)        ,
        DualIntensity8Sgis = ((int)0x8119)        ,
        DualIntensity12Sgis = ((int)0x811A)        ,
        DualIntensity16Sgis = ((int)0x811B)        ,
        DualLuminanceAlpha4Sgis = ((int)0x811C)        ,
        DualLuminanceAlpha8Sgis = ((int)0x811D)        ,
        QuadAlpha4Sgis = ((int)0x811E)        ,
        QuadAlpha8Sgis = ((int)0x811F)        ,
        QuadLuminance4Sgis = ((int)0x8120)        ,
        QuadLuminance8Sgis = ((int)0x8121)        ,
        QuadIntensity4Sgis = ((int)0x8122)        ,
        QuadIntensity8Sgis = ((int)0x8123)        ,
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32Sgix = ((int)0x81A7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvModeSgix : int
    {
        Add = ((int)0x0104)        ,
        Replace = ((int)0x1E01)        ,
        Modulate = ((int)0x2100)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightEnvParameterSgix : int
    {
        LightEnvModeSgix = ((int)0x8407)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LightModelColorControl : int
    {
        SingleColor = ((int)0x81F9)        ,
        SingleColorExt = ((int)0x81F9)        ,
        SeparateSpecularColor = ((int)0x81FA)        ,
        SeparateSpecularColorExt = ((int)0x81FA)        ,
    }

    /// <summary>
    /// Used in GL.LightModel
    /// </summary>
    public enum LightModelParameter : int
    {
        LightModelLocalViewer = ((int)0x0B51)        ,
        LightModelTwoSide = ((int)0x0B52)        ,
        LightModelAmbient = ((int)0x0B53)        ,
        LightModelColorControl = ((int)0x81F8)        ,
        LightModelColorControlExt = ((int)0x81F8)        ,
    }

    /// <summary>
    /// Used in GL.GetLight, GL.Light
    /// </summary>
    public enum LightName : int
    {
        Light0 = ((int)0x4000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        FragmentLight0Sgix = ((int)0x840C)        ,
        FragmentLight1Sgix = ((int)0x840D)        ,
        FragmentLight2Sgix = ((int)0x840E)        ,
        FragmentLight3Sgix = ((int)0x840F)        ,
        FragmentLight4Sgix = ((int)0x8410)        ,
        FragmentLight5Sgix = ((int)0x8411)        ,
        FragmentLight6Sgix = ((int)0x8412)        ,
        FragmentLight7Sgix = ((int)0x8413)        ,
    }

    /// <summary>
    /// Used in GL.GetLight, GL.Light
    /// </summary>
    public enum LightParameter : int
    {
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Position = ((int)0x1203)        ,
        SpotDirection = ((int)0x1204)        ,
        SpotExponent = ((int)0x1205)        ,
        SpotCutoff = ((int)0x1206)        ,
        ConstantAttenuation = ((int)0x1207)        ,
        LinearAttenuation = ((int)0x1208)        ,
        QuadraticAttenuation = ((int)0x1209)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListMode : int
    {
        Compile = ((int)0x1300)        ,
        CompileAndExecute = ((int)0x1301)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListNameType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Gl2Bytes = ((int)0x1407)        ,
        Gl3Bytes = ((int)0x1408)        ,
        Gl4Bytes = ((int)0x1409)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListParameterName : int
    {
        ListPrioritySgix = ((int)0x8182)        ,
    }

    /// <summary>
    /// Used in GL.LogicOp
    /// </summary>
    public enum LogicOp : int
    {
        Clear = ((int)0x1500)        ,
        And = ((int)0x1501)        ,
        AndReverse = ((int)0x1502)        ,
        Copy = ((int)0x1503)        ,
        AndInverted = ((int)0x1504)        ,
        Noop = ((int)0x1505)        ,
        Xor = ((int)0x1506)        ,
        Or = ((int)0x1507)        ,
        Nor = ((int)0x1508)        ,
        Equiv = ((int)0x1509)        ,
        Invert = ((int)0x150A)        ,
        OrReverse = ((int)0x150B)        ,
        CopyInverted = ((int)0x150C)        ,
        OrInverted = ((int)0x150D)        ,
        Nand = ((int)0x150E)        ,
        Set = ((int)0x150F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MapBufferUsageMask : int
    {
        MapReadBit = ((int)0x0001)        ,
        MapReadBitExt = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapWriteBitExt = ((int)0x0002)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateRangeBitExt = ((int)0x0004)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapInvalidateBufferBitExt = ((int)0x0008)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapFlushExplicitBitExt = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        MapUnsynchronizedBitExt = ((int)0x0020)        ,
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        ClientStorageBit = ((int)0x0200)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapTarget : int
    {
        Map1Color4 = ((int)0x0D90)        ,
        Map1Index = ((int)0x0D91)        ,
        Map1Normal = ((int)0x0D92)        ,
        Map1TextureCoord1 = ((int)0x0D93)        ,
        Map1TextureCoord2 = ((int)0x0D94)        ,
        Map1TextureCoord3 = ((int)0x0D95)        ,
        Map1TextureCoord4 = ((int)0x0D96)        ,
        Map1Vertex3 = ((int)0x0D97)        ,
        Map1Vertex4 = ((int)0x0D98)        ,
        Map2Color4 = ((int)0x0DB0)        ,
        Map2Index = ((int)0x0DB1)        ,
        Map2Normal = ((int)0x0DB2)        ,
        Map2TextureCoord1 = ((int)0x0DB3)        ,
        Map2TextureCoord2 = ((int)0x0DB4)        ,
        Map2TextureCoord3 = ((int)0x0DB5)        ,
        Map2TextureCoord4 = ((int)0x0DB6)        ,
        Map2Vertex3 = ((int)0x0DB7)        ,
        Map2Vertex4 = ((int)0x0DB8)        ,
        GeometryDeformationSgix = ((int)0x8194)        ,
        TextureDeformationSgix = ((int)0x8195)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MapTextureFormatIntel : int
    {
        LayoutDefaultIntel = ((int)0)        ,
        LayoutLinearIntel = ((int)1)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.Material
    /// </summary>
    public enum MaterialFace : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.Material
    /// </summary>
    public enum MaterialParameter : int
    {
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Emission = ((int)0x1600)        ,
        Shininess = ((int)0x1601)        ,
        AmbientAndDiffuse = ((int)0x1602)        ,
        ColorIndexes = ((int)0x1603)        ,
    }

    /// <summary>
    /// Used in GL.MatrixMode
    /// </summary>
    public enum MatrixMode : int
    {
        Modelview = ((int)0x1700)        ,
        Modelview0Ext = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryBarrierMask : int
    {
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBitExt = ((int)0x00000001)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        ElementArrayBarrierBitExt = ((int)0x00000002)        ,
        UniformBarrierBit = ((int)0x00000004)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
        TextureFetchBarrierBit = ((int)0x00000008)        ,
        TextureFetchBarrierBitExt = ((int)0x00000008)        ,
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBitExt = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        CommandBarrierBitExt = ((int)0x00000040)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        PixelBufferBarrierBitExt = ((int)0x00000080)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        TextureUpdateBarrierBitExt = ((int)0x00000100)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        BufferUpdateBarrierBitExt = ((int)0x00000200)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        FramebufferBarrierBitExt = ((int)0x00000400)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        TransformFeedbackBarrierBitExt = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        AtomicCounterBarrierBitExt = ((int)0x00001000)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode1 : int
    {
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MeshMode2 : int
    {
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
        Fill = ((int)0x1B02)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MinmaxTargetExt : int
    {
        Minmax = ((int)0x802E)        ,
        MinmaxExt = ((int)0x802E)        ,
    }

    /// <summary>
    /// Used in GL.NormalPointer
    /// </summary>
    public enum NormalPointerType : int
    {
        Byte = ((int)0x1400)        ,
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Nvfence : int
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2)        ,
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3)        ,
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4)        ,
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFence : int
    {
        AllCompletedNv = ((int)0x84F2)        ,
        FenceStatusNv = ((int)0x84F3)        ,
        FenceConditionNv = ((int)0x84F4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum OcclusionQueryEventMaskAmd : int
    {
        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        /// </summary>
        QueryDepthBoundsFailEventBitAmd = ((int)0x00000008)        ,
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesblendEquationSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB_OES = 0x8009
        /// </summary>
        BlendEquationRgbOes = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA_OES = 0x883D
        /// </summary>
        BlendEquationAlphaOes = ((int)0x883D)        ,
        /// <summary>
        /// Original was GL_OES_blend_equation_separate = 1
        /// </summary>
        OesBlendEquationSeparate = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendEquationSeparate : int
    {
        BlendEquationRgbOes = ((int)0x8009)        ,
        BlendEquationAlphaOes = ((int)0x883D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesblendFuncSeparate : int
    {
        /// <summary>
        /// Original was GL_BLEND_DST_RGB_OES = 0x80C8
        /// </summary>
        BlendDstRgbOes = ((int)0x80C8)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB_OES = 0x80C9
        /// </summary>
        BlendSrcRgbOes = ((int)0x80C9)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA_OES = 0x80CA
        /// </summary>
        BlendDstAlphaOes = ((int)0x80CA)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA_OES = 0x80CB
        /// </summary>
        BlendSrcAlphaOes = ((int)0x80CB)        ,
        /// <summary>
        /// Original was GL_OES_blend_func_separate = 1
        /// </summary>
        OesBlendFuncSeparate = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendFuncSeparate : int
    {
        BlendDstRgbOes = ((int)0x80C8)        ,
        BlendSrcRgbOes = ((int)0x80C9)        ,
        BlendDstAlphaOes = ((int)0x80CA)        ,
        BlendSrcAlphaOes = ((int)0x80CB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesblendSubtract : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD_OES = 0x8006
        /// </summary>
        FuncAddOes = ((int)0x8006)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_OES = 0x8009
        /// </summary>
        BlendEquationOes = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT_OES = 0x800A
        /// </summary>
        FuncSubtractOes = ((int)0x800A)        ,
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT_OES = 0x800B
        /// </summary>
        FuncReverseSubtractOes = ((int)0x800B)        ,
        /// <summary>
        /// Original was GL_OES_blend_subtract = 1
        /// </summary>
        OesBlendSubtract = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesBlendSubtract : int
    {
        FuncAddOes = ((int)0x8006)        ,
        BlendEquationOes = ((int)0x8009)        ,
        FuncSubtractOes = ((int)0x800A)        ,
        FuncReverseSubtractOes = ((int)0x800B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesbyteCoordinates : int
    {
        /// <summary>
        /// Original was GL_OES_byte_coordinates = 1
        /// </summary>
        OesByteCoordinates = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesByteCoordinates : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OescompressedEtc1Rgb8Texture : int
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedEtc1Rgb8Texture : int
    {
        Etc1Rgb8Oes = ((int)0x8D64)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OescompressedPalettedTexture : int
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91)        ,
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96)        ,
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99)        ,
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedPalettedTexture : int
    {
        Palette4Rgb8Oes = ((int)0x8B90)        ,
        Palette4Rgba8Oes = ((int)0x8B91)        ,
        Palette4R5G6B5Oes = ((int)0x8B92)        ,
        Palette4Rgba4Oes = ((int)0x8B93)        ,
        Palette4Rgb5A1Oes = ((int)0x8B94)        ,
        Palette8Rgb8Oes = ((int)0x8B95)        ,
        Palette8Rgba8Oes = ((int)0x8B96)        ,
        Palette8R5G6B5Oes = ((int)0x8B97)        ,
        Palette8Rgba4Oes = ((int)0x8B98)        ,
        Palette8Rgb5A1Oes = ((int)0x8B99)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesdepth24 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth24 : int
    {
        DepthComponent24Oes = ((int)0x81A6)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesdepth32 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7)        ,
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth32 : int
    {
        DepthComponent32Oes = ((int)0x81A7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesdrawTexture : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_CROP_RECT_OES = 0x8B9D
        /// </summary>
        TextureCropRectOes = ((int)0x8B9D)        ,
        /// <summary>
        /// Original was GL_OES_draw_texture = 1
        /// </summary>
        OesDrawTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDrawTexture : int
    {
        TextureCropRectOes = ((int)0x8B9D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oeseglimage : int
    {
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImage : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImageExternal : int
    {
        TextureExternalOes = ((int)0x8D65)        ,
        SamplerExternalOes = ((int)0x8D66)        ,
        TextureBindingExternalOes = ((int)0x8D67)        ,
        RequiredTextureImageUnitsOes = ((int)0x8D68)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OeselementIndexUint : int
    {
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesElementIndexUint : int
    {
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesextendedMatrixPalette : int
    {
        /// <summary>
        /// Original was GL_OES_extended_matrix_palette = 1
        /// </summary>
        OesExtendedMatrixPalette = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesExtendedMatrixPalette : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesfboRenderMipmap : int
    {
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFboRenderMipmap : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesfixedPoint : int
    {
        /// <summary>
        /// Original was GL_FIXED_OES = 0x140C
        /// </summary>
        FixedOes = ((int)0x140C)        ,
        /// <summary>
        /// Original was GL_OES_fixed_point = 1
        /// </summary>
        OesFixedPoint = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFixedPoint : int
    {
        FixedOes = ((int)0x140C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesframebufferObject : int
    {
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0)        ,
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506)        ,
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE_OES = 0x84E8
        /// </summary>
        MaxRenderbufferSizeOes = ((int)0x84E8)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING_OES = 0x8CA6
        /// </summary>
        FramebufferBindingOes = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING_OES = 0x8CA7
        /// </summary>
        RenderbufferBindingOes = ((int)0x8CA7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_OES = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_OES = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_OES = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_OES = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_OES = 0x8CD5
        /// </summary>
        FramebufferCompleteOes = ((int)0x8CD5)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_OES = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_OES = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_OES = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsOes = ((int)0x8CDA)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_OES = 0x8CDD
        /// </summary>
        FramebufferUnsupportedOes = ((int)0x8CDD)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00)        ,
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_OES = 0x8D20
        /// </summary>
        StencilAttachmentOes = ((int)0x8D20)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_OES = 0x8D40
        /// </summary>
        FramebufferOes = ((int)0x8D40)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_OES = 0x8D41
        /// </summary>
        RenderbufferOes = ((int)0x8D41)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH_OES = 0x8D42
        /// </summary>
        RenderbufferWidthOes = ((int)0x8D42)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT_OES = 0x8D43
        /// </summary>
        RenderbufferHeightOes = ((int)0x8D43)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT_OES = 0x8D44
        /// </summary>
        RenderbufferInternalFormatOes = ((int)0x8D44)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE_OES = 0x8D50
        /// </summary>
        RenderbufferRedSizeOes = ((int)0x8D50)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE_OES = 0x8D51
        /// </summary>
        RenderbufferGreenSizeOes = ((int)0x8D51)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE_OES = 0x8D52
        /// </summary>
        RenderbufferBlueSizeOes = ((int)0x8D52)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE_OES = 0x8D53
        /// </summary>
        RenderbufferAlphaSizeOes = ((int)0x8D53)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE_OES = 0x8D54
        /// </summary>
        RenderbufferDepthSizeOes = ((int)0x8D54)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE_OES = 0x8D55
        /// </summary>
        RenderbufferStencilSizeOes = ((int)0x8D55)        ,
        /// <summary>
        /// Original was GL_RGB565_OES = 0x8D62
        /// </summary>
        Rgb565Oes = ((int)0x8D62)        ,
        /// <summary>
        /// Original was GL_OES_framebuffer_object = 1
        /// </summary>
        OesFramebufferObject = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFramebufferObject : int
    {
        NoneOes = ((int)0)        ,
        InvalidFramebufferOperationOes = ((int)0x0506)        ,
        Rgba4Oes = ((int)0x8056)        ,
        Rgb5A1Oes = ((int)0x8057)        ,
        DepthComponent16Oes = ((int)0x81A5)        ,
        MaxRenderbufferSizeOes = ((int)0x84E8)        ,
        FramebufferBindingOes = ((int)0x8CA6)        ,
        RenderbufferBindingOes = ((int)0x8CA7)        ,
        FramebufferAttachmentObjectTypeOes = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectNameOes = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevelOes = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFaceOes = ((int)0x8CD3)        ,
        FramebufferCompleteOes = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachmentOes = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachmentOes = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensionsOes = ((int)0x8CD9)        ,
        FramebufferIncompleteFormatsOes = ((int)0x8CDA)        ,
        FramebufferUnsupportedOes = ((int)0x8CDD)        ,
        ColorAttachment0Oes = ((int)0x8CE0)        ,
        DepthAttachmentOes = ((int)0x8D00)        ,
        StencilAttachmentOes = ((int)0x8D20)        ,
        FramebufferOes = ((int)0x8D40)        ,
        RenderbufferOes = ((int)0x8D41)        ,
        RenderbufferWidthOes = ((int)0x8D42)        ,
        RenderbufferHeightOes = ((int)0x8D43)        ,
        RenderbufferInternalFormatOes = ((int)0x8D44)        ,
        RenderbufferRedSizeOes = ((int)0x8D50)        ,
        RenderbufferGreenSizeOes = ((int)0x8D51)        ,
        RenderbufferBlueSizeOes = ((int)0x8D52)        ,
        RenderbufferAlphaSizeOes = ((int)0x8D53)        ,
        RenderbufferDepthSizeOes = ((int)0x8D54)        ,
        RenderbufferStencilSizeOes = ((int)0x8D55)        ,
        Rgb565Oes = ((int)0x8D62)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesmapbuffer : int
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9)        ,
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD)        ,
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMapbuffer : int
    {
        WriteOnlyOes = ((int)0x88B9)        ,
        BufferAccessOes = ((int)0x88BB)        ,
        BufferMappedOes = ((int)0x88BC)        ,
        BufferMapPointerOes = ((int)0x88BD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesmatrixGet : int
    {
        /// <summary>
        /// Original was GL_MODELVIEW_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898D
        /// </summary>
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D)        ,
        /// <summary>
        /// Original was GL_PROJECTION_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898E
        /// </summary>
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MATRIX_FLOAT_AS_INT_BITS_OES = 0x898F
        /// </summary>
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F)        ,
        /// <summary>
        /// Original was GL_OES_matrix_get = 1
        /// </summary>
        OesMatrixGet = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMatrixGet : int
    {
        ModelviewMatrixFloatAsIntBitsOes = ((int)0x898D)        ,
        ProjectionMatrixFloatAsIntBitsOes = ((int)0x898E)        ,
        TextureMatrixFloatAsIntBitsOes = ((int)0x898F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesmatrixPalette : int
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNITS_OES = 0x86A4
        /// </summary>
        MaxVertexUnitsOes = ((int)0x86A4)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_TYPE_OES = 0x86A9
        /// </summary>
        WeightArrayTypeOes = ((int)0x86A9)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_STRIDE_OES = 0x86AA
        /// </summary>
        WeightArrayStrideOes = ((int)0x86AA)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_SIZE_OES = 0x86AB
        /// </summary>
        WeightArraySizeOes = ((int)0x86AB)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_POINTER_OES = 0x86AC
        /// </summary>
        WeightArrayPointerOes = ((int)0x86AC)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_OES = 0x86AD
        /// </summary>
        WeightArrayOes = ((int)0x86AD)        ,
        /// <summary>
        /// Original was GL_MATRIX_PALETTE_OES = 0x8840
        /// </summary>
        MatrixPaletteOes = ((int)0x8840)        ,
        /// <summary>
        /// Original was GL_MAX_PALETTE_MATRICES_OES = 0x8842
        /// </summary>
        MaxPaletteMatricesOes = ((int)0x8842)        ,
        /// <summary>
        /// Original was GL_CURRENT_PALETTE_MATRIX_OES = 0x8843
        /// </summary>
        CurrentPaletteMatrixOes = ((int)0x8843)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_OES = 0x8844
        /// </summary>
        MatrixIndexArrayOes = ((int)0x8844)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_SIZE_OES = 0x8846
        /// </summary>
        MatrixIndexArraySizeOes = ((int)0x8846)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_TYPE_OES = 0x8847
        /// </summary>
        MatrixIndexArrayTypeOes = ((int)0x8847)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_STRIDE_OES = 0x8848
        /// </summary>
        MatrixIndexArrayStrideOes = ((int)0x8848)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_POINTER_OES = 0x8849
        /// </summary>
        MatrixIndexArrayPointerOes = ((int)0x8849)        ,
        /// <summary>
        /// Original was GL_WEIGHT_ARRAY_BUFFER_BINDING_OES = 0x889E
        /// </summary>
        WeightArrayBufferBindingOes = ((int)0x889E)        ,
        /// <summary>
        /// Original was GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E
        /// </summary>
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E)        ,
        /// <summary>
        /// Original was GL_OES_matrix_palette = 1
        /// </summary>
        OesMatrixPalette = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMatrixPalette : int
    {
        MaxVertexUnitsOes = ((int)0x86A4)        ,
        WeightArrayTypeOes = ((int)0x86A9)        ,
        WeightArrayStrideOes = ((int)0x86AA)        ,
        WeightArraySizeOes = ((int)0x86AB)        ,
        WeightArrayPointerOes = ((int)0x86AC)        ,
        WeightArrayOes = ((int)0x86AD)        ,
        MatrixPaletteOes = ((int)0x8840)        ,
        MaxPaletteMatricesOes = ((int)0x8842)        ,
        CurrentPaletteMatrixOes = ((int)0x8843)        ,
        MatrixIndexArrayOes = ((int)0x8844)        ,
        MatrixIndexArraySizeOes = ((int)0x8846)        ,
        MatrixIndexArrayTypeOes = ((int)0x8847)        ,
        MatrixIndexArrayStrideOes = ((int)0x8848)        ,
        MatrixIndexArrayPointerOes = ((int)0x8849)        ,
        WeightArrayBufferBindingOes = ((int)0x889E)        ,
        MatrixIndexArrayBufferBindingOes = ((int)0x8B9E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OespackedDepthStencil : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPackedDepthStencil : int
    {
        DepthStencilOes = ((int)0x84F9)        ,
        UnsignedInt248Oes = ((int)0x84FA)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OespointSizeArray : int
    {
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_TYPE_OES = 0x898A
        /// </summary>
        PointSizeArrayTypeOes = ((int)0x898A)        ,
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_STRIDE_OES = 0x898B
        /// </summary>
        PointSizeArrayStrideOes = ((int)0x898B)        ,
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_POINTER_OES = 0x898C
        /// </summary>
        PointSizeArrayPointerOes = ((int)0x898C)        ,
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_OES = 0x8B9C
        /// </summary>
        PointSizeArrayOes = ((int)0x8B9C)        ,
        /// <summary>
        /// Original was GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F
        /// </summary>
        PointSizeArrayBufferBindingOes = ((int)0x8B9F)        ,
        /// <summary>
        /// Original was GL_OES_point_size_array = 1
        /// </summary>
        OesPointSizeArray = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPointSizeArray : int
    {
        PointSizeArrayTypeOes = ((int)0x898A)        ,
        PointSizeArrayStrideOes = ((int)0x898B)        ,
        PointSizeArrayPointerOes = ((int)0x898C)        ,
        PointSizeArrayOes = ((int)0x8B9C)        ,
        PointSizeArrayBufferBindingOes = ((int)0x8B9F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OespointSprite : int
    {
        /// <summary>
        /// Original was GL_POINT_SPRITE_OES = 0x8861
        /// </summary>
        PointSpriteOes = ((int)0x8861)        ,
        /// <summary>
        /// Original was GL_COORD_REPLACE_OES = 0x8862
        /// </summary>
        CoordReplaceOes = ((int)0x8862)        ,
        /// <summary>
        /// Original was GL_OES_point_sprite = 1
        /// </summary>
        OesPointSprite = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPointSprite : int
    {
        PointSpriteOes = ((int)0x8861)        ,
        CoordReplaceOes = ((int)0x8862)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesqueryMatrix : int
    {
        /// <summary>
        /// Original was GL_OES_query_matrix = 1
        /// </summary>
        OesQueryMatrix = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesQueryMatrix : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesreadFormat : int
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A
        /// </summary>
        ImplementationColorReadTypeOes = ((int)0x8B9A)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B
        /// </summary>
        ImplementationColorReadFormatOes = ((int)0x8B9B)        ,
        /// <summary>
        /// Original was GL_OES_read_format = 1
        /// </summary>
        OesReadFormat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesReadFormat : int
    {
        ImplementationColorReadTypeOes = ((int)0x8B9A)        ,
        ImplementationColorReadFormatOes = ((int)0x8B9B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRequiredInternalformat : int
    {
        Alpha8Oes = ((int)0x803C)        ,
        Luminance8Oes = ((int)0x8040)        ,
        Luminance4Alpha4Oes = ((int)0x8043)        ,
        Luminance8Alpha8Oes = ((int)0x8045)        ,
        Rgb8Oes = ((int)0x8051)        ,
        Rgb10Ext = ((int)0x8052)        ,
        Rgba4Oes = ((int)0x8056)        ,
        Rgb5A1Oes = ((int)0x8057)        ,
        Rgba8Oes = ((int)0x8058)        ,
        Rgb10A2Ext = ((int)0x8059)        ,
        DepthComponent16Oes = ((int)0x81A5)        ,
        DepthComponent24Oes = ((int)0x81A6)        ,
        DepthComponent32Oes = ((int)0x81A7)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        Rgb565Oes = ((int)0x8D62)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesrgb8Rgba8 : int
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRgb8Rgba8 : int
    {
        Rgb8Oes = ((int)0x8051)        ,
        Rgba8Oes = ((int)0x8058)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OessinglePrecision : int
    {
        /// <summary>
        /// Original was GL_OES_single_precision = 1
        /// </summary>
        OesSinglePrecision = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesSinglePrecision : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesstencil1 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46)        ,
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil1 : int
    {
        StencilIndex1Oes = ((int)0x8D46)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesstencil4 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47)        ,
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil4 : int
    {
        StencilIndex4Oes = ((int)0x8D47)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Oesstencil8 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_OES = 0x8D48
        /// </summary>
        StencilIndex8Oes = ((int)0x8D48)        ,
        /// <summary>
        /// Original was GL_OES_stencil8 = 1
        /// </summary>
        OesStencil8 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil8 : int
    {
        StencilIndex8Oes = ((int)0x8D48)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesstencilWrap : int
    {
        /// <summary>
        /// Original was GL_INCR_WRAP_OES = 0x8507
        /// </summary>
        IncrWrapOes = ((int)0x8507)        ,
        /// <summary>
        /// Original was GL_DECR_WRAP_OES = 0x8508
        /// </summary>
        DecrWrapOes = ((int)0x8508)        ,
        /// <summary>
        /// Original was GL_OES_stencil_wrap = 1
        /// </summary>
        OesStencilWrap = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencilWrap : int
    {
        IncrWrapOes = ((int)0x8507)        ,
        DecrWrapOes = ((int)0x8508)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OestextureCubeMap : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_GEN_MODE_OES = 0x2500
        /// </summary>
        TextureGenModeOes = ((int)0x2500)        ,
        /// <summary>
        /// Original was GL_NORMAL_MAP_OES = 0x8511
        /// </summary>
        NormalMapOes = ((int)0x8511)        ,
        /// <summary>
        /// Original was GL_REFLECTION_MAP_OES = 0x8512
        /// </summary>
        ReflectionMapOes = ((int)0x8512)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_OES = 0x8513
        /// </summary>
        TextureCubeMapOes = ((int)0x8513)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP_OES = 0x8514
        /// </summary>
        TextureBindingCubeMapOes = ((int)0x8514)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X_OES = 0x8515
        /// </summary>
        TextureCubeMapPositiveXOes = ((int)0x8515)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X_OES = 0x8516
        /// </summary>
        TextureCubeMapNegativeXOes = ((int)0x8516)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y_OES = 0x8517
        /// </summary>
        TextureCubeMapPositiveYOes = ((int)0x8517)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_OES = 0x8518
        /// </summary>
        TextureCubeMapNegativeYOes = ((int)0x8518)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z_OES = 0x8519
        /// </summary>
        TextureCubeMapPositiveZOes = ((int)0x8519)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_OES = 0x851A
        /// </summary>
        TextureCubeMapNegativeZOes = ((int)0x851A)        ,
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE_OES = 0x851C
        /// </summary>
        MaxCubeMapTextureSizeOes = ((int)0x851C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_GEN_STR_OES = 0x8D60
        /// </summary>
        TextureGenStrOes = ((int)0x8D60)        ,
        /// <summary>
        /// Original was GL_OES_texture_cube_map = 1
        /// </summary>
        OesTextureCubeMap = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureCubeMap : int
    {
        TextureGenModeOes = ((int)0x2500)        ,
        NormalMapOes = ((int)0x8511)        ,
        ReflectionMapOes = ((int)0x8512)        ,
        TextureCubeMapOes = ((int)0x8513)        ,
        TextureBindingCubeMapOes = ((int)0x8514)        ,
        TextureCubeMapPositiveXOes = ((int)0x8515)        ,
        TextureCubeMapNegativeXOes = ((int)0x8516)        ,
        TextureCubeMapPositiveYOes = ((int)0x8517)        ,
        TextureCubeMapNegativeYOes = ((int)0x8518)        ,
        TextureCubeMapPositiveZOes = ((int)0x8519)        ,
        TextureCubeMapNegativeZOes = ((int)0x851A)        ,
        MaxCubeMapTextureSizeOes = ((int)0x851C)        ,
        TextureGenStrOes = ((int)0x8D60)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OestextureEnvCrossbar : int
    {
        /// <summary>
        /// Original was GL_OES_texture_env_crossbar = 1
        /// </summary>
        OesTextureEnvCrossbar = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureEnvCrossbar : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OestextureMirroredRepeat : int
    {
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT_OES = 0x8370
        /// </summary>
        MirroredRepeatOes = ((int)0x8370)        ,
        /// <summary>
        /// Original was GL_OES_texture_mirrored_repeat = 1
        /// </summary>
        OesTextureMirroredRepeat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureMirroredRepeat : int
    {
        MirroredRepeatOes = ((int)0x8370)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexArrayObject : int
    {
        VertexArrayBindingOes = ((int)0x85B5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OpenGlescoreVersions : int
    {
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_0 = 1
        /// </summary>
        VersionEsCl10 = ((int)1)        ,
        /// <summary>
        /// Original was GL_VERSION_ES_CL_1_1 = 1
        /// </summary>
        VersionEsCl11 = ((int)1)        ,
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_0 = 1
        /// </summary>
        VersionEsCm10 = ((int)1)        ,
        /// <summary>
        /// Original was GL_VERSION_ES_CM_1_1 = 1
        /// </summary>
        VersionEsCm11 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelCopyType : int
    {
        Color = ((int)0x1800)        ,
        ColorExt = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        DepthExt = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        StencilExt = ((int)0x1802)        ,
    }

    /// <summary>
    /// Used in GL.CompressedTexSubImage2D, GL.ReadPixels and 2 other functions
    /// </summary>
    public enum PixelFormat : int
    {
        UnsignedShort = ((int)0x1403)        ,
        UnsignedInt = ((int)0x1405)        ,
        ColorIndex = ((int)0x1900)        ,
        StencilIndex = ((int)0x1901)        ,
        DepthComponent = ((int)0x1902)        ,
        Red = ((int)0x1903)        ,
        RedExt = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        AbgrExt = ((int)0x8000)        ,
        CmykExt = ((int)0x800C)        ,
        CmykaExt = ((int)0x800D)        ,
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelMap : int
    {
        PixelMapIToI = ((int)0x0C70)        ,
        PixelMapSToS = ((int)0x0C71)        ,
        PixelMapIToR = ((int)0x0C72)        ,
        PixelMapIToG = ((int)0x0C73)        ,
        PixelMapIToB = ((int)0x0C74)        ,
        PixelMapIToA = ((int)0x0C75)        ,
        PixelMapRToR = ((int)0x0C76)        ,
        PixelMapGToG = ((int)0x0C77)        ,
        PixelMapBToB = ((int)0x0C78)        ,
        PixelMapAToA = ((int)0x0C79)        ,
    }

    /// <summary>
    /// Used in GL.PixelStore
    /// </summary>
    public enum PixelStoreParameter : int
    {
        UnpackSwapBytes = ((int)0x0CF0)        ,
        UnpackLsbFirst = ((int)0x0CF1)        ,
        UnpackRowLength = ((int)0x0CF2)        ,
        UnpackRowLengthExt = ((int)0x0CF2)        ,
        UnpackSkipRows = ((int)0x0CF3)        ,
        UnpackSkipRowsExt = ((int)0x0CF3)        ,
        UnpackSkipPixels = ((int)0x0CF4)        ,
        UnpackSkipPixelsExt = ((int)0x0CF4)        ,
        UnpackAlignment = ((int)0x0CF5)        ,
        PackSwapBytes = ((int)0x0D00)        ,
        PackLsbFirst = ((int)0x0D01)        ,
        PackRowLength = ((int)0x0D02)        ,
        PackSkipRows = ((int)0x0D03)        ,
        PackSkipPixels = ((int)0x0D04)        ,
        PackAlignment = ((int)0x0D05)        ,
        PackSkipImages = ((int)0x806B)        ,
        PackSkipImagesExt = ((int)0x806B)        ,
        PackImageHeight = ((int)0x806C)        ,
        PackImageHeightExt = ((int)0x806C)        ,
        UnpackSkipImages = ((int)0x806D)        ,
        UnpackSkipImagesExt = ((int)0x806D)        ,
        UnpackImageHeight = ((int)0x806E)        ,
        UnpackImageHeightExt = ((int)0x806E)        ,
        PackSkipVolumesSgis = ((int)0x8130)        ,
        PackImageDepthSgis = ((int)0x8131)        ,
        UnpackSkipVolumesSgis = ((int)0x8132)        ,
        UnpackImageDepthSgis = ((int)0x8133)        ,
        PixelTileWidthSgix = ((int)0x8140)        ,
        PixelTileHeightSgix = ((int)0x8141)        ,
        PixelTileGridWidthSgix = ((int)0x8142)        ,
        PixelTileGridHeightSgix = ((int)0x8143)        ,
        PixelTileGridDepthSgix = ((int)0x8144)        ,
        PixelTileCacheSizeSgix = ((int)0x8145)        ,
        PackResampleSgix = ((int)0x842C)        ,
        UnpackResampleSgix = ((int)0x842D)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreResampleMode : int
    {
        ResampleReplicateSgix = ((int)0x842E)        ,
        ResampleZeroFillSgix = ((int)0x842F)        ,
        ResampleDecimateSgix = ((int)0x8430)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelStoreSubsampleRate : int
    {
        PixelSubsample4444Sgix = ((int)0x85A2)        ,
        PixelSubsample2424Sgix = ((int)0x85A3)        ,
        PixelSubsample4242Sgix = ((int)0x85A4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenMode : int
    {
        None = ((int)0)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        PixelTexGenAlphaReplaceSgix = ((int)0x8187)        ,
        PixelTexGenAlphaNoReplaceSgix = ((int)0x8188)        ,
        PixelTexGenAlphaLsSgix = ((int)0x8189)        ,
        PixelTexGenAlphaMsSgix = ((int)0x818A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTexGenParameterNameSgis : int
    {
        PixelFragmentRgbSourceSgis = ((int)0x8354)        ,
        PixelFragmentAlphaSourceSgis = ((int)0x8355)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelTransferParameter : int
    {
        MapColor = ((int)0x0D10)        ,
        MapStencil = ((int)0x0D11)        ,
        IndexShift = ((int)0x0D12)        ,
        IndexOffset = ((int)0x0D13)        ,
        RedScale = ((int)0x0D14)        ,
        RedBias = ((int)0x0D15)        ,
        GreenScale = ((int)0x0D18)        ,
        GreenBias = ((int)0x0D19)        ,
        BlueScale = ((int)0x0D1A)        ,
        BlueBias = ((int)0x0D1B)        ,
        AlphaScale = ((int)0x0D1C)        ,
        AlphaBias = ((int)0x0D1D)        ,
        DepthScale = ((int)0x0D1E)        ,
        DepthBias = ((int)0x0D1F)        ,
        PostConvolutionRedScale = ((int)0x801C)        ,
        PostConvolutionRedScaleExt = ((int)0x801C)        ,
        PostConvolutionGreenScale = ((int)0x801D)        ,
        PostConvolutionGreenScaleExt = ((int)0x801D)        ,
        PostConvolutionBlueScale = ((int)0x801E)        ,
        PostConvolutionBlueScaleExt = ((int)0x801E)        ,
        PostConvolutionAlphaScale = ((int)0x801F)        ,
        PostConvolutionAlphaScaleExt = ((int)0x801F)        ,
        PostConvolutionRedBias = ((int)0x8020)        ,
        PostConvolutionRedBiasExt = ((int)0x8020)        ,
        PostConvolutionGreenBias = ((int)0x8021)        ,
        PostConvolutionGreenBiasExt = ((int)0x8021)        ,
        PostConvolutionBlueBias = ((int)0x8022)        ,
        PostConvolutionBlueBiasExt = ((int)0x8022)        ,
        PostConvolutionAlphaBias = ((int)0x8023)        ,
        PostConvolutionAlphaBiasExt = ((int)0x8023)        ,
        PostColorMatrixRedScale = ((int)0x80B4)        ,
        PostColorMatrixRedScaleSgi = ((int)0x80B4)        ,
        PostColorMatrixGreenScale = ((int)0x80B5)        ,
        PostColorMatrixGreenScaleSgi = ((int)0x80B5)        ,
        PostColorMatrixBlueScale = ((int)0x80B6)        ,
        PostColorMatrixBlueScaleSgi = ((int)0x80B6)        ,
        PostColorMatrixAlphaScale = ((int)0x80B7)        ,
        PostColorMatrixAlphaScaleSgi = ((int)0x80B7)        ,
        PostColorMatrixRedBias = ((int)0x80B8)        ,
        PostColorMatrixRedBiasSgi = ((int)0x80B8)        ,
        PostColorMatrixGreenBias = ((int)0x80B9)        ,
        PostColorMatrixGreenBiasSgi = ((int)0x80B9)        ,
        PostColorMatrixBlueBias = ((int)0x80BA)        ,
        PostColorMatrixBlueBiasSgi = ((int)0x80BA)        ,
        PostColorMatrixAlphaBias = ((int)0x80BB)        ,
        PostColorMatrixAlphaBiasSgi = ((int)0x80BB)        ,
    }

    /// <summary>
    /// Used in GL.ReadPixels, GL.TexImage2D and 1 other function
    /// </summary>
    public enum PixelType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Bitmap = ((int)0x1A00)        ,
        UnsignedByte332 = ((int)0x8032)        ,
        UnsignedByte332Ext = ((int)0x8032)        ,
        UnsignedShort4444 = ((int)0x8033)        ,
        UnsignedShort4444Ext = ((int)0x8033)        ,
        UnsignedShort5551 = ((int)0x8034)        ,
        UnsignedShort5551Ext = ((int)0x8034)        ,
        UnsignedInt8888 = ((int)0x8035)        ,
        UnsignedInt8888Ext = ((int)0x8035)        ,
        UnsignedInt1010102 = ((int)0x8036)        ,
        UnsignedInt1010102Ext = ((int)0x8036)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PointParameterNameSgis : int
    {
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMinArb = ((int)0x8126)        ,
        PointSizeMinExt = ((int)0x8126)        ,
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointSizeMaxArb = ((int)0x8127)        ,
        PointSizeMaxExt = ((int)0x8127)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointFadeThresholdSizeArb = ((int)0x8128)        ,
        PointFadeThresholdSizeExt = ((int)0x8128)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationExt = ((int)0x8129)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
        PointDistanceAttenuationArb = ((int)0x8129)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PolygonMode : int
    {
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
        Fill = ((int)0x1B02)        ,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements and 2 other functions
    /// </summary>
    public enum PrimitiveType : int
    {
        Points = ((int)0x0000)        ,
        Lines = ((int)0x0001)        ,
        LineLoop = ((int)0x0002)        ,
        LineStrip = ((int)0x0003)        ,
        Triangles = ((int)0x0004)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Quads = ((int)0x0007)        ,
        QuadStrip = ((int)0x0008)        ,
        Polygon = ((int)0x0009)        ,
        LinesAdjacency = ((int)0x000A)        ,
        LinesAdjacencyArb = ((int)0x000A)        ,
        LinesAdjacencyExt = ((int)0x000A)        ,
        LineStripAdjacency = ((int)0x000B)        ,
        LineStripAdjacencyArb = ((int)0x000B)        ,
        LineStripAdjacencyExt = ((int)0x000B)        ,
        TrianglesAdjacency = ((int)0x000C)        ,
        TrianglesAdjacencyArb = ((int)0x000C)        ,
        TrianglesAdjacencyExt = ((int)0x000C)        ,
        TriangleStripAdjacency = ((int)0x000D)        ,
        TriangleStripAdjacencyArb = ((int)0x000D)        ,
        TriangleStripAdjacencyExt = ((int)0x000D)        ,
        Patches = ((int)0x000E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomdriverControl : int
    {
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomDriverControl : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet : int
    {
        TextureWidthQcom = ((int)0x8BD2)        ,
        TextureHeightQcom = ((int)0x8BD3)        ,
        TextureDepthQcom = ((int)0x8BD4)        ,
        TextureInternalFormatQcom = ((int)0x8BD5)        ,
        TextureFormatQcom = ((int)0x8BD6)        ,
        TextureTypeQcom = ((int)0x8BD7)        ,
        TextureImageValidQcom = ((int)0x8BD8)        ,
        TextureNumLevelsQcom = ((int)0x8BD9)        ,
        TextureTargetQcom = ((int)0x8BDA)        ,
        TextureObjectValidQcom = ((int)0x8BDB)        ,
        StateRestore = ((int)0x8BDC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet2 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomperfmonGlobalMode : int
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomPerfmonGlobalMode : int
    {
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomTiledRendering : int
    {
        ColorBufferBit0Qcom = ((int)0x00000001)        ,
        ColorBufferBit1Qcom = ((int)0x00000002)        ,
        ColorBufferBit2Qcom = ((int)0x00000004)        ,
        ColorBufferBit3Qcom = ((int)0x00000008)        ,
        ColorBufferBit4Qcom = ((int)0x00000010)        ,
        ColorBufferBit5Qcom = ((int)0x00000020)        ,
        ColorBufferBit6Qcom = ((int)0x00000040)        ,
        ColorBufferBit7Qcom = ((int)0x00000080)        ,
        DepthBufferBit0Qcom = ((int)0x00000100)        ,
        DepthBufferBit1Qcom = ((int)0x00000200)        ,
        DepthBufferBit2Qcom = ((int)0x00000400)        ,
        DepthBufferBit3Qcom = ((int)0x00000800)        ,
        DepthBufferBit4Qcom = ((int)0x00001000)        ,
        DepthBufferBit5Qcom = ((int)0x00002000)        ,
        DepthBufferBit6Qcom = ((int)0x00004000)        ,
        DepthBufferBit7Qcom = ((int)0x00008000)        ,
        StencilBufferBit0Qcom = ((int)0x00010000)        ,
        StencilBufferBit1Qcom = ((int)0x00020000)        ,
        StencilBufferBit2Qcom = ((int)0x00040000)        ,
        StencilBufferBit3Qcom = ((int)0x00080000)        ,
        StencilBufferBit4Qcom = ((int)0x00100000)        ,
        StencilBufferBit5Qcom = ((int)0x00200000)        ,
        StencilBufferBit6Qcom = ((int)0x00400000)        ,
        StencilBufferBit7Qcom = ((int)0x00800000)        ,
        MultisampleBufferBit0Qcom = ((int)0x01000000)        ,
        MultisampleBufferBit1Qcom = ((int)0x02000000)        ,
        MultisampleBufferBit2Qcom = ((int)0x04000000)        ,
        MultisampleBufferBit3Qcom = ((int)0x08000000)        ,
        MultisampleBufferBit4Qcom = ((int)0x10000000)        ,
        MultisampleBufferBit5Qcom = ((int)0x20000000)        ,
        MultisampleBufferBit6Qcom = ((int)0x40000000)        ,
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomWriteonlyRendering : int
    {
        WriteonlyRenderingQcom = ((int)0x8823)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ReadBufferMode : int
    {
        FrontLeft = ((int)0x0400)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        Left = ((int)0x0406)        ,
        Right = ((int)0x0407)        ,
        Aux0 = ((int)0x0409)        ,
        Aux1 = ((int)0x040A)        ,
        Aux2 = ((int)0x040B)        ,
        Aux3 = ((int)0x040C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum RenderingMode : int
    {
        Render = ((int)0x1C00)        ,
        Feedback = ((int)0x1C01)        ,
        Select = ((int)0x1C02)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SamplePatternSgis : int
    {
        Gl1PassExt = ((int)0x80A1)        ,
        Gl1PassSgis = ((int)0x80A1)        ,
        Gl2Pass0Ext = ((int)0x80A2)        ,
        Gl2Pass0Sgis = ((int)0x80A2)        ,
        Gl2Pass1Ext = ((int)0x80A3)        ,
        Gl2Pass1Sgis = ((int)0x80A3)        ,
        Gl4Pass0Ext = ((int)0x80A4)        ,
        Gl4Pass0Sgis = ((int)0x80A4)        ,
        Gl4Pass1Ext = ((int)0x80A5)        ,
        Gl4Pass1Sgis = ((int)0x80A5)        ,
        Gl4Pass2Ext = ((int)0x80A6)        ,
        Gl4Pass2Sgis = ((int)0x80A6)        ,
        Gl4Pass3Ext = ((int)0x80A7)        ,
        Gl4Pass3Sgis = ((int)0x80A7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SeparableTargetExt : int
    {
        Separable2D = ((int)0x8012)        ,
        Separable2DExt = ((int)0x8012)        ,
    }

    /// <summary>
    /// Used in GL.ShadeModel
    /// </summary>
    public enum ShadingModel : int
    {
        Flat = ((int)0x1D00)        ,
        Smooth = ((int)0x1D01)        ,
    }

    /// <summary>
    /// Used in GL.StencilFunc
    /// </summary>
    public enum StencilFunction : int
    {
        Never = ((int)0x0200)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
    }

    /// <summary>
    /// Used in GL.StencilOp
    /// </summary>
    public enum StencilOp : int
    {
        Zero = ((int)0)        ,
        Invert = ((int)0x150A)        ,
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringName : int
    {
        Vendor = ((int)0x1F00)        ,
        Renderer = ((int)0x1F01)        ,
        Version = ((int)0x1F02)        ,
        Extensions = ((int)0x1F03)        ,
    }

    /// <summary>
    /// Used in GL.TexCoordPointer
    /// </summary>
    public enum TexCoordPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureCombineDot3 : int
    {
        /// <summary>
        /// Original was GL_ALPHA_SCALE = 0x0D1C
        /// </summary>
        AlphaScale = ((int)0x0D1C)        ,
        /// <summary>
        /// Original was GL_SUBTRACT = 0x84E7
        /// </summary>
        Subtract = ((int)0x84E7)        ,
        /// <summary>
        /// Original was GL_COMBINE = 0x8570
        /// </summary>
        Combine = ((int)0x8570)        ,
        /// <summary>
        /// Original was GL_COMBINE_RGB = 0x8571
        /// </summary>
        CombineRgb = ((int)0x8571)        ,
        /// <summary>
        /// Original was GL_COMBINE_ALPHA = 0x8572
        /// </summary>
        CombineAlpha = ((int)0x8572)        ,
        /// <summary>
        /// Original was GL_RGB_SCALE = 0x8573
        /// </summary>
        RgbScale = ((int)0x8573)        ,
        /// <summary>
        /// Original was GL_ADD_SIGNED = 0x8574
        /// </summary>
        AddSigned = ((int)0x8574)        ,
        /// <summary>
        /// Original was GL_INTERPOLATE = 0x8575
        /// </summary>
        Interpolate = ((int)0x8575)        ,
        /// <summary>
        /// Original was GL_CONSTANT = 0x8576
        /// </summary>
        Constant = ((int)0x8576)        ,
        /// <summary>
        /// Original was GL_PRIMARY_COLOR = 0x8577
        /// </summary>
        PrimaryColor = ((int)0x8577)        ,
        /// <summary>
        /// Original was GL_PREVIOUS = 0x8578
        /// </summary>
        Previous = ((int)0x8578)        ,
        /// <summary>
        /// Original was GL_SRC0_RGB = 0x8580
        /// </summary>
        Src0Rgb = ((int)0x8580)        ,
        /// <summary>
        /// Original was GL_SRC1_RGB = 0x8581
        /// </summary>
        Src1Rgb = ((int)0x8581)        ,
        /// <summary>
        /// Original was GL_SRC2_RGB = 0x8582
        /// </summary>
        Src2Rgb = ((int)0x8582)        ,
        /// <summary>
        /// Original was GL_SRC0_ALPHA = 0x8588
        /// </summary>
        Src0Alpha = ((int)0x8588)        ,
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589)        ,
        /// <summary>
        /// Original was GL_SRC2_ALPHA = 0x858A
        /// </summary>
        Src2Alpha = ((int)0x858A)        ,
        /// <summary>
        /// Original was GL_OPERAND0_RGB = 0x8590
        /// </summary>
        Operand0Rgb = ((int)0x8590)        ,
        /// <summary>
        /// Original was GL_OPERAND1_RGB = 0x8591
        /// </summary>
        Operand1Rgb = ((int)0x8591)        ,
        /// <summary>
        /// Original was GL_OPERAND2_RGB = 0x8592
        /// </summary>
        Operand2Rgb = ((int)0x8592)        ,
        /// <summary>
        /// Original was GL_OPERAND0_ALPHA = 0x8598
        /// </summary>
        Operand0Alpha = ((int)0x8598)        ,
        /// <summary>
        /// Original was GL_OPERAND1_ALPHA = 0x8599
        /// </summary>
        Operand1Alpha = ((int)0x8599)        ,
        /// <summary>
        /// Original was GL_OPERAND2_ALPHA = 0x859A
        /// </summary>
        Operand2Alpha = ((int)0x859A)        ,
        /// <summary>
        /// Original was GL_DOT3_RGB = 0x86AE
        /// </summary>
        Dot3Rgb = ((int)0x86AE)        ,
        /// <summary>
        /// Original was GL_DOT3_RGBA = 0x86AF
        /// </summary>
        Dot3Rgba = ((int)0x86AF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureCoordName : int
    {
        S = ((int)0x2000)        ,
        T = ((int)0x2001)        ,
        R = ((int)0x2002)        ,
        Q = ((int)0x2003)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvMode : int
    {
        Add = ((int)0x0104)        ,
        Blend = ((int)0x0BE2)        ,
        Modulate = ((int)0x2100)        ,
        Decal = ((int)0x2101)        ,
        ReplaceExt = ((int)0x8062)        ,
        TextureEnvBiasSgix = ((int)0x80BE)        ,
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.TexEnv
    /// </summary>
    public enum TextureEnvParameter : int
    {
        TextureEnvMode = ((int)0x2200)        ,
        TextureEnvColor = ((int)0x2201)        ,
    }

    /// <summary>
    /// Used in GL.GetTexEnv, GL.TexEnv
    /// </summary>
    public enum TextureEnvTarget : int
    {
        TextureEnv = ((int)0x2300)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureFilterFuncSgis : int
    {
        Filter4Sgis = ((int)0x8146)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureGenMode : int
    {
        EyeLinear = ((int)0x2400)        ,
        ObjectLinear = ((int)0x2401)        ,
        SphereMap = ((int)0x2402)        ,
        EyeDistanceToPointSgis = ((int)0x81F0)        ,
        ObjectDistanceToPointSgis = ((int)0x81F1)        ,
        EyeDistanceToLineSgis = ((int)0x81F2)        ,
        ObjectDistanceToLineSgis = ((int)0x81F3)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureGenParameter : int
    {
        TextureGenMode = ((int)0x2500)        ,
        ObjectPlane = ((int)0x2501)        ,
        EyePlane = ((int)0x2502)        ,
        EyePointSgis = ((int)0x81F4)        ,
        ObjectPointSgis = ((int)0x81F5)        ,
        EyeLineSgis = ((int)0x81F6)        ,
        ObjectLineSgis = ((int)0x81F7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMagFilter : int
    {
        Nearest = ((int)0x2600)        ,
        Linear = ((int)0x2601)        ,
        LinearDetailSgis = ((int)0x8097)        ,
        LinearDetailAlphaSgis = ((int)0x8098)        ,
        LinearDetailColorSgis = ((int)0x8099)        ,
        LinearSharpenSgis = ((int)0x80AD)        ,
        LinearSharpenAlphaSgis = ((int)0x80AE)        ,
        LinearSharpenColorSgis = ((int)0x80AF)        ,
        Filter4Sgis = ((int)0x8146)        ,
        PixelTexGenQCeilingSgix = ((int)0x8184)        ,
        PixelTexGenQRoundSgix = ((int)0x8185)        ,
        PixelTexGenQFloorSgix = ((int)0x8186)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMinFilter : int
    {
        Nearest = ((int)0x2600)        ,
        Linear = ((int)0x2601)        ,
        NearestMipmapNearest = ((int)0x2700)        ,
        LinearMipmapNearest = ((int)0x2701)        ,
        NearestMipmapLinear = ((int)0x2702)        ,
        LinearMipmapLinear = ((int)0x2703)        ,
        Filter4Sgis = ((int)0x8146)        ,
        LinearClipmapLinearSgix = ((int)0x8170)        ,
        PixelTexGenQCeilingSgix = ((int)0x8184)        ,
        PixelTexGenQRoundSgix = ((int)0x8185)        ,
        PixelTexGenQFloorSgix = ((int)0x8186)        ,
        NearestClipmapNearestSgix = ((int)0x844D)        ,
        NearestClipmapLinearSgix = ((int)0x844E)        ,
        LinearClipmapNearestSgix = ((int)0x844F)        ,
    }

    /// <summary>
    /// Used in GL.TexParameter
    /// </summary>
    public enum TextureParameterName : int
    {
        TextureBorderColor = ((int)0x1004)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        TexturePriority = ((int)0x8066)        ,
        TexturePriorityExt = ((int)0x8066)        ,
        TextureWrapR = ((int)0x8072)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        TextureWrapROes = ((int)0x8072)        ,
        DetailTextureLevelSgis = ((int)0x809A)        ,
        DetailTextureModeSgis = ((int)0x809B)        ,
        ShadowAmbientSgix = ((int)0x80BF)        ,
        DualTextureSelectSgis = ((int)0x8124)        ,
        QuadTextureSelectSgis = ((int)0x8125)        ,
        TextureWrapQSgis = ((int)0x8137)        ,
        TextureClipmapCenterSgix = ((int)0x8171)        ,
        TextureClipmapFrameSgix = ((int)0x8172)        ,
        TextureClipmapOffsetSgix = ((int)0x8173)        ,
        TextureClipmapVirtualDepthSgix = ((int)0x8174)        ,
        TextureClipmapLodOffsetSgix = ((int)0x8175)        ,
        TextureClipmapDepthSgix = ((int)0x8176)        ,
        PostTextureFilterBiasSgix = ((int)0x8179)        ,
        PostTextureFilterScaleSgix = ((int)0x817A)        ,
        TextureLodBiasSSgix = ((int)0x818E)        ,
        TextureLodBiasTSgix = ((int)0x818F)        ,
        TextureLodBiasRSgix = ((int)0x8190)        ,
        GenerateMipmap = ((int)0x8191)        ,
        GenerateMipmapSgis = ((int)0x8191)        ,
        TextureCompareSgix = ((int)0x819A)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.CompressedTexImage2D and 7 other functions
    /// </summary>
    public enum TextureTarget : int
    {
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture1DExt = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        ProxyTexture2DExt = ((int)0x8064)        ,
        Texture3D = ((int)0x806F)        ,
        Texture3DExt = ((int)0x806F)        ,
        Texture3DOes = ((int)0x806F)        ,
        ProxyTexture3D = ((int)0x8070)        ,
        ProxyTexture3DExt = ((int)0x8070)        ,
        DetailTexture2DSgis = ((int)0x8095)        ,
        Texture4DSgis = ((int)0x8134)        ,
        ProxyTexture4DSgis = ((int)0x8135)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMinLodSgis = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureMaxLodSgis = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureBaseLevelSgis = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
        TextureMaxLevelSgis = ((int)0x813D)        ,
    }

    /// <summary>
    /// Used in GL.ActiveTexture, GL.ClientActiveTexture and 1 other function
    /// </summary>
    public enum TextureUnit : int
    {
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0)        ,
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1)        ,
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2)        ,
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3)        ,
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4)        ,
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5)        ,
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6)        ,
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7)        ,
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8)        ,
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9)        ,
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA)        ,
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB)        ,
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC)        ,
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD)        ,
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE)        ,
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF)        ,
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0)        ,
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1)        ,
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2)        ,
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3)        ,
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4)        ,
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5)        ,
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6)        ,
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7)        ,
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8)        ,
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9)        ,
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA)        ,
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB)        ,
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC)        ,
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD)        ,
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE)        ,
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF)        ,
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0)        ,
        /// <summary>
        /// Original was GL_CLIENT_ACTIVE_TEXTURE = 0x84E1
        /// </summary>
        ClientActiveTexture = ((int)0x84E1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureWrapMode : int
    {
        Clamp = ((int)0x2900)        ,
        Repeat = ((int)0x2901)        ,
        ClampToBorder = ((int)0x812D)        ,
        ClampToBorderArb = ((int)0x812D)        ,
        ClampToBorderNv = ((int)0x812D)        ,
        ClampToBorderSgis = ((int)0x812D)        ,
        ClampToEdge = ((int)0x812F)        ,
        ClampToEdgeSgis = ((int)0x812F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum UseProgramStageMask : int
    {
        VertexShaderBit = ((int)0x00000001)        ,
        VertexShaderBitExt = ((int)0x00000001)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        TessControlShaderBit = ((int)0x00000008)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ComputeShaderBit = ((int)0x00000020)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VersionEsCm10 : int
    {
        False = ((int)0)        ,
        NoError = ((int)0)        ,
        Zero = ((int)0)        ,
        Points = ((int)0x0000)        ,
        DepthBufferBit = ((int)0x00000100)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        Lines = ((int)0x0001)        ,
        LineLoop = ((int)0x0002)        ,
        LineStrip = ((int)0x0003)        ,
        Triangles = ((int)0x0004)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Add = ((int)0x0104)        ,
        Never = ((int)0x0200)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
        InvalidEnum = ((int)0x0500)        ,
        InvalidValue = ((int)0x0501)        ,
        InvalidOperation = ((int)0x0502)        ,
        StackOverflow = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        OutOfMemory = ((int)0x0505)        ,
        Exp = ((int)0x0800)        ,
        Exp2 = ((int)0x0801)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        CurrentColor = ((int)0x0B00)        ,
        CurrentNormal = ((int)0x0B02)        ,
        CurrentTextureCoords = ((int)0x0B03)        ,
        PointSmooth = ((int)0x0B10)        ,
        PointSize = ((int)0x0B11)        ,
        SmoothPointSizeRange = ((int)0x0B12)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineWidth = ((int)0x0B21)        ,
        SmoothLineWidthRange = ((int)0x0B22)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
        Lighting = ((int)0x0B50)        ,
        LightModelTwoSide = ((int)0x0B52)        ,
        LightModelAmbient = ((int)0x0B53)        ,
        ShadeModel = ((int)0x0B54)        ,
        ColorMaterial = ((int)0x0B57)        ,
        Fog = ((int)0x0B60)        ,
        FogDensity = ((int)0x0B62)        ,
        FogStart = ((int)0x0B63)        ,
        FogEnd = ((int)0x0B64)        ,
        FogMode = ((int)0x0B65)        ,
        FogColor = ((int)0x0B66)        ,
        DepthRange = ((int)0x0B70)        ,
        DepthTest = ((int)0x0B71)        ,
        DepthWritemask = ((int)0x0B72)        ,
        DepthClearValue = ((int)0x0B73)        ,
        DepthFunc = ((int)0x0B74)        ,
        StencilTest = ((int)0x0B90)        ,
        StencilClearValue = ((int)0x0B91)        ,
        StencilFunc = ((int)0x0B92)        ,
        StencilValueMask = ((int)0x0B93)        ,
        StencilFail = ((int)0x0B94)        ,
        StencilPassDepthFail = ((int)0x0B95)        ,
        StencilPassDepthPass = ((int)0x0B96)        ,
        StencilRef = ((int)0x0B97)        ,
        StencilWritemask = ((int)0x0B98)        ,
        MatrixMode = ((int)0x0BA0)        ,
        Normalize = ((int)0x0BA1)        ,
        Viewport = ((int)0x0BA2)        ,
        ModelviewStackDepth = ((int)0x0BA3)        ,
        ProjectionStackDepth = ((int)0x0BA4)        ,
        TextureStackDepth = ((int)0x0BA5)        ,
        ModelviewMatrix = ((int)0x0BA6)        ,
        ProjectionMatrix = ((int)0x0BA7)        ,
        TextureMatrix = ((int)0x0BA8)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestFunc = ((int)0x0BC1)        ,
        AlphaTestRef = ((int)0x0BC2)        ,
        Dither = ((int)0x0BD0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        PerspectiveCorrectionHint = ((int)0x0C50)        ,
        PointSmoothHint = ((int)0x0C51)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        FogHint = ((int)0x0C54)        ,
        UnpackAlignment = ((int)0x0CF5)        ,
        PackAlignment = ((int)0x0D05)        ,
        AlphaScale = ((int)0x0D1C)        ,
        MaxLights = ((int)0x0D31)        ,
        MaxClipPlanes = ((int)0x0D32)        ,
        MaxTextureSize = ((int)0x0D33)        ,
        MaxModelviewStackDepth = ((int)0x0D36)        ,
        MaxProjectionStackDepth = ((int)0x0D38)        ,
        MaxTextureStackDepth = ((int)0x0D39)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        SubpixelBits = ((int)0x0D50)        ,
        RedBits = ((int)0x0D52)        ,
        GreenBits = ((int)0x0D53)        ,
        BlueBits = ((int)0x0D54)        ,
        AlphaBits = ((int)0x0D55)        ,
        DepthBits = ((int)0x0D56)        ,
        StencilBits = ((int)0x0D57)        ,
        Texture2D = ((int)0x0DE1)        ,
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0x1101)        ,
        Nicest = ((int)0x1102)        ,
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Position = ((int)0x1203)        ,
        SpotDirection = ((int)0x1204)        ,
        SpotExponent = ((int)0x1205)        ,
        SpotCutoff = ((int)0x1206)        ,
        ConstantAttenuation = ((int)0x1207)        ,
        LinearAttenuation = ((int)0x1208)        ,
        QuadraticAttenuation = ((int)0x1209)        ,
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Float = ((int)0x1406)        ,
        Fixed = ((int)0x140C)        ,
        Clear = ((int)0x1500)        ,
        And = ((int)0x1501)        ,
        AndReverse = ((int)0x1502)        ,
        Copy = ((int)0x1503)        ,
        AndInverted = ((int)0x1504)        ,
        Noop = ((int)0x1505)        ,
        Xor = ((int)0x1506)        ,
        Or = ((int)0x1507)        ,
        Nor = ((int)0x1508)        ,
        Equiv = ((int)0x1509)        ,
        Invert = ((int)0x150A)        ,
        OrReverse = ((int)0x150B)        ,
        CopyInverted = ((int)0x150C)        ,
        OrInverted = ((int)0x150D)        ,
        Nand = ((int)0x150E)        ,
        Set = ((int)0x150F)        ,
        Emission = ((int)0x1600)        ,
        Shininess = ((int)0x1601)        ,
        AmbientAndDiffuse = ((int)0x1602)        ,
        Modelview = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        Flat = ((int)0x1D00)        ,
        Smooth = ((int)0x1D01)        ,
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
        Vendor = ((int)0x1F00)        ,
        Renderer = ((int)0x1F01)        ,
        Version = ((int)0x1F02)        ,
        Extensions = ((int)0x1F03)        ,
        Modulate = ((int)0x2100)        ,
        Decal = ((int)0x2101)        ,
        TextureEnvMode = ((int)0x2200)        ,
        TextureEnvColor = ((int)0x2201)        ,
        TextureEnv = ((int)0x2300)        ,
        Nearest = ((int)0x2600)        ,
        Linear = ((int)0x2601)        ,
        NearestMipmapNearest = ((int)0x2700)        ,
        LinearMipmapNearest = ((int)0x2701)        ,
        NearestMipmapLinear = ((int)0x2702)        ,
        LinearMipmapLinear = ((int)0x2703)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        Repeat = ((int)0x2901)        ,
        PolygonOffsetUnits = ((int)0x2A00)        ,
        ClipPlane0 = ((int)0x3000)        ,
        ClipPlane1 = ((int)0x3001)        ,
        ClipPlane2 = ((int)0x3002)        ,
        ClipPlane3 = ((int)0x3003)        ,
        ClipPlane4 = ((int)0x3004)        ,
        ClipPlane5 = ((int)0x3005)        ,
        Light0 = ((int)0x4000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        UnsignedShort4444 = ((int)0x8033)        ,
        UnsignedShort5551 = ((int)0x8034)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
        RescaleNormal = ((int)0x803A)        ,
        TextureBinding2D = ((int)0x8069)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        TextureCoordArray = ((int)0x8078)        ,
        VertexArraySize = ((int)0x807A)        ,
        VertexArrayType = ((int)0x807B)        ,
        VertexArrayStride = ((int)0x807C)        ,
        NormalArrayType = ((int)0x807E)        ,
        NormalArrayStride = ((int)0x807F)        ,
        ColorArraySize = ((int)0x8081)        ,
        ColorArrayType = ((int)0x8082)        ,
        ColorArrayStride = ((int)0x8083)        ,
        TextureCoordArraySize = ((int)0x8088)        ,
        TextureCoordArrayType = ((int)0x8089)        ,
        TextureCoordArrayStride = ((int)0x808A)        ,
        VertexArrayPointer = ((int)0x808E)        ,
        NormalArrayPointer = ((int)0x808F)        ,
        ColorArrayPointer = ((int)0x8090)        ,
        TextureCoordArrayPointer = ((int)0x8092)        ,
        Multisample = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleBuffers = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
        ClampToEdge = ((int)0x812F)        ,
        GenerateMipmap = ((int)0x8191)        ,
        GenerateMipmapHint = ((int)0x8192)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        AliasedPointSizeRange = ((int)0x846D)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
        Texture0 = ((int)0x84C0)        ,
        Texture1 = ((int)0x84C1)        ,
        Texture2 = ((int)0x84C2)        ,
        Texture3 = ((int)0x84C3)        ,
        Texture4 = ((int)0x84C4)        ,
        Texture5 = ((int)0x84C5)        ,
        Texture6 = ((int)0x84C6)        ,
        Texture7 = ((int)0x84C7)        ,
        Texture8 = ((int)0x84C8)        ,
        Texture9 = ((int)0x84C9)        ,
        Texture10 = ((int)0x84CA)        ,
        Texture11 = ((int)0x84CB)        ,
        Texture12 = ((int)0x84CC)        ,
        Texture13 = ((int)0x84CD)        ,
        Texture14 = ((int)0x84CE)        ,
        Texture15 = ((int)0x84CF)        ,
        Texture16 = ((int)0x84D0)        ,
        Texture17 = ((int)0x84D1)        ,
        Texture18 = ((int)0x84D2)        ,
        Texture19 = ((int)0x84D3)        ,
        Texture20 = ((int)0x84D4)        ,
        Texture21 = ((int)0x84D5)        ,
        Texture22 = ((int)0x84D6)        ,
        Texture23 = ((int)0x84D7)        ,
        Texture24 = ((int)0x84D8)        ,
        Texture25 = ((int)0x84D9)        ,
        Texture26 = ((int)0x84DA)        ,
        Texture27 = ((int)0x84DB)        ,
        Texture28 = ((int)0x84DC)        ,
        Texture29 = ((int)0x84DD)        ,
        Texture30 = ((int)0x84DE)        ,
        Texture31 = ((int)0x84DF)        ,
        ActiveTexture = ((int)0x84E0)        ,
        ClientActiveTexture = ((int)0x84E1)        ,
        MaxTextureUnits = ((int)0x84E2)        ,
        Subtract = ((int)0x84E7)        ,
        Combine = ((int)0x8570)        ,
        CombineRgb = ((int)0x8571)        ,
        CombineAlpha = ((int)0x8572)        ,
        RgbScale = ((int)0x8573)        ,
        AddSigned = ((int)0x8574)        ,
        Interpolate = ((int)0x8575)        ,
        Constant = ((int)0x8576)        ,
        PrimaryColor = ((int)0x8577)        ,
        Previous = ((int)0x8578)        ,
        Src0Rgb = ((int)0x8580)        ,
        Src1Rgb = ((int)0x8581)        ,
        Src2Rgb = ((int)0x8582)        ,
        Src0Alpha = ((int)0x8588)        ,
        Src1Alpha = ((int)0x8589)        ,
        Src2Alpha = ((int)0x858A)        ,
        Operand0Rgb = ((int)0x8590)        ,
        Operand1Rgb = ((int)0x8591)        ,
        Operand2Rgb = ((int)0x8592)        ,
        Operand0Alpha = ((int)0x8598)        ,
        Operand1Alpha = ((int)0x8599)        ,
        Operand2Alpha = ((int)0x859A)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexArrayBufferBinding = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        StaticDraw = ((int)0x88E4)        ,
        DynamicDraw = ((int)0x88E8)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
        VersionEsCl10 = ((int)1)        ,
        VersionEsCl11 = ((int)1)        ,
        VersionEsCm11 = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.VertexPointer
    /// </summary>
    public enum VertexPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

}
