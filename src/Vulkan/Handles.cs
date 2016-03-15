using System;

namespace Vulkan
{
	public partial class Instance
	{
		internal IntPtr m;

		public void Destroy (AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyInstance (this.m, Allocator.m);
			}
		}

		public Result EnumeratePhysicalDevices (out UInt32 PhysicalDeviceCount, out PhysicalDevice PhysicalDevices)
		{
			unsafe {
				PhysicalDevices = new PhysicalDevice ();

				fixed (UInt32* ptrPhysicalDeviceCount = &PhysicalDeviceCount) {
					fixed (IntPtr* ptrPhysicalDevices = &PhysicalDevices.m) {
						return Interop.NativeMethods.vkEnumeratePhysicalDevices (this.m, ptrPhysicalDeviceCount, ptrPhysicalDevices);
					}
				}
			}
		}

		public IntPtr GetProcAddr (string pName)
		{
			unsafe {
				return Interop.NativeMethods.vkGetInstanceProcAddr (this.m, pName);
			}
		}

		public Result CreateDisplayPlaneSurfaceKHR (DisplaySurfaceCreateInfoKhr CreateInfo, AllocationCallbacks Allocator, out SurfaceKhr Surface)
		{
			unsafe {
				Surface = new SurfaceKhr ();

				fixed (UInt64* ptrSurface = &Surface.m) {
					return Interop.NativeMethods.vkCreateDisplayPlaneSurfaceKHR (this.m, CreateInfo.m, Allocator.m, ptrSurface);
				}
			}
		}

