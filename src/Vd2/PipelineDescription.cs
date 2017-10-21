﻿namespace Vd2
{
    public struct PipelineDescription
    {
        public BlendStateDescription BlendState;
        public DepthStencilStateDescription DepthStencilState;
        public RasterizerStateDescription RasterizerState;
        public PrimitiveTopology PrimitiveTopology;
        public ShaderSetDescription ShaderSet;
        public ResourceLayout ResourceLayout; // TODO: Allow multiple resource layouts
        public OutputDescription Outputs;

        public PipelineDescription(
            BlendStateDescription blendState,
            DepthStencilStateDescription depthStencilStateDescription,
            RasterizerStateDescription rasterizerState,
            PrimitiveTopology primitiveTopology,
            ShaderSetDescription shaderSet,
            ResourceLayout resourceLayout,
            OutputDescription outputs)
        {
            BlendState = blendState;
            DepthStencilState = depthStencilStateDescription;
            RasterizerState = rasterizerState;
            PrimitiveTopology = primitiveTopology;
            ShaderSet = shaderSet;
            ResourceLayout = resourceLayout;
            Outputs = outputs;
        }
    }
}