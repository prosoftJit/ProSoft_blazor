using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.IO;
using System.Linq.Expressions;
using System.Data.Entity;
//using System.Data.Entity.Validation;
using System.Web;
//using System.Web.Helpers;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
//using System.Data.Entity.Infrastructure;
using System.Collections;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
//using System.Web.UI.WebControls;
//using System.Web.WebPages.Html;
using System.Reflection.Emit;
//using System.Web.Mvc.Html;
//using System.Runtime.Remoting.Messaging;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using static System.Collections.Specialized.BitVector32;
using System.Security.Policy;
//using System.Web.Routing;
using System.Dynamic;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Encodings.Web;
using ProSoft.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Fast.Components.FluentUI;

namespace System
{
    public static class SystemExtensions
    {
        public enum MimeTypes
        {
            [Description("application/postscript")]
            ai,
            [Description("audio/x-aiff")]
            aif,
            [Description("audio/x-aiff")]
            aifc,
            [Description("audio/x-aiff")]
            aiff,
            [Description("text/plain")]
            asc,
            [Description("application/atom+xml")]
            atom,
            [Description("audio/basic")]
            au,
            [Description("video/x-msvideo")]
            avi,
            [Description("application/x-bcpio")]
            bcpio,
            [Description("application/octet-stream")]
            bin,
            [Description("image/bmp")]
            bmp,
            [Description("application/x-netcdf")]
            cdf,
            [Description("image/cgm")]
            cgm,
            [Description("application/octet-stream")]
            @class,
            [Description("application/x-cpio")]
            cpio,
            [Description("application/mac-compactpro")]
            cpt,
            [Description("application/x-csh")]
            csh,
            [Description("text/css")]
            css,
            [Description("application/x-director")]
            dcr,
            [Description("video/x-dv")]
            dif,
            [Description("application/x-director")]
            dir,
            [Description("image/vnd.djvu")]
            djv,
            [Description("image/vnd.djvu")]
            djvu,
            [Description("application/octet-stream")]
            dll,
            [Description("application/octet-stream")]
            dmg,
            [Description("application/octet-stream")]
            dms,
            [Description("application/msword")]
            doc,
            [Description("application/xml-dtd")]
            dtd,
            [Description("video/x-dv")]
            dv,
            [Description("application/x-dvi")]
            dvi,
            [Description("application/x-director")]
            dxr,
            [Description("application/postscript")]
            eps,
            [Description("text/x-setext")]
            etx,
            [Description("application/octet-stream")]
            exe,
            [Description("application/andrew-inset")]
            ez,
            [Description("image/gif")]
            gif,
            [Description("application/srgs")]
            gram,
            [Description("application/srgs+xml")]
            grxml,
            [Description("application/x-gtar")]
            gtar,
            [Description("application/x-hdf")]
            hdf,
            [Description("application/mac-binhex40")]
            hqx,
            [Description("text/html")]
            htm,
            [Description("text/html")]
            html,
            [Description("x-conference/x-cooltalk")]
            ice,
            [Description("image/x-icon")]
            ico,
            [Description("text/calendar")]
            ics,
            [Description("image/ief")]
            ief,
            [Description("text/calendar")]
            ifb,
            [Description("model/iges")]
            iges,
            [Description("model/iges")]
            igs,
            [Description("application/x-java-jnlp-file")]
            jnlp,
            [Description("image/jp2")]
            jp2,
            [Description("image/jpeg")]
            jpe,
            [Description("image/jpeg")]
            jpeg,
            [Description("image/jpeg")]
            jpg,
            [Description("application/x-javascript")]
            js,
            [Description("audio/midi")]
            kar,
            [Description("application/x-latex")]
            latex,
            [Description("application/octet-stream")]
            lha,
            [Description("application/octet-stream")]
            lzh,
            [Description("audio/x-mpegurl")]
            m3u,
            [Description("audio/mp4a-latm")]
            m4a,
            [Description("audio/mp4a-latm")]
            m4b,
            [Description("audio/mp4a-latm")]
            m4p,
            [Description("video/vnd.mpegurl")]
            m4u,
            [Description("video/x-m4v")]
            m4v,
            [Description("image/x-macpaint")]
            mac,
            [Description("application/x-troff-man")]
            man,
            [Description("application/mathml+xml")]
            mathml,
            [Description("application/x-troff-me")]
            me,
            [Description("model/mesh")]
            mesh,
            [Description("audio/midi")]
            mid,
            [Description("audio/midi")]
            midi,
            [Description("application/vnd.mif")]
            mif,
            [Description("video/quicktime")]
            mov,
            [Description("video/x-sgi-movie")]
            movie,
            [Description("audio/mpeg")]
            mp2,
            [Description("audio/mpeg")]
            mp3,
            [Description("video/mp4")]
            mp4,
            [Description("video/mpeg")]
            mpe,
            [Description("video/mpeg")]
            mpeg,
            [Description("video/mpeg")]
            mpg,
            [Description("audio/mpeg")]
            mpga,
            [Description("application/x-troff-ms")]
            ms,
            [Description("model/mesh")]
            msh,
            [Description("video/vnd.mpegurl")]
            mxu,
            [Description("application/x-netcdf")]
            nc,
            [Description("application/oda")]
            oda,
            [Description("application/ogg")]
            ogg,
            [Description("image/x-portable-bitmap")]
            pbm,
            [Description("image/pict")]
            pct,
            [Description("chemical/x-pdb")]
            pdb,
            [Description("application/pdf")]
            pdf,
            [Description("image/x-portable-graymap")]
            pgm,
            [Description("application/x-chess-pgn")]
            pgn,
            [Description("image/pict")]
            pic,
            [Description("image/pict")]
            pict,
            [Description("image/png")]
            png,
            [Description("image/x-portable-anymap")]
            pnm,
            [Description("image/x-macpaint")]
            pnt,
            [Description("image/x-macpaint")]
            pntg,
            [Description("image/x-portable-pixmap")]
            ppm,
            [Description("application/vnd.ms-powerpoint")]
            ppt,
            [Description("application/postscript")]
            ps,
            [Description("video/quicktime")]
            qt,
            [Description("image/x-quicktime")]
            qti,
            [Description("image/x-quicktime")]
            qtif,
            [Description("audio/x-pn-realaudio")]
            ra,
            [Description("audio/x-pn-realaudio")]
            ram,
            [Description("image/x-cmu-raster")]
            ras,
            [Description("application/rdf+xml")]
            rdf,
            [Description("image/x-rgb")]
            rgb,
            [Description("application/vnd.rn-realmedia")]
            rm,
            [Description("application/x-troff")]
            roff,
            [Description("text/rtf")]
            rtf,
            [Description("text/richtext")]
            rtx,
            [Description("text/sgml")]
            sgm,
            [Description("text/sgml")]
            sgml,
            [Description("application/x-sh")]
            sh,
            [Description("application/x-shar")]
            shar,
            [Description("model/mesh")]
            silo,
            [Description("application/x-stuffit")]
            sit,
            [Description("application/x-koan")]
            skd,
            [Description("application/x-koan")]
            skm,
            [Description("application/x-koan")]
            skp,
            [Description("application/x-koan")]
            skt,
            [Description("application/smil")]
            smi,
            [Description("application/smil")]
            smil,
            [Description("audio/basic")]
            snd,
            [Description("application/octet-stream")]
            so,
            [Description("application/x-futuresplash")]
            spl,
            [Description("application/x-wais-source")]
            src,
            [Description("application/x-sv4cpio")]
            sv4cpio,
            [Description("application/x-sv4crc")]
            sv4crc,
            [Description("image/svg+xml")]
            svg,
            [Description("application/x-shockwave-flash")]
            swf,
            [Description("application/x-troff")]
            t,
            [Description("application/x-tar")]
            tar,
            [Description("application/x-tcl")]
            tcl,
            [Description("application/x-tex")]
            tex,
            [Description("application/x-texinfo")]
            texi,
            [Description("application/x-texinfo")]
            texinfo,
            [Description("image/tiff")]
            tif,
            [Description("image/tiff")]
            tiff,
            [Description("application/x-troff")]
            tr,
            [Description("text/tab-separated-values")]
            tsv,
            [Description("text/plain")]
            txt,
            [Description("application/x-ustar")]
            ustar,
            [Description("application/x-cdlink")]
            vcd,
            [Description("model/vrml")]
            vrml,
            [Description("application/voicexml+xml")]
            vxml,
            [Description("audio/x-wav")]
            wav,
            [Description("image/vnd.wap.wbmp")]
            wbmp,
            [Description("application/vnd.wap.wbxml")]
            wbmxl,
            [Description("text/vnd.wap.wml")]
            wml,
            [Description("application/vnd.wap.wmlc")]
            wmlc,
            [Description("text/vnd.wap.wmlscript")]
            wmls,
            [Description("application/vnd.wap.wmlscriptc")]
            wmlsc,
            [Description("model/vrml")]
            wrl,
            [Description("image/x-xbitmap")]
            xbm,
            [Description("application/xhtml+xml")]
            xht,
            [Description("application/xhtml+xml")]
            xhtml,
            [Description("application/vnd.ms-excel")]
            xls,
            [Description("application/xml")]
            xml,
            [Description("image/x-xpixmap")]
            xpm,
            [Description("application/xml")]
            xsl,
            [Description("application/xslt+xml")]
            xslt,
            [Description("application/vnd.mozilla.xul+xml")]
            xul,
            [Description("image/x-xwindowdump")]
            xwd,
            [Description("chemical/x-xyz")]
            xyz,
            [Description("application/zip")]
            zip
        }

        public static string? GetMimeType(this string filename)
        {
            string ext = System.IO.Path.GetExtension(filename).Substring(1);
            MimeTypes mt;
            if (Enum.TryParse<MimeTypes>(ext, out mt))
                return mt.GetEnumDescription();
            else
                return null;
        }

        public static string Format(this string str, params object[] pars)
        {
            if (str != null)
                return string.Format(str, pars);
            return string.Empty;
        }

        public static string? GetEnumDescription(this Enum value)
        {
            FieldInfo? fi = value.GetType().GetField(value.ToString());

            if (fi == null)
                return null;

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
            {
                DisplayAttribute[] dattr =
                    (DisplayAttribute[])fi.GetCustomAttributes(
                    typeof(DisplayAttribute),
                    false);

                if (dattr != null && dattr.Length > 0)
                    return dattr[0].Name;
            }
            return value.ToString();
        }

        public static T? Attribute<T>(this Type type, string propertyName) where T : Attribute //Hint: Change the method signature and input paramter to use the type parameter T
        {
            PropertyInfo? pi = type.GetProperty(propertyName);
            if (pi != null)
                return pi.GetCustomAttributes<T>().FirstOrDefault();
            else
                return null;
        }

        // get description from enum
        public static T? Attribute<T>(this Type type) where T : Attribute //Hint: Change the method signature and input paramter to use the type parameter T
        {
            var attrs = type.GetCustomAttributes(typeof(T), true);
            T? attr = attrs.FirstOrDefault() as T;
            return attr;
        }
        public static T? Attribute<T>(this Enum generic) where T : Attribute
        {
            Type genericType = generic.GetType();
            System.Reflection.MemberInfo[] memberInfo = genericType.GetMember(generic.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(T), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((T)_Attribs.ElementAt(0));
                }
            }
            return null;
        }

        /// <summary>
        ///     A generic extension method that aids in reflecting 
        ///     and retrieving any attribute that is applied to an `Enum`.
        /// </summary>
        public static TAttribute? GetAttribute<TAttribute>(this Enum enumValue)
                where TAttribute : Attribute
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<TAttribute>();
        }
    }

    public static class DateTimeExtensions
    {
        public static string? AsShortDateString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            else
                return ((DateTime)dateTime).ToShortDateString();
        }
        public static string? AsYMDString(this DateTime? dateTime)
        {
            if (dateTime == null)
                return null;
            else
                return ((DateTime)dateTime).ToString("yyyy-MM-dd");
        }
        public static string AsYMDString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
        public static string? AsString(this DateTime? dateTime, string? format = null)
        {
            if (dateTime == null)
                return null;
            else
                if (string.IsNullOrEmpty(format))
                return ((DateTime)dateTime).ToString();
            else
                return ((DateTime)dateTime).ToString(format);
        }
    }
}

namespace System.Data.Entity
{
    public static class SystemDataEntity
    {
        public static void WriteEdmx(this DbContext context, string writePath)
        {
            //https : / / stackoverflow.com/questions/40956330/how-to-generate-class-diagram-from-models-in-ef-core
        }
    }

}

namespace System.Linq
{
    public static class LinqExtensios
    {
        public static IEnumerable<T> Except<T>(this IEnumerable<T> items, Func<T, bool> except)
        {
            foreach (T item in items)
                if (!except(item))
                    yield return item;
        }
        public static IEnumerable<T> Parents<T>(this T item, Func<T, T> parent)
        {
            T i = item;
            var nodes = new Stack<T>();
            while (i != null)
            {
                nodes.Push(i);
                i = parent(i);
            }
            return nodes;
        }
        public static IEnumerable<T> Descendants<T>(this T root, Func<T, IEnumerable<T>> childs)
        {
            var nodes = new Queue<T>(new[] { root });
            while (nodes.Any())
            {
                T node = nodes.Dequeue();
                yield return node;
                IEnumerable<T> c = childs(node);
                if (c != null)
                    foreach (T n in c) nodes.Enqueue(n);
            }
        }

        // public static IQueryable<TSource>? OfType<TSource>(this IQueryable<TSource> queryable, Type runtimeType)
        // {
        //     var method = typeof(Queryable).GetMethod(nameof(Queryable.OfType));
        //     var generic = method?.MakeGenericMethod(new[] { runtimeType });
        //     var ret = (IQueryable<TSource>)generic?.Invoke(null, new[] { queryable });
        //     return ret;
        // }
        // public static int IndexOf<T>(this IEnumerable<T> lista, T targetValue)
        // {
        //     return lista.Select((value, index) => new { value, index })
        //                 .Where(pair => pair.value.Equals(targetValue))
        //                 .Select(pair => pair.index + 1)
        //                 .FirstOrDefault() - 1;
        // }
    }
}

namespace System.Web
{

}

namespace System.Collections.Generic
{
    public static class SystemCollectionsGenericExtensions
    {
        public static string Join(this IEnumerable<string> items, string separator, string? lastseprator = null)
        {
            if (items.Count() == 0) return "";
            if (items.Count() == 1) return items.ElementAt(0);

            if (lastseprator == null)
            {
                lastseprator = separator;
            }

            string ret = "";
            string[] itm = items.ToArray();
            for (int i = 0; i < items.Count() - 2; i++)
            {
                ret += itm[i];
                ret += separator;
            }
            if (itm.Length > 1)
            {
                ret += itm[itm.Length - 2] + lastseprator + itm[itm.Length - 1];
            }
            return ret;
        }

    }
}

namespace System
{
    public class MySelection<T>
    {
        public MySelection(string text, T value)
        {
            this.Text = text;
            this.Value = value;
        }
        public string Text { get; set; }
        public T Value { get; set; }
    }

    public static class MyExtension
    {





        //public static EntityType GetCSpaceEntityType<T>(this MetadataWorkspace workspace) 
        //{ 
        //    if (workspace == null)  
        //        throw new ArgumentNullException("workspace"); 
        //    // Make sure the assembly for "T" is loaded 
        //    workspace.LoadFromAssembly(typeof(T).Assembly); 
        //    // Try to get the ospace type and if that is found 
        //    // look for the cspace type too. 
        //    EntityType ospaceEntityType = null; 
        //    StructuralType cspaceEntityType = null; 
        //    if (workspace.TryGetItem<EntityType>( 
        //        typeof(T).FullName,  
        //        DataSpace.OSpace, 
        //        out ospaceEntityType)) 
        //    { 
        //        if (workspace.TryGetEdmSpaceType( 
        //            ospaceEntityType, 
        //            out cspaceEntityType)) 
        //        { 
        //            return cspaceEntityType as EntityType; 
        //        } 
        //    } 
        //    return null; 
        //}

        //public static T GetId<T, K>(this ObjectQuery<T> query, K key) 
        //{ 
        //    //Get the EntityType 
        //    EntityType entityType = query.Context.MetadataWorkspace.GetCSpaceEntityType<T>(); 

        //    if (entityType.KeyMembers.Count != 1) 
        //        throw new Exception("You need to pass all the keys"); 

        //    //Build the ESQL 
        //    string eSQL = string.Format("it.{0} = @{0}", 
        //                                entityType.KeyMembers[0].Name);

        //    try
        //    {
        //        //Execute the query 
        //        return query.Where(
        //            eSQL,
        //            new ObjectParameter(entityType.KeyMembers[0].Name, key)
        //        ).First();
        //    }
        //    catch {
        //        return default(T);
        //    }
        //}

        //public static T As<T>(this object obj, T defaultValue)
        //{
        //    Type nt = typeof(T);
        //    return (T)Convert.ChangeType(obj, nt);
        //}

        //public static T Entity<T>(this HttpRequestBase request, ObjectQuery<T> lista, string requestStr) {
        //    long id = request[requestStr].As<long>(-1);
        //    return lista.GetId<T, long>(id);
        //}

        //public static System.Data.EntityClient.EntityConnection BuildEntityConnection(string dbFileName, string resourceData, string password) {

        //  string dataSource = @"Data Source=|DataDirectory|" + "\\" + dbFileName;

        //  System.Data.EntityClient.EntityConnectionStringBuilder entityBuilder = new System.Data.EntityClient.EntityConnectionStringBuilder();

        //  //entityBuilder.Metadata = "res://*/App_Code.EmpModel.csdl|res://*/App_Code.EmpModel.ssdl|res://*/App_Code.EmpModel.msl";

        //  entityBuilder.Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", resourceData);



        //  entityBuilder.Provider = "System.Data.SqlServerCe.4.0";

        //  if (String.IsNullOrEmpty(password)) {
        //    entityBuilder.ProviderConnectionString = dataSource;
        //  } else {
        //    entityBuilder.ProviderConnectionString = dataSource + ";Password=" + password;
        //  }
        //  System.Data.EntityClient.EntityConnection con = new System.Data.EntityClient.EntityConnection();

        //    con.ConnectionString = entityBuilder.ToString();
        //    con.Open();
        //    return con;
        //}

   
        //public static Type[] Subclasses(this Type tipo) {
        //    var tipos = AppDomain.CurrentDomain.GetAssemblies().SelectMany(k=> {
        //        Type[] ret = null;
        //        try { 
        //            ret = k.GetTypes();
        //        } catch (Exception ex) {
        //            return null;
        //        }
        //        return ret;
        //    }).Where(k=>k != null);
        //    var tp = tipos.Where(k=>k.IsSubclassOf(tipo) && !k.IsAbstract);
        //    return tp.OrderBy(k=>k.Description()).ToArray();
        //}




