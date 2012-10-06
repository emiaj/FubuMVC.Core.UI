using System;
using System.Linq.Expressions;
using HtmlTags;

namespace FubuMVC.Core.UI.Elements
{
    public interface IElementGenerator<T> where T : class
    {
        HtmlTag LabelFor(Expression<Func<T, object>> expression, string profile = null, T model = null);
        HtmlTag InputFor(Expression<Func<T, object>> expression, string profile = null, T model = null);
        HtmlTag DisplayFor(Expression<Func<T, object>> expression, string profile = null, T model = null);

        T Model { get; set; }
    }
}