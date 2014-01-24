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

namespace OpenTK.Graphics.ES30
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
    /// Used in GL.GetActiveAttrib
    /// </summary>
    public enum ActiveAttribType : int
    {
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0X1406)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniformBlock
    /// </summary>
    public enum ActiveUniformBlockParameter : int
    {
        UniformBlockBinding = ((int)0x8A3F)        ,
        UniformBlockDataSize = ((int)0x8A40)        ,
        UniformBlockNameLength = ((int)0x8A41)        ,
        UniformBlockActiveUniforms = ((int)0x8A42)        ,
        UniformBlockActiveUniformIndices = ((int)0x8A43)        ,
        UniformBlockReferencedByVertexShader = ((int)0x8A44)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniforms
    /// </summary>
    public enum ActiveUniformParameter : int
    {
        UniformType = ((int)0x8A37)        ,
        UniformSize = ((int)0x8A38)        ,
        UniformNameLength = ((int)0x8A39)        ,
        UniformBlockIndex = ((int)0x8A3A)        ,
        UniformOffset = ((int)0x8A3B)        ,
        UniformArrayStride = ((int)0x8A3C)        ,
        UniformMatrixStride = ((int)0x8A3D)        ,
        UniformIsRowMajor = ((int)0x8A3E)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniform
    /// </summary>
    public enum ActiveUniformType : int
    {
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0X1406)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        Bool = ((int)0X8b56)        ,
        BoolVec2 = ((int)0x8B57)        ,
        BoolVec3 = ((int)0x8B58)        ,
        BoolVec4 = ((int)0x8B59)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
    }

    /// <summary>
    /// Used in GL.Amd.GetPerfMonitorCounterData, GL.Amd.GetPerfMonitorCounterInfo and 194 other functions
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
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001)        ,
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
        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004)        ,
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        LineBit = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
        ColorBufferBit3Qcom = ((int)0x00000008)        ,
        PolygonBit = ((int)0x00000008)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008
        /// </summary>
        QueryDepthBoundsFailEventBitAmd = ((int)0x00000008)        ,
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER_BIT = 0x00000008
        /// </summary>
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
        Never = ((int)0X0200)        ,
        MultisampleBufferBit1Qcom = ((int)0x02000000)        ,
        Less = ((int)0X0201)        ,
        Equal = ((int)0X0202)        ,
        Lequal = ((int)0X0203)        ,
        Greater = ((int)0X0204)        ,
        Notequal = ((int)0X0205)        ,
        Gequal = ((int)0X0206)        ,
        Always = ((int)0X0207)        ,
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
        Front = ((int)0X0404)        ,
        Back = ((int)0X0405)        ,
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
        StackOverflowKhr = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        StackUnderflowKhr = ((int)0x0504)        ,
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
        Cw = ((int)0X0900)        ,
        Ccw = ((int)0X0901)        ,
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
        Viewport = ((int)0X0ba2)        ,
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
        Dither = ((int)0X0bd0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0X0be2)        ,
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
        Fastest = ((int)0X1101)        ,
        Nicest = ((int)0X1102)        ,
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
        Byte = ((int)0X1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0X1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0X1406)        ,
        Gl2Bytes = ((int)0x1407)        ,
        Gl3Bytes = ((int)0x1408)        ,
        Gl4Bytes = ((int)0x1409)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
        Fixed = ((int)0X140c)        ,
        Clear = ((int)0x1500)        ,
        And = ((int)0x1501)        ,
        AndReverse = ((int)0x1502)        ,
        Copy = ((int)0x1503)        ,
        AndInverted = ((int)0x1504)        ,
        Noop = ((int)0x1505)        ,
        Xor = ((int)0x1506)        ,
        XorNv = ((int)0x1506)        ,
        Or = ((int)0x1507)        ,
        Nor = ((int)0x1508)        ,
        Equiv = ((int)0x1509)        ,
        Invert = ((int)0X150a)        ,
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
        RedNv = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        GreenNv = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        BlueNv = ((int)0x1905)        ,
        Alpha = ((int)0X1906)        ,
        Rgb = ((int)0X1907)        ,
        Rgba = ((int)0X1908)        ,
        Luminance = ((int)0X1909)        ,
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
        Keep = ((int)0X1e00)        ,
        Replace = ((int)0X1e01)        ,
        Incr = ((int)0X1e02)        ,
        Decr = ((int)0X1e03)        ,
        Vendor = ((int)0X1f00)        ,
        Renderer = ((int)0X1f01)        ,
        Version = ((int)0X1f02)        ,
        Extensions = ((int)0X1f03)        ,
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
        ObjectPlane = ((int)0x2501)        ,
        EyePlane = ((int)0x2502)        ,
        Nearest = ((int)0X2600)        ,
        Linear = ((int)0X2601)        ,
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
        ConstantColor = ((int)0x8001)        ,
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        BlendColor = ((int)0x8005)        ,
        BlendColorExt = ((int)0x8005)        ,
        FuncAdd = ((int)0x8006)        ,
        FuncAddExt = ((int)0x8006)        ,
        Min = ((int)0x8007)        ,
        MinExt = ((int)0x8007)        ,
        Max = ((int)0x8008)        ,
        MaxExt = ((int)0x8008)        ,
        BlendEquation = ((int)0x8009)        ,
        BlendEquationExt = ((int)0x8009)        ,
        BlendEquationRgb = ((int)0x8009)        ,
        FuncSubtract = ((int)0x800A)        ,
        FuncSubtractExt = ((int)0x800A)        ,
        FuncReverseSubtract = ((int)0x800B)        ,
        FuncReverseSubtractExt = ((int)0x800B)        ,
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
        Rgba4Oes = ((int)0x8056)        ,
        Rgba4 = ((int)0X8056)        ,
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
        TextureBinding3DOes = ((int)0x806A)        ,
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
        Max3DTextureSize = ((int)0x8073)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
        Max3DTextureSizeOes = ((int)0x8073)        ,
        VertexArray = ((int)0x8074)        ,
        VertexArrayKhr = ((int)0x8074)        ,
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
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
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
        SamplesSgis = ((int)0x80A9)        ,
        Samples = ((int)0X80a9)        ,
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
        BlendDstRgb = ((int)0x80C8)        ,
        BlendSrcRgb = ((int)0x80C9)        ,
        BlendDstAlpha = ((int)0x80CA)        ,
        BlendSrcAlpha = ((int)0x80CB)        ,
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
        BgraExt = ((int)0x80E1)        ,
        BgraImg = ((int)0x80E1)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
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
        DepthComponent16 = ((int)0x81A5)        ,
        DepthComponent16Oes = ((int)0x81A5)        ,
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81A6)        ,
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
        FramebufferAttachmentColorEncoding = ((int)0x8210)        ,
        FramebufferAttachmentColorEncodingExt = ((int)0x8210)        ,
        FramebufferAttachmentComponentType = ((int)0x8211)        ,
        FramebufferAttachmentComponentTypeExt = ((int)0x8211)        ,
        FramebufferAttachmentRedSize = ((int)0x8212)        ,
        FramebufferAttachmentGreenSize = ((int)0x8213)        ,
        FramebufferAttachmentBlueSize = ((int)0x8214)        ,
        FramebufferAttachmentAlphaSize = ((int)0x8215)        ,
        FramebufferAttachmentDepthSize = ((int)0x8216)        ,
        FramebufferAttachmentStencilSize = ((int)0x8217)        ,
        FramebufferDefault = ((int)0x8218)        ,
        FramebufferUndefined = ((int)0x8219)        ,
        FramebufferUndefinedOes = ((int)0x8219)        ,
        DepthStencilAttachment = ((int)0x821A)        ,
        MajorVersion = ((int)0x821B)        ,
        MinorVersion = ((int)0x821C)        ,
        NumExtensions = ((int)0x821D)        ,
        Rg = ((int)0x8227)        ,
        RgExt = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R8 = ((int)0x8229)        ,
        R8Ext = ((int)0x8229)        ,
        Rg8 = ((int)0x822B)        ,
        Rg8Ext = ((int)0x822B)        ,
        R16f = ((int)0x822D)        ,
        R16fExt = ((int)0x822D)        ,
        R32f = ((int)0x822E)        ,
        R32fExt = ((int)0x822E)        ,
        Rg16f = ((int)0x822F)        ,
        Rg16fExt = ((int)0x822F)        ,
        Rg32f = ((int)0x8230)        ,
        Rg32fExt = ((int)0x8230)        ,
        R8i = ((int)0x8231)        ,
        R8ui = ((int)0x8232)        ,
        R16i = ((int)0x8233)        ,
        R16ui = ((int)0x8234)        ,
        R32i = ((int)0x8235)        ,
        R32ui = ((int)0x8236)        ,
        Rg8i = ((int)0x8237)        ,
        Rg8ui = ((int)0x8238)        ,
        Rg16i = ((int)0x8239)        ,
        Rg16ui = ((int)0x823A)        ,
        Rg32i = ((int)0x823B)        ,
        Rg32ui = ((int)0x823C)        ,
        DebugOutputSynchronous = ((int)0x8242)        ,
        DebugOutputSynchronousKhr = ((int)0x8242)        ,
        DebugNextLoggedMessageLength = ((int)0x8243)        ,
        DebugNextLoggedMessageLengthKhr = ((int)0x8243)        ,
        DebugCallbackFunction = ((int)0x8244)        ,
        DebugCallbackFunctionKhr = ((int)0x8244)        ,
        DebugCallbackUserParam = ((int)0x8245)        ,
        DebugCallbackUserParamKhr = ((int)0x8245)        ,
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceApiKhr = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceWindowSystemKhr = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceShaderCompilerKhr = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceThirdPartyKhr = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceApplicationKhr = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
        DebugSourceOtherKhr = ((int)0x824B)        ,
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeErrorKhr = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeDeprecatedBehaviorKhr = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypeUndefinedBehaviorKhr = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePortabilityKhr = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypePerformanceKhr = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        DebugTypeOtherKhr = ((int)0x8251)        ,
        LoseContextOnResetExt = ((int)0x8252)        ,
        GuiltyContextResetExt = ((int)0x8253)        ,
        InnocentContextResetExt = ((int)0x8254)        ,
        UnknownContextResetExt = ((int)0x8255)        ,
        ResetNotificationStrategyExt = ((int)0x8256)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparableExt = ((int)0x8258)        ,
        ActiveProgramExt = ((int)0x8259)        ,
        ProgramPipelineBindingExt = ((int)0x825A)        ,
        NoResetNotificationExt = ((int)0x8261)        ,
        DebugTypeMarker = ((int)0x8268)        ,
        DebugTypeMarkerKhr = ((int)0x8268)        ,
        DebugTypePushGroup = ((int)0x8269)        ,
        DebugTypePushGroupKhr = ((int)0x8269)        ,
        DebugTypePopGroup = ((int)0x826A)        ,
        DebugTypePopGroupKhr = ((int)0x826A)        ,
        DebugSeverityNotification = ((int)0x826B)        ,
        DebugSeverityNotificationKhr = ((int)0x826B)        ,
        MaxDebugGroupStackDepth = ((int)0x826C)        ,
        MaxDebugGroupStackDepthKhr = ((int)0x826C)        ,
        DebugGroupStackDepth = ((int)0x826D)        ,
        DebugGroupStackDepthKhr = ((int)0x826D)        ,
        TextureImmutableLevels = ((int)0x82DF)        ,
        Buffer = ((int)0x82E0)        ,
        BufferKhr = ((int)0x82E0)        ,
        Shader = ((int)0x82E1)        ,
        ShaderKhr = ((int)0x82E1)        ,
        Program = ((int)0x82E2)        ,
        ProgramKhr = ((int)0x82E2)        ,
        Query = ((int)0x82E3)        ,
        QueryKhr = ((int)0x82E3)        ,
        ProgramPipeline = ((int)0x82E4)        ,
        Sampler = ((int)0x82E6)        ,
        SamplerKhr = ((int)0x82E6)        ,
        DisplayList = ((int)0x82E7)        ,
        MaxLabelLength = ((int)0x82E8)        ,
        MaxLabelLengthKhr = ((int)0x82E8)        ,
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
        UnsignedShort4444RevExt = ((int)0x8365)        ,
        UnsignedShort4444RevImg = ((int)0x8365)        ,
        UnsignedShort1555RevExt = ((int)0x8366)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        UnsignedInt2101010RevExt = ((int)0x8368)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
        MirroredRepeat = ((int)0x8370)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        CompressedRgbaS3tcDxt3Angle = ((int)0x83F2)        ,
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)        ,
        CompressedRgbaS3tcDxt5Angle = ((int)0x83F3)        ,
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)        ,
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
        Texture0 = ((int)0X84c0)        ,
        Texture1 = ((int)0X84c1)        ,
        Texture2 = ((int)0X84c2)        ,
        Texture3 = ((int)0X84c3)        ,
        Texture4 = ((int)0X84c4)        ,
        Texture5 = ((int)0X84c5)        ,
        Texture6 = ((int)0X84c6)        ,
        Texture7 = ((int)0X84c7)        ,
        Texture8 = ((int)0X84c8)        ,
        Texture9 = ((int)0X84c9)        ,
        Texture10 = ((int)0X84ca)        ,
        Texture11 = ((int)0X84cb)        ,
        Texture12 = ((int)0X84cc)        ,
        Texture13 = ((int)0X84cd)        ,
        Texture14 = ((int)0X84ce)        ,
        Texture15 = ((int)0X84cf)        ,
        Texture16 = ((int)0X84d0)        ,
        Texture17 = ((int)0X84d1)        ,
        Texture18 = ((int)0X84d2)        ,
        Texture19 = ((int)0X84d3)        ,
        Texture20 = ((int)0X84d4)        ,
        Texture21 = ((int)0X84d5)        ,
        Texture22 = ((int)0X84d6)        ,
        Texture23 = ((int)0X84d7)        ,
        Texture24 = ((int)0X84d8)        ,
        Texture25 = ((int)0X84d9)        ,
        Texture26 = ((int)0X84da)        ,
        Texture27 = ((int)0X84db)        ,
        Texture28 = ((int)0X84dc)        ,
        Texture29 = ((int)0X84dd)        ,
        Texture30 = ((int)0X84de)        ,
        Texture31 = ((int)0X84df)        ,
        ActiveTexture = ((int)0x84E0)        ,
        MaxRenderbufferSize = ((int)0x84E8)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        AllCompletedNv = ((int)0x84F2)        ,
        FenceStatusNv = ((int)0x84F3)        ,
        FenceConditionNv = ((int)0x84F4)        ,
        DepthStencil = ((int)0x84F9)        ,
        DepthStencilOes = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        UnsignedInt248Oes = ((int)0x84FA)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        VertexArrayStorageHintApple = ((int)0x851F)        ,
        MultisampleFilterHintNv = ((int)0x8534)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        PixelSubsample4444Sgix = ((int)0x85A2)        ,
        PixelSubsample2424Sgix = ((int)0x85A3)        ,
        PixelSubsample4242Sgix = ((int)0x85A4)        ,
        TransformHintApple = ((int)0x85B1)        ,
        VertexArrayBinding = ((int)0x85B5)        ,
        VertexArrayBindingOes = ((int)0x85B5)        ,
        UnsignedShort88Apple = ((int)0x85BA)        ,
        UnsignedShort88RevApple = ((int)0x85BB)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        VertexAttribArrayPointer = ((int)0x8645)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        Z400BinaryAmd = ((int)0x8740)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        ProgramBinaryLengthOes = ((int)0x8741)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        Gl3DcXAmd = ((int)0x87F9)        ,
        Gl3DcXyAmd = ((int)0x87FA)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        NumProgramBinaryFormatsOes = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        ProgramBinaryFormatsOes = ((int)0x87FF)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
        Rgba32f = ((int)0x8814)        ,
        Rgba32fExt = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgb32fExt = ((int)0x8815)        ,
        Alpha32fExt = ((int)0x8816)        ,
        Luminance32fExt = ((int)0x8818)        ,
        LuminanceAlpha32fExt = ((int)0x8819)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgba16fExt = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        Rgb16fExt = ((int)0x881B)        ,
        Alpha16fExt = ((int)0x881C)        ,
        Luminance16fExt = ((int)0x881E)        ,
        LuminanceAlpha16fExt = ((int)0x881F)        ,
        WriteonlyRenderingQcom = ((int)0x8823)        ,
        MaxDrawBuffers = ((int)0x8824)        ,
        MaxDrawBuffersExt = ((int)0x8824)        ,
        MaxDrawBuffersNv = ((int)0x8824)        ,
        DrawBuffer0 = ((int)0x8825)        ,
        DrawBuffer0Ext = ((int)0x8825)        ,
        DrawBuffer0Nv = ((int)0x8825)        ,
        DrawBuffer1 = ((int)0x8826)        ,
        DrawBuffer1Ext = ((int)0x8826)        ,
        DrawBuffer1Nv = ((int)0x8826)        ,
        DrawBuffer2 = ((int)0x8827)        ,
        DrawBuffer2Ext = ((int)0x8827)        ,
        DrawBuffer2Nv = ((int)0x8827)        ,
        DrawBuffer3 = ((int)0x8828)        ,
        DrawBuffer3Ext = ((int)0x8828)        ,
        DrawBuffer3Nv = ((int)0x8828)        ,
        DrawBuffer4 = ((int)0x8829)        ,
        DrawBuffer4Ext = ((int)0x8829)        ,
        DrawBuffer4Nv = ((int)0x8829)        ,
        DrawBuffer5 = ((int)0x882A)        ,
        DrawBuffer5Ext = ((int)0x882A)        ,
        DrawBuffer5Nv = ((int)0x882A)        ,
        DrawBuffer6 = ((int)0x882B)        ,
        DrawBuffer6Ext = ((int)0x882B)        ,
        DrawBuffer6Nv = ((int)0x882B)        ,
        DrawBuffer7 = ((int)0x882C)        ,
        DrawBuffer7Ext = ((int)0x882C)        ,
        DrawBuffer7Nv = ((int)0x882C)        ,
        DrawBuffer8 = ((int)0x882D)        ,
        DrawBuffer8Ext = ((int)0x882D)        ,
        DrawBuffer8Nv = ((int)0x882D)        ,
        DrawBuffer9 = ((int)0x882E)        ,
        DrawBuffer9Ext = ((int)0x882E)        ,
        DrawBuffer9Nv = ((int)0x882E)        ,
        DrawBuffer10 = ((int)0x882F)        ,
        DrawBuffer10Ext = ((int)0x882F)        ,
        DrawBuffer10Nv = ((int)0x882F)        ,
        DrawBuffer11 = ((int)0x8830)        ,
        DrawBuffer11Ext = ((int)0x8830)        ,
        DrawBuffer11Nv = ((int)0x8830)        ,
        DrawBuffer12 = ((int)0x8831)        ,
        DrawBuffer12Ext = ((int)0x8831)        ,
        DrawBuffer12Nv = ((int)0x8831)        ,
        DrawBuffer13 = ((int)0x8832)        ,
        DrawBuffer13Ext = ((int)0x8832)        ,
        DrawBuffer13Nv = ((int)0x8832)        ,
        DrawBuffer14 = ((int)0x8833)        ,
        DrawBuffer14Ext = ((int)0x8833)        ,
        DrawBuffer14Nv = ((int)0x8833)        ,
        DrawBuffer15 = ((int)0x8834)        ,
        DrawBuffer15Ext = ((int)0x8834)        ,
        DrawBuffer15Nv = ((int)0x8834)        ,
        BlendEquationAlpha = ((int)0x883D)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareModeExt = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        TextureCompareFuncExt = ((int)0x884D)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        CompareRefToTextureExt = ((int)0x884E)        ,
        QueryCounterBitsExt = ((int)0x8864)        ,
        CurrentQuery = ((int)0x8865)        ,
        CurrentQueryExt = ((int)0x8865)        ,
        QueryResult = ((int)0x8866)        ,
        QueryResultExt = ((int)0x8866)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        QueryResultAvailableExt = ((int)0x8867)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        WriteOnlyOes = ((int)0x88B9)        ,
        BufferAccessOes = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMappedOes = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        BufferMapPointerOes = ((int)0x88BD)        ,
        TimeElapsedExt = ((int)0x88BF)        ,
        StreamDraw = ((int)0x88E0)        ,
        StreamRead = ((int)0x88E1)        ,
        StreamCopy = ((int)0x88E2)        ,
        StaticDraw = ((int)0x88E4)        ,
        StaticRead = ((int)0x88E5)        ,
        StaticCopy = ((int)0x88E6)        ,
        DynamicDraw = ((int)0x88E8)        ,
        DynamicRead = ((int)0x88E9)        ,
        DynamicCopy = ((int)0x88EA)        ,
        PixelPackBuffer = ((int)0x88EB)        ,
        PixelUnpackBuffer = ((int)0x88EC)        ,
        PixelPackBufferBinding = ((int)0x88ED)        ,
        Etc1Srgb8Nv = ((int)0x88EE)        ,
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
        VertexAttribArrayDivisorAngle = ((int)0x88FE)        ,
        VertexAttribArrayDivisorExt = ((int)0x88FE)        ,
        VertexAttribArrayDivisorNv = ((int)0x88FE)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        SamplerBinding = ((int)0x8919)        ,
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
        UniformBuffer = ((int)0x8A11)        ,
        Rgb422Apple = ((int)0x8A1F)        ,
        UniformBufferBinding = ((int)0x8A28)        ,
        UniformBufferStart = ((int)0x8A29)        ,
        UniformBufferSize = ((int)0x8A2A)        ,
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        MaxUniformBlockSize = ((int)0x8A30)        ,
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        MaxCombinedFragmentUniformComponents = ((int)0x8A33)        ,
        UniformBufferOffsetAlignment = ((int)0x8A34)        ,
        ActiveUniformBlockMaxNameLength = ((int)0x8A35)        ,
        ActiveUniformBlocks = ((int)0x8A36)        ,
        UniformType = ((int)0x8A37)        ,
        UniformSize = ((int)0x8A38)        ,
        UniformNameLength = ((int)0x8A39)        ,
        UniformBlockIndex = ((int)0x8A3A)        ,
        UniformOffset = ((int)0x8A3B)        ,
        UniformArrayStride = ((int)0x8A3C)        ,
        UniformMatrixStride = ((int)0x8A3D)        ,
        UniformIsRowMajor = ((int)0x8A3E)        ,
        UniformBlockBinding = ((int)0x8A3F)        ,
        UniformBlockDataSize = ((int)0x8A40)        ,
        UniformBlockNameLength = ((int)0x8A41)        ,
        UniformBlockActiveUniforms = ((int)0x8A42)        ,
        UniformBlockActiveUniformIndices = ((int)0x8A43)        ,
        UniformBlockReferencedByVertexShader = ((int)0x8A44)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
        TextureSrgbDecodeExt = ((int)0x8A48)        ,
        DecodeExt = ((int)0x8A49)        ,
        SkipDecodeExt = ((int)0x8A4A)        ,
        ProgramPipelineObjectExt = ((int)0x8A4F)        ,
        RgbRaw422Apple = ((int)0x8A51)        ,
        FragmentShaderDiscardsSamplesExt = ((int)0x8A52)        ,
        SyncObjectApple = ((int)0x8A53)        ,
        CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54)        ,
        CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55)        ,
        CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56)        ,
        CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57)        ,
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        ProgramObjectExt = ((int)0x8B40)        ,
        ShaderObjectExt = ((int)0x8B48)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        ShaderType = ((int)0x8B4F)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        Bool = ((int)0X8b56)        ,
        BoolVec2 = ((int)0x8B57)        ,
        BoolVec3 = ((int)0x8B58)        ,
        BoolVec4 = ((int)0x8B59)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        Sampler3DOes = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        Sampler2DShadowExt = ((int)0x8B62)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x3Nv = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat2x4Nv = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x2Nv = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat3x4Nv = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x2Nv = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        FloatMat4x3Nv = ((int)0x8B6A)        ,
        DeleteStatus = ((int)0x8B80)        ,
        CompileStatus = ((int)0x8B81)        ,
        LinkStatus = ((int)0x8B82)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        AttachedShaders = ((int)0x8B85)        ,
        ActiveUniforms = ((int)0x8B86)        ,
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        ShaderSourceLength = ((int)0x8B88)        ,
        ActiveAttributes = ((int)0x8B89)        ,
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintArb = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        CurrentProgram = ((int)0x8B8D)        ,
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
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        CounterTypeAmd = ((int)0x8BC0)        ,
        CounterRangeAmd = ((int)0x8BC1)        ,
        UnsignedInt64Amd = ((int)0x8BC2)        ,
        PercentageAmd = ((int)0x8BC3)        ,
        PerfmonResultAvailableAmd = ((int)0x8BC4)        ,
        PerfmonResultSizeAmd = ((int)0x8BC5)        ,
        PerfmonResultAmd = ((int)0x8BC6)        ,
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
        SgxBinaryImg = ((int)0x8C0A)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        UnsignedNormalizedExt = ((int)0x8C17)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        AnySamplesPassedExt = ((int)0x8C2F)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        Srgb = ((int)0x8C40)        ,
        SrgbExt = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        Srgb8Nv = ((int)0x8C41)        ,
        SrgbAlphaExt = ((int)0x8C42)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        Srgb8Alpha8Ext = ((int)0x8C43)        ,
        SluminanceAlphaNv = ((int)0x8C44)        ,
        Sluminance8Alpha8Nv = ((int)0x8C45)        ,
        SluminanceNv = ((int)0x8C46)        ,
        Sluminance8Nv = ((int)0x8C47)        ,
        CompressedSrgbS3tcDxt1Nv = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Nv = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Nv = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Nv = ((int)0x8C4F)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        InterleavedAttribs = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        AtcRgbAmd = ((int)0x8C92)        ,
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        DrawFramebufferBindingAngle = ((int)0x8CA6)        ,
        DrawFramebufferBindingApple = ((int)0x8CA6)        ,
        DrawFramebufferBindingNv = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        ReadFramebufferAngle = ((int)0x8CA8)        ,
        ReadFramebufferApple = ((int)0x8CA8)        ,
        ReadFramebufferNv = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        DrawFramebufferAngle = ((int)0x8CA9)        ,
        DrawFramebufferApple = ((int)0x8CA9)        ,
        DrawFramebufferNv = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        ReadFramebufferBindingAngle = ((int)0x8CAA)        ,
        ReadFramebufferBindingApple = ((int)0x8CAA)        ,
        ReadFramebufferBindingNv = ((int)0x8CAA)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        RenderbufferSamplesAngle = ((int)0x8CAB)        ,
        RenderbufferSamplesApple = ((int)0x8CAB)        ,
        RenderbufferSamplesExt = ((int)0x8CAB)        ,
        RenderbufferSamplesNv = ((int)0x8CAB)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensions = ((int)0x8CD9)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
        MaxColorAttachmentsExt = ((int)0x8CDF)        ,
        MaxColorAttachmentsNv = ((int)0x8CDF)        ,
        ColorAttachment0 = ((int)0x8CE0)        ,
        ColorAttachment0Ext = ((int)0x8CE0)        ,
        ColorAttachment0Nv = ((int)0x8CE0)        ,
        ColorAttachment1 = ((int)0x8CE1)        ,
        ColorAttachment1Ext = ((int)0x8CE1)        ,
        ColorAttachment1Nv = ((int)0x8CE1)        ,
        ColorAttachment2 = ((int)0x8CE2)        ,
        ColorAttachment2Ext = ((int)0x8CE2)        ,
        ColorAttachment2Nv = ((int)0x8CE2)        ,
        ColorAttachment3 = ((int)0x8CE3)        ,
        ColorAttachment3Ext = ((int)0x8CE3)        ,
        ColorAttachment3Nv = ((int)0x8CE3)        ,
        ColorAttachment4 = ((int)0x8CE4)        ,
        ColorAttachment4Ext = ((int)0x8CE4)        ,
        ColorAttachment4Nv = ((int)0x8CE4)        ,
        ColorAttachment5 = ((int)0x8CE5)        ,
        ColorAttachment5Ext = ((int)0x8CE5)        ,
        ColorAttachment5Nv = ((int)0x8CE5)        ,
        ColorAttachment6 = ((int)0x8CE6)        ,
        ColorAttachment6Ext = ((int)0x8CE6)        ,
        ColorAttachment6Nv = ((int)0x8CE6)        ,
        ColorAttachment7 = ((int)0x8CE7)        ,
        ColorAttachment7Ext = ((int)0x8CE7)        ,
        ColorAttachment7Nv = ((int)0x8CE7)        ,
        ColorAttachment8 = ((int)0x8CE8)        ,
        ColorAttachment8Ext = ((int)0x8CE8)        ,
        ColorAttachment8Nv = ((int)0x8CE8)        ,
        ColorAttachment9 = ((int)0x8CE9)        ,
        ColorAttachment9Ext = ((int)0x8CE9)        ,
        ColorAttachment9Nv = ((int)0x8CE9)        ,
        ColorAttachment10 = ((int)0x8CEA)        ,
        ColorAttachment10Ext = ((int)0x8CEA)        ,
        ColorAttachment10Nv = ((int)0x8CEA)        ,
        ColorAttachment11 = ((int)0x8CEB)        ,
        ColorAttachment11Ext = ((int)0x8CEB)        ,
        ColorAttachment11Nv = ((int)0x8CEB)        ,
        ColorAttachment12 = ((int)0x8CEC)        ,
        ColorAttachment12Ext = ((int)0x8CEC)        ,
        ColorAttachment12Nv = ((int)0x8CEC)        ,
        ColorAttachment13 = ((int)0x8CED)        ,
        ColorAttachment13Ext = ((int)0x8CED)        ,
        ColorAttachment13Nv = ((int)0x8CED)        ,
        ColorAttachment14 = ((int)0x8CEE)        ,
        ColorAttachment14Ext = ((int)0x8CEE)        ,
        ColorAttachment14Nv = ((int)0x8CEE)        ,
        ColorAttachment15 = ((int)0x8CEF)        ,
        ColorAttachment15Ext = ((int)0x8CEF)        ,
        ColorAttachment15Nv = ((int)0x8CEF)        ,
        DepthAttachment = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        Framebuffer = ((int)0X8d40)        ,
        Renderbuffer = ((int)0X8d41)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        StencilIndex1Oes = ((int)0x8D46)        ,
        StencilIndex4Oes = ((int)0x8D47)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        FramebufferIncompleteMultisampleAngle = ((int)0x8D56)        ,
        FramebufferIncompleteMultisampleApple = ((int)0x8D56)        ,
        FramebufferIncompleteMultisampleExt = ((int)0x8D56)        ,
        FramebufferIncompleteMultisampleNv = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
        MaxSamplesAngle = ((int)0x8D57)        ,
        MaxSamplesApple = ((int)0x8D57)        ,
        MaxSamplesExt = ((int)0x8D57)        ,
        MaxSamplesNv = ((int)0x8D57)        ,
        HalfFloatOes = ((int)0x8D61)        ,
        Rgb565Oes = ((int)0x8D62)        ,
        Rgb565 = ((int)0X8d62)        ,
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        TextureExternalOes = ((int)0x8D65)        ,
        SamplerExternalOes = ((int)0x8D66)        ,
        TextureBindingExternalOes = ((int)0x8D67)        ,
        RequiredTextureImageUnitsOes = ((int)0x8D68)        ,
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        AnySamplesPassedConservativeExt = ((int)0x8D6A)        ,
        MaxElementIndex = ((int)0x8D6B)        ,
        FramebufferAttachmentTextureSamplesExt = ((int)0x8D6C)        ,
        Rgba32ui = ((int)0x8D70)        ,
        Rgb32ui = ((int)0x8D71)        ,
        Rgba16ui = ((int)0x8D76)        ,
        Rgb16ui = ((int)0x8D77)        ,
        Rgba8ui = ((int)0x8D7C)        ,
        Rgb8ui = ((int)0x8D7D)        ,
        Rgba32i = ((int)0x8D82)        ,
        Rgb32i = ((int)0x8D83)        ,
        Rgba16i = ((int)0x8D88)        ,
        Rgb16i = ((int)0x8D89)        ,
        Rgba8i = ((int)0x8D8E)        ,
        Rgb8i = ((int)0x8D8F)        ,
        RedInteger = ((int)0x8D94)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        FramebufferSrgbExt = ((int)0x8DB9)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        Sampler2DArrayShadowNv = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        SamplerCubeShadowNv = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        LowFloat = ((int)0x8DF0)        ,
        MediumFloat = ((int)0x8DF1)        ,
        HighFloat = ((int)0x8DF2)        ,
        LowInt = ((int)0x8DF3)        ,
        MediumInt = ((int)0x8DF4)        ,
        HighInt = ((int)0x8DF5)        ,
        UnsignedInt1010102Oes = ((int)0x8DF6)        ,
        Int1010102Oes = ((int)0x8DF7)        ,
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
        ShaderCompiler = ((int)0x8DFA)        ,
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        MaxVaryingVectors = ((int)0x8DFC)        ,
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackPaused = ((int)0x8E23)        ,
        TransformFeedbackActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        TimestampExt = ((int)0x8E28)        ,
        DepthComponent16NonlinearNv = ((int)0x8E2C)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        CoverageComponentNv = ((int)0x8ED0)        ,
        CoverageComponent4Nv = ((int)0x8ED1)        ,
        CoverageAttachmentNv = ((int)0x8ED2)        ,
        CoverageBuffersNv = ((int)0x8ED3)        ,
        CoverageSamplesNv = ((int)0x8ED4)        ,
        CoverageAllFragmentsNv = ((int)0x8ED5)        ,
        CoverageEdgeFragmentsNv = ((int)0x8ED6)        ,
        CoverageAutomaticNv = ((int)0x8ED7)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyReadBufferBinding = ((int)0x8F36)        ,
        CopyReadBufferNv = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        CopyWriteBufferBinding = ((int)0x8F37)        ,
        CopyWriteBufferNv = ((int)0x8F37)        ,
        MaliShaderBinaryArm = ((int)0x8F60)        ,
        MaliProgramBinaryArm = ((int)0x8F61)        ,
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        SignedNormalized = ((int)0x8F9C)        ,
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
        BinningControlHintQcom = ((int)0x8FB0)        ,
        CpuOptimizedQcom = ((int)0x8FB1)        ,
        GpuOptimizedQcom = ((int)0x8FB2)        ,
        RenderDirectToFramebufferQcom = ((int)0x8FB3)        ,
        GpuDisjointExt = ((int)0x8FBB)        ,
        ShaderBinaryViv = ((int)0x8FC4)        ,
        Rgb10A2ui = ((int)0x906F)        ,
        ColorAttachmentExt = ((int)0x90F0)        ,
        MultiviewExt = ((int)0x90F1)        ,
        MaxMultiviewBuffersExt = ((int)0x90F2)        ,
        ContextRobustAccessExt = ((int)0x90F3)        ,
        MaxServerWaitTimeout = ((int)0x9111)        ,
        MaxServerWaitTimeoutApple = ((int)0x9111)        ,
        ObjectType = ((int)0x9112)        ,
        ObjectTypeApple = ((int)0x9112)        ,
        SyncCondition = ((int)0x9113)        ,
        SyncConditionApple = ((int)0x9113)        ,
        SyncStatus = ((int)0x9114)        ,
        SyncStatusApple = ((int)0x9114)        ,
        SyncFlags = ((int)0x9115)        ,
        SyncFlagsApple = ((int)0x9115)        ,
        SyncFence = ((int)0x9116)        ,
        SyncFenceApple = ((int)0x9116)        ,
        SyncGpuCommandsComplete = ((int)0x9117)        ,
        SyncGpuCommandsCompleteApple = ((int)0x9117)        ,
        Unsignaled = ((int)0x9118)        ,
        UnsignaledApple = ((int)0x9118)        ,
        Signaled = ((int)0x9119)        ,
        SignaledApple = ((int)0x9119)        ,
        AlreadySignaled = ((int)0x911A)        ,
        AlreadySignaledApple = ((int)0x911A)        ,
        TimeoutExpired = ((int)0x911B)        ,
        TimeoutExpiredApple = ((int)0x911B)        ,
        ConditionSatisfied = ((int)0x911C)        ,
        ConditionSatisfiedApple = ((int)0x911C)        ,
        WaitFailed = ((int)0x911D)        ,
        WaitFailedApple = ((int)0x911D)        ,
        BufferAccessFlags = ((int)0x911F)        ,
        BufferMapLength = ((int)0x9120)        ,
        BufferMapOffset = ((int)0x9121)        ,
        MaxVertexOutputComponents = ((int)0x9122)        ,
        MaxFragmentInputComponents = ((int)0x9125)        ,
        TextureImmutableFormat = ((int)0x912F)        ,
        TextureImmutableFormatExt = ((int)0x912F)        ,
        SgxProgramBinaryImg = ((int)0x9130)        ,
        RenderbufferSamplesImg = ((int)0x9133)        ,
        FramebufferIncompleteMultisampleImg = ((int)0x9134)        ,
        MaxSamplesImg = ((int)0x9135)        ,
        TextureSamplesImg = ((int)0x9136)        ,
        CompressedRgbaPvrtc2Bppv2Img = ((int)0x9137)        ,
        CompressedRgbaPvrtc4Bppv2Img = ((int)0x9138)        ,
        MaxDebugMessageLength = ((int)0x9143)        ,
        MaxDebugMessageLengthKhr = ((int)0x9143)        ,
        MaxDebugLoggedMessages = ((int)0x9144)        ,
        MaxDebugLoggedMessagesKhr = ((int)0x9144)        ,
        DebugLoggedMessages = ((int)0x9145)        ,
        DebugLoggedMessagesKhr = ((int)0x9145)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityHighKhr = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityMediumKhr = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
        DebugSeverityLowKhr = ((int)0x9148)        ,
        BufferObjectExt = ((int)0x9151)        ,
        QueryObjectExt = ((int)0x9153)        ,
        VertexArrayObjectExt = ((int)0x9154)        ,
        ShaderBinaryDmp = ((int)0x9250)        ,
        GccsoShaderBinaryFj = ((int)0x9260)        ,
        CompressedR11Eac = ((int)0x9270)        ,
        CompressedSignedR11Eac = ((int)0x9271)        ,
        CompressedRg11Eac = ((int)0x9272)        ,
        CompressedSignedRg11Eac = ((int)0x9273)        ,
        CompressedRgb8Etc2 = ((int)0x9274)        ,
        CompressedSrgb8Etc2 = ((int)0x9275)        ,
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276)        ,
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277)        ,
        CompressedRgba8Etc2Eac = ((int)0x9278)        ,
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279)        ,
        BlendPremultipliedSrcNv = ((int)0x9280)        ,
        BlendOverlapNv = ((int)0x9281)        ,
        UncorrelatedNv = ((int)0x9282)        ,
        DisjointNv = ((int)0x9283)        ,
        ConjointNv = ((int)0x9284)        ,
        BlendAdvancedCoherentNv = ((int)0x9285)        ,
        SrcNv = ((int)0x9286)        ,
        DstNv = ((int)0x9287)        ,
        SrcOverNv = ((int)0x9288)        ,
        DstOverNv = ((int)0x9289)        ,
        SrcInNv = ((int)0x928A)        ,
        DstInNv = ((int)0x928B)        ,
        SrcOutNv = ((int)0x928C)        ,
        DstOutNv = ((int)0x928D)        ,
        SrcAtopNv = ((int)0x928E)        ,
        DstAtopNv = ((int)0x928F)        ,
        PlusNv = ((int)0x9291)        ,
        PlusDarkerNv = ((int)0x9292)        ,
        MultiplyNv = ((int)0x9294)        ,
        ScreenNv = ((int)0x9295)        ,
        OverlayNv = ((int)0x9296)        ,
        DarkenNv = ((int)0x9297)        ,
        LightenNv = ((int)0x9298)        ,
        ColordodgeNv = ((int)0x9299)        ,
        ColorburnNv = ((int)0x929A)        ,
        HardlightNv = ((int)0x929B)        ,
        SoftlightNv = ((int)0x929C)        ,
        DifferenceNv = ((int)0x929E)        ,
        MinusNv = ((int)0x929F)        ,
        ExclusionNv = ((int)0x92A0)        ,
        ContrastNv = ((int)0x92A1)        ,
        InvertRgbNv = ((int)0x92A3)        ,
        LineardodgeNv = ((int)0x92A4)        ,
        LinearburnNv = ((int)0x92A5)        ,
        VividlightNv = ((int)0x92A6)        ,
        LinearlightNv = ((int)0x92A7)        ,
        PinlightNv = ((int)0x92A8)        ,
        HardmixNv = ((int)0x92A9)        ,
        HslHueNv = ((int)0x92AD)        ,
        HslSaturationNv = ((int)0x92AE)        ,
        HslColorNv = ((int)0x92AF)        ,
        HslLuminosityNv = ((int)0x92B0)        ,
        PlusClampedNv = ((int)0x92B1)        ,
        PlusClampedAlphaNv = ((int)0x92B2)        ,
        MinusClampedNv = ((int)0x92B3)        ,
        InvertOvgNv = ((int)0x92B4)        ,
        DebugOutput = ((int)0x92E0)        ,
        DebugOutputKhr = ((int)0x92E0)        ,
        NumSampleCounts = ((int)0x9380)        ,
        TranslatedShaderSourceLengthAngle = ((int)0x93A0)        ,
        Bgra8Ext = ((int)0x93A1)        ,
        TextureUsageAngle = ((int)0x93A2)        ,
        FramebufferAttachmentAngle = ((int)0x93A3)        ,
        PackReverseRowOrderAngle = ((int)0x93A4)        ,
        ProgramBinaryAngle = ((int)0x93A6)        ,
        CompressedRgbaAstc4X4Khr = ((int)0x93B0)        ,
        CompressedRgbaAstc5X4Khr = ((int)0x93B1)        ,
        CompressedRgbaAstc5X5Khr = ((int)0x93B2)        ,
        CompressedRgbaAstc6X5Khr = ((int)0x93B3)        ,
        CompressedRgbaAstc6X6Khr = ((int)0x93B4)        ,
        CompressedRgbaAstc8X5Khr = ((int)0x93B5)        ,
        CompressedRgbaAstc8X6Khr = ((int)0x93B6)        ,
        CompressedRgbaAstc8X8Khr = ((int)0x93B7)        ,
        CompressedRgbaAstc10X5Khr = ((int)0x93B8)        ,
        CompressedRgbaAstc10X6Khr = ((int)0x93B9)        ,
        CompressedRgbaAstc10X8Khr = ((int)0x93BA)        ,
        CompressedRgbaAstc10X10Khr = ((int)0x93BB)        ,
        CompressedRgbaAstc12X10Khr = ((int)0x93BC)        ,
        CompressedRgbaAstc12X12Khr = ((int)0x93BD)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0
        /// </summary>
        CompressedRgbaAstc3X3x3Oes = ((int)0x93C0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1
        /// </summary>
        CompressedRgbaAstc4X3x3Oes = ((int)0x93C1)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2
        /// </summary>
        CompressedRgbaAstc4X4x3Oes = ((int)0x93C2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3
        /// </summary>
        CompressedRgbaAstc4X4x4Oes = ((int)0x93C3)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4
        /// </summary>
        CompressedRgbaAstc5X4x4Oes = ((int)0x93C4)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5
        /// </summary>
        CompressedRgbaAstc5X5x4Oes = ((int)0x93C5)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6
        /// </summary>
        CompressedRgbaAstc5X5x5Oes = ((int)0x93C6)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7
        /// </summary>
        CompressedRgbaAstc6X5x5Oes = ((int)0x93C7)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8
        /// </summary>
        CompressedRgbaAstc6X6x5Oes = ((int)0x93C8)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9
        /// </summary>
        CompressedRgbaAstc6X6x6Oes = ((int)0x93C9)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0)        ,
        CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1)        ,
        CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2)        ,
        CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3)        ,
        CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4)        ,
        CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5)        ,
        CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6)        ,
        CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7)        ,
        CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8)        ,
        CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9)        ,
        CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA)        ,
        CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB)        ,
        CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC)        ,
        CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0
        /// </summary>
        CompressedSrgb8Alpha8Astc3X3x3Oes = ((int)0x93E0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1
        /// </summary>
        CompressedSrgb8Alpha8Astc4X3x3Oes = ((int)0x93E1)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4x3Oes = ((int)0x93E2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4x4Oes = ((int)0x93E3)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4
        /// </summary>
        CompressedSrgb8Alpha8Astc5X4x4Oes = ((int)0x93E4)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5
        /// </summary>
        CompressedSrgb8Alpha8Astc5X5x4Oes = ((int)0x93E5)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6
        /// </summary>
        CompressedSrgb8Alpha8Astc5X5x5Oes = ((int)0x93E6)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7
        /// </summary>
        CompressedSrgb8Alpha8Astc6X5x5Oes = ((int)0x93E7)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8
        /// </summary>
        CompressedSrgb8Alpha8Astc6X6x5Oes = ((int)0x93E8)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9
        /// </summary>
        CompressedSrgb8Alpha8Astc6X6x6Oes = ((int)0x93E9)        ,
        /// <summary>
        /// Original was GL_ALL_ATTRIB_BITS = 0xFFFFFFFF
        /// </summary>
        AllAttribBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF)        ,
        InvalidIndex = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
        TimeoutIgnoredApple = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
        LayoutLinearIntel = ((int)1)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
    }

    /// <summary>
    /// Not used directly.
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
    public enum AmdCompressed3DcTexture : int
    {
        Gl3DcXAmd = ((int)0x87F9)        ,
        Gl3DcXyAmd = ((int)0x87FA)        ,
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
    public enum AmdPerformanceMonitor : int
    {
        CounterTypeAmd = ((int)0x8BC0)        ,
        CounterRangeAmd = ((int)0x8BC1)        ,
        UnsignedInt64Amd = ((int)0x8BC2)        ,
        PercentageAmd = ((int)0x8BC3)        ,
        PerfmonResultAvailableAmd = ((int)0x8BC4)        ,
        PerfmonResultSizeAmd = ((int)0x8BC5)        ,
        PerfmonResultAmd = ((int)0x8BC6)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdProgramBinaryZ400 : int
    {
        Z400BinaryAmd = ((int)0x8740)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleDepthTexture : int
    {
        UnsignedShort = ((int)0x1403)        ,
        UnsignedInt = ((int)0x1405)        ,
        DepthComponent = ((int)0x1902)        ,
        DepthComponent16 = ((int)0x81A5)        ,
        DepthComponent32Oes = ((int)0x81A7)        ,
        DepthStencilOes = ((int)0x84F9)        ,
        UnsignedInt248Oes = ((int)0x84FA)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleFramebufferBlit : int
    {
        DrawFramebufferBindingAngle = ((int)0x8CA6)        ,
        ReadFramebufferAngle = ((int)0x8CA8)        ,
        DrawFramebufferAngle = ((int)0x8CA9)        ,
        ReadFramebufferBindingAngle = ((int)0x8CAA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleFramebufferMultisample : int
    {
        RenderbufferSamplesAngle = ((int)0x8CAB)        ,
        FramebufferIncompleteMultisampleAngle = ((int)0x8D56)        ,
        MaxSamplesAngle = ((int)0x8D57)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleInstancedArrays : int
    {
        VertexAttribArrayDivisorAngle = ((int)0x88FE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AnglePackReverseRowOrder : int
    {
        PackReverseRowOrderAngle = ((int)0x93A4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleProgramBinary : int
    {
        ProgramBinaryAngle = ((int)0x93A6)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleTextureCompressionDxt3 : int
    {
        CompressedRgbaS3tcDxt3Angle = ((int)0x83F2)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleTextureCompressionDxt5 : int
    {
        CompressedRgbaS3tcDxt5Angle = ((int)0x83F3)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleTextureUsage : int
    {
        TextureUsageAngle = ((int)0x93A2)        ,
        FramebufferAttachmentAngle = ((int)0x93A3)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleTranslatedShaderSource : int
    {
        TranslatedShaderSourceLengthAngle = ((int)0x93A0)        ,
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
    public enum AppleRgb422 : int
    {
        UnsignedShort88Apple = ((int)0x85BA)        ,
        UnsignedShort88RevApple = ((int)0x85BB)        ,
        Rgb422Apple = ((int)0x8A1F)        ,
        RgbRaw422Apple = ((int)0x8A51)        ,
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
    public enum ArmMaliProgramBinary : int
    {
        MaliProgramBinaryArm = ((int)0x8F61)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmMaliShaderBinary : int
    {
        MaliShaderBinaryArm = ((int)0x8F60)        ,
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
    /// Not used directly.
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
    /// Used in GL.BlendEquation, GL.BlendEquationSeparate and 1 other function
    /// </summary>
    public enum BlendEquationMode : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = ((int)0x8006)        ,
        /// <summary>
        /// Original was GL_MIN = 0x8007
        /// </summary>
        Min = ((int)0x8007)        ,
        /// <summary>
        /// Original was GL_MAX = 0x8008
        /// </summary>
        Max = ((int)0x8008)        ,
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = ((int)0x800A)        ,
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = ((int)0x800B)        ,
    }

    /// <summary>
    /// Not used directly.
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
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
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
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307)        ,
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308)        ,
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_CONSTANT_COLOR_EXT = 0x8001
        /// </summary>
        ConstantColorExt = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        /// <summary>
        /// Original was GL_One = 1
        /// </summary>
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactorSrc : int
    {
        Zero = ((int)0)        ,
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_CONSTANT_COLOR_EXT = 0x8001
        /// </summary>
        ConstantColorExt = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        /// <summary>
        /// Original was GL_One = 1
        /// </summary>
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.Angle.BlitFramebuffer, GL.BlitFramebuffer and 1 other function
    /// </summary>
    public enum BlitFramebufferFilter : int
    {
        Nearest = ((int)0X2600)        ,
        Linear = ((int)0X2601)        ,
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
    /// Used in GL.MapBufferRange
    /// </summary>
    [Flags]
    public enum BufferAccessMask : int
    {
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
    }

    /// <summary>
    /// Used in GL.GetBufferParameter
    /// </summary>
    public enum BufferParameterName : int
    {
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_FLAGS = 0x911F
        /// </summary>
        BufferAccessFlags = ((int)0x911F)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAP_LENGTH = 0x9120
        /// </summary>
        BufferMapLength = ((int)0x9120)        ,
        BufferMapOffset = ((int)0x9121)        ,
    }

    /// <summary>
    /// Used in GL.GetBufferPointer, GL.Oes.GetBufferPointer
    /// </summary>
    public enum BufferPointer : int
    {
        BufferMapPointer = ((int)0x88BD)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD)        ,
    }

    /// <summary>
    /// Used in GL.BindBufferBase, GL.BindBufferRange
    /// </summary>
    public enum BufferRangeTarget : int
    {
        UniformBuffer = ((int)0x8A11)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
    }

    /// <summary>
    /// Used in GL.BindBuffer, GL.BufferData and 12 other functions
    /// </summary>
    public enum BufferTarget : int
    {
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        PixelPackBuffer = ((int)0x88EB)        ,
        PixelUnpackBuffer = ((int)0x88EC)        ,
        UniformBuffer = ((int)0x8A11)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferUsage : int
    {
        StreamDraw = ((int)0X88e0)        ,
        StaticDraw = ((int)0X88e4)        ,
        DynamicDraw = ((int)0X88e8)        ,
    }

    /// <summary>
    /// Used in GL.BufferData
    /// </summary>
    public enum BufferUsageHint : int
    {
        StreamDraw = ((int)0x88E0)        ,
        StreamRead = ((int)0x88E1)        ,
        StreamCopy = ((int)0x88E2)        ,
        StaticDraw = ((int)0x88E4)        ,
        StaticRead = ((int)0x88E5)        ,
        StaticCopy = ((int)0x88E6)        ,
        DynamicDraw = ((int)0x88E8)        ,
        DynamicRead = ((int)0x88E9)        ,
        DynamicCopy = ((int)0x88EA)        ,
    }

    /// <summary>
    /// Used in GL.ClearBuffer
    /// </summary>
    public enum ClearBuffer : int
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800)        ,
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801)        ,
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802)        ,
    }

    /// <summary>
    /// Used in GL.ClearBuffer
    /// </summary>
    public enum ClearBufferCombined : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9)        ,
    }

    /// <summary>
    /// Used in GL.Angle.BlitFramebuffer, GL.BlitFramebuffer and 2 other functions
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
    /// Used in GL.Apple.ClientWaitSync, GL.ClientWaitSync
    /// </summary>
    public enum ClientWaitSyncFlags : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0)        ,
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT_APPLE = 0x00000001
        /// </summary>
        SyncFlushCommandsBitApple = ((int)0x00000001)        ,
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
    /// Not used directly.
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
    /// Used in GL.CompressedTexImage2D, GL.CompressedTexImage3D and 1 other function
    /// </summary>
    public enum CompressedInternalFormat : int
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = ((int)0x9270)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = ((int)0x9271)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = ((int)0x9272)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = ((int)0x9273)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = ((int)0x9274)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = ((int)0x9275)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = ((int)0x9278)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279)        ,
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
        Front = ((int)0X0404)        ,
        Back = ((int)0X0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DataType : int
    {
    }

    /// <summary>
    /// Used in GL.DebugMessageInsert, GL.GetDebugMessageLog and 2 other functions
    /// </summary>
    public enum DebugSeverity : int
    {
        DebugSeverityNotification = ((int)0x826B)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.Khr.DebugMessageControl
    /// </summary>
    public enum DebugSeverityControl : int
    {
        DontCare = ((int)0x1100)        ,
        DebugSeverityNotification = ((int)0x826B)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DebugSource : int
    {
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.Khr.DebugMessageControl
    /// </summary>
    public enum DebugSourceControl : int
    {
        DontCare = ((int)0x1100)        ,
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageInsert, GL.GetDebugMessageLog and 2 other functions
    /// </summary>
    public enum DebugSourceExternal : int
    {
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageInsert, GL.GetDebugMessageLog and 2 other functions
    /// </summary>
    public enum DebugType : int
    {
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        DebugTypeMarker = ((int)0x8268)        ,
        DebugTypePushGroup = ((int)0x8269)        ,
        DebugTypePopGroup = ((int)0x826A)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl, GL.Khr.DebugMessageControl
    /// </summary>
    public enum DebugTypeControl : int
    {
        DontCare = ((int)0x1100)        ,
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        DebugTypeMarker = ((int)0x8268)        ,
        DebugTypePushGroup = ((int)0x8269)        ,
        DebugTypePopGroup = ((int)0x826A)        ,
    }

    /// <summary>
    /// Used in GL.DepthFunc
    /// </summary>
    public enum DepthFunction : int
    {
        Never = ((int)0X0200)        ,
        Less = ((int)0X0201)        ,
        Equal = ((int)0X0202)        ,
        Lequal = ((int)0X0203)        ,
        Greater = ((int)0X0204)        ,
        Notequal = ((int)0X0205)        ,
        Gequal = ((int)0X0206)        ,
        Always = ((int)0X0207)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DmpShaderBinary : int
    {
        ShaderBinaryDmp = ((int)0x9250)        ,
    }

    /// <summary>
    /// Used in GL.DrawBuffers, GL.Ext.DrawBuffers and 1 other function
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
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF)        ,
    }

    /// <summary>
    /// Used in GL.Angle.DrawElementsInstanced, GL.DrawElements and 5 other functions
    /// </summary>
    public enum DrawElementsType : int
    {
        UnsignedByte = ((int)0x1401)        ,
        UnsignedShort = ((int)0x1403)        ,
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Used in GL.Disable, GL.Enable and 1 other function
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
        Dither = ((int)0X0bd0)        ,
        Blend = ((int)0X0be2)        ,
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
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0)        ,
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
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
        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = ((int)0x8C89)        ,
        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        /// </summary>
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
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
    public enum EsVersion20 : int
    {
        False = ((int)0)        ,
        NoError = ((int)0)        ,
        None = ((int)0)        ,
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
        OutOfMemory = ((int)0x0505)        ,
        InvalidFramebufferOperation = ((int)0x0506)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        LineWidth = ((int)0x0B21)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
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
        Viewport = ((int)0x0BA2)        ,
        Dither = ((int)0x0BD0)        ,
        Blend = ((int)0x0BE2)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        UnpackAlignment = ((int)0x0CF5)        ,
        PackAlignment = ((int)0x0D05)        ,
        MaxTextureSize = ((int)0x0D33)        ,
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
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Fixed = ((int)0x140C)        ,
        Invert = ((int)0x150A)        ,
        Texture = ((int)0x1702)        ,
        DepthComponent = ((int)0x1902)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
        Vendor = ((int)0x1F00)        ,
        Renderer = ((int)0x1F01)        ,
        Version = ((int)0x1F02)        ,
        Extensions = ((int)0x1F03)        ,
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
        ConstantColor = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        BlendColor = ((int)0x8005)        ,
        FuncAdd = ((int)0x8006)        ,
        BlendEquation = ((int)0x8009)        ,
        BlendEquationRgb = ((int)0x8009)        ,
        FuncSubtract = ((int)0x800A)        ,
        FuncReverseSubtract = ((int)0x800B)        ,
        UnsignedShort4444 = ((int)0x8033)        ,
        UnsignedShort5551 = ((int)0x8034)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
        Rgba4 = ((int)0x8056)        ,
        Rgb5A1 = ((int)0x8057)        ,
        TextureBinding2D = ((int)0x8069)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleBuffers = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
        BlendDstRgb = ((int)0x80C8)        ,
        BlendSrcRgb = ((int)0x80C9)        ,
        BlendDstAlpha = ((int)0x80CA)        ,
        BlendSrcAlpha = ((int)0x80CB)        ,
        ClampToEdge = ((int)0x812F)        ,
        GenerateMipmapHint = ((int)0x8192)        ,
        DepthComponent16 = ((int)0x81A5)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        MirroredRepeat = ((int)0x8370)        ,
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
        MaxRenderbufferSize = ((int)0x84E8)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        VertexAttribArrayPointer = ((int)0x8645)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
        BlendEquationAlpha = ((int)0x883D)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        StreamDraw = ((int)0x88E0)        ,
        StaticDraw = ((int)0x88E4)        ,
        DynamicDraw = ((int)0x88E8)        ,
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        ShaderType = ((int)0x8B4F)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        Bool = ((int)0x8B56)        ,
        BoolVec2 = ((int)0x8B57)        ,
        BoolVec3 = ((int)0x8B58)        ,
        BoolVec4 = ((int)0x8B59)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        Sampler2D = ((int)0x8B5E)        ,
        SamplerCube = ((int)0x8B60)        ,
        DeleteStatus = ((int)0x8B80)        ,
        CompileStatus = ((int)0x8B81)        ,
        LinkStatus = ((int)0x8B82)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        AttachedShaders = ((int)0x8B85)        ,
        ActiveUniforms = ((int)0x8B86)        ,
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        ShaderSourceLength = ((int)0x8B88)        ,
        ActiveAttributes = ((int)0x8B89)        ,
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        CurrentProgram = ((int)0x8B8D)        ,
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensions = ((int)0x8CD9)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        ColorAttachment0 = ((int)0x8CE0)        ,
        DepthAttachment = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        Framebuffer = ((int)0x8D40)        ,
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        Rgb565 = ((int)0x8D62)        ,
        LowFloat = ((int)0x8DF0)        ,
        MediumFloat = ((int)0x8DF1)        ,
        HighFloat = ((int)0x8DF2)        ,
        LowInt = ((int)0x8DF3)        ,
        MediumInt = ((int)0x8DF4)        ,
        HighInt = ((int)0x8DF5)        ,
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
        ShaderCompiler = ((int)0x8DFA)        ,
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        MaxVaryingVectors = ((int)0x8DFC)        ,
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum EsVersion30 : int
    {
        SyncFlushCommandsBit = ((int)0x00000001)        ,
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        ReadBuffer = ((int)0x0C02)        ,
        UnpackRowLength = ((int)0x0CF2)        ,
        UnpackSkipRows = ((int)0x0CF3)        ,
        UnpackSkipPixels = ((int)0x0CF4)        ,
        PackRowLength = ((int)0x0D02)        ,
        PackSkipRows = ((int)0x0D03)        ,
        PackSkipPixels = ((int)0x0D04)        ,
        HalfFloat = ((int)0x140B)        ,
        Color = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        Red = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Min = ((int)0x8007)        ,
        Max = ((int)0x8008)        ,
        Rgb8 = ((int)0x8051)        ,
        Rgba8 = ((int)0x8058)        ,
        Rgb10A2 = ((int)0x8059)        ,
        TextureBinding3D = ((int)0x806A)        ,
        UnpackSkipImages = ((int)0x806D)        ,
        UnpackImageHeight = ((int)0x806E)        ,
        Texture3D = ((int)0x806F)        ,
        TextureWrapR = ((int)0x8072)        ,
        Max3DTextureSize = ((int)0x8073)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
        DepthComponent24 = ((int)0x81A6)        ,
        FramebufferAttachmentColorEncoding = ((int)0x8210)        ,
        FramebufferAttachmentComponentType = ((int)0x8211)        ,
        FramebufferAttachmentRedSize = ((int)0x8212)        ,
        FramebufferAttachmentGreenSize = ((int)0x8213)        ,
        FramebufferAttachmentBlueSize = ((int)0x8214)        ,
        FramebufferAttachmentAlphaSize = ((int)0x8215)        ,
        FramebufferAttachmentDepthSize = ((int)0x8216)        ,
        FramebufferAttachmentStencilSize = ((int)0x8217)        ,
        FramebufferDefault = ((int)0x8218)        ,
        FramebufferUndefined = ((int)0x8219)        ,
        DepthStencilAttachment = ((int)0x821A)        ,
        MajorVersion = ((int)0x821B)        ,
        MinorVersion = ((int)0x821C)        ,
        NumExtensions = ((int)0x821D)        ,
        Rg = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R8 = ((int)0x8229)        ,
        Rg8 = ((int)0x822B)        ,
        R16f = ((int)0x822D)        ,
        R32f = ((int)0x822E)        ,
        Rg16f = ((int)0x822F)        ,
        Rg32f = ((int)0x8230)        ,
        R8i = ((int)0x8231)        ,
        R8ui = ((int)0x8232)        ,
        R16i = ((int)0x8233)        ,
        R16ui = ((int)0x8234)        ,
        R32i = ((int)0x8235)        ,
        R32ui = ((int)0x8236)        ,
        Rg8i = ((int)0x8237)        ,
        Rg8ui = ((int)0x8238)        ,
        Rg16i = ((int)0x8239)        ,
        Rg16ui = ((int)0x823A)        ,
        Rg32i = ((int)0x823B)        ,
        Rg32ui = ((int)0x823C)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        TextureImmutableLevels = ((int)0x82DF)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        DepthStencil = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        VertexArrayBinding = ((int)0x85B5)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        Rgba32f = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        MaxDrawBuffers = ((int)0x8824)        ,
        DrawBuffer0 = ((int)0x8825)        ,
        DrawBuffer1 = ((int)0x8826)        ,
        DrawBuffer2 = ((int)0x8827)        ,
        DrawBuffer3 = ((int)0x8828)        ,
        DrawBuffer4 = ((int)0x8829)        ,
        DrawBuffer5 = ((int)0x882A)        ,
        DrawBuffer6 = ((int)0x882B)        ,
        DrawBuffer7 = ((int)0x882C)        ,
        DrawBuffer8 = ((int)0x882D)        ,
        DrawBuffer9 = ((int)0x882E)        ,
        DrawBuffer10 = ((int)0x882F)        ,
        DrawBuffer11 = ((int)0x8830)        ,
        DrawBuffer12 = ((int)0x8831)        ,
        DrawBuffer13 = ((int)0x8832)        ,
        DrawBuffer14 = ((int)0x8833)        ,
        DrawBuffer15 = ((int)0x8834)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        CurrentQuery = ((int)0x8865)        ,
        QueryResult = ((int)0x8866)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        StreamRead = ((int)0x88E1)        ,
        StreamCopy = ((int)0x88E2)        ,
        StaticRead = ((int)0x88E5)        ,
        StaticCopy = ((int)0x88E6)        ,
        DynamicRead = ((int)0x88E9)        ,
        DynamicCopy = ((int)0x88EA)        ,
        PixelPackBuffer = ((int)0x88EB)        ,
        PixelUnpackBuffer = ((int)0x88EC)        ,
        PixelPackBufferBinding = ((int)0x88ED)        ,
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        SamplerBinding = ((int)0x8919)        ,
        UniformBuffer = ((int)0x8A11)        ,
        UniformBufferBinding = ((int)0x8A28)        ,
        UniformBufferStart = ((int)0x8A29)        ,
        UniformBufferSize = ((int)0x8A2A)        ,
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        MaxUniformBlockSize = ((int)0x8A30)        ,
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        MaxCombinedFragmentUniformComponents = ((int)0x8A33)        ,
        UniformBufferOffsetAlignment = ((int)0x8A34)        ,
        ActiveUniformBlockMaxNameLength = ((int)0x8A35)        ,
        ActiveUniformBlocks = ((int)0x8A36)        ,
        UniformType = ((int)0x8A37)        ,
        UniformSize = ((int)0x8A38)        ,
        UniformNameLength = ((int)0x8A39)        ,
        UniformBlockIndex = ((int)0x8A3A)        ,
        UniformOffset = ((int)0x8A3B)        ,
        UniformArrayStride = ((int)0x8A3C)        ,
        UniformMatrixStride = ((int)0x8A3D)        ,
        UniformIsRowMajor = ((int)0x8A3E)        ,
        UniformBlockBinding = ((int)0x8A3F)        ,
        UniformBlockDataSize = ((int)0x8A40)        ,
        UniformBlockNameLength = ((int)0x8A41)        ,
        UniformBlockActiveUniforms = ((int)0x8A42)        ,
        UniformBlockActiveUniformIndices = ((int)0x8A43)        ,
        UniformBlockReferencedByVertexShader = ((int)0x8A44)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        Sampler3D = ((int)0x8B5F)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        Srgb = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        InterleavedAttribs = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
        ColorAttachment1 = ((int)0x8CE1)        ,
        ColorAttachment2 = ((int)0x8CE2)        ,
        ColorAttachment3 = ((int)0x8CE3)        ,
        ColorAttachment4 = ((int)0x8CE4)        ,
        ColorAttachment5 = ((int)0x8CE5)        ,
        ColorAttachment6 = ((int)0x8CE6)        ,
        ColorAttachment7 = ((int)0x8CE7)        ,
        ColorAttachment8 = ((int)0x8CE8)        ,
        ColorAttachment9 = ((int)0x8CE9)        ,
        ColorAttachment10 = ((int)0x8CEA)        ,
        ColorAttachment11 = ((int)0x8CEB)        ,
        ColorAttachment12 = ((int)0x8CEC)        ,
        ColorAttachment13 = ((int)0x8CED)        ,
        ColorAttachment14 = ((int)0x8CEE)        ,
        ColorAttachment15 = ((int)0x8CEF)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        MaxElementIndex = ((int)0x8D6B)        ,
        Rgba32ui = ((int)0x8D70)        ,
        Rgb32ui = ((int)0x8D71)        ,
        Rgba16ui = ((int)0x8D76)        ,
        Rgb16ui = ((int)0x8D77)        ,
        Rgba8ui = ((int)0x8D7C)        ,
        Rgb8ui = ((int)0x8D7D)        ,
        Rgba32i = ((int)0x8D82)        ,
        Rgb32i = ((int)0x8D83)        ,
        Rgba16i = ((int)0x8D88)        ,
        Rgb16i = ((int)0x8D89)        ,
        Rgba8i = ((int)0x8D8E)        ,
        Rgb8i = ((int)0x8D8F)        ,
        RedInteger = ((int)0x8D94)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackPaused = ((int)0x8E23)        ,
        TransformFeedbackActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyReadBufferBinding = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        CopyWriteBufferBinding = ((int)0x8F37)        ,
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        SignedNormalized = ((int)0x8F9C)        ,
        Rgb10A2ui = ((int)0x906F)        ,
        MaxServerWaitTimeout = ((int)0x9111)        ,
        ObjectType = ((int)0x9112)        ,
        SyncCondition = ((int)0x9113)        ,
        SyncStatus = ((int)0x9114)        ,
        SyncFlags = ((int)0x9115)        ,
        SyncFence = ((int)0x9116)        ,
        SyncGpuCommandsComplete = ((int)0x9117)        ,
        Unsignaled = ((int)0x9118)        ,
        Signaled = ((int)0x9119)        ,
        AlreadySignaled = ((int)0x911A)        ,
        TimeoutExpired = ((int)0x911B)        ,
        ConditionSatisfied = ((int)0x911C)        ,
        WaitFailed = ((int)0x911D)        ,
        BufferAccessFlags = ((int)0x911F)        ,
        BufferMapLength = ((int)0x9120)        ,
        BufferMapOffset = ((int)0x9121)        ,
        MaxVertexOutputComponents = ((int)0x9122)        ,
        MaxFragmentInputComponents = ((int)0x9125)        ,
        TextureImmutableFormat = ((int)0x912F)        ,
        CompressedR11Eac = ((int)0x9270)        ,
        CompressedSignedR11Eac = ((int)0x9271)        ,
        CompressedRg11Eac = ((int)0x9272)        ,
        CompressedSignedRg11Eac = ((int)0x9273)        ,
        CompressedRgb8Etc2 = ((int)0x9274)        ,
        CompressedSrgb8Etc2 = ((int)0x9275)        ,
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276)        ,
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277)        ,
        CompressedRgba8Etc2Eac = ((int)0x9278)        ,
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279)        ,
        NumSampleCounts = ((int)0x9380)        ,
        InvalidIndex = unchecked((int)0xFFFFFFFF)        ,
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
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
    public enum ExtColorBufferHalfFloat : int
    {
        FramebufferAttachmentComponentTypeExt = ((int)0x8211)        ,
        R16fExt = ((int)0x822D)        ,
        Rg16fExt = ((int)0x822F)        ,
        Rgba16fExt = ((int)0x881A)        ,
        Rgb16fExt = ((int)0x881B)        ,
        UnsignedNormalizedExt = ((int)0x8C17)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDebugLabel : int
    {
        Sampler = ((int)0x82E6)        ,
        ProgramPipelineObjectExt = ((int)0x8A4F)        ,
        ProgramObjectExt = ((int)0x8B40)        ,
        ShaderObjectExt = ((int)0x8B48)        ,
        TransformFeedback = ((int)0x8E22)        ,
        BufferObjectExt = ((int)0x9151)        ,
        QueryObjectExt = ((int)0x9153)        ,
        VertexArrayObjectExt = ((int)0x9154)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDebugMarker : int
    {
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
    public enum ExtDisjointTimerQuery : int
    {
        QueryCounterBitsExt = ((int)0x8864)        ,
        CurrentQueryExt = ((int)0x8865)        ,
        QueryResultExt = ((int)0x8866)        ,
        QueryResultAvailableExt = ((int)0x8867)        ,
        TimeElapsedExt = ((int)0x88BF)        ,
        TimestampExt = ((int)0x8E28)        ,
        GpuDisjointExt = ((int)0x8FBB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDrawBuffers : int
    {
        MaxDrawBuffersExt = ((int)0x8824)        ,
        DrawBuffer0Ext = ((int)0x8825)        ,
        DrawBuffer1Ext = ((int)0x8826)        ,
        DrawBuffer2Ext = ((int)0x8827)        ,
        DrawBuffer3Ext = ((int)0x8828)        ,
        DrawBuffer4Ext = ((int)0x8829)        ,
        DrawBuffer5Ext = ((int)0x882A)        ,
        DrawBuffer6Ext = ((int)0x882B)        ,
        DrawBuffer7Ext = ((int)0x882C)        ,
        DrawBuffer8Ext = ((int)0x882D)        ,
        DrawBuffer9Ext = ((int)0x882E)        ,
        DrawBuffer10Ext = ((int)0x882F)        ,
        DrawBuffer11Ext = ((int)0x8830)        ,
        DrawBuffer12Ext = ((int)0x8831)        ,
        DrawBuffer13Ext = ((int)0x8832)        ,
        DrawBuffer14Ext = ((int)0x8833)        ,
        DrawBuffer15Ext = ((int)0x8834)        ,
        MaxColorAttachmentsExt = ((int)0x8CDF)        ,
        ColorAttachment0Ext = ((int)0x8CE0)        ,
        ColorAttachment1Ext = ((int)0x8CE1)        ,
        ColorAttachment2Ext = ((int)0x8CE2)        ,
        ColorAttachment3Ext = ((int)0x8CE3)        ,
        ColorAttachment4Ext = ((int)0x8CE4)        ,
        ColorAttachment5Ext = ((int)0x8CE5)        ,
        ColorAttachment6Ext = ((int)0x8CE6)        ,
        ColorAttachment7Ext = ((int)0x8CE7)        ,
        ColorAttachment8Ext = ((int)0x8CE8)        ,
        ColorAttachment9Ext = ((int)0x8CE9)        ,
        ColorAttachment10Ext = ((int)0x8CEA)        ,
        ColorAttachment11Ext = ((int)0x8CEB)        ,
        ColorAttachment12Ext = ((int)0x8CEC)        ,
        ColorAttachment13Ext = ((int)0x8CED)        ,
        ColorAttachment14Ext = ((int)0x8CEE)        ,
        ColorAttachment15Ext = ((int)0x8CEF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDrawInstanced : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtInstancedArrays : int
    {
        VertexAttribArrayDivisorExt = ((int)0x88FE)        ,
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
    public enum ExtMultiviewDrawBuffers : int
    {
        DrawBufferExt = ((int)0x0C01)        ,
        ReadBufferExt = ((int)0x0C02)        ,
        ColorAttachmentExt = ((int)0x90F0)        ,
        MultiviewExt = ((int)0x90F1)        ,
        MaxMultiviewBuffersExt = ((int)0x90F2)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtOcclusionQueryBoolean : int
    {
        CurrentQueryExt = ((int)0x8865)        ,
        QueryResultExt = ((int)0x8866)        ,
        QueryResultAvailableExt = ((int)0x8867)        ,
        AnySamplesPassedExt = ((int)0x8C2F)        ,
        AnySamplesPassedConservativeExt = ((int)0x8D6A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPvrtcSrgb : int
    {
        CompressedSrgbPvrtc2Bppv1Ext = ((int)0x8A54)        ,
        CompressedSrgbPvrtc4Bppv1Ext = ((int)0x8A55)        ,
        CompressedSrgbAlphaPvrtc2Bppv1Ext = ((int)0x8A56)        ,
        CompressedSrgbAlphaPvrtc4Bppv1Ext = ((int)0x8A57)        ,
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
    public enum ExtSeparateShaderObjects : int
    {
        VertexShaderBitExt = ((int)0x00000001)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        ProgramSeparableExt = ((int)0x8258)        ,
        ActiveProgramExt = ((int)0x8259)        ,
        ProgramPipelineBindingExt = ((int)0x825A)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtShaderFramebufferFetch : int
    {
        FragmentShaderDiscardsSamplesExt = ((int)0x8A52)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtShaderIntegerMix : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtShaderTextureLod : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtShadowSamplers : int
    {
        TextureCompareModeExt = ((int)0x884C)        ,
        TextureCompareFuncExt = ((int)0x884D)        ,
        CompareRefToTextureExt = ((int)0x884E)        ,
        Sampler2DShadowExt = ((int)0x8B62)        ,
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
    public enum ExtSrgbWriteControl : int
    {
        FramebufferSrgbExt = ((int)0x8DB9)        ,
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
    public enum ExtTextureCompressionS3tc : int
    {
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)        ,
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)        ,
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
    public enum ExtTextureFormatBgra8888 : int
    {
        BgraExt = ((int)0x80E1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureRg : int
    {
        RedExt = ((int)0x1903)        ,
        RgExt = ((int)0x8227)        ,
        R8Ext = ((int)0x8229)        ,
        Rg8Ext = ((int)0x822B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureSrgbDecode : int
    {
        TextureSrgbDecodeExt = ((int)0x8A48)        ,
        DecodeExt = ((int)0x8A49)        ,
        SkipDecodeExt = ((int)0x8A4A)        ,
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
    public enum ExtTextureType2101010Rev : int
    {
        UnsignedInt2101010RevExt = ((int)0x8368)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtUnpackSubimage : int
    {
        UnpackRowLengthExt = ((int)0x0CF2)        ,
        UnpackSkipRowsExt = ((int)0x0CF3)        ,
        UnpackSkipPixelsExt = ((int)0x0CF4)        ,
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
    public enum FjShaderBinaryGccso : int
    {
        GccsoShaderBinaryFj = ((int)0x9260)        ,
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
    /// Not used directly.
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
    /// Used in GL.FramebufferRenderbuffer, GL.FramebufferTexture2D and 4 other functions
    /// </summary>
    public enum FramebufferAttachment : int
    {
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800)        ,
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801)        ,
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802)        ,
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        /// </summary>
        DepthStencilAttachment = ((int)0x821A)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF)        ,
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00)        ,
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = ((int)0x8D20)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferErrorCode : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensions = ((int)0x8CD9)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD)        ,
    }

    /// <summary>
    /// Used in GL.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferParameterName : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210
        /// </summary>
        FramebufferAttachmentColorEncoding = ((int)0x8210)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211
        /// </summary>
        FramebufferAttachmentComponentType = ((int)0x8211)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212
        /// </summary>
        FramebufferAttachmentRedSize = ((int)0x8212)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213
        /// </summary>
        FramebufferAttachmentGreenSize = ((int)0x8213)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214
        /// </summary>
        FramebufferAttachmentBlueSize = ((int)0x8214)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215
        /// </summary>
        FramebufferAttachmentAlphaSize = ((int)0x8215)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216
        /// </summary>
        FramebufferAttachmentDepthSize = ((int)0x8216)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217
        /// </summary>
        FramebufferAttachmentStencilSize = ((int)0x8217)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4
        /// </summary>
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferSlot : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        /// </summary>
        DepthStencilAttachment = ((int)0x821A)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF)        ,
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00)        ,
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = ((int)0x8D20)        ,
    }

    /// <summary>
    /// Used in GL.BindFramebuffer, GL.CheckFramebufferStatus and 6 other functions
    /// </summary>
    public enum FramebufferTarget : int
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = ((int)0x8CA8)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = ((int)0x8CA9)        ,
        /// <summary>
        /// Original was GL_Framebuffer = 0X8d40
        /// </summary>
        Framebuffer = ((int)0X8d40)        ,
    }

    /// <summary>
    /// Used in GL.FrontFace
    /// </summary>
    public enum FrontFaceDirection : int
    {
        Cw = ((int)0X0900)        ,
        Ccw = ((int)0X0901)        ,
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
    /// Used in GL.GetInteger64, GL.GetInteger and 1 other function
    /// </summary>
    public enum GetIndexedPName : int
    {
        /// <summary>
        /// Original was GL_DRAW_BUFFER_EXT = 0x0C01
        /// </summary>
        DrawBufferExt = ((int)0x0C01)        ,
        /// <summary>
        /// Original was GL_READ_BUFFER_EXT = 0x0C02
        /// </summary>
        ReadBufferExt = ((int)0x0C02)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        /// </summary>
        UniformBufferBinding = ((int)0x8A28)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_START = 0x8A29
        /// </summary>
        UniformBufferStart = ((int)0x8A29)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_SIZE = 0x8A2A
        /// </summary>
        UniformBufferSize = ((int)0x8A2A)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84
        /// </summary>
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85
        /// </summary>
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
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
    /// Used in GL.Apple.GetInteger64, GL.GetBoolean and 3 other functions
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
        Viewport = ((int)0X0ba2)        ,
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
        Dither = ((int)0X0bd0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0X0be2)        ,
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
        /// <summary>
        /// Original was GL_BLEND_COLOR = 0x8005
        /// </summary>
        BlendColor = ((int)0x8005)        ,
        /// <summary>
        /// Original was GL_BLEND_COLOR_EXT = 0x8005
        /// </summary>
        BlendColorExt = ((int)0x8005)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_EXT = 0x8009
        /// </summary>
        BlendEquationExt = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_RGB = 0x8009
        /// </summary>
        BlendEquationRgb = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_BlendEquation = 0X8009
        /// </summary>
        BlendEquation = ((int)0X8009)        ,
        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
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
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D_OES = 0x806A
        /// </summary>
        TextureBinding3DOes = ((int)0x806A)        ,
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = ((int)0x806B)        ,
        PackImageHeightExt = ((int)0x806C)        ,
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = ((int)0x806D)        ,
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = ((int)0x806D)        ,
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = ((int)0x806E)        ,
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = ((int)0x806E)        ,
        Texture3DExt = ((int)0x806F)        ,
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE = 0x8073
        /// </summary>
        Max3DTextureSize = ((int)0x8073)        ,
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_EXT = 0x8073
        /// </summary>
        Max3DTextureSizeExt = ((int)0x8073)        ,
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073
        /// </summary>
        Max3DTextureSizeOes = ((int)0x8073)        ,
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
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
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0)        ,
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0)        ,
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        /// <summary>
        /// Original was GL_SAMPLES_SGIS = 0x80A9
        /// </summary>
        SamplesSgis = ((int)0x80A9)        ,
        Samples = ((int)0X80a9)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = ((int)0x80AA)        ,
        /// <summary>
        /// Original was GL_SAMPLE_MASK_VALUE_SGIS = 0x80AA
        /// </summary>
        SampleMaskValueSgis = ((int)0x80AA)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = ((int)0x80AB)        ,
        SampleMaskInvertSgis = ((int)0x80AB)        ,
        /// <summary>
        /// Original was GL_SAMPLE_PATTERN_SGIS = 0x80AC
        /// </summary>
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
        /// <summary>
        /// Original was GL_BLEND_DST_RGB = 0x80C8
        /// </summary>
        BlendDstRgb = ((int)0x80C8)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB = 0x80C9
        /// </summary>
        BlendSrcRgb = ((int)0x80C9)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA = 0x80CA
        /// </summary>
        BlendDstAlpha = ((int)0x80CA)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA = 0x80CB
        /// </summary>
        BlendSrcAlpha = ((int)0x80CB)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        /// <summary>
        /// Original was GL_MAX_ELEMENTS_VERTICES = 0x80E8
        /// </summary>
        MaxElementsVertices = ((int)0x80E8)        ,
        /// <summary>
        /// Original was GL_MAX_ELEMENTS_INDICES = 0x80E9
        /// </summary>
        MaxElementsIndices = ((int)0x80E9)        ,
        /// <summary>
        /// Original was GL_POINT_SIZE_MIN_SGIS = 0x8126
        /// </summary>
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
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192)        ,
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = ((int)0x8192)        ,
        /// <summary>
        /// Original was GL_DEFORMATIONS_MASK_SGIX = 0x8196
        /// </summary>
        DeformationsMaskSgix = ((int)0x8196)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
        LightModelColorControl = ((int)0x81F8)        ,
        SharedTexturePaletteExt = ((int)0x81FB)        ,
        /// <summary>
        /// Original was GL_MAJOR_VERSION = 0x821B
        /// </summary>
        MajorVersion = ((int)0x821B)        ,
        /// <summary>
        /// Original was GL_MINOR_VERSION = 0x821C
        /// </summary>
        MinorVersion = ((int)0x821C)        ,
        /// <summary>
        /// Original was GL_NUM_EXTENSIONS = 0x821D
        /// </summary>
        NumExtensions = ((int)0x821D)        ,
        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
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
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0)        ,
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        /// </summary>
        MaxRenderbufferSize = ((int)0x84E8)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_LOD_BIAS = 0x84FD
        /// </summary>
        MaxTextureLodBias = ((int)0x84FD)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = ((int)0x8514)        ,
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        /// </summary>
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING = 0x85B5
        /// </summary>
        VertexArrayBinding = ((int)0x85B5)        ,
        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = ((int)0x86A3)        ,
        /// <summary>
        /// Original was GL_NUM_PROGRAM_BINARY_FORMATS = 0x87FE
        /// </summary>
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_FORMATS = 0x87FF
        /// </summary>
        ProgramBinaryFormats = ((int)0x87FF)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FUNC = 0x8800
        /// </summary>
        StencilBackFunc = ((int)0x8800)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FAIL = 0x8801
        /// </summary>
        StencilBackFail = ((int)0x8801)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        /// </summary>
        StencilBackPassDepthFail = ((int)0x8802)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        /// </summary>
        StencilBackPassDepthPass = ((int)0x8803)        ,
        /// <summary>
        /// Original was GL_MAX_DRAW_BUFFERS = 0x8824
        /// </summary>
        MaxDrawBuffers = ((int)0x8824)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER0 = 0x8825
        /// </summary>
        DrawBuffer0 = ((int)0x8825)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER1 = 0x8826
        /// </summary>
        DrawBuffer1 = ((int)0x8826)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER2 = 0x8827
        /// </summary>
        DrawBuffer2 = ((int)0x8827)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER3 = 0x8828
        /// </summary>
        DrawBuffer3 = ((int)0x8828)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER4 = 0x8829
        /// </summary>
        DrawBuffer4 = ((int)0x8829)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER5 = 0x882A
        /// </summary>
        DrawBuffer5 = ((int)0x882A)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER6 = 0x882B
        /// </summary>
        DrawBuffer6 = ((int)0x882B)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER7 = 0x882C
        /// </summary>
        DrawBuffer7 = ((int)0x882C)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER8 = 0x882D
        /// </summary>
        DrawBuffer8 = ((int)0x882D)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER9 = 0x882E
        /// </summary>
        DrawBuffer9 = ((int)0x882E)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER10 = 0x882F
        /// </summary>
        DrawBuffer10 = ((int)0x882F)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER11 = 0x8830
        /// </summary>
        DrawBuffer11 = ((int)0x8830)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER12 = 0x8831
        /// </summary>
        DrawBuffer12 = ((int)0x8831)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER13 = 0x8832
        /// </summary>
        DrawBuffer13 = ((int)0x8832)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER14 = 0x8833
        /// </summary>
        DrawBuffer14 = ((int)0x8833)        ,
        /// <summary>
        /// Original was GL_DRAW_BUFFER15 = 0x8834
        /// </summary>
        DrawBuffer15 = ((int)0x8834)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        /// </summary>
        BlendEquationAlpha = ((int)0x883D)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        /// </summary>
        MaxVertexAttribs = ((int)0x8869)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        /// </summary>
        MaxTextureImageUnits = ((int)0x8872)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895)        ,
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED
        /// </summary>
        PixelPackBufferBinding = ((int)0x88ED)        ,
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF
        /// </summary>
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        /// <summary>
        /// Original was GL_MAX_ARRAY_TEXTURE_LAYERS = 0x88FF
        /// </summary>
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        /// <summary>
        /// Original was GL_MIN_PROGRAM_TEXEL_OFFSET = 0x8904
        /// </summary>
        MinProgramTexelOffset = ((int)0x8904)        ,
        /// <summary>
        /// Original was GL_MAX_PROGRAM_TEXEL_OFFSET = 0x8905
        /// </summary>
        MaxProgramTexelOffset = ((int)0x8905)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_BINDING = 0x8A28
        /// </summary>
        UniformBufferBinding = ((int)0x8A28)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B
        /// </summary>
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D
        /// </summary>
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E
        /// </summary>
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        /// <summary>
        /// Original was GL_MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F
        /// </summary>
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        /// <summary>
        /// Original was GL_MAX_UNIFORM_BLOCK_SIZE = 0x8A30
        /// </summary>
        MaxUniformBlockSize = ((int)0x8A30)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31
        /// </summary>
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33
        /// </summary>
        MaxCombinedFragmentUniformComponents = ((int)0x8A33)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34
        /// </summary>
        UniformBufferOffsetAlignment = ((int)0x8A34)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49
        /// </summary>
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A
        /// </summary>
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        /// <summary>
        /// Original was GL_MAX_VARYING_COMPONENTS = 0x8B4B
        /// </summary>
        MaxVaryingComponents = ((int)0x8B4B)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        /// </summary>
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        /// </summary>
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        /// <summary>
        /// Original was GL_CURRENT_PROGRAM = 0x8B8D
        /// </summary>
        CurrentProgram = ((int)0x8B8D)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = ((int)0x8B9A)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D_ARRAY = 0x8C1D
        /// </summary>
        TextureBinding2DArray = ((int)0x8C1D)        ,
        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80
        /// </summary>
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = ((int)0x8C89)        ,
        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A
        /// </summary>
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        /// <summary>
        /// Original was GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B
        /// </summary>
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F
        /// </summary>
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_REF = 0x8CA3
        /// </summary>
        StencilBackRef = ((int)0x8CA3)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        /// </summary>
        StencilBackValueMask = ((int)0x8CA4)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        /// </summary>
        StencilBackWritemask = ((int)0x8CA5)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_FramebufferBinding = 0X8ca6
        /// </summary>
        FramebufferBinding = ((int)0X8ca6)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        /// </summary>
        RenderbufferBinding = ((int)0x8CA7)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING = 0x8CAA
        /// </summary>
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = ((int)0x8CDF)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES = 0x8D57
        /// </summary>
        MaxSamples = ((int)0x8D57)        ,
        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        /// </summary>
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        /// <summary>
        /// Original was GL_MAX_ELEMENT_INDEX = 0x8D6B
        /// </summary>
        MaxElementIndex = ((int)0x8D6B)        ,
        /// <summary>
        /// Original was GL_SHADER_BINARY_FORMATS = 0x8DF8
        /// </summary>
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        /// <summary>
        /// Original was GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
        /// </summary>
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
        /// <summary>
        /// Original was GL_SHADER_COMPILER = 0x8DFA
        /// </summary>
        ShaderCompiler = ((int)0x8DFA)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
        /// </summary>
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        /// <summary>
        /// Original was GL_MAX_VARYING_VECTORS = 0x8DFC
        /// </summary>
        MaxVaryingVectors = ((int)0x8DFC)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
        /// </summary>
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23
        /// </summary>
        TransformFeedbackPaused = ((int)0x8E23)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24
        /// </summary>
        TransformFeedbackActive = ((int)0x8E24)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BINDING = 0x8E25
        /// </summary>
        TransformFeedbackBinding = ((int)0x8E25)        ,
        /// <summary>
        /// Original was GL_TIMESTAMP_EXT = 0x8E28
        /// </summary>
        TimestampExt = ((int)0x8E28)        ,
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER_BINDING = 0x8F36
        /// </summary>
        CopyReadBufferBinding = ((int)0x8F36)        ,
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER_BINDING = 0x8F37
        /// </summary>
        CopyWriteBufferBinding = ((int)0x8F37)        ,
        /// <summary>
        /// Original was GL_GPU_DISJOINT_EXT = 0x8FBB
        /// </summary>
        GpuDisjointExt = ((int)0x8FBB)        ,
        /// <summary>
        /// Original was GL_MAX_MULTIVIEW_BUFFERS_EXT = 0x90F2
        /// </summary>
        MaxMultiviewBuffersExt = ((int)0x90F2)        ,
        /// <summary>
        /// Original was GL_MAX_SERVER_WAIT_TIMEOUT = 0x9111
        /// </summary>
        MaxServerWaitTimeout = ((int)0x9111)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122
        /// </summary>
        MaxVertexOutputComponents = ((int)0x9122)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125
        /// </summary>
        MaxFragmentInputComponents = ((int)0x9125)        ,
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
    /// Used in GL.GetProgram
    /// </summary>
    public enum GetProgramParameterName : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82)        ,
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83)        ,
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84)        ,
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
    }

    /// <summary>
    /// Used in GL.GetQueryObject, GL.Ext.GetQueryObject
    /// </summary>
    public enum GetQueryObjectParam : int
    {
        /// <summary>
        /// Original was GL_QUERY_RESULT = 0x8866
        /// </summary>
        QueryResult = ((int)0x8866)        ,
        /// <summary>
        /// Original was GL_QUERY_RESULT_EXT = 0x8866
        /// </summary>
        QueryResultExt = ((int)0x8866)        ,
        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE = 0x8867
        /// </summary>
        QueryResultAvailable = ((int)0x8867)        ,
        /// <summary>
        /// Original was GL_QUERY_RESULT_AVAILABLE_EXT = 0x8867
        /// </summary>
        QueryResultAvailableExt = ((int)0x8867)        ,
    }

    /// <summary>
    /// Used in GL.GetQuery, GL.Ext.GetQuery
    /// </summary>
    public enum GetQueryParam : int
    {
        /// <summary>
        /// Original was GL_QUERY_COUNTER_BITS_EXT = 0x8864
        /// </summary>
        QueryCounterBitsExt = ((int)0x8864)        ,
        /// <summary>
        /// Original was GL_CURRENT_QUERY = 0x8865
        /// </summary>
        CurrentQuery = ((int)0x8865)        ,
        /// <summary>
        /// Original was GL_CURRENT_QUERY_EXT = 0x8865
        /// </summary>
        CurrentQueryExt = ((int)0x8865)        ,
    }

    /// <summary>
    /// Not used directly.
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
    /// Used in GL.GetTexParameter
    /// </summary>
    public enum GetTextureParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = ((int)0x813C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = ((int)0x813D)        ,
        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_LEVELS = 0x82DF
        /// </summary>
        TextureImmutableLevels = ((int)0x82DF)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = ((int)0x8E42)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = ((int)0x8E43)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = ((int)0x8E44)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = ((int)0x8E45)        ,
        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT = 0x912F
        /// </summary>
        TextureImmutableFormat = ((int)0x912F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_IMMUTABLE_FORMAT_EXT = 0x912F
        /// </summary>
        TextureImmutableFormatExt = ((int)0x912F)        ,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintMode : int
    {
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0X1101)        ,
        Nicest = ((int)0X1102)        ,
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
    /// Used in GL.GetInternalformat
    /// </summary>
    public enum ImageTarget : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0X8d41
        /// </summary>
        Renderbuffer = ((int)0X8d41)        ,
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
    public enum ImgProgramBinary : int
    {
        SgxProgramBinaryImg = ((int)0x9130)        ,
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
    public enum ImgShaderBinary : int
    {
        SgxBinaryImg = ((int)0x8C0A)        ,
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
    public enum ImgTextureCompressionPvrtc2 : int
    {
        CompressedRgbaPvrtc2Bppv2Img = ((int)0x9137)        ,
        CompressedRgbaPvrtc4Bppv2Img = ((int)0x9138)        ,
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
    /// Used in GL.GetInternalformat
    /// </summary>
    public enum InternalFormatParameter : int
    {
        /// <summary>
        /// Original was GL_SAMPLES = 0X80a9
        /// </summary>
        Samples = ((int)0X80a9)        ,
        /// <summary>
        /// Original was GL_NUM_SAMPLE_COUNTS = 0x9380
        /// </summary>
        NumSampleCounts = ((int)0x9380)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrDebug : int
    {
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ContextFlagDebugBitKhr = ((int)0x00000002)        ,
        StackOverflow = ((int)0x0503)        ,
        StackOverflowKhr = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        StackUnderflowKhr = ((int)0x0504)        ,
        VertexArray = ((int)0x8074)        ,
        VertexArrayKhr = ((int)0x8074)        ,
        DebugOutputSynchronous = ((int)0x8242)        ,
        DebugOutputSynchronousKhr = ((int)0x8242)        ,
        DebugNextLoggedMessageLength = ((int)0x8243)        ,
        DebugNextLoggedMessageLengthKhr = ((int)0x8243)        ,
        DebugCallbackFunction = ((int)0x8244)        ,
        DebugCallbackFunctionKhr = ((int)0x8244)        ,
        DebugCallbackUserParam = ((int)0x8245)        ,
        DebugCallbackUserParamKhr = ((int)0x8245)        ,
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceApiKhr = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceWindowSystemKhr = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceShaderCompilerKhr = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceThirdPartyKhr = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceApplicationKhr = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
        DebugSourceOtherKhr = ((int)0x824B)        ,
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeErrorKhr = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeDeprecatedBehaviorKhr = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypeUndefinedBehaviorKhr = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePortabilityKhr = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypePerformanceKhr = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        DebugTypeOtherKhr = ((int)0x8251)        ,
        DebugTypeMarker = ((int)0x8268)        ,
        DebugTypeMarkerKhr = ((int)0x8268)        ,
        DebugTypePushGroup = ((int)0x8269)        ,
        DebugTypePushGroupKhr = ((int)0x8269)        ,
        DebugTypePopGroup = ((int)0x826A)        ,
        DebugTypePopGroupKhr = ((int)0x826A)        ,
        DebugSeverityNotification = ((int)0x826B)        ,
        DebugSeverityNotificationKhr = ((int)0x826B)        ,
        MaxDebugGroupStackDepth = ((int)0x826C)        ,
        MaxDebugGroupStackDepthKhr = ((int)0x826C)        ,
        DebugGroupStackDepth = ((int)0x826D)        ,
        DebugGroupStackDepthKhr = ((int)0x826D)        ,
        Buffer = ((int)0x82E0)        ,
        BufferKhr = ((int)0x82E0)        ,
        Shader = ((int)0x82E1)        ,
        ShaderKhr = ((int)0x82E1)        ,
        Program = ((int)0x82E2)        ,
        ProgramKhr = ((int)0x82E2)        ,
        Query = ((int)0x82E3)        ,
        QueryKhr = ((int)0x82E3)        ,
        ProgramPipeline = ((int)0x82E4)        ,
        Sampler = ((int)0x82E6)        ,
        SamplerKhr = ((int)0x82E6)        ,
        DisplayList = ((int)0x82E7)        ,
        MaxLabelLength = ((int)0x82E8)        ,
        MaxLabelLengthKhr = ((int)0x82E8)        ,
        MaxDebugMessageLength = ((int)0x9143)        ,
        MaxDebugMessageLengthKhr = ((int)0x9143)        ,
        MaxDebugLoggedMessages = ((int)0x9144)        ,
        MaxDebugLoggedMessagesKhr = ((int)0x9144)        ,
        DebugLoggedMessages = ((int)0x9145)        ,
        DebugLoggedMessagesKhr = ((int)0x9145)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityHighKhr = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityMediumKhr = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
        DebugSeverityLowKhr = ((int)0x9148)        ,
        DebugOutput = ((int)0x92E0)        ,
        DebugOutputKhr = ((int)0x92E0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrTextureCompressionAstcHdr : int
    {
        CompressedRgbaAstc4X4Khr = ((int)0x93B0)        ,
        CompressedRgbaAstc5X4Khr = ((int)0x93B1)        ,
        CompressedRgbaAstc5X5Khr = ((int)0x93B2)        ,
        CompressedRgbaAstc6X5Khr = ((int)0x93B3)        ,
        CompressedRgbaAstc6X6Khr = ((int)0x93B4)        ,
        CompressedRgbaAstc8X5Khr = ((int)0x93B5)        ,
        CompressedRgbaAstc8X6Khr = ((int)0x93B6)        ,
        CompressedRgbaAstc8X8Khr = ((int)0x93B7)        ,
        CompressedRgbaAstc10X5Khr = ((int)0x93B8)        ,
        CompressedRgbaAstc10X6Khr = ((int)0x93B9)        ,
        CompressedRgbaAstc10X8Khr = ((int)0x93BA)        ,
        CompressedRgbaAstc10X10Khr = ((int)0x93BB)        ,
        CompressedRgbaAstc12X10Khr = ((int)0x93BC)        ,
        CompressedRgbaAstc12X12Khr = ((int)0x93BD)        ,
        CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0)        ,
        CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1)        ,
        CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2)        ,
        CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3)        ,
        CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4)        ,
        CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5)        ,
        CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6)        ,
        CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7)        ,
        CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8)        ,
        CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9)        ,
        CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA)        ,
        CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB)        ,
        CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC)        ,
        CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum KhrTextureCompressionAstcLdr : int
    {
        CompressedRgbaAstc4X4Khr = ((int)0x93B0)        ,
        CompressedRgbaAstc5X4Khr = ((int)0x93B1)        ,
        CompressedRgbaAstc5X5Khr = ((int)0x93B2)        ,
        CompressedRgbaAstc6X5Khr = ((int)0x93B3)        ,
        CompressedRgbaAstc6X6Khr = ((int)0x93B4)        ,
        CompressedRgbaAstc8X5Khr = ((int)0x93B5)        ,
        CompressedRgbaAstc8X6Khr = ((int)0x93B6)        ,
        CompressedRgbaAstc8X8Khr = ((int)0x93B7)        ,
        CompressedRgbaAstc10X5Khr = ((int)0x93B8)        ,
        CompressedRgbaAstc10X6Khr = ((int)0x93B9)        ,
        CompressedRgbaAstc10X8Khr = ((int)0x93BA)        ,
        CompressedRgbaAstc10X10Khr = ((int)0x93BB)        ,
        CompressedRgbaAstc12X10Khr = ((int)0x93BC)        ,
        CompressedRgbaAstc12X12Khr = ((int)0x93BD)        ,
        CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0)        ,
        CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1)        ,
        CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2)        ,
        CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3)        ,
        CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4)        ,
        CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5)        ,
        CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6)        ,
        CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7)        ,
        CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8)        ,
        CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9)        ,
        CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA)        ,
        CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB)        ,
        CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC)        ,
        CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD)        ,
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
    /// Not used directly.
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
    /// Not used directly.
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
    /// Not used directly.
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
    /// Not used directly.
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
    /// Not used directly.
    /// </summary>
    public enum MaterialFace : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Not used directly.
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
    /// Not used directly.
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
    /// Not used directly.
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
    public enum NvBlendEquationAdvanced : int
    {
        Zero = ((int)0)        ,
        /// <summary>
        /// Original was GL_XOR_NV = 0x1506
        /// </summary>
        XorNv = ((int)0x1506)        ,
        Invert = ((int)0x150A)        ,
        /// <summary>
        /// Original was GL_RED_NV = 0x1903
        /// </summary>
        RedNv = ((int)0x1903)        ,
        /// <summary>
        /// Original was GL_GREEN_NV = 0x1904
        /// </summary>
        GreenNv = ((int)0x1904)        ,
        /// <summary>
        /// Original was GL_BLUE_NV = 0x1905
        /// </summary>
        BlueNv = ((int)0x1905)        ,
        BlendPremultipliedSrcNv = ((int)0x9280)        ,
        BlendOverlapNv = ((int)0x9281)        ,
        UncorrelatedNv = ((int)0x9282)        ,
        DisjointNv = ((int)0x9283)        ,
        ConjointNv = ((int)0x9284)        ,
        SrcNv = ((int)0x9286)        ,
        DstNv = ((int)0x9287)        ,
        SrcOverNv = ((int)0x9288)        ,
        DstOverNv = ((int)0x9289)        ,
        SrcInNv = ((int)0x928A)        ,
        DstInNv = ((int)0x928B)        ,
        SrcOutNv = ((int)0x928C)        ,
        DstOutNv = ((int)0x928D)        ,
        SrcAtopNv = ((int)0x928E)        ,
        DstAtopNv = ((int)0x928F)        ,
        PlusNv = ((int)0x9291)        ,
        PlusDarkerNv = ((int)0x9292)        ,
        MultiplyNv = ((int)0x9294)        ,
        ScreenNv = ((int)0x9295)        ,
        OverlayNv = ((int)0x9296)        ,
        DarkenNv = ((int)0x9297)        ,
        LightenNv = ((int)0x9298)        ,
        ColordodgeNv = ((int)0x9299)        ,
        ColorburnNv = ((int)0x929A)        ,
        HardlightNv = ((int)0x929B)        ,
        SoftlightNv = ((int)0x929C)        ,
        DifferenceNv = ((int)0x929E)        ,
        MinusNv = ((int)0x929F)        ,
        ExclusionNv = ((int)0x92A0)        ,
        ContrastNv = ((int)0x92A1)        ,
        InvertRgbNv = ((int)0x92A3)        ,
        LineardodgeNv = ((int)0x92A4)        ,
        LinearburnNv = ((int)0x92A5)        ,
        VividlightNv = ((int)0x92A6)        ,
        LinearlightNv = ((int)0x92A7)        ,
        PinlightNv = ((int)0x92A8)        ,
        HardmixNv = ((int)0x92A9)        ,
        HslHueNv = ((int)0x92AD)        ,
        HslSaturationNv = ((int)0x92AE)        ,
        HslColorNv = ((int)0x92AF)        ,
        HslLuminosityNv = ((int)0x92B0)        ,
        PlusClampedNv = ((int)0x92B1)        ,
        PlusClampedAlphaNv = ((int)0x92B2)        ,
        MinusClampedNv = ((int)0x92B3)        ,
        InvertOvgNv = ((int)0x92B4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvBlendEquationAdvancedCoherent : int
    {
        BlendAdvancedCoherentNv = ((int)0x9285)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvCopyBuffer : int
    {
        CopyReadBufferNv = ((int)0x8F36)        ,
        CopyWriteBufferNv = ((int)0x8F37)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvCoverageSample : int
    {
        CoverageBufferBitNv = ((int)0x00008000)        ,
        CoverageComponentNv = ((int)0x8ED0)        ,
        CoverageComponent4Nv = ((int)0x8ED1)        ,
        CoverageAttachmentNv = ((int)0x8ED2)        ,
        CoverageBuffersNv = ((int)0x8ED3)        ,
        CoverageSamplesNv = ((int)0x8ED4)        ,
        CoverageAllFragmentsNv = ((int)0x8ED5)        ,
        CoverageEdgeFragmentsNv = ((int)0x8ED6)        ,
        CoverageAutomaticNv = ((int)0x8ED7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDepthNonlinear : int
    {
        DepthComponent16NonlinearNv = ((int)0x8E2C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDrawBuffers : int
    {
        MaxDrawBuffersNv = ((int)0x8824)        ,
        DrawBuffer0Nv = ((int)0x8825)        ,
        DrawBuffer1Nv = ((int)0x8826)        ,
        DrawBuffer2Nv = ((int)0x8827)        ,
        DrawBuffer3Nv = ((int)0x8828)        ,
        DrawBuffer4Nv = ((int)0x8829)        ,
        DrawBuffer5Nv = ((int)0x882A)        ,
        DrawBuffer6Nv = ((int)0x882B)        ,
        DrawBuffer7Nv = ((int)0x882C)        ,
        DrawBuffer8Nv = ((int)0x882D)        ,
        DrawBuffer9Nv = ((int)0x882E)        ,
        DrawBuffer10Nv = ((int)0x882F)        ,
        DrawBuffer11Nv = ((int)0x8830)        ,
        DrawBuffer12Nv = ((int)0x8831)        ,
        DrawBuffer13Nv = ((int)0x8832)        ,
        DrawBuffer14Nv = ((int)0x8833)        ,
        DrawBuffer15Nv = ((int)0x8834)        ,
        ColorAttachment0Nv = ((int)0x8CE0)        ,
        ColorAttachment1Nv = ((int)0x8CE1)        ,
        ColorAttachment2Nv = ((int)0x8CE2)        ,
        ColorAttachment3Nv = ((int)0x8CE3)        ,
        ColorAttachment4Nv = ((int)0x8CE4)        ,
        ColorAttachment5Nv = ((int)0x8CE5)        ,
        ColorAttachment6Nv = ((int)0x8CE6)        ,
        ColorAttachment7Nv = ((int)0x8CE7)        ,
        ColorAttachment8Nv = ((int)0x8CE8)        ,
        ColorAttachment9Nv = ((int)0x8CE9)        ,
        ColorAttachment10Nv = ((int)0x8CEA)        ,
        ColorAttachment11Nv = ((int)0x8CEB)        ,
        ColorAttachment12Nv = ((int)0x8CEC)        ,
        ColorAttachment13Nv = ((int)0x8CED)        ,
        ColorAttachment14Nv = ((int)0x8CEE)        ,
        ColorAttachment15Nv = ((int)0x8CEF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDrawInstanced : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvExplicitAttribLocation : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFboColorAttachments : int
    {
        MaxColorAttachmentsNv = ((int)0x8CDF)        ,
        ColorAttachment0Nv = ((int)0x8CE0)        ,
        ColorAttachment1Nv = ((int)0x8CE1)        ,
        ColorAttachment2Nv = ((int)0x8CE2)        ,
        ColorAttachment3Nv = ((int)0x8CE3)        ,
        ColorAttachment4Nv = ((int)0x8CE4)        ,
        ColorAttachment5Nv = ((int)0x8CE5)        ,
        ColorAttachment6Nv = ((int)0x8CE6)        ,
        ColorAttachment7Nv = ((int)0x8CE7)        ,
        ColorAttachment8Nv = ((int)0x8CE8)        ,
        ColorAttachment9Nv = ((int)0x8CE9)        ,
        ColorAttachment10Nv = ((int)0x8CEA)        ,
        ColorAttachment11Nv = ((int)0x8CEB)        ,
        ColorAttachment12Nv = ((int)0x8CEC)        ,
        ColorAttachment13Nv = ((int)0x8CED)        ,
        ColorAttachment14Nv = ((int)0x8CEE)        ,
        ColorAttachment15Nv = ((int)0x8CEF)        ,
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
    public enum NvFramebufferBlit : int
    {
        DrawFramebufferBindingNv = ((int)0x8CA6)        ,
        ReadFramebufferNv = ((int)0x8CA8)        ,
        DrawFramebufferNv = ((int)0x8CA9)        ,
        ReadFramebufferBindingNv = ((int)0x8CAA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFramebufferMultisample : int
    {
        RenderbufferSamplesNv = ((int)0x8CAB)        ,
        FramebufferIncompleteMultisampleNv = ((int)0x8D56)        ,
        MaxSamplesNv = ((int)0x8D57)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvGenerateMipmapSrgb : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvInstancedArrays : int
    {
        VertexAttribArrayDivisorNv = ((int)0x88FE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvNonSquareMatrices : int
    {
        FloatMat2x3Nv = ((int)0x8B65)        ,
        FloatMat2x4Nv = ((int)0x8B66)        ,
        FloatMat3x2Nv = ((int)0x8B67)        ,
        FloatMat3x4Nv = ((int)0x8B68)        ,
        FloatMat4x2Nv = ((int)0x8B69)        ,
        FloatMat4x3Nv = ((int)0x8B6A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvReadBuffer : int
    {
        ReadBufferNv = ((int)0x0C02)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvReadBufferFront : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvReadDepth : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvReadDepthStencil : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvReadStencil : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShadowSamplersArray : int
    {
        Sampler2DArrayShadowNv = ((int)0x8DC4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShadowSamplersCube : int
    {
        SamplerCubeShadowNv = ((int)0x8DC5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvSrgbFormats : int
    {
        Etc1Srgb8Nv = ((int)0x88EE)        ,
        Srgb8Nv = ((int)0x8C41)        ,
        SluminanceAlphaNv = ((int)0x8C44)        ,
        Sluminance8Alpha8Nv = ((int)0x8C45)        ,
        SluminanceNv = ((int)0x8C46)        ,
        Sluminance8Nv = ((int)0x8C47)        ,
        CompressedSrgbS3tcDxt1Nv = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Nv = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Nv = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Nv = ((int)0x8C4F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureBorderClamp : int
    {
        TextureBorderColorNv = ((int)0x1004)        ,
        ClampToBorderNv = ((int)0x812D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureCompressionS3tcUpdate : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureNpot2DMipmap : int
    {
    }

    /// <summary>
    /// Used in GL.GetObjectLabel, GL.ObjectLabel and 2 other functions
    /// </summary>
    public enum ObjectLabelIdentifier : int
    {
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702)        ,
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074)        ,
        /// <summary>
        /// Original was GL_BUFFER = 0x82E0
        /// </summary>
        Buffer = ((int)0x82E0)        ,
        /// <summary>
        /// Original was GL_SHADER = 0x82E1
        /// </summary>
        Shader = ((int)0x82E1)        ,
        /// <summary>
        /// Original was GL_PROGRAM = 0x82E2
        /// </summary>
        Program = ((int)0x82E2)        ,
        /// <summary>
        /// Original was GL_QUERY = 0x82E3
        /// </summary>
        Query = ((int)0x82E3)        ,
        /// <summary>
        /// Original was GL_PROGRAM_PIPELINE = 0x82E4
        /// </summary>
        ProgramPipeline = ((int)0x82E4)        ,
        /// <summary>
        /// Original was GL_SAMPLER = 0x82E6
        /// </summary>
        Sampler = ((int)0x82E6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0X8d40
        /// </summary>
        Framebuffer = ((int)0X8d40)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0X8d41
        /// </summary>
        Renderbuffer = ((int)0X8d41)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK = 0x8E22
        /// </summary>
        TransformFeedback = ((int)0x8E22)        ,
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
    public enum OesCompressedEtc1Rgb8Texture : int
    {
        Etc1Rgb8Oes = ((int)0x8D64)        ,
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
    public enum OesDepth24 : int
    {
        DepthComponent24Oes = ((int)0x81A6)        ,
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
    public enum OesDepthTexture : int
    {
        UnsignedShort = ((int)0x1403)        ,
        UnsignedInt = ((int)0x1405)        ,
        DepthComponent = ((int)0x1902)        ,
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
    public enum OesElementIndexUint : int
    {
        UnsignedInt = ((int)0x1405)        ,
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
    public enum OesFragmentPrecisionHigh : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesGetProgramBinary : int
    {
        ProgramBinaryLengthOes = ((int)0x8741)        ,
        NumProgramBinaryFormatsOes = ((int)0x87FE)        ,
        ProgramBinaryFormatsOes = ((int)0x87FF)        ,
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
    public enum OesPackedDepthStencil : int
    {
        DepthStencilOes = ((int)0x84F9)        ,
        UnsignedInt248Oes = ((int)0x84FA)        ,
        Depth24Stencil8Oes = ((int)0x88F0)        ,
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
    public enum OesRgb8Rgba8 : int
    {
        Rgb8Oes = ((int)0x8051)        ,
        Rgba8Oes = ((int)0x8058)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStandardDerivatives : int
    {
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
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
    public enum OesStencil4 : int
    {
        StencilIndex4Oes = ((int)0x8D47)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesSurfacelessContext : int
    {
        FramebufferUndefinedOes = ((int)0x8219)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTexture3D : int
    {
        TextureBinding3DOes = ((int)0x806A)        ,
        Texture3DOes = ((int)0x806F)        ,
        TextureWrapROes = ((int)0x8072)        ,
        Max3DTextureSizeOes = ((int)0x8073)        ,
        Sampler3DOes = ((int)0x8B5F)        ,
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureCompressionAstc : int
    {
        CompressedRgbaAstc4X4Khr = ((int)0x93B0)        ,
        CompressedRgbaAstc5X4Khr = ((int)0x93B1)        ,
        CompressedRgbaAstc5X5Khr = ((int)0x93B2)        ,
        CompressedRgbaAstc6X5Khr = ((int)0x93B3)        ,
        CompressedRgbaAstc6X6Khr = ((int)0x93B4)        ,
        CompressedRgbaAstc8X5Khr = ((int)0x93B5)        ,
        CompressedRgbaAstc8X6Khr = ((int)0x93B6)        ,
        CompressedRgbaAstc8X8Khr = ((int)0x93B7)        ,
        CompressedRgbaAstc10X5Khr = ((int)0x93B8)        ,
        CompressedRgbaAstc10X6Khr = ((int)0x93B9)        ,
        CompressedRgbaAstc10X8Khr = ((int)0x93BA)        ,
        CompressedRgbaAstc10X10Khr = ((int)0x93BB)        ,
        CompressedRgbaAstc12X10Khr = ((int)0x93BC)        ,
        CompressedRgbaAstc12X12Khr = ((int)0x93BD)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0
        /// </summary>
        CompressedRgbaAstc3X3x3Oes = ((int)0x93C0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1
        /// </summary>
        CompressedRgbaAstc4X3x3Oes = ((int)0x93C1)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2
        /// </summary>
        CompressedRgbaAstc4X4x3Oes = ((int)0x93C2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3
        /// </summary>
        CompressedRgbaAstc4X4x4Oes = ((int)0x93C3)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4
        /// </summary>
        CompressedRgbaAstc5X4x4Oes = ((int)0x93C4)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5
        /// </summary>
        CompressedRgbaAstc5X5x4Oes = ((int)0x93C5)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6
        /// </summary>
        CompressedRgbaAstc5X5x5Oes = ((int)0x93C6)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7
        /// </summary>
        CompressedRgbaAstc6X5x5Oes = ((int)0x93C7)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8
        /// </summary>
        CompressedRgbaAstc6X6x5Oes = ((int)0x93C8)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9
        /// </summary>
        CompressedRgbaAstc6X6x6Oes = ((int)0x93C9)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4Khr = ((int)0x93D0)        ,
        CompressedSrgb8Alpha8Astc5X4Khr = ((int)0x93D1)        ,
        CompressedSrgb8Alpha8Astc5X5Khr = ((int)0x93D2)        ,
        CompressedSrgb8Alpha8Astc6X5Khr = ((int)0x93D3)        ,
        CompressedSrgb8Alpha8Astc6X6Khr = ((int)0x93D4)        ,
        CompressedSrgb8Alpha8Astc8X5Khr = ((int)0x93D5)        ,
        CompressedSrgb8Alpha8Astc8X6Khr = ((int)0x93D6)        ,
        CompressedSrgb8Alpha8Astc8X8Khr = ((int)0x93D7)        ,
        CompressedSrgb8Alpha8Astc10X5Khr = ((int)0x93D8)        ,
        CompressedSrgb8Alpha8Astc10X6Khr = ((int)0x93D9)        ,
        CompressedSrgb8Alpha8Astc10X8Khr = ((int)0x93DA)        ,
        CompressedSrgb8Alpha8Astc10X10Khr = ((int)0x93DB)        ,
        CompressedSrgb8Alpha8Astc12X10Khr = ((int)0x93DC)        ,
        CompressedSrgb8Alpha8Astc12X12Khr = ((int)0x93DD)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0
        /// </summary>
        CompressedSrgb8Alpha8Astc3X3x3Oes = ((int)0x93E0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1
        /// </summary>
        CompressedSrgb8Alpha8Astc4X3x3Oes = ((int)0x93E1)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4x3Oes = ((int)0x93E2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3
        /// </summary>
        CompressedSrgb8Alpha8Astc4X4x4Oes = ((int)0x93E3)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4
        /// </summary>
        CompressedSrgb8Alpha8Astc5X4x4Oes = ((int)0x93E4)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5
        /// </summary>
        CompressedSrgb8Alpha8Astc5X5x4Oes = ((int)0x93E5)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6
        /// </summary>
        CompressedSrgb8Alpha8Astc5X5x5Oes = ((int)0x93E6)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7
        /// </summary>
        CompressedSrgb8Alpha8Astc6X5x5Oes = ((int)0x93E7)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8
        /// </summary>
        CompressedSrgb8Alpha8Astc6X6x5Oes = ((int)0x93E8)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9
        /// </summary>
        CompressedSrgb8Alpha8Astc6X6x6Oes = ((int)0x93E9)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureFloat : int
    {
        Float = ((int)0x1406)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureFloatLinear : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureHalfFloat : int
    {
        HalfFloatOes = ((int)0x8D61)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureHalfFloatLinear : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureNpot : int
    {
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
    public enum OesVertexHalfFloat : int
    {
        HalfFloatOes = ((int)0x8D61)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexType1010102 : int
    {
        UnsignedInt1010102Oes = ((int)0x8DF6)        ,
        Int1010102Oes = ((int)0x8DF7)        ,
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
    /// Used in GL.CompressedTexSubImage2D, GL.CompressedTexSubImage3D and 6 other functions
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
        Alpha = ((int)0X1906)        ,
        Rgb = ((int)0X1907)        ,
        Rgba = ((int)0X1908)        ,
        Luminance = ((int)0X1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        /// <summary>
        /// Original was GL_R = 0x2002
        /// </summary>
        R = ((int)0x2002)        ,
        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = ((int)0x8000)        ,
        CmykExt = ((int)0x800C)        ,
        CmykaExt = ((int)0x800D)        ,
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = ((int)0x8227)        ,
        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = ((int)0x8228)        ,
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9)        ,
        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = ((int)0x8D94)        ,
        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = ((int)0x8D98)        ,
        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = ((int)0x8D99)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PixelInternalFormat : int
    {
        Alpha = ((int)0X1906)        ,
        Rgb = ((int)0X1907)        ,
        Rgba = ((int)0X1908)        ,
        Luminance = ((int)0X1909)        ,
        LuminanceAlpha = ((int)0X190a)        ,
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
    /// Used in GL.ReadPixels, GL.TexImage2D and 4 other functions
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
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B)        ,
        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
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
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        /// </summary>
        UnsignedInt248 = ((int)0x84FA)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        /// </summary>
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        /// <summary>
        /// Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        /// </summary>
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
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
    /// Used in GL.Angle.DrawArraysInstanced, GL.Angle.DrawElementsInstanced and 11 other functions
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
    public enum ProgramParameter : int
    {
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        LinkStatus = ((int)0x8B82)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        AttachedShaders = ((int)0x8B85)        ,
        ActiveUniforms = ((int)0x8B86)        ,
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        ActiveAttributes = ((int)0x8B89)        ,
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
    }

    /// <summary>
    /// Used in GL.ProgramParameter, GL.Ext.ProgramParameter
    /// </summary>
    public enum ProgramParameterName : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = ((int)0x8A35)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = ((int)0x8A36)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82)        ,
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83)        ,
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84)        ,
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = ((int)0x8C83)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomAlphaTest : int
    {
        AlphaTestQcom = ((int)0x0BC0)        ,
        AlphaTestFuncQcom = ((int)0x0BC1)        ,
        AlphaTestRefQcom = ((int)0x0BC2)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomBinningControl : int
    {
        BinningControlHintQcom = ((int)0x8FB0)        ,
        CpuOptimizedQcom = ((int)0x8FB1)        ,
        GpuOptimizedQcom = ((int)0x8FB2)        ,
        RenderDirectToFramebufferQcom = ((int)0x8FB3)        ,
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
    public enum QueryCounterTarget : int
    {
        /// <summary>
        /// Original was GL_TIMESTAMP_EXT = 0x8E28
        /// </summary>
        TimestampExt = ((int)0x8E28)        ,
    }

    /// <summary>
    /// Used in GL.BeginQuery, GL.EndQuery and 4 other functions
    /// </summary>
    public enum QueryTarget : int
    {
        /// <summary>
        /// Original was GL_TIME_ELAPSED_EXT = 0x88BF
        /// </summary>
        TimeElapsedExt = ((int)0x88BF)        ,
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED = 0x8C2F
        /// </summary>
        AnySamplesPassed = ((int)0x8C2F)        ,
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_EXT = 0x8C2F
        /// </summary>
        AnySamplesPassedExt = ((int)0x8C2F)        ,
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88
        /// </summary>
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        /// <summary>
        /// Original was GL_ANY_SAMPLES_PASSED_CONSERVATIVE_EXT = 0x8D6A
        /// </summary>
        AnySamplesPassedConservativeExt = ((int)0x8D6A)        ,
    }

    /// <summary>
    /// Used in GL.ReadBuffer
    /// </summary>
    public enum ReadBufferMode : int
    {
        None = ((int)0)        ,
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
        ColorAttachment0 = ((int)0x8CE0)        ,
        ColorAttachment1 = ((int)0x8CE1)        ,
        ColorAttachment2 = ((int)0x8CE2)        ,
        ColorAttachment3 = ((int)0x8CE3)        ,
        ColorAttachment4 = ((int)0x8CE4)        ,
        ColorAttachment5 = ((int)0x8CE5)        ,
        ColorAttachment6 = ((int)0x8CE6)        ,
        ColorAttachment7 = ((int)0x8CE7)        ,
        ColorAttachment8 = ((int)0x8CE8)        ,
        ColorAttachment9 = ((int)0x8CE9)        ,
        ColorAttachment10 = ((int)0x8CEA)        ,
        ColorAttachment11 = ((int)0x8CEB)        ,
        ColorAttachment12 = ((int)0x8CEC)        ,
        ColorAttachment13 = ((int)0x8CED)        ,
        ColorAttachment14 = ((int)0x8CEE)        ,
        ColorAttachment15 = ((int)0x8CEF)        ,
    }

    /// <summary>
    /// Used in GL.Angle.RenderbufferStorageMultisample, GL.Apple.RenderbufferStorageMultisample and 5 other functions
    /// </summary>
    public enum RenderbufferInternalFormat : int
    {
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_Rgba4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231)        ,
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232)        ,
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233)        ,
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234)        ,
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235)        ,
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236)        ,
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237)        ,
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238)        ,
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239)        ,
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A)        ,
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B)        ,
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C)        ,
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A)        ,
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D)        ,
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41)        ,
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC)        ,
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD)        ,
        /// <summary>
        /// Original was GL_StencilIndex8 = 0X8d48
        /// </summary>
        StencilIndex8 = ((int)0X8d48)        ,
        Rgb565 = ((int)0X8d62)        ,
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70)        ,
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71)        ,
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76)        ,
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77)        ,
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C)        ,
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D)        ,
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82)        ,
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83)        ,
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88)        ,
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89)        ,
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E)        ,
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95)        ,
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96)        ,
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97)        ,
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F)        ,
    }

    /// <summary>
    /// Used in GL.GetRenderbufferParameter
    /// </summary>
    public enum RenderbufferParameterName : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES = 0x8CAB
        /// </summary>
        RenderbufferSamples = ((int)0x8CAB)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = ((int)0x8D42)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = ((int)0x8D43)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = ((int)0x8D50)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = ((int)0x8D51)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = ((int)0x8D52)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = ((int)0x8D54)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = ((int)0x8D55)        ,
    }

    /// <summary>
    /// Used in GL.Angle.RenderbufferStorageMultisample, GL.Apple.RenderbufferStorageMultisample and 8 other functions
    /// </summary>
    public enum RenderbufferTarget : int
    {
        Renderbuffer = ((int)0X8d41)        ,
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
    /// Used in GL.GetSamplerParameter, GL.SamplerParameter
    /// </summary>
    public enum SamplerParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D)        ,
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
    /// Used in GL.ShaderBinary
    /// </summary>
    public enum ShaderBinaryFormat : int
    {
    }

    /// <summary>
    /// Used in GL.GetShader
    /// </summary>
    public enum ShaderParameter : int
    {
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81)        ,
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84)        ,
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88)        ,
    }

    /// <summary>
    /// Used in GL.GetShaderPrecisionFormat
    /// </summary>
    public enum ShaderPrecision : int
    {
        LowFloat = ((int)0x8DF0)        ,
        MediumFloat = ((int)0x8DF1)        ,
        HighFloat = ((int)0x8DF2)        ,
        LowInt = ((int)0x8DF3)        ,
        MediumInt = ((int)0x8DF4)        ,
        HighInt = ((int)0x8DF5)        ,
    }

    /// <summary>
    /// Used in GL.CreateShader, GL.GetShaderPrecisionFormat
    /// </summary>
    public enum ShaderType : int
    {
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShadingModel : int
    {
        Flat = ((int)0x1D00)        ,
        Smooth = ((int)0x1D01)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SizedColorFormat : int
    {
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231)        ,
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232)        ,
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233)        ,
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234)        ,
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235)        ,
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236)        ,
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237)        ,
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238)        ,
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239)        ,
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A)        ,
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B)        ,
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C)        ,
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A)        ,
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D)        ,
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41)        ,
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0X8d62
        /// </summary>
        Rgb565 = ((int)0X8d62)        ,
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70)        ,
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71)        ,
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76)        ,
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77)        ,
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C)        ,
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D)        ,
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82)        ,
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83)        ,
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88)        ,
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89)        ,
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E)        ,
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95)        ,
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96)        ,
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97)        ,
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SizedDepthStencilFormat : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC)        ,
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD)        ,
    }

    /// <summary>
    /// Used in GL.GetInternalformat, GL.TexStorage2D and 3 other functions
    /// </summary>
    public enum SizedInternalFormat : int
    {
        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = ((int)0x803C)        ,
        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = ((int)0x8040)        ,
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231)        ,
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232)        ,
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233)        ,
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234)        ,
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235)        ,
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236)        ,
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237)        ,
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238)        ,
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239)        ,
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A)        ,
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B)        ,
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C)        ,
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = ((int)0x8816)        ,
        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = ((int)0x8818)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = ((int)0x8819)        ,
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = ((int)0x881C)        ,
        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = ((int)0x881E)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = ((int)0x881F)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_RGB_RAW_422_APPLE = 0x8A51
        /// </summary>
        RgbRaw422Apple = ((int)0x8A51)        ,
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A)        ,
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D)        ,
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41)        ,
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC)        ,
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0X8d62
        /// </summary>
        Rgb565 = ((int)0X8d62)        ,
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70)        ,
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71)        ,
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76)        ,
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77)        ,
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C)        ,
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D)        ,
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82)        ,
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83)        ,
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88)        ,
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89)        ,
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E)        ,
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95)        ,
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96)        ,
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97)        ,
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F)        ,
        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = ((int)0x93A1)        ,
    }

    /// <summary>
    /// Used in GL.StencilFuncSeparate, GL.StencilMaskSeparate and 1 other function
    /// </summary>
    public enum StencilFace : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0X0404
        /// </summary>
        Front = ((int)0X0404)        ,
        /// <summary>
        /// Original was GL_BACK = 0X0405
        /// </summary>
        Back = ((int)0X0405)        ,
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Used in GL.StencilFunc, GL.StencilFuncSeparate
    /// </summary>
    public enum StencilFunction : int
    {
        Never = ((int)0X0200)        ,
        Less = ((int)0X0201)        ,
        Equal = ((int)0X0202)        ,
        Lequal = ((int)0X0203)        ,
        Greater = ((int)0X0204)        ,
        Notequal = ((int)0X0205)        ,
        Gequal = ((int)0X0206)        ,
        Always = ((int)0X0207)        ,
    }

    /// <summary>
    /// Used in GL.StencilOp, GL.StencilOpSeparate
    /// </summary>
    public enum StencilOp : int
    {
        Zero = ((int)0X0000)        ,
        Invert = ((int)0X150a)        ,
        Keep = ((int)0X1e00)        ,
        Replace = ((int)0X1e01)        ,
        Incr = ((int)0X1e02)        ,
        Decr = ((int)0X1e03)        ,
        /// <summary>
        /// Original was GL_INCR_WRAP = 0x8507
        /// </summary>
        IncrWrap = ((int)0x8507)        ,
        /// <summary>
        /// Original was GL_DECR_WRAP = 0x8508
        /// </summary>
        DecrWrap = ((int)0x8508)        ,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringName : int
    {
        Vendor = ((int)0X1f00)        ,
        Renderer = ((int)0X1f01)        ,
        Version = ((int)0X1f02)        ,
        Extensions = ((int)0X1f03)        ,
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C)        ,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringNameIndexed : int
    {
        /// <summary>
        /// Original was GL_EXTENSIONS = 0X1f03
        /// </summary>
        Extensions = ((int)0X1f03)        ,
    }

    /// <summary>
    /// Used in GL.Apple.FenceSync, GL.FenceSync
    /// </summary>
    public enum SyncCondition : int
    {
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE = 0x9117
        /// </summary>
        SyncGpuCommandsComplete = ((int)0x9117)        ,
        /// <summary>
        /// Original was GL_SYNC_GPU_COMMANDS_COMPLETE_APPLE = 0x9117
        /// </summary>
        SyncGpuCommandsCompleteApple = ((int)0x9117)        ,
    }

    /// <summary>
    /// Used in GL.Apple.GetSync, GL.GetSync
    /// </summary>
    public enum SyncParameterName : int
    {
        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = ((int)0x9112)        ,
        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = ((int)0x9112)        ,
        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = ((int)0x9113)        ,
        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = ((int)0x9113)        ,
        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = ((int)0x9114)        ,
        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = ((int)0x9114)        ,
        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = ((int)0x9115)        ,
        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = ((int)0x9115)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TexCoordPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Used in GL.TexImage2D, GL.TexImage3D and 1 other function
    /// </summary>
    public enum TextureComponentCount : int
    {
        /// <summary>
        /// Original was GL_ALPHA = 0X1906
        /// </summary>
        Alpha = ((int)0X1906)        ,
        /// <summary>
        /// Original was GL_RGB = 0X1907
        /// </summary>
        Rgb = ((int)0X1907)        ,
        /// <summary>
        /// Original was GL_RGBA = 0X1908
        /// </summary>
        Rgba = ((int)0X1908)        ,
        /// <summary>
        /// Original was GL_LUMINANCE = 0X1909
        /// </summary>
        Luminance = ((int)0X1909)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A)        ,
        /// <summary>
        /// Original was GL_ALPHA8_EXT = 0x803C
        /// </summary>
        Alpha8Ext = ((int)0x803C)        ,
        /// <summary>
        /// Original was GL_LUMINANCE8_EXT = 0x8040
        /// </summary>
        Luminance8Ext = ((int)0x8040)        ,
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8_EXT = 0x8045
        /// </summary>
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81A6
        /// </summary>
        DepthComponent24 = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231)        ,
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232)        ,
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233)        ,
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234)        ,
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235)        ,
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236)        ,
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237)        ,
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238)        ,
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239)        ,
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A)        ,
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B)        ,
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C)        ,
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_RGB32F_EXT = 0x8815
        /// </summary>
        Rgb32fExt = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_ALPHA32F_EXT = 0x8816
        /// </summary>
        Alpha32fExt = ((int)0x8816)        ,
        /// <summary>
        /// Original was GL_LUMINANCE32F_EXT = 0x8818
        /// </summary>
        Luminance32fExt = ((int)0x8818)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA32F_EXT = 0x8819
        /// </summary>
        LuminanceAlpha32fExt = ((int)0x8819)        ,
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_ALPHA16F_EXT = 0x881C
        /// </summary>
        Alpha16fExt = ((int)0x881C)        ,
        /// <summary>
        /// Original was GL_LUMINANCE16F_EXT = 0x881E
        /// </summary>
        Luminance16fExt = ((int)0x881E)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA16F_EXT = 0x881F
        /// </summary>
        LuminanceAlpha16fExt = ((int)0x881F)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_RGB_RAW_422_APPLE = 0x8A51
        /// </summary>
        RgbRaw422Apple = ((int)0x8A51)        ,
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A)        ,
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D)        ,
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41)        ,
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC)        ,
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0X8d62
        /// </summary>
        Rgb565 = ((int)0X8d62)        ,
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70)        ,
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71)        ,
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76)        ,
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77)        ,
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C)        ,
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D)        ,
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82)        ,
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83)        ,
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88)        ,
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89)        ,
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E)        ,
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95)        ,
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96)        ,
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97)        ,
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F)        ,
        /// <summary>
        /// Original was GL_BGRA8_EXT = 0x93A1
        /// </summary>
        Bgra8Ext = ((int)0x93A1)        ,
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
    /// Used in GL.CopyTexImage2D
    /// </summary>
    public enum TextureCopyComponentCount : int
    {
        /// <summary>
        /// Original was GL_ALPHA = 0X1906
        /// </summary>
        Alpha = ((int)0X1906)        ,
        /// <summary>
        /// Original was GL_RGB = 0X1907
        /// </summary>
        Rgb = ((int)0X1907)        ,
        /// <summary>
        /// Original was GL_RGBA = 0X1908
        /// </summary>
        Rgba = ((int)0X1908)        ,
        /// <summary>
        /// Original was GL_LUMINANCE = 0X1909
        /// </summary>
        Luminance = ((int)0X1909)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A)        ,
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059)        ,
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229)        ,
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B)        ,
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D)        ,
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E)        ,
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F)        ,
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230)        ,
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231)        ,
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232)        ,
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233)        ,
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234)        ,
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235)        ,
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236)        ,
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237)        ,
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238)        ,
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239)        ,
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A)        ,
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B)        ,
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C)        ,
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814)        ,
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815)        ,
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A)        ,
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B)        ,
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A)        ,
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D)        ,
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41)        ,
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0X8d62
        /// </summary>
        Rgb565 = ((int)0X8d62)        ,
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70)        ,
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71)        ,
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76)        ,
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77)        ,
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C)        ,
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D)        ,
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82)        ,
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83)        ,
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88)        ,
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89)        ,
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E)        ,
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95)        ,
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96)        ,
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97)        ,
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F)        ,
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
    /// Not used directly.
    /// </summary>
    public enum TextureEnvParameter : int
    {
        TextureEnvMode = ((int)0x2200)        ,
        TextureEnvColor = ((int)0x2201)        ,
    }

    /// <summary>
    /// Not used directly.
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
        Nearest = ((int)0X2600)        ,
        Linear = ((int)0X2601)        ,
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
        Nearest = ((int)0X2600)        ,
        Linear = ((int)0X2601)        ,
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
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = ((int)0x813C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = ((int)0x813D)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
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
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C)        ,
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = ((int)0x8E42)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = ((int)0x8E43)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = ((int)0x8E44)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = ((int)0x8E45)        ,
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.GenerateMipmap and 2 other functions
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
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513)        ,
        TextureCubeMapPositiveX = ((int)0X8515)        ,
        TextureCubeMapNegativeX = ((int)0X8516)        ,
        TextureCubeMapPositiveY = ((int)0X8517)        ,
        TextureCubeMapNegativeY = ((int)0X8518)        ,
        TextureCubeMapPositiveZ = ((int)0X8519)        ,
        TextureCubeMapNegativeZ = ((int)0X851a)        ,
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A)        ,
    }

    /// <summary>
    /// Used in GL.CompressedTexImage2D, GL.CompressedTexSubImage2D and 7 other functions
    /// </summary>
    public enum TextureTarget2d : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
    }

    /// <summary>
    /// Used in GL.CompressedTexImage3D, GL.CompressedTexSubImage3D and 10 other functions
    /// </summary>
    public enum TextureTarget3d : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = ((int)0x806F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A)        ,
    }

    /// <summary>
    /// Used in GL.ActiveTexture
    /// </summary>
    public enum TextureUnit : int
    {
        Texture0 = ((int)0X84c0)        ,
        Texture1 = ((int)0X84c1)        ,
        Texture2 = ((int)0X84c2)        ,
        Texture3 = ((int)0X84c3)        ,
        Texture4 = ((int)0X84c4)        ,
        Texture5 = ((int)0X84c5)        ,
        Texture6 = ((int)0X84c6)        ,
        Texture7 = ((int)0X84c7)        ,
        Texture8 = ((int)0X84c8)        ,
        Texture9 = ((int)0X84c9)        ,
        Texture10 = ((int)0X84ca)        ,
        Texture11 = ((int)0X84cb)        ,
        Texture12 = ((int)0X84cc)        ,
        Texture13 = ((int)0X84cd)        ,
        Texture14 = ((int)0X84ce)        ,
        Texture15 = ((int)0X84cf)        ,
        Texture16 = ((int)0X84d0)        ,
        Texture17 = ((int)0X84d1)        ,
        Texture18 = ((int)0X84d2)        ,
        Texture19 = ((int)0X84d3)        ,
        Texture20 = ((int)0X84d4)        ,
        Texture21 = ((int)0X84d5)        ,
        Texture22 = ((int)0X84d6)        ,
        Texture23 = ((int)0X84d7)        ,
        Texture24 = ((int)0X84d8)        ,
        Texture25 = ((int)0X84d9)        ,
        Texture26 = ((int)0X84da)        ,
        Texture27 = ((int)0X84db)        ,
        Texture28 = ((int)0X84dc)        ,
        Texture29 = ((int)0X84dd)        ,
        Texture30 = ((int)0X84de)        ,
        Texture31 = ((int)0X84df)        ,
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
    /// Used in GL.TransformFeedbackVaryings
    /// </summary>
    public enum TransformFeedbackMode : int
    {
        InterleavedAttribs = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
    }

    /// <summary>
    /// Used in GL.BeginTransformFeedback
    /// </summary>
    public enum TransformFeedbackPrimitiveType : int
    {
        Points = ((int)0X0000)        ,
        Lines = ((int)0X0001)        ,
        Triangles = ((int)0X0004)        ,
    }

    /// <summary>
    /// Used in GL.BindTransformFeedback
    /// </summary>
    public enum TransformFeedbackTarget : int
    {
        TransformFeedback = ((int)0x8E22)        ,
    }

    /// <summary>
    /// Used in GL.GetTransformFeedbackVarying
    /// </summary>
    public enum TransformFeedbackType : int
    {
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0X1406)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
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
    /// Used in GL.VertexAttribIPointer
    /// </summary>
    public enum VertexAttribIntegerType : int
    {
        Byte = ((int)0X1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0X1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttrib
    /// </summary>
    public enum VertexAttribParameter : int
    {
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerParameter : int
    {
        VertexAttribArrayPointer = ((int)0x8645)        ,
    }

    /// <summary>
    /// Used in GL.VertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerType : int
    {
        Byte = ((int)0X1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0X1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0X1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0X1406)        ,
        HalfFloat = ((int)0x140B)        ,
        Fixed = ((int)0X140c)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VivShaderBinary : int
    {
        ShaderBinaryViv = ((int)0x8FC4)        ,
    }

    /// <summary>
    /// Used in GL.Apple.FenceSync, GL.Apple.WaitSync and 2 other functions
    /// </summary>
    public enum WaitSyncFlags : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum WaitSyncStatus : int
    {
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED = 0x911A
        /// </summary>
        AlreadySignaled = ((int)0x911A)        ,
        /// <summary>
        /// Original was GL_ALREADY_SIGNALED_APPLE = 0x911A
        /// </summary>
        AlreadySignaledApple = ((int)0x911A)        ,
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED = 0x911B
        /// </summary>
        TimeoutExpired = ((int)0x911B)        ,
        /// <summary>
        /// Original was GL_TIMEOUT_EXPIRED_APPLE = 0x911B
        /// </summary>
        TimeoutExpiredApple = ((int)0x911B)        ,
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED = 0x911C
        /// </summary>
        ConditionSatisfied = ((int)0x911C)        ,
        /// <summary>
        /// Original was GL_CONDITION_SATISFIED_APPLE = 0x911C
        /// </summary>
        ConditionSatisfiedApple = ((int)0x911C)        ,
        /// <summary>
        /// Original was GL_WAIT_FAILED = 0x911D
        /// </summary>
        WaitFailed = ((int)0x911D)        ,
        /// <summary>
        /// Original was GL_WAIT_FAILED_APPLE = 0x911D
        /// </summary>
        WaitFailedApple = ((int)0x911D)        ,
    }

}