		public void DestroySurfaceKHR (SurfaceKhr surface, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroySurfaceKHR (this.m, surface.m, Allocator.m);
			}
		}

		public Result CreateDebugReportCallbackEXT (DebugReportCallbackCreateInfoExt CreateInfo, AllocationCallbacks Allocator, out DebugReportCallbackExt Callback)
		{
			unsafe {
				Callback = new DebugReportCallbackExt ();

				fixed (UInt64* ptrCallback = &Callback.m) {
					return Interop.NativeMethods.vkCreateDebugReportCallbackEXT (this.m, CreateInfo.m, Allocator.m, ptrCallback);
				}
			}
		}

		public void DestroyDebugReportCallbackEXT (DebugReportCallbackExt callback, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyDebugReportCallbackEXT (this.m, callback.m, Allocator.m);
			}
		}

		public void DebugReportMessageEXT (DebugReportFlagsExt flags, DebugReportObjectTypeExt objectType, UInt64 @object, UIntPtr location, Int32 messageCode, string pLayerPrefix, string pMessage)
		{
			unsafe {
				Interop.NativeMethods.vkDebugReportMessageEXT (this.m, flags, objectType, @object, location, messageCode, pLayerPrefix, pMessage);
			}
		}
	}

	public partial class PhysicalDevice
	{
		internal IntPtr m;

		public void GetProperties (out PhysicalDeviceProperties Properties)
		{
			unsafe {
				Properties = new PhysicalDeviceProperties ();
				Interop.NativeMethods.vkGetPhysicalDeviceProperties (this.m, Properties.m);
			}
		}

		public void GetQueueFamilyProperties (out UInt32 QueueFamilyPropertyCount, out QueueFamilyProperties QueueFamilyProperties)
		{
			unsafe {
				fixed (UInt32* ptrQueueFamilyPropertyCount = &QueueFamilyPropertyCount) {
					QueueFamilyProperties = new QueueFamilyProperties ();
					Interop.NativeMethods.vkGetPhysicalDeviceQueueFamilyProperties (this.m, ptrQueueFamilyPropertyCount, QueueFamilyProperties.m);
				}
			}
		}

		public void GetMemoryProperties (out PhysicalDeviceMemoryProperties MemoryProperties)
		{
			unsafe {
				MemoryProperties = new PhysicalDeviceMemoryProperties ();
				Interop.NativeMethods.vkGetPhysicalDeviceMemoryProperties (this.m, MemoryProperties.m);
			}
		}

		public void GetFeatures (out PhysicalDeviceFeatures Features)
		{
			unsafe {
				Features = new PhysicalDeviceFeatures ();
				Interop.NativeMethods.vkGetPhysicalDeviceFeatures (this.m, Features.m);
			}
		}

		public void GetFormatProperties (Format format, out FormatProperties FormatProperties)
		{
			unsafe {
				FormatProperties = new FormatProperties ();
				Interop.NativeMethods.vkGetPhysicalDeviceFormatProperties (this.m, format, FormatProperties.m);
			}
		}

		public Result GetImageFormatProperties (Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, out ImageFormatProperties ImageFormatProperties)
		{
			unsafe {
				ImageFormatProperties = new ImageFormatProperties ();
				return Interop.NativeMethods.vkGetPhysicalDeviceImageFormatProperties (this.m, format, type, tiling, usage, flags, ImageFormatProperties.m);
			}
		}

		public Result CreateDevice (DeviceCreateInfo CreateInfo, AllocationCallbacks Allocator, out Device Device)
		{
			unsafe {
				Device = new Device ();

				fixed (IntPtr* ptrDevice = &Device.m) {
					return Interop.NativeMethods.vkCreateDevice (this.m, CreateInfo.m, Allocator.m, ptrDevice);
				}
			}
		}

		public Result EnumerateDeviceLayerProperties (out UInt32 PropertyCount, out LayerProperties Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new LayerProperties ();
					return Interop.NativeMethods.vkEnumerateDeviceLayerProperties (this.m, ptrPropertyCount, Properties.m);
				}
			}
		}

		public Result EnumerateDeviceExtensionProperties (string pLayerName, out UInt32 PropertyCount, out ExtensionProperties Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new ExtensionProperties ();
					return Interop.NativeMethods.vkEnumerateDeviceExtensionProperties (this.m, pLayerName, ptrPropertyCount, Properties.m);
				}
			}
		}

		public void GetSparseImageFormatProperties (Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, out UInt32 PropertyCount, out SparseImageFormatProperties Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new SparseImageFormatProperties ();
					Interop.NativeMethods.vkGetPhysicalDeviceSparseImageFormatProperties (this.m, format, type, samples, usage, tiling, ptrPropertyCount, Properties.m);
				}
			}
		}

		public Result GetDisplayPropertiesKHR (out UInt32 PropertyCount, out DisplayPropertiesKhr Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new DisplayPropertiesKhr ();
					return Interop.NativeMethods.vkGetPhysicalDeviceDisplayPropertiesKHR (this.m, ptrPropertyCount, Properties.m);
				}
			}
		}

		public Result GetDisplayPlanePropertiesKHR (out UInt32 PropertyCount, out DisplayPlanePropertiesKhr Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new DisplayPlanePropertiesKhr ();
					return Interop.NativeMethods.vkGetPhysicalDeviceDisplayPlanePropertiesKHR (this.m, ptrPropertyCount, Properties.m);
				}
			}
		}

		public Result GetDisplayPlaneSupportedDisplaysKHR (UInt32 planeIndex, out UInt32 DisplayCount, out DisplayKhr Displays)
		{
			unsafe {
				Displays = new DisplayKhr ();

				fixed (UInt32* ptrDisplayCount = &DisplayCount) {
					fixed (UInt64* ptrDisplays = &Displays.m) {
						return Interop.NativeMethods.vkGetDisplayPlaneSupportedDisplaysKHR (this.m, planeIndex, ptrDisplayCount, ptrDisplays);
					}
				}
			}
		}

		public Result GetDisplayModePropertiesKHR (DisplayKhr display, out UInt32 PropertyCount, out DisplayModePropertiesKhr Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new DisplayModePropertiesKhr ();
					return Interop.NativeMethods.vkGetDisplayModePropertiesKHR (this.m, display.m, ptrPropertyCount, Properties.m);
				}
			}
		}

		public Result CreateDisplayModeKHR (DisplayKhr display, DisplayModeCreateInfoKhr CreateInfo, AllocationCallbacks Allocator, out DisplayModeKhr Mode)
		{
			unsafe {
				Mode = new DisplayModeKhr ();

				fixed (UInt64* ptrMode = &Mode.m) {
					return Interop.NativeMethods.vkCreateDisplayModeKHR (this.m, display.m, CreateInfo.m, Allocator.m, ptrMode);
				}
			}
		}

		public Result GetDisplayPlaneCapabilitiesKHR (DisplayModeKhr mode, UInt32 planeIndex, out DisplayPlaneCapabilitiesKhr Capabilities)
		{
			unsafe {
				Capabilities = new DisplayPlaneCapabilitiesKhr ();
				return Interop.NativeMethods.vkGetDisplayPlaneCapabilitiesKHR (this.m, mode.m, planeIndex, Capabilities.m);
			}
		}

		public Result GetSurfaceSupportKHR (UInt32 queueFamilyIndex, SurfaceKhr surface, out Bool32 Supported)
		{
			unsafe {
				fixed (Bool32* ptrSupported = &Supported) {
					return Interop.NativeMethods.vkGetPhysicalDeviceSurfaceSupportKHR (this.m, queueFamilyIndex, surface.m, ptrSupported);
				}
			}
		}

		public Result GetSurfaceCapabilitiesKHR (SurfaceKhr surface, out SurfaceCapabilitiesKhr SurfaceCapabilities)
		{
			unsafe {
				SurfaceCapabilities = new SurfaceCapabilitiesKhr ();
				return Interop.NativeMethods.vkGetPhysicalDeviceSurfaceCapabilitiesKHR (this.m, surface.m, SurfaceCapabilities.m);
			}
		}

		public Result GetSurfaceFormatsKHR (SurfaceKhr surface, out UInt32 SurfaceFormatCount, out SurfaceFormatKhr SurfaceFormats)
		{
			unsafe {
				fixed (UInt32* ptrSurfaceFormatCount = &SurfaceFormatCount) {
					SurfaceFormats = new SurfaceFormatKhr ();
					return Interop.NativeMethods.vkGetPhysicalDeviceSurfaceFormatsKHR (this.m, surface.m, ptrSurfaceFormatCount, SurfaceFormats.m);
				}
			}
		}

		public Result GetSurfacePresentModesKHR (SurfaceKhr surface, out UInt32 PresentModeCount, out PresentModeKhr PresentModes)
		{
			unsafe {
				fixed (UInt32* ptrPresentModeCount = &PresentModeCount) {
					fixed (PresentModeKhr* ptrPresentModes = &PresentModes) {
						return Interop.NativeMethods.vkGetPhysicalDeviceSurfacePresentModesKHR (this.m, surface.m, ptrPresentModeCount, ptrPresentModes);
					}
				}
			}
		}

		public Bool32 GetWin32PresentationSupportKHR (UInt32 queueFamilyIndex)
		{
			unsafe {
				return Interop.NativeMethods.vkGetPhysicalDeviceWin32PresentationSupportKHR (this.m, queueFamilyIndex);
			}
		}
	}

	public partial class Device
	{
		internal IntPtr m;

		public IntPtr GetProcAddr (string pName)
		{
			unsafe {
				return Interop.NativeMethods.vkGetDeviceProcAddr (this.m, pName);
			}
		}

		public void Destroy (AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyDevice (this.m, Allocator.m);
			}
		}

		public void GetQueue (UInt32 queueFamilyIndex, UInt32 queueIndex, out Queue Queue)
		{
			unsafe {
				Queue = new Queue ();

				fixed (IntPtr* ptrQueue = &Queue.m) {
					Interop.NativeMethods.vkGetDeviceQueue (this.m, queueFamilyIndex, queueIndex, ptrQueue);
				}
			}
		}

		public Result WaitIdle ()
		{
			unsafe {
				return Interop.NativeMethods.vkDeviceWaitIdle (this.m);
			}
		}

		public Result AllocateMemory (MemoryAllocateInfo AllocateInfo, AllocationCallbacks Allocator, out DeviceMemory Memory)
		{
			unsafe {
				Memory = new DeviceMemory ();

				fixed (UInt64* ptrMemory = &Memory.m) {
					return Interop.NativeMethods.vkAllocateMemory (this.m, AllocateInfo.m, Allocator.m, ptrMemory);
				}
			}
		}

		public void FreeMemory (DeviceMemory memory, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkFreeMemory (this.m, memory.m, Allocator.m);
			}
		}

		public Result MapMemory (DeviceMemory memory, DeviceSize offset, DeviceSize size, UInt32 flags, out IntPtr pData)
		{
			unsafe {
				fixed (IntPtr* ptrpData = &pData) {
					return Interop.NativeMethods.vkMapMemory (this.m, memory.m, offset, size, flags, ptrpData);
				}
			}
		}

		public void UnmapMemory (DeviceMemory memory)
		{
			unsafe {
				Interop.NativeMethods.vkUnmapMemory (this.m, memory.m);
			}
		}

		public Result FlushMappedMemoryRanges (UInt32 memoryRangeCount, MappedMemoryRange MemoryRanges)
		{
			unsafe {
				return Interop.NativeMethods.vkFlushMappedMemoryRanges (this.m, memoryRangeCount, MemoryRanges.m);
			}
		}

		public Result InvalidateMappedMemoryRanges (UInt32 memoryRangeCount, MappedMemoryRange MemoryRanges)
		{
			unsafe {
				return Interop.NativeMethods.vkInvalidateMappedMemoryRanges (this.m, memoryRangeCount, MemoryRanges.m);
			}
		}

		public void GetMemoryCommitment (DeviceMemory memory, out DeviceSize CommittedMemoryInBytes)
		{
			unsafe {
				fixed (DeviceSize* ptrCommittedMemoryInBytes = &CommittedMemoryInBytes) {
					Interop.NativeMethods.vkGetDeviceMemoryCommitment (this.m, memory.m, ptrCommittedMemoryInBytes);
				}
			}
		}

		public void GetBufferMemoryRequirements (Buffer buffer, out MemoryRequirements MemoryRequirements)
		{
			unsafe {
				MemoryRequirements = new MemoryRequirements ();
				Interop.NativeMethods.vkGetBufferMemoryRequirements (this.m, buffer.m, MemoryRequirements.m);
			}
		}

		public Result BindBufferMemory (Buffer buffer, DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe {
				return Interop.NativeMethods.vkBindBufferMemory (this.m, buffer.m, memory.m, memoryOffset);
			}
		}

		public void GetImageMemoryRequirements (Image image, out MemoryRequirements MemoryRequirements)
		{
			unsafe {
				MemoryRequirements = new MemoryRequirements ();
				Interop.NativeMethods.vkGetImageMemoryRequirements (this.m, image.m, MemoryRequirements.m);
			}
		}

		public Result BindImageMemory (Image image, DeviceMemory memory, DeviceSize memoryOffset)
		{
			unsafe {
				return Interop.NativeMethods.vkBindImageMemory (this.m, image.m, memory.m, memoryOffset);
			}
		}

		public void GetImageSparseMemoryRequirements (Image image, out UInt32 SparseMemoryRequirementCount, out SparseImageMemoryRequirements SparseMemoryRequirements)
		{
			unsafe {
				fixed (UInt32* ptrSparseMemoryRequirementCount = &SparseMemoryRequirementCount) {
					SparseMemoryRequirements = new SparseImageMemoryRequirements ();
					Interop.NativeMethods.vkGetImageSparseMemoryRequirements (this.m, image.m, ptrSparseMemoryRequirementCount, SparseMemoryRequirements.m);
				}
			}
		}

		public Result CreateFence (FenceCreateInfo CreateInfo, AllocationCallbacks Allocator, out Fence Fence)
		{
			unsafe {
				Fence = new Fence ();

				fixed (UInt64* ptrFence = &Fence.m) {
					return Interop.NativeMethods.vkCreateFence (this.m, CreateInfo.m, Allocator.m, ptrFence);
				}
			}
		}

		public void DestroyFence (Fence fence, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyFence (this.m, fence.m, Allocator.m);
			}
		}

		public Result ResetFences (UInt32 fenceCount, Fence Fences)
		{
			unsafe {
				Fences = new Fence ();

				fixed (UInt64* ptrFences = &Fences.m) {
					return Interop.NativeMethods.vkResetFences (this.m, fenceCount, ptrFences);
				}
			}
		}

		public Result GetFenceStatus (Fence fence)
		{
			unsafe {
				return Interop.NativeMethods.vkGetFenceStatus (this.m, fence.m);
			}
		}

		public Result WaitForFences (UInt32 fenceCount, Fence Fences, Bool32 waitAll, UInt64 timeout)
		{
			unsafe {
				Fences = new Fence ();

				fixed (UInt64* ptrFences = &Fences.m) {
					return Interop.NativeMethods.vkWaitForFences (this.m, fenceCount, ptrFences, waitAll, timeout);
				}
			}
		}

		public Result CreateSemaphore (SemaphoreCreateInfo CreateInfo, AllocationCallbacks Allocator, out Semaphore Semaphore)
		{
			unsafe {
				Semaphore = new Semaphore ();

				fixed (UInt64* ptrSemaphore = &Semaphore.m) {
					return Interop.NativeMethods.vkCreateSemaphore (this.m, CreateInfo.m, Allocator.m, ptrSemaphore);
				}
			}
		}

		public void DestroySemaphore (Semaphore semaphore, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroySemaphore (this.m, semaphore.m, Allocator.m);
			}
		}

		public Result CreateEvent (EventCreateInfo CreateInfo, AllocationCallbacks Allocator, out Event Event)
		{
			unsafe {
				Event = new Event ();

				fixed (UInt64* ptrEvent = &Event.m) {
					return Interop.NativeMethods.vkCreateEvent (this.m, CreateInfo.m, Allocator.m, ptrEvent);
				}
			}
		}

		public void DestroyEvent (Event @event, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyEvent (this.m, @event.m, Allocator.m);
			}
		}

		public Result GetEventStatus (Event @event)
		{
			unsafe {
				return Interop.NativeMethods.vkGetEventStatus (this.m, @event.m);
			}
		}

		public Result SetEvent (Event @event)
		{
			unsafe {
				return Interop.NativeMethods.vkSetEvent (this.m, @event.m);
			}
		}

		public Result ResetEvent (Event @event)
		{
			unsafe {
				return Interop.NativeMethods.vkResetEvent (this.m, @event.m);
			}
		}

		public Result CreateQueryPool (QueryPoolCreateInfo CreateInfo, AllocationCallbacks Allocator, out QueryPool QueryPool)
		{
			unsafe {
				QueryPool = new QueryPool ();

				fixed (UInt64* ptrQueryPool = &QueryPool.m) {
					return Interop.NativeMethods.vkCreateQueryPool (this.m, CreateInfo.m, Allocator.m, ptrQueryPool);
				}
			}
		}

		public void DestroyQueryPool (QueryPool queryPool, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyQueryPool (this.m, queryPool.m, Allocator.m);
			}
		}

		public Result GetQueryPoolResults (QueryPool queryPool, UInt32 firstQuery, UInt32 queryCount, UIntPtr dataSize, IntPtr Data, DeviceSize stride, QueryResultFlags flags)
		{
			unsafe {
				return Interop.NativeMethods.vkGetQueryPoolResults (this.m, queryPool.m, firstQuery, queryCount, dataSize, Data, stride, flags);
			}
		}

		public Result CreateBuffer (BufferCreateInfo CreateInfo, AllocationCallbacks Allocator, out Buffer Buffer)
		{
			unsafe {
				Buffer = new Buffer ();

				fixed (UInt64* ptrBuffer = &Buffer.m) {
					return Interop.NativeMethods.vkCreateBuffer (this.m, CreateInfo.m, Allocator.m, ptrBuffer);
				}
			}
		}

		public void DestroyBuffer (Buffer buffer, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyBuffer (this.m, buffer.m, Allocator.m);
			}
		}

		public Result CreateBufferView (BufferViewCreateInfo CreateInfo, AllocationCallbacks Allocator, out BufferView View)
		{
			unsafe {
				View = new BufferView ();

				fixed (UInt64* ptrView = &View.m) {
					return Interop.NativeMethods.vkCreateBufferView (this.m, CreateInfo.m, Allocator.m, ptrView);
				}
			}
		}

		public void DestroyBufferView (BufferView bufferView, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyBufferView (this.m, bufferView.m, Allocator.m);
			}
		}

		public Result CreateImage (ImageCreateInfo CreateInfo, AllocationCallbacks Allocator, out Image Image)
		{
			unsafe {
				Image = new Image ();

				fixed (UInt64* ptrImage = &Image.m) {
					return Interop.NativeMethods.vkCreateImage (this.m, CreateInfo.m, Allocator.m, ptrImage);
				}
			}
		}

		public void DestroyImage (Image image, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyImage (this.m, image.m, Allocator.m);
			}
		}

		public void GetImageSubresourceLayout (Image image, ImageSubresource Subresource, out SubresourceLayout Layout)
		{
			unsafe {
				Layout = new SubresourceLayout ();
				Interop.NativeMethods.vkGetImageSubresourceLayout (this.m, image.m, Subresource.m, Layout.m);
			}
		}

		public Result CreateImageView (ImageViewCreateInfo CreateInfo, AllocationCallbacks Allocator, out ImageView View)
		{
			unsafe {
				View = new ImageView ();

				fixed (UInt64* ptrView = &View.m) {
					return Interop.NativeMethods.vkCreateImageView (this.m, CreateInfo.m, Allocator.m, ptrView);
				}
			}
		}

		public void DestroyImageView (ImageView imageView, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyImageView (this.m, imageView.m, Allocator.m);
			}
		}

		public Result CreateShaderModule (ShaderModuleCreateInfo CreateInfo, AllocationCallbacks Allocator, out ShaderModule ShaderModule)
		{
			unsafe {
				ShaderModule = new ShaderModule ();

				fixed (UInt64* ptrShaderModule = &ShaderModule.m) {
					return Interop.NativeMethods.vkCreateShaderModule (this.m, CreateInfo.m, Allocator.m, ptrShaderModule);
				}
			}
		}

		public void DestroyShaderModule (ShaderModule shaderModule, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyShaderModule (this.m, shaderModule.m, Allocator.m);
			}
		}

		public Result CreatePipelineCache (PipelineCacheCreateInfo CreateInfo, AllocationCallbacks Allocator, out PipelineCache PipelineCache)
		{
			unsafe {
				PipelineCache = new PipelineCache ();

				fixed (UInt64* ptrPipelineCache = &PipelineCache.m) {
					return Interop.NativeMethods.vkCreatePipelineCache (this.m, CreateInfo.m, Allocator.m, ptrPipelineCache);
				}
			}
		}

		public void DestroyPipelineCache (PipelineCache pipelineCache, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyPipelineCache (this.m, pipelineCache.m, Allocator.m);
			}
		}

		public Result GetPipelineCacheData (PipelineCache pipelineCache, out UIntPtr DataSize, IntPtr Data)
		{
			unsafe {
				fixed (UIntPtr* ptrDataSize = &DataSize) {
					return Interop.NativeMethods.vkGetPipelineCacheData (this.m, pipelineCache.m, ptrDataSize, Data);
				}
			}
		}

		public Result MergePipelineCaches (PipelineCache dstCache, UInt32 srcCacheCount, PipelineCache SrcCaches)
		{
			unsafe {
				SrcCaches = new PipelineCache ();

				fixed (UInt64* ptrSrcCaches = &SrcCaches.m) {
					return Interop.NativeMethods.vkMergePipelineCaches (this.m, dstCache.m, srcCacheCount, ptrSrcCaches);
				}
			}
		}

		public Result CreateGraphicsPipelines (PipelineCache pipelineCache, UInt32 createInfoCount, GraphicsPipelineCreateInfo CreateInfos, AllocationCallbacks Allocator, out Pipeline Pipelines)
		{
			unsafe {
				Pipelines = new Pipeline ();

				fixed (UInt64* ptrPipelines = &Pipelines.m) {
					return Interop.NativeMethods.vkCreateGraphicsPipelines (this.m, pipelineCache.m, createInfoCount, CreateInfos.m, Allocator.m, ptrPipelines);
				}
			}
		}

		public Result CreateComputePipelines (PipelineCache pipelineCache, UInt32 createInfoCount, ComputePipelineCreateInfo CreateInfos, AllocationCallbacks Allocator, out Pipeline Pipelines)
		{
			unsafe {
				Pipelines = new Pipeline ();

				fixed (UInt64* ptrPipelines = &Pipelines.m) {
					return Interop.NativeMethods.vkCreateComputePipelines (this.m, pipelineCache.m, createInfoCount, CreateInfos.m, Allocator.m, ptrPipelines);
				}
			}
		}

		public void DestroyPipeline (Pipeline pipeline, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyPipeline (this.m, pipeline.m, Allocator.m);
			}
		}

		public Result CreatePipelineLayout (PipelineLayoutCreateInfo CreateInfo, AllocationCallbacks Allocator, out PipelineLayout PipelineLayout)
		{
			unsafe {
				PipelineLayout = new PipelineLayout ();

				fixed (UInt64* ptrPipelineLayout = &PipelineLayout.m) {
					return Interop.NativeMethods.vkCreatePipelineLayout (this.m, CreateInfo.m, Allocator.m, ptrPipelineLayout);
				}
			}
		}

		public void DestroyPipelineLayout (PipelineLayout pipelineLayout, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyPipelineLayout (this.m, pipelineLayout.m, Allocator.m);
			}
		}

		public Result CreateSampler (SamplerCreateInfo CreateInfo, AllocationCallbacks Allocator, out Sampler Sampler)
		{
			unsafe {
				Sampler = new Sampler ();

				fixed (UInt64* ptrSampler = &Sampler.m) {
					return Interop.NativeMethods.vkCreateSampler (this.m, CreateInfo.m, Allocator.m, ptrSampler);
				}
			}
		}

		public void DestroySampler (Sampler sampler, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroySampler (this.m, sampler.m, Allocator.m);
			}
		}

		public Result CreateDescriptorSetLayout (DescriptorSetLayoutCreateInfo CreateInfo, AllocationCallbacks Allocator, out DescriptorSetLayout SetLayout)
		{
			unsafe {
				SetLayout = new DescriptorSetLayout ();

				fixed (UInt64* ptrSetLayout = &SetLayout.m) {
					return Interop.NativeMethods.vkCreateDescriptorSetLayout (this.m, CreateInfo.m, Allocator.m, ptrSetLayout);
				}
			}
		}

		public void DestroyDescriptorSetLayout (DescriptorSetLayout descriptorSetLayout, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyDescriptorSetLayout (this.m, descriptorSetLayout.m, Allocator.m);
			}
		}

		public Result CreateDescriptorPool (DescriptorPoolCreateInfo CreateInfo, AllocationCallbacks Allocator, out DescriptorPool DescriptorPool)
		{
			unsafe {
				DescriptorPool = new DescriptorPool ();

				fixed (UInt64* ptrDescriptorPool = &DescriptorPool.m) {
					return Interop.NativeMethods.vkCreateDescriptorPool (this.m, CreateInfo.m, Allocator.m, ptrDescriptorPool);
				}
			}
		}

		public void DestroyDescriptorPool (DescriptorPool descriptorPool, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyDescriptorPool (this.m, descriptorPool.m, Allocator.m);
			}
		}

		public Result ResetDescriptorPool (DescriptorPool descriptorPool, UInt32 flags)
		{
			unsafe {
				return Interop.NativeMethods.vkResetDescriptorPool (this.m, descriptorPool.m, flags);
			}
		}

		public Result AllocateDescriptorSets (DescriptorSetAllocateInfo AllocateInfo, out DescriptorSet DescriptorSets)
		{
			unsafe {
				DescriptorSets = new DescriptorSet ();

				fixed (UInt64* ptrDescriptorSets = &DescriptorSets.m) {
					return Interop.NativeMethods.vkAllocateDescriptorSets (this.m, AllocateInfo.m, ptrDescriptorSets);
				}
			}
		}

		public Result FreeDescriptorSets (DescriptorPool descriptorPool, UInt32 descriptorSetCount, DescriptorSet DescriptorSets)
		{
			unsafe {
				DescriptorSets = new DescriptorSet ();

				fixed (UInt64* ptrDescriptorSets = &DescriptorSets.m) {
					return Interop.NativeMethods.vkFreeDescriptorSets (this.m, descriptorPool.m, descriptorSetCount, ptrDescriptorSets);
				}
			}
		}

		public void UpdateDescriptorSets (UInt32 descriptorWriteCount, WriteDescriptorSet DescriptorWrites, UInt32 descriptorCopyCount, CopyDescriptorSet DescriptorCopies)
		{
			unsafe {
				Interop.NativeMethods.vkUpdateDescriptorSets (this.m, descriptorWriteCount, DescriptorWrites.m, descriptorCopyCount, DescriptorCopies.m);
			}
		}

		public Result CreateFramebuffer (FramebufferCreateInfo CreateInfo, AllocationCallbacks Allocator, out Framebuffer Framebuffer)
		{
			unsafe {
				Framebuffer = new Framebuffer ();

				fixed (UInt64* ptrFramebuffer = &Framebuffer.m) {
					return Interop.NativeMethods.vkCreateFramebuffer (this.m, CreateInfo.m, Allocator.m, ptrFramebuffer);
				}
			}
		}

		public void DestroyFramebuffer (Framebuffer framebuffer, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyFramebuffer (this.m, framebuffer.m, Allocator.m);
			}
		}

		public Result CreateRenderPass (RenderPassCreateInfo CreateInfo, AllocationCallbacks Allocator, out RenderPass RenderPass)
		{
			unsafe {
				RenderPass = new RenderPass ();

				fixed (UInt64* ptrRenderPass = &RenderPass.m) {
					return Interop.NativeMethods.vkCreateRenderPass (this.m, CreateInfo.m, Allocator.m, ptrRenderPass);
				}
			}
		}

		public void DestroyRenderPass (RenderPass renderPass, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyRenderPass (this.m, renderPass.m, Allocator.m);
			}
		}

		public void GetRenderAreaGranularity (RenderPass renderPass, out Extent2D Granularity)
		{
			unsafe {
				Granularity = new Extent2D ();
				Interop.NativeMethods.vkGetRenderAreaGranularity (this.m, renderPass.m, Granularity.m);
			}
		}

		public Result CreateCommandPool (CommandPoolCreateInfo CreateInfo, AllocationCallbacks Allocator, out CommandPool CommandPool)
		{
			unsafe {
				CommandPool = new CommandPool ();

				fixed (UInt64* ptrCommandPool = &CommandPool.m) {
					return Interop.NativeMethods.vkCreateCommandPool (this.m, CreateInfo.m, Allocator.m, ptrCommandPool);
				}
			}
		}

		public void DestroyCommandPool (CommandPool commandPool, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroyCommandPool (this.m, commandPool.m, Allocator.m);
			}
		}

		public Result ResetCommandPool (CommandPool commandPool, CommandPoolResetFlags flags)
		{
			unsafe {
				return Interop.NativeMethods.vkResetCommandPool (this.m, commandPool.m, flags);
			}
		}

		public Result AllocateCommandBuffers (CommandBufferAllocateInfo AllocateInfo, out CommandBuffer CommandBuffers)
		{
			unsafe {
				CommandBuffers = new CommandBuffer ();

				fixed (IntPtr* ptrCommandBuffers = &CommandBuffers.m) {
					return Interop.NativeMethods.vkAllocateCommandBuffers (this.m, AllocateInfo.m, ptrCommandBuffers);
				}
			}
		}

		public void FreeCommandBuffers (CommandPool commandPool, UInt32 commandBufferCount, CommandBuffer CommandBuffers)
		{
			unsafe {
				CommandBuffers = new CommandBuffer ();

				fixed (IntPtr* ptrCommandBuffers = &CommandBuffers.m) {
					Interop.NativeMethods.vkFreeCommandBuffers (this.m, commandPool.m, commandBufferCount, ptrCommandBuffers);
				}
			}
		}

		public Result CreateSharedSwapchainsKHR (UInt32 swapchainCount, SwapchainCreateInfoKhr CreateInfos, AllocationCallbacks Allocator, out SwapchainKhr Swapchains)
		{
			unsafe {
				Swapchains = new SwapchainKhr ();

				fixed (UInt64* ptrSwapchains = &Swapchains.m) {
					return Interop.NativeMethods.vkCreateSharedSwapchainsKHR (this.m, swapchainCount, CreateInfos.m, Allocator.m, ptrSwapchains);
				}
			}
		}

		public Result CreateSwapchainKHR (SwapchainCreateInfoKhr CreateInfo, AllocationCallbacks Allocator, out SwapchainKhr Swapchain)
		{
			unsafe {
				Swapchain = new SwapchainKhr ();

				fixed (UInt64* ptrSwapchain = &Swapchain.m) {
					return Interop.NativeMethods.vkCreateSwapchainKHR (this.m, CreateInfo.m, Allocator.m, ptrSwapchain);
				}
			}
		}

		public void DestroySwapchainKHR (SwapchainKhr swapchain, AllocationCallbacks Allocator)
		{
			unsafe {
				Interop.NativeMethods.vkDestroySwapchainKHR (this.m, swapchain.m, Allocator.m);
			}
		}

		public Result GetSwapchainImagesKHR (SwapchainKhr swapchain, out UInt32 SwapchainImageCount, out Image SwapchainImages)
		{
			unsafe {
				SwapchainImages = new Image ();

				fixed (UInt32* ptrSwapchainImageCount = &SwapchainImageCount) {
					fixed (UInt64* ptrSwapchainImages = &SwapchainImages.m) {
						return Interop.NativeMethods.vkGetSwapchainImagesKHR (this.m, swapchain.m, ptrSwapchainImageCount, ptrSwapchainImages);
					}
				}
			}
		}

		public Result AcquireNextImageKHR (SwapchainKhr swapchain, UInt64 timeout, Semaphore semaphore, Fence fence, out UInt32 ImageIndex)
		{
			unsafe {
				fixed (UInt32* ptrImageIndex = &ImageIndex) {
					return Interop.NativeMethods.vkAcquireNextImageKHR (this.m, swapchain.m, timeout, semaphore.m, fence.m, ptrImageIndex);
				}
			}
		}
	}

	public partial class Queue
	{
		internal IntPtr m;

		public Result Submit (UInt32 submitCount, SubmitInfo Submits, Fence fence)
		{
			unsafe {
				return Interop.NativeMethods.vkQueueSubmit (this.m, submitCount, Submits.m, fence.m);
			}
		}

		public Result WaitIdle ()
		{
			unsafe {
				return Interop.NativeMethods.vkQueueWaitIdle (this.m);
			}
		}

		public Result BindSparse (UInt32 bindInfoCount, BindSparseInfo BindInfo, Fence fence)
		{
			unsafe {
				return Interop.NativeMethods.vkQueueBindSparse (this.m, bindInfoCount, BindInfo.m, fence.m);
			}
		}

		public Result PresentKHR (PresentInfoKhr PresentInfo)
		{
			unsafe {
				return Interop.NativeMethods.vkQueuePresentKHR (this.m, PresentInfo.m);
			}
		}
	}

	public partial class CommandBuffer
	{
		internal IntPtr m;

		public Result Begin (CommandBufferBeginInfo BeginInfo)
		{
			unsafe {
				return Interop.NativeMethods.vkBeginCommandBuffer (this.m, BeginInfo.m);
			}
		}

		public Result End ()
		{
			unsafe {
				return Interop.NativeMethods.vkEndCommandBuffer (this.m);
			}
		}

		public Result Reset (CommandBufferResetFlags flags)
		{
			unsafe {
				return Interop.NativeMethods.vkResetCommandBuffer (this.m, flags);
			}
		}

		public void CmdBindPipeline (PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
		{
			unsafe {
				Interop.NativeMethods.vkCmdBindPipeline (this.m, pipelineBindPoint, pipeline.m);
			}
		}

		public void CmdSetViewport (UInt32 firstViewport, UInt32 viewportCount, Viewport Viewports)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetViewport (this.m, firstViewport, viewportCount, Viewports.m);
			}
		}

		public void CmdSetScissor (UInt32 firstScissor, UInt32 scissorCount, Rect2D Scissors)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetScissor (this.m, firstScissor, scissorCount, Scissors.m);
			}
		}

		public void CmdSetLineWidth (float lineWidth)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetLineWidth (this.m, lineWidth);
			}
		}

		public void CmdSetDepthBias (float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetDepthBias (this.m, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
			}
		}

		public void CmdSetBlendConstants (float blendConstants)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetBlendConstants (this.m, blendConstants);
			}
		}

		public void CmdSetDepthBounds (float minDepthBounds, float maxDepthBounds)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetDepthBounds (this.m, minDepthBounds, maxDepthBounds);
			}
		}

		public void CmdSetStencilCompareMask (StencilFaceFlags faceMask, UInt32 compareMask)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetStencilCompareMask (this.m, faceMask, compareMask);
			}
		}

		public void CmdSetStencilWriteMask (StencilFaceFlags faceMask, UInt32 writeMask)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetStencilWriteMask (this.m, faceMask, writeMask);
			}
		}

		public void CmdSetStencilReference (StencilFaceFlags faceMask, UInt32 reference)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetStencilReference (this.m, faceMask, reference);
			}
		}

		public void CmdBindDescriptorSets (PipelineBindPoint pipelineBindPoint, PipelineLayout layout, UInt32 firstSet, UInt32 descriptorSetCount, DescriptorSet DescriptorSets, UInt32 dynamicOffsetCount, UInt32 DynamicOffsets)
		{
			unsafe {
				DescriptorSets = new DescriptorSet ();

				fixed (UInt64* ptrDescriptorSets = &DescriptorSets.m) {
					Interop.NativeMethods.vkCmdBindDescriptorSets (this.m, pipelineBindPoint, layout.m, firstSet, descriptorSetCount, ptrDescriptorSets, dynamicOffsetCount, &DynamicOffsets);
				}
			}
		}

		public void CmdBindIndexBuffer (Buffer buffer, DeviceSize offset, IndexType indexType)
		{
			unsafe {
				Interop.NativeMethods.vkCmdBindIndexBuffer (this.m, buffer.m, offset, indexType);
			}
		}

		public void CmdBindVertexBuffers (UInt32 firstBinding, UInt32 bindingCount, Buffer Buffers, DeviceSize Offsets)
		{
			unsafe {
				Buffers = new Buffer ();

				fixed (UInt64* ptrBuffers = &Buffers.m) {
					Interop.NativeMethods.vkCmdBindVertexBuffers (this.m, firstBinding, bindingCount, ptrBuffers, &Offsets);
				}
			}
		}

		public void CmdDraw (UInt32 vertexCount, UInt32 instanceCount, UInt32 firstVertex, UInt32 firstInstance)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDraw (this.m, vertexCount, instanceCount, firstVertex, firstInstance);
			}
		}

		public void CmdDrawIndexed (UInt32 indexCount, UInt32 instanceCount, UInt32 firstIndex, Int32 vertexOffset, UInt32 firstInstance)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDrawIndexed (this.m, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
			}
		}

		public void CmdDrawIndirect (Buffer buffer, DeviceSize offset, UInt32 drawCount, UInt32 stride)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDrawIndirect (this.m, buffer.m, offset, drawCount, stride);
			}
		}

		public void CmdDrawIndexedIndirect (Buffer buffer, DeviceSize offset, UInt32 drawCount, UInt32 stride)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDrawIndexedIndirect (this.m, buffer.m, offset, drawCount, stride);
			}
		}

		public void CmdDispatch (UInt32 x, UInt32 y, UInt32 z)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDispatch (this.m, x, y, z);
			}
		}

		public void CmdDispatchIndirect (Buffer buffer, DeviceSize offset)
		{
			unsafe {
				Interop.NativeMethods.vkCmdDispatchIndirect (this.m, buffer.m, offset);
			}
		}

		public void CmdCopyBuffer (Buffer srcBuffer, Buffer dstBuffer, UInt32 regionCount, BufferCopy Regions)
		{
			unsafe {
				Interop.NativeMethods.vkCmdCopyBuffer (this.m, srcBuffer.m, dstBuffer.m, regionCount, Regions.m);
			}
		}

		public void CmdCopyImage (Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, UInt32 regionCount, ImageCopy Regions)
		{
			unsafe {
				Interop.NativeMethods.vkCmdCopyImage (this.m, srcImage.m, srcImageLayout, dstImage.m, dstImageLayout, regionCount, Regions.m);
			}
		}

		public void CmdBlitImage (Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, UInt32 regionCount, ImageBlit Regions, Filter filter)
		{
			unsafe {
				Interop.NativeMethods.vkCmdBlitImage (this.m, srcImage.m, srcImageLayout, dstImage.m, dstImageLayout, regionCount, Regions.m, filter);
			}
		}

		public void CmdCopyBufferToImage (Buffer srcBuffer, Image dstImage, ImageLayout dstImageLayout, UInt32 regionCount, BufferImageCopy Regions)
		{
			unsafe {
				Interop.NativeMethods.vkCmdCopyBufferToImage (this.m, srcBuffer.m, dstImage.m, dstImageLayout, regionCount, Regions.m);
			}
		}

		public void CmdCopyImageToBuffer (Image srcImage, ImageLayout srcImageLayout, Buffer dstBuffer, UInt32 regionCount, BufferImageCopy Regions)
		{
			unsafe {
				Interop.NativeMethods.vkCmdCopyImageToBuffer (this.m, srcImage.m, srcImageLayout, dstBuffer.m, regionCount, Regions.m);
			}
		}

		public void CmdUpdateBuffer (Buffer dstBuffer, DeviceSize dstOffset, DeviceSize dataSize, UInt32 Data)
		{
			unsafe {
				Interop.NativeMethods.vkCmdUpdateBuffer (this.m, dstBuffer.m, dstOffset, dataSize, &Data);
			}
		}

		public void CmdFillBuffer (Buffer dstBuffer, DeviceSize dstOffset, DeviceSize size, UInt32 data)
		{
			unsafe {
				Interop.NativeMethods.vkCmdFillBuffer (this.m, dstBuffer.m, dstOffset, size, data);
			}
		}

		public void CmdClearColorImage (Image image, ImageLayout imageLayout, ClearColorValue Color, UInt32 rangeCount, ImageSubresourceRange Ranges)
		{
			unsafe {
				Interop.NativeMethods.vkCmdClearColorImage (this.m, image.m, imageLayout, Color.m, rangeCount, Ranges.m);
			}
		}

		public void CmdClearDepthStencilImage (Image image, ImageLayout imageLayout, ClearDepthStencilValue DepthStencil, UInt32 rangeCount, ImageSubresourceRange Ranges)
		{
			unsafe {
				Interop.NativeMethods.vkCmdClearDepthStencilImage (this.m, image.m, imageLayout, DepthStencil.m, rangeCount, Ranges.m);
			}
		}

		public void CmdClearAttachments (UInt32 attachmentCount, ClearAttachment Attachments, UInt32 rectCount, ClearRect Rects)
		{
			unsafe {
				Interop.NativeMethods.vkCmdClearAttachments (this.m, attachmentCount, Attachments.m, rectCount, Rects.m);
			}
		}

		public void CmdResolveImage (Image srcImage, ImageLayout srcImageLayout, Image dstImage, ImageLayout dstImageLayout, UInt32 regionCount, ImageResolve Regions)
		{
			unsafe {
				Interop.NativeMethods.vkCmdResolveImage (this.m, srcImage.m, srcImageLayout, dstImage.m, dstImageLayout, regionCount, Regions.m);
			}
		}

		public void CmdSetEvent (Event @event, PipelineStageFlags stageMask)
		{
			unsafe {
				Interop.NativeMethods.vkCmdSetEvent (this.m, @event.m, stageMask);
			}
		}

		public void CmdResetEvent (Event @event, PipelineStageFlags stageMask)
		{
			unsafe {
				Interop.NativeMethods.vkCmdResetEvent (this.m, @event.m, stageMask);
			}
		}

		public void CmdWaitEvents (UInt32 eventCount, Event Events, PipelineStageFlags srcStageMask, PipelineStageFlags dstStageMask, UInt32 memoryBarrierCount, MemoryBarrier MemoryBarriers, UInt32 bufferMemoryBarrierCount, BufferMemoryBarrier BufferMemoryBarriers, UInt32 imageMemoryBarrierCount, ImageMemoryBarrier ImageMemoryBarriers)
		{
			unsafe {
				Events = new Event ();

				fixed (UInt64* ptrEvents = &Events.m) {
					Interop.NativeMethods.vkCmdWaitEvents (this.m, eventCount, ptrEvents, srcStageMask, dstStageMask, memoryBarrierCount, MemoryBarriers.m, bufferMemoryBarrierCount, BufferMemoryBarriers.m, imageMemoryBarrierCount, ImageMemoryBarriers.m);
				}
			}
		}

		public void CmdPipelineBarrier (PipelineStageFlags srcStageMask, PipelineStageFlags dstStageMask, DependencyFlags dependencyFlags, UInt32 memoryBarrierCount, MemoryBarrier MemoryBarriers, UInt32 bufferMemoryBarrierCount, BufferMemoryBarrier BufferMemoryBarriers, UInt32 imageMemoryBarrierCount, ImageMemoryBarrier ImageMemoryBarriers)
		{
			unsafe {
				Interop.NativeMethods.vkCmdPipelineBarrier (this.m, srcStageMask, dstStageMask, dependencyFlags, memoryBarrierCount, MemoryBarriers.m, bufferMemoryBarrierCount, BufferMemoryBarriers.m, imageMemoryBarrierCount, ImageMemoryBarriers.m);
			}
		}

		public void CmdBeginQuery (QueryPool queryPool, UInt32 query, QueryControlFlags flags)
		{
			unsafe {
				Interop.NativeMethods.vkCmdBeginQuery (this.m, queryPool.m, query, flags);
			}
		}

		public void CmdEndQuery (QueryPool queryPool, UInt32 query)
		{
			unsafe {
				Interop.NativeMethods.vkCmdEndQuery (this.m, queryPool.m, query);
			}
		}

		public void CmdResetQueryPool (QueryPool queryPool, UInt32 firstQuery, UInt32 queryCount)
		{
			unsafe {
				Interop.NativeMethods.vkCmdResetQueryPool (this.m, queryPool.m, firstQuery, queryCount);
			}
		}

		public void CmdWriteTimestamp (PipelineStageFlags pipelineStage, QueryPool queryPool, UInt32 query)
		{
			unsafe {
				Interop.NativeMethods.vkCmdWriteTimestamp (this.m, pipelineStage, queryPool.m, query);
			}
		}

		public void CmdCopyQueryPoolResults (QueryPool queryPool, UInt32 firstQuery, UInt32 queryCount, Buffer dstBuffer, DeviceSize dstOffset, DeviceSize stride, QueryResultFlags flags)
		{
			unsafe {
				Interop.NativeMethods.vkCmdCopyQueryPoolResults (this.m, queryPool.m, firstQuery, queryCount, dstBuffer.m, dstOffset, stride, flags);
			}
		}

		public void CmdPushConstants (PipelineLayout layout, ShaderStageFlags stageFlags, UInt32 offset, UInt32 size, IntPtr Values)
		{
			unsafe {
				Interop.NativeMethods.vkCmdPushConstants (this.m, layout.m, stageFlags, offset, size, Values);
			}
		}

		public void CmdBeginRenderPass (RenderPassBeginInfo RenderPassBegin, SubpassContents contents)
		{
			unsafe {
				Interop.NativeMethods.vkCmdBeginRenderPass (this.m, RenderPassBegin.m, contents);
			}
		}

		public void CmdNextSubpass (SubpassContents contents)
		{
			unsafe {
				Interop.NativeMethods.vkCmdNextSubpass (this.m, contents);
			}
		}

		public void CmdEndRenderPass ()
		{
			unsafe {
				Interop.NativeMethods.vkCmdEndRenderPass (this.m);
			}
		}

		public void CmdExecuteCommands (UInt32 commandBufferCount, CommandBuffer CommandBuffers)
		{
			unsafe {
				CommandBuffers = new CommandBuffer ();

				fixed (IntPtr* ptrCommandBuffers = &CommandBuffers.m) {
					Interop.NativeMethods.vkCmdExecuteCommands (this.m, commandBufferCount, ptrCommandBuffers);
				}
			}
		}
	}

	public partial class DeviceMemory
	{
		internal UInt64 m;
	}

	public partial class CommandPool
	{
		internal UInt64 m;
	}

	public partial class Buffer
	{
		internal UInt64 m;
	}

	public partial class BufferView
	{
		internal UInt64 m;
	}

	public partial class Image
	{
		internal UInt64 m;
	}

	public partial class ImageView
	{
		internal UInt64 m;
	}

	public partial class ShaderModule
	{
		internal UInt64 m;
	}

	public partial class Pipeline
	{
		internal UInt64 m;
	}

	public partial class PipelineLayout
	{
		internal UInt64 m;
	}

	public partial class Sampler
	{
		internal UInt64 m;
	}

	public partial class DescriptorSet
	{
		internal UInt64 m;
	}

	public partial class DescriptorSetLayout
	{
		internal UInt64 m;
	}

	public partial class DescriptorPool
	{
		internal UInt64 m;
	}

	public partial class Fence
	{
		internal UInt64 m;
	}

	public partial class Semaphore
	{
		internal UInt64 m;
	}

	public partial class Event
	{
		internal UInt64 m;
	}

	public partial class QueryPool
	{
		internal UInt64 m;
	}

	public partial class Framebuffer
	{
		internal UInt64 m;
	}

	public partial class RenderPass
	{
		internal UInt64 m;
	}

	public partial class PipelineCache
	{
		internal UInt64 m;
	}

	public partial class DisplayKhr
	{
		internal UInt64 m;
	}

	public partial class DisplayModeKhr
	{
		internal UInt64 m;
	}

	public partial class SurfaceKhr
	{
		internal UInt64 m;
	}

	public partial class SwapchainKhr
	{
		internal UInt64 m;
	}

	public partial class DebugReportCallbackExt
	{
		internal UInt64 m;
	}
}