﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Olive_OS_Web_Edition.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("_1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("_2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("_3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property _4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("_4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property apps() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("apps", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 
        '''&lt;html&gt;
        '''   &lt;head&gt;
        '''      &lt;title&gt;Calculator&lt;/title&gt;
        '''      &lt;script&gt;
        '''         //Displays the numbers (calculator display)
        '''         function dis(val)
        '''         {
        '''             document.getElementById(&quot;result&quot;).value+=val
        '''         }
        '''         //Lets javascript do the math and return the result
        '''         function solve()
        '''         {
        '''             var x = document.getElementById(&quot;result&quot;).value
        '''             var y = eval(x)
        '''             document.getElementById(&quot;result&quot;).value = y
        '''         }
        '''         //Cle [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property calc() As String
            Get
                Return ResourceManager.GetString("calc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property calculator() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("calculator", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property cliff() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("cliff", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property def() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("def", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You have failed 3
        '''password attemps. Olive 
        '''OS will now be disabled for
        '''5 minutes..
        '''</summary>
        Friend ReadOnly Property err() As String
            Get
                Return ResourceManager.GetString("err", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property error_snd() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("error_snd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property mountian() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("mountian", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;title&gt;Music Player&lt;/title&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''        &lt;p id=&quot;titlee&quot;&gt;Music Player&lt;/p&gt;
        '''        &lt;img id=&quot;play&quot; src=&quot;https://olivewebsoftware.github.io/idkbro/play.png&quot; onclick=&quot;playState()&quot;&gt;&lt;/img&gt;
        '''        &lt;img id=&quot;pause&quot; src=&quot;https://olivewebsoftware.github.io/idkbro/pause.png&quot; onclick=&quot;pauseState()&quot;&gt;&lt;/img&gt;
        '''        &lt;img id=&quot;stop&quot; src=&quot;https://olivewebsoftware.github.io/idkbro/stop.png&quot; onclick=&quot;stopState()&quot;&gt;&lt;/img&gt;
        '''        &lt;br&gt;
        '''        &lt;br&gt;
        '''        &lt;im [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property music() As String
            Get
                Return ResourceManager.GetString("music", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property music1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("music1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An internet connection
        '''was not detected. Some
        '''apps and features may not
        '''work properly..
        '''</summary>
        Friend ReadOnly Property neterror() As String
            Get
                Return ResourceManager.GetString("neterror", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property notepad() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("notepad", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;title&gt;Olive OS Web Image Viewer&lt;/title&gt;
        '''    &lt;/head&gt;
        '''    &lt;body style=&quot;background-color: black;&quot;&gt;
        '''        &lt;div class=&quot;layout&quot;&gt;
        '''            &lt;p id=&quot;pathname&quot;&gt;---&lt;/p&gt;
        '''            &lt;img id=&quot;refresh&quot; onclick=&quot;doAssign()&quot; width=&quot;43&quot; height=&quot;43&quot; src=&quot;https://olivewebsoftware.github.io/idkbro/r.png&quot;&gt;&lt;/img&gt;
        '''            &lt;img id=&quot;domail&quot; onclick=&quot;&quot; src=&quot;https://olivewebsoftware.github.io/idkbro/e.png&quot;&gt;&lt;/img&gt;
        '''            &lt;img id=&quot;orgin&quot; src=&quot;https://olivewebsoftware.git [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property photo() As String
            Get
                Return ResourceManager.GetString("photo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property rockwater() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("rockwater", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;title&gt;Online Code Editor&lt;/title&gt;
        '''        &lt;link rel=&quot;shortcut icon&quot; type=&quot;image/jpg&quot; href=&quot;tabimg.png&quot;/&gt;
        '''    &lt;/head&gt;
        '''&lt;body style=&quot;background-color: black;&quot;&gt;
        '''    &lt;p id=&quot;up2&quot;&gt;Olive OS Text Editor&lt;/p&gt;
        '''    &lt;button id=&quot;a&quot; onclick=&quot;save()&quot;&gt;Save...&lt;/button&gt;
        '''    &lt;br&gt;
        '''    &lt;br&gt;
        '''    &lt;textarea id=&quot;main-edit&quot; rows = &quot;1000&quot;&gt;&lt;/textarea&gt;
        '''    &lt;p id=&quot;sr&quot;&gt;0&lt;/p&gt;
        '''    &lt;style&gt;
        '''        #main-edit {
        '''            font-family: &apos;Courier New&apos;, monospace;
        '''            width: 100%;        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property textedit() As String
            Get
                Return ResourceManager.GetString("textedit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property vbexpressisdumb() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("vbexpressisdumb", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.IO.UnmanagedMemoryStream similar to System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property vol_adj() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("vol_adj", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!--(C) 2021 OliveWeb--&gt;
        '''&lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;title&gt;Wallpaper Chooser&lt;/title&gt;
        '''    &lt;/head&gt;
        '''    &lt;body style=&quot;background-color: lightblue;&quot;&gt;
        '''        &lt;h1 id=&quot;main&quot;&gt;Choose A Wallpaper&lt;/h1&gt;
        '''        &lt;img src=&quot;https://olivewebsoftware.github.io/idkbro/3.png&quot; onclick=&quot;setOne()&quot;&gt;
        '''        &lt;img src=&quot;https://olivewebsoftware.github.io/idkbro/2.png&quot; onclick=&quot;setTwo()&quot;&gt;
        '''        &lt;img src=&quot;https://olivewebsoftware.github.io/idkbro/1.png&quot; onclick=&quot;setThree()&quot;&gt;
        '''        &lt;p id=&quot;a&quot;&gt;0&lt;/p&gt;
        '''        [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property wallpaper() As String
            Get
                Return ResourceManager.GetString("wallpaper", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property web() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("web", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace
