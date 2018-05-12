// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
    public /* unmanaged */ unsafe struct ID2D1SvgDocument
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1SvgDocument* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1SvgDocument* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1SvgDocument* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1SvgDocument* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region Delegates
        /// <summary>Sets the size of the initial viewport.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetViewportSize(
            [In] ID2D1SvgDocument* This,
            [In, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize
        );

        /// <summary>Returns the size of the initial viewport.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetViewportSize(
            [In] ID2D1SvgDocument* This,
            [Out, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* pViewportSize
        );

        /// <summary>Sets the root element of the document. The root element must be an 'svg' element. If the element already exists within an svg tree, it is first removed.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetRoot(
            [In] ID2D1SvgDocument* This,
            [In] ID2D1SvgElement* root = null
        );

        /// <summary>Gets the root element of the document.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetRoot(
            [In] ID2D1SvgDocument* This,
            [Out] ID2D1SvgElement** root
        );

        /// <summary>Gets the SVG element with the specified ID. If the element cannot be found, the returned element will be null.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _FindElementById(
            [In] ID2D1SvgDocument* This,
            [In, ComAliasName("PCWSTR")] char* id,
            [Out] ID2D1SvgElement** svgElement
        );

        /// <summary>Serializes an element and its subtree to XML. The output XML is encoded as UTF-8.</summary>
        /// <param name="outputXmlStream">An output stream to contain the SVG XML subtree.</param>
        /// <param name="subtree">The root of the subtree. If null, the entire document is serialized.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Serialize(
            [In] ID2D1SvgDocument* This,
            [In] IStream* outputXmlStream,
            [In] ID2D1SvgElement* subtree = null
        );

        /// <summary>Deserializes a subtree from the stream. The stream must have only one root element, but that root element need not be an 'svg' element. The output element is not inserted into this document tree.</summary>
        /// <param name="inputXmlStream">An input stream containing the SVG XML subtree.</param>
        /// <param name="subtree">The root of the subtree.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Deserialize(
            [In] ID2D1SvgDocument* This,
            [In] IStream* inputXmlStream,
            [Out] ID2D1SvgElement** subtree
        );

        /// <summary>Creates a paint object which can be used to set the 'fill' or 'stroke' properties.</summary>
        /// <param name="color">The color used if the paintType is D2D1_SVG_PAINT_TYPE_COLOR.</param>
        /// <param name="id">The element id which acts as the paint server. This id is used if the paint type is D2D1_SVG_PAINT_TYPE_URI.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreatePaint(
            [In] ID2D1SvgDocument* This,
            [In] D2D1_SVG_PAINT_TYPE paintType,
            [In, Optional, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color,
            [In, Optional, ComAliasName("PCWSTR")] char* id,
            [Out] ID2D1SvgPaint** paint
        );

        /// <summary>Creates a dash array object which can be used to set the 'stroke-dasharray' property.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateStrokeDashArray(
            [In] ID2D1SvgDocument* This,
            [In, Optional, ComAliasName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes,
            [In, ComAliasName("UINT32")] uint dashesCount,
            [Out] ID2D1SvgStrokeDashArray** strokeDashArray
        );

        /// <summary>Creates a points object which can be used to set a 'points' attribute on a 'polygon' or 'polyline' element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreatePointCollection(
            [In] ID2D1SvgDocument* This,
            [In, Optional, ComAliasName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, ComAliasName("UINT32")] uint pointsCount,
            [Out] ID2D1SvgPointCollection** pointCollection
        );

        /// <summary>Creates a path data object which can be used to set a 'd' attribute on a 'path' element.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreatePathData(
            [In] ID2D1SvgDocument* This,
            [In, Optional, ComAliasName("FLOAT[]")] float* segmentData,
            [In, ComAliasName("UINT32")] uint segmentDataCount,
            [In, Optional, ComAliasName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands,
            [In, ComAliasName("UINT32")] uint commandsCount,
            [Out] ID2D1SvgPathData** pathData
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int SetViewportSize(
            [In, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_SetViewportSize>(lpVtbl->SetViewportSize)(
                    This,
                    viewportSize
                );
            }
        }

        public void GetViewportSize(
            [Out, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* pViewportSize
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                MarshalFunction<_GetViewportSize>(lpVtbl->GetViewportSize)(
                    This,
                    pViewportSize
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetRoot(
            [In] ID2D1SvgElement* root = null
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_SetRoot>(lpVtbl->SetRoot)(
                    This,
                    root
                );
            }
        }

        public void GetRoot(
            [Out] ID2D1SvgElement** root
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                MarshalFunction<_GetRoot>(lpVtbl->GetRoot)(
                    This,
                    root
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int FindElementById(
            [In, ComAliasName("PCWSTR")] char* id,
            [Out] ID2D1SvgElement** svgElement
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_FindElementById>(lpVtbl->FindElementById)(
                    This,
                    id,
                    svgElement
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Serialize(
            [In] IStream* outputXmlStream,
            [In] ID2D1SvgElement* subtree = null
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_Serialize>(lpVtbl->Serialize)(
                    This,
                    outputXmlStream,
                    subtree
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Deserialize(
            [In] IStream* inputXmlStream,
            [Out] ID2D1SvgElement** subtree
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_Deserialize>(lpVtbl->Deserialize)(
                    This,
                    inputXmlStream,
                    subtree
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreatePaint(
            [In] D2D1_SVG_PAINT_TYPE paintType,
            [In, Optional, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color,
            [In, Optional, ComAliasName("PCWSTR")] char* id,
            [Out] ID2D1SvgPaint** paint
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_CreatePaint>(lpVtbl->CreatePaint)(
                    This,
                    paintType,
                    color,
                    id,
                    paint
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateStrokeDashArray(
            [In, Optional, ComAliasName("D2D1_SVG_LENGTH[]")] D2D1_SVG_LENGTH* dashes,
            [In, ComAliasName("UINT32")] uint dashesCount,
            [Out] ID2D1SvgStrokeDashArray** strokeDashArray
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_CreateStrokeDashArray>(lpVtbl->CreateStrokeDashArray)(
                    This,
                    dashes,
                    dashesCount,
                    strokeDashArray
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreatePointCollection(
            [In, Optional, ComAliasName("D2D1_POINT_2F[]")] D2D_POINT_2F* points,
            [In, ComAliasName("UINT32")] uint pointsCount,
            [Out] ID2D1SvgPointCollection** pointCollection
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_CreatePointCollection>(lpVtbl->CreatePointCollection)(
                    This,
                    points,
                    pointsCount,
                    pointCollection
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreatePathData(
            [In, Optional, ComAliasName("FLOAT[]")] float* segmentData,
            [In, ComAliasName("UINT32")] uint segmentDataCount,
            [In, Optional, ComAliasName("D2D1_SVG_PATH_COMMAND[]")] D2D1_SVG_PATH_COMMAND* commands,
            [In, ComAliasName("UINT32")] uint commandsCount,
            [Out] ID2D1SvgPathData** pathData
        )
        {
            fixed (ID2D1SvgDocument* This = &this)
            {
                return MarshalFunction<_CreatePathData>(lpVtbl->CreatePathData)(
                    This,
                    segmentData,
                    segmentDataCount,
                    commands,
                    commandsCount,
                    pathData
                );
            }
        }
        #endregion

        #region Structs
        public /* unmanaged */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region Fields
            public IntPtr SetViewportSize;

            public IntPtr GetViewportSize;

            public IntPtr SetRoot;

            public IntPtr GetRoot;

            public IntPtr FindElementById;

            public IntPtr Serialize;

            public IntPtr Deserialize;

            public IntPtr CreatePaint;

            public IntPtr CreateStrokeDashArray;

            public IntPtr CreatePointCollection;

            public IntPtr CreatePathData;
            #endregion
        }
        #endregion
    }
}
