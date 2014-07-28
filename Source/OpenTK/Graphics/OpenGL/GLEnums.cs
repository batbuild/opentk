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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Used in GL.Accum
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
    /// Used in GL.GetActiveAttrib, GL.GetTransformFeedbackVarying and 1 other function
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
        FloatMat3x2 = ((int)0x8B67)        ,
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
    /// Used in GL.Arb.GetProgramEnvParameter, GL.Arb.GetProgramLocalParameter and 9 other functions
    /// </summary>
    public enum All : int
    {
        False = ((int)0)        ,
        LayoutDefaultIntel = ((int)0)        ,
        NoError = ((int)0)        ,
        None = ((int)0)        ,
        NoneOes = ((int)0)        ,
        Zero = ((int)0)        ,
        ClosePathNv = ((int)0x00)        ,
        Points = ((int)0x0000)        ,
        ClientPixelStoreBit = ((int)0x00000001)        ,
        ContextCoreProfileBit = ((int)0x00000001)        ,
        ContextFlagForwardCompatibleBit = ((int)0x00000001)        ,
        CurrentBit = ((int)0x00000001)        ,
        Gl2XBitAti = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001
        /// </summary>
        QueryDepthPassEventBitAmd = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_RED_BIT_ATI = 0x00000001
        /// </summary>
        RedBitAti = ((int)0x00000001)        ,
        SyncFlushCommandsBit = ((int)0x00000001)        ,
        TextureDeformationBitSgix = ((int)0x00000001)        ,
        TextureStorageSparseBitAmd = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBit = ((int)0x00000001)        ,
        VertexAttribArrayBarrierBitExt = ((int)0x00000001)        ,
        VertexShaderBit = ((int)0x00000001)        ,
        VertexShaderBitExt = ((int)0x00000001)        ,
        ClientVertexArrayBit = ((int)0x00000002)        ,
        CompBitAti = ((int)0x00000002)        ,
        ContextCompatibilityProfileBit = ((int)0x00000002)        ,
        ContextFlagDebugBit = ((int)0x00000002)        ,
        ContextFlagDebugBitKhr = ((int)0x00000002)        ,
        ElementArrayBarrierBit = ((int)0x00000002)        ,
        ElementArrayBarrierBitExt = ((int)0x00000002)        ,
        FragmentShaderBit = ((int)0x00000002)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        GeometryDeformationBitSgix = ((int)0x00000002)        ,
        Gl4XBitAti = ((int)0x00000002)        ,
        GreenBitAti = ((int)0x00000002)        ,
        PointBit = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002
        /// </summary>
        QueryDepthFailEventBitAmd = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_BLUE_BIT_ATI = 0x00000004
        /// </summary>
        BlueBitAti = ((int)0x00000004)        ,
        ContextFlagRobustAccessBitArb = ((int)0x00000004)        ,
        GeometryShaderBit = ((int)0x00000004)        ,
        Gl8XBitAti = ((int)0x00000004)        ,
        LineBit = ((int)0x00000004)        ,
        NegateBitAti = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004
        /// </summary>
        QueryStencilFailEventBitAmd = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_UNIFORM_BARRIER_BIT = 0x00000004
        /// </summary>
        UniformBarrierBit = ((int)0x00000004)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
        Vertex23BitPgi = ((int)0x00000004)        ,
        BiasBitAti = ((int)0x00000008)        ,
        HalfBitAti = ((int)0x00000008)        ,
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
        Vertex4BitPgi = ((int)0x00000008)        ,
        PolygonStippleBit = ((int)0x00000010)        ,
        QuarterBitAti = ((int)0x00000010)        ,
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)        ,
        TessEvaluationShaderBit = ((int)0x00000010)        ,
        ComputeShaderBit = ((int)0x00000020)        ,
        EighthBitAti = ((int)0x00000020)        ,
        PixelModeBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBit = ((int)0x00000020)        ,
        ShaderImageAccessBarrierBitExt = ((int)0x00000020)        ,
        CommandBarrierBit = ((int)0x00000040)        ,
        CommandBarrierBitExt = ((int)0x00000040)        ,
        LightingBit = ((int)0x00000040)        ,
        SaturateBitAti = ((int)0x00000040)        ,
        FogBit = ((int)0x00000080)        ,
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
        ViewportBit = ((int)0x00000800)        ,
        AtomicCounterBarrierBit = ((int)0x00001000)        ,
        AtomicCounterBarrierBitExt = ((int)0x00001000)        ,
        TransformBit = ((int)0x00001000)        ,
        EnableBit = ((int)0x00002000)        ,
        ShaderStorageBarrierBit = ((int)0x00002000)        ,
        ClientMappedBufferBarrierBit = ((int)0x00004000)        ,
        ColorBufferBit = ((int)0x00004000)        ,
        CoverageBufferBitNv = ((int)0x00008000)        ,
        HintBit = ((int)0x00008000)        ,
        QueryBufferBarrierBit = ((int)0x00008000)        ,
        Lines = ((int)0x0001)        ,
        MapReadBit = ((int)0x0001)        ,
        MapReadBitExt = ((int)0x0001)        ,
        RestartSun = ((int)0x0001)        ,
        Color3BitPgi = ((int)0x00010000)        ,
        EvalBit = ((int)0x00010000)        ,
        FontXMinBoundsBitNv = ((int)0x00010000)        ,
        LineLoop = ((int)0x0002)        ,
        MapWriteBit = ((int)0x0002)        ,
        MapWriteBitExt = ((int)0x0002)        ,
        ReplaceMiddleSun = ((int)0x0002)        ,
        Color4BitPgi = ((int)0x00020000)        ,
        FontYMinBoundsBitNv = ((int)0x00020000)        ,
        ListBit = ((int)0x00020000)        ,
        LineStrip = ((int)0x0003)        ,
        ReplaceOldestSun = ((int)0x0003)        ,
        MapInvalidateRangeBit = ((int)0x0004)        ,
        MapInvalidateRangeBitExt = ((int)0x0004)        ,
        Triangles = ((int)0x0004)        ,
        EdgeflagBitPgi = ((int)0x00040000)        ,
        FontXMaxBoundsBitNv = ((int)0x00040000)        ,
        TextureBit = ((int)0x00040000)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Quads = ((int)0x0007)        ,
        MapInvalidateBufferBit = ((int)0x0008)        ,
        MapInvalidateBufferBitExt = ((int)0x0008)        ,
        QuadStrip = ((int)0x0008)        ,
        FontYMaxBoundsBitNv = ((int)0x00080000)        ,
        IndexBitPgi = ((int)0x00080000)        ,
        ScissorBit = ((int)0x00080000)        ,
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
        FontUnitsPerEmBitNv = ((int)0x00100000)        ,
        MatAmbientBitPgi = ((int)0x00100000)        ,
        MapUnsynchronizedBit = ((int)0x0020)        ,
        MapUnsynchronizedBitExt = ((int)0x0020)        ,
        FontAscenderBitNv = ((int)0x00200000)        ,
        MatAmbientAndDiffuseBitPgi = ((int)0x00200000)        ,
        MapPersistentBit = ((int)0x0040)        ,
        FontDescenderBitNv = ((int)0x00400000)        ,
        MatDiffuseBitPgi = ((int)0x00400000)        ,
        MapCoherentBit = ((int)0x0080)        ,
        FontHeightBitNv = ((int)0x00800000)        ,
        MatEmissionBitPgi = ((int)0x00800000)        ,
        BoldBitNv = ((int)0x01)        ,
        GlyphWidthBitNv = ((int)0x01)        ,
        Accum = ((int)0x0100)        ,
        DynamicStorageBit = ((int)0x0100)        ,
        FontMaxAdvanceWidthBitNv = ((int)0x01000000)        ,
        MatColorIndexesBitPgi = ((int)0x01000000)        ,
        Load = ((int)0x0101)        ,
        Return = ((int)0x0102)        ,
        Mult = ((int)0x0103)        ,
        Add = ((int)0x0104)        ,
        GlyphHeightBitNv = ((int)0x02)        ,
        ItalicBitNv = ((int)0x02)        ,
        MoveToNv = ((int)0x02)        ,
        ClientStorageBit = ((int)0x0200)        ,
        Never = ((int)0x0200)        ,
        FontMaxAdvanceHeightBitNv = ((int)0x02000000)        ,
        MatShininessBitPgi = ((int)0x02000000)        ,
        Less = ((int)0x0201)        ,
        Equal = ((int)0x0202)        ,
        Lequal = ((int)0x0203)        ,
        Greater = ((int)0x0204)        ,
        Notequal = ((int)0x0205)        ,
        Gequal = ((int)0x0206)        ,
        Always = ((int)0x0207)        ,
        RelativeMoveToNv = ((int)0x03)        ,
        SrcColor = ((int)0x0300)        ,
        OneMinusSrcColor = ((int)0x0301)        ,
        SrcAlpha = ((int)0x0302)        ,
        OneMinusSrcAlpha = ((int)0x0303)        ,
        DstAlpha = ((int)0x0304)        ,
        OneMinusDstAlpha = ((int)0x0305)        ,
        DstColor = ((int)0x0306)        ,
        OneMinusDstColor = ((int)0x0307)        ,
        SrcAlphaSaturate = ((int)0x0308)        ,
        GlyphHorizontalBearingXBitNv = ((int)0x04)        ,
        LineToNv = ((int)0x04)        ,
        FrontLeft = ((int)0x0400)        ,
        FontUnderlinePositionBitNv = ((int)0x04000000)        ,
        MatSpecularBitPgi = ((int)0x04000000)        ,
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
        RelativeLineToNv = ((int)0x05)        ,
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
        HorizontalLineToNv = ((int)0x06)        ,
        Gl2D = ((int)0x0600)        ,
        Gl3D = ((int)0x0601)        ,
        Gl3DColor = ((int)0x0602)        ,
        Gl3DColorTexture = ((int)0x0603)        ,
        Gl4DColorTexture = ((int)0x0604)        ,
        RelativeHorizontalLineToNv = ((int)0x07)        ,
        PassThroughToken = ((int)0x0700)        ,
        PointToken = ((int)0x0701)        ,
        LineToken = ((int)0x0702)        ,
        PolygonToken = ((int)0x0703)        ,
        BitmapToken = ((int)0x0704)        ,
        DrawPixelToken = ((int)0x0705)        ,
        CopyPixelToken = ((int)0x0706)        ,
        LineResetToken = ((int)0x0707)        ,
        GlyphHorizontalBearingYBitNv = ((int)0x08)        ,
        VerticalLineToNv = ((int)0x08)        ,
        Exp = ((int)0x0800)        ,
        FontUnderlineThicknessBitNv = ((int)0x08000000)        ,
        NormalBitPgi = ((int)0x08000000)        ,
        Exp2 = ((int)0x0801)        ,
        RelativeVerticalLineToNv = ((int)0x09)        ,
        Cw = ((int)0x0900)        ,
        Ccw = ((int)0x0901)        ,
        QuadraticCurveToNv = ((int)0x0A)        ,
        Coeff = ((int)0x0A00)        ,
        Order = ((int)0x0A01)        ,
        Domain = ((int)0x0A02)        ,
        RelativeQuadraticCurveToNv = ((int)0x0B)        ,
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
        CubicCurveToNv = ((int)0x0C)        ,
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
        RelativeCubicCurveToNv = ((int)0x0D)        ,
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
        SmoothQuadraticCurveToNv = ((int)0x0E)        ,
        RelativeSmoothQuadraticCurveToNv = ((int)0x0F)        ,
        GlyphHorizontalBearingAdvanceBitNv = ((int)0x10)        ,
        SmoothCubicCurveToNv = ((int)0x10)        ,
        GlyphHasKerningBitNv = ((int)0x100)        ,
        TextureWidth = ((int)0x1000)        ,
        FontHasKerningBitNv = ((int)0x10000000)        ,
        Texcoord1BitPgi = ((int)0x10000000)        ,
        TextureHeight = ((int)0x1001)        ,
        TextureComponents = ((int)0x1003)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
        TextureBorderColorNv = ((int)0x1004)        ,
        TextureBorder = ((int)0x1005)        ,
        RelativeSmoothCubicCurveToNv = ((int)0x11)        ,
        DontCare = ((int)0x1100)        ,
        Fastest = ((int)0x1101)        ,
        Nicest = ((int)0x1102)        ,
        SmallCcwArcToNv = ((int)0x12)        ,
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
        RelativeSmallCcwArcToNv = ((int)0x13)        ,
        Compile = ((int)0x1300)        ,
        CompileAndExecute = ((int)0x1301)        ,
        SmallCwArcToNv = ((int)0x14)        ,
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
        HalfApple = ((int)0x140B)        ,
        HalfFloat = ((int)0x140B)        ,
        HalfFloatArb = ((int)0x140B)        ,
        HalfFloatNv = ((int)0x140B)        ,
        Fixed = ((int)0x140C)        ,
        FixedOes = ((int)0x140C)        ,
        Int64Nv = ((int)0x140E)        ,
        UnsignedInt64Arb = ((int)0x140F)        ,
        UnsignedInt64Nv = ((int)0x140F)        ,
        RelativeSmallCwArcToNv = ((int)0x15)        ,
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
        Invert = ((int)0x150A)        ,
        OrReverse = ((int)0x150B)        ,
        CopyInverted = ((int)0x150C)        ,
        OrInverted = ((int)0x150D)        ,
        Nand = ((int)0x150E)        ,
        Set = ((int)0x150F)        ,
        LargeCcwArcToNv = ((int)0x16)        ,
        Emission = ((int)0x1600)        ,
        Shininess = ((int)0x1601)        ,
        AmbientAndDiffuse = ((int)0x1602)        ,
        ColorIndexes = ((int)0x1603)        ,
        RelativeLargeCcwArcToNv = ((int)0x17)        ,
        Modelview = ((int)0x1700)        ,
        Modelview0Arb = ((int)0x1700)        ,
        Modelview0Ext = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
        LargeCwArcToNv = ((int)0x18)        ,
        Color = ((int)0x1800)        ,
        ColorExt = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        DepthExt = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        StencilExt = ((int)0x1802)        ,
        RelativeLargeCwArcToNv = ((int)0x19)        ,
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
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        RasterPositionUnclippedIbm = ((int)0x19262)        ,
        Bitmap = ((int)0x1A00)        ,
        PreferDoublebufferHintPgi = ((int)0x1A1F8)        ,
        ConserveMemoryHintPgi = ((int)0x1A1FD)        ,
        ReclaimMemoryHintPgi = ((int)0x1A1FE)        ,
        NativeGraphicsHandlePgi = ((int)0x1A202)        ,
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
        GlyphVerticalBearingXBitNv = ((int)0x20)        ,
        S = ((int)0x2000)        ,
        MultisampleBit = ((int)0x20000000)        ,
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleBitExt = ((int)0x20000000)        ,
        Texcoord2BitPgi = ((int)0x20000000)        ,
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
        GlyphVerticalBearingYBitNv = ((int)0x40)        ,
        Light0 = ((int)0x4000)        ,
        Texcoord3BitPgi = ((int)0x40000000)        ,
        Light1 = ((int)0x4001)        ,
        Light2 = ((int)0x4002)        ,
        Light3 = ((int)0x4003)        ,
        Light4 = ((int)0x4004)        ,
        Light5 = ((int)0x4005)        ,
        Light6 = ((int)0x4006)        ,
        Light7 = ((int)0x4007)        ,
        GlyphVerticalBearingAdvanceBitNv = ((int)0x80)        ,
        AbgrExt = ((int)0x8000)        ,
        Texcoord4BitPgi = unchecked((int)0x80000000)        ,
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
        BlendEquationRgbExt = ((int)0x8009)        ,
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
        PolygonOffsetExt = ((int)0x8037)        ,
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
        PolygonOffsetFactorExt = ((int)0x8038)        ,
        PolygonOffsetBiasExt = ((int)0x8039)        ,
        RescaleNormal = ((int)0x803A)        ,
        RescaleNormalExt = ((int)0x803A)        ,
        Alpha4 = ((int)0x803B)        ,
        Alpha4Ext = ((int)0x803B)        ,
        Alpha8 = ((int)0x803C)        ,
        Alpha8Ext = ((int)0x803C)        ,
        Alpha12 = ((int)0x803D)        ,
        Alpha12Ext = ((int)0x803D)        ,
        Alpha16 = ((int)0x803E)        ,
        Alpha16Ext = ((int)0x803E)        ,
        Luminance4 = ((int)0x803F)        ,
        Luminance4Ext = ((int)0x803F)        ,
        Luminance8 = ((int)0x8040)        ,
        Luminance8Ext = ((int)0x8040)        ,
        Luminance12 = ((int)0x8041)        ,
        Luminance12Ext = ((int)0x8041)        ,
        Luminance16 = ((int)0x8042)        ,
        Luminance16Ext = ((int)0x8042)        ,
        Luminance4Alpha4 = ((int)0x8043)        ,
        Luminance4Alpha4Ext = ((int)0x8043)        ,
        Luminance6Alpha2 = ((int)0x8044)        ,
        Luminance6Alpha2Ext = ((int)0x8044)        ,
        Luminance8Alpha8 = ((int)0x8045)        ,
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        Luminance12Alpha4 = ((int)0x8046)        ,
        Luminance12Alpha4Ext = ((int)0x8046)        ,
        Luminance12Alpha12 = ((int)0x8047)        ,
        Luminance12Alpha12Ext = ((int)0x8047)        ,
        Luminance16Alpha16 = ((int)0x8048)        ,
        Luminance16Alpha16Ext = ((int)0x8048)        ,
        Intensity = ((int)0x8049)        ,
        IntensityExt = ((int)0x8049)        ,
        Intensity4 = ((int)0x804A)        ,
        Intensity4Ext = ((int)0x804A)        ,
        Intensity8 = ((int)0x804B)        ,
        Intensity8Ext = ((int)0x804B)        ,
        Intensity12 = ((int)0x804C)        ,
        Intensity12Ext = ((int)0x804C)        ,
        Intensity16 = ((int)0x804D)        ,
        Intensity16Ext = ((int)0x804D)        ,
        Rgb2Ext = ((int)0x804E)        ,
        Rgb4 = ((int)0x804F)        ,
        Rgb4Ext = ((int)0x804F)        ,
        Rgb5 = ((int)0x8050)        ,
        Rgb5Ext = ((int)0x8050)        ,
        Rgb8 = ((int)0x8051)        ,
        Rgb8Ext = ((int)0x8051)        ,
        Rgb10 = ((int)0x8052)        ,
        Rgb10Ext = ((int)0x8052)        ,
        Rgb12 = ((int)0x8053)        ,
        Rgb12Ext = ((int)0x8053)        ,
        Rgb16 = ((int)0x8054)        ,
        Rgb16Ext = ((int)0x8054)        ,
        Rgba2 = ((int)0x8055)        ,
        Rgba2Ext = ((int)0x8055)        ,
        Rgba4 = ((int)0x8056)        ,
        Rgba4Ext = ((int)0x8056)        ,
        Rgb5A1 = ((int)0x8057)        ,
        Rgb5A1Ext = ((int)0x8057)        ,
        Rgba8 = ((int)0x8058)        ,
        Rgba8Ext = ((int)0x8058)        ,
        Rgb10A2 = ((int)0x8059)        ,
        Rgb10A2Ext = ((int)0x8059)        ,
        Rgba12 = ((int)0x805A)        ,
        Rgba12Ext = ((int)0x805A)        ,
        Rgba16 = ((int)0x805B)        ,
        Rgba16Ext = ((int)0x805B)        ,
        TextureRedSize = ((int)0x805C)        ,
        TextureRedSizeExt = ((int)0x805C)        ,
        TextureGreenSize = ((int)0x805D)        ,
        TextureGreenSizeExt = ((int)0x805D)        ,
        TextureBlueSize = ((int)0x805E)        ,
        TextureBlueSizeExt = ((int)0x805E)        ,
        TextureAlphaSize = ((int)0x805F)        ,
        TextureAlphaSizeExt = ((int)0x805F)        ,
        TextureLuminanceSize = ((int)0x8060)        ,
        TextureLuminanceSizeExt = ((int)0x8060)        ,
        TextureIntensitySize = ((int)0x8061)        ,
        TextureIntensitySizeExt = ((int)0x8061)        ,
        ReplaceExt = ((int)0x8062)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture1DExt = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        ProxyTexture2DExt = ((int)0x8064)        ,
        TextureTooLargeExt = ((int)0x8065)        ,
        TexturePriority = ((int)0x8066)        ,
        TexturePriorityExt = ((int)0x8066)        ,
        TextureResident = ((int)0x8067)        ,
        TextureResidentExt = ((int)0x8067)        ,
        Texture1DBindingExt = ((int)0x8068)        ,
        TextureBinding1D = ((int)0x8068)        ,
        Texture2DBindingExt = ((int)0x8069)        ,
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
        VertexArrayExt = ((int)0x8074)        ,
        VertexArrayKhr = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        NormalArrayExt = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        ColorArrayExt = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        IndexArrayExt = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        TextureCoordArrayExt = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        EdgeFlagArrayExt = ((int)0x8079)        ,
        VertexArraySize = ((int)0x807A)        ,
        VertexArraySizeExt = ((int)0x807A)        ,
        VertexArrayType = ((int)0x807B)        ,
        VertexArrayTypeExt = ((int)0x807B)        ,
        VertexArrayStride = ((int)0x807C)        ,
        VertexArrayStrideExt = ((int)0x807C)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayType = ((int)0x807E)        ,
        NormalArrayTypeExt = ((int)0x807E)        ,
        NormalArrayStride = ((int)0x807F)        ,
        NormalArrayStrideExt = ((int)0x807F)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArraySize = ((int)0x8081)        ,
        ColorArraySizeExt = ((int)0x8081)        ,
        ColorArrayType = ((int)0x8082)        ,
        ColorArrayTypeExt = ((int)0x8082)        ,
        ColorArrayStride = ((int)0x8083)        ,
        ColorArrayStrideExt = ((int)0x8083)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayType = ((int)0x8085)        ,
        IndexArrayTypeExt = ((int)0x8085)        ,
        IndexArrayStride = ((int)0x8086)        ,
        IndexArrayStrideExt = ((int)0x8086)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArraySize = ((int)0x8088)        ,
        TextureCoordArraySizeExt = ((int)0x8088)        ,
        TextureCoordArrayType = ((int)0x8089)        ,
        TextureCoordArrayTypeExt = ((int)0x8089)        ,
        TextureCoordArrayStride = ((int)0x808A)        ,
        TextureCoordArrayStrideExt = ((int)0x808A)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayStride = ((int)0x808C)        ,
        EdgeFlagArrayStrideExt = ((int)0x808C)        ,
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
        MultisampleArb = ((int)0x809D)        ,
        MultisampleExt = ((int)0x809D)        ,
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToCoverage = ((int)0x809E)        ,
        SampleAlphaToCoverageArb = ((int)0x809E)        ,
        SampleAlphaToMaskExt = ((int)0x809E)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOne = ((int)0x809F)        ,
        SampleAlphaToOneArb = ((int)0x809F)        ,
        SampleAlphaToOneExt = ((int)0x809F)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleCoverage = ((int)0x80A0)        ,
        SampleCoverageArb = ((int)0x80A0)        ,
        SampleMaskExt = ((int)0x80A0)        ,
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
        SampleBuffersArb = ((int)0x80A8)        ,
        SampleBuffersExt = ((int)0x80A8)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        Samples = ((int)0x80A9)        ,
        SamplesArb = ((int)0x80A9)        ,
        SamplesExt = ((int)0x80A9)        ,
        SamplesSgis = ((int)0x80A9)        ,
        SampleCoverageValue = ((int)0x80AA)        ,
        SampleCoverageValueArb = ((int)0x80AA)        ,
        SampleMaskValueExt = ((int)0x80AA)        ,
        SampleMaskValueSgis = ((int)0x80AA)        ,
        SampleCoverageInvert = ((int)0x80AB)        ,
        SampleCoverageInvertArb = ((int)0x80AB)        ,
        SampleMaskInvertExt = ((int)0x80AB)        ,
        SampleMaskInvertSgis = ((int)0x80AB)        ,
        SamplePatternExt = ((int)0x80AC)        ,
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
        TextureCompareFailValueArb = ((int)0x80BF)        ,
        BlendDstRgb = ((int)0x80C8)        ,
        BlendDstRgbExt = ((int)0x80C8)        ,
        BlendSrcRgb = ((int)0x80C9)        ,
        BlendSrcRgbExt = ((int)0x80C9)        ,
        BlendDstAlpha = ((int)0x80CA)        ,
        BlendDstAlphaExt = ((int)0x80CA)        ,
        BlendSrcAlpha = ((int)0x80CB)        ,
        BlendSrcAlphaExt = ((int)0x80CB)        ,
        Gl422Ext = ((int)0x80CC)        ,
        Gl422RevExt = ((int)0x80CD)        ,
        Gl422AverageExt = ((int)0x80CE)        ,
        Gl422RevAverageExt = ((int)0x80CF)        ,
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
        BgrExt = ((int)0x80E0)        ,
        Bgra = ((int)0x80E1)        ,
        BgraExt = ((int)0x80E1)        ,
        ColorIndex1Ext = ((int)0x80E2)        ,
        ColorIndex2Ext = ((int)0x80E3)        ,
        ColorIndex4Ext = ((int)0x80E4)        ,
        ColorIndex8Ext = ((int)0x80E5)        ,
        ColorIndex12Ext = ((int)0x80E6)        ,
        ColorIndex16Ext = ((int)0x80E7)        ,
        MaxElementsVertices = ((int)0x80E8)        ,
        MaxElementsVerticesExt = ((int)0x80E8)        ,
        MaxElementsIndices = ((int)0x80E9)        ,
        MaxElementsIndicesExt = ((int)0x80E9)        ,
        PhongWin = ((int)0x80EA)        ,
        PhongHintWin = ((int)0x80EB)        ,
        FogSpecularTextureWin = ((int)0x80EC)        ,
        TextureIndexSizeExt = ((int)0x80ED)        ,
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
        SpriteAxialSgix = ((int)0x814C)        ,
        SpriteObjectAlignedSgix = ((int)0x814D)        ,
        SpriteEyeAlignedSgix = ((int)0x814E)        ,
        Texture4DBindingSgis = ((int)0x814F)        ,
        IgnoreBorderHp = ((int)0x8150)        ,
        ConstantBorder = ((int)0x8151)        ,
        ConstantBorderHp = ((int)0x8151)        ,
        ReplicateBorder = ((int)0x8153)        ,
        ReplicateBorderHp = ((int)0x8153)        ,
        ConvolutionBorderColor = ((int)0x8154)        ,
        ConvolutionBorderColorHp = ((int)0x8154)        ,
        ImageScaleXHp = ((int)0x8155)        ,
        ImageScaleYHp = ((int)0x8156)        ,
        ImageTranslateXHp = ((int)0x8157)        ,
        ImageTranslateYHp = ((int)0x8158)        ,
        ImageRotateAngleHp = ((int)0x8159)        ,
        ImageRotateOriginXHp = ((int)0x815A)        ,
        ImageRotateOriginYHp = ((int)0x815B)        ,
        ImageMagFilterHp = ((int)0x815C)        ,
        ImageMinFilterHp = ((int)0x815D)        ,
        ImageCubicWeightHp = ((int)0x815E)        ,
        CubicHp = ((int)0x815F)        ,
        AverageHp = ((int)0x8160)        ,
        ImageTransform2DHp = ((int)0x8161)        ,
        PostImageTransformColorTableHp = ((int)0x8162)        ,
        ProxyPostImageTransformColorTableHp = ((int)0x8163)        ,
        OcclusionTestHp = ((int)0x8165)        ,
        OcclusionTestResultHp = ((int)0x8166)        ,
        TextureLightingModeHp = ((int)0x8167)        ,
        TexturePostSpecularHp = ((int)0x8168)        ,
        TexturePreSpecularHp = ((int)0x8169)        ,
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
        MaxDeformationOrderSgix = ((int)0x8197)        ,
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
        TextureCompareSgix = ((int)0x819A)        ,
        TextureCompareOperatorSgix = ((int)0x819B)        ,
        TextureLequalRSgix = ((int)0x819C)        ,
        TextureGequalRSgix = ((int)0x819D)        ,
        DepthComponent16 = ((int)0x81A5)        ,
        DepthComponent16Arb = ((int)0x81A5)        ,
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81A6)        ,
        DepthComponent24Arb = ((int)0x81A6)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32 = ((int)0x81A7)        ,
        DepthComponent32Arb = ((int)0x81A7)        ,
        DepthComponent32Sgix = ((int)0x81A7)        ,
        ArrayElementLockFirstExt = ((int)0x81A8)        ,
        ArrayElementLockCountExt = ((int)0x81A9)        ,
        CullVertexExt = ((int)0x81AA)        ,
        CullVertexEyePositionExt = ((int)0x81AB)        ,
        CullVertexObjectPositionExt = ((int)0x81AC)        ,
        IuiV2fExt = ((int)0x81AD)        ,
        IuiV3fExt = ((int)0x81AE)        ,
        IuiN3fV2fExt = ((int)0x81AF)        ,
        IuiN3fV3fExt = ((int)0x81B0)        ,
        T2fIuiV2fExt = ((int)0x81B1)        ,
        T2fIuiV3fExt = ((int)0x81B2)        ,
        T2fIuiN3fV2fExt = ((int)0x81B3)        ,
        T2fIuiN3fV3fExt = ((int)0x81B4)        ,
        IndexTestExt = ((int)0x81B5)        ,
        IndexTestFuncExt = ((int)0x81B6)        ,
        IndexTestRefExt = ((int)0x81B7)        ,
        IndexMaterialExt = ((int)0x81B8)        ,
        IndexMaterialParameterExt = ((int)0x81B9)        ,
        IndexMaterialFaceExt = ((int)0x81BA)        ,
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
        WrapBorderSun = ((int)0x81D4)        ,
        UnpackConstantDataSunx = ((int)0x81D5)        ,
        TextureConstantDataSunx = ((int)0x81D6)        ,
        TriangleListSun = ((int)0x81D7)        ,
        ReplacementCodeSun = ((int)0x81D8)        ,
        GlobalAlphaSun = ((int)0x81D9)        ,
        GlobalAlphaFactorSun = ((int)0x81DA)        ,
        TextureColorWritemaskSgis = ((int)0x81EF)        ,
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
        TextFragmentShaderAti = ((int)0x8200)        ,
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
        ProgramSeparableExt = ((int)0x8258)        ,
        ActiveProgram = ((int)0x8259)        ,
        ProgramPipelineBinding = ((int)0x825A)        ,
        ProgramPipelineBindingExt = ((int)0x825A)        ,
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
        YcrcbSgix = ((int)0x8318)        ,
        YcrcbaSgix = ((int)0x8319)        ,
        AlphaMinSgix = ((int)0x8320)        ,
        AlphaMaxSgix = ((int)0x8321)        ,
        ScalebiasHintSgix = ((int)0x8322)        ,
        AsyncMarkerSgix = ((int)0x8329)        ,
        PixelTexGenModeSgix = ((int)0x832B)        ,
        AsyncHistogramSgix = ((int)0x832C)        ,
        MaxAsyncHistogramSgix = ((int)0x832D)        ,
        PixelTransform2DExt = ((int)0x8330)        ,
        PixelMagFilterExt = ((int)0x8331)        ,
        PixelMinFilterExt = ((int)0x8332)        ,
        PixelCubicWeightExt = ((int)0x8333)        ,
        CubicExt = ((int)0x8334)        ,
        AverageExt = ((int)0x8335)        ,
        PixelTransform2DStackDepthExt = ((int)0x8336)        ,
        MaxPixelTransform2DStackDepthExt = ((int)0x8337)        ,
        PixelTransform2DMatrixExt = ((int)0x8338)        ,
        FragmentMaterialExt = ((int)0x8349)        ,
        FragmentNormalExt = ((int)0x834A)        ,
        FragmentColorExt = ((int)0x834C)        ,
        AttenuationExt = ((int)0x834D)        ,
        ShadowAttenuationExt = ((int)0x834E)        ,
        TextureApplicationModeExt = ((int)0x834F)        ,
        TextureLightExt = ((int)0x8350)        ,
        TextureMaterialFaceExt = ((int)0x8351)        ,
        TextureMaterialParameterExt = ((int)0x8352)        ,
        PixelTextureSgis = ((int)0x8353)        ,
        PixelFragmentRgbSourceSgis = ((int)0x8354)        ,
        PixelFragmentAlphaSourceSgis = ((int)0x8355)        ,
        PixelGroupColorSgis = ((int)0x8356)        ,
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
        MirroredRepeatArb = ((int)0x8370)        ,
        MirroredRepeatIbm = ((int)0x8370)        ,
        RgbS3tc = ((int)0x83A0)        ,
        Rgb4S3tc = ((int)0x83A1)        ,
        RgbaS3tc = ((int)0x83A2)        ,
        Rgba4S3tc = ((int)0x83A3)        ,
        RgbaDxt5S3tc = ((int)0x83A4)        ,
        Rgba4Dxt5S3tc = ((int)0x83A5)        ,
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2)        ,
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3)        ,
        ParallelArraysIntel = ((int)0x83F4)        ,
        VertexArrayParallelPointersIntel = ((int)0x83F5)        ,
        NormalArrayParallelPointersIntel = ((int)0x83F6)        ,
        ColorArrayParallelPointersIntel = ((int)0x83F7)        ,
        TextureCoordArrayParallelPointersIntel = ((int)0x83F8)        ,
        TextureMemoryLayoutIntel = ((int)0x83FF)        ,
        FragmentLightingSgix = ((int)0x8400)        ,
        FragmentColorMaterialSgix = ((int)0x8401)        ,
        FragmentColorMaterialFaceSgix = ((int)0x8402)        ,
        FragmentColorMaterialParameterSgix = ((int)0x8403)        ,
        MaxFragmentLightsSgix = ((int)0x8404)        ,
        MaxActiveLightsSgix = ((int)0x8405)        ,
        CurrentRasterNormalSgix = ((int)0x8406)        ,
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
        TangentArrayExt = ((int)0x8439)        ,
        BinormalArrayExt = ((int)0x843A)        ,
        CurrentTangentExt = ((int)0x843B)        ,
        CurrentBinormalExt = ((int)0x843C)        ,
        TangentArrayTypeExt = ((int)0x843E)        ,
        TangentArrayStrideExt = ((int)0x843F)        ,
        BinormalArrayTypeExt = ((int)0x8440)        ,
        BinormalArrayStrideExt = ((int)0x8441)        ,
        TangentArrayPointerExt = ((int)0x8442)        ,
        BinormalArrayPointerExt = ((int)0x8443)        ,
        Map1TangentExt = ((int)0x8444)        ,
        Map2TangentExt = ((int)0x8445)        ,
        Map1BinormalExt = ((int)0x8446)        ,
        Map2BinormalExt = ((int)0x8447)        ,
        NearestClipmapNearestSgix = ((int)0x844D)        ,
        NearestClipmapLinearSgix = ((int)0x844E)        ,
        LinearClipmapNearestSgix = ((int)0x844F)        ,
        FogCoordinateSource = ((int)0x8450)        ,
        FogCoordinateSourceExt = ((int)0x8450)        ,
        FogCoordSrc = ((int)0x8450)        ,
        FogCoord = ((int)0x8451)        ,
        FogCoordinate = ((int)0x8451)        ,
        FogCoordinateExt = ((int)0x8451)        ,
        FragmentDepth = ((int)0x8452)        ,
        FragmentDepthExt = ((int)0x8452)        ,
        CurrentFogCoord = ((int)0x8453)        ,
        CurrentFogCoordinate = ((int)0x8453)        ,
        CurrentFogCoordinateExt = ((int)0x8453)        ,
        FogCoordArrayType = ((int)0x8454)        ,
        FogCoordinateArrayType = ((int)0x8454)        ,
        FogCoordinateArrayTypeExt = ((int)0x8454)        ,
        FogCoordArrayStride = ((int)0x8455)        ,
        FogCoordinateArrayStride = ((int)0x8455)        ,
        FogCoordinateArrayStrideExt = ((int)0x8455)        ,
        FogCoordArrayPointer = ((int)0x8456)        ,
        FogCoordinateArrayPointer = ((int)0x8456)        ,
        FogCoordinateArrayPointerExt = ((int)0x8456)        ,
        FogCoordArray = ((int)0x8457)        ,
        FogCoordinateArray = ((int)0x8457)        ,
        FogCoordinateArrayExt = ((int)0x8457)        ,
        ColorSum = ((int)0x8458)        ,
        ColorSumArb = ((int)0x8458)        ,
        ColorSumExt = ((int)0x8458)        ,
        CurrentSecondaryColor = ((int)0x8459)        ,
        CurrentSecondaryColorExt = ((int)0x8459)        ,
        SecondaryColorArraySize = ((int)0x845A)        ,
        SecondaryColorArraySizeExt = ((int)0x845A)        ,
        SecondaryColorArrayType = ((int)0x845B)        ,
        SecondaryColorArrayTypeExt = ((int)0x845B)        ,
        SecondaryColorArrayStride = ((int)0x845C)        ,
        SecondaryColorArrayStrideExt = ((int)0x845C)        ,
        SecondaryColorArrayPointer = ((int)0x845D)        ,
        SecondaryColorArrayPointerExt = ((int)0x845D)        ,
        SecondaryColorArray = ((int)0x845E)        ,
        SecondaryColorArrayExt = ((int)0x845E)        ,
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
        ScreenCoordinatesRend = ((int)0x8490)        ,
        InvertedScreenWRend = ((int)0x8491)        ,
        Texture0 = ((int)0x84C0)        ,
        Texture0Arb = ((int)0x84C0)        ,
        Texture1 = ((int)0x84C1)        ,
        Texture1Arb = ((int)0x84C1)        ,
        Texture2 = ((int)0x84C2)        ,
        Texture2Arb = ((int)0x84C2)        ,
        Texture3 = ((int)0x84C3)        ,
        Texture3Arb = ((int)0x84C3)        ,
        Texture4 = ((int)0x84C4)        ,
        Texture4Arb = ((int)0x84C4)        ,
        Texture5 = ((int)0x84C5)        ,
        Texture5Arb = ((int)0x84C5)        ,
        Texture6 = ((int)0x84C6)        ,
        Texture6Arb = ((int)0x84C6)        ,
        Texture7 = ((int)0x84C7)        ,
        Texture7Arb = ((int)0x84C7)        ,
        Texture8 = ((int)0x84C8)        ,
        Texture8Arb = ((int)0x84C8)        ,
        Texture9 = ((int)0x84C9)        ,
        Texture9Arb = ((int)0x84C9)        ,
        Texture10 = ((int)0x84CA)        ,
        Texture10Arb = ((int)0x84CA)        ,
        Texture11 = ((int)0x84CB)        ,
        Texture11Arb = ((int)0x84CB)        ,
        Texture12 = ((int)0x84CC)        ,
        Texture12Arb = ((int)0x84CC)        ,
        Texture13 = ((int)0x84CD)        ,
        Texture13Arb = ((int)0x84CD)        ,
        Texture14 = ((int)0x84CE)        ,
        Texture14Arb = ((int)0x84CE)        ,
        Texture15 = ((int)0x84CF)        ,
        Texture15Arb = ((int)0x84CF)        ,
        Texture16 = ((int)0x84D0)        ,
        Texture16Arb = ((int)0x84D0)        ,
        Texture17 = ((int)0x84D1)        ,
        Texture17Arb = ((int)0x84D1)        ,
        Texture18 = ((int)0x84D2)        ,
        Texture18Arb = ((int)0x84D2)        ,
        Texture19 = ((int)0x84D3)        ,
        Texture19Arb = ((int)0x84D3)        ,
        Texture20 = ((int)0x84D4)        ,
        Texture20Arb = ((int)0x84D4)        ,
        Texture21 = ((int)0x84D5)        ,
        Texture21Arb = ((int)0x84D5)        ,
        Texture22 = ((int)0x84D6)        ,
        Texture22Arb = ((int)0x84D6)        ,
        Texture23 = ((int)0x84D7)        ,
        Texture23Arb = ((int)0x84D7)        ,
        Texture24 = ((int)0x84D8)        ,
        Texture24Arb = ((int)0x84D8)        ,
        Texture25 = ((int)0x84D9)        ,
        Texture25Arb = ((int)0x84D9)        ,
        Texture26 = ((int)0x84DA)        ,
        Texture26Arb = ((int)0x84DA)        ,
        Texture27 = ((int)0x84DB)        ,
        Texture27Arb = ((int)0x84DB)        ,
        Texture28 = ((int)0x84DC)        ,
        Texture28Arb = ((int)0x84DC)        ,
        Texture29 = ((int)0x84DD)        ,
        Texture29Arb = ((int)0x84DD)        ,
        Texture30 = ((int)0x84DE)        ,
        Texture30Arb = ((int)0x84DE)        ,
        Texture31 = ((int)0x84DF)        ,
        Texture31Arb = ((int)0x84DF)        ,
        ActiveTexture = ((int)0x84E0)        ,
        ActiveTextureArb = ((int)0x84E0)        ,
        ClientActiveTexture = ((int)0x84E1)        ,
        ClientActiveTextureArb = ((int)0x84E1)        ,
        MaxTextureUnits = ((int)0x84E2)        ,
        MaxTextureUnitsArb = ((int)0x84E2)        ,
        TransposeModelviewMatrix = ((int)0x84E3)        ,
        TransposeModelviewMatrixArb = ((int)0x84E3)        ,
        TransposeProjectionMatrix = ((int)0x84E4)        ,
        TransposeProjectionMatrixArb = ((int)0x84E4)        ,
        TransposeTextureMatrix = ((int)0x84E5)        ,
        TransposeTextureMatrixArb = ((int)0x84E5)        ,
        TransposeColorMatrix = ((int)0x84E6)        ,
        TransposeColorMatrixArb = ((int)0x84E6)        ,
        Subtract = ((int)0x84E7)        ,
        SubtractArb = ((int)0x84E7)        ,
        MaxRenderbufferSize = ((int)0x84E8)        ,
        MaxRenderbufferSizeExt = ((int)0x84E8)        ,
        CompressedAlpha = ((int)0x84E9)        ,
        CompressedAlphaArb = ((int)0x84E9)        ,
        CompressedLuminance = ((int)0x84EA)        ,
        CompressedLuminanceArb = ((int)0x84EA)        ,
        CompressedLuminanceAlpha = ((int)0x84EB)        ,
        CompressedLuminanceAlphaArb = ((int)0x84EB)        ,
        CompressedIntensity = ((int)0x84EC)        ,
        CompressedIntensityArb = ((int)0x84EC)        ,
        CompressedRgb = ((int)0x84ED)        ,
        CompressedRgbArb = ((int)0x84ED)        ,
        CompressedRgba = ((int)0x84EE)        ,
        CompressedRgbaArb = ((int)0x84EE)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        UniformBlockReferencedByTessControlShader = ((int)0x84F0)        ,
        UniformBlockReferencedByTessEvaluationShader = ((int)0x84F1)        ,
        AllCompletedNv = ((int)0x84F2)        ,
        FenceStatusNv = ((int)0x84F3)        ,
        FenceConditionNv = ((int)0x84F4)        ,
        TextureRectangle = ((int)0x84F5)        ,
        TextureRectangleArb = ((int)0x84F5)        ,
        TextureRectangleNv = ((int)0x84F5)        ,
        TextureBindingRectangle = ((int)0x84F6)        ,
        TextureBindingRectangleArb = ((int)0x84F6)        ,
        TextureBindingRectangleNv = ((int)0x84F6)        ,
        ProxyTextureRectangle = ((int)0x84F7)        ,
        ProxyTextureRectangleArb = ((int)0x84F7)        ,
        ProxyTextureRectangleNv = ((int)0x84F7)        ,
        MaxRectangleTextureSize = ((int)0x84F8)        ,
        MaxRectangleTextureSizeArb = ((int)0x84F8)        ,
        MaxRectangleTextureSizeNv = ((int)0x84F8)        ,
        DepthStencil = ((int)0x84F9)        ,
        DepthStencilExt = ((int)0x84F9)        ,
        DepthStencilNv = ((int)0x84F9)        ,
        UnsignedInt248 = ((int)0x84FA)        ,
        UnsignedInt248Ext = ((int)0x84FA)        ,
        UnsignedInt248Nv = ((int)0x84FA)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        MaxTextureLodBiasExt = ((int)0x84FD)        ,
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        TextureFilterControl = ((int)0x8500)        ,
        TextureFilterControlExt = ((int)0x8500)        ,
        TextureLodBias = ((int)0x8501)        ,
        TextureLodBiasExt = ((int)0x8501)        ,
        Modelview1StackDepthExt = ((int)0x8502)        ,
        Combine4Nv = ((int)0x8503)        ,
        MaxShininessNv = ((int)0x8504)        ,
        MaxSpotExponentNv = ((int)0x8505)        ,
        Modelview1MatrixExt = ((int)0x8506)        ,
        IncrWrap = ((int)0x8507)        ,
        IncrWrapExt = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        DecrWrapExt = ((int)0x8508)        ,
        VertexWeightingExt = ((int)0x8509)        ,
        Modelview1Arb = ((int)0x850A)        ,
        Modelview1Ext = ((int)0x850A)        ,
        CurrentVertexWeightExt = ((int)0x850B)        ,
        VertexWeightArrayExt = ((int)0x850C)        ,
        VertexWeightArraySizeExt = ((int)0x850D)        ,
        VertexWeightArrayTypeExt = ((int)0x850E)        ,
        VertexWeightArrayStrideExt = ((int)0x850F)        ,
        VertexWeightArrayPointerExt = ((int)0x8510)        ,
        NormalMap = ((int)0x8511)        ,
        NormalMapArb = ((int)0x8511)        ,
        NormalMapExt = ((int)0x8511)        ,
        NormalMapNv = ((int)0x8511)        ,
        ReflectionMap = ((int)0x8512)        ,
        ReflectionMapArb = ((int)0x8512)        ,
        ReflectionMapExt = ((int)0x8512)        ,
        ReflectionMapNv = ((int)0x8512)        ,
        TextureCubeMap = ((int)0x8513)        ,
        TextureCubeMapArb = ((int)0x8513)        ,
        TextureCubeMapExt = ((int)0x8513)        ,
        TextureBindingCubeMap = ((int)0x8514)        ,
        TextureBindingCubeMapArb = ((int)0x8514)        ,
        TextureBindingCubeMapExt = ((int)0x8514)        ,
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        TextureCubeMapPositiveXArb = ((int)0x8515)        ,
        TextureCubeMapPositiveXExt = ((int)0x8515)        ,
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        TextureCubeMapNegativeXArb = ((int)0x8516)        ,
        TextureCubeMapNegativeXExt = ((int)0x8516)        ,
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        TextureCubeMapPositiveYArb = ((int)0x8517)        ,
        TextureCubeMapPositiveYExt = ((int)0x8517)        ,
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        TextureCubeMapNegativeYArb = ((int)0x8518)        ,
        TextureCubeMapNegativeYExt = ((int)0x8518)        ,
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        TextureCubeMapPositiveZArb = ((int)0x8519)        ,
        TextureCubeMapPositiveZExt = ((int)0x8519)        ,
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        TextureCubeMapNegativeZArb = ((int)0x851A)        ,
        TextureCubeMapNegativeZExt = ((int)0x851A)        ,
        ProxyTextureCubeMap = ((int)0x851B)        ,
        ProxyTextureCubeMapArb = ((int)0x851B)        ,
        ProxyTextureCubeMapExt = ((int)0x851B)        ,
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        MaxCubeMapTextureSizeArb = ((int)0x851C)        ,
        MaxCubeMapTextureSizeExt = ((int)0x851C)        ,
        VertexArrayRangeApple = ((int)0x851D)        ,
        VertexArrayRangeNv = ((int)0x851D)        ,
        VertexArrayRangeLengthApple = ((int)0x851E)        ,
        VertexArrayRangeLengthNv = ((int)0x851E)        ,
        VertexArrayRangeValidNv = ((int)0x851F)        ,
        VertexArrayStorageHintApple = ((int)0x851F)        ,
        MaxVertexArrayRangeElementNv = ((int)0x8520)        ,
        VertexArrayRangePointerApple = ((int)0x8521)        ,
        VertexArrayRangePointerNv = ((int)0x8521)        ,
        RegisterCombinersNv = ((int)0x8522)        ,
        VariableANv = ((int)0x8523)        ,
        VariableBNv = ((int)0x8524)        ,
        VariableCNv = ((int)0x8525)        ,
        VariableDNv = ((int)0x8526)        ,
        VariableENv = ((int)0x8527)        ,
        VariableFNv = ((int)0x8528)        ,
        VariableGNv = ((int)0x8529)        ,
        ConstantColor0Nv = ((int)0x852A)        ,
        ConstantColor1Nv = ((int)0x852B)        ,
        PrimaryColorNv = ((int)0x852C)        ,
        SecondaryColorNv = ((int)0x852D)        ,
        Spare0Nv = ((int)0x852E)        ,
        Spare1Nv = ((int)0x852F)        ,
        DiscardNv = ((int)0x8530)        ,
        ETimesFNv = ((int)0x8531)        ,
        Spare0PlusSecondaryColorNv = ((int)0x8532)        ,
        VertexArrayRangeWithoutFlushNv = ((int)0x8533)        ,
        MultisampleFilterHintNv = ((int)0x8534)        ,
        PerStageConstantsNv = ((int)0x8535)        ,
        UnsignedIdentityNv = ((int)0x8536)        ,
        UnsignedInvertNv = ((int)0x8537)        ,
        ExpandNormalNv = ((int)0x8538)        ,
        ExpandNegateNv = ((int)0x8539)        ,
        HalfBiasNormalNv = ((int)0x853A)        ,
        HalfBiasNegateNv = ((int)0x853B)        ,
        SignedIdentityNv = ((int)0x853C)        ,
        SignedNegateNv = ((int)0x853D)        ,
        ScaleByTwoNv = ((int)0x853E)        ,
        ScaleByFourNv = ((int)0x853F)        ,
        ScaleByOneHalfNv = ((int)0x8540)        ,
        BiasByNegativeOneHalfNv = ((int)0x8541)        ,
        CombinerInputNv = ((int)0x8542)        ,
        CombinerMappingNv = ((int)0x8543)        ,
        CombinerComponentUsageNv = ((int)0x8544)        ,
        CombinerAbDotProductNv = ((int)0x8545)        ,
        CombinerCdDotProductNv = ((int)0x8546)        ,
        CombinerMuxSumNv = ((int)0x8547)        ,
        CombinerScaleNv = ((int)0x8548)        ,
        CombinerBiasNv = ((int)0x8549)        ,
        CombinerAbOutputNv = ((int)0x854A)        ,
        CombinerCdOutputNv = ((int)0x854B)        ,
        CombinerSumOutputNv = ((int)0x854C)        ,
        MaxGeneralCombinersNv = ((int)0x854D)        ,
        NumGeneralCombinersNv = ((int)0x854E)        ,
        ColorSumClampNv = ((int)0x854F)        ,
        Combiner0Nv = ((int)0x8550)        ,
        Combiner1Nv = ((int)0x8551)        ,
        Combiner2Nv = ((int)0x8552)        ,
        Combiner3Nv = ((int)0x8553)        ,
        Combiner4Nv = ((int)0x8554)        ,
        Combiner5Nv = ((int)0x8555)        ,
        Combiner6Nv = ((int)0x8556)        ,
        Combiner7Nv = ((int)0x8557)        ,
        PrimitiveRestartNv = ((int)0x8558)        ,
        PrimitiveRestartIndexNv = ((int)0x8559)        ,
        FogDistanceModeNv = ((int)0x855A)        ,
        EyeRadialNv = ((int)0x855B)        ,
        EyePlaneAbsoluteNv = ((int)0x855C)        ,
        EmbossLightNv = ((int)0x855D)        ,
        EmbossConstantNv = ((int)0x855E)        ,
        EmbossMapNv = ((int)0x855F)        ,
        RedMinClampIngr = ((int)0x8560)        ,
        GreenMinClampIngr = ((int)0x8561)        ,
        BlueMinClampIngr = ((int)0x8562)        ,
        AlphaMinClampIngr = ((int)0x8563)        ,
        RedMaxClampIngr = ((int)0x8564)        ,
        GreenMaxClampIngr = ((int)0x8565)        ,
        BlueMaxClampIngr = ((int)0x8566)        ,
        AlphaMaxClampIngr = ((int)0x8567)        ,
        InterlaceReadIngr = ((int)0x8568)        ,
        Combine = ((int)0x8570)        ,
        CombineArb = ((int)0x8570)        ,
        CombineExt = ((int)0x8570)        ,
        CombineRgb = ((int)0x8571)        ,
        CombineRgbArb = ((int)0x8571)        ,
        CombineRgbExt = ((int)0x8571)        ,
        CombineAlpha = ((int)0x8572)        ,
        CombineAlphaArb = ((int)0x8572)        ,
        CombineAlphaExt = ((int)0x8572)        ,
        RgbScale = ((int)0x8573)        ,
        RgbScaleArb = ((int)0x8573)        ,
        RgbScaleExt = ((int)0x8573)        ,
        AddSigned = ((int)0x8574)        ,
        AddSignedArb = ((int)0x8574)        ,
        AddSignedExt = ((int)0x8574)        ,
        Interpolate = ((int)0x8575)        ,
        InterpolateArb = ((int)0x8575)        ,
        InterpolateExt = ((int)0x8575)        ,
        Constant = ((int)0x8576)        ,
        ConstantArb = ((int)0x8576)        ,
        ConstantExt = ((int)0x8576)        ,
        PrimaryColor = ((int)0x8577)        ,
        PrimaryColorArb = ((int)0x8577)        ,
        PrimaryColorExt = ((int)0x8577)        ,
        Previous = ((int)0x8578)        ,
        PreviousArb = ((int)0x8578)        ,
        PreviousExt = ((int)0x8578)        ,
        Source0Rgb = ((int)0x8580)        ,
        Source0RgbArb = ((int)0x8580)        ,
        Source0RgbExt = ((int)0x8580)        ,
        Src0Rgb = ((int)0x8580)        ,
        Source1Rgb = ((int)0x8581)        ,
        Source1RgbArb = ((int)0x8581)        ,
        Source1RgbExt = ((int)0x8581)        ,
        Src1Rgb = ((int)0x8581)        ,
        Source2Rgb = ((int)0x8582)        ,
        Source2RgbArb = ((int)0x8582)        ,
        Source2RgbExt = ((int)0x8582)        ,
        Src2Rgb = ((int)0x8582)        ,
        Source3RgbNv = ((int)0x8583)        ,
        Source0Alpha = ((int)0x8588)        ,
        Source0AlphaArb = ((int)0x8588)        ,
        Source0AlphaExt = ((int)0x8588)        ,
        Src0Alpha = ((int)0x8588)        ,
        Source1Alpha = ((int)0x8589)        ,
        Source1AlphaArb = ((int)0x8589)        ,
        Source1AlphaExt = ((int)0x8589)        ,
        Src1Alpha = ((int)0x8589)        ,
        Source2Alpha = ((int)0x858A)        ,
        Source2AlphaArb = ((int)0x858A)        ,
        Source2AlphaExt = ((int)0x858A)        ,
        Src2Alpha = ((int)0x858A)        ,
        Source3AlphaNv = ((int)0x858B)        ,
        Operand0Rgb = ((int)0x8590)        ,
        Operand0RgbArb = ((int)0x8590)        ,
        Operand0RgbExt = ((int)0x8590)        ,
        Operand1Rgb = ((int)0x8591)        ,
        Operand1RgbArb = ((int)0x8591)        ,
        Operand1RgbExt = ((int)0x8591)        ,
        Operand2Rgb = ((int)0x8592)        ,
        Operand2RgbArb = ((int)0x8592)        ,
        Operand2RgbExt = ((int)0x8592)        ,
        Operand3RgbNv = ((int)0x8593)        ,
        Operand0Alpha = ((int)0x8598)        ,
        Operand0AlphaArb = ((int)0x8598)        ,
        Operand0AlphaExt = ((int)0x8598)        ,
        Operand1Alpha = ((int)0x8599)        ,
        Operand1AlphaArb = ((int)0x8599)        ,
        Operand1AlphaExt = ((int)0x8599)        ,
        Operand2Alpha = ((int)0x859A)        ,
        Operand2AlphaArb = ((int)0x859A)        ,
        Operand2AlphaExt = ((int)0x859A)        ,
        Operand3AlphaNv = ((int)0x859B)        ,
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        PixelSubsample4444Sgix = ((int)0x85A2)        ,
        PixelSubsample2424Sgix = ((int)0x85A3)        ,
        PixelSubsample4242Sgix = ((int)0x85A4)        ,
        PerturbExt = ((int)0x85AE)        ,
        TextureNormalExt = ((int)0x85AF)        ,
        LightModelSpecularVectorApple = ((int)0x85B0)        ,
        TransformHintApple = ((int)0x85B1)        ,
        UnpackClientStorageApple = ((int)0x85B2)        ,
        BufferObjectApple = ((int)0x85B3)        ,
        StorageClientApple = ((int)0x85B4)        ,
        VertexArrayBinding = ((int)0x85B5)        ,
        VertexArrayBindingApple = ((int)0x85B5)        ,
        TextureRangeLengthApple = ((int)0x85B7)        ,
        TextureRangePointerApple = ((int)0x85B8)        ,
        Ycbcr422Apple = ((int)0x85B9)        ,
        UnsignedShort88Apple = ((int)0x85BA)        ,
        UnsignedShort88Mesa = ((int)0x85BA)        ,
        UnsignedShort88RevApple = ((int)0x85BB)        ,
        UnsignedShort88RevMesa = ((int)0x85BB)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        StoragePrivateApple = ((int)0x85BD)        ,
        StorageCachedApple = ((int)0x85BE)        ,
        StorageSharedApple = ((int)0x85BF)        ,
        ReplacementCodeArraySun = ((int)0x85C0)        ,
        ReplacementCodeArrayTypeSun = ((int)0x85C1)        ,
        ReplacementCodeArrayStrideSun = ((int)0x85C2)        ,
        ReplacementCodeArrayPointerSun = ((int)0x85C3)        ,
        R1uiV3fSun = ((int)0x85C4)        ,
        R1uiC4ubV3fSun = ((int)0x85C5)        ,
        R1uiC3fV3fSun = ((int)0x85C6)        ,
        R1uiN3fV3fSun = ((int)0x85C7)        ,
        R1uiC4fN3fV3fSun = ((int)0x85C8)        ,
        R1uiT2fV3fSun = ((int)0x85C9)        ,
        R1uiT2fN3fV3fSun = ((int)0x85CA)        ,
        R1uiT2fC4fN3fV3fSun = ((int)0x85CB)        ,
        SliceAccumSun = ((int)0x85CC)        ,
        QuadMeshSun = ((int)0x8614)        ,
        TriangleMeshSun = ((int)0x8615)        ,
        VertexProgram = ((int)0x8620)        ,
        VertexProgramArb = ((int)0x8620)        ,
        VertexProgramNv = ((int)0x8620)        ,
        VertexStateProgramNv = ((int)0x8621)        ,
        ArrayEnabled = ((int)0x8622)        ,
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        VertexAttribArrayEnabledArb = ((int)0x8622)        ,
        AttribArraySizeNv = ((int)0x8623)        ,
        VertexAttribArraySize = ((int)0x8623)        ,
        VertexAttribArraySizeArb = ((int)0x8623)        ,
        AttribArrayStrideNv = ((int)0x8624)        ,
        VertexAttribArrayStride = ((int)0x8624)        ,
        VertexAttribArrayStrideArb = ((int)0x8624)        ,
        ArrayType = ((int)0x8625)        ,
        AttribArrayTypeNv = ((int)0x8625)        ,
        VertexAttribArrayType = ((int)0x8625)        ,
        VertexAttribArrayTypeArb = ((int)0x8625)        ,
        CurrentAttribNv = ((int)0x8626)        ,
        CurrentVertexAttrib = ((int)0x8626)        ,
        CurrentVertexAttribArb = ((int)0x8626)        ,
        ProgramLength = ((int)0x8627)        ,
        ProgramLengthArb = ((int)0x8627)        ,
        ProgramLengthNv = ((int)0x8627)        ,
        ProgramString = ((int)0x8628)        ,
        ProgramStringArb = ((int)0x8628)        ,
        ProgramStringNv = ((int)0x8628)        ,
        ModelviewProjectionNv = ((int)0x8629)        ,
        IdentityNv = ((int)0x862A)        ,
        InverseNv = ((int)0x862B)        ,
        TransposeNv = ((int)0x862C)        ,
        InverseTransposeNv = ((int)0x862D)        ,
        MaxProgramMatrixStackDepthArb = ((int)0x862E)        ,
        MaxTrackMatrixStackDepthNv = ((int)0x862E)        ,
        MaxProgramMatricesArb = ((int)0x862F)        ,
        MaxTrackMatricesNv = ((int)0x862F)        ,
        Matrix0Nv = ((int)0x8630)        ,
        Matrix1Nv = ((int)0x8631)        ,
        Matrix2Nv = ((int)0x8632)        ,
        Matrix3Nv = ((int)0x8633)        ,
        Matrix4Nv = ((int)0x8634)        ,
        Matrix5Nv = ((int)0x8635)        ,
        Matrix6Nv = ((int)0x8636)        ,
        Matrix7Nv = ((int)0x8637)        ,
        CurrentMatrixStackDepthArb = ((int)0x8640)        ,
        CurrentMatrixStackDepthNv = ((int)0x8640)        ,
        CurrentMatrixArb = ((int)0x8641)        ,
        CurrentMatrixNv = ((int)0x8641)        ,
        ProgramPointSize = ((int)0x8642)        ,
        ProgramPointSizeArb = ((int)0x8642)        ,
        ProgramPointSizeExt = ((int)0x8642)        ,
        VertexProgramPointSize = ((int)0x8642)        ,
        VertexProgramPointSizeArb = ((int)0x8642)        ,
        VertexProgramPointSizeNv = ((int)0x8642)        ,
        VertexProgramTwoSide = ((int)0x8643)        ,
        VertexProgramTwoSideArb = ((int)0x8643)        ,
        VertexProgramTwoSideNv = ((int)0x8643)        ,
        ProgramParameterNv = ((int)0x8644)        ,
        ArrayPointer = ((int)0x8645)        ,
        AttribArrayPointerNv = ((int)0x8645)        ,
        VertexAttribArrayPointer = ((int)0x8645)        ,
        VertexAttribArrayPointerArb = ((int)0x8645)        ,
        ProgramTargetNv = ((int)0x8646)        ,
        ProgramResidentNv = ((int)0x8647)        ,
        TrackMatrixNv = ((int)0x8648)        ,
        TrackMatrixTransformNv = ((int)0x8649)        ,
        VertexProgramBindingNv = ((int)0x864A)        ,
        ProgramErrorPositionArb = ((int)0x864B)        ,
        ProgramErrorPositionNv = ((int)0x864B)        ,
        OffsetTextureRectangleNv = ((int)0x864C)        ,
        OffsetTextureRectangleScaleNv = ((int)0x864D)        ,
        DotProductTextureRectangleNv = ((int)0x864E)        ,
        DepthClamp = ((int)0x864F)        ,
        DepthClampNv = ((int)0x864F)        ,
        VertexAttribArray0Nv = ((int)0x8650)        ,
        VertexAttribArray1Nv = ((int)0x8651)        ,
        VertexAttribArray2Nv = ((int)0x8652)        ,
        VertexAttribArray3Nv = ((int)0x8653)        ,
        VertexAttribArray4Nv = ((int)0x8654)        ,
        VertexAttribArray5Nv = ((int)0x8655)        ,
        VertexAttribArray6Nv = ((int)0x8656)        ,
        VertexAttribArray7Nv = ((int)0x8657)        ,
        VertexAttribArray8Nv = ((int)0x8658)        ,
        VertexAttribArray9Nv = ((int)0x8659)        ,
        VertexAttribArray10Nv = ((int)0x865A)        ,
        VertexAttribArray11Nv = ((int)0x865B)        ,
        VertexAttribArray12Nv = ((int)0x865C)        ,
        VertexAttribArray13Nv = ((int)0x865D)        ,
        VertexAttribArray14Nv = ((int)0x865E)        ,
        VertexAttribArray15Nv = ((int)0x865F)        ,
        Map1VertexAttrib04Nv = ((int)0x8660)        ,
        Map1VertexAttrib14Nv = ((int)0x8661)        ,
        Map1VertexAttrib24Nv = ((int)0x8662)        ,
        Map1VertexAttrib34Nv = ((int)0x8663)        ,
        Map1VertexAttrib44Nv = ((int)0x8664)        ,
        Map1VertexAttrib54Nv = ((int)0x8665)        ,
        Map1VertexAttrib64Nv = ((int)0x8666)        ,
        Map1VertexAttrib74Nv = ((int)0x8667)        ,
        Map1VertexAttrib84Nv = ((int)0x8668)        ,
        Map1VertexAttrib94Nv = ((int)0x8669)        ,
        Map1VertexAttrib104Nv = ((int)0x866A)        ,
        Map1VertexAttrib114Nv = ((int)0x866B)        ,
        Map1VertexAttrib124Nv = ((int)0x866C)        ,
        Map1VertexAttrib134Nv = ((int)0x866D)        ,
        Map1VertexAttrib144Nv = ((int)0x866E)        ,
        Map1VertexAttrib154Nv = ((int)0x866F)        ,
        Map2VertexAttrib04Nv = ((int)0x8670)        ,
        Map2VertexAttrib14Nv = ((int)0x8671)        ,
        Map2VertexAttrib24Nv = ((int)0x8672)        ,
        Map2VertexAttrib34Nv = ((int)0x8673)        ,
        Map2VertexAttrib44Nv = ((int)0x8674)        ,
        Map2VertexAttrib54Nv = ((int)0x8675)        ,
        Map2VertexAttrib64Nv = ((int)0x8676)        ,
        Map2VertexAttrib74Nv = ((int)0x8677)        ,
        ProgramBinding = ((int)0x8677)        ,
        ProgramBindingArb = ((int)0x8677)        ,
        Map2VertexAttrib84Nv = ((int)0x8678)        ,
        Map2VertexAttrib94Nv = ((int)0x8679)        ,
        Map2VertexAttrib104Nv = ((int)0x867A)        ,
        Map2VertexAttrib114Nv = ((int)0x867B)        ,
        Map2VertexAttrib124Nv = ((int)0x867C)        ,
        Map2VertexAttrib134Nv = ((int)0x867D)        ,
        Map2VertexAttrib144Nv = ((int)0x867E)        ,
        Map2VertexAttrib154Nv = ((int)0x867F)        ,
        TextureCompressedImageSize = ((int)0x86A0)        ,
        TextureCompressedImageSizeArb = ((int)0x86A0)        ,
        TextureCompressed = ((int)0x86A1)        ,
        TextureCompressedArb = ((int)0x86A1)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        NumCompressedTextureFormatsArb = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        CompressedTextureFormatsArb = ((int)0x86A3)        ,
        MaxVertexUnitsArb = ((int)0x86A4)        ,
        ActiveVertexUnitsArb = ((int)0x86A5)        ,
        WeightSumUnityArb = ((int)0x86A6)        ,
        VertexBlendArb = ((int)0x86A7)        ,
        CurrentWeightArb = ((int)0x86A8)        ,
        WeightArrayTypeArb = ((int)0x86A9)        ,
        WeightArrayStrideArb = ((int)0x86AA)        ,
        WeightArraySizeArb = ((int)0x86AB)        ,
        WeightArrayPointerArb = ((int)0x86AC)        ,
        WeightArrayArb = ((int)0x86AD)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3RgbArb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
        Dot3RgbaArb = ((int)0x86AF)        ,
        CompressedRgbFxt13Dfx = ((int)0x86B0)        ,
        CompressedRgbaFxt13Dfx = ((int)0x86B1)        ,
        Multisample3Dfx = ((int)0x86B2)        ,
        SampleBuffers3Dfx = ((int)0x86B3)        ,
        Samples3Dfx = ((int)0x86B4)        ,
        Eval2DNv = ((int)0x86C0)        ,
        EvalTriangular2DNv = ((int)0x86C1)        ,
        MapTessellationNv = ((int)0x86C2)        ,
        MapAttribUOrderNv = ((int)0x86C3)        ,
        MapAttribVOrderNv = ((int)0x86C4)        ,
        EvalFractionalTessellationNv = ((int)0x86C5)        ,
        EvalVertexAttrib0Nv = ((int)0x86C6)        ,
        EvalVertexAttrib1Nv = ((int)0x86C7)        ,
        EvalVertexAttrib2Nv = ((int)0x86C8)        ,
        EvalVertexAttrib3Nv = ((int)0x86C9)        ,
        EvalVertexAttrib4Nv = ((int)0x86CA)        ,
        EvalVertexAttrib5Nv = ((int)0x86CB)        ,
        EvalVertexAttrib6Nv = ((int)0x86CC)        ,
        EvalVertexAttrib7Nv = ((int)0x86CD)        ,
        EvalVertexAttrib8Nv = ((int)0x86CE)        ,
        EvalVertexAttrib9Nv = ((int)0x86CF)        ,
        EvalVertexAttrib10Nv = ((int)0x86D0)        ,
        EvalVertexAttrib11Nv = ((int)0x86D1)        ,
        EvalVertexAttrib12Nv = ((int)0x86D2)        ,
        EvalVertexAttrib13Nv = ((int)0x86D3)        ,
        EvalVertexAttrib14Nv = ((int)0x86D4)        ,
        EvalVertexAttrib15Nv = ((int)0x86D5)        ,
        MaxMapTessellationNv = ((int)0x86D6)        ,
        MaxRationalEvalOrderNv = ((int)0x86D7)        ,
        MaxProgramPatchAttribsNv = ((int)0x86D8)        ,
        RgbaUnsignedDotProductMappingNv = ((int)0x86D9)        ,
        UnsignedIntS8S888Nv = ((int)0x86DA)        ,
        UnsignedInt88S8S8RevNv = ((int)0x86DB)        ,
        DsdtMagIntensityNv = ((int)0x86DC)        ,
        ShaderConsistentNv = ((int)0x86DD)        ,
        TextureShaderNv = ((int)0x86DE)        ,
        ShaderOperationNv = ((int)0x86DF)        ,
        CullModesNv = ((int)0x86E0)        ,
        OffsetTexture2DMatrixNv = ((int)0x86E1)        ,
        OffsetTextureMatrixNv = ((int)0x86E1)        ,
        OffsetTexture2DScaleNv = ((int)0x86E2)        ,
        OffsetTextureScaleNv = ((int)0x86E2)        ,
        OffsetTexture2DBiasNv = ((int)0x86E3)        ,
        OffsetTextureBiasNv = ((int)0x86E3)        ,
        PreviousTextureInputNv = ((int)0x86E4)        ,
        ConstEyeNv = ((int)0x86E5)        ,
        PassThroughNv = ((int)0x86E6)        ,
        CullFragmentNv = ((int)0x86E7)        ,
        OffsetTexture2DNv = ((int)0x86E8)        ,
        DependentArTexture2DNv = ((int)0x86E9)        ,
        DependentGbTexture2DNv = ((int)0x86EA)        ,
        SurfaceStateNv = ((int)0x86EB)        ,
        DotProductNv = ((int)0x86EC)        ,
        DotProductDepthReplaceNv = ((int)0x86ED)        ,
        DotProductTexture2DNv = ((int)0x86EE)        ,
        DotProductTexture3DNv = ((int)0x86EF)        ,
        DotProductTextureCubeMapNv = ((int)0x86F0)        ,
        DotProductDiffuseCubeMapNv = ((int)0x86F1)        ,
        DotProductReflectCubeMapNv = ((int)0x86F2)        ,
        DotProductConstEyeReflectCubeMapNv = ((int)0x86F3)        ,
        HiloNv = ((int)0x86F4)        ,
        DsdtNv = ((int)0x86F5)        ,
        DsdtMagNv = ((int)0x86F6)        ,
        DsdtMagVibNv = ((int)0x86F7)        ,
        Hilo16Nv = ((int)0x86F8)        ,
        SignedHiloNv = ((int)0x86F9)        ,
        SignedHilo16Nv = ((int)0x86FA)        ,
        SignedRgbaNv = ((int)0x86FB)        ,
        SignedRgba8Nv = ((int)0x86FC)        ,
        SurfaceRegisteredNv = ((int)0x86FD)        ,
        SignedRgbNv = ((int)0x86FE)        ,
        SignedRgb8Nv = ((int)0x86FF)        ,
        SurfaceMappedNv = ((int)0x8700)        ,
        SignedLuminanceNv = ((int)0x8701)        ,
        SignedLuminance8Nv = ((int)0x8702)        ,
        SignedLuminanceAlphaNv = ((int)0x8703)        ,
        SignedLuminance8Alpha8Nv = ((int)0x8704)        ,
        SignedAlphaNv = ((int)0x8705)        ,
        SignedAlpha8Nv = ((int)0x8706)        ,
        SignedIntensityNv = ((int)0x8707)        ,
        SignedIntensity8Nv = ((int)0x8708)        ,
        Dsdt8Nv = ((int)0x8709)        ,
        Dsdt8Mag8Nv = ((int)0x870A)        ,
        Dsdt8Mag8Intensity8Nv = ((int)0x870B)        ,
        SignedRgbUnsignedAlphaNv = ((int)0x870C)        ,
        SignedRgb8UnsignedAlpha8Nv = ((int)0x870D)        ,
        HiScaleNv = ((int)0x870E)        ,
        LoScaleNv = ((int)0x870F)        ,
        DsScaleNv = ((int)0x8710)        ,
        DtScaleNv = ((int)0x8711)        ,
        MagnitudeScaleNv = ((int)0x8712)        ,
        VibranceScaleNv = ((int)0x8713)        ,
        HiBiasNv = ((int)0x8714)        ,
        LoBiasNv = ((int)0x8715)        ,
        DsBiasNv = ((int)0x8716)        ,
        DtBiasNv = ((int)0x8717)        ,
        MagnitudeBiasNv = ((int)0x8718)        ,
        VibranceBiasNv = ((int)0x8719)        ,
        TextureBorderValuesNv = ((int)0x871A)        ,
        TextureHiSizeNv = ((int)0x871B)        ,
        TextureLoSizeNv = ((int)0x871C)        ,
        TextureDsSizeNv = ((int)0x871D)        ,
        TextureDtSizeNv = ((int)0x871E)        ,
        TextureMagSizeNv = ((int)0x871F)        ,
        Modelview2Arb = ((int)0x8722)        ,
        Modelview3Arb = ((int)0x8723)        ,
        Modelview4Arb = ((int)0x8724)        ,
        Modelview5Arb = ((int)0x8725)        ,
        Modelview6Arb = ((int)0x8726)        ,
        Modelview7Arb = ((int)0x8727)        ,
        Modelview8Arb = ((int)0x8728)        ,
        Modelview9Arb = ((int)0x8729)        ,
        Modelview10Arb = ((int)0x872A)        ,
        Modelview11Arb = ((int)0x872B)        ,
        Modelview12Arb = ((int)0x872C)        ,
        Modelview13Arb = ((int)0x872D)        ,
        Modelview14Arb = ((int)0x872E)        ,
        Modelview15Arb = ((int)0x872F)        ,
        Modelview16Arb = ((int)0x8730)        ,
        Modelview17Arb = ((int)0x8731)        ,
        Modelview18Arb = ((int)0x8732)        ,
        Modelview19Arb = ((int)0x8733)        ,
        Modelview20Arb = ((int)0x8734)        ,
        Modelview21Arb = ((int)0x8735)        ,
        Modelview22Arb = ((int)0x8736)        ,
        Modelview23Arb = ((int)0x8737)        ,
        Modelview24Arb = ((int)0x8738)        ,
        Modelview25Arb = ((int)0x8739)        ,
        Modelview26Arb = ((int)0x873A)        ,
        Modelview27Arb = ((int)0x873B)        ,
        Modelview28Arb = ((int)0x873C)        ,
        Modelview29Arb = ((int)0x873D)        ,
        Modelview30Arb = ((int)0x873E)        ,
        Modelview31Arb = ((int)0x873F)        ,
        Dot3RgbExt = ((int)0x8740)        ,
        Dot3RgbaExt = ((int)0x8741)        ,
        ProgramBinaryLength = ((int)0x8741)        ,
        MirrorClampAti = ((int)0x8742)        ,
        MirrorClampExt = ((int)0x8742)        ,
        MirrorClampToEdge = ((int)0x8743)        ,
        MirrorClampToEdgeAti = ((int)0x8743)        ,
        MirrorClampToEdgeExt = ((int)0x8743)        ,
        ModulateAddAti = ((int)0x8744)        ,
        ModulateSignedAddAti = ((int)0x8745)        ,
        ModulateSubtractAti = ((int)0x8746)        ,
        SetAmd = ((int)0x874A)        ,
        ReplaceValueAmd = ((int)0x874B)        ,
        StencilOpValueAmd = ((int)0x874C)        ,
        StencilBackOpValueAmd = ((int)0x874D)        ,
        VertexAttribArrayLong = ((int)0x874E)        ,
        /// <summary>
        /// Original was GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F
        /// </summary>
        OcclusionQueryEventMaskAmd = ((int)0x874F)        ,
        /// <summary>
        /// Original was GL_YCBCR_MESA = 0x8757
        /// </summary>
        YcbcrMesa = ((int)0x8757)        ,
        PackInvertMesa = ((int)0x8758)        ,
        Texture1DStackMesax = ((int)0x8759)        ,
        Texture2DStackMesax = ((int)0x875A)        ,
        ProxyTexture1DStackMesax = ((int)0x875B)        ,
        ProxyTexture2DStackMesax = ((int)0x875C)        ,
        Texture1DStackBindingMesax = ((int)0x875D)        ,
        Texture2DStackBindingMesax = ((int)0x875E)        ,
        StaticAti = ((int)0x8760)        ,
        DynamicAti = ((int)0x8761)        ,
        PreserveAti = ((int)0x8762)        ,
        DiscardAti = ((int)0x8763)        ,
        BufferSize = ((int)0x8764)        ,
        BufferSizeArb = ((int)0x8764)        ,
        ObjectBufferSizeAti = ((int)0x8764)        ,
        BufferUsage = ((int)0x8765)        ,
        BufferUsageArb = ((int)0x8765)        ,
        ObjectBufferUsageAti = ((int)0x8765)        ,
        ArrayObjectBufferAti = ((int)0x8766)        ,
        ArrayObjectOffsetAti = ((int)0x8767)        ,
        ElementArrayAti = ((int)0x8768)        ,
        ElementArrayTypeAti = ((int)0x8769)        ,
        ElementArrayPointerAti = ((int)0x876A)        ,
        MaxVertexStreamsAti = ((int)0x876B)        ,
        VertexStream0Ati = ((int)0x876C)        ,
        VertexStream1Ati = ((int)0x876D)        ,
        VertexStream2Ati = ((int)0x876E)        ,
        VertexStream3Ati = ((int)0x876F)        ,
        VertexStream4Ati = ((int)0x8770)        ,
        VertexStream5Ati = ((int)0x8771)        ,
        VertexStream6Ati = ((int)0x8772)        ,
        VertexStream7Ati = ((int)0x8773)        ,
        VertexSourceAti = ((int)0x8774)        ,
        BumpRotMatrixAti = ((int)0x8775)        ,
        BumpRotMatrixSizeAti = ((int)0x8776)        ,
        BumpNumTexUnitsAti = ((int)0x8777)        ,
        BumpTexUnitsAti = ((int)0x8778)        ,
        DudvAti = ((int)0x8779)        ,
        Du8Dv8Ati = ((int)0x877A)        ,
        BumpEnvmapAti = ((int)0x877B)        ,
        BumpTargetAti = ((int)0x877C)        ,
        VertexShaderExt = ((int)0x8780)        ,
        VertexShaderBindingExt = ((int)0x8781)        ,
        OpIndexExt = ((int)0x8782)        ,
        OpNegateExt = ((int)0x8783)        ,
        OpDot3Ext = ((int)0x8784)        ,
        OpDot4Ext = ((int)0x8785)        ,
        OpMulExt = ((int)0x8786)        ,
        OpAddExt = ((int)0x8787)        ,
        OpMaddExt = ((int)0x8788)        ,
        OpFracExt = ((int)0x8789)        ,
        OpMaxExt = ((int)0x878A)        ,
        OpMinExt = ((int)0x878B)        ,
        OpSetGeExt = ((int)0x878C)        ,
        OpSetLtExt = ((int)0x878D)        ,
        OpClampExt = ((int)0x878E)        ,
        OpFloorExt = ((int)0x878F)        ,
        OpRoundExt = ((int)0x8790)        ,
        OpExpBase2Ext = ((int)0x8791)        ,
        OpLogBase2Ext = ((int)0x8792)        ,
        OpPowerExt = ((int)0x8793)        ,
        OpRecipExt = ((int)0x8794)        ,
        OpRecipSqrtExt = ((int)0x8795)        ,
        OpSubExt = ((int)0x8796)        ,
        OpCrossProductExt = ((int)0x8797)        ,
        OpMultiplyMatrixExt = ((int)0x8798)        ,
        OpMovExt = ((int)0x8799)        ,
        OutputVertexExt = ((int)0x879A)        ,
        OutputColor0Ext = ((int)0x879B)        ,
        OutputColor1Ext = ((int)0x879C)        ,
        OutputTextureCoord0Ext = ((int)0x879D)        ,
        OutputTextureCoord1Ext = ((int)0x879E)        ,
        OutputTextureCoord2Ext = ((int)0x879F)        ,
        OutputTextureCoord3Ext = ((int)0x87A0)        ,
        OutputTextureCoord4Ext = ((int)0x87A1)        ,
        OutputTextureCoord5Ext = ((int)0x87A2)        ,
        OutputTextureCoord6Ext = ((int)0x87A3)        ,
        OutputTextureCoord7Ext = ((int)0x87A4)        ,
        OutputTextureCoord8Ext = ((int)0x87A5)        ,
        OutputTextureCoord9Ext = ((int)0x87A6)        ,
        OutputTextureCoord10Ext = ((int)0x87A7)        ,
        OutputTextureCoord11Ext = ((int)0x87A8)        ,
        OutputTextureCoord12Ext = ((int)0x87A9)        ,
        OutputTextureCoord13Ext = ((int)0x87AA)        ,
        OutputTextureCoord14Ext = ((int)0x87AB)        ,
        OutputTextureCoord15Ext = ((int)0x87AC)        ,
        OutputTextureCoord16Ext = ((int)0x87AD)        ,
        OutputTextureCoord17Ext = ((int)0x87AE)        ,
        OutputTextureCoord18Ext = ((int)0x87AF)        ,
        OutputTextureCoord19Ext = ((int)0x87B0)        ,
        OutputTextureCoord20Ext = ((int)0x87B1)        ,
        OutputTextureCoord21Ext = ((int)0x87B2)        ,
        OutputTextureCoord22Ext = ((int)0x87B3)        ,
        OutputTextureCoord23Ext = ((int)0x87B4)        ,
        OutputTextureCoord24Ext = ((int)0x87B5)        ,
        OutputTextureCoord25Ext = ((int)0x87B6)        ,
        OutputTextureCoord26Ext = ((int)0x87B7)        ,
        OutputTextureCoord27Ext = ((int)0x87B8)        ,
        OutputTextureCoord28Ext = ((int)0x87B9)        ,
        OutputTextureCoord29Ext = ((int)0x87BA)        ,
        OutputTextureCoord30Ext = ((int)0x87BB)        ,
        OutputTextureCoord31Ext = ((int)0x87BC)        ,
        OutputFogExt = ((int)0x87BD)        ,
        ScalarExt = ((int)0x87BE)        ,
        VectorExt = ((int)0x87BF)        ,
        MatrixExt = ((int)0x87C0)        ,
        VariantExt = ((int)0x87C1)        ,
        InvariantExt = ((int)0x87C2)        ,
        LocalConstantExt = ((int)0x87C3)        ,
        LocalExt = ((int)0x87C4)        ,
        MaxVertexShaderInstructionsExt = ((int)0x87C5)        ,
        MaxVertexShaderVariantsExt = ((int)0x87C6)        ,
        MaxVertexShaderInvariantsExt = ((int)0x87C7)        ,
        MaxVertexShaderLocalConstantsExt = ((int)0x87C8)        ,
        MaxVertexShaderLocalsExt = ((int)0x87C9)        ,
        MaxOptimizedVertexShaderInstructionsExt = ((int)0x87CA)        ,
        MaxOptimizedVertexShaderVariantsExt = ((int)0x87CB)        ,
        MaxOptimizedVertexShaderLocalConstantsExt = ((int)0x87CC)        ,
        MaxOptimizedVertexShaderInvariantsExt = ((int)0x87CD)        ,
        MaxOptimizedVertexShaderLocalsExt = ((int)0x87CE)        ,
        VertexShaderInstructionsExt = ((int)0x87CF)        ,
        VertexShaderVariantsExt = ((int)0x87D0)        ,
        VertexShaderInvariantsExt = ((int)0x87D1)        ,
        VertexShaderLocalConstantsExt = ((int)0x87D2)        ,
        VertexShaderLocalsExt = ((int)0x87D3)        ,
        VertexShaderOptimizedExt = ((int)0x87D4)        ,
        XExt = ((int)0x87D5)        ,
        YExt = ((int)0x87D6)        ,
        ZExt = ((int)0x87D7)        ,
        WExt = ((int)0x87D8)        ,
        NegativeXExt = ((int)0x87D9)        ,
        NegativeYExt = ((int)0x87DA)        ,
        NegativeZExt = ((int)0x87DB)        ,
        NegativeWExt = ((int)0x87DC)        ,
        ZeroExt = ((int)0x87DD)        ,
        OneExt = ((int)0x87DE)        ,
        NegativeOneExt = ((int)0x87DF)        ,
        NormalizedRangeExt = ((int)0x87E0)        ,
        FullRangeExt = ((int)0x87E1)        ,
        CurrentVertexExt = ((int)0x87E2)        ,
        MvpMatrixExt = ((int)0x87E3)        ,
        VariantValueExt = ((int)0x87E4)        ,
        VariantDatatypeExt = ((int)0x87E5)        ,
        VariantArrayStrideExt = ((int)0x87E6)        ,
        VariantArrayTypeExt = ((int)0x87E7)        ,
        VariantArrayExt = ((int)0x87E8)        ,
        VariantArrayPointerExt = ((int)0x87E9)        ,
        InvariantValueExt = ((int)0x87EA)        ,
        InvariantDatatypeExt = ((int)0x87EB)        ,
        LocalConstantValueExt = ((int)0x87EC)        ,
        LocalConstantDatatypeExt = ((int)0x87ED)        ,
        PnTrianglesAti = ((int)0x87F0)        ,
        MaxPnTrianglesTesselationLevelAti = ((int)0x87F1)        ,
        PnTrianglesPointModeAti = ((int)0x87F2)        ,
        PnTrianglesNormalModeAti = ((int)0x87F3)        ,
        PnTrianglesTesselationLevelAti = ((int)0x87F4)        ,
        PnTrianglesPointModeLinearAti = ((int)0x87F5)        ,
        PnTrianglesPointModeCubicAti = ((int)0x87F6)        ,
        PnTrianglesNormalModeLinearAti = ((int)0x87F7)        ,
        PnTrianglesNormalModeQuadraticAti = ((int)0x87F8)        ,
        VboFreeMemoryAti = ((int)0x87FB)        ,
        TextureFreeMemoryAti = ((int)0x87FC)        ,
        RenderbufferFreeMemoryAti = ((int)0x87FD)        ,
        NumProgramBinaryFormats = ((int)0x87FE)        ,
        ProgramBinaryFormats = ((int)0x87FF)        ,
        StencilBackFunc = ((int)0x8800)        ,
        StencilBackFuncAti = ((int)0x8800)        ,
        StencilBackFail = ((int)0x8801)        ,
        StencilBackFailAti = ((int)0x8801)        ,
        StencilBackPassDepthFail = ((int)0x8802)        ,
        StencilBackPassDepthFailAti = ((int)0x8802)        ,
        StencilBackPassDepthPass = ((int)0x8803)        ,
        StencilBackPassDepthPassAti = ((int)0x8803)        ,
        FragmentProgram = ((int)0x8804)        ,
        FragmentProgramArb = ((int)0x8804)        ,
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
        Rgba32fArb = ((int)0x8814)        ,
        RgbaFloat32Apple = ((int)0x8814)        ,
        RgbaFloat32Ati = ((int)0x8814)        ,
        Rgb32f = ((int)0x8815)        ,
        Rgb32fArb = ((int)0x8815)        ,
        RgbFloat32Apple = ((int)0x8815)        ,
        RgbFloat32Ati = ((int)0x8815)        ,
        Alpha32fArb = ((int)0x8816)        ,
        AlphaFloat32Apple = ((int)0x8816)        ,
        AlphaFloat32Ati = ((int)0x8816)        ,
        Intensity32fArb = ((int)0x8817)        ,
        IntensityFloat32Apple = ((int)0x8817)        ,
        IntensityFloat32Ati = ((int)0x8817)        ,
        Luminance32fArb = ((int)0x8818)        ,
        LuminanceFloat32Apple = ((int)0x8818)        ,
        LuminanceFloat32Ati = ((int)0x8818)        ,
        LuminanceAlpha32fArb = ((int)0x8819)        ,
        LuminanceAlphaFloat32Apple = ((int)0x8819)        ,
        LuminanceAlphaFloat32Ati = ((int)0x8819)        ,
        Rgba16f = ((int)0x881A)        ,
        Rgba16fArb = ((int)0x881A)        ,
        RgbaFloat16Apple = ((int)0x881A)        ,
        RgbaFloat16Ati = ((int)0x881A)        ,
        Rgb16f = ((int)0x881B)        ,
        Rgb16fArb = ((int)0x881B)        ,
        RgbFloat16Apple = ((int)0x881B)        ,
        RgbFloat16Ati = ((int)0x881B)        ,
        Alpha16fArb = ((int)0x881C)        ,
        AlphaFloat16Apple = ((int)0x881C)        ,
        AlphaFloat16Ati = ((int)0x881C)        ,
        Intensity16fArb = ((int)0x881D)        ,
        IntensityFloat16Apple = ((int)0x881D)        ,
        IntensityFloat16Ati = ((int)0x881D)        ,
        Luminance16fArb = ((int)0x881E)        ,
        LuminanceFloat16Apple = ((int)0x881E)        ,
        LuminanceFloat16Ati = ((int)0x881E)        ,
        LuminanceAlpha16fArb = ((int)0x881F)        ,
        LuminanceAlphaFloat16Apple = ((int)0x881F)        ,
        LuminanceAlphaFloat16Ati = ((int)0x881F)        ,
        RgbaFloatMode = ((int)0x8820)        ,
        RgbaFloatModeArb = ((int)0x8820)        ,
        RgbaFloatModeAti = ((int)0x8820)        ,
        MaxDrawBuffers = ((int)0x8824)        ,
        MaxDrawBuffersArb = ((int)0x8824)        ,
        MaxDrawBuffersAti = ((int)0x8824)        ,
        DrawBuffer0 = ((int)0x8825)        ,
        DrawBuffer0Arb = ((int)0x8825)        ,
        DrawBuffer0Ati = ((int)0x8825)        ,
        DrawBuffer1 = ((int)0x8826)        ,
        DrawBuffer1Arb = ((int)0x8826)        ,
        DrawBuffer1Ati = ((int)0x8826)        ,
        DrawBuffer2 = ((int)0x8827)        ,
        DrawBuffer2Arb = ((int)0x8827)        ,
        DrawBuffer2Ati = ((int)0x8827)        ,
        DrawBuffer3 = ((int)0x8828)        ,
        DrawBuffer3Arb = ((int)0x8828)        ,
        DrawBuffer3Ati = ((int)0x8828)        ,
        DrawBuffer4 = ((int)0x8829)        ,
        DrawBuffer4Arb = ((int)0x8829)        ,
        DrawBuffer4Ati = ((int)0x8829)        ,
        DrawBuffer5 = ((int)0x882A)        ,
        DrawBuffer5Arb = ((int)0x882A)        ,
        DrawBuffer5Ati = ((int)0x882A)        ,
        DrawBuffer6 = ((int)0x882B)        ,
        DrawBuffer6Arb = ((int)0x882B)        ,
        DrawBuffer6Ati = ((int)0x882B)        ,
        DrawBuffer7 = ((int)0x882C)        ,
        DrawBuffer7Arb = ((int)0x882C)        ,
        DrawBuffer7Ati = ((int)0x882C)        ,
        DrawBuffer8 = ((int)0x882D)        ,
        DrawBuffer8Arb = ((int)0x882D)        ,
        DrawBuffer8Ati = ((int)0x882D)        ,
        DrawBuffer9 = ((int)0x882E)        ,
        DrawBuffer9Arb = ((int)0x882E)        ,
        DrawBuffer9Ati = ((int)0x882E)        ,
        DrawBuffer10 = ((int)0x882F)        ,
        DrawBuffer10Arb = ((int)0x882F)        ,
        DrawBuffer10Ati = ((int)0x882F)        ,
        DrawBuffer11 = ((int)0x8830)        ,
        DrawBuffer11Arb = ((int)0x8830)        ,
        DrawBuffer11Ati = ((int)0x8830)        ,
        DrawBuffer12 = ((int)0x8831)        ,
        DrawBuffer12Arb = ((int)0x8831)        ,
        DrawBuffer12Ati = ((int)0x8831)        ,
        DrawBuffer13 = ((int)0x8832)        ,
        DrawBuffer13Arb = ((int)0x8832)        ,
        DrawBuffer13Ati = ((int)0x8832)        ,
        DrawBuffer14 = ((int)0x8833)        ,
        DrawBuffer14Arb = ((int)0x8833)        ,
        DrawBuffer14Ati = ((int)0x8833)        ,
        DrawBuffer15 = ((int)0x8834)        ,
        DrawBuffer15Arb = ((int)0x8834)        ,
        DrawBuffer15Ati = ((int)0x8834)        ,
        ColorClearUnclampedValueAti = ((int)0x8835)        ,
        BlendEquationAlpha = ((int)0x883D)        ,
        BlendEquationAlphaExt = ((int)0x883D)        ,
        SubsampleDistanceAmd = ((int)0x883F)        ,
        MatrixPaletteArb = ((int)0x8840)        ,
        MaxMatrixPaletteStackDepthArb = ((int)0x8841)        ,
        MaxPaletteMatricesArb = ((int)0x8842)        ,
        CurrentPaletteMatrixArb = ((int)0x8843)        ,
        MatrixIndexArrayArb = ((int)0x8844)        ,
        CurrentMatrixIndexArb = ((int)0x8845)        ,
        MatrixIndexArraySizeArb = ((int)0x8846)        ,
        MatrixIndexArrayTypeArb = ((int)0x8847)        ,
        MatrixIndexArrayStrideArb = ((int)0x8848)        ,
        MatrixIndexArrayPointerArb = ((int)0x8849)        ,
        TextureDepthSize = ((int)0x884A)        ,
        TextureDepthSizeArb = ((int)0x884A)        ,
        DepthTextureMode = ((int)0x884B)        ,
        DepthTextureModeArb = ((int)0x884B)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareModeArb = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        TextureCompareFuncArb = ((int)0x884D)        ,
        CompareRefDepthToTextureExt = ((int)0x884E)        ,
        CompareRefToTexture = ((int)0x884E)        ,
        CompareRToTexture = ((int)0x884E)        ,
        CompareRToTextureArb = ((int)0x884E)        ,
        TextureCubeMapSeamless = ((int)0x884F)        ,
        OffsetProjectiveTexture2DNv = ((int)0x8850)        ,
        OffsetProjectiveTexture2DScaleNv = ((int)0x8851)        ,
        OffsetProjectiveTextureRectangleNv = ((int)0x8852)        ,
        OffsetProjectiveTextureRectangleScaleNv = ((int)0x8853)        ,
        OffsetHiloTexture2DNv = ((int)0x8854)        ,
        OffsetHiloTextureRectangleNv = ((int)0x8855)        ,
        OffsetHiloProjectiveTexture2DNv = ((int)0x8856)        ,
        OffsetHiloProjectiveTextureRectangleNv = ((int)0x8857)        ,
        DependentHiloTexture2DNv = ((int)0x8858)        ,
        DependentRgbTexture3DNv = ((int)0x8859)        ,
        DependentRgbTextureCubeMapNv = ((int)0x885A)        ,
        DotProductPassThroughNv = ((int)0x885B)        ,
        DotProductTexture1DNv = ((int)0x885C)        ,
        DotProductAffineDepthReplaceNv = ((int)0x885D)        ,
        Hilo8Nv = ((int)0x885E)        ,
        SignedHilo8Nv = ((int)0x885F)        ,
        ForceBlueToOneNv = ((int)0x8860)        ,
        PointSprite = ((int)0x8861)        ,
        PointSpriteArb = ((int)0x8861)        ,
        PointSpriteNv = ((int)0x8861)        ,
        CoordReplace = ((int)0x8862)        ,
        CoordReplaceArb = ((int)0x8862)        ,
        CoordReplaceNv = ((int)0x8862)        ,
        PointSpriteRModeNv = ((int)0x8863)        ,
        PixelCounterBitsNv = ((int)0x8864)        ,
        QueryCounterBits = ((int)0x8864)        ,
        QueryCounterBitsArb = ((int)0x8864)        ,
        CurrentOcclusionQueryIdNv = ((int)0x8865)        ,
        CurrentQuery = ((int)0x8865)        ,
        CurrentQueryArb = ((int)0x8865)        ,
        PixelCountNv = ((int)0x8866)        ,
        QueryResult = ((int)0x8866)        ,
        QueryResultArb = ((int)0x8866)        ,
        PixelCountAvailableNv = ((int)0x8867)        ,
        QueryResultAvailable = ((int)0x8867)        ,
        QueryResultAvailableArb = ((int)0x8867)        ,
        MaxFragmentProgramLocalParametersNv = ((int)0x8868)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        MaxVertexAttribsArb = ((int)0x8869)        ,
        ArrayNormalized = ((int)0x886A)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        VertexAttribArrayNormalizedArb = ((int)0x886A)        ,
        MaxTessControlInputComponents = ((int)0x886C)        ,
        MaxTessEvaluationInputComponents = ((int)0x886D)        ,
        DepthStencilToRgbaNv = ((int)0x886E)        ,
        DepthStencilToBgraNv = ((int)0x886F)        ,
        FragmentProgramNv = ((int)0x8870)        ,
        MaxTextureCoords = ((int)0x8871)        ,
        MaxTextureCoordsArb = ((int)0x8871)        ,
        MaxTextureCoordsNv = ((int)0x8871)        ,
        MaxTextureImageUnits = ((int)0x8872)        ,
        MaxTextureImageUnitsArb = ((int)0x8872)        ,
        MaxTextureImageUnitsNv = ((int)0x8872)        ,
        FragmentProgramBindingNv = ((int)0x8873)        ,
        ProgramErrorStringArb = ((int)0x8874)        ,
        ProgramErrorStringNv = ((int)0x8874)        ,
        ProgramFormatAsciiArb = ((int)0x8875)        ,
        ProgramFormat = ((int)0x8876)        ,
        ProgramFormatArb = ((int)0x8876)        ,
        WritePixelDataRangeNv = ((int)0x8878)        ,
        ReadPixelDataRangeNv = ((int)0x8879)        ,
        WritePixelDataRangeLengthNv = ((int)0x887A)        ,
        ReadPixelDataRangeLengthNv = ((int)0x887B)        ,
        WritePixelDataRangePointerNv = ((int)0x887C)        ,
        ReadPixelDataRangePointerNv = ((int)0x887D)        ,
        GeometryShaderInvocations = ((int)0x887F)        ,
        FloatRNv = ((int)0x8880)        ,
        FloatRgNv = ((int)0x8881)        ,
        FloatRgbNv = ((int)0x8882)        ,
        FloatRgbaNv = ((int)0x8883)        ,
        FloatR16Nv = ((int)0x8884)        ,
        FloatR32Nv = ((int)0x8885)        ,
        FloatRg16Nv = ((int)0x8886)        ,
        FloatRg32Nv = ((int)0x8887)        ,
        FloatRgb16Nv = ((int)0x8888)        ,
        FloatRgb32Nv = ((int)0x8889)        ,
        FloatRgba16Nv = ((int)0x888A)        ,
        FloatRgba32Nv = ((int)0x888B)        ,
        TextureFloatComponentsNv = ((int)0x888C)        ,
        FloatClearColorValueNv = ((int)0x888D)        ,
        FloatRgbaModeNv = ((int)0x888E)        ,
        TextureUnsignedRemapModeNv = ((int)0x888F)        ,
        DepthBoundsTestExt = ((int)0x8890)        ,
        DepthBoundsExt = ((int)0x8891)        ,
        ArrayBuffer = ((int)0x8892)        ,
        ArrayBufferArb = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        ElementArrayBufferArb = ((int)0x8893)        ,
        ArrayBufferBinding = ((int)0x8894)        ,
        ArrayBufferBindingArb = ((int)0x8894)        ,
        ElementArrayBufferBinding = ((int)0x8895)        ,
        ElementArrayBufferBindingArb = ((int)0x8895)        ,
        VertexArrayBufferBinding = ((int)0x8896)        ,
        VertexArrayBufferBindingArb = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        NormalArrayBufferBindingArb = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        ColorArrayBufferBindingArb = ((int)0x8898)        ,
        IndexArrayBufferBinding = ((int)0x8899)        ,
        IndexArrayBufferBindingArb = ((int)0x8899)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        TextureCoordArrayBufferBindingArb = ((int)0x889A)        ,
        EdgeFlagArrayBufferBinding = ((int)0x889B)        ,
        EdgeFlagArrayBufferBindingArb = ((int)0x889B)        ,
        SecondaryColorArrayBufferBinding = ((int)0x889C)        ,
        SecondaryColorArrayBufferBindingArb = ((int)0x889C)        ,
        FogCoordArrayBufferBinding = ((int)0x889D)        ,
        FogCoordinateArrayBufferBinding = ((int)0x889D)        ,
        FogCoordinateArrayBufferBindingArb = ((int)0x889D)        ,
        WeightArrayBufferBinding = ((int)0x889E)        ,
        WeightArrayBufferBindingArb = ((int)0x889E)        ,
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        VertexAttribArrayBufferBindingArb = ((int)0x889F)        ,
        ProgramInstruction = ((int)0x88A0)        ,
        ProgramInstructionsArb = ((int)0x88A0)        ,
        MaxProgramInstructions = ((int)0x88A1)        ,
        MaxProgramInstructionsArb = ((int)0x88A1)        ,
        ProgramNativeInstructions = ((int)0x88A2)        ,
        ProgramNativeInstructionsArb = ((int)0x88A2)        ,
        MaxProgramNativeInstructions = ((int)0x88A3)        ,
        MaxProgramNativeInstructionsArb = ((int)0x88A3)        ,
        ProgramTemporaries = ((int)0x88A4)        ,
        ProgramTemporariesArb = ((int)0x88A4)        ,
        MaxProgramTemporaries = ((int)0x88A5)        ,
        MaxProgramTemporariesArb = ((int)0x88A5)        ,
        ProgramNativeTemporaries = ((int)0x88A6)        ,
        ProgramNativeTemporariesArb = ((int)0x88A6)        ,
        MaxProgramNativeTemporaries = ((int)0x88A7)        ,
        MaxProgramNativeTemporariesArb = ((int)0x88A7)        ,
        ProgramParameters = ((int)0x88A8)        ,
        ProgramParametersArb = ((int)0x88A8)        ,
        MaxProgramParameters = ((int)0x88A9)        ,
        MaxProgramParametersArb = ((int)0x88A9)        ,
        ProgramNativeParameters = ((int)0x88AA)        ,
        ProgramNativeParametersArb = ((int)0x88AA)        ,
        MaxProgramNativeParameters = ((int)0x88AB)        ,
        MaxProgramNativeParametersArb = ((int)0x88AB)        ,
        ProgramAttribs = ((int)0x88AC)        ,
        ProgramAttribsArb = ((int)0x88AC)        ,
        MaxProgramAttribs = ((int)0x88AD)        ,
        MaxProgramAttribsArb = ((int)0x88AD)        ,
        ProgramNativeAttribs = ((int)0x88AE)        ,
        ProgramNativeAttribsArb = ((int)0x88AE)        ,
        MaxProgramNativeAttribs = ((int)0x88AF)        ,
        MaxProgramNativeAttribsArb = ((int)0x88AF)        ,
        ProgramAddressRegisters = ((int)0x88B0)        ,
        ProgramAddressRegistersArb = ((int)0x88B0)        ,
        MaxProgramAddressRegisters = ((int)0x88B1)        ,
        MaxProgramAddressRegistersArb = ((int)0x88B1)        ,
        ProgramNativeAddressRegisters = ((int)0x88B2)        ,
        ProgramNativeAddressRegistersArb = ((int)0x88B2)        ,
        MaxProgramNativeAddressRegisters = ((int)0x88B3)        ,
        MaxProgramNativeAddressRegistersArb = ((int)0x88B3)        ,
        MaxProgramLocalParameters = ((int)0x88B4)        ,
        MaxProgramLocalParametersArb = ((int)0x88B4)        ,
        MaxProgramEnvParameters = ((int)0x88B5)        ,
        MaxProgramEnvParametersArb = ((int)0x88B5)        ,
        ProgramUnderNativeLimits = ((int)0x88B6)        ,
        ProgramUnderNativeLimitsArb = ((int)0x88B6)        ,
        TransposeCurrentMatrixArb = ((int)0x88B7)        ,
        ReadOnly = ((int)0x88B8)        ,
        ReadOnlyArb = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        WriteOnlyArb = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
        ReadWriteArb = ((int)0x88BA)        ,
        BufferAccess = ((int)0x88BB)        ,
        BufferAccessArb = ((int)0x88BB)        ,
        BufferMapped = ((int)0x88BC)        ,
        BufferMappedArb = ((int)0x88BC)        ,
        BufferMapPointer = ((int)0x88BD)        ,
        BufferMapPointerArb = ((int)0x88BD)        ,
        WriteDiscardNv = ((int)0x88BE)        ,
        TimeElapsed = ((int)0x88BF)        ,
        TimeElapsedExt = ((int)0x88BF)        ,
        Matrix0 = ((int)0x88C0)        ,
        Matrix0Arb = ((int)0x88C0)        ,
        Matrix1 = ((int)0x88C1)        ,
        Matrix1Arb = ((int)0x88C1)        ,
        Matrix2 = ((int)0x88C2)        ,
        Matrix2Arb = ((int)0x88C2)        ,
        Matrix3 = ((int)0x88C3)        ,
        Matrix3Arb = ((int)0x88C3)        ,
        Matrix4 = ((int)0x88C4)        ,
        Matrix4Arb = ((int)0x88C4)        ,
        Matrix5 = ((int)0x88C5)        ,
        Matrix5Arb = ((int)0x88C5)        ,
        Matrix6 = ((int)0x88C6)        ,
        Matrix6Arb = ((int)0x88C6)        ,
        Matrix7 = ((int)0x88C7)        ,
        Matrix7Arb = ((int)0x88C7)        ,
        Matrix8 = ((int)0x88C8)        ,
        Matrix8Arb = ((int)0x88C8)        ,
        Matrix9 = ((int)0x88C9)        ,
        Matrix9Arb = ((int)0x88C9)        ,
        Matrix10 = ((int)0x88CA)        ,
        Matrix10Arb = ((int)0x88CA)        ,
        Matrix11 = ((int)0x88CB)        ,
        Matrix11Arb = ((int)0x88CB)        ,
        Matrix12 = ((int)0x88CC)        ,
        Matrix12Arb = ((int)0x88CC)        ,
        Matrix13 = ((int)0x88CD)        ,
        Matrix13Arb = ((int)0x88CD)        ,
        Matrix14 = ((int)0x88CE)        ,
        Matrix14Arb = ((int)0x88CE)        ,
        Matrix15 = ((int)0x88CF)        ,
        Matrix15Arb = ((int)0x88CF)        ,
        Matrix16 = ((int)0x88D0)        ,
        Matrix16Arb = ((int)0x88D0)        ,
        Matrix17 = ((int)0x88D1)        ,
        Matrix17Arb = ((int)0x88D1)        ,
        Matrix18 = ((int)0x88D2)        ,
        Matrix18Arb = ((int)0x88D2)        ,
        Matrix19 = ((int)0x88D3)        ,
        Matrix19Arb = ((int)0x88D3)        ,
        Matrix20 = ((int)0x88D4)        ,
        Matrix20Arb = ((int)0x88D4)        ,
        Matrix21 = ((int)0x88D5)        ,
        Matrix21Arb = ((int)0x88D5)        ,
        Matrix22 = ((int)0x88D6)        ,
        Matrix22Arb = ((int)0x88D6)        ,
        Matrix23 = ((int)0x88D7)        ,
        Matrix23Arb = ((int)0x88D7)        ,
        Matrix24 = ((int)0x88D8)        ,
        Matrix24Arb = ((int)0x88D8)        ,
        Matrix25 = ((int)0x88D9)        ,
        Matrix25Arb = ((int)0x88D9)        ,
        Matrix26 = ((int)0x88DA)        ,
        Matrix26Arb = ((int)0x88DA)        ,
        Matrix27 = ((int)0x88DB)        ,
        Matrix27Arb = ((int)0x88DB)        ,
        Matrix28 = ((int)0x88DC)        ,
        Matrix28Arb = ((int)0x88DC)        ,
        Matrix29 = ((int)0x88DD)        ,
        Matrix29Arb = ((int)0x88DD)        ,
        Matrix30 = ((int)0x88DE)        ,
        Matrix30Arb = ((int)0x88DE)        ,
        Matrix31 = ((int)0x88DF)        ,
        Matrix31Arb = ((int)0x88DF)        ,
        StreamDraw = ((int)0x88E0)        ,
        StreamDrawArb = ((int)0x88E0)        ,
        StreamRead = ((int)0x88E1)        ,
        StreamReadArb = ((int)0x88E1)        ,
        StreamCopy = ((int)0x88E2)        ,
        StreamCopyArb = ((int)0x88E2)        ,
        StaticDraw = ((int)0x88E4)        ,
        StaticDrawArb = ((int)0x88E4)        ,
        StaticRead = ((int)0x88E5)        ,
        StaticReadArb = ((int)0x88E5)        ,
        StaticCopy = ((int)0x88E6)        ,
        StaticCopyArb = ((int)0x88E6)        ,
        DynamicDraw = ((int)0x88E8)        ,
        DynamicDrawArb = ((int)0x88E8)        ,
        DynamicRead = ((int)0x88E9)        ,
        DynamicReadArb = ((int)0x88E9)        ,
        DynamicCopy = ((int)0x88EA)        ,
        DynamicCopyArb = ((int)0x88EA)        ,
        PixelPackBuffer = ((int)0x88EB)        ,
        PixelPackBufferArb = ((int)0x88EB)        ,
        PixelPackBufferExt = ((int)0x88EB)        ,
        PixelUnpackBuffer = ((int)0x88EC)        ,
        PixelUnpackBufferArb = ((int)0x88EC)        ,
        PixelUnpackBufferExt = ((int)0x88EC)        ,
        PixelPackBufferBinding = ((int)0x88ED)        ,
        PixelPackBufferBindingArb = ((int)0x88ED)        ,
        PixelPackBufferBindingExt = ((int)0x88ED)        ,
        PixelUnpackBufferBinding = ((int)0x88EF)        ,
        PixelUnpackBufferBindingArb = ((int)0x88EF)        ,
        PixelUnpackBufferBindingExt = ((int)0x88EF)        ,
        Depth24Stencil8 = ((int)0x88F0)        ,
        Depth24Stencil8Ext = ((int)0x88F0)        ,
        TextureStencilSize = ((int)0x88F1)        ,
        TextureStencilSizeExt = ((int)0x88F1)        ,
        StencilTagBitsExt = ((int)0x88F2)        ,
        StencilClearTagValueExt = ((int)0x88F3)        ,
        MaxProgramExecInstructionsNv = ((int)0x88F4)        ,
        MaxProgramCallDepthNv = ((int)0x88F5)        ,
        MaxProgramIfDepthNv = ((int)0x88F6)        ,
        MaxProgramLoopDepthNv = ((int)0x88F7)        ,
        MaxProgramLoopCountNv = ((int)0x88F8)        ,
        Src1Color = ((int)0x88F9)        ,
        OneMinusSrc1Color = ((int)0x88FA)        ,
        OneMinusSrc1Alpha = ((int)0x88FB)        ,
        MaxDualSourceDrawBuffers = ((int)0x88FC)        ,
        VertexAttribArrayInteger = ((int)0x88FD)        ,
        VertexAttribArrayIntegerExt = ((int)0x88FD)        ,
        VertexAttribArrayIntegerNv = ((int)0x88FD)        ,
        ArrayDivisor = ((int)0x88FE)        ,
        VertexAttribArrayDivisor = ((int)0x88FE)        ,
        VertexAttribArrayDivisorArb = ((int)0x88FE)        ,
        MaxArrayTextureLayers = ((int)0x88FF)        ,
        MaxArrayTextureLayersExt = ((int)0x88FF)        ,
        MinProgramTexelOffset = ((int)0x8904)        ,
        MinProgramTexelOffsetExt = ((int)0x8904)        ,
        MinProgramTexelOffsetNv = ((int)0x8904)        ,
        MaxProgramTexelOffset = ((int)0x8905)        ,
        MaxProgramTexelOffsetExt = ((int)0x8905)        ,
        MaxProgramTexelOffsetNv = ((int)0x8905)        ,
        ProgramAttribComponentsNv = ((int)0x8906)        ,
        ProgramResultComponentsNv = ((int)0x8907)        ,
        MaxProgramAttribComponentsNv = ((int)0x8908)        ,
        MaxProgramResultComponentsNv = ((int)0x8909)        ,
        StencilTestTwoSideExt = ((int)0x8910)        ,
        ActiveStencilFaceExt = ((int)0x8911)        ,
        MirrorClampToBorderExt = ((int)0x8912)        ,
        SamplesPassed = ((int)0x8914)        ,
        SamplesPassedArb = ((int)0x8914)        ,
        GeometryVerticesOut = ((int)0x8916)        ,
        GeometryInputType = ((int)0x8917)        ,
        GeometryOutputType = ((int)0x8918)        ,
        SamplerBinding = ((int)0x8919)        ,
        ClampVertexColor = ((int)0x891A)        ,
        ClampVertexColorArb = ((int)0x891A)        ,
        ClampFragmentColor = ((int)0x891B)        ,
        ClampFragmentColorArb = ((int)0x891B)        ,
        ClampReadColor = ((int)0x891C)        ,
        ClampReadColorArb = ((int)0x891C)        ,
        FixedOnly = ((int)0x891D)        ,
        FixedOnlyArb = ((int)0x891D)        ,
        TessControlProgramNv = ((int)0x891E)        ,
        TessEvaluationProgramNv = ((int)0x891F)        ,
        FragmentShaderAti = ((int)0x8920)        ,
        Reg0Ati = ((int)0x8921)        ,
        Reg1Ati = ((int)0x8922)        ,
        Reg2Ati = ((int)0x8923)        ,
        Reg3Ati = ((int)0x8924)        ,
        Reg4Ati = ((int)0x8925)        ,
        Reg5Ati = ((int)0x8926)        ,
        Reg6Ati = ((int)0x8927)        ,
        Reg7Ati = ((int)0x8928)        ,
        Reg8Ati = ((int)0x8929)        ,
        Reg9Ati = ((int)0x892A)        ,
        Reg10Ati = ((int)0x892B)        ,
        Reg11Ati = ((int)0x892C)        ,
        Reg12Ati = ((int)0x892D)        ,
        Reg13Ati = ((int)0x892E)        ,
        Reg14Ati = ((int)0x892F)        ,
        Reg15Ati = ((int)0x8930)        ,
        Reg16Ati = ((int)0x8931)        ,
        Reg17Ati = ((int)0x8932)        ,
        Reg18Ati = ((int)0x8933)        ,
        Reg19Ati = ((int)0x8934)        ,
        Reg20Ati = ((int)0x8935)        ,
        Reg21Ati = ((int)0x8936)        ,
        Reg22Ati = ((int)0x8937)        ,
        Reg23Ati = ((int)0x8938)        ,
        Reg24Ati = ((int)0x8939)        ,
        Reg25Ati = ((int)0x893A)        ,
        Reg26Ati = ((int)0x893B)        ,
        Reg27Ati = ((int)0x893C)        ,
        Reg28Ati = ((int)0x893D)        ,
        Reg29Ati = ((int)0x893E)        ,
        Reg30Ati = ((int)0x893F)        ,
        Reg31Ati = ((int)0x8940)        ,
        Con0Ati = ((int)0x8941)        ,
        Con1Ati = ((int)0x8942)        ,
        Con2Ati = ((int)0x8943)        ,
        Con3Ati = ((int)0x8944)        ,
        Con4Ati = ((int)0x8945)        ,
        Con5Ati = ((int)0x8946)        ,
        Con6Ati = ((int)0x8947)        ,
        Con7Ati = ((int)0x8948)        ,
        Con8Ati = ((int)0x8949)        ,
        Con9Ati = ((int)0x894A)        ,
        Con10Ati = ((int)0x894B)        ,
        Con11Ati = ((int)0x894C)        ,
        Con12Ati = ((int)0x894D)        ,
        Con13Ati = ((int)0x894E)        ,
        Con14Ati = ((int)0x894F)        ,
        Con15Ati = ((int)0x8950)        ,
        Con16Ati = ((int)0x8951)        ,
        Con17Ati = ((int)0x8952)        ,
        Con18Ati = ((int)0x8953)        ,
        Con19Ati = ((int)0x8954)        ,
        Con20Ati = ((int)0x8955)        ,
        Con21Ati = ((int)0x8956)        ,
        Con22Ati = ((int)0x8957)        ,
        Con23Ati = ((int)0x8958)        ,
        Con24Ati = ((int)0x8959)        ,
        Con25Ati = ((int)0x895A)        ,
        Con26Ati = ((int)0x895B)        ,
        Con27Ati = ((int)0x895C)        ,
        Con28Ati = ((int)0x895D)        ,
        Con29Ati = ((int)0x895E)        ,
        Con30Ati = ((int)0x895F)        ,
        Con31Ati = ((int)0x8960)        ,
        MovAti = ((int)0x8961)        ,
        AddAti = ((int)0x8963)        ,
        MulAti = ((int)0x8964)        ,
        SubAti = ((int)0x8965)        ,
        Dot3Ati = ((int)0x8966)        ,
        Dot4Ati = ((int)0x8967)        ,
        MadAti = ((int)0x8968)        ,
        LerpAti = ((int)0x8969)        ,
        CndAti = ((int)0x896A)        ,
        Cnd0Ati = ((int)0x896B)        ,
        Dot2AddAti = ((int)0x896C)        ,
        SecondaryInterpolatorAti = ((int)0x896D)        ,
        NumFragmentRegistersAti = ((int)0x896E)        ,
        NumFragmentConstantsAti = ((int)0x896F)        ,
        NumPassesAti = ((int)0x8970)        ,
        NumInstructionsPerPassAti = ((int)0x8971)        ,
        NumInstructionsTotalAti = ((int)0x8972)        ,
        NumInputInterpolatorComponentsAti = ((int)0x8973)        ,
        NumLoopbackComponentsAti = ((int)0x8974)        ,
        ColorAlphaPairingAti = ((int)0x8975)        ,
        SwizzleStrAti = ((int)0x8976)        ,
        SwizzleStqAti = ((int)0x8977)        ,
        SwizzleStrDrAti = ((int)0x8978)        ,
        SwizzleStqDqAti = ((int)0x8979)        ,
        SwizzleStrqAti = ((int)0x897A)        ,
        SwizzleStrqDqAti = ((int)0x897B)        ,
        InterlaceOml = ((int)0x8980)        ,
        InterlaceReadOml = ((int)0x8981)        ,
        FormatSubsample2424Oml = ((int)0x8982)        ,
        FormatSubsample244244Oml = ((int)0x8983)        ,
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
        ResampleReplicateOml = ((int)0x8986)        ,
        ResampleZeroFillOml = ((int)0x8987)        ,
        ResampleAverageOml = ((int)0x8988)        ,
        ResampleDecimateOml = ((int)0x8989)        ,
        VertexAttribMap1Apple = ((int)0x8A00)        ,
        VertexAttribMap2Apple = ((int)0x8A01)        ,
        VertexAttribMap1SizeApple = ((int)0x8A02)        ,
        VertexAttribMap1CoeffApple = ((int)0x8A03)        ,
        VertexAttribMap1OrderApple = ((int)0x8A04)        ,
        VertexAttribMap1DomainApple = ((int)0x8A05)        ,
        VertexAttribMap2SizeApple = ((int)0x8A06)        ,
        VertexAttribMap2CoeffApple = ((int)0x8A07)        ,
        VertexAttribMap2OrderApple = ((int)0x8A08)        ,
        VertexAttribMap2DomainApple = ((int)0x8A09)        ,
        DrawPixelsApple = ((int)0x8A0A)        ,
        FenceApple = ((int)0x8A0B)        ,
        ElementArrayApple = ((int)0x8A0C)        ,
        ElementArrayTypeApple = ((int)0x8A0D)        ,
        ElementArrayPointerApple = ((int)0x8A0E)        ,
        ColorFloatApple = ((int)0x8A0F)        ,
        UniformBuffer = ((int)0x8A11)        ,
        BufferSerializedModifyApple = ((int)0x8A12)        ,
        BufferFlushingUnmapApple = ((int)0x8A13)        ,
        AuxDepthStencilApple = ((int)0x8A14)        ,
        PackRowBytesApple = ((int)0x8A15)        ,
        UnpackRowBytesApple = ((int)0x8A16)        ,
        ReleasedApple = ((int)0x8A19)        ,
        VolatileApple = ((int)0x8A1A)        ,
        RetainedApple = ((int)0x8A1B)        ,
        UndefinedApple = ((int)0x8A1C)        ,
        PurgeableApple = ((int)0x8A1D)        ,
        Rgb422Apple = ((int)0x8A1F)        ,
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
        TextureSrgbDecodeExt = ((int)0x8A48)        ,
        DecodeExt = ((int)0x8A49)        ,
        SkipDecodeExt = ((int)0x8A4A)        ,
        ProgramPipelineObjectExt = ((int)0x8A4F)        ,
        RgbRaw422Apple = ((int)0x8A51)        ,
        FragmentShader = ((int)0x8B30)        ,
        FragmentShaderArb = ((int)0x8B30)        ,
        VertexShader = ((int)0x8B31)        ,
        VertexShaderArb = ((int)0x8B31)        ,
        ProgramObjectArb = ((int)0x8B40)        ,
        ProgramObjectExt = ((int)0x8B40)        ,
        ShaderObjectArb = ((int)0x8B48)        ,
        ShaderObjectExt = ((int)0x8B48)        ,
        MaxFragmentUniformComponents = ((int)0x8B49)        ,
        MaxFragmentUniformComponentsArb = ((int)0x8B49)        ,
        MaxVertexUniformComponents = ((int)0x8B4A)        ,
        MaxVertexUniformComponentsArb = ((int)0x8B4A)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        MaxVaryingComponentsExt = ((int)0x8B4B)        ,
        MaxVaryingFloats = ((int)0x8B4B)        ,
        MaxVaryingFloatsArb = ((int)0x8B4B)        ,
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        MaxVertexTextureImageUnitsArb = ((int)0x8B4C)        ,
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        MaxCombinedTextureImageUnitsArb = ((int)0x8B4D)        ,
        ObjectTypeArb = ((int)0x8B4E)        ,
        ObjectSubtypeArb = ((int)0x8B4F)        ,
        ShaderType = ((int)0x8B4F)        ,
        FloatVec2 = ((int)0x8B50)        ,
        FloatVec2Arb = ((int)0x8B50)        ,
        FloatVec3 = ((int)0x8B51)        ,
        FloatVec3Arb = ((int)0x8B51)        ,
        FloatVec4 = ((int)0x8B52)        ,
        FloatVec4Arb = ((int)0x8B52)        ,
        IntVec2 = ((int)0x8B53)        ,
        IntVec2Arb = ((int)0x8B53)        ,
        IntVec3 = ((int)0x8B54)        ,
        IntVec3Arb = ((int)0x8B54)        ,
        IntVec4 = ((int)0x8B55)        ,
        IntVec4Arb = ((int)0x8B55)        ,
        Bool = ((int)0x8B56)        ,
        BoolArb = ((int)0x8B56)        ,
        BoolVec2 = ((int)0x8B57)        ,
        BoolVec2Arb = ((int)0x8B57)        ,
        BoolVec3 = ((int)0x8B58)        ,
        BoolVec3Arb = ((int)0x8B58)        ,
        BoolVec4 = ((int)0x8B59)        ,
        BoolVec4Arb = ((int)0x8B59)        ,
        FloatMat2 = ((int)0x8B5A)        ,
        FloatMat2Arb = ((int)0x8B5A)        ,
        FloatMat3 = ((int)0x8B5B)        ,
        FloatMat3Arb = ((int)0x8B5B)        ,
        FloatMat4 = ((int)0x8B5C)        ,
        FloatMat4Arb = ((int)0x8B5C)        ,
        Sampler1D = ((int)0x8B5D)        ,
        Sampler1DArb = ((int)0x8B5D)        ,
        Sampler2D = ((int)0x8B5E)        ,
        Sampler2DArb = ((int)0x8B5E)        ,
        Sampler3D = ((int)0x8B5F)        ,
        Sampler3DArb = ((int)0x8B5F)        ,
        SamplerCube = ((int)0x8B60)        ,
        SamplerCubeArb = ((int)0x8B60)        ,
        Sampler1DShadow = ((int)0x8B61)        ,
        Sampler1DShadowArb = ((int)0x8B61)        ,
        Sampler2DShadow = ((int)0x8B62)        ,
        Sampler2DShadowArb = ((int)0x8B62)        ,
        Sampler2DRect = ((int)0x8B63)        ,
        Sampler2DRectArb = ((int)0x8B63)        ,
        Sampler2DRectShadow = ((int)0x8B64)        ,
        Sampler2DRectShadowArb = ((int)0x8B64)        ,
        FloatMat2x3 = ((int)0x8B65)        ,
        FloatMat2x4 = ((int)0x8B66)        ,
        FloatMat3x2 = ((int)0x8B67)        ,
        FloatMat3x4 = ((int)0x8B68)        ,
        FloatMat4x2 = ((int)0x8B69)        ,
        FloatMat4x3 = ((int)0x8B6A)        ,
        DeleteStatus = ((int)0x8B80)        ,
        ObjectDeleteStatusArb = ((int)0x8B80)        ,
        CompileStatus = ((int)0x8B81)        ,
        ObjectCompileStatusArb = ((int)0x8B81)        ,
        LinkStatus = ((int)0x8B82)        ,
        ObjectLinkStatusArb = ((int)0x8B82)        ,
        ObjectValidateStatusArb = ((int)0x8B83)        ,
        ValidateStatus = ((int)0x8B83)        ,
        InfoLogLength = ((int)0x8B84)        ,
        ObjectInfoLogLengthArb = ((int)0x8B84)        ,
        AttachedShaders = ((int)0x8B85)        ,
        ObjectAttachedObjectsArb = ((int)0x8B85)        ,
        ActiveUniforms = ((int)0x8B86)        ,
        ObjectActiveUniformsArb = ((int)0x8B86)        ,
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        ObjectActiveUniformMaxLengthArb = ((int)0x8B87)        ,
        ObjectShaderSourceLengthArb = ((int)0x8B88)        ,
        ShaderSourceLength = ((int)0x8B88)        ,
        ActiveAttributes = ((int)0x8B89)        ,
        ObjectActiveAttributesArb = ((int)0x8B89)        ,
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        ObjectActiveAttributeMaxLengthArb = ((int)0x8B8A)        ,
        FragmentShaderDerivativeHint = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintArb = ((int)0x8B8B)        ,
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        ShadingLanguageVersionArb = ((int)0x8B8C)        ,
        ActiveProgramExt = ((int)0x8B8D)        ,
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
        ImplementationColorReadTypeOes = ((int)0x8B9A)        ,
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        ImplementationColorReadFormatOes = ((int)0x8B9B)        ,
        CounterTypeAmd = ((int)0x8BC0)        ,
        CounterRangeAmd = ((int)0x8BC1)        ,
        UnsignedInt64Amd = ((int)0x8BC2)        ,
        PercentageAmd = ((int)0x8BC3)        ,
        PerfmonResultAvailableAmd = ((int)0x8BC4)        ,
        PerfmonResultSizeAmd = ((int)0x8BC5)        ,
        PerfmonResultAmd = ((int)0x8BC6)        ,
        TextureRedType = ((int)0x8C10)        ,
        TextureRedTypeArb = ((int)0x8C10)        ,
        TextureGreenType = ((int)0x8C11)        ,
        TextureGreenTypeArb = ((int)0x8C11)        ,
        TextureBlueType = ((int)0x8C12)        ,
        TextureBlueTypeArb = ((int)0x8C12)        ,
        TextureAlphaType = ((int)0x8C13)        ,
        TextureAlphaTypeArb = ((int)0x8C13)        ,
        TextureLuminanceType = ((int)0x8C14)        ,
        TextureLuminanceTypeArb = ((int)0x8C14)        ,
        TextureIntensityType = ((int)0x8C15)        ,
        TextureIntensityTypeArb = ((int)0x8C15)        ,
        TextureDepthType = ((int)0x8C16)        ,
        TextureDepthTypeArb = ((int)0x8C16)        ,
        UnsignedNormalized = ((int)0x8C17)        ,
        UnsignedNormalizedArb = ((int)0x8C17)        ,
        Texture1DArray = ((int)0x8C18)        ,
        Texture1DArrayExt = ((int)0x8C18)        ,
        ProxyTexture1DArray = ((int)0x8C19)        ,
        ProxyTexture1DArrayExt = ((int)0x8C19)        ,
        Texture2DArray = ((int)0x8C1A)        ,
        Texture2DArrayExt = ((int)0x8C1A)        ,
        ProxyTexture2DArray = ((int)0x8C1B)        ,
        ProxyTexture2DArrayExt = ((int)0x8C1B)        ,
        TextureBinding1DArray = ((int)0x8C1C)        ,
        TextureBinding1DArrayExt = ((int)0x8C1C)        ,
        TextureBinding2DArray = ((int)0x8C1D)        ,
        TextureBinding2DArrayExt = ((int)0x8C1D)        ,
        GeometryProgramNv = ((int)0x8C26)        ,
        MaxProgramOutputVerticesNv = ((int)0x8C27)        ,
        MaxProgramTotalOutputComponentsNv = ((int)0x8C28)        ,
        MaxGeometryTextureImageUnits = ((int)0x8C29)        ,
        MaxGeometryTextureImageUnitsArb = ((int)0x8C29)        ,
        MaxGeometryTextureImageUnitsExt = ((int)0x8C29)        ,
        TextureBuffer = ((int)0x8C2A)        ,
        TextureBufferArb = ((int)0x8C2A)        ,
        TextureBufferBinding = ((int)0x8C2A)        ,
        TextureBufferExt = ((int)0x8C2A)        ,
        MaxTextureBufferSize = ((int)0x8C2B)        ,
        MaxTextureBufferSizeArb = ((int)0x8C2B)        ,
        MaxTextureBufferSizeExt = ((int)0x8C2B)        ,
        TextureBindingBuffer = ((int)0x8C2C)        ,
        TextureBindingBufferArb = ((int)0x8C2C)        ,
        TextureBindingBufferExt = ((int)0x8C2C)        ,
        TextureBufferDataStoreBinding = ((int)0x8C2D)        ,
        TextureBufferDataStoreBindingArb = ((int)0x8C2D)        ,
        TextureBufferDataStoreBindingExt = ((int)0x8C2D)        ,
        TextureBufferFormatArb = ((int)0x8C2E)        ,
        TextureBufferFormatExt = ((int)0x8C2E)        ,
        AnySamplesPassed = ((int)0x8C2F)        ,
        SampleShading = ((int)0x8C36)        ,
        SampleShadingArb = ((int)0x8C36)        ,
        MinSampleShadingValue = ((int)0x8C37)        ,
        MinSampleShadingValueArb = ((int)0x8C37)        ,
        R11fG11fB10f = ((int)0x8C3A)        ,
        R11fG11fB10fExt = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRev = ((int)0x8C3B)        ,
        UnsignedInt10F11F11FRevExt = ((int)0x8C3B)        ,
        RgbaSignedComponentsExt = ((int)0x8C3C)        ,
        Rgb9E5 = ((int)0x8C3D)        ,
        Rgb9E5Ext = ((int)0x8C3D)        ,
        UnsignedInt5999Rev = ((int)0x8C3E)        ,
        UnsignedInt5999RevExt = ((int)0x8C3E)        ,
        TextureSharedSize = ((int)0x8C3F)        ,
        TextureSharedSizeExt = ((int)0x8C3F)        ,
        Srgb = ((int)0x8C40)        ,
        SrgbExt = ((int)0x8C40)        ,
        Srgb8 = ((int)0x8C41)        ,
        Srgb8Ext = ((int)0x8C41)        ,
        SrgbAlpha = ((int)0x8C42)        ,
        SrgbAlphaExt = ((int)0x8C42)        ,
        Srgb8Alpha8 = ((int)0x8C43)        ,
        Srgb8Alpha8Ext = ((int)0x8C43)        ,
        SluminanceAlpha = ((int)0x8C44)        ,
        SluminanceAlphaExt = ((int)0x8C44)        ,
        Sluminance8Alpha8 = ((int)0x8C45)        ,
        Sluminance8Alpha8Ext = ((int)0x8C45)        ,
        Sluminance = ((int)0x8C46)        ,
        SluminanceExt = ((int)0x8C46)        ,
        Sluminance8 = ((int)0x8C47)        ,
        Sluminance8Ext = ((int)0x8C47)        ,
        CompressedSrgb = ((int)0x8C48)        ,
        CompressedSrgbExt = ((int)0x8C48)        ,
        CompressedSrgbAlpha = ((int)0x8C49)        ,
        CompressedSrgbAlphaExt = ((int)0x8C49)        ,
        CompressedSluminance = ((int)0x8C4A)        ,
        CompressedSluminanceExt = ((int)0x8C4A)        ,
        CompressedSluminanceAlpha = ((int)0x8C4B)        ,
        CompressedSluminanceAlphaExt = ((int)0x8C4B)        ,
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)        ,
        CompressedLuminanceLatc1Ext = ((int)0x8C70)        ,
        CompressedSignedLuminanceLatc1Ext = ((int)0x8C71)        ,
        CompressedLuminanceAlphaLatc2Ext = ((int)0x8C72)        ,
        CompressedSignedLuminanceAlphaLatc2Ext = ((int)0x8C73)        ,
        TessControlProgramParameterBufferNv = ((int)0x8C74)        ,
        TessEvaluationProgramParameterBufferNv = ((int)0x8C75)        ,
        TransformFeedbackVaryingMaxLength = ((int)0x8C76)        ,
        TransformFeedbackVaryingMaxLengthExt = ((int)0x8C76)        ,
        BackPrimaryColorNv = ((int)0x8C77)        ,
        BackSecondaryColorNv = ((int)0x8C78)        ,
        TextureCoordNv = ((int)0x8C79)        ,
        ClipDistanceNv = ((int)0x8C7A)        ,
        VertexIdNv = ((int)0x8C7B)        ,
        PrimitiveIdNv = ((int)0x8C7C)        ,
        GenericAttribNv = ((int)0x8C7D)        ,
        TransformFeedbackAttribsNv = ((int)0x8C7E)        ,
        TransformFeedbackBufferMode = ((int)0x8C7F)        ,
        TransformFeedbackBufferModeExt = ((int)0x8C7F)        ,
        TransformFeedbackBufferModeNv = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponents = ((int)0x8C80)        ,
        MaxTransformFeedbackSeparateComponentsExt = ((int)0x8C80)        ,
        MaxTransformFeedbackSeparateComponentsNv = ((int)0x8C80)        ,
        ActiveVaryingsNv = ((int)0x8C81)        ,
        ActiveVaryingMaxLengthNv = ((int)0x8C82)        ,
        TransformFeedbackVaryings = ((int)0x8C83)        ,
        TransformFeedbackVaryingsExt = ((int)0x8C83)        ,
        TransformFeedbackVaryingsNv = ((int)0x8C83)        ,
        TransformFeedbackBufferStart = ((int)0x8C84)        ,
        TransformFeedbackBufferStartExt = ((int)0x8C84)        ,
        TransformFeedbackBufferStartNv = ((int)0x8C84)        ,
        TransformFeedbackBufferSize = ((int)0x8C85)        ,
        TransformFeedbackBufferSizeExt = ((int)0x8C85)        ,
        TransformFeedbackBufferSizeNv = ((int)0x8C85)        ,
        TransformFeedbackRecordNv = ((int)0x8C86)        ,
        PrimitivesGenerated = ((int)0x8C87)        ,
        PrimitivesGeneratedExt = ((int)0x8C87)        ,
        PrimitivesGeneratedNv = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWritten = ((int)0x8C88)        ,
        TransformFeedbackPrimitivesWrittenExt = ((int)0x8C88)        ,
        TransformFeedbackPrimitivesWrittenNv = ((int)0x8C88)        ,
        RasterizerDiscard = ((int)0x8C89)        ,
        RasterizerDiscardExt = ((int)0x8C89)        ,
        RasterizerDiscardNv = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponents = ((int)0x8C8A)        ,
        MaxTransformFeedbackInterleavedComponentsExt = ((int)0x8C8A)        ,
        MaxTransformFeedbackInterleavedComponentsNv = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribs = ((int)0x8C8B)        ,
        MaxTransformFeedbackSeparateAttribsExt = ((int)0x8C8B)        ,
        MaxTransformFeedbackSeparateAttribsNv = ((int)0x8C8B)        ,
        InterleavedAttribs = ((int)0x8C8C)        ,
        InterleavedAttribsExt = ((int)0x8C8C)        ,
        InterleavedAttribsNv = ((int)0x8C8C)        ,
        SeparateAttribs = ((int)0x8C8D)        ,
        SeparateAttribsExt = ((int)0x8C8D)        ,
        SeparateAttribsNv = ((int)0x8C8D)        ,
        TransformFeedbackBuffer = ((int)0x8C8E)        ,
        TransformFeedbackBufferExt = ((int)0x8C8E)        ,
        TransformFeedbackBufferNv = ((int)0x8C8E)        ,
        TransformFeedbackBufferBinding = ((int)0x8C8F)        ,
        TransformFeedbackBufferBindingExt = ((int)0x8C8F)        ,
        TransformFeedbackBufferBindingNv = ((int)0x8C8F)        ,
        PointSpriteCoordOrigin = ((int)0x8CA0)        ,
        LowerLeft = ((int)0x8CA1)        ,
        UpperLeft = ((int)0x8CA2)        ,
        StencilBackRef = ((int)0x8CA3)        ,
        StencilBackValueMask = ((int)0x8CA4)        ,
        StencilBackWritemask = ((int)0x8CA5)        ,
        DrawFramebufferBinding = ((int)0x8CA6)        ,
        DrawFramebufferBindingExt = ((int)0x8CA6)        ,
        FramebufferBinding = ((int)0x8CA6)        ,
        FramebufferBindingExt = ((int)0x8CA6)        ,
        RenderbufferBinding = ((int)0x8CA7)        ,
        RenderbufferBindingExt = ((int)0x8CA7)        ,
        ReadFramebuffer = ((int)0x8CA8)        ,
        ReadFramebufferExt = ((int)0x8CA8)        ,
        DrawFramebuffer = ((int)0x8CA9)        ,
        DrawFramebufferExt = ((int)0x8CA9)        ,
        ReadFramebufferBinding = ((int)0x8CAA)        ,
        ReadFramebufferBindingExt = ((int)0x8CAA)        ,
        RenderbufferCoverageSamplesNv = ((int)0x8CAB)        ,
        RenderbufferSamples = ((int)0x8CAB)        ,
        RenderbufferSamplesExt = ((int)0x8CAB)        ,
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
        FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)        ,
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
        FramebufferIncompleteMultisampleExt = ((int)0x8D56)        ,
        MaxSamples = ((int)0x8D57)        ,
        MaxSamplesExt = ((int)0x8D57)        ,
        Rgb565 = ((int)0x8D62)        ,
        PrimitiveRestartFixedIndex = ((int)0x8D69)        ,
        AnySamplesPassedConservative = ((int)0x8D6A)        ,
        MaxElementIndex = ((int)0x8D6B)        ,
        Rgba32ui = ((int)0x8D70)        ,
        Rgba32uiExt = ((int)0x8D70)        ,
        Rgb32ui = ((int)0x8D71)        ,
        Rgb32uiExt = ((int)0x8D71)        ,
        Alpha32uiExt = ((int)0x8D72)        ,
        Intensity32uiExt = ((int)0x8D73)        ,
        Luminance32uiExt = ((int)0x8D74)        ,
        LuminanceAlpha32uiExt = ((int)0x8D75)        ,
        Rgba16ui = ((int)0x8D76)        ,
        Rgba16uiExt = ((int)0x8D76)        ,
        Rgb16ui = ((int)0x8D77)        ,
        Rgb16uiExt = ((int)0x8D77)        ,
        Alpha16uiExt = ((int)0x8D78)        ,
        Intensity16uiExt = ((int)0x8D79)        ,
        Luminance16uiExt = ((int)0x8D7A)        ,
        LuminanceAlpha16uiExt = ((int)0x8D7B)        ,
        Rgba8ui = ((int)0x8D7C)        ,
        Rgba8uiExt = ((int)0x8D7C)        ,
        Rgb8ui = ((int)0x8D7D)        ,
        Rgb8uiExt = ((int)0x8D7D)        ,
        Alpha8uiExt = ((int)0x8D7E)        ,
        Intensity8uiExt = ((int)0x8D7F)        ,
        Luminance8uiExt = ((int)0x8D80)        ,
        LuminanceAlpha8uiExt = ((int)0x8D81)        ,
        Rgba32i = ((int)0x8D82)        ,
        Rgba32iExt = ((int)0x8D82)        ,
        Rgb32i = ((int)0x8D83)        ,
        Rgb32iExt = ((int)0x8D83)        ,
        Alpha32iExt = ((int)0x8D84)        ,
        Intensity32iExt = ((int)0x8D85)        ,
        Luminance32iExt = ((int)0x8D86)        ,
        LuminanceAlpha32iExt = ((int)0x8D87)        ,
        Rgba16i = ((int)0x8D88)        ,
        Rgba16iExt = ((int)0x8D88)        ,
        Rgb16i = ((int)0x8D89)        ,
        Rgb16iExt = ((int)0x8D89)        ,
        Alpha16iExt = ((int)0x8D8A)        ,
        Intensity16iExt = ((int)0x8D8B)        ,
        Luminance16iExt = ((int)0x8D8C)        ,
        LuminanceAlpha16iExt = ((int)0x8D8D)        ,
        Rgba8i = ((int)0x8D8E)        ,
        Rgba8iExt = ((int)0x8D8E)        ,
        Rgb8i = ((int)0x8D8F)        ,
        Rgb8iExt = ((int)0x8D8F)        ,
        Alpha8iExt = ((int)0x8D90)        ,
        Intensity8iExt = ((int)0x8D91)        ,
        Luminance8iExt = ((int)0x8D92)        ,
        LuminanceAlpha8iExt = ((int)0x8D93)        ,
        RedInteger = ((int)0x8D94)        ,
        RedIntegerExt = ((int)0x8D94)        ,
        GreenInteger = ((int)0x8D95)        ,
        GreenIntegerExt = ((int)0x8D95)        ,
        BlueInteger = ((int)0x8D96)        ,
        BlueIntegerExt = ((int)0x8D96)        ,
        AlphaInteger = ((int)0x8D97)        ,
        AlphaIntegerExt = ((int)0x8D97)        ,
        RgbInteger = ((int)0x8D98)        ,
        RgbIntegerExt = ((int)0x8D98)        ,
        RgbaInteger = ((int)0x8D99)        ,
        RgbaIntegerExt = ((int)0x8D99)        ,
        BgrInteger = ((int)0x8D9A)        ,
        BgrIntegerExt = ((int)0x8D9A)        ,
        BgraInteger = ((int)0x8D9B)        ,
        BgraIntegerExt = ((int)0x8D9B)        ,
        LuminanceIntegerExt = ((int)0x8D9C)        ,
        LuminanceAlphaIntegerExt = ((int)0x8D9D)        ,
        RgbaIntegerModeExt = ((int)0x8D9E)        ,
        Int2101010Rev = ((int)0x8D9F)        ,
        MaxProgramParameterBufferBindingsNv = ((int)0x8DA0)        ,
        MaxProgramParameterBufferSizeNv = ((int)0x8DA1)        ,
        VertexProgramParameterBufferNv = ((int)0x8DA2)        ,
        GeometryProgramParameterBufferNv = ((int)0x8DA3)        ,
        FragmentProgramParameterBufferNv = ((int)0x8DA4)        ,
        MaxProgramGenericAttribsNv = ((int)0x8DA5)        ,
        MaxProgramGenericResultsNv = ((int)0x8DA6)        ,
        FramebufferAttachmentLayered = ((int)0x8DA7)        ,
        FramebufferAttachmentLayeredArb = ((int)0x8DA7)        ,
        FramebufferAttachmentLayeredExt = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargets = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerTargetsArb = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCount = ((int)0x8DA9)        ,
        FramebufferIncompleteLayerCountArb = ((int)0x8DA9)        ,
        FramebufferIncompleteLayerCountExt = ((int)0x8DA9)        ,
        LayerNv = ((int)0x8DAA)        ,
        DepthComponent32fNv = ((int)0x8DAB)        ,
        Depth32fStencil8Nv = ((int)0x8DAC)        ,
        Float32UnsignedInt248Rev = ((int)0x8DAD)        ,
        Float32UnsignedInt248RevNv = ((int)0x8DAD)        ,
        ShaderIncludeArb = ((int)0x8DAE)        ,
        DepthBufferFloatModeNv = ((int)0x8DAF)        ,
        FramebufferSrgb = ((int)0x8DB9)        ,
        FramebufferSrgbExt = ((int)0x8DB9)        ,
        FramebufferSrgbCapableExt = ((int)0x8DBA)        ,
        CompressedRedRgtc1 = ((int)0x8DBB)        ,
        CompressedRedRgtc1Ext = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1 = ((int)0x8DBC)        ,
        CompressedSignedRedRgtc1Ext = ((int)0x8DBC)        ,
        CompressedRedGreenRgtc2Ext = ((int)0x8DBD)        ,
        CompressedRgRgtc2 = ((int)0x8DBD)        ,
        CompressedSignedRedGreenRgtc2Ext = ((int)0x8DBE)        ,
        CompressedSignedRgRgtc2 = ((int)0x8DBE)        ,
        Sampler1DArray = ((int)0x8DC0)        ,
        Sampler1DArrayExt = ((int)0x8DC0)        ,
        Sampler2DArray = ((int)0x8DC1)        ,
        Sampler2DArrayExt = ((int)0x8DC1)        ,
        SamplerBuffer = ((int)0x8DC2)        ,
        SamplerBufferExt = ((int)0x8DC2)        ,
        Sampler1DArrayShadow = ((int)0x8DC3)        ,
        Sampler1DArrayShadowExt = ((int)0x8DC3)        ,
        Sampler2DArrayShadow = ((int)0x8DC4)        ,
        Sampler2DArrayShadowExt = ((int)0x8DC4)        ,
        SamplerCubeShadow = ((int)0x8DC5)        ,
        SamplerCubeShadowExt = ((int)0x8DC5)        ,
        UnsignedIntVec2 = ((int)0x8DC6)        ,
        UnsignedIntVec2Ext = ((int)0x8DC6)        ,
        UnsignedIntVec3 = ((int)0x8DC7)        ,
        UnsignedIntVec3Ext = ((int)0x8DC7)        ,
        UnsignedIntVec4 = ((int)0x8DC8)        ,
        UnsignedIntVec4Ext = ((int)0x8DC8)        ,
        IntSampler1D = ((int)0x8DC9)        ,
        IntSampler1DExt = ((int)0x8DC9)        ,
        IntSampler2D = ((int)0x8DCA)        ,
        IntSampler2DExt = ((int)0x8DCA)        ,
        IntSampler3D = ((int)0x8DCB)        ,
        IntSampler3DExt = ((int)0x8DCB)        ,
        IntSamplerCube = ((int)0x8DCC)        ,
        IntSamplerCubeExt = ((int)0x8DCC)        ,
        IntSampler2DRect = ((int)0x8DCD)        ,
        IntSampler2DRectExt = ((int)0x8DCD)        ,
        IntSampler1DArray = ((int)0x8DCE)        ,
        IntSampler1DArrayExt = ((int)0x8DCE)        ,
        IntSampler2DArray = ((int)0x8DCF)        ,
        IntSampler2DArrayExt = ((int)0x8DCF)        ,
        IntSamplerBuffer = ((int)0x8DD0)        ,
        IntSamplerBufferExt = ((int)0x8DD0)        ,
        UnsignedIntSampler1D = ((int)0x8DD1)        ,
        UnsignedIntSampler1DExt = ((int)0x8DD1)        ,
        UnsignedIntSampler2D = ((int)0x8DD2)        ,
        UnsignedIntSampler2DExt = ((int)0x8DD2)        ,
        UnsignedIntSampler3D = ((int)0x8DD3)        ,
        UnsignedIntSampler3DExt = ((int)0x8DD3)        ,
        UnsignedIntSamplerCube = ((int)0x8DD4)        ,
        UnsignedIntSamplerCubeExt = ((int)0x8DD4)        ,
        UnsignedIntSampler2DRect = ((int)0x8DD5)        ,
        UnsignedIntSampler2DRectExt = ((int)0x8DD5)        ,
        UnsignedIntSampler1DArray = ((int)0x8DD6)        ,
        UnsignedIntSampler1DArrayExt = ((int)0x8DD6)        ,
        UnsignedIntSampler2DArray = ((int)0x8DD7)        ,
        UnsignedIntSampler2DArrayExt = ((int)0x8DD7)        ,
        UnsignedIntSamplerBuffer = ((int)0x8DD8)        ,
        UnsignedIntSamplerBufferExt = ((int)0x8DD8)        ,
        GeometryShader = ((int)0x8DD9)        ,
        GeometryShaderArb = ((int)0x8DD9)        ,
        GeometryShaderExt = ((int)0x8DD9)        ,
        GeometryVerticesOutArb = ((int)0x8DDA)        ,
        GeometryVerticesOutExt = ((int)0x8DDA)        ,
        GeometryInputTypeArb = ((int)0x8DDB)        ,
        GeometryInputTypeExt = ((int)0x8DDB)        ,
        GeometryOutputTypeArb = ((int)0x8DDC)        ,
        GeometryOutputTypeExt = ((int)0x8DDC)        ,
        MaxGeometryVaryingComponents = ((int)0x8DDD)        ,
        MaxGeometryVaryingComponentsArb = ((int)0x8DDD)        ,
        MaxGeometryVaryingComponentsExt = ((int)0x8DDD)        ,
        MaxVertexVaryingComponents = ((int)0x8DDE)        ,
        MaxVertexVaryingComponentsArb = ((int)0x8DDE)        ,
        MaxVertexVaryingComponentsExt = ((int)0x8DDE)        ,
        MaxGeometryUniformComponents = ((int)0x8DDF)        ,
        MaxGeometryUniformComponentsArb = ((int)0x8DDF)        ,
        MaxGeometryUniformComponentsExt = ((int)0x8DDF)        ,
        MaxGeometryOutputVertices = ((int)0x8DE0)        ,
        MaxGeometryOutputVerticesArb = ((int)0x8DE0)        ,
        MaxGeometryOutputVerticesExt = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponents = ((int)0x8DE1)        ,
        MaxGeometryTotalOutputComponentsArb = ((int)0x8DE1)        ,
        MaxGeometryTotalOutputComponentsExt = ((int)0x8DE1)        ,
        MaxVertexBindableUniformsExt = ((int)0x8DE2)        ,
        MaxFragmentBindableUniformsExt = ((int)0x8DE3)        ,
        MaxGeometryBindableUniformsExt = ((int)0x8DE4)        ,
        ActiveSubroutines = ((int)0x8DE5)        ,
        ActiveSubroutineUniforms = ((int)0x8DE6)        ,
        MaxSubroutines = ((int)0x8DE7)        ,
        MaxSubroutineUniformLocations = ((int)0x8DE8)        ,
        NamedStringLengthArb = ((int)0x8DE9)        ,
        NamedStringTypeArb = ((int)0x8DEA)        ,
        MaxBindableUniformSizeExt = ((int)0x8DED)        ,
        UniformBufferExt = ((int)0x8DEE)        ,
        UniformBufferBindingExt = ((int)0x8DEF)        ,
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
        RenderbufferColorSamplesNv = ((int)0x8E10)        ,
        MaxMultisampleCoverageModesNv = ((int)0x8E11)        ,
        MultisampleCoverageModesNv = ((int)0x8E12)        ,
        QueryWait = ((int)0x8E13)        ,
        QueryWaitNv = ((int)0x8E13)        ,
        QueryNoWait = ((int)0x8E14)        ,
        QueryNoWaitNv = ((int)0x8E14)        ,
        QueryByRegionWait = ((int)0x8E15)        ,
        QueryByRegionWaitNv = ((int)0x8E15)        ,
        QueryByRegionNoWait = ((int)0x8E16)        ,
        QueryByRegionNoWaitNv = ((int)0x8E16)        ,
        MaxCombinedTessControlUniformComponents = ((int)0x8E1E)        ,
        MaxCombinedTessEvaluationUniformComponents = ((int)0x8E1F)        ,
        ColorSamplesNv = ((int)0x8E20)        ,
        TransformFeedback = ((int)0x8E22)        ,
        TransformFeedbackNv = ((int)0x8E22)        ,
        TransformFeedbackBufferPaused = ((int)0x8E23)        ,
        TransformFeedbackBufferPausedNv = ((int)0x8E23)        ,
        TransformFeedbackPaused = ((int)0x8E23)        ,
        TransformFeedbackActive = ((int)0x8E24)        ,
        TransformFeedbackBufferActive = ((int)0x8E24)        ,
        TransformFeedbackBufferActiveNv = ((int)0x8E24)        ,
        TransformFeedbackBinding = ((int)0x8E25)        ,
        TransformFeedbackBindingNv = ((int)0x8E25)        ,
        FrameNv = ((int)0x8E26)        ,
        FieldsNv = ((int)0x8E27)        ,
        CurrentTimeNv = ((int)0x8E28)        ,
        Timestamp = ((int)0x8E28)        ,
        NumFillStreamsNv = ((int)0x8E29)        ,
        PresentTimeNv = ((int)0x8E2A)        ,
        PresentDurationNv = ((int)0x8E2B)        ,
        ProgramMatrixExt = ((int)0x8E2D)        ,
        TransposeProgramMatrixExt = ((int)0x8E2E)        ,
        ProgramMatrixStackDepthExt = ((int)0x8E2F)        ,
        TextureSwizzleR = ((int)0x8E42)        ,
        TextureSwizzleRExt = ((int)0x8E42)        ,
        TextureSwizzleG = ((int)0x8E43)        ,
        TextureSwizzleGExt = ((int)0x8E43)        ,
        TextureSwizzleB = ((int)0x8E44)        ,
        TextureSwizzleBExt = ((int)0x8E44)        ,
        TextureSwizzleA = ((int)0x8E45)        ,
        TextureSwizzleAExt = ((int)0x8E45)        ,
        TextureSwizzleRgba = ((int)0x8E46)        ,
        TextureSwizzleRgbaExt = ((int)0x8E46)        ,
        ActiveSubroutineUniformLocations = ((int)0x8E47)        ,
        ActiveSubroutineMaxLength = ((int)0x8E48)        ,
        ActiveSubroutineUniformMaxLength = ((int)0x8E49)        ,
        NumCompatibleSubroutines = ((int)0x8E4A)        ,
        CompatibleSubroutines = ((int)0x8E4B)        ,
        QuadsFollowProvokingVertexConvention = ((int)0x8E4C)        ,
        QuadsFollowProvokingVertexConventionExt = ((int)0x8E4C)        ,
        FirstVertexConvention = ((int)0x8E4D)        ,
        FirstVertexConventionExt = ((int)0x8E4D)        ,
        LastVertexConvention = ((int)0x8E4E)        ,
        LastVertexConventionExt = ((int)0x8E4E)        ,
        ProvokingVertex = ((int)0x8E4F)        ,
        ProvokingVertexExt = ((int)0x8E4F)        ,
        SamplePosition = ((int)0x8E50)        ,
        SamplePositionNv = ((int)0x8E50)        ,
        SampleMask = ((int)0x8E51)        ,
        SampleMaskNv = ((int)0x8E51)        ,
        SampleMaskValue = ((int)0x8E52)        ,
        SampleMaskValueNv = ((int)0x8E52)        ,
        TextureBindingRenderbufferNv = ((int)0x8E53)        ,
        TextureRenderbufferDataStoreBindingNv = ((int)0x8E54)        ,
        TextureRenderbufferNv = ((int)0x8E55)        ,
        SamplerRenderbufferNv = ((int)0x8E56)        ,
        IntSamplerRenderbufferNv = ((int)0x8E57)        ,
        UnsignedIntSamplerRenderbufferNv = ((int)0x8E58)        ,
        MaxSampleMaskWords = ((int)0x8E59)        ,
        MaxSampleMaskWordsNv = ((int)0x8E59)        ,
        MaxGeometryProgramInvocationsNv = ((int)0x8E5A)        ,
        MaxGeometryShaderInvocations = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffset = ((int)0x8E5B)        ,
        MinFragmentInterpolationOffsetNv = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffset = ((int)0x8E5C)        ,
        MaxFragmentInterpolationOffsetNv = ((int)0x8E5C)        ,
        FragmentInterpolationOffsetBits = ((int)0x8E5D)        ,
        FragmentProgramInterpolationOffsetBitsNv = ((int)0x8E5D)        ,
        MinProgramTextureGatherOffset = ((int)0x8E5E)        ,
        MinProgramTextureGatherOffsetArb = ((int)0x8E5E)        ,
        MinProgramTextureGatherOffsetNv = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffset = ((int)0x8E5F)        ,
        MaxProgramTextureGatherOffsetArb = ((int)0x8E5F)        ,
        MaxProgramTextureGatherOffsetNv = ((int)0x8E5F)        ,
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
        BufferGpuAddressNv = ((int)0x8F1D)        ,
        VertexAttribArrayUnifiedNv = ((int)0x8F1E)        ,
        ElementArrayUnifiedNv = ((int)0x8F1F)        ,
        VertexAttribArrayAddressNv = ((int)0x8F20)        ,
        VertexArrayAddressNv = ((int)0x8F21)        ,
        NormalArrayAddressNv = ((int)0x8F22)        ,
        ColorArrayAddressNv = ((int)0x8F23)        ,
        IndexArrayAddressNv = ((int)0x8F24)        ,
        TextureCoordArrayAddressNv = ((int)0x8F25)        ,
        EdgeFlagArrayAddressNv = ((int)0x8F26)        ,
        SecondaryColorArrayAddressNv = ((int)0x8F27)        ,
        FogCoordArrayAddressNv = ((int)0x8F28)        ,
        ElementArrayAddressNv = ((int)0x8F29)        ,
        VertexAttribArrayLengthNv = ((int)0x8F2A)        ,
        VertexArrayLengthNv = ((int)0x8F2B)        ,
        NormalArrayLengthNv = ((int)0x8F2C)        ,
        ColorArrayLengthNv = ((int)0x8F2D)        ,
        IndexArrayLengthNv = ((int)0x8F2E)        ,
        TextureCoordArrayLengthNv = ((int)0x8F2F)        ,
        EdgeFlagArrayLengthNv = ((int)0x8F30)        ,
        SecondaryColorArrayLengthNv = ((int)0x8F31)        ,
        FogCoordArrayLengthNv = ((int)0x8F32)        ,
        ElementArrayLengthNv = ((int)0x8F33)        ,
        GpuAddressNv = ((int)0x8F34)        ,
        MaxShaderBufferAddressNv = ((int)0x8F35)        ,
        CopyReadBuffer = ((int)0x8F36)        ,
        CopyReadBufferBinding = ((int)0x8F36)        ,
        CopyWriteBuffer = ((int)0x8F37)        ,
        CopyWriteBufferBinding = ((int)0x8F37)        ,
        MaxImageUnits = ((int)0x8F38)        ,
        MaxImageUnitsExt = ((int)0x8F38)        ,
        MaxCombinedImageUnitsAndFragmentOutputs = ((int)0x8F39)        ,
        MaxCombinedImageUnitsAndFragmentOutputsExt = ((int)0x8F39)        ,
        MaxCombinedShaderOutputResources = ((int)0x8F39)        ,
        ImageBindingName = ((int)0x8F3A)        ,
        ImageBindingNameExt = ((int)0x8F3A)        ,
        ImageBindingLevel = ((int)0x8F3B)        ,
        ImageBindingLevelExt = ((int)0x8F3B)        ,
        ImageBindingLayered = ((int)0x8F3C)        ,
        ImageBindingLayeredExt = ((int)0x8F3C)        ,
        ImageBindingLayer = ((int)0x8F3D)        ,
        ImageBindingLayerExt = ((int)0x8F3D)        ,
        ImageBindingAccess = ((int)0x8F3E)        ,
        ImageBindingAccessExt = ((int)0x8F3E)        ,
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        DrawIndirectUnifiedNv = ((int)0x8F40)        ,
        DrawIndirectAddressNv = ((int)0x8F41)        ,
        DrawIndirectLengthNv = ((int)0x8F42)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
        MaxProgramSubroutineParametersNv = ((int)0x8F44)        ,
        MaxProgramSubroutineNumNv = ((int)0x8F45)        ,
        DoubleMat2 = ((int)0x8F46)        ,
        DoubleMat2Ext = ((int)0x8F46)        ,
        DoubleMat3 = ((int)0x8F47)        ,
        DoubleMat3Ext = ((int)0x8F47)        ,
        DoubleMat4 = ((int)0x8F48)        ,
        DoubleMat4Ext = ((int)0x8F48)        ,
        DoubleMat2x3 = ((int)0x8F49)        ,
        DoubleMat2x3Ext = ((int)0x8F49)        ,
        DoubleMat2x4 = ((int)0x8F4A)        ,
        DoubleMat2x4Ext = ((int)0x8F4A)        ,
        DoubleMat3x2 = ((int)0x8F4B)        ,
        DoubleMat3x2Ext = ((int)0x8F4B)        ,
        DoubleMat3x4 = ((int)0x8F4C)        ,
        DoubleMat3x4Ext = ((int)0x8F4C)        ,
        DoubleMat4x2 = ((int)0x8F4D)        ,
        DoubleMat4x2Ext = ((int)0x8F4D)        ,
        DoubleMat4x3 = ((int)0x8F4E)        ,
        DoubleMat4x3Ext = ((int)0x8F4E)        ,
        RedSnorm = ((int)0x8F90)        ,
        RgSnorm = ((int)0x8F91)        ,
        RgbSnorm = ((int)0x8F92)        ,
        RgbaSnorm = ((int)0x8F93)        ,
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
        Int8Nv = ((int)0x8FE0)        ,
        Int8Vec2Nv = ((int)0x8FE1)        ,
        Int8Vec3Nv = ((int)0x8FE2)        ,
        Int8Vec4Nv = ((int)0x8FE3)        ,
        Int16Nv = ((int)0x8FE4)        ,
        Int16Vec2Nv = ((int)0x8FE5)        ,
        Int16Vec3Nv = ((int)0x8FE6)        ,
        Int16Vec4Nv = ((int)0x8FE7)        ,
        Int64Vec2Nv = ((int)0x8FE9)        ,
        Int64Vec3Nv = ((int)0x8FEA)        ,
        Int64Vec4Nv = ((int)0x8FEB)        ,
        UnsignedInt8Nv = ((int)0x8FEC)        ,
        UnsignedInt8Vec2Nv = ((int)0x8FED)        ,
        UnsignedInt8Vec3Nv = ((int)0x8FEE)        ,
        UnsignedInt8Vec4Nv = ((int)0x8FEF)        ,
        UnsignedInt16Nv = ((int)0x8FF0)        ,
        UnsignedInt16Vec2Nv = ((int)0x8FF1)        ,
        UnsignedInt16Vec3Nv = ((int)0x8FF2)        ,
        UnsignedInt16Vec4Nv = ((int)0x8FF3)        ,
        UnsignedInt64Vec2Nv = ((int)0x8FF5)        ,
        UnsignedInt64Vec3Nv = ((int)0x8FF6)        ,
        UnsignedInt64Vec4Nv = ((int)0x8FF7)        ,
        Float16Nv = ((int)0x8FF8)        ,
        Float16Vec2Nv = ((int)0x8FF9)        ,
        Float16Vec3Nv = ((int)0x8FFA)        ,
        Float16Vec4Nv = ((int)0x8FFB)        ,
        DoubleVec2 = ((int)0x8FFC)        ,
        DoubleVec2Ext = ((int)0x8FFC)        ,
        DoubleVec3 = ((int)0x8FFD)        ,
        DoubleVec3Ext = ((int)0x8FFD)        ,
        DoubleVec4 = ((int)0x8FFE)        ,
        DoubleVec4Ext = ((int)0x8FFE)        ,
        SamplerBufferAmd = ((int)0x9001)        ,
        IntSamplerBufferAmd = ((int)0x9002)        ,
        UnsignedIntSamplerBufferAmd = ((int)0x9003)        ,
        TessellationModeAmd = ((int)0x9004)        ,
        TessellationFactorAmd = ((int)0x9005)        ,
        DiscreteAmd = ((int)0x9006)        ,
        ContinuousAmd = ((int)0x9007)        ,
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
        AlphaSnorm = ((int)0x9010)        ,
        LuminanceSnorm = ((int)0x9011)        ,
        LuminanceAlphaSnorm = ((int)0x9012)        ,
        IntensitySnorm = ((int)0x9013)        ,
        Alpha8Snorm = ((int)0x9014)        ,
        Luminance8Snorm = ((int)0x9015)        ,
        Luminance8Alpha8Snorm = ((int)0x9016)        ,
        Intensity8Snorm = ((int)0x9017)        ,
        Alpha16Snorm = ((int)0x9018)        ,
        Luminance16Snorm = ((int)0x9019)        ,
        Luminance16Alpha16Snorm = ((int)0x901A)        ,
        Intensity16Snorm = ((int)0x901B)        ,
        FactorMinAmd = ((int)0x901C)        ,
        FactorMaxAmd = ((int)0x901D)        ,
        DepthClampNearAmd = ((int)0x901E)        ,
        DepthClampFarAmd = ((int)0x901F)        ,
        VideoBufferNv = ((int)0x9020)        ,
        VideoBufferBindingNv = ((int)0x9021)        ,
        FieldUpperNv = ((int)0x9022)        ,
        FieldLowerNv = ((int)0x9023)        ,
        NumVideoCaptureStreamsNv = ((int)0x9024)        ,
        NextVideoCaptureBufferStatusNv = ((int)0x9025)        ,
        VideoCaptureTo422SupportedNv = ((int)0x9026)        ,
        LastVideoCaptureStatusNv = ((int)0x9027)        ,
        VideoBufferPitchNv = ((int)0x9028)        ,
        VideoColorConversionMatrixNv = ((int)0x9029)        ,
        VideoColorConversionMaxNv = ((int)0x902A)        ,
        VideoColorConversionMinNv = ((int)0x902B)        ,
        VideoColorConversionOffsetNv = ((int)0x902C)        ,
        VideoBufferInternalFormatNv = ((int)0x902D)        ,
        PartialSuccessNv = ((int)0x902E)        ,
        SuccessNv = ((int)0x902F)        ,
        FailureNv = ((int)0x9030)        ,
        Ycbycr8422Nv = ((int)0x9031)        ,
        Ycbaycr8A4224Nv = ((int)0x9032)        ,
        Z6y10z6cb10z6y10z6cr10422Nv = ((int)0x9033)        ,
        Z6y10z6cb10z6A10z6y10z6cr10z6A104224Nv = ((int)0x9034)        ,
        Z4y12z4cb12z4y12z4cr12422Nv = ((int)0x9035)        ,
        Z4y12z4cb12z4A12z4y12z4cr12z4A124224Nv = ((int)0x9036)        ,
        Z4y12z4cb12z4cr12444Nv = ((int)0x9037)        ,
        VideoCaptureFrameWidthNv = ((int)0x9038)        ,
        VideoCaptureFrameHeightNv = ((int)0x9039)        ,
        VideoCaptureFieldUpperHeightNv = ((int)0x903A)        ,
        VideoCaptureFieldLowerHeightNv = ((int)0x903B)        ,
        VideoCaptureSurfaceOriginNv = ((int)0x903C)        ,
        TextureCoverageSamplesNv = ((int)0x9045)        ,
        TextureColorSamplesNv = ((int)0x9046)        ,
        Image1D = ((int)0x904C)        ,
        Image1DExt = ((int)0x904C)        ,
        Image2D = ((int)0x904D)        ,
        Image2DExt = ((int)0x904D)        ,
        Image3D = ((int)0x904E)        ,
        Image3DExt = ((int)0x904E)        ,
        Image2DRect = ((int)0x904F)        ,
        Image2DRectExt = ((int)0x904F)        ,
        ImageCube = ((int)0x9050)        ,
        ImageCubeExt = ((int)0x9050)        ,
        ImageBuffer = ((int)0x9051)        ,
        ImageBufferExt = ((int)0x9051)        ,
        Image1DArray = ((int)0x9052)        ,
        Image1DArrayExt = ((int)0x9052)        ,
        Image2DArray = ((int)0x9053)        ,
        Image2DArrayExt = ((int)0x9053)        ,
        ImageCubeMapArray = ((int)0x9054)        ,
        ImageCubeMapArrayExt = ((int)0x9054)        ,
        Image2DMultisample = ((int)0x9055)        ,
        Image2DMultisampleExt = ((int)0x9055)        ,
        Image2DMultisampleArray = ((int)0x9056)        ,
        Image2DMultisampleArrayExt = ((int)0x9056)        ,
        IntImage1D = ((int)0x9057)        ,
        IntImage1DExt = ((int)0x9057)        ,
        IntImage2D = ((int)0x9058)        ,
        IntImage2DExt = ((int)0x9058)        ,
        IntImage3D = ((int)0x9059)        ,
        IntImage3DExt = ((int)0x9059)        ,
        IntImage2DRect = ((int)0x905A)        ,
        IntImage2DRectExt = ((int)0x905A)        ,
        IntImageCube = ((int)0x905B)        ,
        IntImageCubeExt = ((int)0x905B)        ,
        IntImageBuffer = ((int)0x905C)        ,
        IntImageBufferExt = ((int)0x905C)        ,
        IntImage1DArray = ((int)0x905D)        ,
        IntImage1DArrayExt = ((int)0x905D)        ,
        IntImage2DArray = ((int)0x905E)        ,
        IntImage2DArrayExt = ((int)0x905E)        ,
        IntImageCubeMapArray = ((int)0x905F)        ,
        IntImageCubeMapArrayExt = ((int)0x905F)        ,
        IntImage2DMultisample = ((int)0x9060)        ,
        IntImage2DMultisampleExt = ((int)0x9060)        ,
        IntImage2DMultisampleArray = ((int)0x9061)        ,
        IntImage2DMultisampleArrayExt = ((int)0x9061)        ,
        UnsignedIntImage1D = ((int)0x9062)        ,
        UnsignedIntImage1DExt = ((int)0x9062)        ,
        UnsignedIntImage2D = ((int)0x9063)        ,
        UnsignedIntImage2DExt = ((int)0x9063)        ,
        UnsignedIntImage3D = ((int)0x9064)        ,
        UnsignedIntImage3DExt = ((int)0x9064)        ,
        UnsignedIntImage2DRect = ((int)0x9065)        ,
        UnsignedIntImage2DRectExt = ((int)0x9065)        ,
        UnsignedIntImageCube = ((int)0x9066)        ,
        UnsignedIntImageCubeExt = ((int)0x9066)        ,
        UnsignedIntImageBuffer = ((int)0x9067)        ,
        UnsignedIntImageBufferExt = ((int)0x9067)        ,
        UnsignedIntImage1DArray = ((int)0x9068)        ,
        UnsignedIntImage1DArrayExt = ((int)0x9068)        ,
        UnsignedIntImage2DArray = ((int)0x9069)        ,
        UnsignedIntImage2DArrayExt = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArray = ((int)0x906A)        ,
        UnsignedIntImageCubeMapArrayExt = ((int)0x906A)        ,
        UnsignedIntImage2DMultisample = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleExt = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArray = ((int)0x906C)        ,
        UnsignedIntImage2DMultisampleArrayExt = ((int)0x906C)        ,
        MaxImageSamples = ((int)0x906D)        ,
        MaxImageSamplesExt = ((int)0x906D)        ,
        ImageBindingFormat = ((int)0x906E)        ,
        ImageBindingFormatExt = ((int)0x906E)        ,
        Rgb10A2ui = ((int)0x906F)        ,
        PathFormatSvgNv = ((int)0x9070)        ,
        PathFormatPsNv = ((int)0x9071)        ,
        StandardFontNameNv = ((int)0x9072)        ,
        SystemFontNameNv = ((int)0x9073)        ,
        FileNameNv = ((int)0x9074)        ,
        PathStrokeWidthNv = ((int)0x9075)        ,
        PathEndCapsNv = ((int)0x9076)        ,
        PathInitialEndCapNv = ((int)0x9077)        ,
        PathTerminalEndCapNv = ((int)0x9078)        ,
        PathJoinStyleNv = ((int)0x9079)        ,
        PathMiterLimitNv = ((int)0x907A)        ,
        PathDashCapsNv = ((int)0x907B)        ,
        PathInitialDashCapNv = ((int)0x907C)        ,
        PathTerminalDashCapNv = ((int)0x907D)        ,
        PathDashOffsetNv = ((int)0x907E)        ,
        PathClientLengthNv = ((int)0x907F)        ,
        PathFillModeNv = ((int)0x9080)        ,
        PathFillMaskNv = ((int)0x9081)        ,
        PathFillCoverModeNv = ((int)0x9082)        ,
        PathStrokeCoverModeNv = ((int)0x9083)        ,
        PathStrokeMaskNv = ((int)0x9084)        ,
        CountUpNv = ((int)0x9088)        ,
        CountDownNv = ((int)0x9089)        ,
        PathObjectBoundingBoxNv = ((int)0x908A)        ,
        ConvexHullNv = ((int)0x908B)        ,
        BoundingBoxNv = ((int)0x908D)        ,
        TranslateXNv = ((int)0x908E)        ,
        TranslateYNv = ((int)0x908F)        ,
        Translate2DNv = ((int)0x9090)        ,
        Translate3DNv = ((int)0x9091)        ,
        Affine2DNv = ((int)0x9092)        ,
        Affine3DNv = ((int)0x9094)        ,
        TransposeAffine2DNv = ((int)0x9096)        ,
        TransposeAffine3DNv = ((int)0x9098)        ,
        Utf8Nv = ((int)0x909A)        ,
        Utf16Nv = ((int)0x909B)        ,
        BoundingBoxOfBoundingBoxesNv = ((int)0x909C)        ,
        PathCommandCountNv = ((int)0x909D)        ,
        PathCoordCountNv = ((int)0x909E)        ,
        PathDashArrayCountNv = ((int)0x909F)        ,
        PathComputedLengthNv = ((int)0x90A0)        ,
        PathFillBoundingBoxNv = ((int)0x90A1)        ,
        PathStrokeBoundingBoxNv = ((int)0x90A2)        ,
        SquareNv = ((int)0x90A3)        ,
        RoundNv = ((int)0x90A4)        ,
        TriangularNv = ((int)0x90A5)        ,
        BevelNv = ((int)0x90A6)        ,
        MiterRevertNv = ((int)0x90A7)        ,
        MiterTruncateNv = ((int)0x90A8)        ,
        SkipMissingGlyphNv = ((int)0x90A9)        ,
        UseMissingGlyphNv = ((int)0x90AA)        ,
        PathErrorPositionNv = ((int)0x90AB)        ,
        PathFogGenModeNv = ((int)0x90AC)        ,
        AccumAdjacentPairsNv = ((int)0x90AD)        ,
        AdjacentPairsNv = ((int)0x90AE)        ,
        FirstToRestNv = ((int)0x90AF)        ,
        PathGenModeNv = ((int)0x90B0)        ,
        PathGenCoeffNv = ((int)0x90B1)        ,
        PathGenColorFormatNv = ((int)0x90B2)        ,
        PathGenComponentsNv = ((int)0x90B3)        ,
        PathDashOffsetResetNv = ((int)0x90B4)        ,
        MoveToResetsNv = ((int)0x90B5)        ,
        MoveToContinuesNv = ((int)0x90B6)        ,
        PathStencilFuncNv = ((int)0x90B7)        ,
        PathStencilRefNv = ((int)0x90B8)        ,
        PathStencilValueMaskNv = ((int)0x90B9)        ,
        ScaledResolveFastestExt = ((int)0x90BA)        ,
        ScaledResolveNicestExt = ((int)0x90BB)        ,
        MinMapBufferAlignment = ((int)0x90BC)        ,
        PathStencilDepthOffsetFactorNv = ((int)0x90BD)        ,
        PathStencilDepthOffsetUnitsNv = ((int)0x90BE)        ,
        PathCoverDepthFuncNv = ((int)0x90BF)        ,
        ImageFormatCompatibilityType = ((int)0x90C7)        ,
        ImageFormatCompatibilityBySize = ((int)0x90C8)        ,
        ImageFormatCompatibilityByClass = ((int)0x90C9)        ,
        MaxVertexImageUniforms = ((int)0x90CA)        ,
        MaxTessControlImageUniforms = ((int)0x90CB)        ,
        MaxTessEvaluationImageUniforms = ((int)0x90CC)        ,
        MaxGeometryImageUniforms = ((int)0x90CD)        ,
        MaxFragmentImageUniforms = ((int)0x90CE)        ,
        MaxCombinedImageUniforms = ((int)0x90CF)        ,
        MaxDeep3DTextureWidthHeightNv = ((int)0x90D0)        ,
        MaxDeep3DTextureDepthNv = ((int)0x90D1)        ,
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
        SyncX11FenceExt = ((int)0x90E1)        ,
        DepthStencilTextureMode = ((int)0x90EA)        ,
        MaxComputeFixedGroupInvocationsArb = ((int)0x90EB)        ,
        MaxComputeWorkGroupInvocations = ((int)0x90EB)        ,
        UniformBlockReferencedByComputeShader = ((int)0x90EC)        ,
        AtomicCounterBufferReferencedByComputeShader = ((int)0x90ED)        ,
        DispatchIndirectBuffer = ((int)0x90EE)        ,
        DispatchIndirectBufferBinding = ((int)0x90EF)        ,
        ComputeProgramNv = ((int)0x90FB)        ,
        ComputeProgramParameterBufferNv = ((int)0x90FC)        ,
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
        MaxDebugMessageLengthAmd = ((int)0x9143)        ,
        MaxDebugMessageLengthArb = ((int)0x9143)        ,
        MaxDebugMessageLengthKhr = ((int)0x9143)        ,
        MaxDebugLoggedMessages = ((int)0x9144)        ,
        MaxDebugLoggedMessagesAmd = ((int)0x9144)        ,
        MaxDebugLoggedMessagesArb = ((int)0x9144)        ,
        MaxDebugLoggedMessagesKhr = ((int)0x9144)        ,
        DebugLoggedMessages = ((int)0x9145)        ,
        DebugLoggedMessagesAmd = ((int)0x9145)        ,
        DebugLoggedMessagesArb = ((int)0x9145)        ,
        DebugLoggedMessagesKhr = ((int)0x9145)        ,
        DebugSeverityHigh = ((int)0x9146)        ,
        DebugSeverityHighAmd = ((int)0x9146)        ,
        DebugSeverityHighArb = ((int)0x9146)        ,
        DebugSeverityHighKhr = ((int)0x9146)        ,
        DebugSeverityMedium = ((int)0x9147)        ,
        DebugSeverityMediumAmd = ((int)0x9147)        ,
        DebugSeverityMediumArb = ((int)0x9147)        ,
        DebugSeverityMediumKhr = ((int)0x9147)        ,
        DebugSeverityLow = ((int)0x9148)        ,
        DebugSeverityLowAmd = ((int)0x9148)        ,
        DebugSeverityLowArb = ((int)0x9148)        ,
        DebugSeverityLowKhr = ((int)0x9148)        ,
        DebugCategoryApiErrorAmd = ((int)0x9149)        ,
        DebugCategoryWindowSystemAmd = ((int)0x914A)        ,
        DebugCategoryDeprecationAmd = ((int)0x914B)        ,
        DebugCategoryUndefinedBehaviorAmd = ((int)0x914C)        ,
        DebugCategoryPerformanceAmd = ((int)0x914D)        ,
        DebugCategoryShaderCompilerAmd = ((int)0x914E)        ,
        DebugCategoryApplicationAmd = ((int)0x914F)        ,
        DebugCategoryOtherAmd = ((int)0x9150)        ,
        BufferObjectExt = ((int)0x9151)        ,
        DataBufferAmd = ((int)0x9151)        ,
        PerformanceMonitorAmd = ((int)0x9152)        ,
        QueryObjectAmd = ((int)0x9153)        ,
        QueryObjectExt = ((int)0x9153)        ,
        VertexArrayObjectAmd = ((int)0x9154)        ,
        VertexArrayObjectExt = ((int)0x9154)        ,
        SamplerObjectAmd = ((int)0x9155)        ,
        ExternalVirtualMemoryBufferAmd = ((int)0x9160)        ,
        QueryBuffer = ((int)0x9192)        ,
        QueryBufferAmd = ((int)0x9192)        ,
        QueryBufferBinding = ((int)0x9193)        ,
        QueryBufferBindingAmd = ((int)0x9193)        ,
        QueryResultNoWait = ((int)0x9194)        ,
        QueryResultNoWaitAmd = ((int)0x9194)        ,
        VirtualPageSizeXAmd = ((int)0x9195)        ,
        VirtualPageSizeXArb = ((int)0x9195)        ,
        VirtualPageSizeYAmd = ((int)0x9196)        ,
        VirtualPageSizeYArb = ((int)0x9196)        ,
        VirtualPageSizeZAmd = ((int)0x9197)        ,
        VirtualPageSizeZArb = ((int)0x9197)        ,
        MaxSparseTextureSizeAmd = ((int)0x9198)        ,
        MaxSparseTextureSizeArb = ((int)0x9198)        ,
        MaxSparse3DTextureSizeAmd = ((int)0x9199)        ,
        MaxSparse3DTextureSizeArb = ((int)0x9199)        ,
        MaxSparseArrayTextureLayers = ((int)0x919A)        ,
        MaxSparseArrayTextureLayersArb = ((int)0x919A)        ,
        MinSparseLevelAmd = ((int)0x919B)        ,
        MinSparseLevelArb = ((int)0x919B)        ,
        MinLodWarningAmd = ((int)0x919C)        ,
        TextureBufferOffset = ((int)0x919D)        ,
        TextureBufferSize = ((int)0x919E)        ,
        TextureBufferOffsetAlignment = ((int)0x919F)        ,
        VertexElementSwizzleAmd = ((int)0x91A4)        ,
        VertexIdSwizzleAmd = ((int)0x91A5)        ,
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
        RestartPathNv = ((int)0xF0)        ,
        DupFirstCubicCurveToNv = ((int)0xF2)        ,
        DupLastCubicCurveToNv = ((int)0xF4)        ,
        RectNv = ((int)0xF6)        ,
        CircularCcwArcToNv = ((int)0xF8)        ,
        CircularCwArcToNv = ((int)0xFA)        ,
        CircularTangentArcToNv = ((int)0xFC)        ,
        ArcToNv = ((int)0xFE)        ,
        RelativeArcToNv = ((int)0xFF)        ,
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
        LayoutLinearIntel = ((int)1)        ,
        One = ((int)1)        ,
        True = ((int)1)        ,
        CullVertexIbm = ((int)103050)        ,
        AllStaticDataIbm = ((int)103060)        ,
        StaticVertexArrayIbm = ((int)103061)        ,
        VertexArrayListIbm = ((int)103070)        ,
        NormalArrayListIbm = ((int)103071)        ,
        ColorArrayListIbm = ((int)103072)        ,
        IndexArrayListIbm = ((int)103073)        ,
        TextureCoordArrayListIbm = ((int)103074)        ,
        EdgeFlagArrayListIbm = ((int)103075)        ,
        FogCoordinateArrayListIbm = ((int)103076)        ,
        SecondaryColorArrayListIbm = ((int)103077)        ,
        VertexArrayListStrideIbm = ((int)103080)        ,
        NormalArrayListStrideIbm = ((int)103081)        ,
        ColorArrayListStrideIbm = ((int)103082)        ,
        IndexArrayListStrideIbm = ((int)103083)        ,
        TextureCoordArrayListStrideIbm = ((int)103084)        ,
        EdgeFlagArrayListStrideIbm = ((int)103085)        ,
        FogCoordinateArrayListStrideIbm = ((int)103086)        ,
        SecondaryColorArrayListStrideIbm = ((int)103087)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
        Two = ((int)2)        ,
        NextBufferNv = ((int)-2)        ,
        Three = ((int)3)        ,
        SkipComponents4Nv = ((int)-3)        ,
        Four = ((int)4)        ,
        SkipComponents3Nv = ((int)-4)        ,
        SkipComponents2Nv = ((int)-5)        ,
        SkipComponents1Nv = ((int)-6)        ,
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
    public enum AmdBlendMinmaxFactor : int
    {
        FactorMinAmd = ((int)0x901C)        ,
        FactorMaxAmd = ((int)0x901D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdConservativeDepth : int
    {
    }

    /// <summary>
    /// Used in GL.Amd.DebugMessageEnable, GL.Amd.DebugMessageInsert and 1 other function
    /// </summary>
    public enum AmdDebugOutput : int
    {
        MaxDebugMessageLengthAmd = ((int)0x9143)        ,
        MaxDebugLoggedMessagesAmd = ((int)0x9144)        ,
        DebugLoggedMessagesAmd = ((int)0x9145)        ,
        DebugSeverityHighAmd = ((int)0x9146)        ,
        DebugSeverityMediumAmd = ((int)0x9147)        ,
        DebugSeverityLowAmd = ((int)0x9148)        ,
        DebugCategoryApiErrorAmd = ((int)0x9149)        ,
        DebugCategoryWindowSystemAmd = ((int)0x914A)        ,
        DebugCategoryDeprecationAmd = ((int)0x914B)        ,
        DebugCategoryUndefinedBehaviorAmd = ((int)0x914C)        ,
        DebugCategoryPerformanceAmd = ((int)0x914D)        ,
        DebugCategoryShaderCompilerAmd = ((int)0x914E)        ,
        DebugCategoryApplicationAmd = ((int)0x914F)        ,
        DebugCategoryOtherAmd = ((int)0x9150)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdDepthClampSeparate : int
    {
        DepthClampNearAmd = ((int)0x901E)        ,
        DepthClampFarAmd = ((int)0x901F)        ,
    }

    /// <summary>
    /// Used in GL.Amd.BlendEquationIndexed, GL.Amd.BlendEquationSeparateIndexed and 2 other functions
    /// </summary>
    public enum AmdDrawBuffersBlend : int
    {
    }

    /// <summary>
    /// Used in GL.Amd.VertexAttribParameter
    /// </summary>
    public enum AmdInterleavedElements : int
    {
        Red = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Alpha = ((int)0x1906)        ,
        Rg8ui = ((int)0x8238)        ,
        Rg16ui = ((int)0x823A)        ,
        Rgba8ui = ((int)0x8D7C)        ,
        VertexElementSwizzleAmd = ((int)0x91A4)        ,
        VertexIdSwizzleAmd = ((int)0x91A5)        ,
    }

    /// <summary>
    /// Used in GL.Amd.MultiDrawArraysIndirect, GL.Amd.MultiDrawElementsIndirect
    /// </summary>
    public enum AmdMultiDrawIndirect : int
    {
    }

    /// <summary>
    /// Used in GL.Amd.DeleteNames, GL.Amd.GenNames and 1 other function
    /// </summary>
    public enum AmdNameGenDelete : int
    {
        DataBufferAmd = ((int)0x9151)        ,
        PerformanceMonitorAmd = ((int)0x9152)        ,
        QueryObjectAmd = ((int)0x9153)        ,
        VertexArrayObjectAmd = ((int)0x9154)        ,
        SamplerObjectAmd = ((int)0x9155)        ,
    }

    /// <summary>
    /// Used in GL.Amd.QueryObjectParameter
    /// </summary>
    public enum AmdOcclusionQueryEvent : int
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
        /// Original was GL_OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F
        /// </summary>
        OcclusionQueryEventMaskAmd = ((int)0x874F)        ,
        /// <summary>
        /// Original was GL_QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF
        /// </summary>
        QueryAllEventBitsAmd = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Used in GL.Amd.GetPerfMonitorCounterData, GL.Amd.GetPerfMonitorCounterInfo
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
    public enum AmdPinnedMemory : int
    {
        ExternalVirtualMemoryBufferAmd = ((int)0x9160)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdQueryBufferObject : int
    {
        QueryBufferAmd = ((int)0x9192)        ,
        QueryBufferBindingAmd = ((int)0x9193)        ,
        QueryResultNoWaitAmd = ((int)0x9194)        ,
    }

    /// <summary>
    /// Used in GL.Amd.SetMultisample
    /// </summary>
    public enum AmdSamplePositions : int
    {
        SubsampleDistanceAmd = ((int)0x883F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdSeamlessCubemapPerTexture : int
    {
        TextureCubeMapSeamless = ((int)0x884F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdShaderAtomicCounterOps : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdShaderStencilExport : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdShaderTrinaryMinmax : int
    {
    }

    /// <summary>
    /// Used in GL.Amd.TexStorageSparse, GL.Amd.TextureStorageSparse
    /// </summary>
    public enum AmdSparseTexture : int
    {
        TextureStorageSparseBitAmd = ((int)0x00000001)        ,
        VirtualPageSizeXAmd = ((int)0x9195)        ,
        VirtualPageSizeYAmd = ((int)0x9196)        ,
        VirtualPageSizeZAmd = ((int)0x9197)        ,
        MaxSparseTextureSizeAmd = ((int)0x9198)        ,
        MaxSparse3DTextureSizeAmd = ((int)0x9199)        ,
        MaxSparseArrayTextureLayers = ((int)0x919A)        ,
        MinSparseLevelAmd = ((int)0x919B)        ,
        MinLodWarningAmd = ((int)0x919C)        ,
    }

    /// <summary>
    /// Used in GL.Amd.StencilOpValue
    /// </summary>
    public enum AmdStencilOperationExtended : int
    {
        SetAmd = ((int)0x874A)        ,
        ReplaceValueAmd = ((int)0x874B)        ,
        StencilOpValueAmd = ((int)0x874C)        ,
        StencilBackOpValueAmd = ((int)0x874D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdTextureTexture4 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdTransformFeedback3LinesTriangles : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdVertexShaderLayer : int
    {
    }

    /// <summary>
    /// Used in GL.Amd.TessellationMode
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
    /// Used in GL.Amd.TessellationMode
    /// </summary>
    public enum AmdVertexShaderTessellator : int
    {
        SamplerBufferAmd = ((int)0x9001)        ,
        IntSamplerBufferAmd = ((int)0x9002)        ,
        UnsignedIntSamplerBufferAmd = ((int)0x9003)        ,
        TessellationModeAmd = ((int)0x9004)        ,
        TessellationFactorAmd = ((int)0x9005)        ,
        DiscreteAmd = ((int)0x9006)        ,
        ContinuousAmd = ((int)0x9007)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdVertexShaderViewportIndex : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleAuxDepthStencil : int
    {
        AuxDepthStencilApple = ((int)0x8A14)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleClientStorage : int
    {
        UnpackClientStorageApple = ((int)0x85B2)        ,
    }

    /// <summary>
    /// Used in GL.Apple.ElementPointer
    /// </summary>
    public enum AppleElementArray : int
    {
        ElementArrayApple = ((int)0x8A0C)        ,
        ElementArrayTypeApple = ((int)0x8A0D)        ,
        ElementArrayPointerApple = ((int)0x8A0E)        ,
    }

    /// <summary>
    /// Used in GL.Apple.FinishObject, GL.Apple.TestObject
    /// </summary>
    public enum AppleFence : int
    {
        DrawPixelsApple = ((int)0x8A0A)        ,
        FenceApple = ((int)0x8A0B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFloatPixels : int
    {
        HalfApple = ((int)0x140B)        ,
        RgbaFloat32Apple = ((int)0x8814)        ,
        RgbFloat32Apple = ((int)0x8815)        ,
        AlphaFloat32Apple = ((int)0x8816)        ,
        IntensityFloat32Apple = ((int)0x8817)        ,
        LuminanceFloat32Apple = ((int)0x8818)        ,
        LuminanceAlphaFloat32Apple = ((int)0x8819)        ,
        RgbaFloat16Apple = ((int)0x881A)        ,
        RgbFloat16Apple = ((int)0x881B)        ,
        AlphaFloat16Apple = ((int)0x881C)        ,
        IntensityFloat16Apple = ((int)0x881D)        ,
        LuminanceFloat16Apple = ((int)0x881E)        ,
        LuminanceAlphaFloat16Apple = ((int)0x881F)        ,
        ColorFloatApple = ((int)0x8A0F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFlushBufferRange : int
    {
        BufferSerializedModifyApple = ((int)0x8A12)        ,
        BufferFlushingUnmapApple = ((int)0x8A13)        ,
    }

    /// <summary>
    /// Used in GL.Apple.GetObjectParameter, GL.Apple.ObjectPurgeable and 1 other function
    /// </summary>
    public enum AppleObjectPurgeable : int
    {
        BufferObjectApple = ((int)0x85B3)        ,
        ReleasedApple = ((int)0x8A19)        ,
        VolatileApple = ((int)0x8A1A)        ,
        RetainedApple = ((int)0x8A1B)        ,
        UndefinedApple = ((int)0x8A1C)        ,
        PurgeableApple = ((int)0x8A1D)        ,
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
    public enum AppleRowBytes : int
    {
        PackRowBytesApple = ((int)0x8A15)        ,
        UnpackRowBytesApple = ((int)0x8A16)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleSpecularVector : int
    {
        LightModelSpecularVectorApple = ((int)0x85B0)        ,
    }

    /// <summary>
    /// Used in GL.Apple.GetTexParameterPointer, GL.Apple.TextureRange
    /// </summary>
    public enum AppleTextureRange : int
    {
        TextureRangeLengthApple = ((int)0x85B7)        ,
        TextureRangePointerApple = ((int)0x85B8)        ,
        TextureStorageHintApple = ((int)0x85BC)        ,
        StoragePrivateApple = ((int)0x85BD)        ,
        StorageCachedApple = ((int)0x85BE)        ,
        StorageSharedApple = ((int)0x85BF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTransformHint : int
    {
        TransformHintApple = ((int)0x85B1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleVertexArrayObject : int
    {
        VertexArrayBindingApple = ((int)0x85B5)        ,
    }

    /// <summary>
    /// Used in GL.Apple.VertexArrayParameter
    /// </summary>
    public enum AppleVertexArrayRange : int
    {
        VertexArrayRangeApple = ((int)0x851D)        ,
        VertexArrayRangeLengthApple = ((int)0x851E)        ,
        VertexArrayStorageHintApple = ((int)0x851F)        ,
        VertexArrayRangePointerApple = ((int)0x8521)        ,
        StorageClientApple = ((int)0x85B4)        ,
        StorageCachedApple = ((int)0x85BE)        ,
        StorageSharedApple = ((int)0x85BF)        ,
    }

    /// <summary>
    /// Used in GL.Apple.DisableVertexAttrib, GL.Apple.EnableVertexAttrib and 1 other function
    /// </summary>
    public enum AppleVertexProgramEvaluators : int
    {
        VertexAttribMap1Apple = ((int)0x8A00)        ,
        VertexAttribMap2Apple = ((int)0x8A01)        ,
        VertexAttribMap1SizeApple = ((int)0x8A02)        ,
        VertexAttribMap1CoeffApple = ((int)0x8A03)        ,
        VertexAttribMap1OrderApple = ((int)0x8A04)        ,
        VertexAttribMap1DomainApple = ((int)0x8A05)        ,
        VertexAttribMap2SizeApple = ((int)0x8A06)        ,
        VertexAttribMap2CoeffApple = ((int)0x8A07)        ,
        VertexAttribMap2OrderApple = ((int)0x8A08)        ,
        VertexAttribMap2DomainApple = ((int)0x8A09)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleYcbcr422 : int
    {
        Ycbcr422Apple = ((int)0x85B9)        ,
        UnsignedShort88Apple = ((int)0x85BA)        ,
        UnsignedShort88RevApple = ((int)0x85BB)        ,
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
    /// Used in GL.Arb.GetImageHandle, GL.Arb.MakeImageHandleResident
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
    /// Used in GL.Arb.ClampColor
    /// </summary>
    public enum ArbColorBufferFloat : int
    {
        RgbaFloatModeArb = ((int)0x8820)        ,
        ClampVertexColorArb = ((int)0x891A)        ,
        ClampFragmentColorArb = ((int)0x891B)        ,
        ClampReadColorArb = ((int)0x891C)        ,
        FixedOnlyArb = ((int)0x891D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbCompatibility : int
    {
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
    /// Used in GL.Arb.DebugMessageControl, GL.Arb.DebugMessageInsert and 1 other function
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
    public enum ArbDepthTexture : int
    {
        DepthComponent16Arb = ((int)0x81A5)        ,
        DepthComponent24Arb = ((int)0x81A6)        ,
        DepthComponent32Arb = ((int)0x81A7)        ,
        TextureDepthSizeArb = ((int)0x884A)        ,
        DepthTextureModeArb = ((int)0x884B)        ,
    }

    /// <summary>
    /// Used in GL.Arb.DrawBuffers
    /// </summary>
    public enum ArbDrawBuffers : int
    {
        MaxDrawBuffersArb = ((int)0x8824)        ,
        DrawBuffer0Arb = ((int)0x8825)        ,
        DrawBuffer1Arb = ((int)0x8826)        ,
        DrawBuffer2Arb = ((int)0x8827)        ,
        DrawBuffer3Arb = ((int)0x8828)        ,
        DrawBuffer4Arb = ((int)0x8829)        ,
        DrawBuffer5Arb = ((int)0x882A)        ,
        DrawBuffer6Arb = ((int)0x882B)        ,
        DrawBuffer7Arb = ((int)0x882C)        ,
        DrawBuffer8Arb = ((int)0x882D)        ,
        DrawBuffer9Arb = ((int)0x882E)        ,
        DrawBuffer10Arb = ((int)0x882F)        ,
        DrawBuffer11Arb = ((int)0x8830)        ,
        DrawBuffer12Arb = ((int)0x8831)        ,
        DrawBuffer13Arb = ((int)0x8832)        ,
        DrawBuffer14Arb = ((int)0x8833)        ,
        DrawBuffer15Arb = ((int)0x8834)        ,
    }

    /// <summary>
    /// Used in GL.Arb.BlendEquation, GL.Arb.BlendEquationSeparate and 5 other functions
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
    /// Used in GL.DrawArraysIndirect, GL.DrawElementsIndirect
    /// </summary>
    public enum ArbDrawIndirect : int
    {
        DrawIndirectBuffer = ((int)0x8F3F)        ,
        DrawIndirectBufferBinding = ((int)0x8F43)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbDrawInstanced : int
    {
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
    public enum ArbFragmentProgram : int
    {
        ProgramLengthArb = ((int)0x8627)        ,
        ProgramStringArb = ((int)0x8628)        ,
        MaxProgramMatrixStackDepthArb = ((int)0x862E)        ,
        MaxProgramMatricesArb = ((int)0x862F)        ,
        CurrentMatrixStackDepthArb = ((int)0x8640)        ,
        CurrentMatrixArb = ((int)0x8641)        ,
        ProgramErrorPositionArb = ((int)0x864B)        ,
        ProgramBindingArb = ((int)0x8677)        ,
        FragmentProgramArb = ((int)0x8804)        ,
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
        MaxTextureCoordsArb = ((int)0x8871)        ,
        MaxTextureImageUnitsArb = ((int)0x8872)        ,
        ProgramErrorStringArb = ((int)0x8874)        ,
        ProgramFormatAsciiArb = ((int)0x8875)        ,
        ProgramFormatArb = ((int)0x8876)        ,
        ProgramInstructionsArb = ((int)0x88A0)        ,
        MaxProgramInstructionsArb = ((int)0x88A1)        ,
        ProgramNativeInstructionsArb = ((int)0x88A2)        ,
        MaxProgramNativeInstructionsArb = ((int)0x88A3)        ,
        ProgramTemporariesArb = ((int)0x88A4)        ,
        MaxProgramTemporariesArb = ((int)0x88A5)        ,
        ProgramNativeTemporariesArb = ((int)0x88A6)        ,
        MaxProgramNativeTemporariesArb = ((int)0x88A7)        ,
        ProgramParametersArb = ((int)0x88A8)        ,
        MaxProgramParametersArb = ((int)0x88A9)        ,
        ProgramNativeParametersArb = ((int)0x88AA)        ,
        MaxProgramNativeParametersArb = ((int)0x88AB)        ,
        ProgramAttribsArb = ((int)0x88AC)        ,
        MaxProgramAttribsArb = ((int)0x88AD)        ,
        ProgramNativeAttribsArb = ((int)0x88AE)        ,
        MaxProgramNativeAttribsArb = ((int)0x88AF)        ,
        MaxProgramLocalParametersArb = ((int)0x88B4)        ,
        MaxProgramEnvParametersArb = ((int)0x88B5)        ,
        ProgramUnderNativeLimitsArb = ((int)0x88B6)        ,
        TransposeCurrentMatrixArb = ((int)0x88B7)        ,
        Matrix0Arb = ((int)0x88C0)        ,
        Matrix1Arb = ((int)0x88C1)        ,
        Matrix2Arb = ((int)0x88C2)        ,
        Matrix3Arb = ((int)0x88C3)        ,
        Matrix4Arb = ((int)0x88C4)        ,
        Matrix5Arb = ((int)0x88C5)        ,
        Matrix6Arb = ((int)0x88C6)        ,
        Matrix7Arb = ((int)0x88C7)        ,
        Matrix8Arb = ((int)0x88C8)        ,
        Matrix9Arb = ((int)0x88C9)        ,
        Matrix10Arb = ((int)0x88CA)        ,
        Matrix11Arb = ((int)0x88CB)        ,
        Matrix12Arb = ((int)0x88CC)        ,
        Matrix13Arb = ((int)0x88CD)        ,
        Matrix14Arb = ((int)0x88CE)        ,
        Matrix15Arb = ((int)0x88CF)        ,
        Matrix16Arb = ((int)0x88D0)        ,
        Matrix17Arb = ((int)0x88D1)        ,
        Matrix18Arb = ((int)0x88D2)        ,
        Matrix19Arb = ((int)0x88D3)        ,
        Matrix20Arb = ((int)0x88D4)        ,
        Matrix21Arb = ((int)0x88D5)        ,
        Matrix22Arb = ((int)0x88D6)        ,
        Matrix23Arb = ((int)0x88D7)        ,
        Matrix24Arb = ((int)0x88D8)        ,
        Matrix25Arb = ((int)0x88D9)        ,
        Matrix26Arb = ((int)0x88DA)        ,
        Matrix27Arb = ((int)0x88DB)        ,
        Matrix28Arb = ((int)0x88DC)        ,
        Matrix29Arb = ((int)0x88DD)        ,
        Matrix30Arb = ((int)0x88DE)        ,
        Matrix31Arb = ((int)0x88DF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFragmentProgramShadow : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbFragmentShader : int
    {
        FragmentShaderArb = ((int)0x8B30)        ,
        MaxFragmentUniformComponentsArb = ((int)0x8B49)        ,
        FragmentShaderDerivativeHintArb = ((int)0x8B8B)        ,
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
        TextureLuminanceType = ((int)0x8C14)        ,
        TextureIntensityType = ((int)0x8C15)        ,
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
    public enum ArbGeometryShader4 : int
    {
        LinesAdjacencyArb = ((int)0x000A)        ,
        LineStripAdjacencyArb = ((int)0x000B)        ,
        TrianglesAdjacencyArb = ((int)0x000C)        ,
        TriangleStripAdjacencyArb = ((int)0x000D)        ,
        ProgramPointSizeArb = ((int)0x8642)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
        MaxGeometryTextureImageUnitsArb = ((int)0x8C29)        ,
        FramebufferAttachmentTextureLayer = ((int)0x8CD4)        ,
        FramebufferAttachmentLayeredArb = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargetsArb = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCountArb = ((int)0x8DA9)        ,
        GeometryShaderArb = ((int)0x8DD9)        ,
        GeometryVerticesOutArb = ((int)0x8DDA)        ,
        GeometryInputTypeArb = ((int)0x8DDB)        ,
        GeometryOutputTypeArb = ((int)0x8DDC)        ,
        MaxGeometryVaryingComponentsArb = ((int)0x8DDD)        ,
        MaxVertexVaryingComponentsArb = ((int)0x8DDE)        ,
        MaxGeometryUniformComponentsArb = ((int)0x8DDF)        ,
        MaxGeometryOutputVerticesArb = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponentsArb = ((int)0x8DE1)        ,
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
    public enum ArbHalfFloatPixel : int
    {
        HalfFloatArb = ((int)0x140B)        ,
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
    /// Used in GL.Arb.MultiDrawArraysIndirectCount, GL.Arb.MultiDrawElementsIndirectCount
    /// </summary>
    public enum ArbIndirectParameters : int
    {
        ParameterBufferArb = ((int)0x80EE)        ,
        ParameterBufferBindingArb = ((int)0x80EF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbInstancedArrays : int
    {
        VertexAttribArrayDivisorArb = ((int)0x88FE)        ,
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
    /// Used in GL.Arb.MatrixIndexPointer
    /// </summary>
    public enum ArbMatrixPalette : int
    {
        MatrixPaletteArb = ((int)0x8840)        ,
        MaxMatrixPaletteStackDepthArb = ((int)0x8841)        ,
        MaxPaletteMatricesArb = ((int)0x8842)        ,
        CurrentPaletteMatrixArb = ((int)0x8843)        ,
        MatrixIndexArrayArb = ((int)0x8844)        ,
        CurrentMatrixIndexArb = ((int)0x8845)        ,
        MatrixIndexArraySizeArb = ((int)0x8846)        ,
        MatrixIndexArrayTypeArb = ((int)0x8847)        ,
        MatrixIndexArrayStrideArb = ((int)0x8848)        ,
        MatrixIndexArrayPointerArb = ((int)0x8849)        ,
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
    public enum ArbMultisample : int
    {
        MultisampleBitArb = ((int)0x20000000)        ,
        MultisampleArb = ((int)0x809D)        ,
        SampleAlphaToCoverageArb = ((int)0x809E)        ,
        SampleAlphaToOneArb = ((int)0x809F)        ,
        SampleCoverageArb = ((int)0x80A0)        ,
        SampleBuffersArb = ((int)0x80A8)        ,
        SamplesArb = ((int)0x80A9)        ,
        SampleCoverageValueArb = ((int)0x80AA)        ,
        SampleCoverageInvertArb = ((int)0x80AB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbMultitexture : int
    {
        Texture0Arb = ((int)0x84C0)        ,
        Texture1Arb = ((int)0x84C1)        ,
        Texture2Arb = ((int)0x84C2)        ,
        Texture3Arb = ((int)0x84C3)        ,
        Texture4Arb = ((int)0x84C4)        ,
        Texture5Arb = ((int)0x84C5)        ,
        Texture6Arb = ((int)0x84C6)        ,
        Texture7Arb = ((int)0x84C7)        ,
        Texture8Arb = ((int)0x84C8)        ,
        Texture9Arb = ((int)0x84C9)        ,
        Texture10Arb = ((int)0x84CA)        ,
        Texture11Arb = ((int)0x84CB)        ,
        Texture12Arb = ((int)0x84CC)        ,
        Texture13Arb = ((int)0x84CD)        ,
        Texture14Arb = ((int)0x84CE)        ,
        Texture15Arb = ((int)0x84CF)        ,
        Texture16Arb = ((int)0x84D0)        ,
        Texture17Arb = ((int)0x84D1)        ,
        Texture18Arb = ((int)0x84D2)        ,
        Texture19Arb = ((int)0x84D3)        ,
        Texture20Arb = ((int)0x84D4)        ,
        Texture21Arb = ((int)0x84D5)        ,
        Texture22Arb = ((int)0x84D6)        ,
        Texture23Arb = ((int)0x84D7)        ,
        Texture24Arb = ((int)0x84D8)        ,
        Texture25Arb = ((int)0x84D9)        ,
        Texture26Arb = ((int)0x84DA)        ,
        Texture27Arb = ((int)0x84DB)        ,
        Texture28Arb = ((int)0x84DC)        ,
        Texture29Arb = ((int)0x84DD)        ,
        Texture30Arb = ((int)0x84DE)        ,
        Texture31Arb = ((int)0x84DF)        ,
        ActiveTextureArb = ((int)0x84E0)        ,
        ClientActiveTextureArb = ((int)0x84E1)        ,
        MaxTextureUnitsArb = ((int)0x84E2)        ,
    }

    /// <summary>
    /// Used in GL.Arb.BeginQuery, GL.Arb.EndQuery and 2 other functions
    /// </summary>
    public enum ArbOcclusionQuery : int
    {
        QueryCounterBitsArb = ((int)0x8864)        ,
        CurrentQueryArb = ((int)0x8865)        ,
        QueryResultArb = ((int)0x8866)        ,
        QueryResultAvailableArb = ((int)0x8867)        ,
        SamplesPassedArb = ((int)0x8914)        ,
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
    public enum ArbPixelBufferObject : int
    {
        PixelPackBufferArb = ((int)0x88EB)        ,
        PixelUnpackBufferArb = ((int)0x88EC)        ,
        PixelPackBufferBindingArb = ((int)0x88ED)        ,
        PixelUnpackBufferBindingArb = ((int)0x88EF)        ,
    }

    /// <summary>
    /// Used in GL.Arb.PointParameter
    /// </summary>
    public enum ArbPointParameters : int
    {
        PointSizeMinArb = ((int)0x8126)        ,
        PointSizeMaxArb = ((int)0x8127)        ,
        PointFadeThresholdSizeArb = ((int)0x8128)        ,
        PointDistanceAttenuationArb = ((int)0x8129)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbPointSprite : int
    {
        PointSpriteArb = ((int)0x8861)        ,
        CoordReplaceArb = ((int)0x8862)        ,
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
    /// Used in GL.Arb.GetnColorTable, GL.Arb.GetnCompressedTexImage and 8 other functions
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
    /// Used in GL.GetSamplerParameterI, GL.SamplerParameterI
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
    /// Used in GL.Arb.CreateShaderObject, GL.Arb.GetActiveUniform and 2 other functions
    /// </summary>
    public enum ArbShaderObjects : int
    {
        ProgramObjectArb = ((int)0x8B40)        ,
        ShaderObjectArb = ((int)0x8B48)        ,
        ObjectTypeArb = ((int)0x8B4E)        ,
        ObjectSubtypeArb = ((int)0x8B4F)        ,
        FloatVec2Arb = ((int)0x8B50)        ,
        FloatVec3Arb = ((int)0x8B51)        ,
        FloatVec4Arb = ((int)0x8B52)        ,
        IntVec2Arb = ((int)0x8B53)        ,
        IntVec3Arb = ((int)0x8B54)        ,
        IntVec4Arb = ((int)0x8B55)        ,
        BoolArb = ((int)0x8B56)        ,
        BoolVec2Arb = ((int)0x8B57)        ,
        BoolVec3Arb = ((int)0x8B58)        ,
        BoolVec4Arb = ((int)0x8B59)        ,
        FloatMat2Arb = ((int)0x8B5A)        ,
        FloatMat3Arb = ((int)0x8B5B)        ,
        FloatMat4Arb = ((int)0x8B5C)        ,
        Sampler1DArb = ((int)0x8B5D)        ,
        Sampler2DArb = ((int)0x8B5E)        ,
        Sampler3DArb = ((int)0x8B5F)        ,
        SamplerCubeArb = ((int)0x8B60)        ,
        Sampler1DShadowArb = ((int)0x8B61)        ,
        Sampler2DShadowArb = ((int)0x8B62)        ,
        Sampler2DRectArb = ((int)0x8B63)        ,
        Sampler2DRectShadowArb = ((int)0x8B64)        ,
        ObjectDeleteStatusArb = ((int)0x8B80)        ,
        ObjectCompileStatusArb = ((int)0x8B81)        ,
        ObjectLinkStatusArb = ((int)0x8B82)        ,
        ObjectValidateStatusArb = ((int)0x8B83)        ,
        ObjectInfoLogLengthArb = ((int)0x8B84)        ,
        ObjectAttachedObjectsArb = ((int)0x8B85)        ,
        ObjectActiveUniformsArb = ((int)0x8B86)        ,
        ObjectActiveUniformMaxLengthArb = ((int)0x8B87)        ,
        ObjectShaderSourceLengthArb = ((int)0x8B88)        ,
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
    public enum ArbShaderTextureLod : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadingLanguage100 : int
    {
        ShadingLanguageVersionArb = ((int)0x8B8C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadingLanguage420pack : int
    {
    }

    /// <summary>
    /// Used in GL.Arb.GetNamedString, GL.Arb.NamedString
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
    public enum ArbShadow : int
    {
        TextureCompareModeArb = ((int)0x884C)        ,
        TextureCompareFuncArb = ((int)0x884D)        ,
        CompareRToTextureArb = ((int)0x884E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbShadowAmbient : int
    {
        TextureCompareFailValueArb = ((int)0x80BF)        ,
    }

    /// <summary>
    /// Used in GL.Arb.TexPageCommitment
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
    /// Used in GL.FenceSync, GL.GetInteger64 and 1 other function
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
        Quads = ((int)0x0007)        ,
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
    public enum ArbTextureBorderClamp : int
    {
        ClampToBorderArb = ((int)0x812D)        ,
    }

    /// <summary>
    /// Used in GL.Arb.TexBuffer
    /// </summary>
    public enum ArbTextureBufferObject : int
    {
        TextureBufferArb = ((int)0x8C2A)        ,
        MaxTextureBufferSizeArb = ((int)0x8C2B)        ,
        TextureBindingBufferArb = ((int)0x8C2C)        ,
        TextureBufferDataStoreBindingArb = ((int)0x8C2D)        ,
        TextureBufferFormatArb = ((int)0x8C2E)        ,
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
    public enum ArbTextureCompression : int
    {
        CompressedAlphaArb = ((int)0x84E9)        ,
        CompressedLuminanceArb = ((int)0x84EA)        ,
        CompressedLuminanceAlphaArb = ((int)0x84EB)        ,
        CompressedIntensityArb = ((int)0x84EC)        ,
        CompressedRgbArb = ((int)0x84ED)        ,
        CompressedRgbaArb = ((int)0x84EE)        ,
        TextureCompressionHintArb = ((int)0x84EF)        ,
        TextureCompressedImageSizeArb = ((int)0x86A0)        ,
        TextureCompressedArb = ((int)0x86A1)        ,
        NumCompressedTextureFormatsArb = ((int)0x86A2)        ,
        CompressedTextureFormatsArb = ((int)0x86A3)        ,
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
    public enum ArbTextureCubeMap : int
    {
        NormalMapArb = ((int)0x8511)        ,
        ReflectionMapArb = ((int)0x8512)        ,
        TextureCubeMapArb = ((int)0x8513)        ,
        TextureBindingCubeMapArb = ((int)0x8514)        ,
        TextureCubeMapPositiveXArb = ((int)0x8515)        ,
        TextureCubeMapNegativeXArb = ((int)0x8516)        ,
        TextureCubeMapPositiveYArb = ((int)0x8517)        ,
        TextureCubeMapNegativeYArb = ((int)0x8518)        ,
        TextureCubeMapPositiveZArb = ((int)0x8519)        ,
        TextureCubeMapNegativeZArb = ((int)0x851A)        ,
        ProxyTextureCubeMapArb = ((int)0x851B)        ,
        MaxCubeMapTextureSizeArb = ((int)0x851C)        ,
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
    public enum ArbTextureEnvAdd : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureEnvCombine : int
    {
        SubtractArb = ((int)0x84E7)        ,
        CombineArb = ((int)0x8570)        ,
        CombineRgbArb = ((int)0x8571)        ,
        CombineAlphaArb = ((int)0x8572)        ,
        RgbScaleArb = ((int)0x8573)        ,
        AddSignedArb = ((int)0x8574)        ,
        InterpolateArb = ((int)0x8575)        ,
        ConstantArb = ((int)0x8576)        ,
        PrimaryColorArb = ((int)0x8577)        ,
        PreviousArb = ((int)0x8578)        ,
        Source0RgbArb = ((int)0x8580)        ,
        Source1RgbArb = ((int)0x8581)        ,
        Source2RgbArb = ((int)0x8582)        ,
        Source0AlphaArb = ((int)0x8588)        ,
        Source1AlphaArb = ((int)0x8589)        ,
        Source2AlphaArb = ((int)0x858A)        ,
        Operand0RgbArb = ((int)0x8590)        ,
        Operand1RgbArb = ((int)0x8591)        ,
        Operand2RgbArb = ((int)0x8592)        ,
        Operand0AlphaArb = ((int)0x8598)        ,
        Operand1AlphaArb = ((int)0x8599)        ,
        Operand2AlphaArb = ((int)0x859A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureEnvCrossbar : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureEnvDot3 : int
    {
        Dot3RgbArb = ((int)0x86AE)        ,
        Dot3RgbaArb = ((int)0x86AF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArbTextureFloat : int
    {
        Rgba32fArb = ((int)0x8814)        ,
        Rgb32fArb = ((int)0x8815)        ,
        Alpha32fArb = ((int)0x8816)        ,
        Intensity32fArb = ((int)0x8817)        ,
        Luminance32fArb = ((int)0x8818)        ,
        LuminanceAlpha32fArb = ((int)0x8819)        ,
        Rgba16fArb = ((int)0x881A)        ,
        Rgb16fArb = ((int)0x881B)        ,
        Alpha16fArb = ((int)0x881C)        ,
        Intensity16fArb = ((int)0x881D)        ,
        Luminance16fArb = ((int)0x881E)        ,
        LuminanceAlpha16fArb = ((int)0x881F)        ,
        TextureRedTypeArb = ((int)0x8C10)        ,
        TextureGreenTypeArb = ((int)0x8C11)        ,
        TextureBlueTypeArb = ((int)0x8C12)        ,
        TextureAlphaTypeArb = ((int)0x8C13)        ,
        TextureLuminanceTypeArb = ((int)0x8C14)        ,
        TextureIntensityTypeArb = ((int)0x8C15)        ,
        TextureDepthTypeArb = ((int)0x8C16)        ,
        UnsignedNormalizedArb = ((int)0x8C17)        ,
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
    public enum ArbTextureMirroredRepeat : int
    {
        MirroredRepeatArb = ((int)0x8370)        ,
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
    public enum ArbTextureNonPowerOfTwo : int
    {
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
    public enum ArbTextureRectangle : int
    {
        TextureRectangleArb = ((int)0x84F5)        ,
        TextureBindingRectangleArb = ((int)0x84F6)        ,
        ProxyTextureRectangleArb = ((int)0x84F7)        ,
        MaxRectangleTextureSizeArb = ((int)0x84F8)        ,
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
    public enum ArbTransposeMatrix : int
    {
        TransposeModelviewMatrixArb = ((int)0x84E3)        ,
        TransposeProjectionMatrixArb = ((int)0x84E4)        ,
        TransposeTextureMatrixArb = ((int)0x84E5)        ,
        TransposeColorMatrixArb = ((int)0x84E6)        ,
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
    /// Used in GL.Arb.WeightPointer
    /// </summary>
    public enum ArbVertexBlend : int
    {
        Modelview0Arb = ((int)0x1700)        ,
        Modelview1Arb = ((int)0x850A)        ,
        MaxVertexUnitsArb = ((int)0x86A4)        ,
        ActiveVertexUnitsArb = ((int)0x86A5)        ,
        WeightSumUnityArb = ((int)0x86A6)        ,
        VertexBlendArb = ((int)0x86A7)        ,
        CurrentWeightArb = ((int)0x86A8)        ,
        WeightArrayTypeArb = ((int)0x86A9)        ,
        WeightArrayStrideArb = ((int)0x86AA)        ,
        WeightArraySizeArb = ((int)0x86AB)        ,
        WeightArrayPointerArb = ((int)0x86AC)        ,
        WeightArrayArb = ((int)0x86AD)        ,
        Modelview2Arb = ((int)0x8722)        ,
        Modelview3Arb = ((int)0x8723)        ,
        Modelview4Arb = ((int)0x8724)        ,
        Modelview5Arb = ((int)0x8725)        ,
        Modelview6Arb = ((int)0x8726)        ,
        Modelview7Arb = ((int)0x8727)        ,
        Modelview8Arb = ((int)0x8728)        ,
        Modelview9Arb = ((int)0x8729)        ,
        Modelview10Arb = ((int)0x872A)        ,
        Modelview11Arb = ((int)0x872B)        ,
        Modelview12Arb = ((int)0x872C)        ,
        Modelview13Arb = ((int)0x872D)        ,
        Modelview14Arb = ((int)0x872E)        ,
        Modelview15Arb = ((int)0x872F)        ,
        Modelview16Arb = ((int)0x8730)        ,
        Modelview17Arb = ((int)0x8731)        ,
        Modelview18Arb = ((int)0x8732)        ,
        Modelview19Arb = ((int)0x8733)        ,
        Modelview20Arb = ((int)0x8734)        ,
        Modelview21Arb = ((int)0x8735)        ,
        Modelview22Arb = ((int)0x8736)        ,
        Modelview23Arb = ((int)0x8737)        ,
        Modelview24Arb = ((int)0x8738)        ,
        Modelview25Arb = ((int)0x8739)        ,
        Modelview26Arb = ((int)0x873A)        ,
        Modelview27Arb = ((int)0x873B)        ,
        Modelview28Arb = ((int)0x873C)        ,
        Modelview29Arb = ((int)0x873D)        ,
        Modelview30Arb = ((int)0x873E)        ,
        Modelview31Arb = ((int)0x873F)        ,
    }

    /// <summary>
    /// Used in GL.Arb.GetBufferParameter, GL.Arb.GetBufferPointer and 1 other function
    /// </summary>
    public enum ArbVertexBufferObject : int
    {
        BufferSizeArb = ((int)0x8764)        ,
        BufferUsageArb = ((int)0x8765)        ,
        ArrayBufferArb = ((int)0x8892)        ,
        ElementArrayBufferArb = ((int)0x8893)        ,
        ArrayBufferBindingArb = ((int)0x8894)        ,
        ElementArrayBufferBindingArb = ((int)0x8895)        ,
        VertexArrayBufferBindingArb = ((int)0x8896)        ,
        NormalArrayBufferBindingArb = ((int)0x8897)        ,
        ColorArrayBufferBindingArb = ((int)0x8898)        ,
        IndexArrayBufferBindingArb = ((int)0x8899)        ,
        TextureCoordArrayBufferBindingArb = ((int)0x889A)        ,
        EdgeFlagArrayBufferBindingArb = ((int)0x889B)        ,
        SecondaryColorArrayBufferBindingArb = ((int)0x889C)        ,
        FogCoordinateArrayBufferBindingArb = ((int)0x889D)        ,
        WeightArrayBufferBindingArb = ((int)0x889E)        ,
        VertexAttribArrayBufferBindingArb = ((int)0x889F)        ,
        ReadOnlyArb = ((int)0x88B8)        ,
        WriteOnlyArb = ((int)0x88B9)        ,
        ReadWriteArb = ((int)0x88BA)        ,
        BufferAccessArb = ((int)0x88BB)        ,
        BufferMappedArb = ((int)0x88BC)        ,
        BufferMapPointerArb = ((int)0x88BD)        ,
        StreamDrawArb = ((int)0x88E0)        ,
        StreamReadArb = ((int)0x88E1)        ,
        StreamCopyArb = ((int)0x88E2)        ,
        StaticDrawArb = ((int)0x88E4)        ,
        StaticReadArb = ((int)0x88E5)        ,
        StaticCopyArb = ((int)0x88E6)        ,
        DynamicDrawArb = ((int)0x88E8)        ,
        DynamicReadArb = ((int)0x88E9)        ,
        DynamicCopyArb = ((int)0x88EA)        ,
    }

    /// <summary>
    /// Used in GL.Arb.GetProgramEnvParameter, GL.Arb.GetProgramLocalParameter and 1 other function
    /// </summary>
    public enum ArbVertexProgram : int
    {
        ColorSumArb = ((int)0x8458)        ,
        VertexProgramArb = ((int)0x8620)        ,
        VertexAttribArrayEnabledArb = ((int)0x8622)        ,
        VertexAttribArraySizeArb = ((int)0x8623)        ,
        VertexAttribArrayStrideArb = ((int)0x8624)        ,
        VertexAttribArrayTypeArb = ((int)0x8625)        ,
        CurrentVertexAttribArb = ((int)0x8626)        ,
        ProgramLengthArb = ((int)0x8627)        ,
        ProgramStringArb = ((int)0x8628)        ,
        MaxProgramMatrixStackDepthArb = ((int)0x862E)        ,
        MaxProgramMatricesArb = ((int)0x862F)        ,
        CurrentMatrixStackDepthArb = ((int)0x8640)        ,
        CurrentMatrixArb = ((int)0x8641)        ,
        VertexProgramPointSizeArb = ((int)0x8642)        ,
        VertexProgramTwoSideArb = ((int)0x8643)        ,
        VertexAttribArrayPointerArb = ((int)0x8645)        ,
        ProgramErrorPositionArb = ((int)0x864B)        ,
        ProgramBindingArb = ((int)0x8677)        ,
        MaxVertexAttribsArb = ((int)0x8869)        ,
        VertexAttribArrayNormalizedArb = ((int)0x886A)        ,
        ProgramErrorStringArb = ((int)0x8874)        ,
        ProgramFormatAsciiArb = ((int)0x8875)        ,
        ProgramFormatArb = ((int)0x8876)        ,
        ProgramInstructionsArb = ((int)0x88A0)        ,
        MaxProgramInstructionsArb = ((int)0x88A1)        ,
        ProgramNativeInstructionsArb = ((int)0x88A2)        ,
        MaxProgramNativeInstructionsArb = ((int)0x88A3)        ,
        ProgramTemporariesArb = ((int)0x88A4)        ,
        MaxProgramTemporariesArb = ((int)0x88A5)        ,
        ProgramNativeTemporariesArb = ((int)0x88A6)        ,
        MaxProgramNativeTemporariesArb = ((int)0x88A7)        ,
        ProgramParametersArb = ((int)0x88A8)        ,
        MaxProgramParametersArb = ((int)0x88A9)        ,
        ProgramNativeParametersArb = ((int)0x88AA)        ,
        MaxProgramNativeParametersArb = ((int)0x88AB)        ,
        ProgramAttribsArb = ((int)0x88AC)        ,
        MaxProgramAttribsArb = ((int)0x88AD)        ,
        ProgramNativeAttribsArb = ((int)0x88AE)        ,
        MaxProgramNativeAttribsArb = ((int)0x88AF)        ,
        ProgramAddressRegistersArb = ((int)0x88B0)        ,
        MaxProgramAddressRegistersArb = ((int)0x88B1)        ,
        ProgramNativeAddressRegistersArb = ((int)0x88B2)        ,
        MaxProgramNativeAddressRegistersArb = ((int)0x88B3)        ,
        MaxProgramLocalParametersArb = ((int)0x88B4)        ,
        MaxProgramEnvParametersArb = ((int)0x88B5)        ,
        ProgramUnderNativeLimitsArb = ((int)0x88B6)        ,
        TransposeCurrentMatrixArb = ((int)0x88B7)        ,
        Matrix0Arb = ((int)0x88C0)        ,
        Matrix1Arb = ((int)0x88C1)        ,
        Matrix2Arb = ((int)0x88C2)        ,
        Matrix3Arb = ((int)0x88C3)        ,
        Matrix4Arb = ((int)0x88C4)        ,
        Matrix5Arb = ((int)0x88C5)        ,
        Matrix6Arb = ((int)0x88C6)        ,
        Matrix7Arb = ((int)0x88C7)        ,
        Matrix8Arb = ((int)0x88C8)        ,
        Matrix9Arb = ((int)0x88C9)        ,
        Matrix10Arb = ((int)0x88CA)        ,
        Matrix11Arb = ((int)0x88CB)        ,
        Matrix12Arb = ((int)0x88CC)        ,
        Matrix13Arb = ((int)0x88CD)        ,
        Matrix14Arb = ((int)0x88CE)        ,
        Matrix15Arb = ((int)0x88CF)        ,
        Matrix16Arb = ((int)0x88D0)        ,
        Matrix17Arb = ((int)0x88D1)        ,
        Matrix18Arb = ((int)0x88D2)        ,
        Matrix19Arb = ((int)0x88D3)        ,
        Matrix20Arb = ((int)0x88D4)        ,
        Matrix21Arb = ((int)0x88D5)        ,
        Matrix22Arb = ((int)0x88D6)        ,
        Matrix23Arb = ((int)0x88D7)        ,
        Matrix24Arb = ((int)0x88D8)        ,
        Matrix25Arb = ((int)0x88D9)        ,
        Matrix26Arb = ((int)0x88DA)        ,
        Matrix27Arb = ((int)0x88DB)        ,
        Matrix28Arb = ((int)0x88DC)        ,
        Matrix29Arb = ((int)0x88DD)        ,
        Matrix30Arb = ((int)0x88DE)        ,
        Matrix31Arb = ((int)0x88DF)        ,
    }

    /// <summary>
    /// Used in GL.Arb.GetActiveAttrib
    /// </summary>
    public enum ArbVertexShader : int
    {
        Float = ((int)0x1406)        ,
        VertexAttribArrayEnabledArb = ((int)0x8622)        ,
        VertexAttribArraySizeArb = ((int)0x8623)        ,
        VertexAttribArrayStrideArb = ((int)0x8624)        ,
        VertexAttribArrayTypeArb = ((int)0x8625)        ,
        CurrentVertexAttribArb = ((int)0x8626)        ,
        VertexProgramPointSizeArb = ((int)0x8642)        ,
        VertexProgramTwoSideArb = ((int)0x8643)        ,
        VertexAttribArrayPointerArb = ((int)0x8645)        ,
        MaxVertexAttribsArb = ((int)0x8869)        ,
        VertexAttribArrayNormalizedArb = ((int)0x886A)        ,
        MaxTextureCoordsArb = ((int)0x8871)        ,
        MaxTextureImageUnitsArb = ((int)0x8872)        ,
        VertexShaderArb = ((int)0x8B31)        ,
        MaxVertexUniformComponentsArb = ((int)0x8B4A)        ,
        MaxVaryingFloatsArb = ((int)0x8B4B)        ,
        MaxVertexTextureImageUnitsArb = ((int)0x8B4C)        ,
        MaxCombinedTextureImageUnitsArb = ((int)0x8B4D)        ,
        FloatVec2Arb = ((int)0x8B50)        ,
        FloatVec3Arb = ((int)0x8B51)        ,
        FloatVec4Arb = ((int)0x8B52)        ,
        FloatMat2Arb = ((int)0x8B5A)        ,
        FloatMat3Arb = ((int)0x8B5B)        ,
        FloatMat4Arb = ((int)0x8B5C)        ,
        ObjectActiveAttributesArb = ((int)0x8B89)        ,
        ObjectActiveAttributeMaxLengthArb = ((int)0x8B8A)        ,
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
    public enum ArbWindowPos : int
    {
    }

    /// <summary>
    /// Used in GL.DisableClientState, GL.EnableClientState and 4 other functions
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
    /// Used in GL.Arb.GetProgram, GL.Arb.GetProgramString and 5 other functions
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
    /// Used in GL.Arb.BindProgram, GL.Arb.GetProgram and 12 other functions
    /// </summary>
    public enum AssemblyProgramTargetArb : int
    {
        VertexProgram = ((int)0x8620)        ,
        FragmentProgram = ((int)0x8804)        ,
        GeometryProgramNv = ((int)0x8C26)        ,
    }

    /// <summary>
    /// Used in GL.Ati.DrawBuffers
    /// </summary>
    public enum AtiDrawBuffers : int
    {
        MaxDrawBuffersAti = ((int)0x8824)        ,
        DrawBuffer0Ati = ((int)0x8825)        ,
        DrawBuffer1Ati = ((int)0x8826)        ,
        DrawBuffer2Ati = ((int)0x8827)        ,
        DrawBuffer3Ati = ((int)0x8828)        ,
        DrawBuffer4Ati = ((int)0x8829)        ,
        DrawBuffer5Ati = ((int)0x882A)        ,
        DrawBuffer6Ati = ((int)0x882B)        ,
        DrawBuffer7Ati = ((int)0x882C)        ,
        DrawBuffer8Ati = ((int)0x882D)        ,
        DrawBuffer9Ati = ((int)0x882E)        ,
        DrawBuffer10Ati = ((int)0x882F)        ,
        DrawBuffer11Ati = ((int)0x8830)        ,
        DrawBuffer12Ati = ((int)0x8831)        ,
        DrawBuffer13Ati = ((int)0x8832)        ,
        DrawBuffer14Ati = ((int)0x8833)        ,
        DrawBuffer15Ati = ((int)0x8834)        ,
    }

    /// <summary>
    /// Used in GL.Ati.ElementPointer
    /// </summary>
    public enum AtiElementArray : int
    {
        ElementArrayAti = ((int)0x8768)        ,
        ElementArrayTypeAti = ((int)0x8769)        ,
        ElementArrayPointerAti = ((int)0x876A)        ,
    }

    /// <summary>
    /// Used in GL.Ati.GetTexBumpParameter, GL.Ati.TexBumpParameter
    /// </summary>
    public enum AtiEnvmapBumpmap : int
    {
        BumpRotMatrixAti = ((int)0x8775)        ,
        BumpRotMatrixSizeAti = ((int)0x8776)        ,
        BumpNumTexUnitsAti = ((int)0x8777)        ,
        BumpTexUnitsAti = ((int)0x8778)        ,
        DudvAti = ((int)0x8779)        ,
        Du8Dv8Ati = ((int)0x877A)        ,
        BumpEnvmapAti = ((int)0x877B)        ,
        BumpTargetAti = ((int)0x877C)        ,
    }

    /// <summary>
    /// Used in GL.Ati.AlphaFragmentOp1, GL.Ati.AlphaFragmentOp2 and 6 other functions
    /// </summary>
    public enum AtiFragmentShader : int
    {
        Gl2XBitAti = ((int)0x00000001)        ,
        RedBitAti = ((int)0x00000001)        ,
        CompBitAti = ((int)0x00000002)        ,
        Gl4XBitAti = ((int)0x00000002)        ,
        GreenBitAti = ((int)0x00000002)        ,
        BlueBitAti = ((int)0x00000004)        ,
        Gl8XBitAti = ((int)0x00000004)        ,
        NegateBitAti = ((int)0x00000004)        ,
        BiasBitAti = ((int)0x00000008)        ,
        HalfBitAti = ((int)0x00000008)        ,
        QuarterBitAti = ((int)0x00000010)        ,
        EighthBitAti = ((int)0x00000020)        ,
        SaturateBitAti = ((int)0x00000040)        ,
        FragmentShaderAti = ((int)0x8920)        ,
        Reg0Ati = ((int)0x8921)        ,
        Reg1Ati = ((int)0x8922)        ,
        Reg2Ati = ((int)0x8923)        ,
        Reg3Ati = ((int)0x8924)        ,
        Reg4Ati = ((int)0x8925)        ,
        Reg5Ati = ((int)0x8926)        ,
        Reg6Ati = ((int)0x8927)        ,
        Reg7Ati = ((int)0x8928)        ,
        Reg8Ati = ((int)0x8929)        ,
        Reg9Ati = ((int)0x892A)        ,
        Reg10Ati = ((int)0x892B)        ,
        Reg11Ati = ((int)0x892C)        ,
        Reg12Ati = ((int)0x892D)        ,
        Reg13Ati = ((int)0x892E)        ,
        Reg14Ati = ((int)0x892F)        ,
        Reg15Ati = ((int)0x8930)        ,
        Reg16Ati = ((int)0x8931)        ,
        Reg17Ati = ((int)0x8932)        ,
        Reg18Ati = ((int)0x8933)        ,
        Reg19Ati = ((int)0x8934)        ,
        Reg20Ati = ((int)0x8935)        ,
        Reg21Ati = ((int)0x8936)        ,
        Reg22Ati = ((int)0x8937)        ,
        Reg23Ati = ((int)0x8938)        ,
        Reg24Ati = ((int)0x8939)        ,
        Reg25Ati = ((int)0x893A)        ,
        Reg26Ati = ((int)0x893B)        ,
        Reg27Ati = ((int)0x893C)        ,
        Reg28Ati = ((int)0x893D)        ,
        Reg29Ati = ((int)0x893E)        ,
        Reg30Ati = ((int)0x893F)        ,
        Reg31Ati = ((int)0x8940)        ,
        Con0Ati = ((int)0x8941)        ,
        Con1Ati = ((int)0x8942)        ,
        Con2Ati = ((int)0x8943)        ,
        Con3Ati = ((int)0x8944)        ,
        Con4Ati = ((int)0x8945)        ,
        Con5Ati = ((int)0x8946)        ,
        Con6Ati = ((int)0x8947)        ,
        Con7Ati = ((int)0x8948)        ,
        Con8Ati = ((int)0x8949)        ,
        Con9Ati = ((int)0x894A)        ,
        Con10Ati = ((int)0x894B)        ,
        Con11Ati = ((int)0x894C)        ,
        Con12Ati = ((int)0x894D)        ,
        Con13Ati = ((int)0x894E)        ,
        Con14Ati = ((int)0x894F)        ,
        Con15Ati = ((int)0x8950)        ,
        Con16Ati = ((int)0x8951)        ,
        Con17Ati = ((int)0x8952)        ,
        Con18Ati = ((int)0x8953)        ,
        Con19Ati = ((int)0x8954)        ,
        Con20Ati = ((int)0x8955)        ,
        Con21Ati = ((int)0x8956)        ,
        Con22Ati = ((int)0x8957)        ,
        Con23Ati = ((int)0x8958)        ,
        Con24Ati = ((int)0x8959)        ,
        Con25Ati = ((int)0x895A)        ,
        Con26Ati = ((int)0x895B)        ,
        Con27Ati = ((int)0x895C)        ,
        Con28Ati = ((int)0x895D)        ,
        Con29Ati = ((int)0x895E)        ,
        Con30Ati = ((int)0x895F)        ,
        Con31Ati = ((int)0x8960)        ,
        MovAti = ((int)0x8961)        ,
        AddAti = ((int)0x8963)        ,
        MulAti = ((int)0x8964)        ,
        SubAti = ((int)0x8965)        ,
        Dot3Ati = ((int)0x8966)        ,
        Dot4Ati = ((int)0x8967)        ,
        MadAti = ((int)0x8968)        ,
        LerpAti = ((int)0x8969)        ,
        CndAti = ((int)0x896A)        ,
        Cnd0Ati = ((int)0x896B)        ,
        Dot2AddAti = ((int)0x896C)        ,
        SecondaryInterpolatorAti = ((int)0x896D)        ,
        NumFragmentRegistersAti = ((int)0x896E)        ,
        NumFragmentConstantsAti = ((int)0x896F)        ,
        NumPassesAti = ((int)0x8970)        ,
        NumInstructionsPerPassAti = ((int)0x8971)        ,
        NumInstructionsTotalAti = ((int)0x8972)        ,
        NumInputInterpolatorComponentsAti = ((int)0x8973)        ,
        NumLoopbackComponentsAti = ((int)0x8974)        ,
        ColorAlphaPairingAti = ((int)0x8975)        ,
        SwizzleStrAti = ((int)0x8976)        ,
        SwizzleStqAti = ((int)0x8977)        ,
        SwizzleStrDrAti = ((int)0x8978)        ,
        SwizzleStqDqAti = ((int)0x8979)        ,
        SwizzleStrqAti = ((int)0x897A)        ,
        SwizzleStrqDqAti = ((int)0x897B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiMapObjectBuffer : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiMeminfo : int
    {
        VboFreeMemoryAti = ((int)0x87FB)        ,
        TextureFreeMemoryAti = ((int)0x87FC)        ,
        RenderbufferFreeMemoryAti = ((int)0x87FD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiPixelFormatFloat : int
    {
        RgbaFloatModeAti = ((int)0x8820)        ,
        ColorClearUnclampedValueAti = ((int)0x8835)        ,
    }

    /// <summary>
    /// Used in GL.Ati.PNTriangles
    /// </summary>
    public enum AtiPnTriangles : int
    {
        PnTrianglesAti = ((int)0x87F0)        ,
        MaxPnTrianglesTesselationLevelAti = ((int)0x87F1)        ,
        PnTrianglesPointModeAti = ((int)0x87F2)        ,
        PnTrianglesNormalModeAti = ((int)0x87F3)        ,
        PnTrianglesTesselationLevelAti = ((int)0x87F4)        ,
        PnTrianglesPointModeLinearAti = ((int)0x87F5)        ,
        PnTrianglesPointModeCubicAti = ((int)0x87F6)        ,
        PnTrianglesNormalModeLinearAti = ((int)0x87F7)        ,
        PnTrianglesNormalModeQuadraticAti = ((int)0x87F8)        ,
    }

    /// <summary>
    /// Used in GL.Ati.StencilOpSeparate
    /// </summary>
    public enum AtiSeparateStencil : int
    {
        StencilBackFuncAti = ((int)0x8800)        ,
        StencilBackFailAti = ((int)0x8801)        ,
        StencilBackPassDepthFailAti = ((int)0x8802)        ,
        StencilBackPassDepthPassAti = ((int)0x8803)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiTextFragmentShader : int
    {
        TextFragmentShaderAti = ((int)0x8200)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiTextureEnvCombine3 : int
    {
        ModulateAddAti = ((int)0x8744)        ,
        ModulateSignedAddAti = ((int)0x8745)        ,
        ModulateSubtractAti = ((int)0x8746)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiTextureFloat : int
    {
        RgbaFloat32Ati = ((int)0x8814)        ,
        RgbFloat32Ati = ((int)0x8815)        ,
        AlphaFloat32Ati = ((int)0x8816)        ,
        IntensityFloat32Ati = ((int)0x8817)        ,
        LuminanceFloat32Ati = ((int)0x8818)        ,
        LuminanceAlphaFloat32Ati = ((int)0x8819)        ,
        RgbaFloat16Ati = ((int)0x881A)        ,
        RgbFloat16Ati = ((int)0x881B)        ,
        AlphaFloat16Ati = ((int)0x881C)        ,
        IntensityFloat16Ati = ((int)0x881D)        ,
        LuminanceFloat16Ati = ((int)0x881E)        ,
        LuminanceAlphaFloat16Ati = ((int)0x881F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AtiTextureMirrorOnce : int
    {
        MirrorClampAti = ((int)0x8742)        ,
        MirrorClampToEdgeAti = ((int)0x8743)        ,
    }

    /// <summary>
    /// Used in GL.Ati.ArrayObject, GL.Ati.GetArrayObject and 5 other functions
    /// </summary>
    public enum AtiVertexArrayObject : int
    {
        StaticAti = ((int)0x8760)        ,
        DynamicAti = ((int)0x8761)        ,
        PreserveAti = ((int)0x8762)        ,
        DiscardAti = ((int)0x8763)        ,
        ObjectBufferSizeAti = ((int)0x8764)        ,
        ObjectBufferUsageAti = ((int)0x8765)        ,
        ArrayObjectBufferAti = ((int)0x8766)        ,
        ArrayObjectOffsetAti = ((int)0x8767)        ,
    }

    /// <summary>
    /// Used in GL.Ati.GetVertexAttribArrayObject, GL.Ati.VertexAttribArrayObject
    /// </summary>
    public enum AtiVertexAttribArrayObject : int
    {
    }

    /// <summary>
    /// Used in GL.Ati.ClientActiveVertexStream, GL.Ati.NormalStream3 and 5 other functions
    /// </summary>
    public enum AtiVertexStreams : int
    {
        MaxVertexStreamsAti = ((int)0x876B)        ,
        VertexStream0Ati = ((int)0x876C)        ,
        VertexStream1Ati = ((int)0x876D)        ,
        VertexStream2Ati = ((int)0x876E)        ,
        VertexStream3Ati = ((int)0x876F)        ,
        VertexStream4Ati = ((int)0x8770)        ,
        VertexStream5Ati = ((int)0x8771)        ,
        VertexStream6Ati = ((int)0x8772)        ,
        VertexStream7Ati = ((int)0x8773)        ,
        VertexSourceAti = ((int)0x8774)        ,
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
    /// Used in GL.PushAttrib
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
    /// Used in GL.BeginTransformFeedback
    /// </summary>
    public enum BeginFeedbackMode : int
    {
        Points = ((int)0x0000)        ,
        Lines = ((int)0x0001)        ,
        Triangles = ((int)0x0004)        ,
    }

    /// <summary>
    /// Used in GL.Apple.DrawElementArray, GL.Apple.DrawRangeElementArray and 27 other functions
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
    /// Used in GL.Arb.BlendEquation, GL.BlendEquation and 2 other functions
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
    /// Used in GL.Ext.BlendEquationSeparate
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
    /// Used in GL.BlitFramebuffer, GL.Ext.BlitFramebuffer
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
    /// Used in GL.Arb.MapBuffer
    /// </summary>
    public enum BufferAccessArb : int
    {
        ReadOnly = ((int)0x88B8)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
    }

    /// <summary>
    /// Used in GL.MapBufferRange, GL.Ext.MapNamedBufferRange
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
    /// Used in GL.Apple.BufferParameter
    /// </summary>
    public enum BufferParameterApple : int
    {
        BufferSerializedModifyApple = ((int)0x8A12)        ,
        BufferFlushingUnmapApple = ((int)0x8A13)        ,
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
    /// Used in GL.Arb.GetBufferParameter
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
    /// Used in GL.Arb.GetBufferPointer
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
    /// Used in GL.Apple.BufferParameter, GL.Apple.FlushMappedBufferRange and 16 other functions
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
    /// Used in GL.Arb.BindBuffer, GL.Arb.BufferData and 7 other functions
    /// </summary>
    public enum BufferTargetArb : int
    {
        ArrayBuffer = ((int)0x8892)        ,
        ElementArrayBuffer = ((int)0x8893)        ,
        TextureBuffer = ((int)0x8C2A)        ,
    }

    /// <summary>
    /// Used in GL.Arb.BufferData
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
    /// Used in GL.BlitFramebuffer, GL.Clear and 1 other function
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
    /// Used in GL.PushClientAttrib, GL.Ext.ClientAttribDefault and 1 other function
    /// </summary>
    [Flags]
    public enum ClientAttribMask : int
    {
        ClientPixelStoreBit = ((int)0x00000001)        ,
        ClientVertexArrayBit = ((int)0x00000002)        ,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF)        ,
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
    /// Used in GL.ClipPlane, GL.GetClipPlane
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
    /// Used in GL.ColorMaterial
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
    /// Used in GL.ColorPointer, GL.SecondaryColorPointer and 5 other functions
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
    /// Used in GL.Sgi.ColorTableParameter
    /// </summary>
    public enum ColorTableParameterPNameSgi : int
    {
        ColorTableScale = ((int)0x80D6)        ,
        ColorTableScaleSgi = ((int)0x80D6)        ,
        ColorTableBias = ((int)0x80D7)        ,
        ColorTableBiasSgi = ((int)0x80D7)        ,
    }

    /// <summary>
    /// Used in GL.ColorSubTable, GL.ColorTable and 10 other functions
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
    /// Used in GL.Sgi.ColorTableParameter, GL.Sgi.ColorTable and 3 other functions
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
    /// Used in GL.Ext.ConvolutionParameter, GL.Ext.GetConvolutionParameter
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
    /// Used in GL.Ext.ConvolutionFilter1D, GL.Ext.ConvolutionFilter2D and 5 other functions
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
    /// Used in GL.DepthFunc, GL.NV.PathCoverDepthFunc
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
    /// Used in GL.DrawBuffer, GL.Ext.FramebufferDrawBuffer and 1 other function
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
    /// Used in GL.Arb.DrawElementsInstanced, GL.DrawElements and 13 other functions
    /// </summary>
    public enum DrawElementsType : int
    {
        UnsignedByte = ((int)0x1401)        ,
        UnsignedShort = ((int)0x1403)        ,
        UnsignedInt = ((int)0x1405)        ,
    }

    /// <summary>
    /// Used in GL.Ati.ArrayObject, GL.Ati.GetArrayObject and 7 other functions
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
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
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
    public enum Ext422Pixels : int
    {
        Gl422Ext = ((int)0x80CC)        ,
        Gl422RevExt = ((int)0x80CD)        ,
        Gl422AverageExt = ((int)0x80CE)        ,
        Gl422RevAverageExt = ((int)0x80CF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtAbgr : int
    {
        AbgrExt = ((int)0x8000)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBgra : int
    {
        BgrExt = ((int)0x80E0)        ,
        BgraExt = ((int)0x80E1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBindableUniform : int
    {
        MaxVertexBindableUniformsExt = ((int)0x8DE2)        ,
        MaxFragmentBindableUniformsExt = ((int)0x8DE3)        ,
        MaxGeometryBindableUniformsExt = ((int)0x8DE4)        ,
        MaxBindableUniformSizeExt = ((int)0x8DED)        ,
        UniformBufferExt = ((int)0x8DEE)        ,
        UniformBufferBindingExt = ((int)0x8DEF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendColor : int
    {
        ConstantColorExt = ((int)0x8001)        ,
        OneMinusConstantColorExt = ((int)0x8002)        ,
        ConstantAlphaExt = ((int)0x8003)        ,
        OneMinusConstantAlphaExt = ((int)0x8004)        ,
        BlendColorExt = ((int)0x8005)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BlendEquationSeparate
    /// </summary>
    public enum ExtBlendEquationSeparate : int
    {
        BlendEquationRgbExt = ((int)0x8009)        ,
        BlendEquationAlphaExt = ((int)0x883D)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BlendFuncSeparate
    /// </summary>
    public enum ExtBlendFuncSeparate : int
    {
        BlendDstRgbExt = ((int)0x80C8)        ,
        BlendSrcRgbExt = ((int)0x80C9)        ,
        BlendDstAlphaExt = ((int)0x80CA)        ,
        BlendSrcAlphaExt = ((int)0x80CB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendLogicOp : int
    {
    }

    /// <summary>
    /// Used in GL.Ext.BlendEquation
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
    public enum ExtBlendSubtract : int
    {
        FuncSubtractExt = ((int)0x800A)        ,
        FuncReverseSubtractExt = ((int)0x800B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtClipVolumeHint : int
    {
        ClipVolumeClippingHintExt = ((int)0x80F0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtCmyka : int
    {
        CmykExt = ((int)0x800C)        ,
        CmykaExt = ((int)0x800D)        ,
        PackCmykHintExt = ((int)0x800E)        ,
        UnpackCmykHintExt = ((int)0x800F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtColorSubtable : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtCompiledVertexArray : int
    {
        ArrayElementLockFirstExt = ((int)0x81A8)        ,
        ArrayElementLockCountExt = ((int)0x81A9)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ConvolutionFilter1D, GL.Ext.ConvolutionFilter2D and 5 other functions
    /// </summary>
    public enum ExtConvolution : int
    {
        Convolution1DExt = ((int)0x8010)        ,
        Convolution2DExt = ((int)0x8011)        ,
        Separable2DExt = ((int)0x8012)        ,
        ConvolutionBorderModeExt = ((int)0x8013)        ,
        ConvolutionFilterScaleExt = ((int)0x8014)        ,
        ConvolutionFilterBiasExt = ((int)0x8015)        ,
        ReduceExt = ((int)0x8016)        ,
        ConvolutionFormatExt = ((int)0x8017)        ,
        ConvolutionWidthExt = ((int)0x8018)        ,
        ConvolutionHeightExt = ((int)0x8019)        ,
        MaxConvolutionWidthExt = ((int)0x801A)        ,
        MaxConvolutionHeightExt = ((int)0x801B)        ,
        PostConvolutionRedScaleExt = ((int)0x801C)        ,
        PostConvolutionGreenScaleExt = ((int)0x801D)        ,
        PostConvolutionBlueScaleExt = ((int)0x801E)        ,
        PostConvolutionAlphaScaleExt = ((int)0x801F)        ,
        PostConvolutionRedBiasExt = ((int)0x8020)        ,
        PostConvolutionGreenBiasExt = ((int)0x8021)        ,
        PostConvolutionBlueBiasExt = ((int)0x8022)        ,
        PostConvolutionAlphaBiasExt = ((int)0x8023)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtCoordinateFrame : int
    {
        TangentArrayExt = ((int)0x8439)        ,
        BinormalArrayExt = ((int)0x843A)        ,
        CurrentTangentExt = ((int)0x843B)        ,
        CurrentBinormalExt = ((int)0x843C)        ,
        TangentArrayTypeExt = ((int)0x843E)        ,
        TangentArrayStrideExt = ((int)0x843F)        ,
        BinormalArrayTypeExt = ((int)0x8440)        ,
        BinormalArrayStrideExt = ((int)0x8441)        ,
        TangentArrayPointerExt = ((int)0x8442)        ,
        BinormalArrayPointerExt = ((int)0x8443)        ,
        Map1TangentExt = ((int)0x8444)        ,
        Map2TangentExt = ((int)0x8445)        ,
        Map1BinormalExt = ((int)0x8446)        ,
        Map2BinormalExt = ((int)0x8447)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtCopyTexture : int
    {
    }

    /// <summary>
    /// Used in GL.Ext.CullParameter
    /// </summary>
    public enum ExtCullVertex : int
    {
        CullVertexExt = ((int)0x81AA)        ,
        CullVertexEyePositionExt = ((int)0x81AB)        ,
        CullVertexObjectPositionExt = ((int)0x81AC)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetObjectLabel, GL.Ext.LabelObject
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
    public enum ExtDepthBoundsTest : int
    {
        DepthBoundsTestExt = ((int)0x8890)        ,
        DepthBoundsExt = ((int)0x8891)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ClearNamedBufferData, GL.Ext.ClearNamedBufferSubData and 54 other functions
    /// </summary>
    public enum ExtDirectStateAccess : int
    {
        ProgramMatrixExt = ((int)0x8E2D)        ,
        TransposeProgramMatrixExt = ((int)0x8E2E)        ,
        ProgramMatrixStackDepthExt = ((int)0x8E2F)        ,
    }

    /// <summary>
    /// Used in GL.Ext.DisableIndexed, GL.Ext.EnableIndexed and 3 other functions
    /// </summary>
    public enum ExtDrawBuffers2 : int
    {
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
    public enum ExtDrawRangeElements : int
    {
        MaxElementsVerticesExt = ((int)0x80E8)        ,
        MaxElementsIndicesExt = ((int)0x80E9)        ,
    }

    /// <summary>
    /// Used in GL.Ext.FogCoordPointer
    /// </summary>
    public enum ExtFogCoord : int
    {
        FogCoordinateSourceExt = ((int)0x8450)        ,
        FogCoordinateExt = ((int)0x8451)        ,
        FragmentDepthExt = ((int)0x8452)        ,
        CurrentFogCoordinateExt = ((int)0x8453)        ,
        FogCoordinateArrayTypeExt = ((int)0x8454)        ,
        FogCoordinateArrayStrideExt = ((int)0x8455)        ,
        FogCoordinateArrayPointerExt = ((int)0x8456)        ,
        FogCoordinateArrayExt = ((int)0x8457)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BlitFramebuffer
    /// </summary>
    public enum ExtFramebufferBlit : int
    {
        DrawFramebufferBindingExt = ((int)0x8CA6)        ,
        ReadFramebufferExt = ((int)0x8CA8)        ,
        DrawFramebufferExt = ((int)0x8CA9)        ,
        ReadFramebufferBindingExt = ((int)0x8CAA)        ,
    }

    /// <summary>
    /// Used in GL.Ext.RenderbufferStorageMultisample
    /// </summary>
    public enum ExtFramebufferMultisample : int
    {
        RenderbufferSamplesExt = ((int)0x8CAB)        ,
        FramebufferIncompleteMultisampleExt = ((int)0x8D56)        ,
        MaxSamplesExt = ((int)0x8D57)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtFramebufferMultisampleBlitScaled : int
    {
        ScaledResolveFastestExt = ((int)0x90BA)        ,
        ScaledResolveNicestExt = ((int)0x90BB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtFramebufferObject : int
    {
        InvalidFramebufferOperationExt = ((int)0x0506)        ,
        MaxRenderbufferSizeExt = ((int)0x84E8)        ,
        FramebufferBindingExt = ((int)0x8CA6)        ,
        RenderbufferBindingExt = ((int)0x8CA7)        ,
        FramebufferAttachmentObjectTypeExt = ((int)0x8CD0)        ,
        FramebufferAttachmentObjectNameExt = ((int)0x8CD1)        ,
        FramebufferAttachmentTextureLevelExt = ((int)0x8CD2)        ,
        FramebufferAttachmentTextureCubeMapFaceExt = ((int)0x8CD3)        ,
        FramebufferAttachmentTexture3DZoffsetExt = ((int)0x8CD4)        ,
        FramebufferCompleteExt = ((int)0x8CD5)        ,
        FramebufferIncompleteAttachmentExt = ((int)0x8CD6)        ,
        FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7)        ,
        FramebufferIncompleteDimensionsExt = ((int)0x8CD9)        ,
        FramebufferIncompleteFormatsExt = ((int)0x8CDA)        ,
        FramebufferIncompleteDrawBufferExt = ((int)0x8CDB)        ,
        FramebufferIncompleteReadBufferExt = ((int)0x8CDC)        ,
        FramebufferUnsupportedExt = ((int)0x8CDD)        ,
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
        DepthAttachmentExt = ((int)0x8D00)        ,
        StencilAttachmentExt = ((int)0x8D20)        ,
        FramebufferExt = ((int)0x8D40)        ,
        RenderbufferExt = ((int)0x8D41)        ,
        RenderbufferWidthExt = ((int)0x8D42)        ,
        RenderbufferHeightExt = ((int)0x8D43)        ,
        RenderbufferInternalFormatExt = ((int)0x8D44)        ,
        StencilIndex1Ext = ((int)0x8D46)        ,
        StencilIndex4Ext = ((int)0x8D47)        ,
        StencilIndex8Ext = ((int)0x8D48)        ,
        StencilIndex16Ext = ((int)0x8D49)        ,
        RenderbufferRedSizeExt = ((int)0x8D50)        ,
        RenderbufferGreenSizeExt = ((int)0x8D51)        ,
        RenderbufferBlueSizeExt = ((int)0x8D52)        ,
        RenderbufferAlphaSizeExt = ((int)0x8D53)        ,
        RenderbufferDepthSizeExt = ((int)0x8D54)        ,
        RenderbufferStencilSizeExt = ((int)0x8D55)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtFramebufferSrgb : int
    {
        FramebufferSrgbExt = ((int)0x8DB9)        ,
        FramebufferSrgbCapableExt = ((int)0x8DBA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtGeometryShader4 : int
    {
        LinesAdjacencyExt = ((int)0x000A)        ,
        LineStripAdjacencyExt = ((int)0x000B)        ,
        TrianglesAdjacencyExt = ((int)0x000C)        ,
        TriangleStripAdjacencyExt = ((int)0x000D)        ,
        ProgramPointSizeExt = ((int)0x8642)        ,
        MaxVaryingComponentsExt = ((int)0x8B4B)        ,
        MaxGeometryTextureImageUnitsExt = ((int)0x8C29)        ,
        FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)        ,
        FramebufferAttachmentLayeredExt = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCountExt = ((int)0x8DA9)        ,
        GeometryShaderExt = ((int)0x8DD9)        ,
        GeometryVerticesOutExt = ((int)0x8DDA)        ,
        GeometryInputTypeExt = ((int)0x8DDB)        ,
        GeometryOutputTypeExt = ((int)0x8DDC)        ,
        MaxGeometryVaryingComponentsExt = ((int)0x8DDD)        ,
        MaxVertexVaryingComponentsExt = ((int)0x8DDE)        ,
        MaxGeometryUniformComponentsExt = ((int)0x8DDF)        ,
        MaxGeometryOutputVerticesExt = ((int)0x8DE0)        ,
        MaxGeometryTotalOutputComponentsExt = ((int)0x8DE1)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ProgramEnvParameters4, GL.Ext.ProgramLocalParameters4
    /// </summary>
    public enum ExtGpuProgramParameters : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtGpuShader4 : int
    {
        VertexAttribArrayIntegerExt = ((int)0x88FD)        ,
        MinProgramTexelOffsetExt = ((int)0x8904)        ,
        MaxProgramTexelOffsetExt = ((int)0x8905)        ,
        Sampler1DArrayExt = ((int)0x8DC0)        ,
        Sampler2DArrayExt = ((int)0x8DC1)        ,
        SamplerBufferExt = ((int)0x8DC2)        ,
        Sampler1DArrayShadowExt = ((int)0x8DC3)        ,
        Sampler2DArrayShadowExt = ((int)0x8DC4)        ,
        SamplerCubeShadowExt = ((int)0x8DC5)        ,
        UnsignedIntVec2Ext = ((int)0x8DC6)        ,
        UnsignedIntVec3Ext = ((int)0x8DC7)        ,
        UnsignedIntVec4Ext = ((int)0x8DC8)        ,
        IntSampler1DExt = ((int)0x8DC9)        ,
        IntSampler2DExt = ((int)0x8DCA)        ,
        IntSampler3DExt = ((int)0x8DCB)        ,
        IntSamplerCubeExt = ((int)0x8DCC)        ,
        IntSampler2DRectExt = ((int)0x8DCD)        ,
        IntSampler1DArrayExt = ((int)0x8DCE)        ,
        IntSampler2DArrayExt = ((int)0x8DCF)        ,
        IntSamplerBufferExt = ((int)0x8DD0)        ,
        UnsignedIntSampler1DExt = ((int)0x8DD1)        ,
        UnsignedIntSampler2DExt = ((int)0x8DD2)        ,
        UnsignedIntSampler3DExt = ((int)0x8DD3)        ,
        UnsignedIntSamplerCubeExt = ((int)0x8DD4)        ,
        UnsignedIntSampler2DRectExt = ((int)0x8DD5)        ,
        UnsignedIntSampler1DArrayExt = ((int)0x8DD6)        ,
        UnsignedIntSampler2DArrayExt = ((int)0x8DD7)        ,
        UnsignedIntSamplerBufferExt = ((int)0x8DD8)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetHistogram, GL.Ext.GetHistogramParameter and 6 other functions
    /// </summary>
    public enum ExtHistogram : int
    {
        HistogramExt = ((int)0x8024)        ,
        ProxyHistogramExt = ((int)0x8025)        ,
        HistogramWidthExt = ((int)0x8026)        ,
        HistogramFormatExt = ((int)0x8027)        ,
        HistogramRedSizeExt = ((int)0x8028)        ,
        HistogramGreenSizeExt = ((int)0x8029)        ,
        HistogramBlueSizeExt = ((int)0x802A)        ,
        HistogramAlphaSizeExt = ((int)0x802B)        ,
        HistogramLuminanceSizeExt = ((int)0x802C)        ,
        HistogramSinkExt = ((int)0x802D)        ,
        MinmaxExt = ((int)0x802E)        ,
        MinmaxFormatExt = ((int)0x802F)        ,
        MinmaxSinkExt = ((int)0x8030)        ,
        TableTooLargeExt = ((int)0x8031)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtIndexArrayFormats : int
    {
        IuiV2fExt = ((int)0x81AD)        ,
        IuiV3fExt = ((int)0x81AE)        ,
        IuiN3fV2fExt = ((int)0x81AF)        ,
        IuiN3fV3fExt = ((int)0x81B0)        ,
        T2fIuiV2fExt = ((int)0x81B1)        ,
        T2fIuiV3fExt = ((int)0x81B2)        ,
        T2fIuiN3fV2fExt = ((int)0x81B3)        ,
        T2fIuiN3fV3fExt = ((int)0x81B4)        ,
    }

    /// <summary>
    /// Used in GL.Ext.IndexFunc
    /// </summary>
    public enum ExtIndexFunc : int
    {
        IndexTestExt = ((int)0x81B5)        ,
        IndexTestFuncExt = ((int)0x81B6)        ,
        IndexTestRefExt = ((int)0x81B7)        ,
    }

    /// <summary>
    /// Used in GL.Ext.IndexMaterial
    /// </summary>
    public enum ExtIndexMaterial : int
    {
        IndexMaterialExt = ((int)0x81B8)        ,
        IndexMaterialParameterExt = ((int)0x81B9)        ,
        IndexMaterialFaceExt = ((int)0x81BA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtIndexTexture : int
    {
    }

    /// <summary>
    /// Used in GL.Ext.ApplyTexture, GL.Ext.TextureLight
    /// </summary>
    public enum ExtLightTexture : int
    {
        FragmentMaterialExt = ((int)0x8349)        ,
        FragmentNormalExt = ((int)0x834A)        ,
        FragmentColorExt = ((int)0x834C)        ,
        AttenuationExt = ((int)0x834D)        ,
        ShadowAttenuationExt = ((int)0x834E)        ,
        TextureApplicationModeExt = ((int)0x834F)        ,
        TextureLightExt = ((int)0x8350)        ,
        TextureMaterialFaceExt = ((int)0x8351)        ,
        TextureMaterialParameterExt = ((int)0x8352)        ,
        FragmentDepthExt = ((int)0x8452)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMiscAttribute : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtMultiDrawArrays : int
    {
    }

    /// <summary>
    /// Used in GL.Ext.SamplePattern
    /// </summary>
    public enum ExtMultisample : int
    {
        MultisampleBitExt = ((int)0x20000000)        ,
        MultisampleExt = ((int)0x809D)        ,
        SampleAlphaToMaskExt = ((int)0x809E)        ,
        SampleAlphaToOneExt = ((int)0x809F)        ,
        SampleMaskExt = ((int)0x80A0)        ,
        Gl1PassExt = ((int)0x80A1)        ,
        Gl2Pass0Ext = ((int)0x80A2)        ,
        Gl2Pass1Ext = ((int)0x80A3)        ,
        Gl4Pass0Ext = ((int)0x80A4)        ,
        Gl4Pass1Ext = ((int)0x80A5)        ,
        Gl4Pass2Ext = ((int)0x80A6)        ,
        Gl4Pass3Ext = ((int)0x80A7)        ,
        SampleBuffersExt = ((int)0x80A8)        ,
        SamplesExt = ((int)0x80A9)        ,
        SampleMaskValueExt = ((int)0x80AA)        ,
        SampleMaskInvertExt = ((int)0x80AB)        ,
        SamplePatternExt = ((int)0x80AC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPackedDepthStencil : int
    {
        DepthStencilExt = ((int)0x84F9)        ,
        UnsignedInt248Ext = ((int)0x84FA)        ,
        Depth24Stencil8Ext = ((int)0x88F0)        ,
        TextureStencilSizeExt = ((int)0x88F1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPackedFloat : int
    {
        R11fG11fB10fExt = ((int)0x8C3A)        ,
        UnsignedInt10F11F11FRevExt = ((int)0x8C3B)        ,
        RgbaSignedComponentsExt = ((int)0x8C3C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPackedPixels : int
    {
        UnsignedByte332Ext = ((int)0x8032)        ,
        UnsignedShort4444Ext = ((int)0x8033)        ,
        UnsignedShort5551Ext = ((int)0x8034)        ,
        UnsignedInt8888Ext = ((int)0x8035)        ,
        UnsignedInt1010102Ext = ((int)0x8036)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPalettedTexture : int
    {
        ColorIndex1Ext = ((int)0x80E2)        ,
        ColorIndex2Ext = ((int)0x80E3)        ,
        ColorIndex4Ext = ((int)0x80E4)        ,
        ColorIndex8Ext = ((int)0x80E5)        ,
        ColorIndex12Ext = ((int)0x80E6)        ,
        ColorIndex16Ext = ((int)0x80E7)        ,
        TextureIndexSizeExt = ((int)0x80ED)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPixelBufferObject : int
    {
        PixelPackBufferExt = ((int)0x88EB)        ,
        PixelUnpackBufferExt = ((int)0x88EC)        ,
        PixelPackBufferBindingExt = ((int)0x88ED)        ,
        PixelUnpackBufferBindingExt = ((int)0x88EF)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetPixelTransformParameter, GL.Ext.PixelTransformParameter
    /// </summary>
    public enum ExtPixelTransform : int
    {
        PixelTransform2DExt = ((int)0x8330)        ,
        PixelMagFilterExt = ((int)0x8331)        ,
        PixelMinFilterExt = ((int)0x8332)        ,
        PixelCubicWeightExt = ((int)0x8333)        ,
        CubicExt = ((int)0x8334)        ,
        AverageExt = ((int)0x8335)        ,
        PixelTransform2DStackDepthExt = ((int)0x8336)        ,
        MaxPixelTransform2DStackDepthExt = ((int)0x8337)        ,
        PixelTransform2DMatrixExt = ((int)0x8338)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPixelTransformColorTable : int
    {
    }

    /// <summary>
    /// Used in GL.Ext.PointParameter
    /// </summary>
    public enum ExtPointParameters : int
    {
        PointSizeMinExt = ((int)0x8126)        ,
        PointSizeMaxExt = ((int)0x8127)        ,
        PointFadeThresholdSizeExt = ((int)0x8128)        ,
        DistanceAttenuationExt = ((int)0x8129)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPolygonOffset : int
    {
        PolygonOffsetExt = ((int)0x8037)        ,
        PolygonOffsetFactorExt = ((int)0x8038)        ,
        PolygonOffsetBiasExt = ((int)0x8039)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ProvokingVertex
    /// </summary>
    public enum ExtProvokingVertex : int
    {
        QuadsFollowProvokingVertexConventionExt = ((int)0x8E4C)        ,
        FirstVertexConventionExt = ((int)0x8E4D)        ,
        LastVertexConventionExt = ((int)0x8E4E)        ,
        ProvokingVertexExt = ((int)0x8E4F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtRescaleNormal : int
    {
        RescaleNormalExt = ((int)0x803A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSecondaryColor : int
    {
        ColorSumExt = ((int)0x8458)        ,
        CurrentSecondaryColorExt = ((int)0x8459)        ,
        SecondaryColorArraySizeExt = ((int)0x845A)        ,
        SecondaryColorArrayTypeExt = ((int)0x845B)        ,
        SecondaryColorArrayStrideExt = ((int)0x845C)        ,
        SecondaryColorArrayPointerExt = ((int)0x845D)        ,
        SecondaryColorArrayExt = ((int)0x845E)        ,
    }

    /// <summary>
    /// Used in GL.Ext.CreateShaderProgram, GL.Ext.GetProgramPipeline and 1 other function
    /// </summary>
    public enum ExtSeparateShaderObjects : int
    {
        VertexShaderBitExt = ((int)0x00000001)        ,
        FragmentShaderBitExt = ((int)0x00000002)        ,
        ProgramSeparableExt = ((int)0x8258)        ,
        ProgramPipelineBindingExt = ((int)0x825A)        ,
        ActiveProgramExt = ((int)0x8B8D)        ,
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSeparateSpecularColor : int
    {
        LightModelColorControlExt = ((int)0x81F8)        ,
        SingleColorExt = ((int)0x81F9)        ,
        SeparateSpecularColorExt = ((int)0x81FA)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BindImageTexture
    /// </summary>
    public enum ExtShaderImageLoadStore : int
    {
        VertexAttribArrayBarrierBitExt = ((int)0x00000001)        ,
        ElementArrayBarrierBitExt = ((int)0x00000002)        ,
        UniformBarrierBitExt = ((int)0x00000004)        ,
        TextureFetchBarrierBitExt = ((int)0x00000008)        ,
        ShaderImageAccessBarrierBitExt = ((int)0x00000020)        ,
        CommandBarrierBitExt = ((int)0x00000040)        ,
        PixelBufferBarrierBitExt = ((int)0x00000080)        ,
        TextureUpdateBarrierBitExt = ((int)0x00000100)        ,
        BufferUpdateBarrierBitExt = ((int)0x00000200)        ,
        FramebufferBarrierBitExt = ((int)0x00000400)        ,
        TransformFeedbackBarrierBitExt = ((int)0x00000800)        ,
        AtomicCounterBarrierBitExt = ((int)0x00001000)        ,
        MaxImageUnitsExt = ((int)0x8F38)        ,
        MaxCombinedImageUnitsAndFragmentOutputsExt = ((int)0x8F39)        ,
        ImageBindingNameExt = ((int)0x8F3A)        ,
        ImageBindingLevelExt = ((int)0x8F3B)        ,
        ImageBindingLayeredExt = ((int)0x8F3C)        ,
        ImageBindingLayerExt = ((int)0x8F3D)        ,
        ImageBindingAccessExt = ((int)0x8F3E)        ,
        Image1DExt = ((int)0x904C)        ,
        Image2DExt = ((int)0x904D)        ,
        Image3DExt = ((int)0x904E)        ,
        Image2DRectExt = ((int)0x904F)        ,
        ImageCubeExt = ((int)0x9050)        ,
        ImageBufferExt = ((int)0x9051)        ,
        Image1DArrayExt = ((int)0x9052)        ,
        Image2DArrayExt = ((int)0x9053)        ,
        ImageCubeMapArrayExt = ((int)0x9054)        ,
        Image2DMultisampleExt = ((int)0x9055)        ,
        Image2DMultisampleArrayExt = ((int)0x9056)        ,
        IntImage1DExt = ((int)0x9057)        ,
        IntImage2DExt = ((int)0x9058)        ,
        IntImage3DExt = ((int)0x9059)        ,
        IntImage2DRectExt = ((int)0x905A)        ,
        IntImageCubeExt = ((int)0x905B)        ,
        IntImageBufferExt = ((int)0x905C)        ,
        IntImage1DArrayExt = ((int)0x905D)        ,
        IntImage2DArrayExt = ((int)0x905E)        ,
        IntImageCubeMapArrayExt = ((int)0x905F)        ,
        IntImage2DMultisampleExt = ((int)0x9060)        ,
        IntImage2DMultisampleArrayExt = ((int)0x9061)        ,
        UnsignedIntImage1DExt = ((int)0x9062)        ,
        UnsignedIntImage2DExt = ((int)0x9063)        ,
        UnsignedIntImage3DExt = ((int)0x9064)        ,
        UnsignedIntImage2DRectExt = ((int)0x9065)        ,
        UnsignedIntImageCubeExt = ((int)0x9066)        ,
        UnsignedIntImageBufferExt = ((int)0x9067)        ,
        UnsignedIntImage1DArrayExt = ((int)0x9068)        ,
        UnsignedIntImage2DArrayExt = ((int)0x9069)        ,
        UnsignedIntImageCubeMapArrayExt = ((int)0x906A)        ,
        UnsignedIntImage2DMultisampleExt = ((int)0x906B)        ,
        UnsignedIntImage2DMultisampleArrayExt = ((int)0x906C)        ,
        MaxImageSamplesExt = ((int)0x906D)        ,
        ImageBindingFormatExt = ((int)0x906E)        ,
        AllBarrierBitsExt = unchecked((int)0xFFFFFFFF)        ,
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
    public enum ExtShadowFuncs : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSharedTexturePalette : int
    {
        SharedTexturePaletteExt = ((int)0x81FB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtStencilClearTag : int
    {
        StencilTagBitsExt = ((int)0x88F2)        ,
        StencilClearTagValueExt = ((int)0x88F3)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ActiveStencilFace
    /// </summary>
    public enum ExtStencilTwoSide : int
    {
        StencilTestTwoSideExt = ((int)0x8910)        ,
        ActiveStencilFaceExt = ((int)0x8911)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtStencilWrap : int
    {
        IncrWrapExt = ((int)0x8507)        ,
        DecrWrapExt = ((int)0x8508)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtSubtexture : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTexture : int
    {
        Alpha4Ext = ((int)0x803B)        ,
        Alpha8Ext = ((int)0x803C)        ,
        Alpha12Ext = ((int)0x803D)        ,
        Alpha16Ext = ((int)0x803E)        ,
        Luminance4Ext = ((int)0x803F)        ,
        Luminance8Ext = ((int)0x8040)        ,
        Luminance12Ext = ((int)0x8041)        ,
        Luminance16Ext = ((int)0x8042)        ,
        Luminance4Alpha4Ext = ((int)0x8043)        ,
        Luminance6Alpha2Ext = ((int)0x8044)        ,
        Luminance8Alpha8Ext = ((int)0x8045)        ,
        Luminance12Alpha4Ext = ((int)0x8046)        ,
        Luminance12Alpha12Ext = ((int)0x8047)        ,
        Luminance16Alpha16Ext = ((int)0x8048)        ,
        IntensityExt = ((int)0x8049)        ,
        Intensity4Ext = ((int)0x804A)        ,
        Intensity8Ext = ((int)0x804B)        ,
        Intensity12Ext = ((int)0x804C)        ,
        Intensity16Ext = ((int)0x804D)        ,
        Rgb2Ext = ((int)0x804E)        ,
        Rgb4Ext = ((int)0x804F)        ,
        Rgb5Ext = ((int)0x8050)        ,
        Rgb8Ext = ((int)0x8051)        ,
        Rgb10Ext = ((int)0x8052)        ,
        Rgb12Ext = ((int)0x8053)        ,
        Rgb16Ext = ((int)0x8054)        ,
        Rgba2Ext = ((int)0x8055)        ,
        Rgba4Ext = ((int)0x8056)        ,
        Rgb5A1Ext = ((int)0x8057)        ,
        Rgba8Ext = ((int)0x8058)        ,
        Rgb10A2Ext = ((int)0x8059)        ,
        Rgba12Ext = ((int)0x805A)        ,
        Rgba16Ext = ((int)0x805B)        ,
        TextureRedSizeExt = ((int)0x805C)        ,
        TextureGreenSizeExt = ((int)0x805D)        ,
        TextureBlueSizeExt = ((int)0x805E)        ,
        TextureAlphaSizeExt = ((int)0x805F)        ,
        TextureLuminanceSizeExt = ((int)0x8060)        ,
        TextureIntensitySizeExt = ((int)0x8061)        ,
        ReplaceExt = ((int)0x8062)        ,
        ProxyTexture1DExt = ((int)0x8063)        ,
        ProxyTexture2DExt = ((int)0x8064)        ,
        TextureTooLargeExt = ((int)0x8065)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTexture3D : int
    {
        PackSkipImagesExt = ((int)0x806B)        ,
        PackImageHeightExt = ((int)0x806C)        ,
        UnpackSkipImagesExt = ((int)0x806D)        ,
        UnpackImageHeightExt = ((int)0x806E)        ,
        Texture3DExt = ((int)0x806F)        ,
        ProxyTexture3DExt = ((int)0x8070)        ,
        TextureDepthExt = ((int)0x8071)        ,
        TextureWrapRExt = ((int)0x8072)        ,
        Max3DTextureSizeExt = ((int)0x8073)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureArray : int
    {
        CompareRefDepthToTextureExt = ((int)0x884E)        ,
        MaxArrayTextureLayersExt = ((int)0x88FF)        ,
        Texture1DArrayExt = ((int)0x8C18)        ,
        ProxyTexture1DArrayExt = ((int)0x8C19)        ,
        Texture2DArrayExt = ((int)0x8C1A)        ,
        ProxyTexture2DArrayExt = ((int)0x8C1B)        ,
        TextureBinding1DArrayExt = ((int)0x8C1C)        ,
        TextureBinding2DArrayExt = ((int)0x8C1D)        ,
        FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)        ,
    }

    /// <summary>
    /// Used in GL.Ext.TexBuffer
    /// </summary>
    public enum ExtTextureBufferObject : int
    {
        TextureBufferExt = ((int)0x8C2A)        ,
        MaxTextureBufferSizeExt = ((int)0x8C2B)        ,
        TextureBindingBufferExt = ((int)0x8C2C)        ,
        TextureBufferDataStoreBindingExt = ((int)0x8C2D)        ,
        TextureBufferFormatExt = ((int)0x8C2E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionLatc : int
    {
        CompressedLuminanceLatc1Ext = ((int)0x8C70)        ,
        CompressedSignedLuminanceLatc1Ext = ((int)0x8C71)        ,
        CompressedLuminanceAlphaLatc2Ext = ((int)0x8C72)        ,
        CompressedSignedLuminanceAlphaLatc2Ext = ((int)0x8C73)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionRgtc : int
    {
        CompressedRedRgtc1Ext = ((int)0x8DBB)        ,
        CompressedSignedRedRgtc1Ext = ((int)0x8DBC)        ,
        CompressedRedGreenRgtc2Ext = ((int)0x8DBD)        ,
        CompressedSignedRedGreenRgtc2Ext = ((int)0x8DBE)        ,
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
    public enum ExtTextureCubeMap : int
    {
        NormalMapExt = ((int)0x8511)        ,
        ReflectionMapExt = ((int)0x8512)        ,
        TextureCubeMapExt = ((int)0x8513)        ,
        TextureBindingCubeMapExt = ((int)0x8514)        ,
        TextureCubeMapPositiveXExt = ((int)0x8515)        ,
        TextureCubeMapNegativeXExt = ((int)0x8516)        ,
        TextureCubeMapPositiveYExt = ((int)0x8517)        ,
        TextureCubeMapNegativeYExt = ((int)0x8518)        ,
        TextureCubeMapPositiveZExt = ((int)0x8519)        ,
        TextureCubeMapNegativeZExt = ((int)0x851A)        ,
        ProxyTextureCubeMapExt = ((int)0x851B)        ,
        MaxCubeMapTextureSizeExt = ((int)0x851C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureEnvAdd : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureEnvCombine : int
    {
        CombineExt = ((int)0x8570)        ,
        CombineRgbExt = ((int)0x8571)        ,
        CombineAlphaExt = ((int)0x8572)        ,
        RgbScaleExt = ((int)0x8573)        ,
        AddSignedExt = ((int)0x8574)        ,
        InterpolateExt = ((int)0x8575)        ,
        ConstantExt = ((int)0x8576)        ,
        PrimaryColorExt = ((int)0x8577)        ,
        PreviousExt = ((int)0x8578)        ,
        Source0RgbExt = ((int)0x8580)        ,
        Source1RgbExt = ((int)0x8581)        ,
        Source2RgbExt = ((int)0x8582)        ,
        Source0AlphaExt = ((int)0x8588)        ,
        Source1AlphaExt = ((int)0x8589)        ,
        Source2AlphaExt = ((int)0x858A)        ,
        Operand0RgbExt = ((int)0x8590)        ,
        Operand1RgbExt = ((int)0x8591)        ,
        Operand2RgbExt = ((int)0x8592)        ,
        Operand0AlphaExt = ((int)0x8598)        ,
        Operand1AlphaExt = ((int)0x8599)        ,
        Operand2AlphaExt = ((int)0x859A)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureEnvDot3 : int
    {
        Dot3RgbExt = ((int)0x8740)        ,
        Dot3RgbaExt = ((int)0x8741)        ,
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
    public enum ExtTextureInteger : int
    {
        Rgba32uiExt = ((int)0x8D70)        ,
        Rgb32uiExt = ((int)0x8D71)        ,
        Alpha32uiExt = ((int)0x8D72)        ,
        Intensity32uiExt = ((int)0x8D73)        ,
        Luminance32uiExt = ((int)0x8D74)        ,
        LuminanceAlpha32uiExt = ((int)0x8D75)        ,
        Rgba16uiExt = ((int)0x8D76)        ,
        Rgb16uiExt = ((int)0x8D77)        ,
        Alpha16uiExt = ((int)0x8D78)        ,
        Intensity16uiExt = ((int)0x8D79)        ,
        Luminance16uiExt = ((int)0x8D7A)        ,
        LuminanceAlpha16uiExt = ((int)0x8D7B)        ,
        Rgba8uiExt = ((int)0x8D7C)        ,
        Rgb8uiExt = ((int)0x8D7D)        ,
        Alpha8uiExt = ((int)0x8D7E)        ,
        Intensity8uiExt = ((int)0x8D7F)        ,
        Luminance8uiExt = ((int)0x8D80)        ,
        LuminanceAlpha8uiExt = ((int)0x8D81)        ,
        Rgba32iExt = ((int)0x8D82)        ,
        Rgb32iExt = ((int)0x8D83)        ,
        Alpha32iExt = ((int)0x8D84)        ,
        Intensity32iExt = ((int)0x8D85)        ,
        Luminance32iExt = ((int)0x8D86)        ,
        LuminanceAlpha32iExt = ((int)0x8D87)        ,
        Rgba16iExt = ((int)0x8D88)        ,
        Rgb16iExt = ((int)0x8D89)        ,
        Alpha16iExt = ((int)0x8D8A)        ,
        Intensity16iExt = ((int)0x8D8B)        ,
        Luminance16iExt = ((int)0x8D8C)        ,
        LuminanceAlpha16iExt = ((int)0x8D8D)        ,
        Rgba8iExt = ((int)0x8D8E)        ,
        Rgb8iExt = ((int)0x8D8F)        ,
        Alpha8iExt = ((int)0x8D90)        ,
        Intensity8iExt = ((int)0x8D91)        ,
        Luminance8iExt = ((int)0x8D92)        ,
        LuminanceAlpha8iExt = ((int)0x8D93)        ,
        RedIntegerExt = ((int)0x8D94)        ,
        GreenIntegerExt = ((int)0x8D95)        ,
        BlueIntegerExt = ((int)0x8D96)        ,
        AlphaIntegerExt = ((int)0x8D97)        ,
        RgbIntegerExt = ((int)0x8D98)        ,
        RgbaIntegerExt = ((int)0x8D99)        ,
        BgrIntegerExt = ((int)0x8D9A)        ,
        BgraIntegerExt = ((int)0x8D9B)        ,
        LuminanceIntegerExt = ((int)0x8D9C)        ,
        LuminanceAlphaIntegerExt = ((int)0x8D9D)        ,
        RgbaIntegerModeExt = ((int)0x8D9E)        ,
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
    public enum ExtTextureMirrorClamp : int
    {
        MirrorClampExt = ((int)0x8742)        ,
        MirrorClampToEdgeExt = ((int)0x8743)        ,
        MirrorClampToBorderExt = ((int)0x8912)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureObject : int
    {
        TexturePriorityExt = ((int)0x8066)        ,
        TextureResidentExt = ((int)0x8067)        ,
        Texture1DBindingExt = ((int)0x8068)        ,
        Texture2DBindingExt = ((int)0x8069)        ,
        Texture3DBindingExt = ((int)0x806A)        ,
    }

    /// <summary>
    /// Used in GL.Ext.TextureNormal
    /// </summary>
    public enum ExtTexturePerturbNormal : int
    {
        PerturbExt = ((int)0x85AE)        ,
        TextureNormalExt = ((int)0x85AF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureSharedExponent : int
    {
        Rgb9E5Ext = ((int)0x8C3D)        ,
        UnsignedInt5999RevExt = ((int)0x8C3E)        ,
        TextureSharedSizeExt = ((int)0x8C3F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureSnorm : int
    {
        RedSnorm = ((int)0x8F90)        ,
        RgSnorm = ((int)0x8F91)        ,
        RgbSnorm = ((int)0x8F92)        ,
        RgbaSnorm = ((int)0x8F93)        ,
        R8Snorm = ((int)0x8F94)        ,
        Rg8Snorm = ((int)0x8F95)        ,
        Rgb8Snorm = ((int)0x8F96)        ,
        Rgba8Snorm = ((int)0x8F97)        ,
        R16Snorm = ((int)0x8F98)        ,
        Rg16Snorm = ((int)0x8F99)        ,
        Rgb16Snorm = ((int)0x8F9A)        ,
        Rgba16Snorm = ((int)0x8F9B)        ,
        SignedNormalized = ((int)0x8F9C)        ,
        AlphaSnorm = ((int)0x9010)        ,
        LuminanceSnorm = ((int)0x9011)        ,
        LuminanceAlphaSnorm = ((int)0x9012)        ,
        IntensitySnorm = ((int)0x9013)        ,
        Alpha8Snorm = ((int)0x9014)        ,
        Luminance8Snorm = ((int)0x9015)        ,
        Luminance8Alpha8Snorm = ((int)0x9016)        ,
        Intensity8Snorm = ((int)0x9017)        ,
        Alpha16Snorm = ((int)0x9018)        ,
        Luminance16Snorm = ((int)0x9019)        ,
        Luminance16Alpha16Snorm = ((int)0x901A)        ,
        Intensity16Snorm = ((int)0x901B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureSrgb : int
    {
        SrgbExt = ((int)0x8C40)        ,
        Srgb8Ext = ((int)0x8C41)        ,
        SrgbAlphaExt = ((int)0x8C42)        ,
        Srgb8Alpha8Ext = ((int)0x8C43)        ,
        SluminanceAlphaExt = ((int)0x8C44)        ,
        Sluminance8Alpha8Ext = ((int)0x8C45)        ,
        SluminanceExt = ((int)0x8C46)        ,
        Sluminance8Ext = ((int)0x8C47)        ,
        CompressedSrgbExt = ((int)0x8C48)        ,
        CompressedSrgbAlphaExt = ((int)0x8C49)        ,
        CompressedSluminanceExt = ((int)0x8C4A)        ,
        CompressedSluminanceAlphaExt = ((int)0x8C4B)        ,
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C)        ,
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D)        ,
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E)        ,
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F)        ,
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
    public enum ExtTextureSwizzle : int
    {
        TextureSwizzleRExt = ((int)0x8E42)        ,
        TextureSwizzleGExt = ((int)0x8E43)        ,
        TextureSwizzleBExt = ((int)0x8E44)        ,
        TextureSwizzleAExt = ((int)0x8E45)        ,
        TextureSwizzleRgbaExt = ((int)0x8E46)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetQueryObject
    /// </summary>
    public enum ExtTimerQuery : int
    {
        TimeElapsedExt = ((int)0x88BF)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BeginTransformFeedback, GL.Ext.BindBufferBase and 4 other functions
    /// </summary>
    public enum ExtTransformFeedback : int
    {
        TransformFeedbackVaryingMaxLengthExt = ((int)0x8C76)        ,
        TransformFeedbackBufferModeExt = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponentsExt = ((int)0x8C80)        ,
        TransformFeedbackVaryingsExt = ((int)0x8C83)        ,
        TransformFeedbackBufferStartExt = ((int)0x8C84)        ,
        TransformFeedbackBufferSizeExt = ((int)0x8C85)        ,
        PrimitivesGeneratedExt = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWrittenExt = ((int)0x8C88)        ,
        RasterizerDiscardExt = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponentsExt = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribsExt = ((int)0x8C8B)        ,
        InterleavedAttribsExt = ((int)0x8C8C)        ,
        SeparateAttribsExt = ((int)0x8C8D)        ,
        TransformFeedbackBufferExt = ((int)0x8C8E)        ,
        TransformFeedbackBufferBindingExt = ((int)0x8C8F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtVertexArray : int
    {
        VertexArrayExt = ((int)0x8074)        ,
        NormalArrayExt = ((int)0x8075)        ,
        ColorArrayExt = ((int)0x8076)        ,
        IndexArrayExt = ((int)0x8077)        ,
        TextureCoordArrayExt = ((int)0x8078)        ,
        EdgeFlagArrayExt = ((int)0x8079)        ,
        VertexArraySizeExt = ((int)0x807A)        ,
        VertexArrayTypeExt = ((int)0x807B)        ,
        VertexArrayStrideExt = ((int)0x807C)        ,
        VertexArrayCountExt = ((int)0x807D)        ,
        NormalArrayTypeExt = ((int)0x807E)        ,
        NormalArrayStrideExt = ((int)0x807F)        ,
        NormalArrayCountExt = ((int)0x8080)        ,
        ColorArraySizeExt = ((int)0x8081)        ,
        ColorArrayTypeExt = ((int)0x8082)        ,
        ColorArrayStrideExt = ((int)0x8083)        ,
        ColorArrayCountExt = ((int)0x8084)        ,
        IndexArrayTypeExt = ((int)0x8085)        ,
        IndexArrayStrideExt = ((int)0x8086)        ,
        IndexArrayCountExt = ((int)0x8087)        ,
        TextureCoordArraySizeExt = ((int)0x8088)        ,
        TextureCoordArrayTypeExt = ((int)0x8089)        ,
        TextureCoordArrayStrideExt = ((int)0x808A)        ,
        TextureCoordArrayCountExt = ((int)0x808B)        ,
        EdgeFlagArrayStrideExt = ((int)0x808C)        ,
        EdgeFlagArrayCountExt = ((int)0x808D)        ,
        VertexArrayPointerExt = ((int)0x808E)        ,
        NormalArrayPointerExt = ((int)0x808F)        ,
        ColorArrayPointerExt = ((int)0x8090)        ,
        IndexArrayPointerExt = ((int)0x8091)        ,
        TextureCoordArrayPointerExt = ((int)0x8092)        ,
        EdgeFlagArrayPointerExt = ((int)0x8093)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtVertexArrayBgra : int
    {
        Bgra = ((int)0x80E1)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetVertexAttribL, GL.Ext.VertexArrayVertexAttribLOffset and 1 other function
    /// </summary>
    public enum ExtVertexAttrib64bit : int
    {
        Double = ((int)0x140A)        ,
        DoubleMat2Ext = ((int)0x8F46)        ,
        DoubleMat3Ext = ((int)0x8F47)        ,
        DoubleMat4Ext = ((int)0x8F48)        ,
        DoubleMat2x3Ext = ((int)0x8F49)        ,
        DoubleMat2x4Ext = ((int)0x8F4A)        ,
        DoubleMat3x2Ext = ((int)0x8F4B)        ,
        DoubleMat3x4Ext = ((int)0x8F4C)        ,
        DoubleMat4x2Ext = ((int)0x8F4D)        ,
        DoubleMat4x3Ext = ((int)0x8F4E)        ,
        DoubleVec2Ext = ((int)0x8FFC)        ,
        DoubleVec3Ext = ((int)0x8FFD)        ,
        DoubleVec4Ext = ((int)0x8FFE)        ,
    }

    /// <summary>
    /// Used in GL.Ext.BindParameter, GL.Ext.BindTextureUnitParameter and 20 other functions
    /// </summary>
    public enum ExtVertexShader : int
    {
        VertexShaderExt = ((int)0x8780)        ,
        VertexShaderBindingExt = ((int)0x8781)        ,
        OpIndexExt = ((int)0x8782)        ,
        OpNegateExt = ((int)0x8783)        ,
        OpDot3Ext = ((int)0x8784)        ,
        OpDot4Ext = ((int)0x8785)        ,
        OpMulExt = ((int)0x8786)        ,
        OpAddExt = ((int)0x8787)        ,
        OpMaddExt = ((int)0x8788)        ,
        OpFracExt = ((int)0x8789)        ,
        OpMaxExt = ((int)0x878A)        ,
        OpMinExt = ((int)0x878B)        ,
        OpSetGeExt = ((int)0x878C)        ,
        OpSetLtExt = ((int)0x878D)        ,
        OpClampExt = ((int)0x878E)        ,
        OpFloorExt = ((int)0x878F)        ,
        OpRoundExt = ((int)0x8790)        ,
        OpExpBase2Ext = ((int)0x8791)        ,
        OpLogBase2Ext = ((int)0x8792)        ,
        OpPowerExt = ((int)0x8793)        ,
        OpRecipExt = ((int)0x8794)        ,
        OpRecipSqrtExt = ((int)0x8795)        ,
        OpSubExt = ((int)0x8796)        ,
        OpCrossProductExt = ((int)0x8797)        ,
        OpMultiplyMatrixExt = ((int)0x8798)        ,
        OpMovExt = ((int)0x8799)        ,
        OutputVertexExt = ((int)0x879A)        ,
        OutputColor0Ext = ((int)0x879B)        ,
        OutputColor1Ext = ((int)0x879C)        ,
        OutputTextureCoord0Ext = ((int)0x879D)        ,
        OutputTextureCoord1Ext = ((int)0x879E)        ,
        OutputTextureCoord2Ext = ((int)0x879F)        ,
        OutputTextureCoord3Ext = ((int)0x87A0)        ,
        OutputTextureCoord4Ext = ((int)0x87A1)        ,
        OutputTextureCoord5Ext = ((int)0x87A2)        ,
        OutputTextureCoord6Ext = ((int)0x87A3)        ,
        OutputTextureCoord7Ext = ((int)0x87A4)        ,
        OutputTextureCoord8Ext = ((int)0x87A5)        ,
        OutputTextureCoord9Ext = ((int)0x87A6)        ,
        OutputTextureCoord10Ext = ((int)0x87A7)        ,
        OutputTextureCoord11Ext = ((int)0x87A8)        ,
        OutputTextureCoord12Ext = ((int)0x87A9)        ,
        OutputTextureCoord13Ext = ((int)0x87AA)        ,
        OutputTextureCoord14Ext = ((int)0x87AB)        ,
        OutputTextureCoord15Ext = ((int)0x87AC)        ,
        OutputTextureCoord16Ext = ((int)0x87AD)        ,
        OutputTextureCoord17Ext = ((int)0x87AE)        ,
        OutputTextureCoord18Ext = ((int)0x87AF)        ,
        OutputTextureCoord19Ext = ((int)0x87B0)        ,
        OutputTextureCoord20Ext = ((int)0x87B1)        ,
        OutputTextureCoord21Ext = ((int)0x87B2)        ,
        OutputTextureCoord22Ext = ((int)0x87B3)        ,
        OutputTextureCoord23Ext = ((int)0x87B4)        ,
        OutputTextureCoord24Ext = ((int)0x87B5)        ,
        OutputTextureCoord25Ext = ((int)0x87B6)        ,
        OutputTextureCoord26Ext = ((int)0x87B7)        ,
        OutputTextureCoord27Ext = ((int)0x87B8)        ,
        OutputTextureCoord28Ext = ((int)0x87B9)        ,
        OutputTextureCoord29Ext = ((int)0x87BA)        ,
        OutputTextureCoord30Ext = ((int)0x87BB)        ,
        OutputTextureCoord31Ext = ((int)0x87BC)        ,
        OutputFogExt = ((int)0x87BD)        ,
        ScalarExt = ((int)0x87BE)        ,
        VectorExt = ((int)0x87BF)        ,
        MatrixExt = ((int)0x87C0)        ,
        VariantExt = ((int)0x87C1)        ,
        InvariantExt = ((int)0x87C2)        ,
        LocalConstantExt = ((int)0x87C3)        ,
        LocalExt = ((int)0x87C4)        ,
        MaxVertexShaderInstructionsExt = ((int)0x87C5)        ,
        MaxVertexShaderVariantsExt = ((int)0x87C6)        ,
        MaxVertexShaderInvariantsExt = ((int)0x87C7)        ,
        MaxVertexShaderLocalConstantsExt = ((int)0x87C8)        ,
        MaxVertexShaderLocalsExt = ((int)0x87C9)        ,
        MaxOptimizedVertexShaderInstructionsExt = ((int)0x87CA)        ,
        MaxOptimizedVertexShaderVariantsExt = ((int)0x87CB)        ,
        MaxOptimizedVertexShaderLocalConstantsExt = ((int)0x87CC)        ,
        MaxOptimizedVertexShaderInvariantsExt = ((int)0x87CD)        ,
        MaxOptimizedVertexShaderLocalsExt = ((int)0x87CE)        ,
        VertexShaderInstructionsExt = ((int)0x87CF)        ,
        VertexShaderVariantsExt = ((int)0x87D0)        ,
        VertexShaderInvariantsExt = ((int)0x87D1)        ,
        VertexShaderLocalConstantsExt = ((int)0x87D2)        ,
        VertexShaderLocalsExt = ((int)0x87D3)        ,
        VertexShaderOptimizedExt = ((int)0x87D4)        ,
        XExt = ((int)0x87D5)        ,
        YExt = ((int)0x87D6)        ,
        ZExt = ((int)0x87D7)        ,
        WExt = ((int)0x87D8)        ,
        NegativeXExt = ((int)0x87D9)        ,
        NegativeYExt = ((int)0x87DA)        ,
        NegativeZExt = ((int)0x87DB)        ,
        NegativeWExt = ((int)0x87DC)        ,
        ZeroExt = ((int)0x87DD)        ,
        OneExt = ((int)0x87DE)        ,
        NegativeOneExt = ((int)0x87DF)        ,
        NormalizedRangeExt = ((int)0x87E0)        ,
        FullRangeExt = ((int)0x87E1)        ,
        CurrentVertexExt = ((int)0x87E2)        ,
        MvpMatrixExt = ((int)0x87E3)        ,
        VariantValueExt = ((int)0x87E4)        ,
        VariantDatatypeExt = ((int)0x87E5)        ,
        VariantArrayStrideExt = ((int)0x87E6)        ,
        VariantArrayTypeExt = ((int)0x87E7)        ,
        VariantArrayExt = ((int)0x87E8)        ,
        VariantArrayPointerExt = ((int)0x87E9)        ,
        InvariantValueExt = ((int)0x87EA)        ,
        InvariantDatatypeExt = ((int)0x87EB)        ,
        LocalConstantValueExt = ((int)0x87EC)        ,
        LocalConstantDatatypeExt = ((int)0x87ED)        ,
    }

    /// <summary>
    /// Used in GL.Ext.VertexWeightPointer
    /// </summary>
    public enum ExtVertexWeighting : int
    {
        Modelview0StackDepthExt = ((int)0x0BA3)        ,
        Modelview0MatrixExt = ((int)0x0BA6)        ,
        Modelview0Ext = ((int)0x1700)        ,
        Modelview1StackDepthExt = ((int)0x8502)        ,
        Modelview1MatrixExt = ((int)0x8506)        ,
        VertexWeightingExt = ((int)0x8509)        ,
        Modelview1Ext = ((int)0x850A)        ,
        CurrentVertexWeightExt = ((int)0x850B)        ,
        VertexWeightArrayExt = ((int)0x850C)        ,
        VertexWeightArraySizeExt = ((int)0x850D)        ,
        VertexWeightArrayTypeExt = ((int)0x850E)        ,
        VertexWeightArrayStrideExt = ((int)0x850F)        ,
        VertexWeightArrayPointerExt = ((int)0x8510)        ,
    }

    /// <summary>
    /// Used in GL.Ext.ImportSync
    /// </summary>
    public enum ExtX11SyncObject : int
    {
        SyncX11FenceExt = ((int)0x90E1)        ,
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
    /// Used in GL.FeedbackBuffer
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
    /// Used in GL.Sgix.Deform, GL.Sgix.LoadIdentityDeformationMap
    /// </summary>
    [Flags]
    public enum FfdMaskSgix : int
    {
    }

    /// <summary>
    /// Used in GL.Sgix.DeformationMap3
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
        Exp = ((int)0x0800)        ,
        Exp2 = ((int)0x0801)        ,
        Linear = ((int)0x2601)        ,
        FogFuncSgis = ((int)0x812A)        ,
        FogCoord = ((int)0x8451)        ,
        FragmentDepth = ((int)0x8452)        ,
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
        FogCoordSrc = ((int)0x8450)        ,
    }

    /// <summary>
    /// Used in GL.FogCoordPointer, GL.Ext.VertexArrayFogCoordOffset and 1 other function
    /// </summary>
    public enum FogPointerType : int
    {
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
        HalfFloat = ((int)0x140B)        ,
    }

    /// <summary>
    /// Used in GL.Ext.FogCoordPointer
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
    /// Used in GL.Sgix.FragmentLightModel
    /// </summary>
    public enum FragmentLightModelParameterSgix : int
    {
        FragmentLightModelLocalViewerSgix = ((int)0x8408)        ,
        FragmentLightModelTwoSideSgix = ((int)0x8409)        ,
        FragmentLightModelAmbientSgix = ((int)0x840A)        ,
        FragmentLightModelNormalInterpolationSgix = ((int)0x840B)        ,
    }

    /// <summary>
    /// Used in GL.Arb.FramebufferTexture, GL.Arb.FramebufferTextureFace and 26 other functions
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
    /// Used in GL.GetFramebufferAttachmentParameter, GL.Ext.GetFramebufferAttachmentParameter and 1 other function
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
    /// Used in GL.Arb.FramebufferTexture, GL.Arb.FramebufferTextureFace and 25 other functions
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
    /// Used in GL.GenerateMipmap, GL.Ext.GenerateMipmap
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
    /// Used in GL.GetColorTableParameter, GL.Ext.GetColorTableParameter
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
    /// Used in GL.Sgi.GetColorTableParameter
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
    /// Used in GL.Ext.GetHistogramParameter
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
    /// Used in GL.GetBoolean, GL.GetDouble and 4 other functions
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
    /// Used in GL.GetMap
    /// </summary>
    public enum GetMapQuery : int
    {
        Coeff = ((int)0x0A00)        ,
        Order = ((int)0x0A01)        ,
        Domain = ((int)0x0A02)        ,
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
    /// Used in GL.Ext.GetMinmaxParameter
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
    /// Used in GL.GetBoolean, GL.GetDouble and 3 other functions
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
    /// Used in GL.GetPointer, GL.Ext.GetPointer
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
    /// Used in GL.GetTexLevelParameter, GL.GetTexParameter and 8 other functions
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
    /// Not used directly.
    /// </summary>
    public enum Gl3DfxMultisample : int
    {
        MultisampleBit3Dfx = ((int)0x20000000)        ,
        Multisample3Dfx = ((int)0x86B2)        ,
        SampleBuffers3Dfx = ((int)0x86B3)        ,
        Samples3Dfx = ((int)0x86B4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Gl3DfxTbuffer : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Gl3DfxTextureCompressionFxt1 : int
    {
        CompressedRgbFxt13Dfx = ((int)0x86B0)        ,
        CompressedRgbaFxt13Dfx = ((int)0x86B1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GremedyFrameTerminator : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum GremedyStringMarker : int
    {
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
    /// Used in GL.Ext.GetHistogram, GL.Ext.GetHistogramParameter and 2 other functions
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
    public enum HpConvolutionBorderModes : int
    {
        IgnoreBorderHp = ((int)0x8150)        ,
        ConstantBorderHp = ((int)0x8151)        ,
        ReplicateBorderHp = ((int)0x8153)        ,
        ConvolutionBorderColorHp = ((int)0x8154)        ,
    }

    /// <summary>
    /// Used in GL.HP.GetImageTransformParameter, GL.HP.ImageTransformParameter
    /// </summary>
    public enum HpImageTransform : int
    {
        ImageScaleXHp = ((int)0x8155)        ,
        ImageScaleYHp = ((int)0x8156)        ,
        ImageTranslateXHp = ((int)0x8157)        ,
        ImageTranslateYHp = ((int)0x8158)        ,
        ImageRotateAngleHp = ((int)0x8159)        ,
        ImageRotateOriginXHp = ((int)0x815A)        ,
        ImageRotateOriginYHp = ((int)0x815B)        ,
        ImageMagFilterHp = ((int)0x815C)        ,
        ImageMinFilterHp = ((int)0x815D)        ,
        ImageCubicWeightHp = ((int)0x815E)        ,
        CubicHp = ((int)0x815F)        ,
        AverageHp = ((int)0x8160)        ,
        ImageTransform2DHp = ((int)0x8161)        ,
        PostImageTransformColorTableHp = ((int)0x8162)        ,
        ProxyPostImageTransformColorTableHp = ((int)0x8163)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum HpOcclusionTest : int
    {
        OcclusionTestHp = ((int)0x8165)        ,
        OcclusionTestResultHp = ((int)0x8166)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum HpTextureLighting : int
    {
        TextureLightingModeHp = ((int)0x8167)        ,
        TexturePostSpecularHp = ((int)0x8168)        ,
        TexturePreSpecularHp = ((int)0x8169)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IbmCullVertex : int
    {
        CullVertexIbm = ((int)103050)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IbmMultimodeDrawArrays : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IbmRasterposClip : int
    {
        RasterPositionUnclippedIbm = ((int)0x19262)        ,
    }

    /// <summary>
    /// Used in GL.Ibm.FlushStaticData
    /// </summary>
    public enum IbmStaticData : int
    {
        AllStaticDataIbm = ((int)103060)        ,
        StaticVertexArrayIbm = ((int)103061)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IbmTextureMirroredRepeat : int
    {
        MirroredRepeatIbm = ((int)0x8370)        ,
    }

    /// <summary>
    /// Used in GL.Ibm.FogCoordPointerList, GL.Ibm.SecondaryColorPointerList
    /// </summary>
    public enum IbmVertexArrayLists : int
    {
        VertexArrayListIbm = ((int)103070)        ,
        NormalArrayListIbm = ((int)103071)        ,
        ColorArrayListIbm = ((int)103072)        ,
        IndexArrayListIbm = ((int)103073)        ,
        TextureCoordArrayListIbm = ((int)103074)        ,
        EdgeFlagArrayListIbm = ((int)103075)        ,
        FogCoordinateArrayListIbm = ((int)103076)        ,
        SecondaryColorArrayListIbm = ((int)103077)        ,
        VertexArrayListStrideIbm = ((int)103080)        ,
        NormalArrayListStrideIbm = ((int)103081)        ,
        ColorArrayListStrideIbm = ((int)103082)        ,
        IndexArrayListStrideIbm = ((int)103083)        ,
        TextureCoordArrayListStrideIbm = ((int)103084)        ,
        EdgeFlagArrayListStrideIbm = ((int)103085)        ,
        FogCoordinateArrayListStrideIbm = ((int)103086)        ,
        SecondaryColorArrayListStrideIbm = ((int)103087)        ,
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
    /// Used in GL.Disable, GL.Enable and 4 other functions
    /// </summary>
    public enum IndexedEnableCap : int
    {
        Blend = ((int)0x0BE2)        ,
        ScissorTest = ((int)0x0C11)        ,
    }

    /// <summary>
    /// Used in GL.IndexPointer, GL.Ext.IndexPointer and 2 other functions
    /// </summary>
    public enum IndexPointerType : int
    {
        Short = ((int)0x1402)        ,
        Int = ((int)0x1404)        ,
        Float = ((int)0x1406)        ,
        Double = ((int)0x140A)        ,
    }

    /// <summary>
    /// Used in GL.Ingr.BlendFuncSeparate
    /// </summary>
    public enum IngrBlendFuncSeparate : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IngrColorClamp : int
    {
        RedMinClampIngr = ((int)0x8560)        ,
        GreenMinClampIngr = ((int)0x8561)        ,
        BlueMinClampIngr = ((int)0x8562)        ,
        AlphaMinClampIngr = ((int)0x8563)        ,
        RedMaxClampIngr = ((int)0x8564)        ,
        GreenMaxClampIngr = ((int)0x8565)        ,
        BlueMaxClampIngr = ((int)0x8566)        ,
        AlphaMaxClampIngr = ((int)0x8567)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IngrInterlaceRead : int
    {
        InterlaceReadIngr = ((int)0x8568)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IntelFragmentShaderOrdering : int
    {
    }

    /// <summary>
    /// Used in GL.Intel.MapTexture2D
    /// </summary>
    public enum IntelMapTexture : int
    {
        LayoutDefaultIntel = ((int)0)        ,
        TextureMemoryLayoutIntel = ((int)0x83FF)        ,
        LayoutLinearIntel = ((int)1)        ,
        LayoutLinearCpuCachedIntel = ((int)2)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum IntelParallelArrays : int
    {
        ParallelArraysIntel = ((int)0x83F4)        ,
        VertexArrayParallelPointersIntel = ((int)0x83F5)        ,
        NormalArrayParallelPointersIntel = ((int)0x83F6)        ,
        ColorArrayParallelPointersIntel = ((int)0x83F7)        ,
        TextureCoordArrayParallelPointersIntel = ((int)0x83F8)        ,
    }

    /// <summary>
    /// Used in GL.InterleavedArrays
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
    /// Used in GL.Khr.DebugMessageControl, GL.Khr.DebugMessageInsert and 5 other functions
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
    /// Used in GL.Sgix.LightEnv
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
    /// Used in GL.GetLight, GL.Light and 1 other function
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
    /// Used in GL.GetLight, GL.Light and 1 other function
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
    /// Used in GL.NewList
    /// </summary>
    public enum ListMode : int
    {
        Compile = ((int)0x1300)        ,
        CompileAndExecute = ((int)0x1301)        ,
    }

    /// <summary>
    /// Used in GL.CallLists
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
    /// Used in GL.Sgix.GetListParameter, GL.Sgix.ListParameter
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
    /// Used in GL.GetMap, GL.Map1 and 1 other function
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
    /// Used in GL.ColorMaterial, GL.GetMaterial and 8 other functions
    /// </summary>
    public enum MaterialFace : int
    {
        Front = ((int)0x0404)        ,
        Back = ((int)0x0405)        ,
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Used in GL.GetMaterial, GL.Material and 5 other functions
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
    /// Used in GL.MatrixMode, GL.Ext.MatrixFrustum and 11 other functions
    /// </summary>
    public enum MatrixMode : int
    {
        Modelview = ((int)0x1700)        ,
        Modelview0Ext = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MatrixModeArb : int
    {
        Modelview = ((int)0x1700)        ,
        Projection = ((int)0x1701)        ,
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
    public enum MesaPackInvert : int
    {
        PackInvertMesa = ((int)0x8758)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MesaResizeBuffers : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MesaWindowPos : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MesaxTextureStack : int
    {
        Texture1DStackMesax = ((int)0x8759)        ,
        Texture2DStackMesax = ((int)0x875A)        ,
        ProxyTexture1DStackMesax = ((int)0x875B)        ,
        ProxyTexture2DStackMesax = ((int)0x875C)        ,
        Texture1DStackBindingMesax = ((int)0x875D)        ,
        Texture2DStackBindingMesax = ((int)0x875E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum MesaYcbcrTexture : int
    {
        UnsignedShort88Mesa = ((int)0x85BA)        ,
        UnsignedShort88RevMesa = ((int)0x85BB)        ,
        YcbcrMesa = ((int)0x8757)        ,
    }

    /// <summary>
    /// Used in GL.EvalMesh1
    /// </summary>
    public enum MeshMode1 : int
    {
        Point = ((int)0x1B00)        ,
        Line = ((int)0x1B01)        ,
    }

    /// <summary>
    /// Used in GL.EvalMesh2
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
    /// Used in GL.Ext.GetMinmax, GL.Ext.GetMinmaxParameter and 2 other functions
    /// </summary>
    public enum MinmaxTargetExt : int
    {
        Minmax = ((int)0x802E)        ,
        MinmaxExt = ((int)0x802E)        ,
    }

    /// <summary>
    /// Used in GL.NormalPointer, GL.Ext.BinormalPointer and 5 other functions
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
    /// Used in GL.NV.MultiDrawArraysIndirectBindles, GL.NV.MultiDrawElementsIndirectBindles
    /// </summary>
    public enum NvBindlessMultiDrawIndirect : int
    {
    }

    /// <summary>
    /// Used in GL.NV.GetImageHandle, GL.NV.MakeImageHandleResident
    /// </summary>
    public enum NvBindlessTexture : int
    {
    }

    /// <summary>
    /// Used in GL.NV.BlendParameter
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
    public enum NvBlendSquare : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvComputeProgram5 : int
    {
        ComputeProgramNv = ((int)0x90FB)        ,
        ComputeProgramParameterBufferNv = ((int)0x90FC)        ,
    }

    /// <summary>
    /// Used in GL.NV.BeginConditionalRender
    /// </summary>
    public enum NvConditionalRender : int
    {
        QueryWaitNv = ((int)0x8E13)        ,
        QueryNoWaitNv = ((int)0x8E14)        ,
        QueryByRegionWaitNv = ((int)0x8E15)        ,
        QueryByRegionNoWaitNv = ((int)0x8E16)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvCopyDepthToColor : int
    {
        DepthStencilToRgbaNv = ((int)0x886E)        ,
        DepthStencilToBgraNv = ((int)0x886F)        ,
    }

    /// <summary>
    /// Used in GL.NV.CopyImageSubData
    /// </summary>
    public enum NvCopyImage : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDeepTexture3D : int
    {
        MaxDeep3DTextureWidthHeightNv = ((int)0x90D0)        ,
        MaxDeep3DTextureDepthNv = ((int)0x90D1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDepthBufferFloat : int
    {
        DepthComponent32fNv = ((int)0x8DAB)        ,
        Depth32fStencil8Nv = ((int)0x8DAC)        ,
        Float32UnsignedInt248RevNv = ((int)0x8DAD)        ,
        DepthBufferFloatModeNv = ((int)0x8DAF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDepthClamp : int
    {
        DepthClampNv = ((int)0x864F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDrawTexture : int
    {
    }

    /// <summary>
    /// Used in GL.NV.EvalMap, GL.NV.GetMapAttribParameter and 4 other functions
    /// </summary>
    public enum NvEvaluators : int
    {
        Eval2DNv = ((int)0x86C0)        ,
        EvalTriangular2DNv = ((int)0x86C1)        ,
        MapTessellationNv = ((int)0x86C2)        ,
        MapAttribUOrderNv = ((int)0x86C3)        ,
        MapAttribVOrderNv = ((int)0x86C4)        ,
        EvalFractionalTessellationNv = ((int)0x86C5)        ,
        EvalVertexAttrib0Nv = ((int)0x86C6)        ,
        EvalVertexAttrib1Nv = ((int)0x86C7)        ,
        EvalVertexAttrib2Nv = ((int)0x86C8)        ,
        EvalVertexAttrib3Nv = ((int)0x86C9)        ,
        EvalVertexAttrib4Nv = ((int)0x86CA)        ,
        EvalVertexAttrib5Nv = ((int)0x86CB)        ,
        EvalVertexAttrib6Nv = ((int)0x86CC)        ,
        EvalVertexAttrib7Nv = ((int)0x86CD)        ,
        EvalVertexAttrib8Nv = ((int)0x86CE)        ,
        EvalVertexAttrib9Nv = ((int)0x86CF)        ,
        EvalVertexAttrib10Nv = ((int)0x86D0)        ,
        EvalVertexAttrib11Nv = ((int)0x86D1)        ,
        EvalVertexAttrib12Nv = ((int)0x86D2)        ,
        EvalVertexAttrib13Nv = ((int)0x86D3)        ,
        EvalVertexAttrib14Nv = ((int)0x86D4)        ,
        EvalVertexAttrib15Nv = ((int)0x86D5)        ,
        MaxMapTessellationNv = ((int)0x86D6)        ,
        MaxRationalEvalOrderNv = ((int)0x86D7)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetMultisample
    /// </summary>
    public enum NvExplicitMultisample : int
    {
        SamplePositionNv = ((int)0x8E50)        ,
        SampleMaskNv = ((int)0x8E51)        ,
        SampleMaskValueNv = ((int)0x8E52)        ,
        TextureBindingRenderbufferNv = ((int)0x8E53)        ,
        TextureRenderbufferDataStoreBindingNv = ((int)0x8E54)        ,
        TextureRenderbufferNv = ((int)0x8E55)        ,
        SamplerRenderbufferNv = ((int)0x8E56)        ,
        IntSamplerRenderbufferNv = ((int)0x8E57)        ,
        UnsignedIntSamplerRenderbufferNv = ((int)0x8E58)        ,
        MaxSampleMaskWordsNv = ((int)0x8E59)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetFence, GL.NV.SetFence
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
    public enum NvFloatBuffer : int
    {
        FloatRNv = ((int)0x8880)        ,
        FloatRgNv = ((int)0x8881)        ,
        FloatRgbNv = ((int)0x8882)        ,
        FloatRgbaNv = ((int)0x8883)        ,
        FloatR16Nv = ((int)0x8884)        ,
        FloatR32Nv = ((int)0x8885)        ,
        FloatRg16Nv = ((int)0x8886)        ,
        FloatRg32Nv = ((int)0x8887)        ,
        FloatRgb16Nv = ((int)0x8888)        ,
        FloatRgb32Nv = ((int)0x8889)        ,
        FloatRgba16Nv = ((int)0x888A)        ,
        FloatRgba32Nv = ((int)0x888B)        ,
        TextureFloatComponentsNv = ((int)0x888C)        ,
        FloatClearColorValueNv = ((int)0x888D)        ,
        FloatRgbaModeNv = ((int)0x888E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFogDistance : int
    {
        EyePlane = ((int)0x2502)        ,
        FogDistanceModeNv = ((int)0x855A)        ,
        EyeRadialNv = ((int)0x855B)        ,
        EyePlaneAbsoluteNv = ((int)0x855C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFragmentProgram : int
    {
        MaxFragmentProgramLocalParametersNv = ((int)0x8868)        ,
        FragmentProgramNv = ((int)0x8870)        ,
        MaxTextureCoordsNv = ((int)0x8871)        ,
        MaxTextureImageUnitsNv = ((int)0x8872)        ,
        FragmentProgramBindingNv = ((int)0x8873)        ,
        ProgramErrorStringNv = ((int)0x8874)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFragmentProgram2 : int
    {
        MaxProgramExecInstructionsNv = ((int)0x88F4)        ,
        MaxProgramCallDepthNv = ((int)0x88F5)        ,
        MaxProgramIfDepthNv = ((int)0x88F6)        ,
        MaxProgramLoopDepthNv = ((int)0x88F7)        ,
        MaxProgramLoopCountNv = ((int)0x88F8)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFragmentProgram4 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFragmentProgramOption : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFramebufferMultisampleCoverage : int
    {
        RenderbufferCoverageSamplesNv = ((int)0x8CAB)        ,
        RenderbufferColorSamplesNv = ((int)0x8E10)        ,
        MaxMultisampleCoverageModesNv = ((int)0x8E11)        ,
        MultisampleCoverageModesNv = ((int)0x8E12)        ,
    }

    /// <summary>
    /// Used in GL.NV.ProgramVertexLimit
    /// </summary>
    public enum NvGeometryProgram4 : int
    {
        LinesAdjacencyExt = ((int)0x000A)        ,
        LineStripAdjacencyExt = ((int)0x000B)        ,
        TrianglesAdjacencyExt = ((int)0x000C)        ,
        TriangleStripAdjacencyExt = ((int)0x000D)        ,
        ProgramPointSizeExt = ((int)0x8642)        ,
        GeometryProgramNv = ((int)0x8C26)        ,
        MaxProgramOutputVerticesNv = ((int)0x8C27)        ,
        MaxProgramTotalOutputComponentsNv = ((int)0x8C28)        ,
        MaxGeometryTextureImageUnitsExt = ((int)0x8C29)        ,
        FramebufferAttachmentTextureLayerExt = ((int)0x8CD4)        ,
        FramebufferAttachmentLayeredExt = ((int)0x8DA7)        ,
        FramebufferIncompleteLayerTargetsExt = ((int)0x8DA8)        ,
        FramebufferIncompleteLayerCountExt = ((int)0x8DA9)        ,
        GeometryVerticesOutExt = ((int)0x8DDA)        ,
        GeometryInputTypeExt = ((int)0x8DDB)        ,
        GeometryOutputTypeExt = ((int)0x8DDC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvGeometryShader4 : int
    {
    }

    /// <summary>
    /// Used in GL.NV.GetProgramEnvParameterI, GL.NV.GetProgramLocalParameterI and 4 other functions
    /// </summary>
    public enum NvGpuProgram4 : int
    {
        MinProgramTexelOffsetNv = ((int)0x8904)        ,
        MaxProgramTexelOffsetNv = ((int)0x8905)        ,
        ProgramAttribComponentsNv = ((int)0x8906)        ,
        ProgramResultComponentsNv = ((int)0x8907)        ,
        MaxProgramAttribComponentsNv = ((int)0x8908)        ,
        MaxProgramResultComponentsNv = ((int)0x8909)        ,
        MaxProgramGenericAttribsNv = ((int)0x8DA5)        ,
        MaxProgramGenericResultsNv = ((int)0x8DA6)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetProgramSubroutineParameter, GL.NV.ProgramSubroutineParameters
    /// </summary>
    public enum NvGpuProgram5 : int
    {
        MaxGeometryProgramInvocationsNv = ((int)0x8E5A)        ,
        MinFragmentInterpolationOffsetNv = ((int)0x8E5B)        ,
        MaxFragmentInterpolationOffsetNv = ((int)0x8E5C)        ,
        FragmentProgramInterpolationOffsetBitsNv = ((int)0x8E5D)        ,
        MinProgramTextureGatherOffsetNv = ((int)0x8E5E)        ,
        MaxProgramTextureGatherOffsetNv = ((int)0x8E5F)        ,
        MaxProgramSubroutineParametersNv = ((int)0x8F44)        ,
        MaxProgramSubroutineNumNv = ((int)0x8F45)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvGpuProgram5MemExtended : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvGpuShader5 : int
    {
        Patches = ((int)0x000E)        ,
        Int64Nv = ((int)0x140E)        ,
        UnsignedInt64Nv = ((int)0x140F)        ,
        Int8Nv = ((int)0x8FE0)        ,
        Int8Vec2Nv = ((int)0x8FE1)        ,
        Int8Vec3Nv = ((int)0x8FE2)        ,
        Int8Vec4Nv = ((int)0x8FE3)        ,
        Int16Nv = ((int)0x8FE4)        ,
        Int16Vec2Nv = ((int)0x8FE5)        ,
        Int16Vec3Nv = ((int)0x8FE6)        ,
        Int16Vec4Nv = ((int)0x8FE7)        ,
        Int64Vec2Nv = ((int)0x8FE9)        ,
        Int64Vec3Nv = ((int)0x8FEA)        ,
        Int64Vec4Nv = ((int)0x8FEB)        ,
        UnsignedInt8Nv = ((int)0x8FEC)        ,
        UnsignedInt8Vec2Nv = ((int)0x8FED)        ,
        UnsignedInt8Vec3Nv = ((int)0x8FEE)        ,
        UnsignedInt8Vec4Nv = ((int)0x8FEF)        ,
        UnsignedInt16Nv = ((int)0x8FF0)        ,
        UnsignedInt16Vec2Nv = ((int)0x8FF1)        ,
        UnsignedInt16Vec3Nv = ((int)0x8FF2)        ,
        UnsignedInt16Vec4Nv = ((int)0x8FF3)        ,
        UnsignedInt64Vec2Nv = ((int)0x8FF5)        ,
        UnsignedInt64Vec3Nv = ((int)0x8FF6)        ,
        UnsignedInt64Vec4Nv = ((int)0x8FF7)        ,
        Float16Nv = ((int)0x8FF8)        ,
        Float16Vec2Nv = ((int)0x8FF9)        ,
        Float16Vec3Nv = ((int)0x8FFA)        ,
        Float16Vec4Nv = ((int)0x8FFB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvHalfFloat : int
    {
        HalfFloatNv = ((int)0x140B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvLightMaxExponent : int
    {
        MaxShininessNv = ((int)0x8504)        ,
        MaxSpotExponentNv = ((int)0x8505)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvMultisampleCoverage : int
    {
        SamplesArb = ((int)0x80A9)        ,
        ColorSamplesNv = ((int)0x8E20)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvMultisampleFilterHint : int
    {
        MultisampleFilterHintNv = ((int)0x8534)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetOcclusionQuery
    /// </summary>
    public enum NvOcclusionQuery : int
    {
        PixelCounterBitsNv = ((int)0x8864)        ,
        CurrentOcclusionQueryIdNv = ((int)0x8865)        ,
        PixelCountNv = ((int)0x8866)        ,
        PixelCountAvailableNv = ((int)0x8867)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvPackedDepthStencil : int
    {
        DepthStencilNv = ((int)0x84F9)        ,
        UnsignedInt248Nv = ((int)0x84FA)        ,
    }

    /// <summary>
    /// Used in GL.NV.ProgramBufferParameters, GL.NV.ProgramBufferParametersI
    /// </summary>
    public enum NvParameterBufferObject : int
    {
        MaxProgramParameterBufferBindingsNv = ((int)0x8DA0)        ,
        MaxProgramParameterBufferSizeNv = ((int)0x8DA1)        ,
        VertexProgramParameterBufferNv = ((int)0x8DA2)        ,
        GeometryProgramParameterBufferNv = ((int)0x8DA3)        ,
        FragmentProgramParameterBufferNv = ((int)0x8DA4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvParameterBufferObject2 : int
    {
    }

    /// <summary>
    /// Used in GL.NV.CoverFillPathInstanced, GL.NV.CoverFillPath and 22 other functions
    /// </summary>
    public enum NvPathRendering : int
    {
        ClosePathNv = ((int)0x00)        ,
        FontXMinBoundsBitNv = ((int)0x00010000)        ,
        FontYMinBoundsBitNv = ((int)0x00020000)        ,
        FontXMaxBoundsBitNv = ((int)0x00040000)        ,
        FontYMaxBoundsBitNv = ((int)0x00080000)        ,
        FontUnitsPerEmBitNv = ((int)0x00100000)        ,
        FontAscenderBitNv = ((int)0x00200000)        ,
        FontDescenderBitNv = ((int)0x00400000)        ,
        FontHeightBitNv = ((int)0x00800000)        ,
        BoldBitNv = ((int)0x01)        ,
        GlyphWidthBitNv = ((int)0x01)        ,
        FontMaxAdvanceWidthBitNv = ((int)0x01000000)        ,
        GlyphHeightBitNv = ((int)0x02)        ,
        ItalicBitNv = ((int)0x02)        ,
        MoveToNv = ((int)0x02)        ,
        FontMaxAdvanceHeightBitNv = ((int)0x02000000)        ,
        RelativeMoveToNv = ((int)0x03)        ,
        GlyphHorizontalBearingXBitNv = ((int)0x04)        ,
        LineToNv = ((int)0x04)        ,
        FontUnderlinePositionBitNv = ((int)0x04000000)        ,
        RelativeLineToNv = ((int)0x05)        ,
        HorizontalLineToNv = ((int)0x06)        ,
        RelativeHorizontalLineToNv = ((int)0x07)        ,
        GlyphHorizontalBearingYBitNv = ((int)0x08)        ,
        VerticalLineToNv = ((int)0x08)        ,
        FontUnderlineThicknessBitNv = ((int)0x08000000)        ,
        RelativeVerticalLineToNv = ((int)0x09)        ,
        QuadraticCurveToNv = ((int)0x0A)        ,
        RelativeQuadraticCurveToNv = ((int)0x0B)        ,
        CubicCurveToNv = ((int)0x0C)        ,
        RelativeCubicCurveToNv = ((int)0x0D)        ,
        SmoothQuadraticCurveToNv = ((int)0x0E)        ,
        RelativeSmoothQuadraticCurveToNv = ((int)0x0F)        ,
        GlyphHorizontalBearingAdvanceBitNv = ((int)0x10)        ,
        SmoothCubicCurveToNv = ((int)0x10)        ,
        GlyphHasKerningBitNv = ((int)0x100)        ,
        FontHasKerningBitNv = ((int)0x10000000)        ,
        RelativeSmoothCubicCurveToNv = ((int)0x11)        ,
        SmallCcwArcToNv = ((int)0x12)        ,
        RelativeSmallCcwArcToNv = ((int)0x13)        ,
        SmallCwArcToNv = ((int)0x14)        ,
        RelativeSmallCwArcToNv = ((int)0x15)        ,
        LargeCcwArcToNv = ((int)0x16)        ,
        RelativeLargeCcwArcToNv = ((int)0x17)        ,
        LargeCwArcToNv = ((int)0x18)        ,
        RelativeLargeCwArcToNv = ((int)0x19)        ,
        GlyphVerticalBearingXBitNv = ((int)0x20)        ,
        GlyphVerticalBearingYBitNv = ((int)0x40)        ,
        GlyphVerticalBearingAdvanceBitNv = ((int)0x80)        ,
        PrimaryColorNv = ((int)0x852C)        ,
        SecondaryColorNv = ((int)0x852D)        ,
        PrimaryColor = ((int)0x8577)        ,
        PathFormatSvgNv = ((int)0x9070)        ,
        PathFormatPsNv = ((int)0x9071)        ,
        StandardFontNameNv = ((int)0x9072)        ,
        SystemFontNameNv = ((int)0x9073)        ,
        FileNameNv = ((int)0x9074)        ,
        PathStrokeWidthNv = ((int)0x9075)        ,
        PathEndCapsNv = ((int)0x9076)        ,
        PathInitialEndCapNv = ((int)0x9077)        ,
        PathTerminalEndCapNv = ((int)0x9078)        ,
        PathJoinStyleNv = ((int)0x9079)        ,
        PathMiterLimitNv = ((int)0x907A)        ,
        PathDashCapsNv = ((int)0x907B)        ,
        PathInitialDashCapNv = ((int)0x907C)        ,
        PathTerminalDashCapNv = ((int)0x907D)        ,
        PathDashOffsetNv = ((int)0x907E)        ,
        PathClientLengthNv = ((int)0x907F)        ,
        PathFillModeNv = ((int)0x9080)        ,
        PathFillMaskNv = ((int)0x9081)        ,
        PathFillCoverModeNv = ((int)0x9082)        ,
        PathStrokeCoverModeNv = ((int)0x9083)        ,
        PathStrokeMaskNv = ((int)0x9084)        ,
        CountUpNv = ((int)0x9088)        ,
        CountDownNv = ((int)0x9089)        ,
        PathObjectBoundingBoxNv = ((int)0x908A)        ,
        ConvexHullNv = ((int)0x908B)        ,
        BoundingBoxNv = ((int)0x908D)        ,
        TranslateXNv = ((int)0x908E)        ,
        TranslateYNv = ((int)0x908F)        ,
        Translate2DNv = ((int)0x9090)        ,
        Translate3DNv = ((int)0x9091)        ,
        Affine2DNv = ((int)0x9092)        ,
        Affine3DNv = ((int)0x9094)        ,
        TransposeAffine2DNv = ((int)0x9096)        ,
        TransposeAffine3DNv = ((int)0x9098)        ,
        Utf8Nv = ((int)0x909A)        ,
        Utf16Nv = ((int)0x909B)        ,
        BoundingBoxOfBoundingBoxesNv = ((int)0x909C)        ,
        PathCommandCountNv = ((int)0x909D)        ,
        PathCoordCountNv = ((int)0x909E)        ,
        PathDashArrayCountNv = ((int)0x909F)        ,
        PathComputedLengthNv = ((int)0x90A0)        ,
        PathFillBoundingBoxNv = ((int)0x90A1)        ,
        PathStrokeBoundingBoxNv = ((int)0x90A2)        ,
        SquareNv = ((int)0x90A3)        ,
        RoundNv = ((int)0x90A4)        ,
        TriangularNv = ((int)0x90A5)        ,
        BevelNv = ((int)0x90A6)        ,
        MiterRevertNv = ((int)0x90A7)        ,
        MiterTruncateNv = ((int)0x90A8)        ,
        SkipMissingGlyphNv = ((int)0x90A9)        ,
        UseMissingGlyphNv = ((int)0x90AA)        ,
        PathErrorPositionNv = ((int)0x90AB)        ,
        PathFogGenModeNv = ((int)0x90AC)        ,
        AccumAdjacentPairsNv = ((int)0x90AD)        ,
        AdjacentPairsNv = ((int)0x90AE)        ,
        FirstToRestNv = ((int)0x90AF)        ,
        PathGenModeNv = ((int)0x90B0)        ,
        PathGenCoeffNv = ((int)0x90B1)        ,
        PathGenColorFormatNv = ((int)0x90B2)        ,
        PathGenComponentsNv = ((int)0x90B3)        ,
        PathDashOffsetResetNv = ((int)0x90B4)        ,
        MoveToResetsNv = ((int)0x90B5)        ,
        MoveToContinuesNv = ((int)0x90B6)        ,
        PathStencilFuncNv = ((int)0x90B7)        ,
        PathStencilRefNv = ((int)0x90B8)        ,
        PathStencilValueMaskNv = ((int)0x90B9)        ,
        PathStencilDepthOffsetFactorNv = ((int)0x90BD)        ,
        PathStencilDepthOffsetUnitsNv = ((int)0x90BE)        ,
        PathCoverDepthFuncNv = ((int)0x90BF)        ,
        RestartPathNv = ((int)0xF0)        ,
        DupFirstCubicCurveToNv = ((int)0xF2)        ,
        DupLastCubicCurveToNv = ((int)0xF4)        ,
        RectNv = ((int)0xF6)        ,
        CircularCcwArcToNv = ((int)0xF8)        ,
        CircularCwArcToNv = ((int)0xFA)        ,
        CircularTangentArcToNv = ((int)0xFC)        ,
        ArcToNv = ((int)0xFE)        ,
        RelativeArcToNv = ((int)0xFF)        ,
    }

    /// <summary>
    /// Used in GL.NV.FlushPixelDataRange, GL.NV.PixelDataRange
    /// </summary>
    public enum NvPixelDataRange : int
    {
        WritePixelDataRangeNv = ((int)0x8878)        ,
        ReadPixelDataRangeNv = ((int)0x8879)        ,
        WritePixelDataRangeLengthNv = ((int)0x887A)        ,
        ReadPixelDataRangeLengthNv = ((int)0x887B)        ,
        WritePixelDataRangePointerNv = ((int)0x887C)        ,
        ReadPixelDataRangePointerNv = ((int)0x887D)        ,
    }

    /// <summary>
    /// Used in GL.NV.PointParameter
    /// </summary>
    public enum NvPointSprite : int
    {
        PointSpriteNv = ((int)0x8861)        ,
        CoordReplaceNv = ((int)0x8862)        ,
        PointSpriteRModeNv = ((int)0x8863)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetVideo, GL.NV.PresentFrameDualFill and 1 other function
    /// </summary>
    public enum NvPresentVideo : int
    {
        FrameNv = ((int)0x8E26)        ,
        FieldsNv = ((int)0x8E27)        ,
        CurrentTimeNv = ((int)0x8E28)        ,
        NumFillStreamsNv = ((int)0x8E29)        ,
        PresentTimeNv = ((int)0x8E2A)        ,
        PresentDurationNv = ((int)0x8E2B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvPrimitiveRestart : int
    {
        PrimitiveRestartNv = ((int)0x8558)        ,
        PrimitiveRestartIndexNv = ((int)0x8559)        ,
    }

    /// <summary>
    /// Used in GL.NV.CombinerInput, GL.NV.CombinerOutput and 5 other functions
    /// </summary>
    public enum NvRegisterCombiners : int
    {
        None = ((int)0)        ,
        Zero = ((int)0)        ,
        Fog = ((int)0x0B60)        ,
        Texture0Arb = ((int)0x84C0)        ,
        Texture1Arb = ((int)0x84C1)        ,
        RegisterCombinersNv = ((int)0x8522)        ,
        VariableANv = ((int)0x8523)        ,
        VariableBNv = ((int)0x8524)        ,
        VariableCNv = ((int)0x8525)        ,
        VariableDNv = ((int)0x8526)        ,
        VariableENv = ((int)0x8527)        ,
        VariableFNv = ((int)0x8528)        ,
        VariableGNv = ((int)0x8529)        ,
        ConstantColor0Nv = ((int)0x852A)        ,
        ConstantColor1Nv = ((int)0x852B)        ,
        PrimaryColorNv = ((int)0x852C)        ,
        SecondaryColorNv = ((int)0x852D)        ,
        Spare0Nv = ((int)0x852E)        ,
        Spare1Nv = ((int)0x852F)        ,
        DiscardNv = ((int)0x8530)        ,
        ETimesFNv = ((int)0x8531)        ,
        Spare0PlusSecondaryColorNv = ((int)0x8532)        ,
        UnsignedIdentityNv = ((int)0x8536)        ,
        UnsignedInvertNv = ((int)0x8537)        ,
        ExpandNormalNv = ((int)0x8538)        ,
        ExpandNegateNv = ((int)0x8539)        ,
        HalfBiasNormalNv = ((int)0x853A)        ,
        HalfBiasNegateNv = ((int)0x853B)        ,
        SignedIdentityNv = ((int)0x853C)        ,
        SignedNegateNv = ((int)0x853D)        ,
        ScaleByTwoNv = ((int)0x853E)        ,
        ScaleByFourNv = ((int)0x853F)        ,
        ScaleByOneHalfNv = ((int)0x8540)        ,
        BiasByNegativeOneHalfNv = ((int)0x8541)        ,
        CombinerInputNv = ((int)0x8542)        ,
        CombinerMappingNv = ((int)0x8543)        ,
        CombinerComponentUsageNv = ((int)0x8544)        ,
        CombinerAbDotProductNv = ((int)0x8545)        ,
        CombinerCdDotProductNv = ((int)0x8546)        ,
        CombinerMuxSumNv = ((int)0x8547)        ,
        CombinerScaleNv = ((int)0x8548)        ,
        CombinerBiasNv = ((int)0x8549)        ,
        CombinerAbOutputNv = ((int)0x854A)        ,
        CombinerCdOutputNv = ((int)0x854B)        ,
        CombinerSumOutputNv = ((int)0x854C)        ,
        MaxGeneralCombinersNv = ((int)0x854D)        ,
        NumGeneralCombinersNv = ((int)0x854E)        ,
        ColorSumClampNv = ((int)0x854F)        ,
        Combiner0Nv = ((int)0x8550)        ,
        Combiner1Nv = ((int)0x8551)        ,
        Combiner2Nv = ((int)0x8552)        ,
        Combiner3Nv = ((int)0x8553)        ,
        Combiner4Nv = ((int)0x8554)        ,
        Combiner5Nv = ((int)0x8555)        ,
        Combiner6Nv = ((int)0x8556)        ,
        Combiner7Nv = ((int)0x8557)        ,
    }

    /// <summary>
    /// Used in GL.NV.CombinerStageParameter, GL.NV.GetCombinerStageParameter
    /// </summary>
    public enum NvRegisterCombiners2 : int
    {
        PerStageConstantsNv = ((int)0x8535)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShaderAtomicCounters : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShaderAtomicFloat : int
    {
    }

    /// <summary>
    /// Used in GL.NV.GetBufferParameter, GL.NV.GetInteger and 5 other functions
    /// </summary>
    public enum NvShaderBufferLoad : int
    {
        BufferGpuAddressNv = ((int)0x8F1D)        ,
        GpuAddressNv = ((int)0x8F34)        ,
        MaxShaderBufferAddressNv = ((int)0x8F35)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShaderBufferStore : int
    {
        ShaderGlobalAccessBarrierBitNv = ((int)0x00000010)        ,
        WriteOnly = ((int)0x88B9)        ,
        ReadWrite = ((int)0x88BA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvShaderStorageBufferObject : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTessellationProgram5 : int
    {
        MaxProgramPatchAttribsNv = ((int)0x86D8)        ,
        TessControlProgramNv = ((int)0x891E)        ,
        TessEvaluationProgramNv = ((int)0x891F)        ,
        TessControlProgramParameterBufferNv = ((int)0x8C74)        ,
        TessEvaluationProgramParameterBufferNv = ((int)0x8C75)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTexgenEmboss : int
    {
        EmbossLightNv = ((int)0x855D)        ,
        EmbossConstantNv = ((int)0x855E)        ,
        EmbossMapNv = ((int)0x855F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTexgenReflection : int
    {
        NormalMapNv = ((int)0x8511)        ,
        ReflectionMapNv = ((int)0x8512)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureBarrier : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureCompressionVtc : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureEnvCombine4 : int
    {
        Combine4Nv = ((int)0x8503)        ,
        Source3RgbNv = ((int)0x8583)        ,
        Source3AlphaNv = ((int)0x858B)        ,
        Operand3RgbNv = ((int)0x8593)        ,
        Operand3AlphaNv = ((int)0x859B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureExpandNormal : int
    {
        TextureUnsignedRemapModeNv = ((int)0x888F)        ,
    }

    /// <summary>
    /// Used in GL.NV.TexImage2DMultisampleCoverage, GL.NV.TexImage3DMultisampleCoverage and 4 other functions
    /// </summary>
    public enum NvTextureMultisample : int
    {
        TextureCoverageSamplesNv = ((int)0x9045)        ,
        TextureColorSamplesNv = ((int)0x9046)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureRectangle : int
    {
        TextureRectangleNv = ((int)0x84F5)        ,
        TextureBindingRectangleNv = ((int)0x84F6)        ,
        ProxyTextureRectangleNv = ((int)0x84F7)        ,
        MaxRectangleTextureSizeNv = ((int)0x84F8)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureShader : int
    {
        OffsetTextureRectangleNv = ((int)0x864C)        ,
        OffsetTextureRectangleScaleNv = ((int)0x864D)        ,
        DotProductTextureRectangleNv = ((int)0x864E)        ,
        RgbaUnsignedDotProductMappingNv = ((int)0x86D9)        ,
        UnsignedIntS8S888Nv = ((int)0x86DA)        ,
        UnsignedInt88S8S8RevNv = ((int)0x86DB)        ,
        DsdtMagIntensityNv = ((int)0x86DC)        ,
        ShaderConsistentNv = ((int)0x86DD)        ,
        TextureShaderNv = ((int)0x86DE)        ,
        ShaderOperationNv = ((int)0x86DF)        ,
        CullModesNv = ((int)0x86E0)        ,
        OffsetTexture2DMatrixNv = ((int)0x86E1)        ,
        OffsetTextureMatrixNv = ((int)0x86E1)        ,
        OffsetTexture2DScaleNv = ((int)0x86E2)        ,
        OffsetTextureScaleNv = ((int)0x86E2)        ,
        OffsetTexture2DBiasNv = ((int)0x86E3)        ,
        OffsetTextureBiasNv = ((int)0x86E3)        ,
        PreviousTextureInputNv = ((int)0x86E4)        ,
        ConstEyeNv = ((int)0x86E5)        ,
        PassThroughNv = ((int)0x86E6)        ,
        CullFragmentNv = ((int)0x86E7)        ,
        OffsetTexture2DNv = ((int)0x86E8)        ,
        DependentArTexture2DNv = ((int)0x86E9)        ,
        DependentGbTexture2DNv = ((int)0x86EA)        ,
        DotProductNv = ((int)0x86EC)        ,
        DotProductDepthReplaceNv = ((int)0x86ED)        ,
        DotProductTexture2DNv = ((int)0x86EE)        ,
        DotProductTextureCubeMapNv = ((int)0x86F0)        ,
        DotProductDiffuseCubeMapNv = ((int)0x86F1)        ,
        DotProductReflectCubeMapNv = ((int)0x86F2)        ,
        DotProductConstEyeReflectCubeMapNv = ((int)0x86F3)        ,
        HiloNv = ((int)0x86F4)        ,
        DsdtNv = ((int)0x86F5)        ,
        DsdtMagNv = ((int)0x86F6)        ,
        DsdtMagVibNv = ((int)0x86F7)        ,
        Hilo16Nv = ((int)0x86F8)        ,
        SignedHiloNv = ((int)0x86F9)        ,
        SignedHilo16Nv = ((int)0x86FA)        ,
        SignedRgbaNv = ((int)0x86FB)        ,
        SignedRgba8Nv = ((int)0x86FC)        ,
        SignedRgbNv = ((int)0x86FE)        ,
        SignedRgb8Nv = ((int)0x86FF)        ,
        SignedLuminanceNv = ((int)0x8701)        ,
        SignedLuminance8Nv = ((int)0x8702)        ,
        SignedLuminanceAlphaNv = ((int)0x8703)        ,
        SignedLuminance8Alpha8Nv = ((int)0x8704)        ,
        SignedAlphaNv = ((int)0x8705)        ,
        SignedAlpha8Nv = ((int)0x8706)        ,
        SignedIntensityNv = ((int)0x8707)        ,
        SignedIntensity8Nv = ((int)0x8708)        ,
        Dsdt8Nv = ((int)0x8709)        ,
        Dsdt8Mag8Nv = ((int)0x870A)        ,
        Dsdt8Mag8Intensity8Nv = ((int)0x870B)        ,
        SignedRgbUnsignedAlphaNv = ((int)0x870C)        ,
        SignedRgb8UnsignedAlpha8Nv = ((int)0x870D)        ,
        HiScaleNv = ((int)0x870E)        ,
        LoScaleNv = ((int)0x870F)        ,
        DsScaleNv = ((int)0x8710)        ,
        DtScaleNv = ((int)0x8711)        ,
        MagnitudeScaleNv = ((int)0x8712)        ,
        VibranceScaleNv = ((int)0x8713)        ,
        HiBiasNv = ((int)0x8714)        ,
        LoBiasNv = ((int)0x8715)        ,
        DsBiasNv = ((int)0x8716)        ,
        DtBiasNv = ((int)0x8717)        ,
        MagnitudeBiasNv = ((int)0x8718)        ,
        VibranceBiasNv = ((int)0x8719)        ,
        TextureBorderValuesNv = ((int)0x871A)        ,
        TextureHiSizeNv = ((int)0x871B)        ,
        TextureLoSizeNv = ((int)0x871C)        ,
        TextureDsSizeNv = ((int)0x871D)        ,
        TextureDtSizeNv = ((int)0x871E)        ,
        TextureMagSizeNv = ((int)0x871F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureShader2 : int
    {
        DotProductTexture3DNv = ((int)0x86EF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvTextureShader3 : int
    {
        OffsetProjectiveTexture2DNv = ((int)0x8850)        ,
        OffsetProjectiveTexture2DScaleNv = ((int)0x8851)        ,
        OffsetProjectiveTextureRectangleNv = ((int)0x8852)        ,
        OffsetProjectiveTextureRectangleScaleNv = ((int)0x8853)        ,
        OffsetHiloTexture2DNv = ((int)0x8854)        ,
        OffsetHiloTextureRectangleNv = ((int)0x8855)        ,
        OffsetHiloProjectiveTexture2DNv = ((int)0x8856)        ,
        OffsetHiloProjectiveTextureRectangleNv = ((int)0x8857)        ,
        DependentHiloTexture2DNv = ((int)0x8858)        ,
        DependentRgbTexture3DNv = ((int)0x8859)        ,
        DependentRgbTextureCubeMapNv = ((int)0x885A)        ,
        DotProductPassThroughNv = ((int)0x885B)        ,
        DotProductTexture1DNv = ((int)0x885C)        ,
        DotProductAffineDepthReplaceNv = ((int)0x885D)        ,
        Hilo8Nv = ((int)0x885E)        ,
        SignedHilo8Nv = ((int)0x885F)        ,
        ForceBlueToOneNv = ((int)0x8860)        ,
    }

    /// <summary>
    /// Used in GL.NV.BeginTransformFeedback, GL.NV.BindBufferBase and 6 other functions
    /// </summary>
    public enum NvTransformFeedback : int
    {
        BackPrimaryColorNv = ((int)0x8C77)        ,
        BackSecondaryColorNv = ((int)0x8C78)        ,
        TextureCoordNv = ((int)0x8C79)        ,
        ClipDistanceNv = ((int)0x8C7A)        ,
        VertexIdNv = ((int)0x8C7B)        ,
        PrimitiveIdNv = ((int)0x8C7C)        ,
        GenericAttribNv = ((int)0x8C7D)        ,
        TransformFeedbackAttribsNv = ((int)0x8C7E)        ,
        TransformFeedbackBufferModeNv = ((int)0x8C7F)        ,
        MaxTransformFeedbackSeparateComponentsNv = ((int)0x8C80)        ,
        ActiveVaryingsNv = ((int)0x8C81)        ,
        ActiveVaryingMaxLengthNv = ((int)0x8C82)        ,
        TransformFeedbackVaryingsNv = ((int)0x8C83)        ,
        TransformFeedbackBufferStartNv = ((int)0x8C84)        ,
        TransformFeedbackBufferSizeNv = ((int)0x8C85)        ,
        TransformFeedbackRecordNv = ((int)0x8C86)        ,
        PrimitivesGeneratedNv = ((int)0x8C87)        ,
        TransformFeedbackPrimitivesWrittenNv = ((int)0x8C88)        ,
        RasterizerDiscardNv = ((int)0x8C89)        ,
        MaxTransformFeedbackInterleavedComponentsNv = ((int)0x8C8A)        ,
        MaxTransformFeedbackSeparateAttribsNv = ((int)0x8C8B)        ,
        InterleavedAttribsNv = ((int)0x8C8C)        ,
        SeparateAttribsNv = ((int)0x8C8D)        ,
        TransformFeedbackBufferNv = ((int)0x8C8E)        ,
        TransformFeedbackBufferBindingNv = ((int)0x8C8F)        ,
        LayerNv = ((int)0x8DAA)        ,
        NextBufferNv = ((int)-2)        ,
        SkipComponents4Nv = ((int)-3)        ,
        SkipComponents3Nv = ((int)-4)        ,
        SkipComponents2Nv = ((int)-5)        ,
        SkipComponents1Nv = ((int)-6)        ,
    }

    /// <summary>
    /// Used in GL.NV.BindTransformFeedback, GL.NV.DrawTransformFeedback
    /// </summary>
    public enum NvTransformFeedback2 : int
    {
        TransformFeedbackNv = ((int)0x8E22)        ,
        TransformFeedbackBufferPausedNv = ((int)0x8E23)        ,
        TransformFeedbackBufferActiveNv = ((int)0x8E24)        ,
        TransformFeedbackBindingNv = ((int)0x8E25)        ,
    }

    /// <summary>
    /// Used in GL.NV.VDPAUGetSurface, GL.NV.VDPAURegisterOutputSurface and 2 other functions
    /// </summary>
    public enum NvVdpauInterop : int
    {
        SurfaceStateNv = ((int)0x86EB)        ,
        SurfaceRegisteredNv = ((int)0x86FD)        ,
        SurfaceMappedNv = ((int)0x8700)        ,
        WriteDiscardNv = ((int)0x88BE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexArrayRange : int
    {
        VertexArrayRangeNv = ((int)0x851D)        ,
        VertexArrayRangeLengthNv = ((int)0x851E)        ,
        VertexArrayRangeValidNv = ((int)0x851F)        ,
        MaxVertexArrayRangeElementNv = ((int)0x8520)        ,
        VertexArrayRangePointerNv = ((int)0x8521)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexArrayRange2 : int
    {
        VertexArrayRangeWithoutFlushNv = ((int)0x8533)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetVertexAttrib, GL.NV.GetVertexAttribL and 1 other function
    /// </summary>
    public enum NvVertexAttribInteger64bit : int
    {
        Int64Nv = ((int)0x140E)        ,
        UnsignedInt64Nv = ((int)0x140F)        ,
    }

    /// <summary>
    /// Used in GL.NV.BufferAddressRange, GL.NV.ColorFormat and 9 other functions
    /// </summary>
    public enum NvVertexBufferUnifiedMemory : int
    {
        VertexAttribArrayUnifiedNv = ((int)0x8F1E)        ,
        ElementArrayUnifiedNv = ((int)0x8F1F)        ,
        VertexAttribArrayAddressNv = ((int)0x8F20)        ,
        VertexArrayAddressNv = ((int)0x8F21)        ,
        NormalArrayAddressNv = ((int)0x8F22)        ,
        ColorArrayAddressNv = ((int)0x8F23)        ,
        IndexArrayAddressNv = ((int)0x8F24)        ,
        TextureCoordArrayAddressNv = ((int)0x8F25)        ,
        EdgeFlagArrayAddressNv = ((int)0x8F26)        ,
        SecondaryColorArrayAddressNv = ((int)0x8F27)        ,
        FogCoordArrayAddressNv = ((int)0x8F28)        ,
        ElementArrayAddressNv = ((int)0x8F29)        ,
        VertexAttribArrayLengthNv = ((int)0x8F2A)        ,
        VertexArrayLengthNv = ((int)0x8F2B)        ,
        NormalArrayLengthNv = ((int)0x8F2C)        ,
        ColorArrayLengthNv = ((int)0x8F2D)        ,
        IndexArrayLengthNv = ((int)0x8F2E)        ,
        TextureCoordArrayLengthNv = ((int)0x8F2F)        ,
        EdgeFlagArrayLengthNv = ((int)0x8F30)        ,
        SecondaryColorArrayLengthNv = ((int)0x8F31)        ,
        FogCoordArrayLengthNv = ((int)0x8F32)        ,
        ElementArrayLengthNv = ((int)0x8F33)        ,
        DrawIndirectUnifiedNv = ((int)0x8F40)        ,
        DrawIndirectAddressNv = ((int)0x8F41)        ,
        DrawIndirectLengthNv = ((int)0x8F42)        ,
    }

    /// <summary>
    /// Used in GL.NV.GetProgram, GL.NV.GetProgramString and 3 other functions
    /// </summary>
    public enum NvVertexProgram : int
    {
        VertexProgramNv = ((int)0x8620)        ,
        VertexStateProgramNv = ((int)0x8621)        ,
        AttribArraySizeNv = ((int)0x8623)        ,
        AttribArrayStrideNv = ((int)0x8624)        ,
        AttribArrayTypeNv = ((int)0x8625)        ,
        CurrentAttribNv = ((int)0x8626)        ,
        ProgramLengthNv = ((int)0x8627)        ,
        ProgramStringNv = ((int)0x8628)        ,
        ModelviewProjectionNv = ((int)0x8629)        ,
        IdentityNv = ((int)0x862A)        ,
        InverseNv = ((int)0x862B)        ,
        TransposeNv = ((int)0x862C)        ,
        InverseTransposeNv = ((int)0x862D)        ,
        MaxTrackMatrixStackDepthNv = ((int)0x862E)        ,
        MaxTrackMatricesNv = ((int)0x862F)        ,
        Matrix0Nv = ((int)0x8630)        ,
        Matrix1Nv = ((int)0x8631)        ,
        Matrix2Nv = ((int)0x8632)        ,
        Matrix3Nv = ((int)0x8633)        ,
        Matrix4Nv = ((int)0x8634)        ,
        Matrix5Nv = ((int)0x8635)        ,
        Matrix6Nv = ((int)0x8636)        ,
        Matrix7Nv = ((int)0x8637)        ,
        CurrentMatrixStackDepthNv = ((int)0x8640)        ,
        CurrentMatrixNv = ((int)0x8641)        ,
        VertexProgramPointSizeNv = ((int)0x8642)        ,
        VertexProgramTwoSideNv = ((int)0x8643)        ,
        ProgramParameterNv = ((int)0x8644)        ,
        AttribArrayPointerNv = ((int)0x8645)        ,
        ProgramTargetNv = ((int)0x8646)        ,
        ProgramResidentNv = ((int)0x8647)        ,
        TrackMatrixNv = ((int)0x8648)        ,
        TrackMatrixTransformNv = ((int)0x8649)        ,
        VertexProgramBindingNv = ((int)0x864A)        ,
        ProgramErrorPositionNv = ((int)0x864B)        ,
        VertexAttribArray0Nv = ((int)0x8650)        ,
        VertexAttribArray1Nv = ((int)0x8651)        ,
        VertexAttribArray2Nv = ((int)0x8652)        ,
        VertexAttribArray3Nv = ((int)0x8653)        ,
        VertexAttribArray4Nv = ((int)0x8654)        ,
        VertexAttribArray5Nv = ((int)0x8655)        ,
        VertexAttribArray6Nv = ((int)0x8656)        ,
        VertexAttribArray7Nv = ((int)0x8657)        ,
        VertexAttribArray8Nv = ((int)0x8658)        ,
        VertexAttribArray9Nv = ((int)0x8659)        ,
        VertexAttribArray10Nv = ((int)0x865A)        ,
        VertexAttribArray11Nv = ((int)0x865B)        ,
        VertexAttribArray12Nv = ((int)0x865C)        ,
        VertexAttribArray13Nv = ((int)0x865D)        ,
        VertexAttribArray14Nv = ((int)0x865E)        ,
        VertexAttribArray15Nv = ((int)0x865F)        ,
        Map1VertexAttrib04Nv = ((int)0x8660)        ,
        Map1VertexAttrib14Nv = ((int)0x8661)        ,
        Map1VertexAttrib24Nv = ((int)0x8662)        ,
        Map1VertexAttrib34Nv = ((int)0x8663)        ,
        Map1VertexAttrib44Nv = ((int)0x8664)        ,
        Map1VertexAttrib54Nv = ((int)0x8665)        ,
        Map1VertexAttrib64Nv = ((int)0x8666)        ,
        Map1VertexAttrib74Nv = ((int)0x8667)        ,
        Map1VertexAttrib84Nv = ((int)0x8668)        ,
        Map1VertexAttrib94Nv = ((int)0x8669)        ,
        Map1VertexAttrib104Nv = ((int)0x866A)        ,
        Map1VertexAttrib114Nv = ((int)0x866B)        ,
        Map1VertexAttrib124Nv = ((int)0x866C)        ,
        Map1VertexAttrib134Nv = ((int)0x866D)        ,
        Map1VertexAttrib144Nv = ((int)0x866E)        ,
        Map1VertexAttrib154Nv = ((int)0x866F)        ,
        Map2VertexAttrib04Nv = ((int)0x8670)        ,
        Map2VertexAttrib14Nv = ((int)0x8671)        ,
        Map2VertexAttrib24Nv = ((int)0x8672)        ,
        Map2VertexAttrib34Nv = ((int)0x8673)        ,
        Map2VertexAttrib44Nv = ((int)0x8674)        ,
        Map2VertexAttrib54Nv = ((int)0x8675)        ,
        Map2VertexAttrib64Nv = ((int)0x8676)        ,
        Map2VertexAttrib74Nv = ((int)0x8677)        ,
        Map2VertexAttrib84Nv = ((int)0x8678)        ,
        Map2VertexAttrib94Nv = ((int)0x8679)        ,
        Map2VertexAttrib104Nv = ((int)0x867A)        ,
        Map2VertexAttrib114Nv = ((int)0x867B)        ,
        Map2VertexAttrib124Nv = ((int)0x867C)        ,
        Map2VertexAttrib134Nv = ((int)0x867D)        ,
        Map2VertexAttrib144Nv = ((int)0x867E)        ,
        Map2VertexAttrib154Nv = ((int)0x867F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexProgram11 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexProgram2 : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexProgram2Option : int
    {
        MaxProgramExecInstructionsNv = ((int)0x88F4)        ,
        MaxProgramCallDepthNv = ((int)0x88F5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvVertexProgram3 : int
    {
        MaxVertexTextureImageUnitsArb = ((int)0x8B4C)        ,
    }

    /// <summary>
    /// Used in GL.Ext.GetVertexAttribI, GL.Ext.VertexAttribIPointer
    /// </summary>
    public enum NvVertexProgram4 : int
    {
        VertexAttribArrayIntegerNv = ((int)0x88FD)        ,
    }

    /// <summary>
    /// Used in GL.NV.BindVideoCaptureStreamBuffer, GL.NV.BindVideoCaptureStreamTexture and 3 other functions
    /// </summary>
    public enum NvVideoCapture : int
    {
        VideoBufferNv = ((int)0x9020)        ,
        VideoBufferBindingNv = ((int)0x9021)        ,
        FieldUpperNv = ((int)0x9022)        ,
        FieldLowerNv = ((int)0x9023)        ,
        NumVideoCaptureStreamsNv = ((int)0x9024)        ,
        NextVideoCaptureBufferStatusNv = ((int)0x9025)        ,
        VideoCaptureTo422SupportedNv = ((int)0x9026)        ,
        LastVideoCaptureStatusNv = ((int)0x9027)        ,
        VideoBufferPitchNv = ((int)0x9028)        ,
        VideoColorConversionMatrixNv = ((int)0x9029)        ,
        VideoColorConversionMaxNv = ((int)0x902A)        ,
        VideoColorConversionMinNv = ((int)0x902B)        ,
        VideoColorConversionOffsetNv = ((int)0x902C)        ,
        VideoBufferInternalFormatNv = ((int)0x902D)        ,
        PartialSuccessNv = ((int)0x902E)        ,
        SuccessNv = ((int)0x902F)        ,
        FailureNv = ((int)0x9030)        ,
        Ycbycr8422Nv = ((int)0x9031)        ,
        Ycbaycr8A4224Nv = ((int)0x9032)        ,
        Z6y10z6cb10z6y10z6cr10422Nv = ((int)0x9033)        ,
        Z6y10z6cb10z6A10z6y10z6cr10z6A104224Nv = ((int)0x9034)        ,
        Z4y12z4cb12z4y12z4cr12422Nv = ((int)0x9035)        ,
        Z4y12z4cb12z4A12z4y12z4cr12z4A124224Nv = ((int)0x9036)        ,
        Z4y12z4cb12z4cr12444Nv = ((int)0x9037)        ,
        VideoCaptureFrameWidthNv = ((int)0x9038)        ,
        VideoCaptureFrameHeightNv = ((int)0x9039)        ,
        VideoCaptureFieldUpperHeightNv = ((int)0x903A)        ,
        VideoCaptureFieldLowerHeightNv = ((int)0x903B)        ,
        VideoCaptureSurfaceOriginNv = ((int)0x903C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvxConditionalRender : int
    {
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
    /// Used in GL.Amd.QueryObjectParameter
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
    /// Used in GL.Oes.MultiTexCoord1, GL.Oes.MultiTexCoord2 and 2 other functions
    /// </summary>
    public enum OesByteCoordinates : int
    {
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
    /// Used in GL.GetPixelMapx, GL.PixelMapx and 32 other functions
    /// </summary>
    public enum OesFixedPoint : int
    {
        FixedOes = ((int)0x140C)        ,
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
    public enum OesReadFormat : int
    {
        ImplementationColorReadTypeOes = ((int)0x8B9A)        ,
        ImplementationColorReadFormatOes = ((int)0x8B9B)        ,
    }

    /// <summary>
    /// Used in GL.Oes.ClipPlane, GL.Oes.GetClipPlane
    /// </summary>
    public enum OesSinglePrecision : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OmlInterlace : int
    {
        InterlaceOml = ((int)0x8980)        ,
        InterlaceReadOml = ((int)0x8981)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OmlResample : int
    {
        PackResampleOml = ((int)0x8984)        ,
        UnpackResampleOml = ((int)0x8985)        ,
        ResampleReplicateOml = ((int)0x8986)        ,
        ResampleZeroFillOml = ((int)0x8987)        ,
        ResampleAverageOml = ((int)0x8988)        ,
        ResampleDecimateOml = ((int)0x8989)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OmlSubsample : int
    {
        FormatSubsample2424Oml = ((int)0x8982)        ,
        FormatSubsample244244Oml = ((int)0x8983)        ,
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
    /// Used in GL.Pgi.Hint
    /// </summary>
    public enum PgiMiscHints : int
    {
        PreferDoublebufferHintPgi = ((int)0x1A1F8)        ,
        ConserveMemoryHintPgi = ((int)0x1A1FD)        ,
        ReclaimMemoryHintPgi = ((int)0x1A1FE)        ,
        NativeGraphicsHandlePgi = ((int)0x1A202)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PgiVertexHints : int
    {
        Vertex23BitPgi = ((int)0x00000004)        ,
        Vertex4BitPgi = ((int)0x00000008)        ,
        Color3BitPgi = ((int)0x00010000)        ,
        Color4BitPgi = ((int)0x00020000)        ,
        EdgeflagBitPgi = ((int)0x00040000)        ,
        IndexBitPgi = ((int)0x00080000)        ,
        MatAmbientBitPgi = ((int)0x00100000)        ,
        MatAmbientAndDiffuseBitPgi = ((int)0x00200000)        ,
        MatDiffuseBitPgi = ((int)0x00400000)        ,
        MatEmissionBitPgi = ((int)0x00800000)        ,
        MatColorIndexesBitPgi = ((int)0x01000000)        ,
        MatShininessBitPgi = ((int)0x02000000)        ,
        MatSpecularBitPgi = ((int)0x04000000)        ,
        NormalBitPgi = ((int)0x08000000)        ,
        Texcoord1BitPgi = ((int)0x10000000)        ,
        VertexDataHintPgi = ((int)0x1A22A)        ,
        VertexConsistentHintPgi = ((int)0x1A22B)        ,
        MaterialSideHintPgi = ((int)0x1A22C)        ,
        MaxVertexHintPgi = ((int)0x1A22D)        ,
        Texcoord2BitPgi = ((int)0x20000000)        ,
        Texcoord3BitPgi = ((int)0x40000000)        ,
        Texcoord4BitPgi = unchecked((int)0x80000000)        ,
    }

    /// <summary>
    /// Used in GL.CopyPixels
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
    /// Used in GL.Arb.CompressedTexSubImage1D, GL.Arb.CompressedTexSubImage2D and 67 other functions
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
    /// Used in GL.Arb.CompressedTexImage1D, GL.Arb.CompressedTexImage2D and 41 other functions
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
    /// Used in GL.GetPixelMap, GL.PixelMap
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
    /// Used in GL.Sgis.GetPixelTexGenParameter, GL.Sgis.PixelTexGenParameter
    /// </summary>
    public enum PixelTexGenParameterNameSgis : int
    {
        PixelFragmentRgbSourceSgis = ((int)0x8354)        ,
        PixelFragmentAlphaSourceSgis = ((int)0x8355)        ,
    }

    /// <summary>
    /// Used in GL.PixelTransfer
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
    /// Used in GL.ClearTexImage, GL.ClearTexSubImage and 53 other functions
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
    /// Used in GL.Apple.DrawElementArray, GL.Apple.DrawRangeElementArray and 38 other functions
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
    /// Used in GL.GetProgram
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
    /// Used in GL.GetProgramResource, GL.Ext.GetNamedProgram
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
    /// Used in GL.ReadBuffer, GL.Ext.FramebufferReadBuffer
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
    /// Used in GL.GetRenderbufferParameter, GL.Ext.GetNamedRenderbufferParameter and 1 other function
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
    /// Used in GL.RenderbufferStorage, GL.RenderbufferStorageMultisample and 2 other functions
    /// </summary>
    public enum RenderbufferStorage : int
    {
        R3G3B2 = ((int)0x2A10)        ,
        Alpha4 = ((int)0x803B)        ,
        Alpha8 = ((int)0x803C)        ,
        Alpha12 = ((int)0x803D)        ,
        Alpha16 = ((int)0x803E)        ,
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
    /// Used in GL.BindRenderbuffer, GL.FramebufferRenderbuffer and 10 other functions
    /// </summary>
    public enum RenderbufferTarget : int
    {
        Renderbuffer = ((int)0x8D41)        ,
        RenderbufferExt = ((int)0x8D41)        ,
    }

    /// <summary>
    /// Used in GL.RenderMode
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
    public enum RendScreenCoordinates : int
    {
        ScreenCoordinatesRend = ((int)0x8490)        ,
        InvertedScreenWRend = ((int)0x8491)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum S3S3tc : int
    {
        RgbS3tc = ((int)0x83A0)        ,
        Rgb4S3tc = ((int)0x83A1)        ,
        RgbaS3tc = ((int)0x83A2)        ,
        Rgba4S3tc = ((int)0x83A3)        ,
        RgbaDxt5S3tc = ((int)0x83A4)        ,
        Rgba4Dxt5S3tc = ((int)0x83A5)        ,
    }

    /// <summary>
    /// Used in GL.Sgis.SamplePattern
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
    /// Used in GL.Ext.GetSeparableFilter, GL.Ext.SeparableFilter2D
    /// </summary>
    public enum SeparableTargetExt : int
    {
        Separable2D = ((int)0x8012)        ,
        Separable2DExt = ((int)0x8012)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgiColorMatrix : int
    {
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
    }

    /// <summary>
    /// Used in GL.Sgi.ColorTableParameter, GL.Sgi.ColorTable and 3 other functions
    /// </summary>
    public enum SgiColorTable : int
    {
        ColorTableSgi = ((int)0x80D0)        ,
        PostConvolutionColorTableSgi = ((int)0x80D1)        ,
        PostColorMatrixColorTableSgi = ((int)0x80D2)        ,
        ProxyColorTableSgi = ((int)0x80D3)        ,
        ProxyPostConvolutionColorTableSgi = ((int)0x80D4)        ,
        ProxyPostColorMatrixColorTableSgi = ((int)0x80D5)        ,
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
    public enum SgisDetailTexture : int
    {
        DetailTexture2DSgis = ((int)0x8095)        ,
        DetailTexture2DBindingSgis = ((int)0x8096)        ,
        LinearDetailSgis = ((int)0x8097)        ,
        LinearDetailAlphaSgis = ((int)0x8098)        ,
        LinearDetailColorSgis = ((int)0x8099)        ,
        DetailTextureLevelSgis = ((int)0x809A)        ,
        DetailTextureModeSgis = ((int)0x809B)        ,
        DetailTextureFuncPointsSgis = ((int)0x809C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisFogFunction : int
    {
        FogFuncSgis = ((int)0x812A)        ,
        FogFuncPointsSgis = ((int)0x812B)        ,
        MaxFogFuncPointsSgis = ((int)0x812C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisGenerateMipmap : int
    {
        GenerateMipmapSgis = ((int)0x8191)        ,
        GenerateMipmapHintSgis = ((int)0x8192)        ,
    }

    /// <summary>
    /// Used in GL.Sgis.SamplePattern
    /// </summary>
    public enum SgisMultisample : int
    {
        MultisampleSgis = ((int)0x809D)        ,
        SampleAlphaToMaskSgis = ((int)0x809E)        ,
        SampleAlphaToOneSgis = ((int)0x809F)        ,
        SampleMaskSgis = ((int)0x80A0)        ,
        Gl1PassSgis = ((int)0x80A1)        ,
        Gl2Pass0Sgis = ((int)0x80A2)        ,
        Gl2Pass1Sgis = ((int)0x80A3)        ,
        Gl4Pass0Sgis = ((int)0x80A4)        ,
        Gl4Pass1Sgis = ((int)0x80A5)        ,
        Gl4Pass2Sgis = ((int)0x80A6)        ,
        Gl4Pass3Sgis = ((int)0x80A7)        ,
        SampleBuffersSgis = ((int)0x80A8)        ,
        SamplesSgis = ((int)0x80A9)        ,
        SampleMaskValueSgis = ((int)0x80AA)        ,
        SampleMaskInvertSgis = ((int)0x80AB)        ,
        SamplePatternSgis = ((int)0x80AC)        ,
    }

    /// <summary>
    /// Used in GL.Sgis.GetPixelTexGenParameter, GL.Sgis.PixelTexGenParameter
    /// </summary>
    public enum SgisPixelTexture : int
    {
        PixelTextureSgis = ((int)0x8353)        ,
        PixelFragmentRgbSourceSgis = ((int)0x8354)        ,
        PixelFragmentAlphaSourceSgis = ((int)0x8355)        ,
        PixelGroupColorSgis = ((int)0x8356)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisPointLineTexgen : int
    {
        EyeDistanceToPointSgis = ((int)0x81F0)        ,
        ObjectDistanceToPointSgis = ((int)0x81F1)        ,
        EyeDistanceToLineSgis = ((int)0x81F2)        ,
        ObjectDistanceToLineSgis = ((int)0x81F3)        ,
        EyePointSgis = ((int)0x81F4)        ,
        ObjectPointSgis = ((int)0x81F5)        ,
        EyeLineSgis = ((int)0x81F6)        ,
        ObjectLineSgis = ((int)0x81F7)        ,
    }

    /// <summary>
    /// Used in GL.Sgis.PointParameter
    /// </summary>
    public enum SgisPointParameters : int
    {
        PointSizeMinSgis = ((int)0x8126)        ,
        PointSizeMaxSgis = ((int)0x8127)        ,
        PointFadeThresholdSizeSgis = ((int)0x8128)        ,
        DistanceAttenuationSgis = ((int)0x8129)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisSharpenTexture : int
    {
        LinearSharpenSgis = ((int)0x80AD)        ,
        LinearSharpenAlphaSgis = ((int)0x80AE)        ,
        LinearSharpenColorSgis = ((int)0x80AF)        ,
        SharpenTextureFuncPointsSgis = ((int)0x80B0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisTexture4D : int
    {
        PackSkipVolumesSgis = ((int)0x8130)        ,
        PackImageDepthSgis = ((int)0x8131)        ,
        UnpackSkipVolumesSgis = ((int)0x8132)        ,
        UnpackImageDepthSgis = ((int)0x8133)        ,
        Texture4DSgis = ((int)0x8134)        ,
        ProxyTexture4DSgis = ((int)0x8135)        ,
        Texture4DsizeSgis = ((int)0x8136)        ,
        TextureWrapQSgis = ((int)0x8137)        ,
        Max4DTextureSizeSgis = ((int)0x8138)        ,
        Texture4DBindingSgis = ((int)0x814F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisTextureBorderClamp : int
    {
        ClampToBorderSgis = ((int)0x812D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum SgisTextureColorMask : int
    {
        TextureColorWritemaskSgis = ((int)0x81EF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisTextureEdgeClamp : int
    {
        ClampToEdgeSgis = ((int)0x812F)        ,
    }

    /// <summary>
    /// Used in GL.Sgis.GetTexFilterFunc, GL.Sgis.TexFilterFunc
    /// </summary>
    public enum SgisTextureFilter4 : int
    {
        Filter4Sgis = ((int)0x8146)        ,
        TextureFilter4SizeSgis = ((int)0x8147)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisTextureLod : int
    {
        TextureMinLodSgis = ((int)0x813A)        ,
        TextureMaxLodSgis = ((int)0x813B)        ,
        TextureBaseLevelSgis = ((int)0x813C)        ,
        TextureMaxLevelSgis = ((int)0x813D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgisTextureSelect : int
    {
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgiTextureColorTable : int
    {
        TextureColorTableSgi = ((int)0x80BC)        ,
        ProxyTextureColorTableSgi = ((int)0x80BD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixAsync : int
    {
        AsyncMarkerSgix = ((int)0x8329)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixAsyncHistogram : int
    {
        AsyncHistogramSgix = ((int)0x832C)        ,
        MaxAsyncHistogramSgix = ((int)0x832D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixAsyncPixel : int
    {
        AsyncTexImageSgix = ((int)0x835C)        ,
        AsyncDrawPixelsSgix = ((int)0x835D)        ,
        AsyncReadPixelsSgix = ((int)0x835E)        ,
        MaxAsyncTexImageSgix = ((int)0x835F)        ,
        MaxAsyncDrawPixelsSgix = ((int)0x8360)        ,
        MaxAsyncReadPixelsSgix = ((int)0x8361)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixBlendAlphaMinmax : int
    {
        AlphaMinSgix = ((int)0x8320)        ,
        AlphaMaxSgix = ((int)0x8321)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixCalligraphicFragment : int
    {
        CalligraphicFragmentSgix = ((int)0x8183)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixClipmap : int
    {
        LinearClipmapLinearSgix = ((int)0x8170)        ,
        TextureClipmapCenterSgix = ((int)0x8171)        ,
        TextureClipmapFrameSgix = ((int)0x8172)        ,
        TextureClipmapOffsetSgix = ((int)0x8173)        ,
        TextureClipmapVirtualDepthSgix = ((int)0x8174)        ,
        TextureClipmapLodOffsetSgix = ((int)0x8175)        ,
        TextureClipmapDepthSgix = ((int)0x8176)        ,
        MaxClipmapDepthSgix = ((int)0x8177)        ,
        MaxClipmapVirtualDepthSgix = ((int)0x8178)        ,
        NearestClipmapNearestSgix = ((int)0x844D)        ,
        NearestClipmapLinearSgix = ((int)0x844E)        ,
        LinearClipmapNearestSgix = ((int)0x844F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixConvolutionAccuracy : int
    {
        ConvolutionHintSgix = ((int)0x8316)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixDepthPassInstrument : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixDepthTexture : int
    {
        DepthComponent16Sgix = ((int)0x81A5)        ,
        DepthComponent24Sgix = ((int)0x81A6)        ,
        DepthComponent32Sgix = ((int)0x81A7)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixFlushRaster : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixFogOffset : int
    {
        FogOffsetSgix = ((int)0x8198)        ,
        FogOffsetValueSgix = ((int)0x8199)        ,
    }

    /// <summary>
    /// Used in GL.Sgix.FragmentLight, GL.Sgix.FragmentLightModel and 2 other functions
    /// </summary>
    public enum SgixFragmentLighting : int
    {
        FragmentLightingSgix = ((int)0x8400)        ,
        FragmentColorMaterialSgix = ((int)0x8401)        ,
        FragmentColorMaterialFaceSgix = ((int)0x8402)        ,
        FragmentColorMaterialParameterSgix = ((int)0x8403)        ,
        MaxFragmentLightsSgix = ((int)0x8404)        ,
        MaxActiveLightsSgix = ((int)0x8405)        ,
        CurrentRasterNormalSgix = ((int)0x8406)        ,
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
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixFramezoom : int
    {
        FramezoomSgix = ((int)0x818B)        ,
        FramezoomFactorSgix = ((int)0x818C)        ,
        MaxFramezoomFactorSgix = ((int)0x818D)        ,
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
    /// Used in GL.Sgix.IglooInterface
    /// </summary>
    public enum SgixIglooInterface : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixInstruments : int
    {
        InstrumentBufferPointerSgix = ((int)0x8180)        ,
        InstrumentMeasurementsSgix = ((int)0x8181)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixInterlace : int
    {
        InterlaceSgix = ((int)0x8094)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixIrInstrument1 : int
    {
        IrInstrument1Sgix = ((int)0x817F)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixListPriority : int
    {
        ListPrioritySgix = ((int)0x8182)        ,
    }

    /// <summary>
    /// Used in GL.Sgix.PixelTexGen
    /// </summary>
    public enum SgixPixelTexture : int
    {
        PixelTexGenSgix = ((int)0x8139)        ,
        PixelTexGenModeSgix = ((int)0x832B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixPixelTiles : int
    {
        PixelTileBestAlignmentSgix = ((int)0x813E)        ,
        PixelTileCacheIncrementSgix = ((int)0x813F)        ,
        PixelTileWidthSgix = ((int)0x8140)        ,
        PixelTileHeightSgix = ((int)0x8141)        ,
        PixelTileGridWidthSgix = ((int)0x8142)        ,
        PixelTileGridHeightSgix = ((int)0x8143)        ,
        PixelTileGridDepthSgix = ((int)0x8144)        ,
        PixelTileCacheSizeSgix = ((int)0x8145)        ,
    }

    /// <summary>
    /// Used in GL.Sgix.DeformationMap3
    /// </summary>
    public enum SgixPolynomialFfd : int
    {
        TextureDeformationBitSgix = ((int)0x00000001)        ,
        GeometryDeformationBitSgix = ((int)0x00000002)        ,
        GeometryDeformationSgix = ((int)0x8194)        ,
        TextureDeformationSgix = ((int)0x8195)        ,
        DeformationsMaskSgix = ((int)0x8196)        ,
        MaxDeformationOrderSgix = ((int)0x8197)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixReferencePlane : int
    {
        ReferencePlaneSgix = ((int)0x817D)        ,
        ReferencePlaneEquationSgix = ((int)0x817E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixResample : int
    {
        PackResampleSgix = ((int)0x842C)        ,
        UnpackResampleSgix = ((int)0x842D)        ,
        ResampleReplicateSgix = ((int)0x842E)        ,
        ResampleZeroFillSgix = ((int)0x842F)        ,
        ResampleDecimateSgix = ((int)0x8430)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixScalebiasHint : int
    {
        ScalebiasHintSgix = ((int)0x8322)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixShadow : int
    {
        TextureCompareSgix = ((int)0x819A)        ,
        TextureCompareOperatorSgix = ((int)0x819B)        ,
        TextureLequalRSgix = ((int)0x819C)        ,
        TextureGequalRSgix = ((int)0x819D)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixShadowAmbient : int
    {
        ShadowAmbientSgix = ((int)0x80BF)        ,
    }

    /// <summary>
    /// Used in GL.Sgix.SpriteParameter
    /// </summary>
    public enum SgixSprite : int
    {
        SpriteSgix = ((int)0x8148)        ,
        SpriteModeSgix = ((int)0x8149)        ,
        SpriteAxisSgix = ((int)0x814A)        ,
        SpriteTranslationSgix = ((int)0x814B)        ,
        SpriteAxialSgix = ((int)0x814C)        ,
        SpriteObjectAlignedSgix = ((int)0x814D)        ,
        SpriteEyeAlignedSgix = ((int)0x814E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixSubsample : int
    {
        PackSubsampleRateSgix = ((int)0x85A0)        ,
        UnpackSubsampleRateSgix = ((int)0x85A1)        ,
        PixelSubsample4444Sgix = ((int)0x85A2)        ,
        PixelSubsample2424Sgix = ((int)0x85A3)        ,
        PixelSubsample4242Sgix = ((int)0x85A4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTagSampleBuffer : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTextureAddEnv : int
    {
        TextureEnvBiasSgix = ((int)0x80BE)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTextureCoordinateClamp : int
    {
        TextureMaxClampSSgix = ((int)0x8369)        ,
        TextureMaxClampTSgix = ((int)0x836A)        ,
        TextureMaxClampRSgix = ((int)0x836B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTextureLodBias : int
    {
        TextureLodBiasSSgix = ((int)0x818E)        ,
        TextureLodBiasTSgix = ((int)0x818F)        ,
        TextureLodBiasRSgix = ((int)0x8190)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTextureMultiBuffer : int
    {
        TextureMultiBufferHintSgix = ((int)0x812E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixTextureScaleBias : int
    {
        PostTextureFilterBiasSgix = ((int)0x8179)        ,
        PostTextureFilterScaleSgix = ((int)0x817A)        ,
        PostTextureFilterBiasRangeSgix = ((int)0x817B)        ,
        PostTextureFilterScaleRangeSgix = ((int)0x817C)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixVertexPreclip : int
    {
        VertexPreclipSgix = ((int)0x83EE)        ,
        VertexPreclipHintSgix = ((int)0x83EF)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixYcrcb : int
    {
        Ycrcb422Sgix = ((int)0x81BB)        ,
        Ycrcb444Sgix = ((int)0x81BC)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixYcrcba : int
    {
        YcrcbSgix = ((int)0x8318)        ,
        YcrcbaSgix = ((int)0x8319)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SgixYcrcbSubsample : int
    {
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
        GeometryShaderExt = ((int)0x8DD9)        ,
        TessEvaluationShader = ((int)0x8E87)        ,
        TessControlShader = ((int)0x8E88)        ,
        ComputeShader = ((int)0x91B9)        ,
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
    /// Used in GL.Ati.StencilFuncSeparate, GL.StencilFunc and 2 other functions
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
    /// Used in GL.Ati.StencilOpSeparate, GL.StencilOp and 1 other function
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
    /// Not used directly.
    /// </summary>
    public enum SunConvolutionBorderModes : int
    {
        WrapBorderSun = ((int)0x81D4)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SunGlobalAlpha : int
    {
        GlobalAlphaSun = ((int)0x81D9)        ,
        GlobalAlphaFactorSun = ((int)0x81DA)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SunMeshArray : int
    {
        QuadMeshSun = ((int)0x8614)        ,
        TriangleMeshSun = ((int)0x8615)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SunSliceAccum : int
    {
        SliceAccumSun = ((int)0x85CC)        ,
    }

    /// <summary>
    /// Used in GL.Sun.ReplacementCodePointer
    /// </summary>
    public enum SunTriangleList : int
    {
        RestartSun = ((int)0x0001)        ,
        ReplaceMiddleSun = ((int)0x0002)        ,
        ReplaceOldestSun = ((int)0x0003)        ,
        TriangleListSun = ((int)0x81D7)        ,
        ReplacementCodeSun = ((int)0x81D8)        ,
        ReplacementCodeArraySun = ((int)0x85C0)        ,
        ReplacementCodeArrayTypeSun = ((int)0x85C1)        ,
        ReplacementCodeArrayStrideSun = ((int)0x85C2)        ,
        ReplacementCodeArrayPointerSun = ((int)0x85C3)        ,
        R1uiV3fSun = ((int)0x85C4)        ,
        R1uiC4ubV3fSun = ((int)0x85C5)        ,
        R1uiC3fV3fSun = ((int)0x85C6)        ,
        R1uiN3fV3fSun = ((int)0x85C7)        ,
        R1uiC4fN3fV3fSun = ((int)0x85C8)        ,
        R1uiT2fV3fSun = ((int)0x85C9)        ,
        R1uiT2fN3fV3fSun = ((int)0x85CA)        ,
        R1uiT2fC4fN3fV3fSun = ((int)0x85CB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SunVertex : int
    {
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SunxConstantData : int
    {
        UnpackConstantDataSunx = ((int)0x81D5)        ,
        TextureConstantDataSunx = ((int)0x81D6)        ,
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
    /// Used in GL.TexCoordPointer, GL.Ext.MultiTexCoordPointer and 4 other functions
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
    /// Used in GL.GetTexGen, GL.TexGend and 5 other functions
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
        Replace = ((int)0x1E01)        ,
        Modulate = ((int)0x2100)        ,
        Decal = ((int)0x2101)        ,
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
    /// Used in GL.GetTexEnv, GL.TexEnv and 2 other functions
    /// </summary>
    public enum TextureEnvParameter : int
    {
        AlphaScale = ((int)0x0D1C)        ,
        TextureEnvMode = ((int)0x2200)        ,
        TextureEnvColor = ((int)0x2201)        ,
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
    /// Used in GL.GetTexEnv, GL.TexEnv and 2 other functions
    /// </summary>
    public enum TextureEnvTarget : int
    {
        TextureEnv = ((int)0x2300)        ,
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
        EyeLinear = ((int)0x2400)        ,
        ObjectLinear = ((int)0x2401)        ,
        SphereMap = ((int)0x2402)        ,
        EyeDistanceToPointSgis = ((int)0x81F0)        ,
        ObjectDistanceToPointSgis = ((int)0x81F1)        ,
        EyeDistanceToLineSgis = ((int)0x81F2)        ,
        ObjectDistanceToLineSgis = ((int)0x81F3)        ,
        NormalMap = ((int)0x8511)        ,
        ReflectionMap = ((int)0x8512)        ,
    }

    /// <summary>
    /// Used in GL.GetTexGen, GL.TexGend and 5 other functions
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
    /// Used in GL.TexParameter, GL.TexParameterI and 5 other functions
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
    /// Used in GL.Arb.CompressedTexImage1D, GL.Arb.CompressedTexImage2D and 123 other functions
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
        TextureRectangleArb = ((int)0x84F5)        ,
        TextureRectangleNv = ((int)0x84F5)        ,
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
    /// Used in GL.Arb.ActiveTexture, GL.Arb.ClientActiveTexture and 55 other functions
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
        Clamp = ((int)0x2900)        ,
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
        ClientPixelStoreBit = ((int)0x00000001)        ,
        CurrentBit = ((int)0x00000001)        ,
        ClientVertexArrayBit = ((int)0x00000002)        ,
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
        Lines = ((int)0x0001)        ,
        EvalBit = ((int)0x00010000)        ,
        LineLoop = ((int)0x0002)        ,
        ListBit = ((int)0x00020000)        ,
        LineStrip = ((int)0x0003)        ,
        Triangles = ((int)0x0004)        ,
        TextureBit = ((int)0x00040000)        ,
        TriangleStrip = ((int)0x0005)        ,
        TriangleFan = ((int)0x0006)        ,
        Quads = ((int)0x0007)        ,
        QuadStrip = ((int)0x0008)        ,
        ScissorBit = ((int)0x00080000)        ,
        Polygon = ((int)0x0009)        ,
        Accum = ((int)0x0100)        ,
        Load = ((int)0x0101)        ,
        Return = ((int)0x0102)        ,
        Mult = ((int)0x0103)        ,
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
        StackUnderflow = ((int)0x0504)        ,
        OutOfMemory = ((int)0x0505)        ,
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
        PointSizeGranularity = ((int)0x0B13)        ,
        LineSmooth = ((int)0x0B20)        ,
        LineWidth = ((int)0x0B21)        ,
        LineWidthRange = ((int)0x0B22)        ,
        LineWidthGranularity = ((int)0x0B23)        ,
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
        ModelviewStackDepth = ((int)0x0BA3)        ,
        ProjectionStackDepth = ((int)0x0BA4)        ,
        TextureStackDepth = ((int)0x0BA5)        ,
        ModelviewMatrix = ((int)0x0BA6)        ,
        ProjectionMatrix = ((int)0x0BA7)        ,
        TextureMatrix = ((int)0x0BA8)        ,
        AttribStackDepth = ((int)0x0BB0)        ,
        ClientAttribStackDepth = ((int)0x0BB1)        ,
        AlphaTest = ((int)0x0BC0)        ,
        AlphaTestFunc = ((int)0x0BC1)        ,
        AlphaTestRef = ((int)0x0BC2)        ,
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
        ReadBuffer = ((int)0x0C02)        ,
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
        TextureHeight = ((int)0x1001)        ,
        TextureComponents = ((int)0x1003)        ,
        TextureInternalFormat = ((int)0x1003)        ,
        TextureBorderColor = ((int)0x1004)        ,
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
        Projection = ((int)0x1701)        ,
        Texture = ((int)0x1702)        ,
        Color = ((int)0x1800)        ,
        Depth = ((int)0x1801)        ,
        Stencil = ((int)0x1802)        ,
        ColorIndex = ((int)0x1900)        ,
        StencilIndex = ((int)0x1901)        ,
        DepthComponent = ((int)0x1902)        ,
        Red = ((int)0x1903)        ,
        Green = ((int)0x1904)        ,
        Blue = ((int)0x1905)        ,
        Alpha = ((int)0x1906)        ,
        Rgb = ((int)0x1907)        ,
        Rgba = ((int)0x1908)        ,
        Luminance = ((int)0x1909)        ,
        LuminanceAlpha = ((int)0x190A)        ,
        Bitmap = ((int)0x1A00)        ,
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
        PolygonOffsetFill = ((int)0x8037)        ,
        PolygonOffsetFactor = ((int)0x8038)        ,
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
        TextureLuminanceSize = ((int)0x8060)        ,
        TextureIntensitySize = ((int)0x8061)        ,
        ProxyTexture1D = ((int)0x8063)        ,
        ProxyTexture2D = ((int)0x8064)        ,
        TexturePriority = ((int)0x8066)        ,
        TextureResident = ((int)0x8067)        ,
        TextureBinding1D = ((int)0x8068)        ,
        TextureBinding2D = ((int)0x8069)        ,
        VertexArray = ((int)0x8074)        ,
        NormalArray = ((int)0x8075)        ,
        ColorArray = ((int)0x8076)        ,
        IndexArray = ((int)0x8077)        ,
        TextureCoordArray = ((int)0x8078)        ,
        EdgeFlagArray = ((int)0x8079)        ,
        VertexArraySize = ((int)0x807A)        ,
        VertexArrayType = ((int)0x807B)        ,
        VertexArrayStride = ((int)0x807C)        ,
        NormalArrayType = ((int)0x807E)        ,
        NormalArrayStride = ((int)0x807F)        ,
        ColorArraySize = ((int)0x8081)        ,
        ColorArrayType = ((int)0x8082)        ,
        ColorArrayStride = ((int)0x8083)        ,
        IndexArrayType = ((int)0x8085)        ,
        IndexArrayStride = ((int)0x8086)        ,
        TextureCoordArraySize = ((int)0x8088)        ,
        TextureCoordArrayType = ((int)0x8089)        ,
        TextureCoordArrayStride = ((int)0x808A)        ,
        EdgeFlagArrayStride = ((int)0x808C)        ,
        VertexArrayPointer = ((int)0x808E)        ,
        NormalArrayPointer = ((int)0x808F)        ,
        ColorArrayPointer = ((int)0x8090)        ,
        IndexArrayPointer = ((int)0x8091)        ,
        TextureCoordArrayPointer = ((int)0x8092)        ,
        EdgeFlagArrayPointer = ((int)0x8093)        ,
        AllAttribBits = unchecked((int)0xFFFFFFFF)        ,
        ClientAllAttribBits = unchecked((int)0xFFFFFFFF)        ,
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
        RescaleNormal = ((int)0x803A)        ,
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
        LightModelColorControl = ((int)0x81F8)        ,
        SingleColor = ((int)0x81F9)        ,
        SeparateSpecularColor = ((int)0x81FA)        ,
        UnsignedByte233Rev = ((int)0x8362)        ,
        UnsignedShort565 = ((int)0x8363)        ,
        UnsignedShort565Rev = ((int)0x8364)        ,
        UnsignedShort4444Rev = ((int)0x8365)        ,
        UnsignedShort1555Rev = ((int)0x8366)        ,
        UnsignedInt8888Rev = ((int)0x8367)        ,
        UnsignedInt2101010Rev = ((int)0x8368)        ,
        AliasedPointSizeRange = ((int)0x846D)        ,
        AliasedLineWidthRange = ((int)0x846E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version13 : int
    {
        MultisampleBit = ((int)0x20000000)        ,
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
        ClientActiveTexture = ((int)0x84E1)        ,
        MaxTextureUnits = ((int)0x84E2)        ,
        TransposeModelviewMatrix = ((int)0x84E3)        ,
        TransposeProjectionMatrix = ((int)0x84E4)        ,
        TransposeTextureMatrix = ((int)0x84E5)        ,
        TransposeColorMatrix = ((int)0x84E6)        ,
        Subtract = ((int)0x84E7)        ,
        CompressedAlpha = ((int)0x84E9)        ,
        CompressedLuminance = ((int)0x84EA)        ,
        CompressedLuminanceAlpha = ((int)0x84EB)        ,
        CompressedIntensity = ((int)0x84EC)        ,
        CompressedRgb = ((int)0x84ED)        ,
        CompressedRgba = ((int)0x84EE)        ,
        TextureCompressionHint = ((int)0x84EF)        ,
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
        Source1Rgb = ((int)0x8581)        ,
        Source2Rgb = ((int)0x8582)        ,
        Source0Alpha = ((int)0x8588)        ,
        Source1Alpha = ((int)0x8589)        ,
        Source2Alpha = ((int)0x858A)        ,
        Operand0Rgb = ((int)0x8590)        ,
        Operand1Rgb = ((int)0x8591)        ,
        Operand2Rgb = ((int)0x8592)        ,
        Operand0Alpha = ((int)0x8598)        ,
        Operand1Alpha = ((int)0x8599)        ,
        Operand2Alpha = ((int)0x859A)        ,
        TextureCompressedImageSize = ((int)0x86A0)        ,
        TextureCompressed = ((int)0x86A1)        ,
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        CompressedTextureFormats = ((int)0x86A3)        ,
        Dot3Rgb = ((int)0x86AE)        ,
        Dot3Rgba = ((int)0x86AF)        ,
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
        PointSizeMin = ((int)0x8126)        ,
        PointSizeMax = ((int)0x8127)        ,
        PointFadeThresholdSize = ((int)0x8128)        ,
        PointDistanceAttenuation = ((int)0x8129)        ,
        GenerateMipmap = ((int)0x8191)        ,
        GenerateMipmapHint = ((int)0x8192)        ,
        DepthComponent16 = ((int)0x81A5)        ,
        DepthComponent24 = ((int)0x81A6)        ,
        DepthComponent32 = ((int)0x81A7)        ,
        MirroredRepeat = ((int)0x8370)        ,
        FogCoordinateSource = ((int)0x8450)        ,
        FogCoordinate = ((int)0x8451)        ,
        FragmentDepth = ((int)0x8452)        ,
        CurrentFogCoordinate = ((int)0x8453)        ,
        FogCoordinateArrayType = ((int)0x8454)        ,
        FogCoordinateArrayStride = ((int)0x8455)        ,
        FogCoordinateArrayPointer = ((int)0x8456)        ,
        FogCoordinateArray = ((int)0x8457)        ,
        ColorSum = ((int)0x8458)        ,
        CurrentSecondaryColor = ((int)0x8459)        ,
        SecondaryColorArraySize = ((int)0x845A)        ,
        SecondaryColorArrayType = ((int)0x845B)        ,
        SecondaryColorArrayStride = ((int)0x845C)        ,
        SecondaryColorArrayPointer = ((int)0x845D)        ,
        SecondaryColorArray = ((int)0x845E)        ,
        MaxTextureLodBias = ((int)0x84FD)        ,
        TextureFilterControl = ((int)0x8500)        ,
        TextureLodBias = ((int)0x8501)        ,
        IncrWrap = ((int)0x8507)        ,
        DecrWrap = ((int)0x8508)        ,
        TextureDepthSize = ((int)0x884A)        ,
        DepthTextureMode = ((int)0x884B)        ,
        TextureCompareMode = ((int)0x884C)        ,
        TextureCompareFunc = ((int)0x884D)        ,
        CompareRToTexture = ((int)0x884E)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version15 : int
    {
        FogCoordSrc = ((int)0x8450)        ,
        FogCoord = ((int)0x8451)        ,
        CurrentFogCoord = ((int)0x8453)        ,
        FogCoordArrayType = ((int)0x8454)        ,
        FogCoordArrayStride = ((int)0x8455)        ,
        FogCoordArrayPointer = ((int)0x8456)        ,
        FogCoordArray = ((int)0x8457)        ,
        Src0Rgb = ((int)0x8580)        ,
        Src1Rgb = ((int)0x8581)        ,
        Src2Rgb = ((int)0x8582)        ,
        Src0Alpha = ((int)0x8588)        ,
        Src1Alpha = ((int)0x8589)        ,
        Src2Alpha = ((int)0x858A)        ,
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
        VertexArrayBufferBinding = ((int)0x8896)        ,
        NormalArrayBufferBinding = ((int)0x8897)        ,
        ColorArrayBufferBinding = ((int)0x8898)        ,
        IndexArrayBufferBinding = ((int)0x8899)        ,
        TextureCoordArrayBufferBinding = ((int)0x889A)        ,
        EdgeFlagArrayBufferBinding = ((int)0x889B)        ,
        SecondaryColorArrayBufferBinding = ((int)0x889C)        ,
        FogCoordArrayBufferBinding = ((int)0x889D)        ,
        FogCoordinateArrayBufferBinding = ((int)0x889D)        ,
        WeightArrayBufferBinding = ((int)0x889E)        ,
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
    /// Used in GL.StencilFuncSeparate
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
        VertexProgramTwoSide = ((int)0x8643)        ,
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
        PointSprite = ((int)0x8861)        ,
        CoordReplace = ((int)0x8862)        ,
        MaxVertexAttribs = ((int)0x8869)        ,
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        MaxTextureCoords = ((int)0x8871)        ,
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
        CurrentRasterSecondaryColor = ((int)0x845F)        ,
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
        SluminanceAlpha = ((int)0x8C44)        ,
        Sluminance8Alpha8 = ((int)0x8C45)        ,
        Sluminance = ((int)0x8C46)        ,
        Sluminance8 = ((int)0x8C47)        ,
        CompressedSrgb = ((int)0x8C48)        ,
        CompressedSrgbAlpha = ((int)0x8C49)        ,
        CompressedSluminance = ((int)0x8C4A)        ,
        CompressedSluminanceAlpha = ((int)0x8C4B)        ,
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
        ClampVertexColor = ((int)0x891A)        ,
        ClampFragmentColor = ((int)0x891B)        ,
        ClampReadColor = ((int)0x891C)        ,
        FixedOnly = ((int)0x891D)        ,
        MaxVaryingComponents = ((int)0x8B4B)        ,
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
        AlphaInteger = ((int)0x8D97)        ,
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
    /// Used in GL.GetInteger64, GL.ProgramParameter
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
    /// Used in GL.BlendEquation, GL.BlendFunc and 1 other function
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
    /// Used in GL.VertexAttribLPointer
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
    /// Used in GL.VertexAttribIPointer
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
    /// Used in GL.Arb.GetVertexAttrib, GL.Arb.GetVertexAttribL and 1 other function
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
    /// Used in GL.Arb.GetVertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerParameterArb : int
    {
        ArrayPointer = ((int)0x8645)        ,
    }

    /// <summary>
    /// Used in GL.Ati.VertexAttribArrayObject, GL.VertexAttribPointer and 1 other function
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
    /// Used in GL.Arb.VertexAttribPointer
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
    /// Used in GL.VertexPointer, GL.Ext.VertexArrayVertexOffset and 5 other functions
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

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum WinPhongShading : int
    {
        PhongWin = ((int)0x80EA)        ,
        PhongHintWin = ((int)0x80EB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum WinSpecularFog : int
    {
        FogSpecularTextureWin = ((int)0x80EC)        ,
    }

}
