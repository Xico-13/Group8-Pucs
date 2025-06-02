using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColorBlindnessFeature : ScriptableRendererFeature
{
    class ColorBlindnessPass : ScriptableRenderPass
    {
        private Material material;
        private RTHandle temporaryRT;

        public ColorBlindnessPass(Material mat)
        {
            material = mat;
            renderPassEvent = RenderPassEvent.AfterRenderingTransparents;
        }

        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
            RenderingUtils.ReAllocateIfNeeded(ref temporaryRT, cameraTextureDescriptor, name: "_TemporaryColorBlindnessTex");

            // Diz ao URP que queremos trabalhar com o render target principal da câmara
            ConfigureTarget(BuiltinRenderTextureType.CameraTarget);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (material == null)
                return;

            CommandBuffer cmd = CommandBufferPool.Get("Color Blindness Pass");

            RTHandle cameraTarget = renderingData.cameraData.renderer.cameraColorTargetHandle;

            Blit(cmd, cameraTarget, temporaryRT, material, 0);     // Aplica o efeito
            Blit(cmd, temporaryRT, cameraTarget);                  // Volta a escrever no target principal

            context.ExecuteCommandBuffer(cmd);
            CommandBufferPool.Release(cmd);
        }

        public override void OnCameraCleanup(CommandBuffer cmd)
        {
            // cleanup opcional
        }
    }

    [System.Serializable]
    public class Settings
    {
        public Material colorBlindMaterial;
    }

    public Settings settings = new Settings();
    private ColorBlindnessPass colorBlindnessPass;

    public override void Create()
    {
        if (settings.colorBlindMaterial == null)
        {
            Debug.LogError("ColorBlindnessFeature: Material não atribuído.");
            return;
        }

        colorBlindnessPass = new ColorBlindnessPass(settings.colorBlindMaterial);
    }

    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        if (settings.colorBlindMaterial == null)
            return;

        renderer.EnqueuePass(colorBlindnessPass);
    }
}