        ///// <summary>
        ///// Retorna uma descrição curta, em poucas letras, que pode ser usada como identificador único da classe
        ///// </summary>
        ///// <param name="type"></param>
        ///// <returns></returns>
        //public static string SelectId(this Type type) {
        //    SelectId si = type.GetCustomAttributes(typeof(SelectId), true).FirstOrDefault() as SelectId;
        //    if (si != null)
        //        return si.Id;
        //    else
        //        return null;
        //}
        //public static string SendEmail(string destEmail, string assunto, string corpo)
        //{
        //    string errorMessage = null;
        //    try
        //    {
        //        // Initialize WebMail helper
        //        WebMail.SmtpServer = "smtp-mail.outlook.com";
        //        WebMail.SmtpPort = 587;
        //        WebMail.EnableSsl = true;
        //        WebMail.UserName = "camaraivora@hotmail.com";
        //        WebMail.Password = "presidente";
        //        WebMail.From = "camaraivora@hotmail.com";

        //        // Send email
        //        WebMail.Send(to: destEmail,
        //            subject: assunto,
        //            body: corpo,
        //            isBodyHtml: true
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        errorMessage = ex.Message;
        //    }
        //    return errorMessage;
        //}

    }
    /*
    public static class HtmlHelpers {
        public static HtmlString ValidationSummary(this HtmlHelper helper)
        {
            return helper.Validation("Validation");
        }
        public static HtmlString Validation(this HtmlHelper helper, string message, string tipo = "info")
        {
            string s = "";
            if (helper != null && helper.ValidationSummary() != null)
            {
                s += helper.ValidationSummary().ToHtmlString();
            }
            if (message != null)
            {
                s += string.Format("<p class=\"message {0}\">{1}</p>", tipo, message);
            }
            return new HtmlString(s);
        }
        // HTMLAttributes: new { value = "teste", id = "aid", cssclass = "classe", onclick = "asfd";
        public static HtmlString Button(this HtmlHelper helper, object HTMLAttributes = null)
        {
            string s = ObjectToHTMLAttributes(HTMLAttributes);
            return new HtmlString("<Input type=\"button\"" + s + "/>");
        }
        public static HtmlString Button(this HtmlHelper helper, string name, string cssclass = null, object HTMLAttributes = null)
        {
            string s = ObjectToHTMLAttributes(HTMLAttributes);

            if (cssclass == null)
            {
                cssclass = "";
            }
            else
            {
                cssclass = " class=\"" + cssclass + "\"";
            }

            return new HtmlString("<Input type=\"button\" name=\"" + name + "\"" + cssclass + " " + s + "/>");
        }
        public static HtmlString DropDownListFor<T>(this HtmlHelper helper, string name, IEnumerable<MySelection<T>> lista, string selectedValue = null, object selectHtmlAttributes = null, object optionHtmlAttributes = null)
        {
            return helper.DropDownListFor<MySelection<T>>(name, lista, (l) => l.Text, (l) => l.Value, selectedValue, selectHtmlAttributes, optionHtmlAttributes);
        }
        public static HtmlString DropDownListFor<T>(this HtmlHelper helper, string name, IEnumerable<T> list, Func<T, string> text = null, Func<T, object> value = null, object selectedValue = null, object selectHtmlAttributes = null, object optionHtmlAttributes = null)
        {
            string sh = ObjectToHTMLAttributes(selectHtmlAttributes);
            string so = ObjectToHTMLAttributes(optionHtmlAttributes);

            Func<T, string> atext = text == null ? ((s1) => s1 == null ? null : s1.ToString()) : text;
            Func<T, object> avalue = value == null ? (s1) => s1 : value;

            string s = "<select name=\"" + name + "\" " + sh + ">";
            if (list != null && list.Count() > 0)
            {
                foreach (T o in list)
                {
                    string selected = "";
                    string val = "";
                    if (o != null)
                    {
                        object v = avalue(o);
                        val = v == null ? "" : v.ToString();
                        if (val.Equals(selectedValue))// != null && selectedValue == val)
                        {
                            selected = " selected";
                        }
                    }

                    s += "<option " + so + " value=\"" + val + "\"" + selected + ">" + atext(o) + "</option>";
                }
            }
            s += "</select>";
            return new HtmlString(s);
        }
        // insere um conjunto de divs usados para mostrar as pequenas janela ajax
        public static HtmlString ResultContainer(this HtmlHelper helper)
        {
            string s = "<div id=\"resultWindow\" class=\"resultWindowStyle\">";
            s += "<div id=\"btnFechaWindow\" ></div>";
            s += "<div id=\"resultContainer\" ></div>";
            s += "</div>";
            return new HtmlString(s);
        }
    }
    */
    public class TextWrittenEventArgs : EventArgs
    {
        public string Text { get; private set; }
        public TextWrittenEventArgs(string text)
        {
            this.Text = text;
        }
    }

    public class DebugMessages
    {
        StringBuilder _debugBuffer = new StringBuilder();

        // public DebugMessages()
        // {
        //     Debug.OnWrite += delegate (object sender, TextWrittenEventArgs e) { _debugBuffer.Append(e.Text); };
        // }

        public override string ToString()
        {
            return _debugBuffer.ToString();
        }
    }

    // public static class Debug
    // {
    //     public delegate void OnWriteEventHandler(object sender, TextWrittenEventArgs e);
    //     public static event OnWriteEventHandler OnWrite;

    //     // public static void Write(string text)
    //     // {
    //     //     TextWritten(text);
    //     // }

    //     // public static void WriteLine(string text)
    //     // {
    //     //     TextWritten(text + System.Environment.NewLine);
    //     // }

    //     // public static void Write(string text, params object[] args)
    //     // {
    //     //     text = (args != null ? String.Format(text, args) : text);
    //     //     TextWritten(text);
    //     // }

    //     // public static void WriteLine(string text, params object[] args)
    //     // {
    //     //     text = (args != null ? String.Format(text, args) : text) + System.Environment.NewLine;
    //     //     TextWritten(text);
    //     // }

    //     // private static void TextWritten(string text)
    //     // {
    //     //     if (OnWrite != null) OnWrite(null, new TextWrittenEventArgs(text));
    //     // }
    // }



