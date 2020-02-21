using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Blazor.ViewProperties.Components
{
	public abstract class ViewPropertyComponentBase : ComponentBase
	{
		protected override async Task OnParametersSetAsync()
		{
			var properties = GetType().GetRuntimeProperties();
			foreach (var metadata in properties.Where(x => x.GetCustomAttributes<ParameterAttribute>().Any() &&
			                                               typeof(IViewProperty).IsAssignableFrom(x.PropertyType)))
			{
				if (metadata.GetValue(this) is IViewProperty property)
				{
					await property.Get().ConfigureAwait(false);
				}
			}
		}
	}
}