// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace AssimpNet.Unmanaged
{
    /// <summary>Helper structure to describe a virtual camera.</summary>
    /// <remarks>
    /// <para>Cameras have a representation in the node graph and can be animated.</para>
    /// <para>An important aspect is that the camera itself is also part of the</para>
    /// <para>scene-graph. This means, any values such as the look-at vector are not</para>
    /// <para>*absolute*, they'rerelativeto the coordinate system defined</para>
    /// <para>by the node which corresponds to the camera. This allows for camera</para>
    /// <para>animations. For static cameras parameters like the 'look-at' or 'up' vectors</para>
    /// <para>are usually specified directly in aiCamera, but beware, they could also</para>
    /// <para>be encoded in the node transformation. The following (pseudo)code sample</para>
    /// <para>shows how to do it:</para>
    /// <para>some file formats (such as 3DS, ASE) export a &quot;target point&quot; -</para>
    /// <para>the point the camera is looking at (it can even be animated). Assimp</para>
    /// <para>writes the target point as a subnode of the camera's main node,</para>
    /// <para>called &quot;&lt;camName&gt;.Target&quot;. However this is just additional information</para>
    /// <para>then the transformation tracks of the camera main node make the</para>
    /// <para>camera already look in the right direction.</para>
    /// </remarks>
    public unsafe partial class Camera : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 1084)]
        public partial struct __Internal
        {
            internal global::AssimpNet.Unmanaged.String.__Internal mName;
            internal global::System.Numerics.Vector3 mPosition;
            internal global::System.Numerics.Vector3 mUp;
            internal global::System.Numerics.Vector3 mLookAt;
            internal float mHorizontalFOV;
            internal float mClipPlaneNear;
            internal float mClipPlaneFar;
            internal float mAspect;
            internal float mOrthographicWidth;
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.Camera> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AssimpNet.Unmanaged.Camera>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::AssimpNet.Unmanaged.Camera managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::AssimpNet.Unmanaged.Camera managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Camera __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Camera(native.ToPointer(), skipVTables);
        }

        internal static Camera __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Camera)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Camera __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Camera(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Camera(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Camera(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>The name of the camera.</summary>
        /// <remarks>
        /// <para>There must be a node in the scenegraph with the same name.</para>
        /// <para>This node specifies the position of the camera in the scene</para>
        /// <para>hierarchy and can be animated.</para>
        /// </remarks>
        public global::AssimpNet.Unmanaged.String MName
        {
            get
            {
                return global::AssimpNet.Unmanaged.String.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->mName));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((__Internal*)__Instance)->mName = *(global::AssimpNet.Unmanaged.String.__Internal*) value.__Instance;
            }
        }

        /// <summary>
        /// <para>Position of the camera relative to the coordinate space</para>
        /// <para>defined by the corresponding node.</para>
        /// </summary>
        /// <remarks>The default value is 0|0|0.</remarks>
        public global::System.Numerics.Vector3 MPosition
        {
            get
            {
                return ((__Internal*)__Instance)->mPosition;
            }

            set
            {
                ((__Internal*)__Instance)->mPosition = value;
            }
        }

        /// <summary>
        /// <para>'Up' - vector of the camera coordinate system relative to</para>
        /// <para>the coordinate space defined by the corresponding node.</para>
        /// </summary>
        /// <remarks>
        /// <para>The 'right' vector of the camera coordinate system is</para>
        /// <para>the cross product of  the up and lookAt vectors.</para>
        /// <para>The default value is 0|1|0. The vector</para>
        /// <para>may be normalized, but it needn't.</para>
        /// </remarks>
        public global::System.Numerics.Vector3 MUp
        {
            get
            {
                return ((__Internal*)__Instance)->mUp;
            }

            set
            {
                ((__Internal*)__Instance)->mUp = value;
            }
        }

        /// <summary>
        /// <para>'LookAt' - vector of the camera coordinate system relative to</para>
        /// <para>the coordinate space defined by the corresponding node.</para>
        /// </summary>
        /// <remarks>
        /// <para>This is the viewing direction of the user.</para>
        /// <para>The default value is 0|0|1. The vector</para>
        /// <para>may be normalized, but it needn't.</para>
        /// </remarks>
        public global::System.Numerics.Vector3 MLookAt
        {
            get
            {
                return ((__Internal*)__Instance)->mLookAt;
            }

            set
            {
                ((__Internal*)__Instance)->mLookAt = value;
            }
        }

        /// <summary>Horizontal field of view angle, in radians.</summary>
        /// <remarks>
        /// <para>The field of view angle is the angle between the center</para>
        /// <para>line of the screen and the left or right border.</para>
        /// <para>The default value is 1/4PI.</para>
        /// </remarks>
        public float MHorizontalFOV
        {
            get
            {
                return ((__Internal*)__Instance)->mHorizontalFOV;
            }

            set
            {
                ((__Internal*)__Instance)->mHorizontalFOV = value;
            }
        }

        /// <summary>Distance of the near clipping plane from the camera.</summary>
        /// <remarks>
        /// <para>The value may not be 0.f (for arithmetic reasons to prevent</para>
        /// <para>a division through zero). The default value is 0.1f.</para>
        /// </remarks>
        public float MClipPlaneNear
        {
            get
            {
                return ((__Internal*)__Instance)->mClipPlaneNear;
            }

            set
            {
                ((__Internal*)__Instance)->mClipPlaneNear = value;
            }
        }

        /// <summary>Distance of the far clipping plane from the camera.</summary>
        /// <remarks>
        /// <para>The far clipping plane must, of course, be further away than the</para>
        /// <para>near clipping plane. The default value is 1000.f. The ratio</para>
        /// <para>between the near and the far plane should not be too</para>
        /// <para>large (between 1000-10000 should be ok) to avoid floating-point</para>
        /// <para>inaccuracies which could lead to z-fighting.</para>
        /// </remarks>
        public float MClipPlaneFar
        {
            get
            {
                return ((__Internal*)__Instance)->mClipPlaneFar;
            }

            set
            {
                ((__Internal*)__Instance)->mClipPlaneFar = value;
            }
        }

        /// <summary>Screen aspect ratio.</summary>
        /// <remarks>
        /// <para>This is the ration between the width and the height of the</para>
        /// <para>screen. Typical values are 4/3, 1/2 or 1/1. This value is</para>
        /// <para>0 if the aspect ratio is not defined in the source file.</para>
        /// <para>0 is also the default value.</para>
        /// </remarks>
        public float MAspect
        {
            get
            {
                return ((__Internal*)__Instance)->mAspect;
            }

            set
            {
                ((__Internal*)__Instance)->mAspect = value;
            }
        }

        /// <summary>Half horizontal orthographic width, in scene units.</summary>
        /// <remarks>
        /// <para>The orthographic width specifies the half width of the</para>
        /// <para>orthographic view box. If non-zero the camera is</para>
        /// <para>orthographic and the mAspect should define to the</para>
        /// <para>ratio between the orthographic width and height</para>
        /// <para>and mHorizontalFOV should be set to 0.</para>
        /// <para>The default value is 0 (not orthographic).</para>
        /// </remarks>
        public float MOrthographicWidth
        {
            get
            {
                return ((__Internal*)__Instance)->mOrthographicWidth;
            }

            set
            {
                ((__Internal*)__Instance)->mOrthographicWidth = value;
            }
        }
    }
}
