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

namespace OpenTK.Graphics.OpenGL4
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AccumOp : int
    {
    }

    /// <summary>
    /// Used in GL.GetActiveAttrib
    /// </summary>
    public enum ActiveAttribType : int
    {
        None = ((int)0)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
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
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveSubroutineUniform
    /// </summary>
    public enum ActiveSubroutineUniformParameter : int
    {
        UniformSize = ((int)0x8A38)        ,
        UniformNameLength = ((int)0x8A39)        ,
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniformBlock
    /// </summary>
    public enum ActiveUniformBlockParameter : int
    {
        UniformBlockReferencedByTessControlShader = ((int)0x84F0)        ,
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)        ,
        UniformBlockBinding = ((int)0x8A3F)        ,
        UniformBlockDataSize = ((int)0x8A40)        ,
        UniformBlockNameLength = ((int)0x8A41)        ,
        UniformBlockActiveUniforms = ((int)0x8A42)        ,
        UniformBlockActiveUniformIndices = ((int)0x8A43)        ,
        UniformBlockReferencedByVertexShader = ((int)0x8A44)        ,
        UniformBlockReferencedByGeometryShader = ((int)0x8A45)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
        UniformBlockReferencedByComputeShader = ((int)0x90EC)        ,
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
        UniformAtomicCounterBufferIndex = ((int)0x92DA)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniform
    /// </summary>
    public enum ActiveUniformType : int
    {
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
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
        Sampler1D = ((int)0x8B5D)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        Sampler1DShadow = ((int)0x8B61)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        Sampler2DRect = ((int)0x8B63)        ,
        Sampler2DRectShadow = ((int)0x8B64)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        Sampler1DArray = ((int)0x8DC0)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        SamplerBuffer = ((int)0x8DC2)        ,
        Sampler1DArrayShadow = ((int)0x8DC3)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler1D = ((int)0x8DC9)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler2DRect = ((int)0x8DCD)        ,
        IntSampler1DArray = ((int)0x8DCE)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        IntSamplerBuffer = ((int)0x8DD0)        ,
        UnsignedIntSampler1D = ((int)0x8DD1)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler2DRect = ((int)0x8DD5)        ,
        UnsignedIntSampler1DArray = ((int)0x8DD6)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        UnsignedIntSamplerBuffer = ((int)0x8DD8)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
        SamplerCubeMapArray = ((int)0x900C)        ,
        SamplerCubeMapArrayShadow = ((int)0x900D)        ,
        IntSamplerCubeMapArray = ((int)0x900E)        ,
        UnsignedIntSamplerCubeMapArray = ((int)0x900F)        ,
        Image1D = ((int)0x904C)        ,
        Image2D = ((int)0x904D)        ,
        Image3D = ((int)0x904E)        ,
        Image2DRect = ((int)0x904F)        ,
        ImageCube = ((int)0x9050)        ,
        ImageBuffer = ((int)0x9051)        ,
        Image1DArray = ((int)0x9052)        ,
        Image2DArray = ((int)0x9053)        ,
        ImageCubeMapArray = ((int)0x9054)        ,
        Image2DMultisample = ((int)0x9055)        ,
        Image2DMultisampleArray = ((int)0x9056)        ,
        IntImage1D = ((int)0x9057)        ,
        IntImage2D = ((int)0x9058)        ,
        IntImage3D = ((int)0x9059)        ,
        IntImage2DRect = ((int)0x905A)        ,
        IntImageCube = ((int)0x905B)        ,
        IntImageBuffer = ((int)0x905C)        ,
        IntImage1DArray = ((int)0x905D)        ,
        IntImage2DArray = ((int)0x905E)        ,
        IntImageCubeMapArray = ((int)0x905F)        ,
        IntImage2DMultisample = ((int)0x9060)        ,
        IntImage2DMultisampleArray = ((int)0x9061)        ,
        UnsignedIntImage1D = ((int)0x9062)        ,
        UnsignedIntImage2D = ((int)0x9063)        ,
        UnsignedIntImage3D = ((int)0x9064)        ,
        UnsignedIntImage2DRect = ((int)0x9065)        ,
        UnsignedIntImageCube = ((int)0x9066)        ,
        UnsignedIntImageBuffer = ((int)0x9067)        ,
        UnsignedIntImage1DArray = ((int)0x9068)        ,
        UnsignedIntImage2DArray = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArray = ((int)0x906A)        ,
        UnsignedIntImage2DMultisample = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArray = ((int)0x906C)        ,
        Sampler2DMultisample = ((int)0x9108)        ,
        IntSampler2DMultisample = ((int)0x9109)        ,
        UnsignedIntSampler2DMultisample = ((int)0x910A)        ,
        Sampler2DMultisampleArray = ((int)0x910B)        ,
        IntSampler2DMultisampleArray = ((int)0x910C)        ,
        UnsignedIntSampler2DMultisampleArray = ((int)0x910D)        ,
        UnsignedIntAtomicCounter = ((int)0x92DB)        ,
    }

    /// <summary>
    /// Used in GL.Arb.BlendEquationSeparate, GL.Arb.BlendFunc and 33 other functions
    /// </summary>
    public enum All : int
    {
        False = ((int)0)        ,
        LayoutDefaultIntel = ((int)0)        ,
        NoError = ((int)0)        ,
        None = ((int)0)        ,
        NoneOes = ((int)0)        ,
        Zero = ((int)0)        ,
        Points = ((int)0x0000)        ,
        ContextCoreProfileBit = ((int)0x00000001)        ,
        ContextFlagForwardCompatibleBit = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_SYNC_FLUSH_COMMANDS_BIT = 0x00000001
        /// </summary>
        SyncFlushCommandsBit = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBitExt = ((int)0x00000001)        ,
        VertexShaderBit = ((int)0x00000001)        ,
        VertexShaderBitExt = ((int)0x00000001)        ,
        ContextCompatibilityProfileBit = ((int)0x00000002)        ,
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ContextFlagDebugBitKhr = ((int)0x00000002)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        ElementArrayBarrierBitExt = ((int)0x00000002)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004
        /// </summary>
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
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
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ComputeShaderBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBitExt = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        CommandBarrierBitExt = ((int)0x00000040)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        PixelBufferBarrierBitExt = ((int)0x00000080)        ,
        DepthBufferBit = ((int)0x00000100)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        TextureUpdateBarrierBitExt = ((int)0x00000100)        ,
        AccumBufferBit = ((int)0x00000200)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        BufferUpdateBarrierBitExt = ((int)0x00000200)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        FramebufferBarrierBitExt = ((int)0x00000400)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        TransformFeedbackBarrierBitExt = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        AtomicCounterBarrierBitExt = ((int)0x00001000)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        CoverageBufferBitNv = ((int)0x00008000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        Lines = ((int)0x0001)        ,
        MapReadBit = ((int)0x0001)        ,
        MapReadBitExt = ((int)0x0001)        ,
        LineLoop = ((int)0x0002)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapWriteBitExt = ((int)0x0002)        ,
        LineStrip = ((int)0x0003)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateRangeBitExt = ((int)0x0004)        ,
        Triangles = ((int)0x0004)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Quads = ((int)0x0007)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapInvalidateBufferBitExt = ((int)0x0008)        ,
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
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapFlushExplicitBitExt = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        MapUnsynchronizedBitExt = ((int)0x0020)        ,
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        Add = ((int)0x0104)        ,
        ClientStorageBit = ((int)0x0200)        ,
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
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
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
        PolygonMode = ((int)0x0B40)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        PolygonStipple = ((int)0x0B42)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
        Lighting = ((int)0x0B50)        ,
        LightModelLocalViewer = ((int)0x0B51)        ,
        LightModelTwoSide = ((int)0x0B52)        ,
        LightModelAmbient = ((int)0x0B53)        ,
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
        StencilTest = ((int)0x0B90)        ,
        StencilClearValue = ((int)0x0B91)        ,
        StencilFunc = ((int)0x0B92)        ,
        StencilValueMask = ((int)0x0B93)        ,
        StencilFail = ((int)0x0B94)        ,
        StencilPassDepthFail = ((int)0x0B95)        ,
        StencilPassDepthPass = ((int)0x0B96)        ,
        StencilRef = ((int)0x0B97)        ,
        StencilWritemask = ((int)0x0B98)        ,
        Normalize = ((int)0x0BA1)        ,
        Viewport = ((int)0x0BA2)        ,
        Modelview0StackDepthExt = ((int)0x0BA3)        ,
        Modelview0MatrixExt = ((int)0x0BA6)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestQcom = ((int)0x0BC0)        ,
        AlphaTestFuncQcom = ((int)0x0BC1)        ,
        AlphaTestRefQcom = ((int)0x0BC2)        ,
        Dither = ((int)0x0BD0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        IndexLogicOp = ((int)0x0BF1)        ,
        LogicOp = ((int)0x0BF1)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        DrawBuffer = ((int)0x0C01)        ,
        DrawBufferExt = ((int)0x0C01)        ,
        ReadBuffer = ((int)0x0C02)        ,
        ReadBufferExt = ((int)0x0C02)        ,
        ReadBufferNv = ((int)0x0C02)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        Doublebuffer = ((int)0x0C32)        ,
        Stereo = ((int)0x0C33)        ,
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
        GreenScale = ((int)0x0D18)        ,
        GreenBias = ((int)0x0D19)        ,
        BlueScale = ((int)0x0D1A)        ,
        BlueBias = ((int)0x0D1B)        ,
        AlphaScale = ((int)0x0D1C)        ,
        AlphaBias = ((int)0x0D1D)        ,
        DepthScale = ((int)0x0D1E)        ,
        DepthBias = ((int)0x0D1F)        ,
        MaxClipDistances = ((int)0x0D32)        ,
        MaxTextureSize = ((int)0x0D33)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        SubpixelBits = ((int)0x0D50)        ,
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
        TextureWidth = ((int)0x1000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
        TextureBorderColorNv = ((int)0x1004)        ,
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0x1101)        ,
        Nicest = ((int)0x1102)        ,
        Ambient = ((int)0x1200)        ,
        Diffuse = ((int)0x1201)        ,
        Specular = ((int)0x1202)        ,
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
        Fixed = ((int)0x140C)        ,
        UnsignedInt64Arb = ((int)0x140F)        ,
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
        AmbientAndDiffuse = ((int)0x1602)        ,
        Modelview0Ext = ((int)0x1700)        ,
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
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
        Vendor = ((int)0x1F00)        ,
        Renderer = ((int)0x1F01)        ,
        Version = ((int)0x1F02)        ,
        Extensions = ((int)0x1F03)        ,
        MultisampleBit = ((int)0x20000000)        ,
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleBitExt = ((int)0x20000000)        ,
        Modulate = ((int)0x2100)        ,
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
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
        R3G3B2 = ((int)0x2A10)        ,
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
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        AbgrExt = ((int)0x8000)        ,
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
        ConvolutionFormat = ((int)0x8017)        ,
        ConvolutionFormatExt = ((int)0x8017)        ,
        ConvolutionWidth = ((int)0x8018)        ,
        ConvolutionWidthExt = ((int)0x8018)        ,
        ConvolutionHeight = ((int)0x8019)        ,
        ConvolutionHeightExt = ((int)0x8019)        ,
        MaxConvolutionWidth = ((int)0x801A)        ,
        MaxConvolutionWidthExt = ((int)0x801A)        ,
        MaxConvolutionHeight = ((int)0x801B)        ,
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
        HistogramWidth = ((int)0x8026)        ,
        HistogramWidthExt = ((int)0x8026)        ,
        HistogramFormat = ((int)0x8027)        ,
        HistogramFormatExt = ((int)0x8027)        ,
        HistogramRedSize = ((int)0x8028)        ,
        HistogramRedSizeExt = ((int)0x8028)        ,
        HistogramGreenSize = ((int)0x8029)        ,
        HistogramGreenSizeExt = ((int)0x8029)        ,
        HistogramBlueSize = ((int)0x802A)        ,
        HistogramBlueSizeExt = ((int)0x802A)        ,
        HistogramAlphaSize = ((int)0x802B)        ,
        HistogramAlphaSizeExt = ((int)0x802B)        ,
        HistogramLuminanceSize = ((int)0x802C)        ,
        HistogramLuminanceSizeExt = ((int)0x802C)        ,
        HistogramSink = ((int)0x802D)        ,
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
        TextureRedSize = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        ReplaceExt = ((int)0x8062)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture1DExt = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        ProxyTexture2DExt = ((int)0x8064)        ,
        TextureTooLargeExt = ((int)0x8065)        ,
        TexturePriority = ((int)0x8066)        ,
        TexturePriorityExt = ((int)0x8066)        ,
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
        TextureDepth = ((int)0x8071)        ,
        TextureDepthExt = ((int)0x8071)        ,
        TextureWrapR = ((int)0x8072)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        TextureWrapROes = ((int)0x8072)        ,
        Max3DTextureSize = ((int)0x8073)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
        VertexArray = ((int)0x8074)        ,
        VertexArrayKhr = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayCountExt = ((int)0x808D)        ,
        VertexArrayPointerExt = ((int)0x808E)        ,
        NormalArrayPointerExt = ((int)0x808F)        ,
        ColorArrayPointerExt = ((int)0x8090)        ,
        IndexArrayPointerExt = ((int)0x8091)        ,
        TextureCoordArrayPointerExt = ((int)0x8092)        ,
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
        ColorMatrix = ((int)0x80B1)        ,
        ColorMatrixSgi = ((int)0x80B1)        ,
        ColorMatrixStackDepth = ((int)0x80B2)        ,
        ColorMatrixStackDepthSgi = ((int)0x80B2)        ,
        MaxColorMatrixStackDepth = ((int)0x80B3)        ,
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
        TextureCompareFailValue = ((int)0x80BF)        ,
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
        ColorTableFormat = ((int)0x80D8)        ,
        ColorTableFormatSgi = ((int)0x80D8)        ,
        ColorTableWidth = ((int)0x80D9)        ,
        ColorTableWidthSgi = ((int)0x80D9)        ,
        ColorTableRedSize = ((int)0x80DA)        ,
        ColorTableRedSizeSgi = ((int)0x80DA)        ,
        ColorTableGreenSize = ((int)0x80DB)        ,
        ColorTableGreenSizeSgi = ((int)0x80DB)        ,
        ColorTableBlueSize = ((int)0x80DC)        ,
        ColorTableBlueSizeSgi = ((int)0x80DC)        ,
        ColorTableAlphaSize = ((int)0x80DD)        ,
        ColorTableAlphaSizeSgi = ((int)0x80DD)        ,
        ColorTableLuminanceSize = ((int)0x80DE)        ,
        ColorTableLuminanceSizeSgi = ((int)0x80DE)        ,
        ColorTableIntensitySize = ((int)0x80DF)        ,
        ColorTableIntensitySizeSgi = ((int)0x80DF)        ,
        Bgr = ((int)0x80E0)        ,
        Bgra = ((int)0x80E1)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
        PhongHintWin = ((int)0x80EB)        ,
        ParameterBufferArb = ((int)0x80EE)        ,
        ParameterBufferBindingArb = ((int)0x80EF)        ,
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
        ConstantBorder = ((int)0x8151)        ,
        ReplicateBorder = ((int)0x8153)        ,
        ConvolutionBorderColor = ((int)0x8154)        ,
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
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81A6)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32 = ((int)0x81A7)        ,
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
        ContextFlags = ((int)0x821E)        ,
        BufferImmutableStorage = ((int)0x821F)        ,
        BufferStorageFlags = ((int)0x8220)        ,
        PrimitiveRestartForPatchesSupported = ((int)0x8221)        ,
        Index = ((int)0x8222)        ,
        CompressedRed = ((int)0x8225)        ,
        CompressedRg = ((int)0x8226)        ,
        Rg = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
        SyncClEventArb = ((int)0x8240)        ,
        SyncClEventCompleteArb = ((int)0x8241)        ,
        DebugOutputSynchronous = ((int)0x8242)        ,
        DebugOutputSynchronousArb = ((int)0x8242)        ,
        DebugOutputSynchronousKhr = ((int)0x8242)        ,
        DebugNextLoggedMessageLength = ((int)0x8243)        ,
        DebugNextLoggedMessageLengthArb = ((int)0x8243)        ,
        DebugNextLoggedMessageLengthKhr = ((int)0x8243)        ,
        DebugCallbackFunction = ((int)0x8244)        ,
        DebugCallbackFunctionArb = ((int)0x8244)        ,
        DebugCallbackFunctionKhr = ((int)0x8244)        ,
        DebugCallbackUserParam = ((int)0x8245)        ,
        DebugCallbackUserParamArb = ((int)0x8245)        ,
        DebugCallbackUserParamKhr = ((int)0x8245)        ,
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceApiArb = ((int)0x8246)        ,
        DebugSourceApiKhr = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceWindowSystemArb = ((int)0x8247)        ,
        DebugSourceWindowSystemKhr = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceShaderCompilerArb = ((int)0x8248)        ,
        DebugSourceShaderCompilerKhr = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceThirdPartyArb = ((int)0x8249)        ,
        DebugSourceThirdPartyKhr = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceApplicationArb = ((int)0x824A)        ,
        DebugSourceApplicationKhr = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
        DebugSourceOtherArb = ((int)0x824B)        ,
        DebugSourceOtherKhr = ((int)0x824B)        ,
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeErrorArb = ((int)0x824C)        ,
        DebugTypeErrorKhr = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeDeprecatedBehaviorArb = ((int)0x824D)        ,
        DebugTypeDeprecatedBehaviorKhr = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypeUndefinedBehaviorArb = ((int)0x824E)        ,
        DebugTypeUndefinedBehaviorKhr = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePortabilityArb = ((int)0x824F)        ,
        DebugTypePortabilityKhr = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypePerformanceArb = ((int)0x8250)        ,
        DebugTypePerformanceKhr = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        DebugTypeOtherArb = ((int)0x8251)        ,
        DebugTypeOtherKhr = ((int)0x8251)        ,
        LoseContextOnResetArb = ((int)0x8252)        ,
        GuiltyContextResetArb = ((int)0x8253)        ,
        InnocentContextResetArb = ((int)0x8254)        ,
        UnknownContextResetArb = ((int)0x8255)        ,
        ResetNotificationStrategyArb = ((int)0x8256)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparable = ((int)0x8258)        ,
        ActiveProgram = ((int)0x8259)        ,
        ProgramPipelineBinding = ((int)0x825A)        ,
        MaxViewports = ((int)0x825B)        ,
        ViewportSubpixelBits = ((int)0x825C)        ,
        ViewportBoundsRange = ((int)0x825D)        ,
        LayerProvokingVertex = ((int)0x825E)        ,
        ViewportIndexProvokingVertex = ((int)0x825F)        ,
        UndefinedVertex = ((int)0x8260)        ,
        NoResetNotificationArb = ((int)0x8261)        ,
        MaxComputeSharedMemorySize = ((int)0x8262)        ,
        MaxComputeUniformComponents = ((int)0x8263)        ,
        MaxComputeAtomicCounterBuffers = ((int)0x8264)        ,
        MaxComputeAtomicCounters = ((int)0x8265)        ,
        MaxCombinedComputeUniformComponents = ((int)0x8266)        ,
        ComputeWorkGroupSize = ((int)0x8267)        ,
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
        MaxUniformLocations = ((int)0x826E)        ,
        InternalformatSupported = ((int)0x826F)        ,
        InternalformatPreferred = ((int)0x8270)        ,
        InternalformatRedSize = ((int)0x8271)        ,
        InternalformatGreenSize = ((int)0x8272)        ,
        InternalformatBlueSize = ((int)0x8273)        ,
        InternalformatAlphaSize = ((int)0x8274)        ,
        InternalformatDepthSize = ((int)0x8275)        ,
        InternalformatStencilSize = ((int)0x8276)        ,
        InternalformatSharedSize = ((int)0x8277)        ,
        InternalformatRedType = ((int)0x8278)        ,
        InternalformatGreenType = ((int)0x8279)        ,
        InternalformatBlueType = ((int)0x827A)        ,
        InternalformatAlphaType = ((int)0x827B)        ,
        InternalformatDepthType = ((int)0x827C)        ,
        InternalformatStencilType = ((int)0x827D)        ,
        MaxWidth = ((int)0x827E)        ,
        MaxHeight = ((int)0x827F)        ,
        MaxDepth = ((int)0x8280)        ,
        MaxLayers = ((int)0x8281)        ,
        MaxCombinedDimensions = ((int)0x8282)        ,
        ColorComponents = ((int)0x8283)        ,
        DepthComponents = ((int)0x8284)        ,
        StencilComponents = ((int)0x8285)        ,
        ColorRenderable = ((int)0x8286)        ,
        DepthRenderable = ((int)0x8287)        ,
        StencilRenderable = ((int)0x8288)        ,
        FramebufferRenderable = ((int)0x8289)        ,
        FramebufferRenderableLayered = ((int)0x828A)        ,
        FramebufferBlend = ((int)0x828B)        ,
        ReadPixels = ((int)0x828C)        ,
        ReadPixelsFormat = ((int)0x828D)        ,
        ReadPixelsType = ((int)0x828E)        ,
        TextureImageFormat = ((int)0x828F)        ,
        TextureImageType = ((int)0x8290)        ,
        GetTextureImageFormat = ((int)0x8291)        ,
        GetTextureImageType = ((int)0x8292)        ,
        Mipmap = ((int)0x8293)        ,
        ManualGenerateMipmap = ((int)0x8294)        ,
        AutoGenerateMipmap = ((int)0x8295)        ,
        ColorEncoding = ((int)0x8296)        ,
        SrgbRead = ((int)0x8297)        ,
        SrgbWrite = ((int)0x8298)        ,
        SrgbDecodeArb = ((int)0x8299)        ,
        Filter = ((int)0x829A)        ,
        VertexTexture = ((int)0x829B)        ,
        TessControlTexture = ((int)0x829C)        ,
        TessEvaluationTexture = ((int)0x829D)        ,
        GeometryTexture = ((int)0x829E)        ,
        FragmentTexture = ((int)0x829F)        ,
        ComputeTexture = ((int)0x82A0)        ,
        TextureShadow = ((int)0x82A1)        ,
        TextureGather = ((int)0x82A2)        ,
        TextureGatherShadow = ((int)0x82A3)        ,
        ShaderImageLoad = ((int)0x82A4)        ,
        ShaderImageStore = ((int)0x82A5)        ,
        ShaderImageAtomic = ((int)0x82A6)        ,
        ImageTexelSize = ((int)0x82A7)        ,
        ImageCompatibilityClass = ((int)0x82A8)        ,
        ImagePixelFormat = ((int)0x82A9)        ,
        ImagePixelType = ((int)0x82AA)        ,
        SimultaneousTextureAndDepthTest = ((int)0x82AC)        ,
        SimultaneousTextureAndStencilTest = ((int)0x82AD)        ,
        SimultaneousTextureAndDepthWrite = ((int)0x82AE)        ,
        SimultaneousTextureAndStencilWrite = ((int)0x82AF)        ,
        TextureCompressedBlockWidth = ((int)0x82B1)        ,
        TextureCompressedBlockHeight = ((int)0x82B2)        ,
        TextureCompressedBlockSize = ((int)0x82B3)        ,
        ClearBuffer = ((int)0x82B4)        ,
        TextureView = ((int)0x82B5)        ,
        ViewCompatibilityClass = ((int)0x82B6)        ,
        FullSupport = ((int)0x82B7)        ,
        CaveatSupport = ((int)0x82B8)        ,
        ImageClass4X32 = ((int)0x82B9)        ,
        ImageClass2X32 = ((int)0x82BA)        ,
        ImageClass1X32 = ((int)0x82BB)        ,
        ImageClass4X16 = ((int)0x82BC)        ,
        ImageClass2X16 = ((int)0x82BD)        ,
        ImageClass1X16 = ((int)0x82BE)        ,
        ImageClass4X8 = ((int)0x82BF)        ,
        ImageClass2X8 = ((int)0x82C0)        ,
        ImageClass1X8 = ((int)0x82C1)        ,
        ImageClass111110 = ((int)0x82C2)        ,
        ImageClass1010102 = ((int)0x82C3)        ,
        ViewClass128Bits = ((int)0x82C4)        ,
        ViewClass96Bits = ((int)0x82C5)        ,
        ViewClass64Bits = ((int)0x82C6)        ,
        ViewClass48Bits = ((int)0x82C7)        ,
        ViewClass32Bits = ((int)0x82C8)        ,
        ViewClass24Bits = ((int)0x82C9)        ,
        ViewClass16Bits = ((int)0x82CA)        ,
        ViewClass8Bits = ((int)0x82CB)        ,
        ViewClassS3tcDxt1Rgb = ((int)0x82CC)        ,
        ViewClassS3tcDxt1Rgba = ((int)0x82CD)        ,
        ViewClassS3tcDxt3Rgba = ((int)0x82CE)        ,
        ViewClassS3tcDxt5Rgba = ((int)0x82CF)        ,
        ViewClassRgtc1Red = ((int)0x82D0)        ,
        ViewClassRgtc2Rg = ((int)0x82D1)        ,
        ViewClassBptcUnorm = ((int)0x82D2)        ,
        ViewClassBptcFloat = ((int)0x82D3)        ,
        VertexAttribBinding = ((int)0x82D4)        ,
        VertexAttribRelativeOffset = ((int)0x82D5)        ,
        VertexBindingDivisor = ((int)0x82D6)        ,
        VertexBindingOffset = ((int)0x82D7)        ,
        VertexBindingStride = ((int)0x82D8)        ,
        MaxVertexAttribRelativeOffset = ((int)0x82D9)        ,
        MaxVertexAttribBindings = ((int)0x82DA)        ,
        TextureViewMinLevel = ((int)0x82DB)        ,
        TextureViewNumLevels = ((int)0x82DC)        ,
        TextureViewMinLayer = ((int)0x82DD)        ,
        TextureViewNumLayers = ((int)0x82DE)        ,
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
        MaxVertexAttribStride = ((int)0x82E5)        ,
        Sampler = ((int)0x82E6)        ,
        SamplerKhr = ((int)0x82E6)        ,
        DisplayList = ((int)0x82E7)        ,
        MaxLabelLength = ((int)0x82E8)        ,
        MaxLabelLengthKhr = ((int)0x82E8)        ,
        NumShadingLanguageVersions = ((int)0x82E9)        ,
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
        UnsignedByte233Rev = ((int)0x8362)        ,
        UnsignedByte233Reversed = ((int)0x8362)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        UnsignedShort565Rev = ((int)0x8364)        ,
        UnsignedShort565Reversed = ((int)0x8364)        ,
        UnsignedShort4444Rev = ((int)0x8365)        ,
        UnsignedShort4444Reversed = ((int)0x8365)        ,
        UnsignedShort1555Rev = ((int)0x8366)        ,
        UnsignedShort1555Reversed = ((int)0x8366)        ,
        UnsignedInt8888Rev = ((int)0x8367)        ,
        UnsignedInt8888Reversed = ((int)0x8367)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        UnsignedInt2101010Reversed = ((int)0x8368)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
        MirroredRepeat = ((int)0x8370)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)        ,
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
        FogCoordSrc = ((int)0x8450)        ,
        FogCoord = ((int)0x8451)        ,
        FragmentDepth = ((int)0x8452)        ,
        CurrentFogCoord = ((int)0x8453)        ,
        FogCoordArrayType = ((int)0x8454)        ,
        FogCoordArrayStride = ((int)0x8455)        ,
        FogCoordArrayPointer = ((int)0x8456)        ,
        FogCoordArray = ((int)0x8457)        ,
        ColorSum = ((int)0x8458)        ,
        CurrentSecondaryColor = ((int)0x8459)        ,
        SecondaryColorArraySize = ((int)0x845A)        ,
        SecondaryColorArrayType = ((int)0x845B)        ,
        SecondaryColorArrayStride = ((int)0x845C)        ,
        SecondaryColorArrayPointer = ((int)0x845D)        ,
        SecondaryColorArray = ((int)0x845E)        ,
        CurrentRasterSecondaryColor = ((int)0x845F)        ,
        RgbIccSgix = ((int)0x8460)        ,
        RgbaIccSgix = ((int)0x8461)        ,
        AlphaIccSgix = ((int)0x8462)        ,
        LuminanceIccSgix = ((int)0x8463)        ,
        IntensityIccSgix = ((int)0x8464)        ,
        LuminanceAlphaIccSgix = ((int)0x8465)        ,
        R5G6B5IccSgix = ((int)0x8466)        ,
        R5G6B5A8IccSgix = ((int)0x8467)        ,
        Alpha16IccSgix = ((int)0x8468)        ,
        Luminance16IccSgix = ((int)0x8469)        ,
        Intensity16IccSgix = ((int)0x846A)        ,
        Luminance16Alpha8IccSgix = ((int)0x846B)        ,
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
        TransposeModelviewMatrix = ((int)0x84E3)        ,
        TransposeProjectionMatrix = ((int)0x84E4)        ,
        TransposeTextureMatrix = ((int)0x84E5)        ,
        TransposeColorMatrix = ((int)0x84E6)        ,
        Subtract = ((int)0x84E7)        ,
        MaxRenderbufferSize = ((int)0x84E8)        ,
        MaxRenderbufferSizeExt = ((int)0x84E8)        ,
        CompressedAlpha = ((int)0x84E9)        ,
        CompressedLuminance = ((int)0x84EA)        ,
        CompressedLuminanceAlpha = ((int)0x84EB)        ,
        CompressedIntensity = ((int)0x84EC)        ,
        CompressedRgb = ((int)0x84ED)        ,
        CompressedRgba = ((int)0x84EE)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        UniformBlockReferencedByTessControlShader = ((int)0x84F0)        ,
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)        ,
        TextureRectangle = ((int)0x84F5)        ,
        TextureBindingRectangle = ((int)0x84F6)        ,
        ProxyTextureRectangle = ((int)0x84F7)        ,
        MaxRectangleTextureSize = ((int)0x84F8)        ,
        DepthStencil = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        TextureFilterControl = ((int)0x8500)        ,
        TextureLodBias = ((int)0x8501)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        NormalMap = ((int)0x8511)        ,
        ReflectionMap = ((int)0x8512)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
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
        Source0Rgb = ((int)0x8580)        ,
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
        VertexArrayBinding = ((int)0x85B5)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        VertexProgram = ((int)0x8620)        ,
        ArrayEnabled = ((int)0x8622)        ,
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        ArrayType = ((int)0x8625)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        ProgramLength = ((int)0x8627)        ,
        ProgramString = ((int)0x8628)        ,
        ProgramPointSize = ((int)0x8642)        ,
        VertexProgramPointSize = ((int)0x8642)        ,
        VertexProgramTwoSide = ((int)0x8643)        ,
        ArrayPointer = ((int)0x8645)        ,
        VertexAttribArrayPointer = ((int)0x8645)        ,
        DepthClamp = ((int)0x864F)        ,
        ProgramBinding = ((int)0x8677)        ,
        TextureCompressedImageSize = ((int)0x86A0)        ,
        TextureCompressed = ((int)0x86A1)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        MirrorClampToEdge = ((int)0x8743)        ,
        VertexAttribArrayLong = ((int)0x874E)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
        FragmentProgram = ((int)0x8804)        ,
        ProgramAluInstructionsArb = ((int)0x8805)        ,
        ProgramTexInstructionsArb = ((int)0x8806)        ,
        ProgramTexIndirectionsArb = ((int)0x8807)        ,
        ProgramNativeAluInstructionsArb = ((int)0x8808)        ,
        ProgramNativeTexInstructionsArb = ((int)0x8809)        ,
        ProgramNativeTexIndirectionsArb = ((int)0x880A)        ,
        MaxProgramAluInstructionsArb = ((int)0x880B)        ,
        MaxProgramTexInstructionsArb = ((int)0x880C)        ,
        MaxProgramTexIndirectionsArb = ((int)0x880D)        ,
        MaxProgramNativeAluInstructionsArb = ((int)0x880E)        ,
        MaxProgramNativeTexInstructionsArb = ((int)0x880F)        ,
        MaxProgramNativeTexIndirectionsArb = ((int)0x8810)        ,
        Rgba32f = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        RgbaFloatMode = ((int)0x8820)        ,
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
        BlendEquationAlpha = ((int)0x883D)        ,
        TextureDepthSize = ((int)0x884A)        ,
        DepthTextureMode = ((int)0x884B)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        CompareRToTexture = ((int)0x884E)        ,
        TextureCubeMapSeamless = ((int)0x884F)        ,
        PointSprite = ((int)0x8861)        ,
        CoordReplace = ((int)0x8862)        ,
        QueryCounterBits = ((int)0x8864)        ,
        CurrentQuery = ((int)0x8865)        ,
        QueryResult = ((int)0x8866)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        ArrayNormalized = ((int)0x886A)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        MaxTessControlInputComponents = ((int)0x886C)        ,
        MaxTessEvaluationInputComponents = ((int)0x886D)        ,
        MaxTextureCoords = ((int)0x8871)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        ProgramFormatAsciiArb = ((int)0x8875)        ,
        ProgramFormat = ((int)0x8876)        ,
        GeometryShaderInvocations = ((int)0x887F)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexArrayBufferBinding = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        IndexArrayBufferBinding = ((int)0x8899)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        EdgeFlagArrayBufferBinding = ((int)0x889B)        ,
        SecondaryColorArrayBufferBinding = ((int)0x889C)        ,
        FogCoordArrayBufferBinding = ((int)0x889D)        ,
        WeightArrayBufferBinding = ((int)0x889E)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        ProgramInstruction = ((int)0x88A0)        ,
        MaxProgramInstructions = ((int)0x88A1)        ,
        ProgramNativeInstructions = ((int)0x88A2)        ,
        MaxProgramNativeInstructions = ((int)0x88A3)        ,
        ProgramTemporaries = ((int)0x88A4)        ,
        MaxProgramTemporaries = ((int)0x88A5)        ,
        ProgramNativeTemporaries = ((int)0x88A6)        ,
        MaxProgramNativeTemporaries = ((int)0x88A7)        ,
        ProgramParameters = ((int)0x88A8)        ,
        MaxProgramParameters = ((int)0x88A9)        ,
        ProgramNativeParameters = ((int)0x88AA)        ,
        MaxProgramNativeParameters = ((int)0x88AB)        ,
        ProgramAttribs = ((int)0x88AC)        ,
        MaxProgramAttribs = ((int)0x88AD)        ,
        ProgramNativeAttribs = ((int)0x88AE)        ,
        MaxProgramNativeAttribs = ((int)0x88AF)        ,
        ProgramAddressRegisters = ((int)0x88B0)        ,
        MaxProgramAddressRegisters = ((int)0x88B1)        ,
        ProgramNativeAddressRegisters = ((int)0x88B2)        ,
        MaxProgramNativeAddressRegisters = ((int)0x88B3)        ,
        MaxProgramLocalParameters = ((int)0x88B4)        ,
        MaxProgramEnvParameters = ((int)0x88B5)        ,
        ProgramUnderNativeLimits = ((int)0x88B6)        ,
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
        BufferAccess = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        TimeElapsed = ((int)0x88BF)        ,
        Matrix0 = ((int)0x88C0)        ,
        Matrix1 = ((int)0x88C1)        ,
        Matrix2 = ((int)0x88C2)        ,
        Matrix3 = ((int)0x88C3)        ,
        Matrix4 = ((int)0x88C4)        ,
        Matrix5 = ((int)0x88C5)        ,
        Matrix6 = ((int)0x88C6)        ,
        Matrix7 = ((int)0x88C7)        ,
        Matrix8 = ((int)0x88C8)        ,
        Matrix9 = ((int)0x88C9)        ,
        Matrix10 = ((int)0x88CA)        ,
        Matrix11 = ((int)0x88CB)        ,
        Matrix12 = ((int)0x88CC)        ,
        Matrix13 = ((int)0x88CD)        ,
        Matrix14 = ((int)0x88CE)        ,
        Matrix15 = ((int)0x88CF)        ,
        Matrix16 = ((int)0x88D0)        ,
        Matrix17 = ((int)0x88D1)        ,
        Matrix18 = ((int)0x88D2)        ,
        Matrix19 = ((int)0x88D3)        ,
        Matrix20 = ((int)0x88D4)        ,
        Matrix21 = ((int)0x88D5)        ,
        Matrix22 = ((int)0x88D6)        ,
        Matrix23 = ((int)0x88D7)        ,
        Matrix24 = ((int)0x88D8)        ,
        Matrix25 = ((int)0x88D9)        ,
        Matrix26 = ((int)0x88DA)        ,
        Matrix27 = ((int)0x88DB)        ,
        Matrix28 = ((int)0x88DC)        ,
        Matrix29 = ((int)0x88DD)        ,
        Matrix30 = ((int)0x88DE)        ,
        Matrix31 = ((int)0x88DF)        ,
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
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        TextureStencilSize = ((int)0x88F1)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        MaxDualSourceDrawBuffers = ((int)0x88FC)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        ArrayDivisor = ((int)0x88FE)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        SamplesPassed = ((int)0x8914)        ,
        GeometryVerticesOut = ((int)0x8916)        ,
        GeometryInputType = ((int)0x8917)        ,
        GeometryOutputType = ((int)0x8918)        ,
        SamplerBinding = ((int)0x8919)        ,
        ClampVertexColor = ((int)0x891A)        ,
        ClampFragmentColor = ((int)0x891B)        ,
        ClampReadColor = ((int)0x891C)        ,
        FixedOnly = ((int)0x891D)        ,
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
        UniformBuffer = ((int)0x8A11)        ,
        UniformBufferBinding = ((int)0x8A28)        ,
        UniformBufferStart = ((int)0x8A29)        ,
        UniformBufferSize = ((int)0x8A2A)        ,
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        MaxGeometryUniformBlocks = ((int)0x8A2C)        ,
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        MaxUniformBlockSize = ((int)0x8A30)        ,
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        MaxCombinedGeometryUniformComponents = ((int)0x8A32)        ,
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
        UniformBlockReferencedByGeometryShader = ((int)0x8A45)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        MaxVaryingFloats = ((int)0x8B4B)        ,
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
        Sampler1D = ((int)0x8B5D)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        Sampler1DShadow = ((int)0x8B61)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        Sampler2DRect = ((int)0x8B63)        ,
        Sampler2DRectShadow = ((int)0x8B64)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
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
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        TextureRedType = ((int)0x8C10)        ,
        TextureGreenType = ((int)0x8C11)        ,
        TextureBlueType = ((int)0x8C12)        ,
        TextureAlphaType = ((int)0x8C13)        ,
        TextureLuminanceType = ((int)0x8C14)        ,
        TextureIntensityType = ((int)0x8C15)        ,
        TextureDepthType = ((int)0x8C16)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        Texture1DArray = ((int)0x8C18)        ,
        ProxyTexture1DArray = ((int)0x8C19)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        ProxyTexture2DArray = ((int)0x8C1B)        ,
        TextureBinding1DArray = ((int)0x8C1C)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        MaxGeometryTextureImageUnits = ((int)0x8C29)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        TextureBufferBinding = ((int)0x8C2A)        ,
        MaxTextureBufferSize = ((int)0x8C2B)        ,
        TextureBindingBuffer = ((int)0x8C2C)        ,
        TextureBufferDataStoreBinding = ((int)0x8C2D)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        SampleShading = ((int)0x8C36)        ,
        SampleShadingArb = ((int)0x8C36)        ,
        MinSampleShadingValue = ((int)0x8C37)        ,
        MinSampleShadingValueArb = ((int)0x8C37)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        TextureSharedSize = ((int)0x8C3F)        ,
        Srgb = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        SrgbAlpha = ((int)0x8C42)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        SluminanceAlpha = ((int)0x8C44)        ,
        Sluminance8Alpha8 = ((int)0x8C45)        ,
        Sluminance = ((int)0x8C46)        ,
        Sluminance8 = ((int)0x8C47)        ,
        CompressedSrgb = ((int)0x8C48)        ,
        CompressedSrgbAlpha = ((int)0x8C49)        ,
        CompressedSluminance = ((int)0x8C4A)        ,
        CompressedSluminanceAlpha = ((int)0x8C4B)        ,
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        PrimitivesGenerated = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        InterleavedAttribs = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        PointSpriteCoordOrigin = ((int)0x8CA0)        ,
        LowerLeft = ((int)0x8CA1)        ,
        UpperLeft = ((int)0x8CA2)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBindingExt = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        RenderbufferBindingExt = ((int)0x8CA7)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectTypeExt = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentObjectNameExt = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureLevelExt = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8CD3)        ,
        FramebufferAttachmentTexture3DZoffsetExt = ((int)0x8CD4)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferCompleteExt = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteAttachmentExt = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensionsExt = ((int)0x8CD9)        ,
        FramebufferIncompleteFormatsExt = ((int)0x8CDA)        ,
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB)        ,
        FramebufferIncompleteDrawBufferExt = ((int)0x8CDB)        ,
        FramebufferIncompleteReadBuffer = ((int)0x8CDC)        ,
        FramebufferIncompleteReadBufferExt = ((int)0x8CDC)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        FramebufferUnsupportedExt = ((int)0x8CDD)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
        MaxColorAttachmentsExt = ((int)0x8CDF)        ,
        ColorAttachment0 = ((int)0x8CE0)        ,
        ColorAttachment0Ext = ((int)0x8CE0)        ,
        ColorAttachment1 = ((int)0x8CE1)        ,
        ColorAttachment1Ext = ((int)0x8CE1)        ,
        ColorAttachment2 = ((int)0x8CE2)        ,
        ColorAttachment2Ext = ((int)0x8CE2)        ,
        ColorAttachment3 = ((int)0x8CE3)        ,
        ColorAttachment3Ext = ((int)0x8CE3)        ,
        ColorAttachment4 = ((int)0x8CE4)        ,
        ColorAttachment4Ext = ((int)0x8CE4)        ,
        ColorAttachment5 = ((int)0x8CE5)        ,
        ColorAttachment5Ext = ((int)0x8CE5)        ,
        ColorAttachment6 = ((int)0x8CE6)        ,
        ColorAttachment6Ext = ((int)0x8CE6)        ,
        ColorAttachment7 = ((int)0x8CE7)        ,
        ColorAttachment7Ext = ((int)0x8CE7)        ,
        ColorAttachment8 = ((int)0x8CE8)        ,
        ColorAttachment8Ext = ((int)0x8CE8)        ,
        ColorAttachment9 = ((int)0x8CE9)        ,
        ColorAttachment9Ext = ((int)0x8CE9)        ,
        ColorAttachment10 = ((int)0x8CEA)        ,
        ColorAttachment10Ext = ((int)0x8CEA)        ,
        ColorAttachment11 = ((int)0x8CEB)        ,
        ColorAttachment11Ext = ((int)0x8CEB)        ,
        ColorAttachment12 = ((int)0x8CEC)        ,
        ColorAttachment12Ext = ((int)0x8CEC)        ,
        ColorAttachment13 = ((int)0x8CED)        ,
        ColorAttachment13Ext = ((int)0x8CED)        ,
        ColorAttachment14 = ((int)0x8CEE)        ,
        ColorAttachment14Ext = ((int)0x8CEE)        ,
        ColorAttachment15 = ((int)0x8CEF)        ,
        ColorAttachment15Ext = ((int)0x8CEF)        ,
        DepthAttachment = ((int)0x8D00)        ,
        DepthAttachmentExt = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        StencilAttachmentExt = ((int)0x8D20)        ,
        Framebuffer = ((int)0x8D40)        ,
        FramebufferExt = ((int)0x8D40)        ,
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferExt = ((int)0x8D41)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferWidthExt = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferHeightExt = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        RenderbufferInternalFormatExt = ((int)0x8D44)        ,
        StencilIndex1 = ((int)0x8D46)        ,
        StencilIndex1Ext = ((int)0x8D46)        ,
        StencilIndex4 = ((int)0x8D47)        ,
        StencilIndex4Ext = ((int)0x8D47)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        StencilIndex8Ext = ((int)0x8D48)        ,
        StencilIndex16 = ((int)0x8D49)        ,
        StencilIndex16Ext = ((int)0x8D49)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferRedSizeExt = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferGreenSizeExt = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferBlueSizeExt = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferAlphaSizeExt = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferDepthSizeExt = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        RenderbufferStencilSizeExt = ((int)0x8D55)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
        Rgb565 = ((int)0x8D62)        ,
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
        GreenInteger = ((int)0x8D95)        ,
        BlueInteger = ((int)0x8D96)        ,
        AlphaInteger = ((int)0x8D97)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        BgrInteger = ((int)0x8D9A)        ,
        BgraInteger = ((int)0x8D9B)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
        FramebufferAttachmentLayered = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargets = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCount = ((int)0x8DA9)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        ShaderIncludeArb = ((int)0x8DAE)        ,
        FramebufferSrgb = ((int)0x8DB9)        ,
        CompressedRedRgtc1 = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1 = ((int)0x8DBC)        ,
        CompressedRgRgtc2 = ((int)0x8DBD)        ,
        CompressedSignedRgRgtc2 = ((int)0x8DBE)        ,
        Sampler1DArray = ((int)0x8DC0)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        SamplerBuffer = ((int)0x8DC2)        ,
        Sampler1DArrayShadow = ((int)0x8DC3)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler1D = ((int)0x8DC9)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler2DRect = ((int)0x8DCD)        ,
        IntSampler1DArray = ((int)0x8DCE)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        IntSamplerBuffer = ((int)0x8DD0)        ,
        UnsignedIntSampler1D = ((int)0x8DD1)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler2DRect = ((int)0x8DD5)        ,
        UnsignedIntSampler1DArray = ((int)0x8DD6)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        UnsignedIntSamplerBuffer = ((int)0x8DD8)        ,
        GeometryShader = ((int)0x8DD9)        ,
        MaxGeometryVaryingComponents = ((int)0x8DDD)        ,
        MaxVertexVaryingComponents = ((int)0x8DDE)        ,
        MaxGeometryUniformComponents = ((int)0x8DDF)        ,
        MaxGeometryOutputVertices = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponents = ((int)0x8DE1)        ,
        ActiveSubroutines = ((int)0x8DE5)        ,
        ActiveSubroutineUniforms = ((int)0x8DE6)        ,
        MaxSubroutines = ((int)0x8DE7)        ,
        MaxSubroutineUniformLocations = ((int)0x8DE8)        ,
        NamedStringLengthArb = ((int)0x8DE9)        ,
        NamedStringTypeArb = ((int)0x8DEA)        ,
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
        QueryWait = ((int)0x8E13)        ,
        QueryNoWait = ((int)0x8E14)        ,
        QueryByRegionWait = ((int)0x8E15)        ,
        QueryByRegionNoWait = ((int)0x8E16)        ,
        MaxCombinedTessControlUniformComponents = ((int)0x8E1E)        ,
        MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)        ,
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackBufferPaused = ((int)0x8E23)        ,
        TransformFeedbackPaused = ((int)0x8E23)        ,
        TransformFeedbackActive = ((int)0x8E24)        ,
        TransformFeedbackBufferActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        Timestamp = ((int)0x8E28)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
        ActiveSubroutineUniformLocations = ((int)0x8E47)        ,
        ActiveSubroutineMaxLength = ((int)0x8E48)        ,
        ActiveSubroutineUniformMaxLength = ((int)0x8E49)        ,
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
        QuadsFollowProvokingVertexConvention = ((int)0x8E4C)        ,
        FirstVertexConvention = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
        SamplePosition = ((int)0x8E50)        ,
        SampleMask = ((int)0x8E51)        ,
        SampleMaskValue = ((int)0x8E52)        ,
        MaxSampleMaskWords = ((int)0x8E59)        ,
        MaxGeometryShaderInvocations = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffset = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffset = ((int)0x8E5C)        ,
        FragmentInterpolationOffsetBits = ((int)0x8E5D)        ,
        MinProgramTextureGatherOffset = ((int)0x8E5E)        ,
        MinProgramTextureGatherOffsetArb = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffset = ((int)0x8E5F)        ,
        MaxProgramTextureGatherOffsetArb = ((int)0x8E5F)        ,
        MaxTransformFeedbackBuffers = ((int)0x8E70)        ,
        MaxVertexStreams = ((int)0x8E71)        ,
        PatchVertices = ((int)0x8E72)        ,
        PatchDefaultInnerLevel = ((int)0x8E73)        ,
        PatchDefaultOuterLevel = ((int)0x8E74)        ,
        TessControlOutputVertices = ((int)0x8E75)        ,
        TessGenMode = ((int)0x8E76)        ,
        TessGenSpacing = ((int)0x8E77)        ,
        TessGenVertexOrder = ((int)0x8E78)        ,
        TessGenPointMode = ((int)0x8E79)        ,
        Isolines = ((int)0x8E7A)        ,
        FractionalOdd = ((int)0x8E7B)        ,
        FractionalEven = ((int)0x8E7C)        ,
        MaxPatchVertices = ((int)0x8E7D)        ,
        MaxTessGenLevel = ((int)0x8E7E)        ,
        MaxTessControlUniformComponents = ((int)0x8E7F)        ,
        MaxTessEvaluationUniformComponents = ((int)0x8E80)        ,
        MaxTessControlTextureImageUnits = ((int)0x8E81)        ,
        MaxTessEvaluationTextureImageUnits = ((int)0x8E82)        ,
        MaxTessControlOutputComponents = ((int)0x8E83)        ,
        MaxTessPatchComponents = ((int)0x8E84)        ,
        MaxTessControlTotalOutputComponents = ((int)0x8E85)        ,
        MaxTessEvaluationOutputComponents = ((int)0x8E86)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        MaxTessControlUniformBlocks = ((int)0x8E89)        ,
        MaxTessEvaluationUniformBlocks = ((int)0x8E8A)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnormArb = ((int)0x8E8C)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnormArb = ((int)0x8E8D)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloatArb = ((int)0x8E8E)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloatArb = ((int)0x8E8F)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyReadBufferBinding = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        CopyWriteBufferBinding = ((int)0x8F37)        ,
        MaxImageUnits = ((int)0x8F38)        ,
        MaxCombinedImageUnitsAndFragmentOutputs = ((int)0x8F39)        ,
        MaxCombinedShaderOutputResources = ((int)0x8F39)        ,
        ImageBindingName = ((int)0x8F3A)        ,
        ImageBindingLevel = ((int)0x8F3B)        ,
        ImageBindingLayered = ((int)0x8F3C)        ,
        ImageBindingLayer = ((int)0x8F3D)        ,
        ImageBindingAccess = ((int)0x8F3E)        ,
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        R16Snorm = ((int)0x8F98)        ,
        Rg16Snorm = ((int)0x8F99)        ,
        Rgb16Snorm = ((int)0x8F9A)        ,
        Rgba16Snorm = ((int)0x8F9B)        ,
        SignedNormalized = ((int)0x8F9C)        ,
        PrimitiveRestart = ((int)0x8F9D)        ,
        PrimitiveRestartIndex = ((int)0x8F9E)        ,
        MaxProgramTextureGatherComponentsArb = ((int)0x8F9F)        ,
        BinningControlHintQcom = ((int)0x8FB0)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
        /// <summary>
        /// Original was GL_SAMPLER_BUFFER_AMD = 0x9001
        /// </summary>
        SamplerBufferAmd = ((int)0x9001)        ,
        /// <summary>
        /// Original was GL_INT_SAMPLER_BUFFER_AMD = 0x9002
        /// </summary>
        IntSamplerBufferAmd = ((int)0x9002)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003
        /// </summary>
        UnsignedIntSamplerBufferAmd = ((int)0x9003)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_MODE_AMD = 0x9004
        /// </summary>
        TessellationModeAmd = ((int)0x9004)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_FACTOR_AMD = 0x9005
        /// </summary>
        TessellationFactorAmd = ((int)0x9005)        ,
        /// <summary>
        /// Original was GL_DISCRETE_AMD = 0x9006
        /// </summary>
        DiscreteAmd = ((int)0x9006)        ,
        /// <summary>
        /// Original was GL_CONTINUOUS_AMD = 0x9007
        /// </summary>
        ContinuousAmd = ((int)0x9007)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = ((int)0x9009)        ,
        TextureCubeMapArrayArb = ((int)0x9009)        ,
        TextureBindingCubeMapArray = ((int)0x900A)        ,
        TextureBindingCubeMapArrayArb = ((int)0x900A)        ,
        ProxyTextureCubeMapArray = ((int)0x900B)        ,
        ProxyTextureCubeMapArrayArb = ((int)0x900B)        ,
        SamplerCubeMapArray = ((int)0x900C)        ,
        SamplerCubeMapArrayArb = ((int)0x900C)        ,
        SamplerCubeMapArrayShadow = ((int)0x900D)        ,
        SamplerCubeMapArrayShadowArb = ((int)0x900D)        ,
        IntSamplerCubeMapArray = ((int)0x900E)        ,
        IntSamplerCubeMapArrayArb = ((int)0x900E)        ,
        UnsignedIntSamplerCubeMapArray = ((int)0x900F)        ,
        UnsignedIntSamplerCubeMapArrayArb = ((int)0x900F)        ,
        Image1D = ((int)0x904C)        ,
        Image2D = ((int)0x904D)        ,
        Image3D = ((int)0x904E)        ,
        Image2DRect = ((int)0x904F)        ,
        ImageCube = ((int)0x9050)        ,
        ImageBuffer = ((int)0x9051)        ,
        Image1DArray = ((int)0x9052)        ,
        Image2DArray = ((int)0x9053)        ,
        ImageCubeMapArray = ((int)0x9054)        ,
        Image2DMultisample = ((int)0x9055)        ,
        Image2DMultisampleArray = ((int)0x9056)        ,
        IntImage1D = ((int)0x9057)        ,
        IntImage2D = ((int)0x9058)        ,
        IntImage3D = ((int)0x9059)        ,
        IntImage2DRect = ((int)0x905A)        ,
        IntImageCube = ((int)0x905B)        ,
        IntImageBuffer = ((int)0x905C)        ,
        IntImage1DArray = ((int)0x905D)        ,
        IntImage2DArray = ((int)0x905E)        ,
        IntImageCubeMapArray = ((int)0x905F)        ,
        IntImage2DMultisample = ((int)0x9060)        ,
        IntImage2DMultisampleArray = ((int)0x9061)        ,
        UnsignedIntImage1D = ((int)0x9062)        ,
        UnsignedIntImage2D = ((int)0x9063)        ,
        UnsignedIntImage3D = ((int)0x9064)        ,
        UnsignedIntImage2DRect = ((int)0x9065)        ,
        UnsignedIntImageCube = ((int)0x9066)        ,
        UnsignedIntImageBuffer = ((int)0x9067)        ,
        UnsignedIntImage1DArray = ((int)0x9068)        ,
        UnsignedIntImage2DArray = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArray = ((int)0x906A)        ,
        UnsignedIntImage2DMultisample = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArray = ((int)0x906C)        ,
        MaxImageSamples = ((int)0x906D)        ,
        ImageBindingFormat = ((int)0x906E)        ,
        Rgb10A2ui = ((int)0x906F)        ,
        MinMapBufferAlignment = ((int)0x90BC)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        ImageFormatCompatibilityBySize = ((int)0x90C8)        ,
        ImageFormatCompatibilityByClass = ((int)0x90C9)        ,
        MaxVertexImageUniforms = ((int)0x90CA)        ,
        MaxTessControlImageUniforms = ((int)0x90CB)        ,
        MaxTessEvaluationImageUniforms = ((int)0x90CC)        ,
        MaxGeometryImageUniforms = ((int)0x90CD)        ,
        MaxFragmentImageUniforms = ((int)0x90CE)        ,
        MaxCombinedImageUniforms = ((int)0x90CF)        ,
        ShaderStorageBuffer = ((int)0x90D2)        ,
        ShaderStorageBufferBinding = ((int)0x90D3)        ,
        ShaderStorageBufferStart = ((int)0x90D4)        ,
        ShaderStorageBufferSize = ((int)0x90D5)        ,
        MaxVertexShaderStorageBlocks = ((int)0x90D6)        ,
        MaxGeometryShaderStorageBlocks = ((int)0x90D7)        ,
        MaxTessControlShaderStorageBlocks = ((int)0x90D8)        ,
        MaxTessEvaluationShaderStorageBlocks = ((int)0x90D9)        ,
        MaxFragmentShaderStorageBlocks = ((int)0x90DA)        ,
        MaxComputeShaderStorageBlocks = ((int)0x90DB)        ,
        MaxCombinedShaderStorageBlocks = ((int)0x90DC)        ,
        MaxShaderStorageBufferBindings = ((int)0x90DD)        ,
        MaxShaderStorageBlockSize = ((int)0x90DE)        ,
        ShaderStorageBufferOffsetAlignment = ((int)0x90DF)        ,
        DepthStencilTextureMode = ((int)0x90EA)        ,
        MaxComputeFixedGroupInvocationsArb = ((int)0x90EB)        ,
        MaxComputeWorkGroupInvocations = ((int)0x90EB)        ,
        UniformBlockReferencedByComputeShader = ((int)0x90EC)        ,
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED)        ,
        DispatchIndirectBuffer = ((int)0x90EE)        ,
        DispatchIndirectBufferBinding = ((int)0x90EF)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
        TextureBinding2DMultisample = ((int)0x9104)        ,
        TextureBinding2DMultisampleArray = ((int)0x9105)        ,
        TextureSamples = ((int)0x9106)        ,
        TextureFixedSampleLocations = ((int)0x9107)        ,
        Sampler2DMultisample = ((int)0x9108)        ,
        IntSampler2DMultisample = ((int)0x9109)        ,
        UnsignedIntSampler2DMultisample = ((int)0x910A)        ,
        Sampler2DMultisampleArray = ((int)0x910B)        ,
        IntSampler2DMultisampleArray = ((int)0x910C)        ,
        UnsignedIntSampler2DMultisampleArray = ((int)0x910D)        ,
        MaxColorTextureSamples = ((int)0x910E)        ,
        MaxDepthTextureSamples = ((int)0x910F)        ,
        MaxIntegerSamples = ((int)0x9110)        ,
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
        MaxGeometryInputComponents = ((int)0x9123)        ,
        MaxGeometryOutputComponents = ((int)0x9124)        ,
        MaxFragmentInputComponents = ((int)0x9125)        ,
        ContextProfileMask = ((int)0x9126)        ,
        UnpackCompressedBlockWidth = ((int)0x9127)        ,
        UnpackCompressedBlockHeight = ((int)0x9128)        ,
        UnpackCompressedBlockDepth = ((int)0x9129)        ,
        UnpackCompressedBlockSize = ((int)0x912A)        ,
        PackCompressedBlockWidth = ((int)0x912B)        ,
        PackCompressedBlockHeight = ((int)0x912C)        ,
        PackCompressedBlockDepth = ((int)0x912D)        ,
        PackCompressedBlockSize = ((int)0x912E)        ,
        TextureImmutableFormat = ((int)0x912F)        ,
        MaxDebugMessageLength = ((int)0x9143)        ,
        MaxDebugMessageLengthArb = ((int)0x9143)        ,
        MaxDebugMessageLengthKhr = ((int)0x9143)        ,
        MaxDebugLoggedMessages = ((int)0x9144)        ,
        MaxDebugLoggedMessagesArb = ((int)0x9144)        ,
        MaxDebugLoggedMessagesKhr = ((int)0x9144)        ,
        DebugLoggedMessages = ((int)0x9145)        ,
        DebugLoggedMessagesArb = ((int)0x9145)        ,
        DebugLoggedMessagesKhr = ((int)0x9145)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityHighArb = ((int)0x9146)        ,
        DebugSeverityHighKhr = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityMediumArb = ((int)0x9147)        ,
        DebugSeverityMediumKhr = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
        DebugSeverityLowArb = ((int)0x9148)        ,
        DebugSeverityLowKhr = ((int)0x9148)        ,
        QueryBuffer = ((int)0x9192)        ,
        QueryBufferBinding = ((int)0x9193)        ,
        QueryResultNoWait = ((int)0x9194)        ,
        VirtualPageSizeXArb = ((int)0x9195)        ,
        VirtualPageSizeYArb = ((int)0x9196)        ,
        VirtualPageSizeZArb = ((int)0x9197)        ,
        MaxSparseTextureSizeArb = ((int)0x9198)        ,
        MaxSparse3DTextureSizeArb = ((int)0x9199)        ,
        MaxSparseArrayTextureLayersArb = ((int)0x919A)        ,
        MinSparseLevelArb = ((int)0x919B)        ,
        TextureBufferOffset = ((int)0x919D)        ,
        TextureBufferSize = ((int)0x919E)        ,
        TextureBufferOffsetAlignment = ((int)0x919F)        ,
        TextureSparseArb = ((int)0x91A6)        ,
        VirtualPageSizeIndexArb = ((int)0x91A7)        ,
        NumVirtualPageSizesArb = ((int)0x91A8)        ,
        SparseTextureFullArrayCubeMipmapsArb = ((int)0x91A9)        ,
        ComputeShader = ((int)0x91B9)        ,
        MaxComputeUniformBlocks = ((int)0x91BB)        ,
        MaxComputeTextureImageUnits = ((int)0x91BC)        ,
        MaxComputeImageUniforms = ((int)0x91BD)        ,
        MaxComputeWorkGroupCount = ((int)0x91BE)        ,
        MaxComputeFixedGroupSizeArb = ((int)0x91BF)        ,
        MaxComputeWorkGroupSize = ((int)0x91BF)        ,
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
        AtomicCounterBuffer = ((int)0x92C0)        ,
        AtomicCounterBufferBinding = ((int)0x92C1)        ,
        AtomicCounterBufferStart = ((int)0x92C2)        ,
        AtomicCounterBufferSize = ((int)0x92C3)        ,
        AtomicCounterBufferDataSize = ((int)0x92C4)        ,
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5)        ,
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6)        ,
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7)        ,
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8)        ,
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9)        ,
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA)        ,
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB)        ,
        MaxVertexAtomicCounterBuffers = ((int)0x92CC)        ,
        MaxTessControlAtomicCounterBuffers = ((int)0x92CD)        ,
        MaxTessEvaluationAtomicCounterBuffers = ((int)0x92CE)        ,
        MaxGeometryAtomicCounterBuffers = ((int)0x92CF)        ,
        MaxFragmentAtomicCounterBuffers = ((int)0x92D0)        ,
        MaxCombinedAtomicCounterBuffers = ((int)0x92D1)        ,
        MaxVertexAtomicCounters = ((int)0x92D2)        ,
        MaxTessControlAtomicCounters = ((int)0x92D3)        ,
        MaxTessEvaluationAtomicCounters = ((int)0x92D4)        ,
        MaxGeometryAtomicCounters = ((int)0x92D5)        ,
        MaxFragmentAtomicCounters = ((int)0x92D6)        ,
        MaxCombinedAtomicCounters = ((int)0x92D7)        ,
        MaxAtomicCounterBufferSize = ((int)0x92D8)        ,
        ActiveAtomicCounterBuffers = ((int)0x92D9)        ,
        UniformAtomicCounterBufferIndex = ((int)0x92DA)        ,
        UnsignedIntAtomicCounter = ((int)0x92DB)        ,
        MaxAtomicCounterBufferBindings = ((int)0x92DC)        ,
        DebugOutput = ((int)0x92E0)        ,
        DebugOutputKhr = ((int)0x92E0)        ,
        Uniform = ((int)0x92E1)        ,
        UniformBlock = ((int)0x92E2)        ,
        ProgramInput = ((int)0x92E3)        ,
        ProgramOutput = ((int)0x92E4)        ,
        BufferVariable = ((int)0x92E5)        ,
        ShaderStorageBlock = ((int)0x92E6)        ,
        IsPerPatch = ((int)0x92E7)        ,
        VertexSubroutine = ((int)0x92E8)        ,
        TessControlSubroutine = ((int)0x92E9)        ,
        TessEvaluationSubroutine = ((int)0x92EA)        ,
        GeometrySubroutine = ((int)0x92EB)        ,
        FragmentSubroutine = ((int)0x92EC)        ,
        ComputeSubroutine = ((int)0x92ED)        ,
        VertexSubroutineUniform = ((int)0x92EE)        ,
        TessControlSubroutineUniform = ((int)0x92EF)        ,
        TessEvaluationSubroutineUniform = ((int)0x92F0)        ,
        GeometrySubroutineUniform = ((int)0x92F1)        ,
        FragmentSubroutineUniform = ((int)0x92F2)        ,
        ComputeSubroutineUniform = ((int)0x92F3)        ,
        TransformFeedbackVarying = ((int)0x92F4)        ,
        ActiveResources = ((int)0x92F5)        ,
        MaxNameLength = ((int)0x92F6)        ,
        MaxNumActiveVariables = ((int)0x92F7)        ,
        MaxNumCompatibleSubroutines = ((int)0x92F8)        ,
        NameLength = ((int)0x92F9)        ,
        Type = ((int)0x92FA)        ,
        ArraySize = ((int)0x92FB)        ,
        Offset = ((int)0x92FC)        ,
        BlockIndex = ((int)0x92FD)        ,
        ArrayStride = ((int)0x92FE)        ,
        MatrixStride = ((int)0x92FF)        ,
        IsRowMajor = ((int)0x9300)        ,
        AtomicCounterBufferIndex = ((int)0x9301)        ,
        BufferBinding = ((int)0x9302)        ,
        BufferDataSize = ((int)0x9303)        ,
        NumActiveVariables = ((int)0x9304)        ,
        ActiveVariables = ((int)0x9305)        ,
        ReferencedByVertexShader = ((int)0x9306)        ,
        ReferencedByTessControlShader = ((int)0x9307)        ,
        ReferencedByTessEvaluationShader = ((int)0x9308)        ,
        ReferencedByGeometryShader = ((int)0x9309)        ,
        ReferencedByFragmentShader = ((int)0x930A)        ,
        ReferencedByComputeShader = ((int)0x930B)        ,
        TopLevelArraySize = ((int)0x930C)        ,
        TopLevelArrayStride = ((int)0x930D)        ,
        Location = ((int)0x930E)        ,
        LocationIndex = ((int)0x930F)        ,
        FramebufferDefaultWidth = ((int)0x9310)        ,
        FramebufferDefaultHeight = ((int)0x9311)        ,
        FramebufferDefaultLayers = ((int)0x9312)        ,
        FramebufferDefaultSamples = ((int)0x9313)        ,
        FramebufferDefaultFixedSampleLocations = ((int)0x9314)        ,
        MaxFramebufferWidth = ((int)0x9315)        ,
        MaxFramebufferHeight = ((int)0x9316)        ,
        MaxFramebufferLayers = ((int)0x9317)        ,
        MaxFramebufferSamples = ((int)0x9318)        ,
        MaxComputeVariableGroupInvocationsArb = ((int)0x9344)        ,
        MaxComputeVariableGroupSizeArb = ((int)0x9345)        ,
        LocationComponent = ((int)0x934A)        ,
        TransformFeedbackBufferIndex = ((int)0x934B)        ,
        TransformFeedbackBufferStride = ((int)0x934C)        ,
        ClearTexture = ((int)0x9365)        ,
        NumSampleCounts = ((int)0x9380)        ,
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
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
        InvalidIndex = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF)        ,
        /// <summary>
        /// Original was GL_TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF
        /// </summary>
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
        LayoutLinearIntel = ((int)1)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
        Two = ((int)2)        ,
        Three = ((int)3)        ,
        Four = ((int)4)        ,
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
    public enum AmdVertexShaderTesselator : int
    {
        /// <summary>
        /// Original was GL_SAMPLER_BUFFER_AMD = 0x9001
        /// </summary>
        SamplerBufferAmd = ((int)0x9001)        ,
        /// <summary>
        /// Original was GL_INT_SAMPLER_BUFFER_AMD = 0x9002
        /// </summary>
        IntSamplerBufferAmd = ((int)0x9002)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003
        /// </summary>
        UnsignedIntSamplerBufferAmd = ((int)0x9003)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_MODE_AMD = 0x9004
        /// </summary>
        TessellationModeAmd = ((int)0x9004)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_FACTOR_AMD = 0x9005
        /// </summary>
        TessellationFactorAmd = ((int)0x9005)        ,
        /// <summary>
        /// Original was GL_DISCRETE_AMD = 0x9006
        /// </summary>
        DiscreteAmd = ((int)0x9006)        ,
        /// <summary>
        /// Original was GL_CONTINUOUS_AMD = 0x9007
        /// </summary>
        ContinuousAmd = ((int)0x9007)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdVertexShaderTessellator : int
    {
        /// <summary>
        /// Original was GL_SAMPLER_BUFFER_AMD = 0x9001
        /// </summary>
        SamplerBufferAmd = ((int)0x9001)        ,
        /// <summary>
        /// Original was GL_INT_SAMPLER_BUFFER_AMD = 0x9002
        /// </summary>
        IntSamplerBufferAmd = ((int)0x9002)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003
        /// </summary>
        UnsignedIntSamplerBufferAmd = ((int)0x9003)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_MODE_AMD = 0x9004
        /// </summary>
        TessellationModeAmd = ((int)0x9004)        ,
        /// <summary>
        /// Original was GL_TESSELLATION_FACTOR_AMD = 0x9005
        /// </summary>
        TessellationFactorAmd = ((int)0x9005)        ,
        /// <summary>
        /// Original was GL_DISCRETE_AMD = 0x9006
        /// </summary>
        DiscreteAmd = ((int)0x9006)        ,
        /// <summary>
        /// Original was GL_CONTINUOUS_AMD = 0x9007
        /// </summary>
        ContinuousAmd = ((int)0x9007)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbArraysOfArrays : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbBaseInstance : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbBindlessTexture : int
    {
        UnsignedInt64Arb = ((int)0x140F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbBlendFuncExtended : int
    {
        Src1Alpha = ((int)0x8589)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        MaxDualSourceDrawBuffers = ((int)0x88FC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbBufferStorage : int
    {
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        ClientStorageBit = ((int)0x0200)        ,
        BufferImmutableStorage = ((int)0x821F)        ,
        BufferStorageFlags = ((int)0x8220)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbClearBufferObject : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbClearTexture : int
    {
        ClearTexture = ((int)0x9365)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbClEvent : int
    {
        SyncClEventArb = ((int)0x8240)        ,
        SyncClEventCompleteArb = ((int)0x8241)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbCompressedTexturePixelStorage : int
    {
        UnpackCompressedBlockWidth = ((int)0x9127)        ,
        UnpackCompressedBlockHeight = ((int)0x9128)        ,
        UnpackCompressedBlockDepth = ((int)0x9129)        ,
        UnpackCompressedBlockSize = ((int)0x912A)        ,
        PackCompressedBlockWidth = ((int)0x912B)        ,
        PackCompressedBlockHeight = ((int)0x912C)        ,
        PackCompressedBlockDepth = ((int)0x912D)        ,
        PackCompressedBlockSize = ((int)0x912E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbComputeShader : int
    {
        ComputeShaderBit = ((int)0x00000020)        ,
        MaxComputeSharedMemorySize = ((int)0x8262)        ,
        MaxComputeUniformComponents = ((int)0x8263)        ,
        MaxComputeAtomicCounterBuffers = ((int)0x8264)        ,
        MaxComputeAtomicCounters = ((int)0x8265)        ,
        MaxCombinedComputeUniformComponents = ((int)0x8266)        ,
        ComputeWorkGroupSize = ((int)0x8267)        ,
        MaxComputeWorkGroupInvocations = ((int)0x90EB)        ,
        UniformBlockReferencedByComputeShader = ((int)0x90EC)        ,
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED)        ,
        DispatchIndirectBuffer = ((int)0x90EE)        ,
        DispatchIndirectBufferBinding = ((int)0x90EF)        ,
        ComputeShader = ((int)0x91B9)        ,
        MaxComputeUniformBlocks = ((int)0x91BB)        ,
        MaxComputeTextureImageUnits = ((int)0x91BC)        ,
        MaxComputeImageUniforms = ((int)0x91BD)        ,
        MaxComputeWorkGroupCount = ((int)0x91BE)        ,
        MaxComputeWorkGroupSize = ((int)0x91BF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbComputeVariableGroupSize : int
    {
        MaxComputeFixedGroupInvocationsArb = ((int)0x90EB)        ,
        MaxComputeFixedGroupSizeArb = ((int)0x91BF)        ,
        MaxComputeVariableGroupInvocationsArb = ((int)0x9344)        ,
        MaxComputeVariableGroupSizeArb = ((int)0x9345)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbConservativeDepth : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbCopyBuffer : int
    {
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyReadBufferBinding = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        CopyWriteBufferBinding = ((int)0x8F37)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbCopyImage : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDebugOutput : int
    {
        DebugOutputSynchronousArb = ((int)0x8242)        ,
        DebugNextLoggedMessageLengthArb = ((int)0x8243)        ,
        DebugCallbackFunctionArb = ((int)0x8244)        ,
        DebugCallbackUserParamArb = ((int)0x8245)        ,
        DebugSourceApiArb = ((int)0x8246)        ,
        DebugSourceWindowSystemArb = ((int)0x8247)        ,
        DebugSourceShaderCompilerArb = ((int)0x8248)        ,
        DebugSourceThirdPartyArb = ((int)0x8249)        ,
        DebugSourceApplicationArb = ((int)0x824A)        ,
        DebugSourceOtherArb = ((int)0x824B)        ,
        DebugTypeErrorArb = ((int)0x824C)        ,
        DebugTypeDeprecatedBehaviorArb = ((int)0x824D)        ,
        DebugTypeUndefinedBehaviorArb = ((int)0x824E)        ,
        DebugTypePortabilityArb = ((int)0x824F)        ,
        DebugTypePerformanceArb = ((int)0x8250)        ,
        DebugTypeOtherArb = ((int)0x8251)        ,
        MaxDebugMessageLengthArb = ((int)0x9143)        ,
        MaxDebugLoggedMessagesArb = ((int)0x9144)        ,
        DebugLoggedMessagesArb = ((int)0x9145)        ,
        DebugSeverityHighArb = ((int)0x9146)        ,
        DebugSeverityMediumArb = ((int)0x9147)        ,
        DebugSeverityLowArb = ((int)0x9148)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDepthBufferFloat : int
    {
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDepthClamp : int
    {
        DepthClamp = ((int)0x864F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDrawBuffersBlend : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDrawElementsBaseVertex : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDrawIndirect : int
    {
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbEnhancedLayouts : int
    {
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        LocationComponent = ((int)0x934A)        ,
        TransformFeedbackBufferIndex = ((int)0x934B)        ,
        TransformFeedbackBufferStride = ((int)0x934C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbEs2Compatibility : int
    {
        Fixed = ((int)0x140C)        ,
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbEs3Compatibility : int
    {
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        MaxElementIndex = ((int)0x8D6B)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbExplicitAttribLocation : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbExplicitUniformLocation : int
    {
        MaxUniformLocations = ((int)0x826E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFragmentCoordConventions : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFragmentLayerViewport : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFramebufferNoAttachments : int
    {
        FramebufferDefaultWidth = ((int)0x9310)        ,
        FramebufferDefaultHeight = ((int)0x9311)        ,
        FramebufferDefaultLayers = ((int)0x9312)        ,
        FramebufferDefaultSamples = ((int)0x9313)        ,
        FramebufferDefaultFixedSampleLocations = ((int)0x9314)        ,
        MaxFramebufferWidth = ((int)0x9315)        ,
        MaxFramebufferHeight = ((int)0x9316)        ,
        MaxFramebufferLayers = ((int)0x9317)        ,
        MaxFramebufferSamples = ((int)0x9318)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFramebufferObject : int
    {
        InvalidFramebufferOperation = ((int)0x0506)        ,
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
        Index = ((int)0x8222)        ,
        MaxRenderbufferSize = ((int)0x84E8)        ,
        DepthStencil = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        TextureStencilSize = ((int)0x88F1)        ,
        TextureRedType = ((int)0x8C10)        ,
        TextureGreenType = ((int)0x8C11)        ,
        TextureBlueType = ((int)0x8C12)        ,
        TextureAlphaType = ((int)0x8C13)        ,
        TextureDepthType = ((int)0x8C16)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB)        ,
        FramebufferIncompleteReadBuffer = ((int)0x8CDC)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
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
        DepthAttachment = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        Framebuffer = ((int)0x8D40)        ,
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        StencilIndex1 = ((int)0x8D46)        ,
        StencilIndex4 = ((int)0x8D47)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        StencilIndex16 = ((int)0x8D49)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFramebufferSrgb : int
    {
        FramebufferSrgb = ((int)0x8DB9)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbGetProgramBinary : int
    {
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbGpuShader5 : int
    {
        GeometryShaderInvocations = ((int)0x887F)        ,
        MaxGeometryShaderInvocations = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffset = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffset = ((int)0x8E5C)        ,
        FragmentInterpolationOffsetBits = ((int)0x8E5D)        ,
        MaxVertexStreams = ((int)0x8E71)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbGpuShaderFp64 : int
    {
        Double = ((int)0x140A)        ,
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbHalfFloatVertex : int
    {
        HalfFloat = ((int)0x140B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbImaging : int
    {
        ConstantColor = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        BlendColor = ((int)0x8005)        ,
        FuncAdd = ((int)0x8006)        ,
        Min = ((int)0x8007)        ,
        Max = ((int)0x8008)        ,
        BlendEquation = ((int)0x8009)        ,
        FuncSubtract = ((int)0x800A)        ,
        FuncReverseSubtract = ((int)0x800B)        ,
        Convolution1D = ((int)0x8010)        ,
        Convolution2D = ((int)0x8011)        ,
        Separable2D = ((int)0x8012)        ,
        ConvolutionBorderMode = ((int)0x8013)        ,
        ConvolutionFilterScale = ((int)0x8014)        ,
        ConvolutionFilterBias = ((int)0x8015)        ,
        Reduce = ((int)0x8016)        ,
        ConvolutionFormat = ((int)0x8017)        ,
        ConvolutionWidth = ((int)0x8018)        ,
        ConvolutionHeight = ((int)0x8019)        ,
        MaxConvolutionWidth = ((int)0x801A)        ,
        MaxConvolutionHeight = ((int)0x801B)        ,
        PostConvolutionRedScale = ((int)0x801C)        ,
        PostConvolutionGreenScale = ((int)0x801D)        ,
        PostConvolutionBlueScale = ((int)0x801E)        ,
        PostConvolutionAlphaScale = ((int)0x801F)        ,
        PostConvolutionRedBias = ((int)0x8020)        ,
        PostConvolutionGreenBias = ((int)0x8021)        ,
        PostConvolutionBlueBias = ((int)0x8022)        ,
        PostConvolutionAlphaBias = ((int)0x8023)        ,
        Histogram = ((int)0x8024)        ,
        ProxyHistogram = ((int)0x8025)        ,
        HistogramWidth = ((int)0x8026)        ,
        HistogramFormat = ((int)0x8027)        ,
        HistogramRedSize = ((int)0x8028)        ,
        HistogramGreenSize = ((int)0x8029)        ,
        HistogramBlueSize = ((int)0x802A)        ,
        HistogramAlphaSize = ((int)0x802B)        ,
        HistogramLuminanceSize = ((int)0x802C)        ,
        HistogramSink = ((int)0x802D)        ,
        Minmax = ((int)0x802E)        ,
        MinmaxFormat = ((int)0x802F)        ,
        MinmaxSink = ((int)0x8030)        ,
        TableTooLarge = ((int)0x8031)        ,
        ColorMatrix = ((int)0x80B1)        ,
        ColorMatrixStackDepth = ((int)0x80B2)        ,
        MaxColorMatrixStackDepth = ((int)0x80B3)        ,
        PostColorMatrixRedScale = ((int)0x80B4)        ,
        PostColorMatrixGreenScale = ((int)0x80B5)        ,
        PostColorMatrixBlueScale = ((int)0x80B6)        ,
        PostColorMatrixAlphaScale = ((int)0x80B7)        ,
        PostColorMatrixRedBias = ((int)0x80B8)        ,
        PostColorMatrixGreenBias = ((int)0x80B9)        ,
        PostColorMatrixBlueBias = ((int)0x80BA)        ,
        PostColorMatrixAlphaBias = ((int)0x80BB)        ,
        ColorTable = ((int)0x80D0)        ,
        PostConvolutionColorTable = ((int)0x80D1)        ,
        PostColorMatrixColorTable = ((int)0x80D2)        ,
        ProxyColorTable = ((int)0x80D3)        ,
        ProxyPostConvolutionColorTable = ((int)0x80D4)        ,
        ProxyPostColorMatrixColorTable = ((int)0x80D5)        ,
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
        ColorTableFormat = ((int)0x80D8)        ,
        ColorTableWidth = ((int)0x80D9)        ,
        ColorTableRedSize = ((int)0x80DA)        ,
        ColorTableGreenSize = ((int)0x80DB)        ,
        ColorTableBlueSize = ((int)0x80DC)        ,
        ColorTableAlphaSize = ((int)0x80DD)        ,
        ColorTableLuminanceSize = ((int)0x80DE)        ,
        ColorTableIntensitySize = ((int)0x80DF)        ,
        ConstantBorder = ((int)0x8151)        ,
        ReplicateBorder = ((int)0x8153)        ,
        ConvolutionBorderColor = ((int)0x8154)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbIndirectParameters : int
    {
        ParameterBufferArb = ((int)0x80EE)        ,
        ParameterBufferBindingArb = ((int)0x80EF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbInternalformatQuery : int
    {
        NumSampleCounts = ((int)0x9380)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbInternalformatQuery2 : int
    {
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        Texture3D = ((int)0x806F)        ,
        Samples = ((int)0x80A9)        ,
        InternalformatSupported = ((int)0x826F)        ,
        InternalformatPreferred = ((int)0x8270)        ,
        InternalformatRedSize = ((int)0x8271)        ,
        InternalformatGreenSize = ((int)0x8272)        ,
        InternalformatBlueSize = ((int)0x8273)        ,
        InternalformatAlphaSize = ((int)0x8274)        ,
        InternalformatDepthSize = ((int)0x8275)        ,
        InternalformatStencilSize = ((int)0x8276)        ,
        InternalformatSharedSize = ((int)0x8277)        ,
        InternalformatRedType = ((int)0x8278)        ,
        InternalformatGreenType = ((int)0x8279)        ,
        InternalformatBlueType = ((int)0x827A)        ,
        InternalformatAlphaType = ((int)0x827B)        ,
        InternalformatDepthType = ((int)0x827C)        ,
        InternalformatStencilType = ((int)0x827D)        ,
        MaxWidth = ((int)0x827E)        ,
        MaxHeight = ((int)0x827F)        ,
        MaxDepth = ((int)0x8280)        ,
        MaxLayers = ((int)0x8281)        ,
        MaxCombinedDimensions = ((int)0x8282)        ,
        ColorComponents = ((int)0x8283)        ,
        DepthComponents = ((int)0x8284)        ,
        StencilComponents = ((int)0x8285)        ,
        ColorRenderable = ((int)0x8286)        ,
        DepthRenderable = ((int)0x8287)        ,
        StencilRenderable = ((int)0x8288)        ,
        FramebufferRenderable = ((int)0x8289)        ,
        FramebufferRenderableLayered = ((int)0x828A)        ,
        FramebufferBlend = ((int)0x828B)        ,
        ReadPixels = ((int)0x828C)        ,
        ReadPixelsFormat = ((int)0x828D)        ,
        ReadPixelsType = ((int)0x828E)        ,
        TextureImageFormat = ((int)0x828F)        ,
        TextureImageType = ((int)0x8290)        ,
        GetTextureImageFormat = ((int)0x8291)        ,
        GetTextureImageType = ((int)0x8292)        ,
        Mipmap = ((int)0x8293)        ,
        ManualGenerateMipmap = ((int)0x8294)        ,
        AutoGenerateMipmap = ((int)0x8295)        ,
        ColorEncoding = ((int)0x8296)        ,
        SrgbRead = ((int)0x8297)        ,
        SrgbWrite = ((int)0x8298)        ,
        SrgbDecodeArb = ((int)0x8299)        ,
        Filter = ((int)0x829A)        ,
        VertexTexture = ((int)0x829B)        ,
        TessControlTexture = ((int)0x829C)        ,
        TessEvaluationTexture = ((int)0x829D)        ,
        GeometryTexture = ((int)0x829E)        ,
        FragmentTexture = ((int)0x829F)        ,
        ComputeTexture = ((int)0x82A0)        ,
        TextureShadow = ((int)0x82A1)        ,
        TextureGather = ((int)0x82A2)        ,
        TextureGatherShadow = ((int)0x82A3)        ,
        ShaderImageLoad = ((int)0x82A4)        ,
        ShaderImageStore = ((int)0x82A5)        ,
        ShaderImageAtomic = ((int)0x82A6)        ,
        ImageTexelSize = ((int)0x82A7)        ,
        ImageCompatibilityClass = ((int)0x82A8)        ,
        ImagePixelFormat = ((int)0x82A9)        ,
        ImagePixelType = ((int)0x82AA)        ,
        SimultaneousTextureAndDepthTest = ((int)0x82AC)        ,
        SimultaneousTextureAndStencilTest = ((int)0x82AD)        ,
        SimultaneousTextureAndDepthWrite = ((int)0x82AE)        ,
        SimultaneousTextureAndStencilWrite = ((int)0x82AF)        ,
        TextureCompressedBlockWidth = ((int)0x82B1)        ,
        TextureCompressedBlockHeight = ((int)0x82B2)        ,
        TextureCompressedBlockSize = ((int)0x82B3)        ,
        ClearBuffer = ((int)0x82B4)        ,
        TextureView = ((int)0x82B5)        ,
        ViewCompatibilityClass = ((int)0x82B6)        ,
        FullSupport = ((int)0x82B7)        ,
        CaveatSupport = ((int)0x82B8)        ,
        ImageClass4X32 = ((int)0x82B9)        ,
        ImageClass2X32 = ((int)0x82BA)        ,
        ImageClass1X32 = ((int)0x82BB)        ,
        ImageClass4X16 = ((int)0x82BC)        ,
        ImageClass2X16 = ((int)0x82BD)        ,
        ImageClass1X16 = ((int)0x82BE)        ,
        ImageClass4X8 = ((int)0x82BF)        ,
        ImageClass2X8 = ((int)0x82C0)        ,
        ImageClass1X8 = ((int)0x82C1)        ,
        ImageClass111110 = ((int)0x82C2)        ,
        ImageClass1010102 = ((int)0x82C3)        ,
        ViewClass128Bits = ((int)0x82C4)        ,
        ViewClass96Bits = ((int)0x82C5)        ,
        ViewClass64Bits = ((int)0x82C6)        ,
        ViewClass48Bits = ((int)0x82C7)        ,
        ViewClass32Bits = ((int)0x82C8)        ,
        ViewClass24Bits = ((int)0x82C9)        ,
        ViewClass16Bits = ((int)0x82CA)        ,
        ViewClass8Bits = ((int)0x82CB)        ,
        ViewClassS3tcDxt1Rgb = ((int)0x82CC)        ,
        ViewClassS3tcDxt1Rgba = ((int)0x82CD)        ,
        ViewClassS3tcDxt3Rgba = ((int)0x82CE)        ,
        ViewClassS3tcDxt5Rgba = ((int)0x82CF)        ,
        ViewClassRgtc1Red = ((int)0x82D0)        ,
        ViewClassRgtc2Rg = ((int)0x82D1)        ,
        ViewClassBptcUnorm = ((int)0x82D2)        ,
        ViewClassBptcFloat = ((int)0x82D3)        ,
        TextureRectangle = ((int)0x84F5)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureCompressed = ((int)0x86A1)        ,
        Texture1DArray = ((int)0x8C18)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        Renderbuffer = ((int)0x8D41)        ,
        TextureCubeMapArray = ((int)0x9009)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        NumSampleCounts = ((int)0x9380)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbInvalidateSubdata : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbMapBufferAlignment : int
    {
        MinMapBufferAlignment = ((int)0x90BC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbMapBufferRange : int
    {
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbMultiBind : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbMultiDrawIndirect : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbOcclusionQuery2 : int
    {
        AnySamplesPassed = ((int)0x8C2F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbProgramInterfaceQuery : int
    {
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
        AtomicCounterBuffer = ((int)0x92C0)        ,
        Uniform = ((int)0x92E1)        ,
        UniformBlock = ((int)0x92E2)        ,
        ProgramInput = ((int)0x92E3)        ,
        ProgramOutput = ((int)0x92E4)        ,
        BufferVariable = ((int)0x92E5)        ,
        ShaderStorageBlock = ((int)0x92E6)        ,
        IsPerPatch = ((int)0x92E7)        ,
        VertexSubroutine = ((int)0x92E8)        ,
        TessControlSubroutine = ((int)0x92E9)        ,
        TessEvaluationSubroutine = ((int)0x92EA)        ,
        GeometrySubroutine = ((int)0x92EB)        ,
        FragmentSubroutine = ((int)0x92EC)        ,
        ComputeSubroutine = ((int)0x92ED)        ,
        VertexSubroutineUniform = ((int)0x92EE)        ,
        TessControlSubroutineUniform = ((int)0x92EF)        ,
        TessEvaluationSubroutineUniform = ((int)0x92F0)        ,
        GeometrySubroutineUniform = ((int)0x92F1)        ,
        FragmentSubroutineUniform = ((int)0x92F2)        ,
        ComputeSubroutineUniform = ((int)0x92F3)        ,
        TransformFeedbackVarying = ((int)0x92F4)        ,
        ActiveResources = ((int)0x92F5)        ,
        MaxNameLength = ((int)0x92F6)        ,
        MaxNumActiveVariables = ((int)0x92F7)        ,
        MaxNumCompatibleSubroutines = ((int)0x92F8)        ,
        NameLength = ((int)0x92F9)        ,
        Type = ((int)0x92FA)        ,
        ArraySize = ((int)0x92FB)        ,
        Offset = ((int)0x92FC)        ,
        BlockIndex = ((int)0x92FD)        ,
        ArrayStride = ((int)0x92FE)        ,
        MatrixStride = ((int)0x92FF)        ,
        IsRowMajor = ((int)0x9300)        ,
        AtomicCounterBufferIndex = ((int)0x9301)        ,
        BufferBinding = ((int)0x9302)        ,
        BufferDataSize = ((int)0x9303)        ,
        NumActiveVariables = ((int)0x9304)        ,
        ActiveVariables = ((int)0x9305)        ,
        ReferencedByVertexShader = ((int)0x9306)        ,
        ReferencedByTessControlShader = ((int)0x9307)        ,
        ReferencedByTessEvaluationShader = ((int)0x9308)        ,
        ReferencedByGeometryShader = ((int)0x9309)        ,
        ReferencedByFragmentShader = ((int)0x930A)        ,
        ReferencedByComputeShader = ((int)0x930B)        ,
        TopLevelArraySize = ((int)0x930C)        ,
        TopLevelArrayStride = ((int)0x930D)        ,
        Location = ((int)0x930E)        ,
        LocationIndex = ((int)0x930F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbProvokingVertex : int
    {
        QuadsFollowProvokingVertexConvention = ((int)0x8E4C)        ,
        FirstVertexConvention = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbQueryBufferObject : int
    {
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        QueryBuffer = ((int)0x9192)        ,
        QueryBufferBinding = ((int)0x9193)        ,
        QueryResultNoWait = ((int)0x9194)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbRobustBufferAccessBehavior : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbRobustness : int
    {
        NoError = ((int)0)        ,
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
        LoseContextOnResetArb = ((int)0x8252)        ,
        GuiltyContextResetArb = ((int)0x8253)        ,
        InnocentContextResetArb = ((int)0x8254)        ,
        UnknownContextResetArb = ((int)0x8255)        ,
        ResetNotificationStrategyArb = ((int)0x8256)        ,
        NoResetNotificationArb = ((int)0x8261)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbRobustnessIsolation : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSamplerObjects : int
    {
        SamplerBinding = ((int)0x8919)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSampleShading : int
    {
        SampleShadingArb = ((int)0x8C36)        ,
        MinSampleShadingValueArb = ((int)0x8C37)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSeamlessCubeMap : int
    {
        TextureCubeMapSeamless = ((int)0x884F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSeamlessCubemapPerTexture : int
    {
        TextureCubeMapSeamless = ((int)0x884F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSeparateShaderObjects : int
    {
        VertexShaderBit = ((int)0x00000001)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        TessControlShaderBit = ((int)0x00000008)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ProgramSeparable = ((int)0x8258)        ,
        ActiveProgram = ((int)0x8259)        ,
        ProgramPipelineBinding = ((int)0x825A)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderAtomicCounters : int
    {
        AtomicCounterBuffer = ((int)0x92C0)        ,
        AtomicCounterBufferBinding = ((int)0x92C1)        ,
        AtomicCounterBufferStart = ((int)0x92C2)        ,
        AtomicCounterBufferSize = ((int)0x92C3)        ,
        AtomicCounterBufferDataSize = ((int)0x92C4)        ,
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5)        ,
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6)        ,
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7)        ,
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8)        ,
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9)        ,
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA)        ,
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB)        ,
        MaxVertexAtomicCounterBuffers = ((int)0x92CC)        ,
        MaxTessControlAtomicCounterBuffers = ((int)0x92CD)        ,
        MaxTessEvaluationAtomicCounterBuffers = ((int)0x92CE)        ,
        MaxGeometryAtomicCounterBuffers = ((int)0x92CF)        ,
        MaxFragmentAtomicCounterBuffers = ((int)0x92D0)        ,
        MaxCombinedAtomicCounterBuffers = ((int)0x92D1)        ,
        MaxVertexAtomicCounters = ((int)0x92D2)        ,
        MaxTessControlAtomicCounters = ((int)0x92D3)        ,
        MaxTessEvaluationAtomicCounters = ((int)0x92D4)        ,
        MaxGeometryAtomicCounters = ((int)0x92D5)        ,
        MaxFragmentAtomicCounters = ((int)0x92D6)        ,
        MaxCombinedAtomicCounters = ((int)0x92D7)        ,
        MaxAtomicCounterBufferSize = ((int)0x92D8)        ,
        ActiveAtomicCounterBuffers = ((int)0x92D9)        ,
        UniformAtomicCounterBufferIndex = ((int)0x92DA)        ,
        UnsignedIntAtomicCounter = ((int)0x92DB)        ,
        MaxAtomicCounterBufferBindings = ((int)0x92DC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderBitEncoding : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderDrawParameters : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderGroupVote : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderImageLoadStore : int
    {
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        UniformBarrierBit = ((int)0x00000004)        ,
        TextureFetchBarrierBit = ((int)0x00000008)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        MaxImageUnits = ((int)0x8F38)        ,
        MaxCombinedImageUnitsAndFragmentOutputs = ((int)0x8F39)        ,
        ImageBindingName = ((int)0x8F3A)        ,
        ImageBindingLevel = ((int)0x8F3B)        ,
        ImageBindingLayered = ((int)0x8F3C)        ,
        ImageBindingLayer = ((int)0x8F3D)        ,
        ImageBindingAccess = ((int)0x8F3E)        ,
        Image1D = ((int)0x904C)        ,
        Image2D = ((int)0x904D)        ,
        Image3D = ((int)0x904E)        ,
        Image2DRect = ((int)0x904F)        ,
        ImageCube = ((int)0x9050)        ,
        ImageBuffer = ((int)0x9051)        ,
        Image1DArray = ((int)0x9052)        ,
        Image2DArray = ((int)0x9053)        ,
        ImageCubeMapArray = ((int)0x9054)        ,
        Image2DMultisample = ((int)0x9055)        ,
        Image2DMultisampleArray = ((int)0x9056)        ,
        IntImage1D = ((int)0x9057)        ,
        IntImage2D = ((int)0x9058)        ,
        IntImage3D = ((int)0x9059)        ,
        IntImage2DRect = ((int)0x905A)        ,
        IntImageCube = ((int)0x905B)        ,
        IntImageBuffer = ((int)0x905C)        ,
        IntImage1DArray = ((int)0x905D)        ,
        IntImage2DArray = ((int)0x905E)        ,
        IntImageCubeMapArray = ((int)0x905F)        ,
        IntImage2DMultisample = ((int)0x9060)        ,
        IntImage2DMultisampleArray = ((int)0x9061)        ,
        UnsignedIntImage1D = ((int)0x9062)        ,
        UnsignedIntImage2D = ((int)0x9063)        ,
        UnsignedIntImage3D = ((int)0x9064)        ,
        UnsignedIntImage2DRect = ((int)0x9065)        ,
        UnsignedIntImageCube = ((int)0x9066)        ,
        UnsignedIntImageBuffer = ((int)0x9067)        ,
        UnsignedIntImage1DArray = ((int)0x9068)        ,
        UnsignedIntImage2DArray = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArray = ((int)0x906A)        ,
        UnsignedIntImage2DMultisample = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArray = ((int)0x906C)        ,
        MaxImageSamples = ((int)0x906D)        ,
        ImageBindingFormat = ((int)0x906E)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        ImageFormatCompatibilityBySize = ((int)0x90C8)        ,
        ImageFormatCompatibilityByClass = ((int)0x90C9)        ,
        MaxVertexImageUniforms = ((int)0x90CA)        ,
        MaxTessControlImageUniforms = ((int)0x90CB)        ,
        MaxTessEvaluationImageUniforms = ((int)0x90CC)        ,
        MaxGeometryImageUniforms = ((int)0x90CD)        ,
        MaxFragmentImageUniforms = ((int)0x90CE)        ,
        MaxCombinedImageUniforms = ((int)0x90CF)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderImageSize : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderPrecision : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderStencilExport : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderStorageBufferObject : int
    {
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        MaxCombinedImageUnitsAndFragmentOutputs = ((int)0x8F39)        ,
        MaxCombinedShaderOutputResources = ((int)0x8F39)        ,
        ShaderStorageBuffer = ((int)0x90D2)        ,
        ShaderStorageBufferBinding = ((int)0x90D3)        ,
        ShaderStorageBufferStart = ((int)0x90D4)        ,
        ShaderStorageBufferSize = ((int)0x90D5)        ,
        MaxVertexShaderStorageBlocks = ((int)0x90D6)        ,
        MaxGeometryShaderStorageBlocks = ((int)0x90D7)        ,
        MaxTessControlShaderStorageBlocks = ((int)0x90D8)        ,
        MaxTessEvaluationShaderStorageBlocks = ((int)0x90D9)        ,
        MaxFragmentShaderStorageBlocks = ((int)0x90DA)        ,
        MaxComputeShaderStorageBlocks = ((int)0x90DB)        ,
        MaxCombinedShaderStorageBlocks = ((int)0x90DC)        ,
        MaxShaderStorageBufferBindings = ((int)0x90DD)        ,
        MaxShaderStorageBlockSize = ((int)0x90DE)        ,
        ShaderStorageBufferOffsetAlignment = ((int)0x90DF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShaderSubroutine : int
    {
        UniformSize = ((int)0x8A38)        ,
        UniformNameLength = ((int)0x8A39)        ,
        ActiveSubroutines = ((int)0x8DE5)        ,
        ActiveSubroutineUniforms = ((int)0x8DE6)        ,
        MaxSubroutines = ((int)0x8DE7)        ,
        MaxSubroutineUniformLocations = ((int)0x8DE8)        ,
        ActiveSubroutineUniformLocations = ((int)0x8E47)        ,
        ActiveSubroutineMaxLength = ((int)0x8E48)        ,
        ActiveSubroutineUniformMaxLength = ((int)0x8E49)        ,
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadingLanguage420pack : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadingLanguageInclude : int
    {
        ShaderIncludeArb = ((int)0x8DAE)        ,
        NamedStringLengthArb = ((int)0x8DE9)        ,
        NamedStringTypeArb = ((int)0x8DEA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadingLanguagePacking : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSparseTexture : int
    {
        VirtualPageSizeXArb = ((int)0x9195)        ,
        VirtualPageSizeYArb = ((int)0x9196)        ,
        VirtualPageSizeZArb = ((int)0x9197)        ,
        MaxSparseTextureSizeArb = ((int)0x9198)        ,
        MaxSparse3DTextureSizeArb = ((int)0x9199)        ,
        MaxSparseArrayTextureLayersArb = ((int)0x919A)        ,
        MinSparseLevelArb = ((int)0x919B)        ,
        TextureSparseArb = ((int)0x91A6)        ,
        VirtualPageSizeIndexArb = ((int)0x91A7)        ,
        NumVirtualPageSizesArb = ((int)0x91A8)        ,
        SparseTextureFullArrayCubeMipmapsArb = ((int)0x91A9)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbStencilTexturing : int
    {
        DepthStencilTextureMode = ((int)0x90EA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbSync : int
    {
        SyncFlushCommandsBit = ((int)0x00000001)        ,
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
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTessellationShader : int
    {
        Triangles = ((int)0x0004)        ,
        Patches = ((int)0x000E)        ,
        Equal = ((int)0x0202)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        UniformBlockReferencedByTessControlShader = ((int)0x84F0)        ,
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)        ,
        MaxTessControlInputComponents = ((int)0x886C)        ,
        MaxTessEvaluationInputComponents = ((int)0x886D)        ,
        MaxCombinedTessControlUniformComponents = ((int)0x8E1E)        ,
        MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)        ,
        PatchVertices = ((int)0x8E72)        ,
        PatchDefaultInnerLevel = ((int)0x8E73)        ,
        PatchDefaultOuterLevel = ((int)0x8E74)        ,
        TessControlOutputVertices = ((int)0x8E75)        ,
        TessGenMode = ((int)0x8E76)        ,
        TessGenSpacing = ((int)0x8E77)        ,
        TessGenVertexOrder = ((int)0x8E78)        ,
        TessGenPointMode = ((int)0x8E79)        ,
        Isolines = ((int)0x8E7A)        ,
        FractionalOdd = ((int)0x8E7B)        ,
        FractionalEven = ((int)0x8E7C)        ,
        MaxPatchVertices = ((int)0x8E7D)        ,
        MaxTessGenLevel = ((int)0x8E7E)        ,
        MaxTessControlUniformComponents = ((int)0x8E7F)        ,
        MaxTessEvaluationUniformComponents = ((int)0x8E80)        ,
        MaxTessControlTextureImageUnits = ((int)0x8E81)        ,
        MaxTessEvaluationTextureImageUnits = ((int)0x8E82)        ,
        MaxTessControlOutputComponents = ((int)0x8E83)        ,
        MaxTessPatchComponents = ((int)0x8E84)        ,
        MaxTessControlTotalOutputComponents = ((int)0x8E85)        ,
        MaxTessEvaluationOutputComponents = ((int)0x8E86)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        MaxTessControlUniformBlocks = ((int)0x8E89)        ,
        MaxTessEvaluationUniformBlocks = ((int)0x8E8A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureBufferObjectRgb32 : int
    {
        Rgb32f = ((int)0x8815)        ,
        Rgb32ui = ((int)0x8D71)        ,
        Rgb32i = ((int)0x8D83)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureBufferRange : int
    {
        TextureBufferOffset = ((int)0x919D)        ,
        TextureBufferSize = ((int)0x919E)        ,
        TextureBufferOffsetAlignment = ((int)0x919F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureCompressionBptc : int
    {
        CompressedRgbaBptcUnormArb = ((int)0x8E8C)        ,
        CompressedSrgbAlphaBptcUnormArb = ((int)0x8E8D)        ,
        CompressedRgbBptcSignedFloatArb = ((int)0x8E8E)        ,
        CompressedRgbBptcUnsignedFloatArb = ((int)0x8E8F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureCompressionRgtc : int
    {
        CompressedRedRgtc1 = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1 = ((int)0x8DBC)        ,
        CompressedRgRgtc2 = ((int)0x8DBD)        ,
        CompressedSignedRgRgtc2 = ((int)0x8DBE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureCubeMapArray : int
    {
        TextureCubeMapArrayArb = ((int)0x9009)        ,
        TextureBindingCubeMapArrayArb = ((int)0x900A)        ,
        ProxyTextureCubeMapArrayArb = ((int)0x900B)        ,
        SamplerCubeMapArrayArb = ((int)0x900C)        ,
        SamplerCubeMapArrayShadowArb = ((int)0x900D)        ,
        IntSamplerCubeMapArrayArb = ((int)0x900E)        ,
        UnsignedIntSamplerCubeMapArrayArb = ((int)0x900F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureGather : int
    {
        MinProgramTextureGatherOffsetArb = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffsetArb = ((int)0x8E5F)        ,
        MaxProgramTextureGatherComponentsArb = ((int)0x8F9F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureMirrorClampToEdge : int
    {
        MirrorClampToEdge = ((int)0x8743)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureMultisample : int
    {
        SamplePosition = ((int)0x8E50)        ,
        SampleMask = ((int)0x8E51)        ,
        SampleMaskValue = ((int)0x8E52)        ,
        MaxSampleMaskWords = ((int)0x8E59)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
        TextureBinding2DMultisample = ((int)0x9104)        ,
        TextureBinding2DMultisampleArray = ((int)0x9105)        ,
        TextureSamples = ((int)0x9106)        ,
        TextureFixedSampleLocations = ((int)0x9107)        ,
        Sampler2DMultisample = ((int)0x9108)        ,
        IntSampler2DMultisample = ((int)0x9109)        ,
        UnsignedIntSampler2DMultisample = ((int)0x910A)        ,
        Sampler2DMultisampleArray = ((int)0x910B)        ,
        IntSampler2DMultisampleArray = ((int)0x910C)        ,
        UnsignedIntSampler2DMultisampleArray = ((int)0x910D)        ,
        MaxColorTextureSamples = ((int)0x910E)        ,
        MaxDepthTextureSamples = ((int)0x910F)        ,
        MaxIntegerSamples = ((int)0x9110)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureQueryLevels : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureQueryLod : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureRg : int
    {
        Rg = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureRgb10A2ui : int
    {
        Rgb10A2ui = ((int)0x906F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureStencil8 : int
    {
        StencilIndex = ((int)0x1901)        ,
        StencilIndex8 = ((int)0x8D48)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureStorage : int
    {
        TextureImmutableFormat = ((int)0x912F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureStorageMultisample : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureSwizzle : int
    {
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureView : int
    {
        TextureViewMinLevel = ((int)0x82DB)        ,
        TextureViewNumLevels = ((int)0x82DC)        ,
        TextureViewMinLayer = ((int)0x82DD)        ,
        TextureViewNumLayers = ((int)0x82DE)        ,
        TextureImmutableLevels = ((int)0x82DF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTimerQuery : int
    {
        TimeElapsed = ((int)0x88BF)        ,
        Timestamp = ((int)0x8E28)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTransformFeedback2 : int
    {
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackBufferPaused = ((int)0x8E23)        ,
        TransformFeedbackPaused = ((int)0x8E23)        ,
        TransformFeedbackActive = ((int)0x8E24)        ,
        TransformFeedbackBufferActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTransformFeedback3 : int
    {
        MaxTransformFeedbackBuffers = ((int)0x8E70)        ,
        MaxVertexStreams = ((int)0x8E71)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTransformFeedbackInstanced : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbUniformBufferObject : int
    {
        UniformBuffer = ((int)0x8A11)        ,
        UniformBufferBinding = ((int)0x8A28)        ,
        UniformBufferStart = ((int)0x8A29)        ,
        UniformBufferSize = ((int)0x8A2A)        ,
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        MaxGeometryUniformBlocks = ((int)0x8A2C)        ,
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        MaxUniformBlockSize = ((int)0x8A30)        ,
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        MaxCombinedGeometryUniformComponents = ((int)0x8A32)        ,
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
        UniformBlockReferencedByGeometryShader = ((int)0x8A45)        ,
        UniformBlockReferencedByFragmentShader = ((int)0x8A46)        ,
        InvalidIndex = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexArrayBgra : int
    {
        Bgra = ((int)0x80E1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexArrayObject : int
    {
        VertexArrayBinding = ((int)0x85B5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexAttrib64bit : int
    {
        Rgb32i = ((int)0x8D83)        ,
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexAttribBinding : int
    {
        VertexAttribBinding = ((int)0x82D4)        ,
        VertexAttribRelativeOffset = ((int)0x82D5)        ,
        VertexBindingDivisor = ((int)0x82D6)        ,
        VertexBindingOffset = ((int)0x82D7)        ,
        VertexBindingStride = ((int)0x82D8)        ,
        MaxVertexAttribRelativeOffset = ((int)0x82D9)        ,
        MaxVertexAttribBindings = ((int)0x82DA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexType10f11f11fRev : int
    {
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbVertexType2101010Rev : int
    {
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbViewportArray : int
    {
        DepthRange = ((int)0x0B70)        ,
        Viewport = ((int)0x0BA2)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        MaxViewports = ((int)0x825B)        ,
        ViewportSubpixelBits = ((int)0x825C)        ,
        ViewportBoundsRange = ((int)0x825D)        ,
        LayerProvokingVertex = ((int)0x825E)        ,
        ViewportIndexProvokingVertex = ((int)0x825F)        ,
        UndefinedVertex = ((int)0x8260)        ,
        FirstVertexConvention = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArrayCap : int
    {
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        FogCoordArray = ((int)0x8457)        ,
        SecondaryColorArray = ((int)0x845E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AssemblyProgramFormatArb : int
    {
        ProgramFormatAsciiArb = ((int)0x8875)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AssemblyProgramParameterArb : int
    {
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparable = ((int)0x8258)        ,
        ProgramLength = ((int)0x8627)        ,
        ProgramBinding = ((int)0x8677)        ,
        ProgramAluInstructionsArb = ((int)0x8805)        ,
        ProgramTexInstructionsArb = ((int)0x8806)        ,
        ProgramTexIndirectionsArb = ((int)0x8807)        ,
        ProgramNativeAluInstructionsArb = ((int)0x8808)        ,
        ProgramNativeTexInstructionsArb = ((int)0x8809)        ,
        ProgramNativeTexIndirectionsArb = ((int)0x880A)        ,
        MaxProgramAluInstructionsArb = ((int)0x880B)        ,
        MaxProgramTexInstructionsArb = ((int)0x880C)        ,
        MaxProgramTexIndirectionsArb = ((int)0x880D)        ,
        MaxProgramNativeAluInstructionsArb = ((int)0x880E)        ,
        MaxProgramNativeTexInstructionsArb = ((int)0x880F)        ,
        MaxProgramNativeTexIndirectionsArb = ((int)0x8810)        ,
        ProgramFormat = ((int)0x8876)        ,
        ProgramInstruction = ((int)0x88A0)        ,
        MaxProgramInstructions = ((int)0x88A1)        ,
        ProgramNativeInstructions = ((int)0x88A2)        ,
        MaxProgramNativeInstructions = ((int)0x88A3)        ,
        ProgramTemporaries = ((int)0x88A4)        ,
        MaxProgramTemporaries = ((int)0x88A5)        ,
        ProgramNativeTemporaries = ((int)0x88A6)        ,
        MaxProgramNativeTemporaries = ((int)0x88A7)        ,
        ProgramParameters = ((int)0x88A8)        ,
        MaxProgramParameters = ((int)0x88A9)        ,
        ProgramNativeParameters = ((int)0x88AA)        ,
        MaxProgramNativeParameters = ((int)0x88AB)        ,
        ProgramAttribs = ((int)0x88AC)        ,
        MaxProgramAttribs = ((int)0x88AD)        ,
        ProgramNativeAttribs = ((int)0x88AE)        ,
        MaxProgramNativeAttribs = ((int)0x88AF)        ,
        ProgramAddressRegisters = ((int)0x88B0)        ,
        MaxProgramAddressRegisters = ((int)0x88B1)        ,
        ProgramNativeAddressRegisters = ((int)0x88B2)        ,
        MaxProgramNativeAddressRegisters = ((int)0x88B3)        ,
        MaxProgramLocalParameters = ((int)0x88B4)        ,
        MaxProgramEnvParameters = ((int)0x88B5)        ,
        ProgramUnderNativeLimits = ((int)0x88B6)        ,
        GeometryVerticesOut = ((int)0x8916)        ,
        GeometryInputType = ((int)0x8917)        ,
        GeometryOutputType = ((int)0x8918)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AssemblyProgramStringParameterArb : int
    {
        ProgramString = ((int)0x8628)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AssemblyProgramTargetArb : int
    {
        VertexProgram = ((int)0x8620)        ,
        FragmentProgram = ((int)0x8804)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveAtomicCounterBuffer
    /// </summary>
    public enum AtomicCounterBufferParameter : int
    {
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED)        ,
        AtomicCounterBufferBinding = ((int)0x92C1)        ,
        AtomicCounterBufferDataSize = ((int)0x92C4)        ,
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5)        ,
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6)        ,
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7)        ,
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8)        ,
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9)        ,
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA)        ,
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum AttribMask : int
    {
        DepthBufferBit = ((int)0x00000100)        ,
        StencilBufferBit = ((int)0x00000400)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        MultisampleBit = ((int)0x20000000)        ,
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleBitExt = ((int)0x20000000)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BeginFeedbackMode : int
    {
        Points = ((int)0x0000)        ,
        Lines = ((int)0x0001)        ,
        Triangles = ((int)0x0004)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BeginMode : int
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
        Patches = ((int)0x000E)        ,
        LinesAdjacency = ((int)0xA)        ,
        LineStripAdjacency = ((int)0xB)        ,
        TrianglesAdjacency = ((int)0xC)        ,
        TriangleStripAdjacency = ((int)0xD)        ,
    }

    /// <summary>
    /// Used in GL.GetProgramBinary, GL.ProgramBinary and 1 other function
    /// </summary>
    public enum BinaryFormat : int
    {
    }

    /// <summary>
    /// Used in GL.Arb.BlendEquation, GL.BlendEquation and 1 other function
    /// </summary>
    public enum BlendEquationMode : int
    {
        FuncAdd = ((int)0x8006)        ,
        Min = ((int)0x8007)        ,
        Max = ((int)0x8008)        ,
        FuncSubtract = ((int)0x800A)        ,
        FuncReverseSubtract = ((int)0x800B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlendEquationModeExt : int
    {
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
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        Src1Alpha = ((int)0x8589)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactorSrc : int
    {
        Zero = ((int)0)        ,
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        ConstantColor = ((int)0x8001)        ,
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        Src1Alpha = ((int)0x8589)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.BlitFramebuffer
    /// </summary>
    public enum BlitFramebufferFilter : int
    {
        Nearest = ((int)0x2600)        ,
        Linear = ((int)0x2601)        ,
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
    /// Used in GL.MapBuffer
    /// </summary>
    public enum BufferAccess : int
    {
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferAccessArb : int
    {
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
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
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferParameterApple : int
    {
    }

    /// <summary>
    /// Used in GL.GetBufferParameter
    /// </summary>
    public enum BufferParameterName : int
    {
        BufferImmutableStorage = ((int)0x821F)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        BufferAccess = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferAccessFlags = ((int)0x911F)        ,
        BufferMapLength = ((int)0x9120)        ,
        BufferMapOffset = ((int)0x9121)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferParameterNameArb : int
    {
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        BufferAccess = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
    }

    /// <summary>
    /// Used in GL.GetBufferPointer
    /// </summary>
    public enum BufferPointer : int
    {
        BufferMapPointer = ((int)0x88BD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferPointerNameArb : int
    {
        BufferMapPointer = ((int)0x88BD)        ,
    }

    /// <summary>
    /// Used in GL.BindBufferBase, GL.BindBufferRange and 2 other functions
    /// </summary>
    public enum BufferRangeTarget : int
    {
        UniformBuffer = ((int)0x8A11)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        ShaderStorageBuffer = ((int)0x90D2)        ,
        AtomicCounterBuffer = ((int)0x92C0)        ,
    }

    /// <summary>
    /// Used in GL.BufferStorage
    /// </summary>
    public enum BufferStorageFlags : int
    {
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        ClientStorageBit = ((int)0x0200)        ,
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
        TextureBuffer = ((int)0x8C2A)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        ShaderStorageBuffer = ((int)0x90D2)        ,
        DispatchIndirectBuffer = ((int)0x90EE)        ,
        QueryBuffer = ((int)0x9192)        ,
        AtomicCounterBuffer = ((int)0x92C0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferTargetArb : int
    {
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        TextureBuffer = ((int)0x8C2A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferUsageArb : int
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
    /// Used in GL.ClampColor
    /// </summary>
    public enum ClampColorMode : int
    {
        False = ((int)0)        ,
        FixedOnly = ((int)0x891D)        ,
        True = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.ClampColor
    /// </summary>
    public enum ClampColorTarget : int
    {
        ClampVertexColor = ((int)0x891A)        ,
        ClampFragmentColor = ((int)0x891B)        ,
        ClampReadColor = ((int)0x891C)        ,
    }

    /// <summary>
    /// Used in GL.ClearBuffer
    /// </summary>
    public enum ClearBuffer : int
    {
        Color = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
    }

    /// <summary>
    /// Used in GL.ClearBuffer
    /// </summary>
    public enum ClearBufferCombined : int
    {
        DepthStencil = ((int)0x84F9)        ,
    }

    /// <summary>
    /// Used in GL.BlitFramebuffer, GL.Clear
    /// </summary>
    [Flags]
    public enum ClearBufferMask : int
    {
        None = ((int)0)        ,
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
    }

    /// <summary>
    /// Used in GL.ClientWaitSync
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ClipPlaneName : int
    {
        ClipDistance0 = ((int)0x3000)        ,
        ClipDistance1 = ((int)0x3001)        ,
        ClipDistance2 = ((int)0x3002)        ,
        ClipDistance3 = ((int)0x3003)        ,
        ClipDistance4 = ((int)0x3004)        ,
        ClipDistance5 = ((int)0x3005)        ,
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
        HalfFloat = ((int)0x140B)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Used in GL.ColorTableParameter
    /// </summary>
    public enum ColorTableParameterPName : int
    {
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
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
    /// Used in GL.ColorSubTable, GL.ColorTable and 5 other functions
    /// </summary>
    public enum ColorTableTarget : int
    {
        ColorTable = ((int)0x80D0)        ,
        PostConvolutionColorTable = ((int)0x80D1)        ,
        PostColorMatrixColorTable = ((int)0x80D2)        ,
        ProxyColorTable = ((int)0x80D3)        ,
        ProxyPostConvolutionColorTable = ((int)0x80D4)        ,
        ProxyPostColorMatrixColorTable = ((int)0x80D5)        ,
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
    /// Used in GL.BeginConditionalRender
    /// </summary>
    public enum ConditionalRenderType : int
    {
        QueryWait = ((int)0x8E13)        ,
        QueryNoWait = ((int)0x8E14)        ,
        QueryByRegionWait = ((int)0x8E15)        ,
        QueryByRegionNoWait = ((int)0x8E16)        ,
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
    /// Used in GL.ConvolutionParameter
    /// </summary>
    public enum ConvolutionParameter : int
    {
        ConvolutionBorderMode = ((int)0x8013)        ,
        ConvolutionFilterScale = ((int)0x8014)        ,
        ConvolutionFilterBias = ((int)0x8015)        ,
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
    public enum ConvolutionParameterValue : int
    {
        Reduce = ((int)0x8016)        ,
        ConstantBorder = ((int)0x8151)        ,
        ReplicateBorder = ((int)0x8153)        ,
    }

    /// <summary>
    /// Used in GL.ConvolutionFilter1D, GL.ConvolutionFilter2D and 5 other functions
    /// </summary>
    public enum ConvolutionTarget : int
    {
        Convolution1D = ((int)0x8010)        ,
        Convolution2D = ((int)0x8011)        ,
        Separable2D = ((int)0x8012)        ,
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
    /// Used in GL.DebugMessageInsert, GL.GetDebugMessageLog
    /// </summary>
    public enum DebugSeverity : int
    {
        DebugSeverityNotification = ((int)0x826B)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageControl
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
    /// Used in GL.GetDebugMessageLog
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
    /// Used in GL.DebugMessageControl
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
    /// Used in GL.DebugMessageInsert, GL.PushDebugGroup
    /// </summary>
    public enum DebugSourceExternal : int
    {
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
    }

    /// <summary>
    /// Used in GL.DebugMessageInsert, GL.GetDebugMessageLog
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
    /// Used in GL.DebugMessageControl
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
    /// Used in GL.DrawBuffer
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
    /// Used in GL.DrawBuffers
    /// </summary>
    public enum DrawBuffersEnum : int
    {
        None = ((int)0)        ,
        FrontLeft = ((int)0x0400)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
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
    /// Used in GL.DrawElements, GL.DrawElementsBaseVertex and 8 other functions
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
        LineSmooth = ((int)0x0B20)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        CullFace = ((int)0x0B44)        ,
        DepthTest = ((int)0x0B71)        ,
        StencilTest = ((int)0x0B90)        ,
        Dither = ((int)0x0BD0)        ,
        Blend = ((int)0x0BE2)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        ScissorTest = ((int)0x0C11)        ,
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
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
        Convolution1D = ((int)0x8010)        ,
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2D = ((int)0x8011)        ,
        Convolution2DExt = ((int)0x8011)        ,
        Separable2D = ((int)0x8012)        ,
        Separable2DExt = ((int)0x8012)        ,
        Histogram = ((int)0x8024)        ,
        HistogramExt = ((int)0x8024)        ,
        MinmaxExt = ((int)0x802E)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        RescaleNormal = ((int)0x803A)        ,
        RescaleNormalExt = ((int)0x803A)        ,
        Texture3DExt = ((int)0x806F)        ,
        InterlaceSgix = ((int)0x8094)        ,
        Multisample = ((int)0x809D)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        TextureColorTableSgi = ((int)0x80BC)        ,
        ColorTable = ((int)0x80D0)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTable = ((int)0x80D1)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTable = ((int)0x80D2)        ,
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
        DebugOutputSynchronous = ((int)0x8242)        ,
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
        FogCoordArray = ((int)0x8457)        ,
        ColorSum = ((int)0x8458)        ,
        SecondaryColorArray = ((int)0x845E)        ,
        TextureRectangle = ((int)0x84F5)        ,
        TextureCubeMap = ((int)0x8513)        ,
        ProgramPointSize = ((int)0x8642)        ,
        VertexProgramPointSize = ((int)0x8642)        ,
        VertexProgramTwoSide = ((int)0x8643)        ,
        DepthClamp = ((int)0x864F)        ,
        TextureCubeMapSeamless = ((int)0x884F)        ,
        PointSprite = ((int)0x8861)        ,
        SampleShading = ((int)0x8C36)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        FramebufferSrgb = ((int)0x8DB9)        ,
        SampleMask = ((int)0x8E51)        ,
        PrimitiveRestart = ((int)0x8F9D)        ,
        DebugOutput = ((int)0x92E0)        ,
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
    public enum FeedBackToken : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FeedbackType : int
    {
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
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogMode : int
    {
        Linear = ((int)0x2601)        ,
        FogFuncSgis = ((int)0x812A)        ,
        FogCoord = ((int)0x8451)        ,
        FragmentDepth = ((int)0x8452)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogParameter : int
    {
        FogOffsetValueSgix = ((int)0x8199)        ,
        FogCoordSrc = ((int)0x8450)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerType : int
    {
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeExt : int
    {
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FogPointerTypeIbm : int
    {
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
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
    /// Used in GL.FramebufferRenderbuffer, GL.FramebufferTexture and 7 other functions
    /// </summary>
    public enum FramebufferAttachment : int
    {
        FrontLeft = ((int)0x0400)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
        Aux0 = ((int)0x0409)        ,
        Aux1 = ((int)0x040A)        ,
        Aux2 = ((int)0x040B)        ,
        Aux3 = ((int)0x040C)        ,
        Color = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        DepthStencilAttachment = ((int)0x821A)        ,
        ColorAttachment0 = ((int)0x8CE0)        ,
        ColorAttachment0Ext = ((int)0x8CE0)        ,
        ColorAttachment1 = ((int)0x8CE1)        ,
        ColorAttachment1Ext = ((int)0x8CE1)        ,
        ColorAttachment2 = ((int)0x8CE2)        ,
        ColorAttachment2Ext = ((int)0x8CE2)        ,
        ColorAttachment3 = ((int)0x8CE3)        ,
        ColorAttachment3Ext = ((int)0x8CE3)        ,
        ColorAttachment4 = ((int)0x8CE4)        ,
        ColorAttachment4Ext = ((int)0x8CE4)        ,
        ColorAttachment5 = ((int)0x8CE5)        ,
        ColorAttachment5Ext = ((int)0x8CE5)        ,
        ColorAttachment6 = ((int)0x8CE6)        ,
        ColorAttachment6Ext = ((int)0x8CE6)        ,
        ColorAttachment7 = ((int)0x8CE7)        ,
        ColorAttachment7Ext = ((int)0x8CE7)        ,
        ColorAttachment8 = ((int)0x8CE8)        ,
        ColorAttachment8Ext = ((int)0x8CE8)        ,
        ColorAttachment9 = ((int)0x8CE9)        ,
        ColorAttachment9Ext = ((int)0x8CE9)        ,
        ColorAttachment10 = ((int)0x8CEA)        ,
        ColorAttachment10Ext = ((int)0x8CEA)        ,
        ColorAttachment11 = ((int)0x8CEB)        ,
        ColorAttachment11Ext = ((int)0x8CEB)        ,
        ColorAttachment12 = ((int)0x8CEC)        ,
        ColorAttachment12Ext = ((int)0x8CEC)        ,
        ColorAttachment13 = ((int)0x8CED)        ,
        ColorAttachment13Ext = ((int)0x8CED)        ,
        ColorAttachment14 = ((int)0x8CEE)        ,
        ColorAttachment14Ext = ((int)0x8CEE)        ,
        ColorAttachment15 = ((int)0x8CEF)        ,
        ColorAttachment15Ext = ((int)0x8CEF)        ,
        DepthAttachment = ((int)0x8D00)        ,
        DepthAttachmentExt = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        StencilAttachmentExt = ((int)0x8D20)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferAttachmentComponentType : int
    {
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Index = ((int)0x8222)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferAttachmentObjectType : int
    {
        None = ((int)0)        ,
        Texture = ((int)0x1702)        ,
        FramebufferDefault = ((int)0x8218)        ,
        Renderbuffer = ((int)0x8D41)        ,
    }

    /// <summary>
    /// Used in GL.FramebufferParameter, GL.GetFramebufferParameter
    /// </summary>
    public enum FramebufferDefaultParameter : int
    {
        FramebufferDefaultWidth = ((int)0x9310)        ,
        FramebufferDefaultHeight = ((int)0x9311)        ,
        FramebufferDefaultLayers = ((int)0x9312)        ,
        FramebufferDefaultSamples = ((int)0x9313)        ,
        FramebufferDefaultFixedSampleLocations = ((int)0x9314)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferErrorCode : int
    {
        FramebufferUndefined = ((int)0x8219)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferCompleteExt = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteAttachmentExt = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensionsExt = ((int)0x8CD9)        ,
        FramebufferIncompleteFormatsExt = ((int)0x8CDA)        ,
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB)        ,
        FramebufferIncompleteDrawBufferExt = ((int)0x8CDB)        ,
        FramebufferIncompleteReadBuffer = ((int)0x8CDC)        ,
        FramebufferIncompleteReadBufferExt = ((int)0x8CDC)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        FramebufferUnsupportedExt = ((int)0x8CDD)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        FramebufferIncompleteLayerTargets = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCount = ((int)0x8DA9)        ,
    }

    /// <summary>
    /// Used in GL.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferParameterName : int
    {
        FramebufferAttachmentColorEncoding = ((int)0x8210)        ,
        FramebufferAttachmentComponentType = ((int)0x8211)        ,
        FramebufferAttachmentRedSize = ((int)0x8212)        ,
        FramebufferAttachmentGreenSize = ((int)0x8213)        ,
        FramebufferAttachmentBlueSize = ((int)0x8214)        ,
        FramebufferAttachmentAlphaSize = ((int)0x8215)        ,
        FramebufferAttachmentDepthSize = ((int)0x8216)        ,
        FramebufferAttachmentStencilSize = ((int)0x8217)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectTypeExt = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentObjectNameExt = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureLevelExt = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8CD3)        ,
        FramebufferAttachmentTexture3DZoffsetExt = ((int)0x8CD4)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferAttachmentLayered = ((int)0x8DA7)        ,
    }

    /// <summary>
    /// Used in GL.BindFramebuffer, GL.CheckFramebufferStatus and 11 other functions
    /// </summary>
    public enum FramebufferTarget : int
    {
        ReadFramebuffer = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        Framebuffer = ((int)0x8D40)        ,
        FramebufferExt = ((int)0x8D40)        ,
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
    /// Used in GL.GenerateMipmap
    /// </summary>
    public enum GenerateMipmapTarget : int
    {
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        Texture3D = ((int)0x806F)        ,
        TextureCubeMap = ((int)0x8513)        ,
        Texture1DArray = ((int)0x8C18)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        TextureCubeMapArray = ((int)0x9009)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
    }

    /// <summary>
    /// Used in GL.GetColorTableParameter
    /// </summary>
    public enum GetColorTableParameterPName : int
    {
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
        ColorTableFormat = ((int)0x80D8)        ,
        ColorTableWidth = ((int)0x80D9)        ,
        ColorTableRedSize = ((int)0x80DA)        ,
        ColorTableGreenSize = ((int)0x80DB)        ,
        ColorTableBlueSize = ((int)0x80DC)        ,
        ColorTableAlphaSize = ((int)0x80DD)        ,
        ColorTableLuminanceSize = ((int)0x80DE)        ,
        ColorTableIntensitySize = ((int)0x80DF)        ,
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
    /// Used in GL.GetConvolutionParameter
    /// </summary>
    public enum GetConvolutionParameterPName : int
    {
        ConvolutionBorderMode = ((int)0x8013)        ,
        ConvolutionFilterScale = ((int)0x8014)        ,
        ConvolutionFilterBias = ((int)0x8015)        ,
        ConvolutionFormat = ((int)0x8017)        ,
        ConvolutionWidth = ((int)0x8018)        ,
        ConvolutionHeight = ((int)0x8019)        ,
        MaxConvolutionWidth = ((int)0x801A)        ,
        MaxConvolutionHeight = ((int)0x801B)        ,
        ConvolutionBorderColor = ((int)0x8154)        ,
    }

    /// <summary>
    /// Used in GL.GetHistogramParameter
    /// </summary>
    public enum GetHistogramParameterPName : int
    {
        HistogramWidth = ((int)0x8026)        ,
        HistogramFormat = ((int)0x8027)        ,
        HistogramRedSize = ((int)0x8028)        ,
        HistogramGreenSize = ((int)0x8029)        ,
        HistogramBlueSize = ((int)0x802A)        ,
        HistogramAlphaSize = ((int)0x802B)        ,
        HistogramLuminanceSize = ((int)0x802C)        ,
        HistogramSink = ((int)0x802D)        ,
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
    /// Used in GL.GetBoolean, GL.GetDouble and 3 other functions
    /// </summary>
    public enum GetIndexedPName : int
    {
        DepthRange = ((int)0x0B70)        ,
        Viewport = ((int)0x0BA2)        ,
        ScissorBox = ((int)0x0C10)        ,
        ColorWritemask = ((int)0x0C23)        ,
        UniformBufferBinding = ((int)0x8A28)        ,
        UniformBufferStart = ((int)0x8A29)        ,
        UniformBufferSize = ((int)0x8A2A)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        SampleMaskValue = ((int)0x8E52)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetMapQuery : int
    {
    }

    /// <summary>
    /// Used in GL.GetMinmaxParameter
    /// </summary>
    public enum GetMinmaxParameterPName : int
    {
        MinmaxFormat = ((int)0x802F)        ,
        MinmaxSink = ((int)0x8030)        ,
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
    /// Used in GL.GetMultisample
    /// </summary>
    public enum GetMultisamplePName : int
    {
        SamplePosition = ((int)0x8E50)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GetPixelMap : int
    {
    }

    /// <summary>
    /// Used in GL.GetBoolean, GL.GetDouble and 3 other functions
    /// </summary>
    public enum GetPName : int
    {
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
        PolygonMode = ((int)0x0B40)        ,
        PolygonSmooth = ((int)0x0B41)        ,
        PolygonStipple = ((int)0x0B42)        ,
        CullFace = ((int)0x0B44)        ,
        CullFaceMode = ((int)0x0B45)        ,
        FrontFace = ((int)0x0B46)        ,
        Lighting = ((int)0x0B50)        ,
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
        StencilTest = ((int)0x0B90)        ,
        StencilClearValue = ((int)0x0B91)        ,
        StencilFunc = ((int)0x0B92)        ,
        StencilValueMask = ((int)0x0B93)        ,
        StencilFail = ((int)0x0B94)        ,
        StencilPassDepthFail = ((int)0x0B95)        ,
        StencilPassDepthPass = ((int)0x0B96)        ,
        StencilRef = ((int)0x0B97)        ,
        StencilWritemask = ((int)0x0B98)        ,
        Normalize = ((int)0x0BA1)        ,
        Viewport = ((int)0x0BA2)        ,
        Modelview0StackDepthExt = ((int)0x0BA3)        ,
        Modelview0MatrixExt = ((int)0x0BA6)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestQcom = ((int)0x0BC0)        ,
        AlphaTestFuncQcom = ((int)0x0BC1)        ,
        AlphaTestRefQcom = ((int)0x0BC2)        ,
        Dither = ((int)0x0BD0)        ,
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        IndexLogicOp = ((int)0x0BF1)        ,
        LogicOp = ((int)0x0BF1)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        DrawBuffer = ((int)0x0C01)        ,
        DrawBufferExt = ((int)0x0C01)        ,
        ReadBuffer = ((int)0x0C02)        ,
        ReadBufferExt = ((int)0x0C02)        ,
        ReadBufferNv = ((int)0x0C02)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        Doublebuffer = ((int)0x0C32)        ,
        Stereo = ((int)0x0C33)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        PolygonSmoothHint = ((int)0x0C53)        ,
        TextureGenS = ((int)0x0C60)        ,
        TextureGenT = ((int)0x0C61)        ,
        TextureGenR = ((int)0x0C62)        ,
        TextureGenQ = ((int)0x0C63)        ,
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
        MaxClipDistances = ((int)0x0D32)        ,
        MaxTextureSize = ((int)0x0D33)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        SubpixelBits = ((int)0x0D50)        ,
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
        BlendEquationRgb = ((int)0x8009)        ,
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
        Max3DTextureSize = ((int)0x8073)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayCountExt = ((int)0x808D)        ,
        InterlaceSgix = ((int)0x8094)        ,
        DetailTexture2DBindingSgis = ((int)0x8096)        ,
        Multisample = ((int)0x809D)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        SampleBuffers = ((int)0x80A8)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SamplesSgis = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleMaskValueSgis = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
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
        BlendDstRgb = ((int)0x80C8)        ,
        BlendSrcRgb = ((int)0x80C9)        ,
        BlendDstAlpha = ((int)0x80CA)        ,
        BlendSrcAlpha = ((int)0x80CB)        ,
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
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
        GenerateMipmapHint = ((int)0x8192)        ,
        GenerateMipmapHintSgis = ((int)0x8192)        ,
        DeformationsMaskSgix = ((int)0x8196)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
        LightModelColorControl = ((int)0x81F8)        ,
        SharedTexturePaletteExt = ((int)0x81FB)        ,
        MajorVersion = ((int)0x821B)        ,
        MinorVersion = ((int)0x821C)        ,
        NumExtensions = ((int)0x821D)        ,
        ContextFlags = ((int)0x821E)        ,
        ProgramPipelineBinding = ((int)0x825A)        ,
        MaxViewports = ((int)0x825B)        ,
        ViewportSubpixelBits = ((int)0x825C)        ,
        ViewportBoundsRange = ((int)0x825D)        ,
        LayerProvokingVertex = ((int)0x825E)        ,
        ViewportIndexProvokingVertex = ((int)0x825F)        ,
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
        CurrentFogCoord = ((int)0x8453)        ,
        FogCoordArrayType = ((int)0x8454)        ,
        FogCoordArrayStride = ((int)0x8455)        ,
        ColorSum = ((int)0x8458)        ,
        CurrentSecondaryColor = ((int)0x8459)        ,
        SecondaryColorArraySize = ((int)0x845A)        ,
        SecondaryColorArrayType = ((int)0x845B)        ,
        SecondaryColorArrayStride = ((int)0x845C)        ,
        CurrentRasterSecondaryColor = ((int)0x845F)        ,
        AliasedPointSizeRange = ((int)0x846D)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
        ActiveTexture = ((int)0x84E0)        ,
        ClientActiveTexture = ((int)0x84E1)        ,
        MaxTextureUnits = ((int)0x84E2)        ,
        TransposeModelviewMatrix = ((int)0x84E3)        ,
        TransposeProjectionMatrix = ((int)0x84E4)        ,
        TransposeTextureMatrix = ((int)0x84E5)        ,
        TransposeColorMatrix = ((int)0x84E6)        ,
        MaxRenderbufferSize = ((int)0x84E8)        ,
        MaxRenderbufferSizeExt = ((int)0x84E8)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureBindingRectangle = ((int)0x84F6)        ,
        MaxRectangleTextureSize = ((int)0x84F8)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        VertexArrayBinding = ((int)0x85B5)        ,
        ProgramPointSize = ((int)0x8642)        ,
        DepthClamp = ((int)0x864F)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
        RgbaFloatMode = ((int)0x8820)        ,
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
        BlendEquationAlpha = ((int)0x883D)        ,
        TextureCubeMapSeamless = ((int)0x884F)        ,
        PointSprite = ((int)0x8861)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        MaxTessControlInputComponents = ((int)0x886C)        ,
        MaxTessEvaluationInputComponents = ((int)0x886D)        ,
        MaxTextureCoords = ((int)0x8871)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexArrayBufferBinding = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        IndexArrayBufferBinding = ((int)0x8899)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        EdgeFlagArrayBufferBinding = ((int)0x889B)        ,
        SecondaryColorArrayBufferBinding = ((int)0x889C)        ,
        FogCoordArrayBufferBinding = ((int)0x889D)        ,
        WeightArrayBufferBinding = ((int)0x889E)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        PixelPackBufferBinding = ((int)0x88ED)        ,
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        MaxDualSourceDrawBuffers = ((int)0x88FC)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        SamplerBinding = ((int)0x8919)        ,
        ClampVertexColor = ((int)0x891A)        ,
        ClampFragmentColor = ((int)0x891B)        ,
        ClampReadColor = ((int)0x891C)        ,
        MaxVertexUniformBlocks = ((int)0x8A2B)        ,
        MaxGeometryUniformBlocks = ((int)0x8A2C)        ,
        MaxFragmentUniformBlocks = ((int)0x8A2D)        ,
        MaxCombinedUniformBlocks = ((int)0x8A2E)        ,
        MaxUniformBufferBindings = ((int)0x8A2F)        ,
        MaxUniformBlockSize = ((int)0x8A30)        ,
        MaxCombinedVertexUniformComponents = ((int)0x8A31)        ,
        MaxCombinedGeometryUniformComponents = ((int)0x8A32)        ,
        MaxCombinedFragmentUniformComponents = ((int)0x8A33)        ,
        UniformBufferOffsetAlignment = ((int)0x8A34)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        MaxVaryingFloats = ((int)0x8B4B)        ,
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        CurrentProgram = ((int)0x8B8D)        ,
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        TextureBinding1DArray = ((int)0x8C1C)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        MaxGeometryTextureImageUnits = ((int)0x8C29)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        MaxTextureBufferSize = ((int)0x8C2B)        ,
        TextureBindingBuffer = ((int)0x8C2C)        ,
        TextureBufferDataStoreBinding = ((int)0x8C2D)        ,
        SampleShading = ((int)0x8C36)        ,
        MinSampleShadingValue = ((int)0x8C37)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBindingExt = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        RenderbufferBindingExt = ((int)0x8CA7)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
        MaxColorAttachmentsExt = ((int)0x8CDF)        ,
        MaxSamples = ((int)0x8D57)        ,
        FramebufferSrgb = ((int)0x8DB9)        ,
        MaxGeometryVaryingComponents = ((int)0x8DDD)        ,
        MaxVertexVaryingComponents = ((int)0x8DDE)        ,
        MaxGeometryUniformComponents = ((int)0x8DDF)        ,
        MaxGeometryOutputVertices = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponents = ((int)0x8DE1)        ,
        MaxSubroutines = ((int)0x8DE7)        ,
        MaxSubroutineUniformLocations = ((int)0x8DE8)        ,
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
        ShaderCompiler = ((int)0x8DFA)        ,
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        MaxVaryingVectors = ((int)0x8DFC)        ,
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
        MaxCombinedTessControlUniformComponents = ((int)0x8E1E)        ,
        MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)        ,
        TransformFeedbackBufferPaused = ((int)0x8E23)        ,
        TransformFeedbackBufferActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        Timestamp = ((int)0x8E28)        ,
        QuadsFollowProvokingVertexConvention = ((int)0x8E4C)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
        SampleMask = ((int)0x8E51)        ,
        MaxSampleMaskWords = ((int)0x8E59)        ,
        MaxGeometryShaderInvocations = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffset = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffset = ((int)0x8E5C)        ,
        FragmentInterpolationOffsetBits = ((int)0x8E5D)        ,
        MinProgramTextureGatherOffset = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffset = ((int)0x8E5F)        ,
        MaxTransformFeedbackBuffers = ((int)0x8E70)        ,
        MaxVertexStreams = ((int)0x8E71)        ,
        PatchVertices = ((int)0x8E72)        ,
        PatchDefaultInnerLevel = ((int)0x8E73)        ,
        PatchDefaultOuterLevel = ((int)0x8E74)        ,
        MaxTessGenLevel = ((int)0x8E7E)        ,
        MaxTessControlUniformComponents = ((int)0x8E7F)        ,
        MaxTessEvaluationUniformComponents = ((int)0x8E80)        ,
        MaxTessControlTextureImageUnits = ((int)0x8E81)        ,
        MaxTessEvaluationTextureImageUnits = ((int)0x8E82)        ,
        MaxTessControlOutputComponents = ((int)0x8E83)        ,
        MaxTessPatchComponents = ((int)0x8E84)        ,
        MaxTessControlTotalOutputComponents = ((int)0x8E85)        ,
        MaxTessEvaluationOutputComponents = ((int)0x8E86)        ,
        MaxTessControlUniformBlocks = ((int)0x8E89)        ,
        MaxTessEvaluationUniformBlocks = ((int)0x8E8A)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
        TextureBinding2DMultisample = ((int)0x9104)        ,
        TextureBinding2DMultisampleArray = ((int)0x9105)        ,
        MaxColorTextureSamples = ((int)0x910E)        ,
        MaxDepthTextureSamples = ((int)0x910F)        ,
        MaxIntegerSamples = ((int)0x9110)        ,
        MaxVertexOutputComponents = ((int)0x9122)        ,
        MaxGeometryInputComponents = ((int)0x9123)        ,
        MaxGeometryOutputComponents = ((int)0x9124)        ,
        MaxFragmentInputComponents = ((int)0x9125)        ,
    }

    /// <summary>
    /// Used in GL.GetPointer
    /// </summary>
    public enum GetPointervPName : int
    {
        VertexArrayPointerExt = ((int)0x808E)        ,
        NormalArrayPointerExt = ((int)0x808F)        ,
        ColorArrayPointerExt = ((int)0x8090)        ,
        IndexArrayPointerExt = ((int)0x8091)        ,
        TextureCoordArrayPointerExt = ((int)0x8092)        ,
        EdgeFlagArrayPointerExt = ((int)0x8093)        ,
        InstrumentBufferPointerSgix = ((int)0x8180)        ,
        FogCoordArrayPointer = ((int)0x8456)        ,
        SecondaryColorArrayPointer = ((int)0x845D)        ,
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
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = ((int)0x8258)        ,
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = ((int)0x887F)        ,
        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = ((int)0x8916)        ,
        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = ((int)0x8917)        ,
        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = ((int)0x8918)        ,
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
        /// <summary>
        /// Original was GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75
        /// </summary>
        TessControlOutputVertices = ((int)0x8E75)        ,
        /// <summary>
        /// Original was GL_TESS_GEN_MODE = 0x8E76
        /// </summary>
        TessGenMode = ((int)0x8E76)        ,
        /// <summary>
        /// Original was GL_TESS_GEN_SPACING = 0x8E77
        /// </summary>
        TessGenSpacing = ((int)0x8E77)        ,
        /// <summary>
        /// Original was GL_TESS_GEN_VERTEX_ORDER = 0x8E78
        /// </summary>
        TessGenVertexOrder = ((int)0x8E78)        ,
        /// <summary>
        /// Original was GL_TESS_GEN_POINT_MODE = 0x8E79
        /// </summary>
        TessGenPointMode = ((int)0x8E79)        ,
        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        /// </summary>
        MaxComputeWorkGroupSize = ((int)0x91BF)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = ((int)0x92D9)        ,
    }

    /// <summary>
    /// Used in GL.GetQueryObject
    /// </summary>
    public enum GetQueryObjectParam : int
    {
        QueryResult = ((int)0x8866)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        QueryResultNoWait = ((int)0x9194)        ,
    }

    /// <summary>
    /// Used in GL.GetQueryIndexed, GL.GetQuery
    /// </summary>
    public enum GetQueryParam : int
    {
        QueryCounterBits = ((int)0x8864)        ,
        CurrentQuery = ((int)0x8865)        ,
    }

    /// <summary>
    /// Used in GL.GetTexLevelParameter, GL.GetTexParameter and 1 other function
    /// </summary>
    public enum GetTextureParameter : int
    {
        TextureWidth = ((int)0x1000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
        TextureBorderColorNv = ((int)0x1004)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        TextureRedSize = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        TextureDepth = ((int)0x8071)        ,
        TextureDepthExt = ((int)0x8071)        ,
        TextureWrapR = ((int)0x8072)        ,
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
        TextureMinLod = ((int)0x813A)        ,
        TextureMinLodSgis = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureMaxLodSgis = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureBaseLevelSgis = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
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
        GenerateMipmap = ((int)0x8191)        ,
        GenerateMipmapSgis = ((int)0x8191)        ,
        TextureCompareSgix = ((int)0x819A)        ,
        TextureCompareOperatorSgix = ((int)0x819B)        ,
        TextureLequalRSgix = ((int)0x819C)        ,
        TextureGequalRSgix = ((int)0x819D)        ,
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
        TextureCompressedImageSize = ((int)0x86A0)        ,
        TextureCompressed = ((int)0x86A1)        ,
        TextureDepthSize = ((int)0x884A)        ,
        DepthTextureMode = ((int)0x884B)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        TextureStencilSize = ((int)0x88F1)        ,
        TextureRedType = ((int)0x8C10)        ,
        TextureGreenType = ((int)0x8C11)        ,
        TextureBlueType = ((int)0x8C12)        ,
        TextureAlphaType = ((int)0x8C13)        ,
        TextureLuminanceType = ((int)0x8C14)        ,
        TextureIntensityType = ((int)0x8C15)        ,
        TextureDepthType = ((int)0x8C16)        ,
        TextureSharedSize = ((int)0x8C3F)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
        TextureSamples = ((int)0x9106)        ,
        TextureFixedSampleLocations = ((int)0x9107)        ,
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
    /// Used in GL.GetHistogram, GL.GetHistogramParameter and 2 other functions
    /// </summary>
    public enum HistogramTarget : int
    {
        Histogram = ((int)0x8024)        ,
        ProxyHistogram = ((int)0x8025)        ,
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
    /// Used in GL.CopyImageSubData, GL.GetInternalformat
    /// </summary>
    public enum ImageTarget : int
    {
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        Texture3D = ((int)0x806F)        ,
        TextureRectangle = ((int)0x84F5)        ,
        TextureCubeMap = ((int)0x8513)        ,
        Texture1DArray = ((int)0x8C18)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        Renderbuffer = ((int)0x8D41)        ,
        TextureCubeMapArray = ((int)0x9009)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
    }

    /// <summary>
    /// Used in GL.Disable, GL.Enable and 1 other function
    /// </summary>
    public enum IndexedEnableCap : int
    {
        Blend = ((int)0x0BE2)        ,
        ScissorTest = ((int)0x0C11)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum InternalFormat : int
    {
        R3G3B2 = ((int)0x2A10)        ,
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
        Samples = ((int)0x80A9)        ,
        InternalformatSupported = ((int)0x826F)        ,
        InternalformatPreferred = ((int)0x8270)        ,
        InternalformatRedSize = ((int)0x8271)        ,
        InternalformatGreenSize = ((int)0x8272)        ,
        InternalformatBlueSize = ((int)0x8273)        ,
        InternalformatAlphaSize = ((int)0x8274)        ,
        InternalformatDepthSize = ((int)0x8275)        ,
        InternalformatStencilSize = ((int)0x8276)        ,
        InternalformatSharedSize = ((int)0x8277)        ,
        InternalformatRedType = ((int)0x8278)        ,
        InternalformatGreenType = ((int)0x8279)        ,
        InternalformatBlueType = ((int)0x827A)        ,
        InternalformatAlphaType = ((int)0x827B)        ,
        InternalformatDepthType = ((int)0x827C)        ,
        InternalformatStencilType = ((int)0x827D)        ,
        MaxWidth = ((int)0x827E)        ,
        MaxHeight = ((int)0x827F)        ,
        MaxDepth = ((int)0x8280)        ,
        MaxLayers = ((int)0x8281)        ,
        MaxCombinedDimensions = ((int)0x8282)        ,
        ColorComponents = ((int)0x8283)        ,
        DepthComponents = ((int)0x8284)        ,
        StencilComponents = ((int)0x8285)        ,
        ColorRenderable = ((int)0x8286)        ,
        DepthRenderable = ((int)0x8287)        ,
        StencilRenderable = ((int)0x8288)        ,
        FramebufferRenderable = ((int)0x8289)        ,
        FramebufferRenderableLayered = ((int)0x828A)        ,
        FramebufferBlend = ((int)0x828B)        ,
        ReadPixelsFormat = ((int)0x828D)        ,
        ReadPixelsType = ((int)0x828E)        ,
        TextureImageFormat = ((int)0x828F)        ,
        TextureImageType = ((int)0x8290)        ,
        GetTextureImageFormat = ((int)0x8291)        ,
        GetTextureImageType = ((int)0x8292)        ,
        Mipmap = ((int)0x8293)        ,
        ManualGenerateMipmap = ((int)0x8294)        ,
        ColorEncoding = ((int)0x8296)        ,
        SrgbRead = ((int)0x8297)        ,
        SrgbWrite = ((int)0x8298)        ,
        Filter = ((int)0x829A)        ,
        VertexTexture = ((int)0x829B)        ,
        TessControlTexture = ((int)0x829C)        ,
        TessEvaluationTexture = ((int)0x829D)        ,
        GeometryTexture = ((int)0x829E)        ,
        FragmentTexture = ((int)0x829F)        ,
        ComputeTexture = ((int)0x82A0)        ,
        TextureShadow = ((int)0x82A1)        ,
        TextureGather = ((int)0x82A2)        ,
        TextureGatherShadow = ((int)0x82A3)        ,
        ShaderImageLoad = ((int)0x82A4)        ,
        ShaderImageStore = ((int)0x82A5)        ,
        ShaderImageAtomic = ((int)0x82A6)        ,
        ImageTexelSize = ((int)0x82A7)        ,
        ImageCompatibilityClass = ((int)0x82A8)        ,
        ImagePixelFormat = ((int)0x82A9)        ,
        ImagePixelType = ((int)0x82AA)        ,
        SimultaneousTextureAndDepthTest = ((int)0x82AC)        ,
        SimultaneousTextureAndStencilTest = ((int)0x82AD)        ,
        SimultaneousTextureAndStencilWrite = ((int)0x82AF)        ,
        TextureCompressedBlockWidth = ((int)0x82B1)        ,
        TextureCompressedBlockHeight = ((int)0x82B2)        ,
        TextureCompressedBlockSize = ((int)0x82B3)        ,
        ClearBuffer = ((int)0x82B4)        ,
        TextureView = ((int)0x82B5)        ,
        ViewCompatibilityClass = ((int)0x82B6)        ,
        TextureCompressed = ((int)0x86A1)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        ClearTexture = ((int)0x9365)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ListMode : int
    {
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
    /// Used in GL.PolygonMode
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
        AmbientAndDiffuse = ((int)0x1602)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MatrixMode : int
    {
        Modelview0Ext = ((int)0x1700)        ,
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MatrixModeArb : int
    {
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
        Matrix0 = ((int)0x88C0)        ,
        Matrix1 = ((int)0x88C1)        ,
        Matrix2 = ((int)0x88C2)        ,
        Matrix3 = ((int)0x88C3)        ,
        Matrix4 = ((int)0x88C4)        ,
        Matrix5 = ((int)0x88C5)        ,
        Matrix6 = ((int)0x88C6)        ,
        Matrix7 = ((int)0x88C7)        ,
        Matrix8 = ((int)0x88C8)        ,
        Matrix9 = ((int)0x88C9)        ,
        Matrix10 = ((int)0x88CA)        ,
        Matrix11 = ((int)0x88CB)        ,
        Matrix12 = ((int)0x88CC)        ,
        Matrix13 = ((int)0x88CD)        ,
        Matrix14 = ((int)0x88CE)        ,
        Matrix15 = ((int)0x88CF)        ,
        Matrix16 = ((int)0x88D0)        ,
        Matrix17 = ((int)0x88D1)        ,
        Matrix18 = ((int)0x88D2)        ,
        Matrix19 = ((int)0x88D3)        ,
        Matrix20 = ((int)0x88D4)        ,
        Matrix21 = ((int)0x88D5)        ,
        Matrix22 = ((int)0x88D6)        ,
        Matrix23 = ((int)0x88D7)        ,
        Matrix24 = ((int)0x88D8)        ,
        Matrix25 = ((int)0x88D9)        ,
        Matrix26 = ((int)0x88DA)        ,
        Matrix27 = ((int)0x88DB)        ,
        Matrix28 = ((int)0x88DC)        ,
        Matrix29 = ((int)0x88DD)        ,
        Matrix30 = ((int)0x88DE)        ,
        Matrix31 = ((int)0x88DF)        ,
    }

    /// <summary>
    /// Used in GL.MemoryBarrier
    /// </summary>
    public enum MemoryBarrierFlags : int
    {
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        UniformBarrierBit = ((int)0x00000004)        ,
        TextureFetchBarrierBit = ((int)0x00000008)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
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
    /// Used in GL.GetMinmax, GL.GetMinmaxParameter and 2 other functions
    /// </summary>
    public enum MinmaxTarget : int
    {
        Minmax = ((int)0x802E)        ,
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
        HalfFloat = ((int)0x140B)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Used in GL.GetObjectLabel, GL.ObjectLabel
    /// </summary>
    public enum ObjectLabelIdentifier : int
    {
        Texture = ((int)0x1702)        ,
        VertexArray = ((int)0x8074)        ,
        Buffer = ((int)0x82E0)        ,
        Shader = ((int)0x82E1)        ,
        Program = ((int)0x82E2)        ,
        Query = ((int)0x82E3)        ,
        ProgramPipeline = ((int)0x82E4)        ,
        Sampler = ((int)0x82E6)        ,
        Framebuffer = ((int)0x8D40)        ,
        Renderbuffer = ((int)0x8D41)        ,
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
    /// Used in GL.ColorP3, GL.ColorP4 and 17 other functions
    /// </summary>
    public enum PackedPointerType : int
    {
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Used in GL.PatchParameter
    /// </summary>
    public enum PatchParameterFloat : int
    {
        PatchDefaultInnerLevel = ((int)0x8E73)        ,
        PatchDefaultOuterLevel = ((int)0x8E74)        ,
    }

    /// <summary>
    /// Used in GL.PatchParameter
    /// </summary>
    public enum PatchParameterInt : int
    {
        PatchVertices = ((int)0x8E72)        ,
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
    /// Used in GL.ClearBufferData, GL.ClearBufferSubData and 23 other functions
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
        Bgr = ((int)0x80E0)        ,
        Bgra = ((int)0x80E1)        ,
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
        Rg = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R5G6B5IccSgix = ((int)0x8466)        ,
        R5G6B5A8IccSgix = ((int)0x8467)        ,
        Alpha16IccSgix = ((int)0x8468)        ,
        Luminance16IccSgix = ((int)0x8469)        ,
        Luminance16Alpha8IccSgix = ((int)0x846B)        ,
        DepthStencil = ((int)0x84F9)        ,
        RedInteger = ((int)0x8D94)        ,
        GreenInteger = ((int)0x8D95)        ,
        BlueInteger = ((int)0x8D96)        ,
        AlphaInteger = ((int)0x8D97)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        BgrInteger = ((int)0x8D9A)        ,
        BgraInteger = ((int)0x8D9B)        ,
    }

    /// <summary>
    /// Used in GL.ClearBufferData, GL.ClearBufferSubData and 20 other functions
    /// </summary>
    public enum PixelInternalFormat : int
    {
        DepthComponent = ((int)0x1902)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        R3G3B2 = ((int)0x2A10)        ,
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
        DepthComponent16 = ((int)0x81a5)        ,
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81a6)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32 = ((int)0x81a7)        ,
        DepthComponent32Sgix = ((int)0x81A7)        ,
        CompressedRed = ((int)0x8225)        ,
        CompressedRg = ((int)0x8226)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)        ,
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)        ,
        RgbIccSgix = ((int)0x8460)        ,
        RgbaIccSgix = ((int)0x8461)        ,
        AlphaIccSgix = ((int)0x8462)        ,
        LuminanceIccSgix = ((int)0x8463)        ,
        IntensityIccSgix = ((int)0x8464)        ,
        LuminanceAlphaIccSgix = ((int)0x8465)        ,
        R5G6B5IccSgix = ((int)0x8466)        ,
        R5G6B5A8IccSgix = ((int)0x8467)        ,
        Alpha16IccSgix = ((int)0x8468)        ,
        Luminance16IccSgix = ((int)0x8469)        ,
        Intensity16IccSgix = ((int)0x846A)        ,
        Luminance16Alpha8IccSgix = ((int)0x846B)        ,
        CompressedAlpha = ((int)0x84E9)        ,
        CompressedLuminance = ((int)0x84EA)        ,
        CompressedLuminanceAlpha = ((int)0x84EB)        ,
        CompressedIntensity = ((int)0x84EC)        ,
        CompressedRgb = ((int)0x84ED)        ,
        CompressedRgba = ((int)0x84EE)        ,
        DepthStencil = ((int)0x84F9)        ,
        Rgba32f = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        Srgb = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        SrgbAlpha = ((int)0x8C42)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        SluminanceAlpha = ((int)0x8C44)        ,
        Sluminance8Alpha8 = ((int)0x8C45)        ,
        Sluminance = ((int)0x8C46)        ,
        Sluminance8 = ((int)0x8C47)        ,
        CompressedSrgb = ((int)0x8C48)        ,
        CompressedSrgbAlpha = ((int)0x8C49)        ,
        CompressedSluminance = ((int)0x8C4A)        ,
        CompressedSluminanceAlpha = ((int)0x8C4B)        ,
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
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
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        CompressedRedRgtc1 = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1 = ((int)0x8DBC)        ,
        CompressedRgRgtc2 = ((int)0x8DBD)        ,
        CompressedSignedRgRgtc2 = ((int)0x8DBE)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F)        ,
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        Rgb10A2ui = ((int)0x906F)        ,
        One = ((int)1)        ,
        Two = ((int)2)        ,
        Three = ((int)3)        ,
        Four = ((int)4)        ,
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
        UnpackCompressedBlockWidth = ((int)0x9127)        ,
        UnpackCompressedBlockHeight = ((int)0x9128)        ,
        UnpackCompressedBlockDepth = ((int)0x9129)        ,
        UnpackCompressedBlockSize = ((int)0x912A)        ,
        PackCompressedBlockWidth = ((int)0x912B)        ,
        PackCompressedBlockHeight = ((int)0x912C)        ,
        PackCompressedBlockDepth = ((int)0x912D)        ,
        PackCompressedBlockSize = ((int)0x912E)        ,
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
    /// Used in GL.ClearTexImage, GL.ClearTexSubImage and 18 other functions
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
        HalfFloat = ((int)0x140B)        ,
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
        UnsignedByte233Reversed = ((int)0x8362)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        UnsignedShort565Reversed = ((int)0x8364)        ,
        UnsignedShort4444Reversed = ((int)0x8365)        ,
        UnsignedShort1555Reversed = ((int)0x8366)        ,
        UnsignedInt8888Reversed = ((int)0x8367)        ,
        UnsignedInt2101010Reversed = ((int)0x8368)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
    }

    /// <summary>
    /// Used in GL.PointParameter
    /// </summary>
    public enum PointParameterName : int
    {
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
        PointSpriteCoordOrigin = ((int)0x8CA0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PointParameterNameSgis : int
    {
        PointSizeMinArb = ((int)0x8126)        ,
        PointSizeMinExt = ((int)0x8126)        ,
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMaxArb = ((int)0x8127)        ,
        PointSizeMaxExt = ((int)0x8127)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointFadeThresholdSizeArb = ((int)0x8128)        ,
        PointFadeThresholdSizeExt = ((int)0x8128)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationExt = ((int)0x8129)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
        PointDistanceAttenuationArb = ((int)0x8129)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PointSpriteCoordOriginParameter : int
    {
        LowerLeft = ((int)0x8CA1)        ,
        UpperLeft = ((int)0x8CA2)        ,
    }

    /// <summary>
    /// Used in GL.PolygonMode
    /// </summary>
    public enum PolygonMode : int
    {
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
        Fill = ((int)0x1B02)        ,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawArraysIndirect and 19 other functions
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
    /// Used in GL.GetProgramInterface, GL.GetProgramResourceIndex and 4 other functions
    /// </summary>
    public enum ProgramInterface : int
    {
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        AtomicCounterBuffer = ((int)0x92C0)        ,
        Uniform = ((int)0x92E1)        ,
        UniformBlock = ((int)0x92E2)        ,
        ProgramInput = ((int)0x92E3)        ,
        ProgramOutput = ((int)0x92E4)        ,
        BufferVariable = ((int)0x92E5)        ,
        ShaderStorageBlock = ((int)0x92E6)        ,
        VertexSubroutine = ((int)0x92E8)        ,
        TessControlSubroutine = ((int)0x92E9)        ,
        TessEvaluationSubroutine = ((int)0x92EA)        ,
        GeometrySubroutine = ((int)0x92EB)        ,
        FragmentSubroutine = ((int)0x92EC)        ,
        ComputeSubroutine = ((int)0x92ED)        ,
        VertexSubroutineUniform = ((int)0x92EE)        ,
        TessControlSubroutineUniform = ((int)0x92EF)        ,
        TessEvaluationSubroutineUniform = ((int)0x92F0)        ,
        GeometrySubroutineUniform = ((int)0x92F1)        ,
        FragmentSubroutineUniform = ((int)0x92F2)        ,
        ComputeSubroutineUniform = ((int)0x92F3)        ,
        TransformFeedbackVarying = ((int)0x92F4)        ,
    }

    /// <summary>
    /// Used in GL.GetProgramInterface
    /// </summary>
    public enum ProgramInterfaceParameter : int
    {
        ActiveResources = ((int)0x92F5)        ,
        MaxNameLength = ((int)0x92F6)        ,
        MaxNumActiveVariables = ((int)0x92F7)        ,
        MaxNumCompatibleSubroutines = ((int)0x92F8)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramParameter : int
    {
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparable = ((int)0x8258)        ,
        GeometryShaderInvocations = ((int)0x887F)        ,
        GeometryVerticesOut = ((int)0x8916)        ,
        GeometryInputType = ((int)0x8917)        ,
        GeometryOutputType = ((int)0x8918)        ,
        ActiveUniformBlockMaxNameLength = ((int)0x8A35)        ,
        ActiveUniformBlocks = ((int)0x8A36)        ,
        DeleteStatus = ((int)0x8B80)        ,
        LinkStatus = ((int)0x8B82)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        AttachedShaders = ((int)0x8B85)        ,
        ActiveUniforms = ((int)0x8B86)        ,
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        ActiveAttributes = ((int)0x8B89)        ,
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TessControlOutputVertices = ((int)0x8E75)        ,
        TessGenMode = ((int)0x8E76)        ,
        TessGenSpacing = ((int)0x8E77)        ,
        TessGenVertexOrder = ((int)0x8E78)        ,
        TessGenPointMode = ((int)0x8E79)        ,
        MaxComputeWorkGroupSize = ((int)0x91BF)        ,
        ActiveAtomicCounterBuffers = ((int)0x92D9)        ,
    }

    /// <summary>
    /// Used in GL.ProgramParameter
    /// </summary>
    public enum ProgramParameterName : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = ((int)0x8258)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ProgramParameterPName : int
    {
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparable = ((int)0x8258)        ,
    }

    /// <summary>
    /// Used in GL.GetProgramPipeline
    /// </summary>
    public enum ProgramPipelineParameter : int
    {
        ActiveProgram = ((int)0x8259)        ,
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        GeometryShader = ((int)0x8DD9)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        ComputeShader = ((int)0x91B9)        ,
    }

    /// <summary>
    /// Used in GL.GetProgramResource
    /// </summary>
    public enum ProgramProperty : int
    {
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
        IsPerPatch = ((int)0x92E7)        ,
        NameLength = ((int)0x92F9)        ,
        Type = ((int)0x92FA)        ,
        ArraySize = ((int)0x92FB)        ,
        Offset = ((int)0x92FC)        ,
        BlockIndex = ((int)0x92FD)        ,
        ArrayStride = ((int)0x92FE)        ,
        MatrixStride = ((int)0x92FF)        ,
        IsRowMajor = ((int)0x9300)        ,
        AtomicCounterBufferIndex = ((int)0x9301)        ,
        BufferBinding = ((int)0x9302)        ,
        BufferDataSize = ((int)0x9303)        ,
        NumActiveVariables = ((int)0x9304)        ,
        ActiveVariables = ((int)0x9305)        ,
        ReferencedByVertexShader = ((int)0x9306)        ,
        ReferencedByTessControlShader = ((int)0x9307)        ,
        ReferencedByTessEvaluationShader = ((int)0x9308)        ,
        ReferencedByGeometryShader = ((int)0x9309)        ,
        ReferencedByFragmentShader = ((int)0x930A)        ,
        TopLevelArraySize = ((int)0x930C)        ,
        TopLevelArrayStride = ((int)0x930D)        ,
        Location = ((int)0x930E)        ,
        LocationIndex = ((int)0x930F)        ,
        LocationComponent = ((int)0x934A)        ,
        TransformFeedbackBufferIndex = ((int)0x934B)        ,
        TransformFeedbackBufferStride = ((int)0x934C)        ,
    }

    /// <summary>
    /// Used in GL.UseProgramStages
    /// </summary>
    [Flags]
    public enum ProgramStageMask : int
    {
        VertexShaderBit = ((int)0x00000001)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        TessControlShaderBit = ((int)0x00000008)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ComputeShaderBit = ((int)0x00000020)        ,
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Used in GL.GetProgramStage
    /// </summary>
    public enum ProgramStageParameter : int
    {
        ActiveSubroutines = ((int)0x8DE5)        ,
        ActiveSubroutineUniforms = ((int)0x8DE6)        ,
        ActiveSubroutineUniformLocations = ((int)0x8E47)        ,
        ActiveSubroutineMaxLength = ((int)0x8E48)        ,
        ActiveSubroutineUniformMaxLength = ((int)0x8E49)        ,
    }

    /// <summary>
    /// Used in GL.ProvokingVertex
    /// </summary>
    public enum ProvokingVertexMode : int
    {
        FirstVertexConvention = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
    }

    /// <summary>
    /// Used in GL.QueryCounter
    /// </summary>
    public enum QueryCounterTarget : int
    {
        Timestamp = ((int)0x8E28)        ,
    }

    /// <summary>
    /// Used in GL.BeginQuery, GL.BeginQueryIndexed and 4 other functions
    /// </summary>
    public enum QueryTarget : int
    {
        TimeElapsed = ((int)0x88BF)        ,
        SamplesPassed = ((int)0x8914)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        PrimitivesGenerated = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        Timestamp = ((int)0x8E28)        ,
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
        FrontAndBack = ((int)0x0408)        ,
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
    /// Used in GL.GetRenderbufferParameter
    /// </summary>
    public enum RenderbufferParameterName : int
    {
        RenderbufferSamples = ((int)0x8CAB)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferWidthExt = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferHeightExt = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        RenderbufferInternalFormatExt = ((int)0x8D44)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferRedSizeExt = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferGreenSizeExt = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferBlueSizeExt = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferAlphaSizeExt = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferDepthSizeExt = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        RenderbufferStencilSizeExt = ((int)0x8D55)        ,
    }

    /// <summary>
    /// Used in GL.RenderbufferStorage, GL.RenderbufferStorageMultisample
    /// </summary>
    public enum RenderbufferStorage : int
    {
        R3G3B2 = ((int)0x2A10)        ,
        Rgb4 = ((int)0x804F)        ,
        Rgb5 = ((int)0x8050)        ,
        Rgb8 = ((int)0x8051)        ,
        Rgb10 = ((int)0x8052)        ,
        Rgb12 = ((int)0x8053)        ,
        Rgb16 = ((int)0x8054)        ,
        Rgba2 = ((int)0x8055)        ,
        Rgba4 = ((int)0x8056)        ,
        Rgba8 = ((int)0x8058)        ,
        Rgb10A2 = ((int)0x8059)        ,
        Rgba12 = ((int)0x805A)        ,
        Rgba16 = ((int)0x805B)        ,
        DepthComponent16 = ((int)0x81a5)        ,
        DepthComponent24 = ((int)0x81a6)        ,
        DepthComponent32 = ((int)0x81a7)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
        Rgba32f = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        Srgb8 = ((int)0x8C41)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        StencilIndex1 = ((int)0x8D46)        ,
        StencilIndex1Ext = ((int)0x8D46)        ,
        StencilIndex4 = ((int)0x8D47)        ,
        StencilIndex4Ext = ((int)0x8D47)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        StencilIndex8Ext = ((int)0x8D48)        ,
        StencilIndex16 = ((int)0x8D49)        ,
        StencilIndex16Ext = ((int)0x8D49)        ,
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
        Rgb10A2ui = ((int)0x906F)        ,
    }

    /// <summary>
    /// Used in GL.BindRenderbuffer, GL.FramebufferRenderbuffer and 3 other functions
    /// </summary>
    public enum RenderbufferTarget : int
    {
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferExt = ((int)0x8D41)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum RenderingMode : int
    {
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
    public enum SamplerParameter : int
    {
        TextureBorderColor = ((int)0x1004)        ,
        TextureMagFilter = ((int)0x2800)        ,
        TextureMinFilter = ((int)0x2801)        ,
        TextureWrapS = ((int)0x2802)        ,
        TextureWrapT = ((int)0x2803)        ,
        TextureWrapR = ((int)0x8072)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        TextureLodBias = ((int)0x8501)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
    }

    /// <summary>
    /// Used in GL.GetSamplerParameter, GL.SamplerParameter and 1 other function
    /// </summary>
    public enum SamplerParameterName : int
    {
        /// <summary>
        /// Original was GL_TextureBorderColor = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004)        ,
        /// <summary>
        /// Original was GL_TextureMagFilter = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800)        ,
        /// <summary>
        /// Original was GL_TextureMinFilter = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801)        ,
        /// <summary>
        /// Original was GL_TextureWrapS = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802)        ,
        /// <summary>
        /// Original was GL_TextureWrapT = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803)        ,
        /// <summary>
        /// Original was GL_TextureWrapR = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_TextureMinLod = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A)        ,
        /// <summary>
        /// Original was GL_TextureMaxLod = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B)        ,
        /// <summary>
        /// Original was GL_TextureMaxAnisotropyExt = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        /// <summary>
        /// Original was GL_TextureLodBias = 0x8501
        /// </summary>
        TextureLodBias = ((int)0x8501)        ,
        /// <summary>
        /// Original was GL_TextureCompareMode = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C)        ,
        /// <summary>
        /// Original was GL_TextureCompareFunc = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D)        ,
    }

    /// <summary>
    /// Used in GL.GetSeparableFilter, GL.SeparableFilter2D
    /// </summary>
    public enum SeparableTarget : int
    {
        Separable2D = ((int)0x8012)        ,
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
    /// Not used directly.
    /// </summary>
    public enum SgixIccTexture : int
    {
        RgbIccSgix = ((int)0x8460)        ,
        RgbaIccSgix = ((int)0x8461)        ,
        AlphaIccSgix = ((int)0x8462)        ,
        LuminanceIccSgix = ((int)0x8463)        ,
        IntensityIccSgix = ((int)0x8464)        ,
        LuminanceAlphaIccSgix = ((int)0x8465)        ,
        R5G6B5IccSgix = ((int)0x8466)        ,
        R5G6B5A8IccSgix = ((int)0x8467)        ,
        Alpha16IccSgix = ((int)0x8468)        ,
        Luminance16IccSgix = ((int)0x8469)        ,
        Intensity16IccSgix = ((int)0x846A)        ,
        Luminance16Alpha8IccSgix = ((int)0x846B)        ,
    }

    /// <summary>
    /// Used in GL.GetShader
    /// </summary>
    public enum ShaderParameter : int
    {
        ShaderType = ((int)0x8B4F)        ,
        DeleteStatus = ((int)0x8B80)        ,
        CompileStatus = ((int)0x8B81)        ,
        InfoLogLength = ((int)0x8B84)        ,
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
    /// Used in GL.CreateShader, GL.CreateShaderProgram and 9 other functions
    /// </summary>
    public enum ShaderType : int
    {
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        GeometryShader = ((int)0x8DD9)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        ComputeShader = ((int)0x91B9)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShadingModel : int
    {
    }

    /// <summary>
    /// Used in GL.BindImageTexture, GL.GetInternalformat and 7 other functions
    /// </summary>
    public enum SizedInternalFormat : int
    {
        Rgba8 = ((int)0x8058)        ,
        Rgba16 = ((int)0x805B)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
        Rgba32f = ((int)0x8814)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgba32ui = ((int)0x8D70)        ,
        Rgba16ui = ((int)0x8D76)        ,
        Rgba8ui = ((int)0x8D7C)        ,
        Rgba32i = ((int)0x8D82)        ,
        Rgba16i = ((int)0x8D88)        ,
        Rgba8i = ((int)0x8D8E)        ,
    }

    /// <summary>
    /// Used in GL.StencilFuncSeparate, GL.StencilMaskSeparate and 1 other function
    /// </summary>
    public enum StencilFace : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Used in GL.StencilFunc, GL.StencilFuncSeparate
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
    /// Used in GL.StencilOp, GL.StencilOpSeparate
    /// </summary>
    public enum StencilOp : int
    {
        Zero = ((int)0)        ,
        Invert = ((int)0x150A)        ,
        Keep = ((int)0x1E00)        ,
        Replace = ((int)0x1E01)        ,
        Incr = ((int)0x1E02)        ,
        Decr = ((int)0x1E03)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
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
        ShadingLanguageVersion = ((int)0x8B8C)        ,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringNameIndexed : int
    {
        Extensions = ((int)0x1F03)        ,
        ShadingLanguageVersion = ((int)0x8B8C)        ,
    }

    /// <summary>
    /// Used in GL.FenceSync
    /// </summary>
    public enum SyncCondition : int
    {
        SyncGpuCommandsComplete = ((int)0x9117)        ,
    }

    /// <summary>
    /// Used in GL.GetSync
    /// </summary>
    public enum SyncParameterName : int
    {
        ObjectType = ((int)0x9112)        ,
        SyncCondition = ((int)0x9113)        ,
        SyncStatus = ((int)0x9114)        ,
        SyncFlags = ((int)0x9115)        ,
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
        HalfFloat = ((int)0x140B)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Used in GL.BindImageTexture
    /// </summary>
    public enum TextureAccess : int
    {
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
    }

    /// <summary>
    /// Used in GL.TexBuffer, GL.TexBufferRange
    /// </summary>
    public enum TextureBufferTarget : int
    {
        TextureBuffer = ((int)0x8C2A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureCompareMode : int
    {
        None = ((int)0)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        CompareRToTexture = ((int)0x884E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureCoordName : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvMode : int
    {
        Add = ((int)0x0104)        ,
        Blend = ((int)0x0BE2)        ,
        Replace = ((int)0x1E01)        ,
        Modulate = ((int)0x2100)        ,
        ReplaceExt = ((int)0x8062)        ,
        TextureEnvBiasSgix = ((int)0x80BE)        ,
        Combine = ((int)0x8570)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeCombine : int
    {
        Add = ((int)0x0104)        ,
        Replace = ((int)0x1E01)        ,
        Modulate = ((int)0x2100)        ,
        Subtract = ((int)0x84E7)        ,
        AddSigned = ((int)0x8574)        ,
        Interpolate = ((int)0x8575)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeOperandAlpha : int
    {
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeOperandRgb : int
    {
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModePointSprite : int
    {
        False = ((int)0)        ,
        True = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeScale : int
    {
        One = ((int)1)        ,
        Two = ((int)2)        ,
        Four = ((int)4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvModeSource : int
    {
        Texture = ((int)0x1702)        ,
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
        Constant = ((int)0x8576)        ,
        PrimaryColor = ((int)0x8577)        ,
        Previous = ((int)0x8578)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvParameter : int
    {
        AlphaScale = ((int)0x0D1C)        ,
        TextureLodBias = ((int)0x8501)        ,
        CombineRgb = ((int)0x8571)        ,
        CombineAlpha = ((int)0x8572)        ,
        RgbScale = ((int)0x8573)        ,
        Source0Rgb = ((int)0x8580)        ,
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
        CoordReplace = ((int)0x8862)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureEnvTarget : int
    {
        TextureFilterControl = ((int)0x8500)        ,
        PointSprite = ((int)0x8861)        ,
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
        EyeDistanceToPointSgis = ((int)0x81F0)        ,
        ObjectDistanceToPointSgis = ((int)0x81F1)        ,
        EyeDistanceToLineSgis = ((int)0x81F2)        ,
        ObjectDistanceToLineSgis = ((int)0x81F3)        ,
        NormalMap = ((int)0x8511)        ,
        ReflectionMap = ((int)0x8512)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureGenParameter : int
    {
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
    /// Used in GL.TexParameter, GL.TexParameterI
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
        TextureDepth = ((int)0x8071)        ,
        TextureWrapR = ((int)0x8072)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        TextureWrapROes = ((int)0x8072)        ,
        DetailTextureLevelSgis = ((int)0x809A)        ,
        DetailTextureModeSgis = ((int)0x809B)        ,
        ShadowAmbientSgix = ((int)0x80BF)        ,
        TextureCompareFailValue = ((int)0x80BF)        ,
        DualTextureSelectSgis = ((int)0x8124)        ,
        QuadTextureSelectSgis = ((int)0x8125)        ,
        ClampToBorder = ((int)0x812D)        ,
        ClampToEdge = ((int)0x812F)        ,
        TextureWrapQSgis = ((int)0x8137)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
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
        TextureLodBias = ((int)0x8501)        ,
        DepthTextureMode = ((int)0x884B)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.CompressedTexImage1D and 27 other functions
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
        TextureRectangle = ((int)0x84F5)        ,
        ProxyTextureRectangle = ((int)0x84F7)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        Texture1DArray = ((int)0x8C18)        ,
        ProxyTexture1DArray = ((int)0x8C19)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        ProxyTexture2DArray = ((int)0x8C1B)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        TextureCubeMapArray = ((int)0x9009)        ,
        ProxyTextureCubeMapArray = ((int)0x900B)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
    }

    /// <summary>
    /// Used in GL.TexStorage1D
    /// </summary>
    public enum TextureTarget1d : int
    {
        Texture1D = ((int)0x0DE0)        ,
        ProxyTexture1D = ((int)0x8063)        ,
    }

    /// <summary>
    /// Used in GL.TexStorage2D
    /// </summary>
    public enum TextureTarget2d : int
    {
        Texture2D = ((int)0x0DE1)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        TextureRectangle = ((int)0x84F5)        ,
        ProxyTextureRectangle = ((int)0x84F7)        ,
        TextureCubeMap = ((int)0x8513)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        Texture1DArray = ((int)0x8C18)        ,
        ProxyTexture1DArray = ((int)0x8C19)        ,
    }

    /// <summary>
    /// Used in GL.TexStorage3D
    /// </summary>
    public enum TextureTarget3d : int
    {
        Texture3D = ((int)0x806F)        ,
        ProxyTexture3D = ((int)0x8070)        ,
        TextureCubeMap = ((int)0x8513)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        ProxyTexture2DArray = ((int)0x8C1B)        ,
    }

    /// <summary>
    /// Used in GL.TexImage2DMultisample, GL.TexImage3DMultisample
    /// </summary>
    public enum TextureTargetMultisample : int
    {
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
    }

    /// <summary>
    /// Used in GL.TexStorage2DMultisample
    /// </summary>
    public enum TextureTargetMultisample2d : int
    {
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
    }

    /// <summary>
    /// Used in GL.TexStorage3DMultisample
    /// </summary>
    public enum TextureTargetMultisample3d : int
    {
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
    }

    /// <summary>
    /// Used in GL.ActiveTexture, GL.MultiTexCoordP1 and 3 other functions
    /// </summary>
    public enum TextureUnit : int
    {
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureWrapMode : int
    {
        Repeat = ((int)0x2901)        ,
        ClampToBorder = ((int)0x812D)        ,
        ClampToBorderArb = ((int)0x812D)        ,
        ClampToBorderNv = ((int)0x812D)        ,
        ClampToBorderSgis = ((int)0x812D)        ,
        ClampToEdge = ((int)0x812F)        ,
        ClampToEdgeSgis = ((int)0x812F)        ,
        MirroredRepeat = ((int)0x8370)        ,
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
        Points = ((int)0x0000)        ,
        Lines = ((int)0x0001)        ,
        Triangles = ((int)0x0004)        ,
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
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
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
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
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
    public enum Version10 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version11 : int
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
        FrontLeft = ((int)0x0400)        ,
        FrontRight = ((int)0x0401)        ,
        BackLeft = ((int)0x0402)        ,
        BackRight = ((int)0x0403)        ,
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        Left = ((int)0x0406)        ,
        Right = ((int)0x0407)        ,
        FrontAndBack = ((int)0x0408)        ,
        InvalidEnum = ((int)0x0500)        ,
        InvalidValue = ((int)0x0501)        ,
        InvalidOperation = ((int)0x0502)        ,
        OutOfMemory = ((int)0x0505)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        PointSize = ((int)0x0B11)        ,
        PointSizeRange = ((int)0x0B12)        ,
        PointSizeGranularity = ((int)0x0B13)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineWidth = ((int)0x0B21)        ,
        LineWidthRange = ((int)0x0B22)        ,
        LineWidthGranularity = ((int)0x0B23)        ,
        PolygonMode = ((int)0x0B40)        ,
        PolygonSmooth = ((int)0x0B41)        ,
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
        BlendDst = ((int)0x0BE0)        ,
        BlendSrc = ((int)0x0BE1)        ,
        Blend = ((int)0x0BE2)        ,
        LogicOpMode = ((int)0x0BF0)        ,
        ColorLogicOp = ((int)0x0BF2)        ,
        DrawBuffer = ((int)0x0C01)        ,
        ReadBuffer = ((int)0x0C02)        ,
        ScissorBox = ((int)0x0C10)        ,
        ScissorTest = ((int)0x0C11)        ,
        ColorClearValue = ((int)0x0C22)        ,
        ColorWritemask = ((int)0x0C23)        ,
        Doublebuffer = ((int)0x0C32)        ,
        Stereo = ((int)0x0C33)        ,
        LineSmoothHint = ((int)0x0C52)        ,
        PolygonSmoothHint = ((int)0x0C53)        ,
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
        MaxTextureSize = ((int)0x0D33)        ,
        MaxViewportDims = ((int)0x0D3A)        ,
        SubpixelBits = ((int)0x0D50)        ,
        Texture1D = ((int)0x0DE0)        ,
        Texture2D = ((int)0x0DE1)        ,
        TextureWidth = ((int)0x1000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
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
        Double = ((int)0x140A)        ,
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
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        StencilIndex = ((int)0x1901)        ,
        DepthComponent = ((int)0x1902)        ,
        Red = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
        Fill = ((int)0x1B02)        ,
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
        PolygonOffsetPoint = ((int)0x2A01)        ,
        PolygonOffsetLine = ((int)0x2A02)        ,
        R3G3B2 = ((int)0x2A10)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
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
        TextureRedSize = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        TextureBinding1D = ((int)0x8068)        ,
        TextureBinding2D = ((int)0x8069)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version12 : int
    {
        SmoothPointSizeRange = ((int)0x0B12)        ,
        SmoothPointSizeGranularity = ((int)0x0B13)        ,
        SmoothLineWidthRange = ((int)0x0B22)        ,
        SmoothLineWidthGranularity = ((int)0x0B23)        ,
        UnsignedByte332 = ((int)0x8032)        ,
        UnsignedShort4444 = ((int)0x8033)        ,
        UnsignedShort5551 = ((int)0x8034)        ,
        UnsignedInt8888 = ((int)0x8035)        ,
        UnsignedInt1010102 = ((int)0x8036)        ,
        TextureBinding3D = ((int)0x806A)        ,
        PackSkipImages = ((int)0x806B)        ,
        PackImageHeight = ((int)0x806C)        ,
        UnpackSkipImages = ((int)0x806D)        ,
        UnpackImageHeight = ((int)0x806E)        ,
        Texture3D = ((int)0x806F)        ,
        ProxyTexture3D = ((int)0x8070)        ,
        TextureDepth = ((int)0x8071)        ,
        TextureWrapR = ((int)0x8072)        ,
        Max3DTextureSize = ((int)0x8073)        ,
        Bgr = ((int)0x80E0)        ,
        Bgra = ((int)0x80E1)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
        ClampToEdge = ((int)0x812F)        ,
        TextureMinLod = ((int)0x813A)        ,
        TextureMaxLod = ((int)0x813B)        ,
        TextureBaseLevel = ((int)0x813C)        ,
        TextureMaxLevel = ((int)0x813D)        ,
        UnsignedByte233Rev = ((int)0x8362)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        UnsignedShort565Rev = ((int)0x8364)        ,
        UnsignedShort4444Rev = ((int)0x8365)        ,
        UnsignedShort1555Rev = ((int)0x8366)        ,
        UnsignedInt8888Rev = ((int)0x8367)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version13 : int
    {
        Multisample = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleBuffers = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
        ClampToBorder = ((int)0x812D)        ,
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
        CompressedRgb = ((int)0x84ED)        ,
        CompressedRgba = ((int)0x84EE)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        TextureCompressedImageSize = ((int)0x86A0)        ,
        TextureCompressed = ((int)0x86A1)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version14 : int
    {
        ConstantColor = ((int)0x8001)        ,
        OneMinusConstantColor = ((int)0x8002)        ,
        ConstantAlpha = ((int)0x8003)        ,
        OneMinusConstantAlpha = ((int)0x8004)        ,
        FuncAdd = ((int)0x8006)        ,
        Min = ((int)0x8007)        ,
        Max = ((int)0x8008)        ,
        FuncSubtract = ((int)0x800A)        ,
        FuncReverseSubtract = ((int)0x800B)        ,
        BlendDstRgb = ((int)0x80C8)        ,
        BlendSrcRgb = ((int)0x80C9)        ,
        BlendDstAlpha = ((int)0x80CA)        ,
        BlendSrcAlpha = ((int)0x80CB)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        DepthComponent16 = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81A6)        ,
        DepthComponent32 = ((int)0x81A7)        ,
        MirroredRepeat = ((int)0x8370)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        TextureLodBias = ((int)0x8501)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        TextureDepthSize = ((int)0x884A)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version15 : int
    {
        Src1Alpha = ((int)0x8589)        ,
        BufferSize = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        QueryCounterBits = ((int)0x8864)        ,
        CurrentQuery = ((int)0x8865)        ,
        QueryResult = ((int)0x8866)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
        BufferAccess = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        StreamDraw = ((int)0x88E0)        ,
        StreamRead = ((int)0x88E1)        ,
        StreamCopy = ((int)0x88E2)        ,
        StaticDraw = ((int)0x88E4)        ,
        StaticRead = ((int)0x88E5)        ,
        StaticCopy = ((int)0x88E6)        ,
        DynamicDraw = ((int)0x88E8)        ,
        DynamicRead = ((int)0x88E9)        ,
        DynamicCopy = ((int)0x88EA)        ,
        SamplesPassed = ((int)0x8914)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version20 : int
    {
        BlendEquationRgb = ((int)0x8009)        ,
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        VertexProgramPointSize = ((int)0x8642)        ,
        VertexAttribArrayPointer = ((int)0x8645)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
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
        BlendEquationAlpha = ((int)0x883D)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        FragmentShader = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVaryingFloats = ((int)0x8B4B)        ,
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
        Sampler1D = ((int)0x8B5D)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        Sampler1DShadow = ((int)0x8B61)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
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
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        CurrentProgram = ((int)0x8B8D)        ,
        PointSpriteCoordOrigin = ((int)0x8CA0)        ,
        LowerLeft = ((int)0x8CA1)        ,
        UpperLeft = ((int)0x8CA2)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version21 : int
    {
        PixelPackBuffer = ((int)0x88EB)        ,
        PixelUnpackBuffer = ((int)0x88EC)        ,
        PixelPackBufferBinding = ((int)0x88ED)        ,
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        Srgb = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        SrgbAlpha = ((int)0x8C42)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        CompressedSrgb = ((int)0x8C48)        ,
        CompressedSrgbAlpha = ((int)0x8C49)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version30 : int
    {
        ContextFlagForwardCompatibleBit = ((int)0x00000001)        ,
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapFlushExplicitBit = ((int)0x0010)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        InvalidFramebufferOperation = ((int)0x0506)        ,
        MaxClipDistances = ((int)0x0D32)        ,
        HalfFloat = ((int)0x140B)        ,
        ClipDistance0 = ((int)0x3000)        ,
        ClipDistance1 = ((int)0x3001)        ,
        ClipDistance2 = ((int)0x3002)        ,
        ClipDistance3 = ((int)0x3003)        ,
        ClipDistance4 = ((int)0x3004)        ,
        ClipDistance5 = ((int)0x3005)        ,
        ClipDistance6 = ((int)0x3006)        ,
        ClipDistance7 = ((int)0x3007)        ,
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
        ContextFlags = ((int)0x821E)        ,
        Index = ((int)0x8222)        ,
        CompressedRed = ((int)0x8225)        ,
        CompressedRg = ((int)0x8226)        ,
        Rg = ((int)0x8227)        ,
        RgInteger = ((int)0x8228)        ,
        R8 = ((int)0x8229)        ,
        R16 = ((int)0x822A)        ,
        Rg8 = ((int)0x822B)        ,
        Rg16 = ((int)0x822C)        ,
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
        MaxRenderbufferSize = ((int)0x84E8)        ,
        DepthStencil = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        VertexArrayBinding = ((int)0x85B5)        ,
        Rgba32f = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        TextureStencilSize = ((int)0x88F1)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        ClampReadColor = ((int)0x891C)        ,
        FixedOnly = ((int)0x891D)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        TextureRedType = ((int)0x8C10)        ,
        TextureGreenType = ((int)0x8C11)        ,
        TextureBlueType = ((int)0x8C12)        ,
        TextureAlphaType = ((int)0x8C13)        ,
        TextureDepthType = ((int)0x8C16)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        Texture1DArray = ((int)0x8C18)        ,
        ProxyTexture1DArray = ((int)0x8C19)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        ProxyTexture2DArray = ((int)0x8C1B)        ,
        TextureBinding1DArray = ((int)0x8C1C)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        TextureSharedSize = ((int)0x8C3F)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        PrimitivesGenerated = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        InterleavedAttribs = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        DepthComponent32f = ((int)0x8CAC)        ,
        Depth32fStencil8 = ((int)0x8CAD)        ,
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferComplete = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB)        ,
        FramebufferIncompleteReadBuffer = ((int)0x8CDC)        ,
        FramebufferUnsupported = ((int)0x8CDD)        ,
        MaxColorAttachments = ((int)0x8CDF)        ,
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
        DepthAttachment = ((int)0x8D00)        ,
        StencilAttachment = ((int)0x8D20)        ,
        Framebuffer = ((int)0x8D40)        ,
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferWidth = ((int)0x8D42)        ,
        RenderbufferHeight = ((int)0x8D43)        ,
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        StencilIndex1 = ((int)0x8D46)        ,
        StencilIndex4 = ((int)0x8D47)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        StencilIndex16 = ((int)0x8D49)        ,
        RenderbufferRedSize = ((int)0x8D50)        ,
        RenderbufferGreenSize = ((int)0x8D51)        ,
        RenderbufferBlueSize = ((int)0x8D52)        ,
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        RenderbufferDepthSize = ((int)0x8D54)        ,
        RenderbufferStencilSize = ((int)0x8D55)        ,
        FramebufferIncompleteMultisample = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
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
        GreenInteger = ((int)0x8D95)        ,
        BlueInteger = ((int)0x8D96)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        BgrInteger = ((int)0x8D9A)        ,
        BgraInteger = ((int)0x8D9B)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        FramebufferSrgb = ((int)0x8DB9)        ,
        CompressedRedRgtc1 = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1 = ((int)0x8DBC)        ,
        CompressedRgRgtc2 = ((int)0x8DBD)        ,
        CompressedSignedRgRgtc2 = ((int)0x8DBE)        ,
        Sampler1DArray = ((int)0x8DC0)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        Sampler1DArrayShadow = ((int)0x8DC3)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        IntSampler1D = ((int)0x8DC9)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSampler1DArray = ((int)0x8DCE)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        UnsignedIntSampler1D = ((int)0x8DD1)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSampler1DArray = ((int)0x8DD6)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        QueryWait = ((int)0x8E13)        ,
        QueryNoWait = ((int)0x8E14)        ,
        QueryByRegionWait = ((int)0x8E15)        ,
        QueryByRegionNoWait = ((int)0x8E16)        ,
        BufferAccessFlags = ((int)0x911F)        ,
        BufferMapLength = ((int)0x9120)        ,
        BufferMapOffset = ((int)0x9121)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version31 : int
    {
        TextureRectangle = ((int)0x84F5)        ,
        TextureBindingRectangle = ((int)0x84F6)        ,
        ProxyTextureRectangle = ((int)0x84F7)        ,
        MaxRectangleTextureSize = ((int)0x84F8)        ,
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
        Sampler2DRect = ((int)0x8B63)        ,
        Sampler2DRectShadow = ((int)0x8B64)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        MaxTextureBufferSize = ((int)0x8C2B)        ,
        TextureBindingBuffer = ((int)0x8C2C)        ,
        TextureBufferDataStoreBinding = ((int)0x8C2D)        ,
        SamplerBuffer = ((int)0x8DC2)        ,
        IntSampler2DRect = ((int)0x8DCD)        ,
        IntSamplerBuffer = ((int)0x8DD0)        ,
        UnsignedIntSampler2DRect = ((int)0x8DD5)        ,
        UnsignedIntSamplerBuffer = ((int)0x8DD8)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        R16Snorm = ((int)0x8F98)        ,
        Rg16Snorm = ((int)0x8F99)        ,
        Rgb16Snorm = ((int)0x8F9A)        ,
        Rgba16Snorm = ((int)0x8F9B)        ,
        SignedNormalized = ((int)0x8F9C)        ,
        PrimitiveRestart = ((int)0x8F9D)        ,
        PrimitiveRestartIndex = ((int)0x8F9E)        ,
        InvalidIndex = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version32 : int
    {
        ContextCoreProfileBit = ((int)0x00000001)        ,
        SyncFlushCommandsBit = ((int)0x00000001)        ,
        ContextCompatibilityProfileBit = ((int)0x00000002)        ,
        LinesAdjacency = ((int)0x000A)        ,
        LineStripAdjacency = ((int)0x000B)        ,
        TrianglesAdjacency = ((int)0x000C)        ,
        TriangleStripAdjacency = ((int)0x000D)        ,
        ProgramPointSize = ((int)0x8642)        ,
        DepthClamp = ((int)0x864F)        ,
        TextureCubeMapSeamless = ((int)0x884F)        ,
        GeometryVerticesOut = ((int)0x8916)        ,
        GeometryInputType = ((int)0x8917)        ,
        GeometryOutputType = ((int)0x8918)        ,
        MaxGeometryTextureImageUnits = ((int)0x8C29)        ,
        FramebufferAttachmentLayered = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargets = ((int)0x8DA8)        ,
        GeometryShader = ((int)0x8DD9)        ,
        MaxGeometryUniformComponents = ((int)0x8DDF)        ,
        MaxGeometryOutputVertices = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponents = ((int)0x8DE1)        ,
        QuadsFollowProvokingVertexConvention = ((int)0x8E4C)        ,
        FirstVertexConvention = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
        SamplePosition = ((int)0x8E50)        ,
        SampleMask = ((int)0x8E51)        ,
        SampleMaskValue = ((int)0x8E52)        ,
        MaxSampleMaskWords = ((int)0x8E59)        ,
        Texture2DMultisample = ((int)0x9100)        ,
        ProxyTexture2DMultisample = ((int)0x9101)        ,
        Texture2DMultisampleArray = ((int)0x9102)        ,
        ProxyTexture2DMultisampleArray = ((int)0x9103)        ,
        TextureBinding2DMultisample = ((int)0x9104)        ,
        TextureBinding2DMultisampleArray = ((int)0x9105)        ,
        TextureSamples = ((int)0x9106)        ,
        TextureFixedSampleLocations = ((int)0x9107)        ,
        Sampler2DMultisample = ((int)0x9108)        ,
        IntSampler2DMultisample = ((int)0x9109)        ,
        UnsignedIntSampler2DMultisample = ((int)0x910A)        ,
        Sampler2DMultisampleArray = ((int)0x910B)        ,
        IntSampler2DMultisampleArray = ((int)0x910C)        ,
        UnsignedIntSampler2DMultisampleArray = ((int)0x910D)        ,
        MaxColorTextureSamples = ((int)0x910E)        ,
        MaxDepthTextureSamples = ((int)0x910F)        ,
        MaxIntegerSamples = ((int)0x9110)        ,
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
        MaxVertexOutputComponents = ((int)0x9122)        ,
        MaxGeometryInputComponents = ((int)0x9123)        ,
        MaxGeometryOutputComponents = ((int)0x9124)        ,
        MaxFragmentInputComponents = ((int)0x9125)        ,
        ContextProfileMask = ((int)0x9126)        ,
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version33 : int
    {
        TimeElapsed = ((int)0x88BF)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        MaxDualSourceDrawBuffers = ((int)0x88FC)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
        SamplerBinding = ((int)0x8919)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
        Timestamp = ((int)0x8E28)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
        Rgb10A2ui = ((int)0x906F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version40 : int
    {
        Quads = ((int)0x0007)        ,
        Patches = ((int)0x000E)        ,
        UniformBlockReferencedByTessControlShader = ((int)0x84F0)        ,
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)        ,
        MaxTessControlInputComponents = ((int)0x886C)        ,
        MaxTessEvaluationInputComponents = ((int)0x886D)        ,
        GeometryShaderInvocations = ((int)0x887F)        ,
        SampleShading = ((int)0x8C36)        ,
        MinSampleShadingValue = ((int)0x8C37)        ,
        ActiveSubroutines = ((int)0x8DE5)        ,
        ActiveSubroutineUniforms = ((int)0x8DE6)        ,
        MaxSubroutines = ((int)0x8DE7)        ,
        MaxSubroutineUniformLocations = ((int)0x8DE8)        ,
        MaxCombinedTessControlUniformComponents = ((int)0x8E1E)        ,
        MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)        ,
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackBufferPaused = ((int)0x8E23)        ,
        TransformFeedbackBufferActive = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        ActiveSubroutineUniformLocations = ((int)0x8E47)        ,
        ActiveSubroutineMaxLength = ((int)0x8E48)        ,
        ActiveSubroutineUniformMaxLength = ((int)0x8E49)        ,
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
        MaxGeometryShaderInvocations = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffset = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffset = ((int)0x8E5C)        ,
        FragmentInterpolationOffsetBits = ((int)0x8E5D)        ,
        MinProgramTextureGatherOffset = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffset = ((int)0x8E5F)        ,
        MaxTransformFeedbackBuffers = ((int)0x8E70)        ,
        MaxVertexStreams = ((int)0x8E71)        ,
        PatchVertices = ((int)0x8E72)        ,
        PatchDefaultInnerLevel = ((int)0x8E73)        ,
        PatchDefaultOuterLevel = ((int)0x8E74)        ,
        TessControlOutputVertices = ((int)0x8E75)        ,
        TessGenMode = ((int)0x8E76)        ,
        TessGenSpacing = ((int)0x8E77)        ,
        TessGenVertexOrder = ((int)0x8E78)        ,
        TessGenPointMode = ((int)0x8E79)        ,
        Isolines = ((int)0x8E7A)        ,
        FractionalOdd = ((int)0x8E7B)        ,
        FractionalEven = ((int)0x8E7C)        ,
        MaxPatchVertices = ((int)0x8E7D)        ,
        MaxTessGenLevel = ((int)0x8E7E)        ,
        MaxTessControlUniformComponents = ((int)0x8E7F)        ,
        MaxTessEvaluationUniformComponents = ((int)0x8E80)        ,
        MaxTessControlTextureImageUnits = ((int)0x8E81)        ,
        MaxTessEvaluationTextureImageUnits = ((int)0x8E82)        ,
        MaxTessControlOutputComponents = ((int)0x8E83)        ,
        MaxTessPatchComponents = ((int)0x8E84)        ,
        MaxTessControlTotalOutputComponents = ((int)0x8E85)        ,
        MaxTessEvaluationOutputComponents = ((int)0x8E86)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        MaxTessControlUniformBlocks = ((int)0x8E89)        ,
        MaxTessEvaluationUniformBlocks = ((int)0x8E8A)        ,
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
        TextureCubeMapArray = ((int)0x9009)        ,
        TextureBindingCubeMapArray = ((int)0x900A)        ,
        ProxyTextureCubeMapArray = ((int)0x900B)        ,
        SamplerCubeMapArray = ((int)0x900C)        ,
        SamplerCubeMapArrayShadow = ((int)0x900D)        ,
        IntSamplerCubeMapArray = ((int)0x900E)        ,
        UnsignedIntSamplerCubeMapArray = ((int)0x900F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version41 : int
    {
        VertexShaderBit = ((int)0x00000001)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        TessControlShaderBit = ((int)0x00000008)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        Fixed = ((int)0x140C)        ,
        ProgramBinaryRetrievableHint = ((int)0x8257)        ,
        ProgramSeparable = ((int)0x8258)        ,
        ActiveProgram = ((int)0x8259)        ,
        ProgramPipelineBinding = ((int)0x825A)        ,
        MaxViewports = ((int)0x825B)        ,
        ViewportSubpixelBits = ((int)0x825C)        ,
        ViewportBoundsRange = ((int)0x825D)        ,
        LayerProvokingVertex = ((int)0x825E)        ,
        ViewportIndexProvokingVertex = ((int)0x825F)        ,
        UndefinedVertex = ((int)0x8260)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        ImplementationColorReadType = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
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
        AllShaderBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version42 : int
    {
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        UniformBarrierBit = ((int)0x00000004)        ,
        TextureFetchBarrierBit = ((int)0x00000008)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        PixelBufferBarrierBit = ((int)0x00000080)        ,
        TextureUpdateBarrierBit = ((int)0x00000100)        ,
        BufferUpdateBarrierBit = ((int)0x00000200)        ,
        FramebufferBarrierBit = ((int)0x00000400)        ,
        TransformFeedbackBarrierBit = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F)        ,
        /// <summary>
        /// Original was GL_MAX_IMAGE_UNITS = 0x8F38
        /// </summary>
        MaxImageUnits = ((int)0x8F38)        ,
        MaxCombinedImageUnitsAndFragmentOutputs = ((int)0x8F39)        ,
        ImageBindingName = ((int)0x8F3A)        ,
        ImageBindingLevel = ((int)0x8F3B)        ,
        ImageBindingLayered = ((int)0x8F3C)        ,
        ImageBindingLayer = ((int)0x8F3D)        ,
        ImageBindingAccess = ((int)0x8F3E)        ,
        Image1D = ((int)0x904C)        ,
        Image2D = ((int)0x904D)        ,
        Image3D = ((int)0x904E)        ,
        Image2DRect = ((int)0x904F)        ,
        ImageCube = ((int)0x9050)        ,
        ImageBuffer = ((int)0x9051)        ,
        Image1DArray = ((int)0x9052)        ,
        Image2DArray = ((int)0x9053)        ,
        ImageCubeMapArray = ((int)0x9054)        ,
        Image2DMultisample = ((int)0x9055)        ,
        Image2DMultisampleArray = ((int)0x9056)        ,
        IntImage1D = ((int)0x9057)        ,
        IntImage2D = ((int)0x9058)        ,
        IntImage3D = ((int)0x9059)        ,
        IntImage2DRect = ((int)0x905A)        ,
        IntImageCube = ((int)0x905B)        ,
        IntImageBuffer = ((int)0x905C)        ,
        IntImage1DArray = ((int)0x905D)        ,
        IntImage2DArray = ((int)0x905E)        ,
        IntImageCubeMapArray = ((int)0x905F)        ,
        IntImage2DMultisample = ((int)0x9060)        ,
        IntImage2DMultisampleArray = ((int)0x9061)        ,
        UnsignedIntImage1D = ((int)0x9062)        ,
        UnsignedIntImage2D = ((int)0x9063)        ,
        UnsignedIntImage3D = ((int)0x9064)        ,
        UnsignedIntImage2DRect = ((int)0x9065)        ,
        UnsignedIntImageCube = ((int)0x9066)        ,
        UnsignedIntImageBuffer = ((int)0x9067)        ,
        UnsignedIntImage1DArray = ((int)0x9068)        ,
        UnsignedIntImage2DArray = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArray = ((int)0x906A)        ,
        UnsignedIntImage2DMultisample = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArray = ((int)0x906C)        ,
        MaxImageSamples = ((int)0x906D)        ,
        ImageBindingFormat = ((int)0x906E)        ,
        MinMapBufferAlignment = ((int)0x90BC)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        ImageFormatCompatibilityBySize = ((int)0x90C8)        ,
        ImageFormatCompatibilityByClass = ((int)0x90C9)        ,
        MaxVertexImageUniforms = ((int)0x90CA)        ,
        MaxTessControlImageUniforms = ((int)0x90CB)        ,
        MaxTessEvaluationImageUniforms = ((int)0x90CC)        ,
        MaxGeometryImageUniforms = ((int)0x90CD)        ,
        MaxFragmentImageUniforms = ((int)0x90CE)        ,
        MaxCombinedImageUniforms = ((int)0x90CF)        ,
        UnpackCompressedBlockWidth = ((int)0x9127)        ,
        UnpackCompressedBlockHeight = ((int)0x9128)        ,
        UnpackCompressedBlockDepth = ((int)0x9129)        ,
        UnpackCompressedBlockSize = ((int)0x912A)        ,
        PackCompressedBlockWidth = ((int)0x912B)        ,
        PackCompressedBlockHeight = ((int)0x912C)        ,
        PackCompressedBlockDepth = ((int)0x912D)        ,
        PackCompressedBlockSize = ((int)0x912E)        ,
        TextureImmutableFormat = ((int)0x912F)        ,
        AtomicCounterBuffer = ((int)0x92C0)        ,
        AtomicCounterBufferBinding = ((int)0x92C1)        ,
        AtomicCounterBufferStart = ((int)0x92C2)        ,
        AtomicCounterBufferSize = ((int)0x92C3)        ,
        AtomicCounterBufferDataSize = ((int)0x92C4)        ,
        AtomicCounterBufferActiveAtomicCounters = ((int)0x92C5)        ,
        AtomicCounterBufferActiveAtomicCounterIndices = ((int)0x92C6)        ,
        AtomicCounterBufferReferencedByVertexShader = ((int)0x92C7)        ,
        AtomicCounterBufferReferencedByTessControlShader = ((int)0x92C8)        ,
        AtomicCounterBufferReferencedByTessEvaluationShader = ((int)0x92C9)        ,
        AtomicCounterBufferReferencedByGeometryShader = ((int)0x92CA)        ,
        AtomicCounterBufferReferencedByFragmentShader = ((int)0x92CB)        ,
        MaxVertexAtomicCounterBuffers = ((int)0x92CC)        ,
        MaxTessControlAtomicCounterBuffers = ((int)0x92CD)        ,
        MaxTessEvaluationAtomicCounterBuffers = ((int)0x92CE)        ,
        MaxGeometryAtomicCounterBuffers = ((int)0x92CF)        ,
        MaxFragmentAtomicCounterBuffers = ((int)0x92D0)        ,
        MaxCombinedAtomicCounterBuffers = ((int)0x92D1)        ,
        MaxVertexAtomicCounters = ((int)0x92D2)        ,
        MaxTessControlAtomicCounters = ((int)0x92D3)        ,
        MaxTessEvaluationAtomicCounters = ((int)0x92D4)        ,
        MaxGeometryAtomicCounters = ((int)0x92D5)        ,
        MaxFragmentAtomicCounters = ((int)0x92D6)        ,
        MaxCombinedAtomicCounters = ((int)0x92D7)        ,
        MaxAtomicCounterBufferSize = ((int)0x92D8)        ,
        ActiveAtomicCounterBuffers = ((int)0x92D9)        ,
        UniformAtomicCounterBufferIndex = ((int)0x92DA)        ,
        UnsignedIntAtomicCounter = ((int)0x92DB)        ,
        MaxAtomicCounterBufferBindings = ((int)0x92DC)        ,
        NumSampleCounts = ((int)0x9380)        ,
        AllBarrierBits = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version43 : int
    {
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        StackOverflow = ((int)0x0503)        ,
        StackUnderflow = ((int)0x0504)        ,
        VertexArray = ((int)0x8074)        ,
        DebugOutputSynchronous = ((int)0x8242)        ,
        DebugNextLoggedMessageLength = ((int)0x8243)        ,
        DebugCallbackFunction = ((int)0x8244)        ,
        DebugCallbackUserParam = ((int)0x8245)        ,
        DebugSourceApi = ((int)0x8246)        ,
        DebugSourceWindowSystem = ((int)0x8247)        ,
        DebugSourceShaderCompiler = ((int)0x8248)        ,
        DebugSourceThirdParty = ((int)0x8249)        ,
        DebugSourceApplication = ((int)0x824A)        ,
        DebugSourceOther = ((int)0x824B)        ,
        DebugTypeError = ((int)0x824C)        ,
        DebugTypeDeprecatedBehavior = ((int)0x824D)        ,
        DebugTypeUndefinedBehavior = ((int)0x824E)        ,
        DebugTypePortability = ((int)0x824F)        ,
        DebugTypePerformance = ((int)0x8250)        ,
        DebugTypeOther = ((int)0x8251)        ,
        MaxComputeSharedMemorySize = ((int)0x8262)        ,
        MaxComputeUniformComponents = ((int)0x8263)        ,
        MaxComputeAtomicCounterBuffers = ((int)0x8264)        ,
        MaxComputeAtomicCounters = ((int)0x8265)        ,
        MaxCombinedComputeUniformComponents = ((int)0x8266)        ,
        ComputeWorkGroupSize = ((int)0x8267)        ,
        DebugTypeMarker = ((int)0x8268)        ,
        DebugTypePushGroup = ((int)0x8269)        ,
        DebugTypePopGroup = ((int)0x826A)        ,
        DebugSeverityNotification = ((int)0x826B)        ,
        MaxDebugGroupStackDepth = ((int)0x826C)        ,
        DebugGroupStackDepth = ((int)0x826D)        ,
        MaxUniformLocations = ((int)0x826E)        ,
        InternalformatSupported = ((int)0x826F)        ,
        InternalformatPreferred = ((int)0x8270)        ,
        InternalformatRedSize = ((int)0x8271)        ,
        InternalformatGreenSize = ((int)0x8272)        ,
        InternalformatBlueSize = ((int)0x8273)        ,
        InternalformatAlphaSize = ((int)0x8274)        ,
        InternalformatDepthSize = ((int)0x8275)        ,
        InternalformatStencilSize = ((int)0x8276)        ,
        InternalformatSharedSize = ((int)0x8277)        ,
        InternalformatRedType = ((int)0x8278)        ,
        InternalformatGreenType = ((int)0x8279)        ,
        InternalformatBlueType = ((int)0x827A)        ,
        InternalformatAlphaType = ((int)0x827B)        ,
        InternalformatDepthType = ((int)0x827C)        ,
        InternalformatStencilType = ((int)0x827D)        ,
        MaxWidth = ((int)0x827E)        ,
        MaxHeight = ((int)0x827F)        ,
        MaxDepth = ((int)0x8280)        ,
        MaxLayers = ((int)0x8281)        ,
        MaxCombinedDimensions = ((int)0x8282)        ,
        ColorComponents = ((int)0x8283)        ,
        DepthComponents = ((int)0x8284)        ,
        StencilComponents = ((int)0x8285)        ,
        ColorRenderable = ((int)0x8286)        ,
        DepthRenderable = ((int)0x8287)        ,
        StencilRenderable = ((int)0x8288)        ,
        FramebufferRenderable = ((int)0x8289)        ,
        FramebufferRenderableLayered = ((int)0x828A)        ,
        FramebufferBlend = ((int)0x828B)        ,
        ReadPixels = ((int)0x828C)        ,
        ReadPixelsFormat = ((int)0x828D)        ,
        ReadPixelsType = ((int)0x828E)        ,
        TextureImageFormat = ((int)0x828F)        ,
        TextureImageType = ((int)0x8290)        ,
        GetTextureImageFormat = ((int)0x8291)        ,
        GetTextureImageType = ((int)0x8292)        ,
        Mipmap = ((int)0x8293)        ,
        ManualGenerateMipmap = ((int)0x8294)        ,
        AutoGenerateMipmap = ((int)0x8295)        ,
        ColorEncoding = ((int)0x8296)        ,
        SrgbRead = ((int)0x8297)        ,
        SrgbWrite = ((int)0x8298)        ,
        Filter = ((int)0x829A)        ,
        VertexTexture = ((int)0x829B)        ,
        TessControlTexture = ((int)0x829C)        ,
        TessEvaluationTexture = ((int)0x829D)        ,
        GeometryTexture = ((int)0x829E)        ,
        FragmentTexture = ((int)0x829F)        ,
        ComputeTexture = ((int)0x82A0)        ,
        TextureShadow = ((int)0x82A1)        ,
        TextureGather = ((int)0x82A2)        ,
        TextureGatherShadow = ((int)0x82A3)        ,
        ShaderImageLoad = ((int)0x82A4)        ,
        ShaderImageStore = ((int)0x82A5)        ,
        ShaderImageAtomic = ((int)0x82A6)        ,
        ImageTexelSize = ((int)0x82A7)        ,
        ImageCompatibilityClass = ((int)0x82A8)        ,
        ImagePixelFormat = ((int)0x82A9)        ,
        ImagePixelType = ((int)0x82AA)        ,
        SimultaneousTextureAndDepthTest = ((int)0x82AC)        ,
        SimultaneousTextureAndStencilTest = ((int)0x82AD)        ,
        SimultaneousTextureAndDepthWrite = ((int)0x82AE)        ,
        SimultaneousTextureAndStencilWrite = ((int)0x82AF)        ,
        TextureCompressedBlockWidth = ((int)0x82B1)        ,
        TextureCompressedBlockHeight = ((int)0x82B2)        ,
        TextureCompressedBlockSize = ((int)0x82B3)        ,
        ClearBuffer = ((int)0x82B4)        ,
        TextureView = ((int)0x82B5)        ,
        ViewCompatibilityClass = ((int)0x82B6)        ,
        FullSupport = ((int)0x82B7)        ,
        CaveatSupport = ((int)0x82B8)        ,
        ImageClass4X32 = ((int)0x82B9)        ,
        ImageClass2X32 = ((int)0x82BA)        ,
        ImageClass1X32 = ((int)0x82BB)        ,
        ImageClass4X16 = ((int)0x82BC)        ,
        ImageClass2X16 = ((int)0x82BD)        ,
        ImageClass1X16 = ((int)0x82BE)        ,
        ImageClass4X8 = ((int)0x82BF)        ,
        ImageClass2X8 = ((int)0x82C0)        ,
        ImageClass1X8 = ((int)0x82C1)        ,
        ImageClass111110 = ((int)0x82C2)        ,
        ImageClass1010102 = ((int)0x82C3)        ,
        ViewClass128Bits = ((int)0x82C4)        ,
        ViewClass96Bits = ((int)0x82C5)        ,
        ViewClass64Bits = ((int)0x82C6)        ,
        ViewClass48Bits = ((int)0x82C7)        ,
        ViewClass32Bits = ((int)0x82C8)        ,
        ViewClass24Bits = ((int)0x82C9)        ,
        ViewClass16Bits = ((int)0x82CA)        ,
        ViewClass8Bits = ((int)0x82CB)        ,
        ViewClassS3tcDxt1Rgb = ((int)0x82CC)        ,
        ViewClassS3tcDxt1Rgba = ((int)0x82CD)        ,
        ViewClassS3tcDxt3Rgba = ((int)0x82CE)        ,
        ViewClassS3tcDxt5Rgba = ((int)0x82CF)        ,
        ViewClassRgtc1Red = ((int)0x82D0)        ,
        ViewClassRgtc2Rg = ((int)0x82D1)        ,
        ViewClassBptcUnorm = ((int)0x82D2)        ,
        ViewClassBptcFloat = ((int)0x82D3)        ,
        VertexAttribBinding = ((int)0x82D4)        ,
        VertexAttribRelativeOffset = ((int)0x82D5)        ,
        VertexBindingDivisor = ((int)0x82D6)        ,
        VertexBindingOffset = ((int)0x82D7)        ,
        VertexBindingStride = ((int)0x82D8)        ,
        MaxVertexAttribRelativeOffset = ((int)0x82D9)        ,
        MaxVertexAttribBindings = ((int)0x82DA)        ,
        TextureViewMinLevel = ((int)0x82DB)        ,
        TextureViewNumLevels = ((int)0x82DC)        ,
        TextureViewMinLayer = ((int)0x82DD)        ,
        TextureViewNumLayers = ((int)0x82DE)        ,
        TextureImmutableLevels = ((int)0x82DF)        ,
        Buffer = ((int)0x82E0)        ,
        Shader = ((int)0x82E1)        ,
        Program = ((int)0x82E2)        ,
        Query = ((int)0x82E3)        ,
        ProgramPipeline = ((int)0x82E4)        ,
        Sampler = ((int)0x82E6)        ,
        DisplayList = ((int)0x82E7)        ,
        MaxLabelLength = ((int)0x82E8)        ,
        NumShadingLanguageVersions = ((int)0x82E9)        ,
        VertexAttribArrayLong = ((int)0x874E)        ,
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        MaxElementIndex = ((int)0x8D6B)        ,
        MaxCombinedShaderOutputResources = ((int)0x8F39)        ,
        ShaderStorageBuffer = ((int)0x90D2)        ,
        ShaderStorageBufferBinding = ((int)0x90D3)        ,
        ShaderStorageBufferStart = ((int)0x90D4)        ,
        ShaderStorageBufferSize = ((int)0x90D5)        ,
        MaxVertexShaderStorageBlocks = ((int)0x90D6)        ,
        MaxGeometryShaderStorageBlocks = ((int)0x90D7)        ,
        MaxTessControlShaderStorageBlocks = ((int)0x90D8)        ,
        MaxTessEvaluationShaderStorageBlocks = ((int)0x90D9)        ,
        MaxFragmentShaderStorageBlocks = ((int)0x90DA)        ,
        MaxComputeShaderStorageBlocks = ((int)0x90DB)        ,
        MaxCombinedShaderStorageBlocks = ((int)0x90DC)        ,
        MaxShaderStorageBufferBindings = ((int)0x90DD)        ,
        MaxShaderStorageBlockSize = ((int)0x90DE)        ,
        ShaderStorageBufferOffsetAlignment = ((int)0x90DF)        ,
        DepthStencilTextureMode = ((int)0x90EA)        ,
        MaxComputeWorkGroupInvocations = ((int)0x90EB)        ,
        UniformBlockReferencedByComputeShader = ((int)0x90EC)        ,
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED)        ,
        DispatchIndirectBuffer = ((int)0x90EE)        ,
        DispatchIndirectBufferBinding = ((int)0x90EF)        ,
        MaxDebugMessageLength = ((int)0x9143)        ,
        MaxDebugLoggedMessages = ((int)0x9144)        ,
        DebugLoggedMessages = ((int)0x9145)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
        TextureBufferOffset = ((int)0x919D)        ,
        TextureBufferSize = ((int)0x919E)        ,
        TextureBufferOffsetAlignment = ((int)0x919F)        ,
        ComputeShader = ((int)0x91B9)        ,
        MaxComputeUniformBlocks = ((int)0x91BB)        ,
        MaxComputeTextureImageUnits = ((int)0x91BC)        ,
        MaxComputeImageUniforms = ((int)0x91BD)        ,
        MaxComputeWorkGroupCount = ((int)0x91BE)        ,
        MaxComputeWorkGroupSize = ((int)0x91BF)        ,
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
        DebugOutput = ((int)0x92E0)        ,
        Uniform = ((int)0x92E1)        ,
        UniformBlock = ((int)0x92E2)        ,
        ProgramInput = ((int)0x92E3)        ,
        ProgramOutput = ((int)0x92E4)        ,
        BufferVariable = ((int)0x92E5)        ,
        ShaderStorageBlock = ((int)0x92E6)        ,
        IsPerPatch = ((int)0x92E7)        ,
        VertexSubroutine = ((int)0x92E8)        ,
        TessControlSubroutine = ((int)0x92E9)        ,
        TessEvaluationSubroutine = ((int)0x92EA)        ,
        GeometrySubroutine = ((int)0x92EB)        ,
        FragmentSubroutine = ((int)0x92EC)        ,
        ComputeSubroutine = ((int)0x92ED)        ,
        VertexSubroutineUniform = ((int)0x92EE)        ,
        TessControlSubroutineUniform = ((int)0x92EF)        ,
        TessEvaluationSubroutineUniform = ((int)0x92F0)        ,
        GeometrySubroutineUniform = ((int)0x92F1)        ,
        FragmentSubroutineUniform = ((int)0x92F2)        ,
        ComputeSubroutineUniform = ((int)0x92F3)        ,
        TransformFeedbackVarying = ((int)0x92F4)        ,
        ActiveResources = ((int)0x92F5)        ,
        MaxNameLength = ((int)0x92F6)        ,
        MaxNumActiveVariables = ((int)0x92F7)        ,
        MaxNumCompatibleSubroutines = ((int)0x92F8)        ,
        NameLength = ((int)0x92F9)        ,
        Type = ((int)0x92FA)        ,
        ArraySize = ((int)0x92FB)        ,
        Offset = ((int)0x92FC)        ,
        BlockIndex = ((int)0x92FD)        ,
        ArrayStride = ((int)0x92FE)        ,
        MatrixStride = ((int)0x92FF)        ,
        IsRowMajor = ((int)0x9300)        ,
        AtomicCounterBufferIndex = ((int)0x9301)        ,
        BufferBinding = ((int)0x9302)        ,
        BufferDataSize = ((int)0x9303)        ,
        NumActiveVariables = ((int)0x9304)        ,
        ActiveVariables = ((int)0x9305)        ,
        ReferencedByVertexShader = ((int)0x9306)        ,
        ReferencedByTessControlShader = ((int)0x9307)        ,
        ReferencedByTessEvaluationShader = ((int)0x9308)        ,
        ReferencedByGeometryShader = ((int)0x9309)        ,
        ReferencedByFragmentShader = ((int)0x930A)        ,
        ReferencedByComputeShader = ((int)0x930B)        ,
        TopLevelArraySize = ((int)0x930C)        ,
        TopLevelArrayStride = ((int)0x930D)        ,
        Location = ((int)0x930E)        ,
        LocationIndex = ((int)0x930F)        ,
        FramebufferDefaultWidth = ((int)0x9310)        ,
        FramebufferDefaultHeight = ((int)0x9311)        ,
        FramebufferDefaultLayers = ((int)0x9312)        ,
        FramebufferDefaultSamples = ((int)0x9313)        ,
        FramebufferDefaultFixedSampleLocations = ((int)0x9314)        ,
        MaxFramebufferWidth = ((int)0x9315)        ,
        MaxFramebufferHeight = ((int)0x9316)        ,
        MaxFramebufferLayers = ((int)0x9317)        ,
        MaxFramebufferSamples = ((int)0x9318)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version44 : int
    {
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        MapReadBit = ((int)0x0001)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapPersistentBit = ((int)0x0040)        ,
        MapCoherentBit = ((int)0x0080)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        ClientStorageBit = ((int)0x0200)        ,
        StencilIndex = ((int)0x1901)        ,
        BufferImmutableStorage = ((int)0x821F)        ,
        BufferStorageFlags = ((int)0x8220)        ,
        PrimitiveRestartForPatchesSupported = ((int)0x8221)        ,
        MaxVertexAttribStride = ((int)0x82E5)        ,
        MirrorClampToEdge = ((int)0x8743)        ,
        TextureBufferBinding = ((int)0x8C2A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        StencilIndex8 = ((int)0x8D48)        ,
        QueryBuffer = ((int)0x9192)        ,
        QueryBufferBinding = ((int)0x9193)        ,
        QueryResultNoWait = ((int)0x9194)        ,
        LocationComponent = ((int)0x934A)        ,
        TransformFeedbackBufferIndex = ((int)0x934B)        ,
        TransformFeedbackBufferStride = ((int)0x934C)        ,
        ClearTexture = ((int)0x9365)        ,
    }

    /// <summary>
    /// Used in GL.VertexAttribLFormat, GL.VertexAttribLPointer
    /// </summary>
    public enum VertexAttribDoubleType : int
    {
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribDPointerType : int
    {
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Used in GL.VertexAttribIFormat, GL.VertexAttribIPointer
    /// </summary>
    public enum VertexAttribIntegerType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribIPointerType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttrib, GL.GetVertexAttribI and 1 other function
    /// </summary>
    public enum VertexAttribParameter : int
    {
        ArrayEnabled = ((int)0x8622)        ,
        ArraySize = ((int)0x8623)        ,
        ArrayStride = ((int)0x8624)        ,
        ArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        ArrayNormalized = ((int)0x886A)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
    }

    /// <summary>
    /// Used in GL.Arb.GetVertexAttribL
    /// </summary>
    public enum VertexAttribParameterArb : int
    {
        ArrayEnabled = ((int)0x8622)        ,
        ArraySize = ((int)0x8623)        ,
        ArrayStride = ((int)0x8624)        ,
        ArrayType = ((int)0x8625)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        ArrayNormalized = ((int)0x886A)        ,
        ArrayDivisor = ((int)0x88FE)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerParameter : int
    {
        ArrayPointer = ((int)0x8645)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribPointerParameterArb : int
    {
        ArrayPointer = ((int)0x8645)        ,
    }

    /// <summary>
    /// Used in GL.VertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
        Fixed = ((int)0x140C)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexAttribPointerTypeArb : int
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
    /// Used in GL.VertexAttribFormat
    /// </summary>
    public enum VertexAttribType : int
    {
        Byte = ((int)0x1400)        ,
        UnsignedByte = ((int)0x1401)        ,
        Short = ((int)0x1402)        ,
        UnsignedShort = ((int)0x1403)        ,
        Int = ((int)0x1404)        ,
        UnsignedInt = ((int)0x1405)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
        Fixed = ((int)0x140C)        ,
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
        HalfFloat = ((int)0x140B)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
    }

    /// <summary>
    /// Used in GL.FenceSync, GL.WaitSync
    /// </summary>
    public enum WaitSyncFlags : int
    {
        None = ((int)0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum WaitSyncStatus : int
    {
        AlreadySignaled = ((int)0x911A)        ,
        TimeoutExpired = ((int)0x911B)        ,
        ConditionSatisfied = ((int)0x911C)        ,
        WaitFailed = ((int)0x911D)        ,
    }

}