    public static class PSHelpers
    {
        public static HtmlString ImportXml()
        {
            //        if (!System.IO.File.Exists("d:\\meusprodutos.xml"))
            //            return new HtmlString("");

            //        ProSoft.Model m = new ProSoft.Model();
            //        m.ExecuteStoreCommand("delete from Grupo");
            //        m.ExecuteStoreCommand("delete from Produto");

            //        m = new ProSoft.Model();

            //        XDocument xmlDoc = XDocument.Load("d:\\meusprodutos.xml"); 
            ////        System.IO.File.Delete("d:\\meusprodutos.xml");
            //        
            //        //StringBuilder sb = new StringBuilder();
            //        var grg = xmlDoc.Descendants("Export").Descendants("Grupos").Descendants("Grupo");

            //        System.Func<string, long?> ParseLong = (text) =>
            //        {
            //            if (string.IsNullOrEmpty(text))
            //                return null;
            //            else
            //                return (long?)long.Parse(text);
            //        };

            //        // importa todos os grupos como raiz
            //        var grupos = from c in grg
            //                select new GrupoImport
            //                {
            //                    GrupoId = long.Parse(c.Element("GrupoId").Value),
            //                    Descricao = c.Element("Descricao").Value,
            //                    ParentId = ParseLong(c.Element("ParentId").Value)
            //                };

            //        List<ProSoft.Grupo> gruposl = new List<ProSoft.Grupo>();
            //        foreach (GrupoImport c in grupos)
            //        {
            //            ProSoft.Grupo parent = null;
            //            if (c.ParentId != null)
            //            {
            //                parent = gruposl.FirstOrDefault(k)
            //            }

            //            gruposl.Add(
            //            new ProSoft.Grupo
            //            {
            //            });
            //            if (c.ParentId != null)
            //            {

            //            }
            //        }

            //        foreach (var g in grupos)
            //            m.Grupos.AddObject(g);

            //        foreach (var g in grg)
            //        {
            //            if (!string.IsNullOrEmpty(g.Element("Descricao").Value))
            //            {
            //                long? ParentId = ParseLong(g.Element("ParentId").Value);
            //                long? GrupoId = ParseLong(g.Element("GrupoId").Value);
            //                if (ParentId != null && GrupoId != null)
            //                {
            //                    ProSoft.Grupo parent = m.Grupos.FirstOrDefault(k=>k.GrupoId == ParentId);

            //                    ProSoft.Grupo thisgrupo = m.Grupos.FirstOrDefault(k=>k.GrupoId == GrupoId);

            //                    thisgrupo.Parent = parent;
            //                }
            //            }
            //        }

            //        m.SaveChanges();

            //        var produtos = from c in xmlDoc.Descendants("Export").Descendants("Produtos").Descendants("Produto")
            //            select new ProSoft.Produto
            //            {
            //                   ProdutoId = long.Parse(c.Element("ProdutoId").Value),
            //                   Descricao = c.Element("Descricao").Value,
            //                   Unidade = c.Element("Unidade").Value,
            //                   Unitario = double.Parse(c.Element("Unitario").Value),
            //                   GrupoId = ParseLong(c.Element("GrupoId").Value),
            //                   Imagem = c.Element("Imagem").Value
            //            };

            //        foreach(var p in produtos)
            //            m.Produtos.AddObject(p);
            //        m.SaveChanges();

            return new HtmlString("");
        }

    }

    public static class ExtensoHelpers
    {

        public static bool IsInt(this string text)
        {
            int i = 0;
            return int.TryParse(text, out i);
        }

        /// <summary>
        ///Retorna true se um string contem somente digitos.
        ///Vazio ou nulo é considerado como verdadeiro
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsDigits(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return true;

            foreach (char c in text)
            {
                if (!c.IsDigit())
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Informa se um string é a representação válida de um float.
        /// </summary>
        public static bool IsFloat(this string text)
        {
            float i = 0;
            return float.TryParse(text, out i);
        }
        /// <summary>
        /// Informa se um <seealso cref="char"/> é a representação de um dígito.
        /// </summary>
        public static bool IsDigit(this char key)
        {
            int i = 0;
            return int.TryParse(key.ToString(), out i);
        }

        public static string ToMoedaExt(this double value, bool acompanhaExtensoEntreParenteses = true)
        {
            string s = value.ToString("C");

            if (acompanhaExtensoEntreParenteses)
            {
                s += " (" + value.ToExtenso("Real", "Reais", "centavo", "centavos") + ")";
            }

            return s;
        }

        /// <summary>
        /// Converte um número para extenso
        /// </summary>
        /// <param name="valor">O número a ser convertido</param>
        /// <param name="inteirosingular">Inteiro no singular (Ex: Real)</param>
        /// <param name="inteiroplural">Inteiro no plural (Ex: Reais)</param>
        /// <param name="quebradosingular">Fração no singular (Ex: Centavo)</param>
        /// <param name="quebradoplural">Fração no plural (Ex: Centavos)</param>
        /// <param name="feminino">O texto retornado será em feminino?</param>
        /// <returns>Uma string que representa o número "valor" em extenso</returns>
        public static string ToExtenso(this int valor, string inteirosingular = "", string inteiroplural = "", string quebradosingular = "", string quebradoplural = "", bool feminino = false)
        {
            double d = (double)valor;
            return d.ToExtenso(inteirosingular, inteiroplural, quebradosingular, quebradoplural, feminino);
        }

        /// <summary>
        /// Converte um número para extenso
        /// </summary>
        /// <param name="valor">O número a ser convertido</param>
        /// <param name="inteirosingular">Inteiro no singular (Ex: Real)</param>
        /// <param name="inteiroplural">Inteiro no plural (Ex: Reais)</param>
        /// <param name="quebradosingular">Fração no singular (Ex: Centavo)</param>
        /// <param name="quebradoplural">Fração no plural (Ex: Centavos)</param>
        /// <param name="feminino">O número é feminino?</param>
        /// <returns>Uma string que representa o número "valor" em extenso</returns>
        public static string ToExtenso(this float valor, string inteirosingular = "", string inteiroplural = "", string quebradosingular = "", string quebradoplural = "", bool feminino = false)
        {
            double d = (double)valor;
            return d.ToExtenso(inteirosingular, inteiroplural, quebradosingular, quebradoplural, feminino);
        }

        /// <summary>
        /// Retorna o valor em extenso e em ordinal.
        /// </summary>
        /// <param name="valor">Valor a ser convertido.</param>
        /// <param name="feminino">O número é feminino?</param>
        /// <returns>String representando o valor em ordinal.</returns>
        public static string ExtensoOrdinal(this int valor, bool feminino = false)
        {
            return ((double)valor).ToExtensoOrdinal(feminino);
        }
        /// <summary>
        /// Retorna o valor em extenso e em ordinal.
        /// </summary>
        /// <param name="valor">Valor a ser convertido.</param>
        /// <param name="feminino">O número é feminino?</param>
        /// <returns>String representando o valor em ordinal.</returns>
        public static string ToExtensoOrdinal(this double valor, bool feminino = false)
        {
            string texto = "";
            string[] Unidades = { "", "Primeiro ", "Segundo ", "Terceiro  ", "Quarto", "Quinto ", "Sexto ", "Sétimo ", "Oitavo ", "Nono " };
            string[] Dezenas = { "", "Décimo ", "Vigésimo ", "Trigésimo ", "Quadragésimo ", "Quinquagésimo ", "Sexagésimo ", "Setuagésimo ", "Octogésimo ", "Novagésimo " };
            string[] Centenas = { "", "Centésimo ", "Ducentésimo ", "Tricentésimo ", "Quadringentésimo ", "Quingentésimo ", "Sexcentésimo ", "Septingentésimo ", "Octingentésimo ", "Noningentésimo " };
            if (feminino)
            {
                Unidades = new string[] { "", "Primeira ", "Segunda ", "Terceira  ", "Quarta", "Quinta ", "Sexta ", "Sétima ", "Oitava ", "Nono " };
                Dezenas = new string[] { "", "Décima ", "Vigésima ", "Trigésima ", "Quadragésima ", "Quinquagésima ", "Sexagésima ", "Setuagésima ", "Octogésima ", "Novagésima " };
                Centenas = new string[] { "", "Centésima ", "Ducentésima ", "Tricentésima ", "Quadringentésima ", "Quingentésima ", "Sexcentésima ", "Septingentésima ", "Octingentésima ", "Noningentésima " };
            }

            // tira os possiveis espacos em branco.
            string numero = valor.ToString().Trim();
            // cria um laço para caminhar na string da direita para esquerda pegando os numeros.
            for (int conta = numero.Length - 1; conta > -1; conta--)
            {
                string txnum = numero.Substring(conta, 1);
                int num = 0;
                int.TryParse(txnum, out num);

                // unidades
                if (numero.Length - conta == 1) texto = Unidades[num];
                // dezenas
                if (numero.Length - conta == 2) texto = Dezenas[num] + texto;
                // centenas
                if (numero.Length - conta == 3) texto = Centenas[num] + texto;
                // milhares
                if (numero.Length - conta > 3) texto = "nao sabe contar tanto,ainda." + texto;
            }
            return texto.Trim().ToLower();
        }

        /// <summary>
        /// Converte um número para extenso
        /// </summary>
        /// <param name="valor">O número a ser convertido</param>
        /// <param name="inteirosingular">Inteiro no singular (Ex: Real)</param>
        /// <param name="inteiroplural">Inteiro no plural (Ex: Reais)</param>
        /// <param name="quebradosingular">Fração no singular (Ex: Centavo)</param>
        /// <param name="quebradoplural">Fração no plural (Ex: Centavos)</param>
        /// <param name="feminino">O valor retornado será em feminino?</param>
        /// <returns>Uma string que representa o número "valor" em extenso</returns>
        public static string ToExtenso(this double valor, string inteirosingular = "", string inteiroplural = "", string quebradosingular = "", string quebradoplural = "", bool feminino = false)
        {
            bool negativo = false;
            if (valor < 0)
            {
                negativo = true;
                valor *= -1;
            }

            string wvalor = valor.ToString("N2");
            if (!string.IsNullOrEmpty(inteirosingular))
                inteirosingular = " " + inteirosingular;
            if (!string.IsNullOrEmpty(inteiroplural))
                inteiroplural = " " + inteiroplural;
            if (!string.IsNullOrEmpty(quebradosingular))
                quebradosingular = " " + quebradosingular;
            if (!string.IsNullOrEmpty(quebradoplural))
                quebradoplural = " " + quebradoplural;

            string[] wunidade = { "", " e um", " e dois", " e três", " e quatro", " e cinco", " e seis", " e sete", " e oito", " e nove" };

            if (feminino)
            {
                wunidade[1] = " e uma";
                wunidade[2] = " e duas";
            }

            string[] wdezes = { "", " e onze", " e doze", " e treze", " e quatorze", " e quinze", " e dezesseis", " e dezessete", " e dezoito", " e dezenove" };
            string[] wdezenas = { "", " e dez", " e vinte", " e trinta", " e quarenta", " e cinquenta", " e sessenta", " e setenta", " e oitenta", " e noventa" };
            string[] wcentenas = { "", " e cento", " e duzentos", " e trezentos", " e quatrocentos", " e quinhentos", " e seiscentos", " e setecentos", " e oitocentos", " e novecentos" };
            string[] wplural = { " bilhões", " milhões", " mil", "" };
            string[] wsingular = { " bilhão", " milhão", " mil", "" };
            string wextenso = "";
            string wfracao;
            wvalor = wvalor.Replace("R$", "").Trim();
            string wnumero = wvalor.Replace(",", "").Trim();
            wnumero = wnumero.Replace(".", "").PadLeft(14, '0');

            if (Int64.Parse(wnumero.Substring(0, 12)) > 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    wfracao = wnumero.Substring(i * 3, 3);
                    if (int.Parse(wfracao) != 0)
                    {
                        if (int.Parse(wfracao.Substring(0, 3)) == 100)
                            wextenso += " e cem";
                        else
                        {
                            wextenso += wcentenas[int.Parse(wfracao.Substring(0, 1))];
                            if (int.Parse(wfracao.Substring(1, 2)) > 10 && int.Parse(wfracao.Substring(1, 2)) < 20)
                                wextenso += wdezes[int.Parse(wfracao.Substring(2, 1))];
                            else
                            {
                                wextenso += wdezenas[int.Parse(wfracao.Substring(1, 1))];
                                wextenso += wunidade[int.Parse(wfracao.Substring(2, 1))];
                            }
                        }
                        if (int.Parse(wfracao) > 1)
                            wextenso += wplural[i];
                        else
                            wextenso += wsingular[i];
                    }
                }
                if (Int64.Parse(wnumero.Substring(0, 12)) > 1)
                    wextenso += inteiroplural;
                else
                    wextenso += inteirosingular;
            }
            wfracao = wnumero.Substring(12, 2);
            if (int.Parse(wfracao) > 0)
            {
                if (int.Parse(wfracao.Substring(0, 2)) > 10 && int.Parse(wfracao.Substring(0, 2)) < 20)
                    wextenso = wextenso + wdezes[int.Parse(wfracao.Substring(1, 1))];
                else
                {
                    wextenso += wdezenas[int.Parse(wfracao.Substring(0, 1))];
                    wextenso += wunidade[int.Parse(wfracao.Substring(1, 1))];
                }
                if (int.Parse(wfracao) > 1)
                    wextenso += quebradoplural;
                else
                    wextenso += quebradosingular;
            }
            if (wextenso != "")
            {
                wextenso = wextenso.Substring(3, 1) + wextenso.Substring(4);
            }
            else
                wextenso = "Nada";
            return wextenso + (negativo ? " negativo" : "");
        }
    }

    public static class DateTimeHelpers
    {
        ///// <summary>
        ///// Diferença em meses, entre duas datas
        ///// </summary>
        ///// <returns>O número de meses</returns>
        //public static int DiffMonths(this DateTime startDate, DateTime endDate)
        //{
        //    int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
        //    return Math.Abs(monthsApart);
        //}
        ///// <summary>
        ///// Diferença em dias, entre duas datas
        ///// </summary>
        ///// <returns>O número de dias</returns>
        //public static long DiffDays(this DateTime startDate, DateTime endDate)
        //{
        //    return (long)(endDate - startDate).TotalDays;
        //}
        ///// <summary>
        ///// Diferença em anos, entre duas datas
        ///// </summary>
        ///// <returns>O número de anos</returns>
        //public static int DiffYears(this DateTime startDate, DateTime endDate)
        //{
        //    // get the difference in years
        //    int years = endDate.Year - startDate.Year;
        //    // subtract another year if we're before the birth day in the current year
        //    if (endDate.Month < startDate.Month || (endDate.Month == startDate.Month && endDate.Day < startDate.Day))
        //        --years;
        //    return years;
        //}
        ///// <summary>
        ///// Retorna a diferença entre duas datas, em dias, meses e anos
        ///// </summary>
        //public static void Diff(this DateTime startDate, DateTime endDate, out int years, out int months, out int days)
        //{
        //    years = startDate.DiffYears(endDate);
        //    months = endDate.Month - startDate.Month;
        //    if (startDate.Day > endDate.Day)
        //        --months;
        //    if (months < 0) months = 0;
        //    days = endDate.Day - startDate.Day;
        //    if (days < 0) days = 0;
        //}
        ///// <summary>
        ///// Retorna novo DateTime no mesmo dia do mês, mas acrescido do número de meses passados, que pode ser negativo.
        ///// </summary>
        //public static DateTime AddMonths(this DateTime dateTime, int count)
        //{
        //    int y = dateTime.Year + (count / 12);
        //    int m = dateTime.Month + (count % 12);
        //    return new DateTime(y, m, dateTime.Day);
        //}
        ///// <summary>
        ///// Retorna um novo DateTime, no mesmo dia do ano e no mesmo mês, mas acrescido do número de dias passado, que pode ser negativo.
        ///// </summary>
        //public static DateTime AddYears(this DateTime dateTime, int count)
        //{
        //    int y = dateTime.Year + count;
        //    return new DateTime(y, dateTime.Month, dateTime.Day);
        //}

        public static int Idade(this DateTime nascimento)
        {
            DateTime curDate = DateTime.Today;
            DateTime testDate = new DateTime(curDate.Year, nascimento.Month, nascimento.Day);
            int Age = curDate.Year - nascimento.Year;
            // Overloaded comparision operator
            if (testDate <= curDate) // You do not yet celebrate your birthday this year
            {
                Age--;
            }
            return Age;
        }

        ///// <summary>
        ///// Retorna quantos anos, meses e dias tem um timespan.
        ///// </summary>
        ///// <param name="timeSpan"></param>
        ///// <param name="years"></param>
        ///// <param name="months"></param>
        ///// <param name="days"></param>
        //public static void Decompose(this TimeSpan timeSpan, out int years, out int months, out int days)
        //{
        //    DateTime dt = DateTime.MinValue + timeSpan;

        //    // note: MinValue is 1/1/1 so we have to subtract...
        //    years = dt.Year - 1;
        //    months = dt.Month - 1;
        //    days = dt.Day - 1;
        //}

        //public static void DateDiff(DateTime dtStart, DateTime dtEnd, out int Years, out int Months, out int Days, out int Hours, out int Minutes, out int Seconds)
        //{
        //    TimeSpan TS = dtEnd - dtStart;

        //    Years = dtEnd.Year - dtStart.Year;
        //    Months = dtEnd.Month - dtStart.Month;
        //    Days = dtEnd.Day - dtStart.Day;
        //    Hours = dtEnd.Hour - dtStart.Hour;
        //    Minutes = dtEnd.Minute - dtStart.Minute;
        //    Seconds = dtEnd.Second - dtStart.Second;

        //    //if (intYears > 0) return String.Format("há {0} {1}", intYears, (intYears == 1) ? "ano" : "anos");
        //    //else if (intMonths > 0) return String.Format("há {0} {1}", intMonths, (intMonths == 1) ? "mês" : "meses");
        //    //else if (intDays > 0) return String.Format("há {0} {1}", intDays, (intDays == 1) ? "dia" : "dias");
        //    //else if (intHours > 0) return String.Format("há {0} {1}", intHours, (intHours == 1) ? "hora" : "horas");
        //    //else if (intMinutes > 0) return String.Format("há {0} {1}", intMinutes, (intMinutes == 1) ? "minuto" : "minutos");
        //    //else if (intSeconds > 0) return String.Format("há {0} {1}", intSeconds, (intSeconds == 1) ? "segundo" : "segundos");
        //    //else
        //    //{
        //    //    return String.Format("em {0} às {1}", dtStart.ToShortDateString(), dtStart.ToShortTimeString());
        //    //}
        //}

        public static TimeSpan FromYMD(this TimeSpan timespan, int years, int months, int days)
        {
            DateTime Birth = DateTime.MinValue.AddYears(years).AddMonths(months).AddDays(days);
            return Birth - DateTime.MinValue;
        }
        /// <summary>
        /// Informa se um string é a representação válida de um DateTime.
        /// </summary>
        public static bool IsDateTime(this string text)
        {
            DateTime d = DateTime.MinValue;
            return DateTime.TryParse(text, out d);
        }
        public static double ToValue(this TimeSpan ts, double valorDoMinuto)
        {
            return ts.TotalHours * (valorDoMinuto * 60f);
        }
        public static TimeSpan ToDuration(this double valor, double valorDoMinuto)
        {
            double horas = valor / (valorDoMinuto * 60f);
            if (valor == 0 || valorDoMinuto == 0)
                horas = 0;
            DateTime fim = DateTime.Now.AddHours(horas);
            return fim - DateTime.Now;
        }
        /// <summary>
        /// Remove todas as ocorrências de todos os caracteres passados em <para="ocurrences"> do string.
        /// </summary>
        /// <param name="aString"></param>
        /// <param name="ocurrences"></param>
        /// <returns>Retorna o string sem nenhum dos caracteres passados.</returns>
        public static string RemoveOcurrences(this string aString, string ocurrences)
        {
            if (string.IsNullOrEmpty(aString))
                return aString;
            else
            {
                string tx = aString;
                foreach (char c in ocurrences)
                {
                    tx = tx.Replace(new string(c, 1), "");
                }
                return tx;
            }
        }
        public static string AsString(this TimeSpan ts)
        {
            return ts.Hours.ToString().PadLeft(2, '0') + ":" + ts.Minutes.ToString().PadLeft(2, '0') + ":" + ts.Seconds.ToString().PadLeft(2, '0');
        }
        /// <summary>
        /// Converte uma data/hora para extenso, inclusive número do dia e do ano
        /// </summary>
        /// <param name="dt">O datetime que será convertido</param>
        /// <param name="returnDate">Retorna a data?</param>
        /// <param name="returnTime">Retorna a hora?</param>
        /// <param name="includenumbers">Incluir números de dia, ano e hora?</param>
        /// <param name="diaEAnoEmExtenso">Dia e ano serão representados por extenso?</param>
        /// <param name="timeExtenso">HOra será representada por extenso?</param>
        /// <param name="feminino">Ordinais serão representados em feminino?</param>
        /// <param name="primeiroDiaOrdinal">O primeiro dia do mês será representado em ordinal?</param>
        /// <param name="todosDiasOrdinal">Os dias serão representados em ordinal?</param>
        /// <returns>Um string que é a representação por extenso da data</returns>
        public static string ToExtenso(this System.DateTime? dt, bool returnDate = true, bool returnTime = false, bool includenumbers = false, bool diaEAnoEmExtenso = true, bool timeExtenso = false, bool feminino = false, bool primeiroDiaOrdinal = false, bool todosDiasOrdinal = false)
        {
            if (dt != null)
                return ((DateTime)dt).ToExtenso(returnDate, returnTime, includenumbers, diaEAnoEmExtenso, timeExtenso, feminino, primeiroDiaOrdinal, todosDiasOrdinal);
            else
                return "";
        }
        /// <summary>
        /// Converte um número inteiro em nome do mês que ele representa [1..12].
        /// </summary>
        /// <param name="numero">Número do mês.</param>
        /// <returns>O nome do mês</returns>
        public static string ToMonthName(this int numeroMes)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");
            System.Globalization.DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            return dtfi.GetMonthName(numeroMes);
        }
        /// <summary>
        /// Converte um número inteiro em nome do mês que ele representa [1..12].
        /// </summary>
        /// <param name="numero">Número do mês.</param>
        /// <returns>O nome do mês</returns>
        public static string Mes(this DateTime date)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");
            System.Globalization.DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            return dtfi.GetMonthName(date.Month);
        }
        /// <summary>
        /// Converte uma data/hora para extenso, inclusive número do dia e do ano
        /// </summary>
        /// <param name="dt">O datetime que será convertido</param>
        /// <param name="returnDate">Retorna a data?</param>
        /// <param name="returnTime">Retorna a hora?</param>
        /// <param name="includenumbers">Incluir números de dia, ano e hora?</param>
        /// <param name="diaEAnoEmExtenso">Dia e ano serão representados por extenso?</param>
        /// <param name="timeExtenso">HOra será representada por extenso?</param>
        /// <param name="feminino">Ordinais serão representados em feminino?</param>
        /// <param name="primeiroDiaOrdinal">O primeiro dia do mês será representado em ordinal?</param>
        /// <param name="todosDiasOrdinal">Os dias serão representados em ordinal?</param>
        /// <returns>Um string que é a representação por extenso da data</returns>
        public static string ToExtenso(this DateTime dt, bool returnDate = true, bool returnTime = false, bool includenumbers = false, bool diaEAnoEmExtenso = false, bool timeExtenso = false, bool feminino = false, bool primeiroDiaOrdinal = false, bool todosDiasOrdinal = false)
        {
            //System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");
            //System.Globalization.DateTimeFormatInfo dtfi = culture.DateTimeFormat;        
            int dia = dt.Day;
            int ano = dt.Year;
            string mes = dt.Month.ToMonthName();// dtfi.GetMonthName(dt.Month);
            string hora = "";
            string data = "";
            string ret = "";
            if (returnTime)
            {
                if (timeExtenso)
                {
                    string hr = "";
                    string mr = "";
                    if (dt.Hour > 0)
                        hr = dt.Hour.ToExtenso("hora", "horas", "", "", true);
                    if (dt.Minute > 0)
                        mr = dt.Minute.ToExtenso("minuto", "minutos", "", "", false);
                    if (hr.Length > 0 && mr.Length > 0)
                        hora = hr + " e " + mr;
                    else
                        hora = hr + mr;
                    if (includenumbers) hora += " (";
                }
                if (!timeExtenso || includenumbers)
                {
                    string hr = "h";
                    string min = "min";
                    hora += dt.Hour.ToString().PadLeft(2, '0');
                    if (dt.Minute > 0)
                        hora += hr + dt.Minute.ToString().PadLeft(2, '0') + min;
                    else
                        hora += "horas";
                }
                if (includenumbers) hora += ")";
            }
            if (returnDate)
            {
                string dn = "";
                string yn = "";
                if (includenumbers)
                {
                    if (primeiroDiaOrdinal && dia == 1)
                        dn = "(1º)";
                    else if (todosDiasOrdinal)
                        dn = " (" + dia.ToString() + "º)";
                    else
                        dn = " (" + dia.ToString().PadLeft(2, '0') + ")";
                    yn = " (" + ano.ToString() + ")";
                }
                string diae = dia.ToString();
                string anoe = ano.ToString();
                if (diaEAnoEmExtenso)
                {
                    if (primeiroDiaOrdinal && dia == 1)
                        diae = "primeiro";
                    else if (todosDiasOrdinal)
                        diae = dia.ExtensoOrdinal();
                    else
                        diae = dia.ToExtenso("", "", "", "", false);
                    anoe = ano.ToExtenso();
                }
                string doano = diaEAnoEmExtenso ? " de " : " de ";
                data += diae + dn + " de " + mes + doano + anoe + yn;
            }
            if (hora.Length > 0 && data.Length > 0)
                ret = hora + " do dia " + data;
            else
                ret = hora + data;
            return ret;
        }
    }

};

namespace ProSoft.ComponentHelpers
{
    public enum TextAlign
    {
        [Description("text-start")]
        start,
        [Description("text-center")]
        center,
        [Description("text-end")]
        end
    }

}
