using System.Threading.Tasks;

namespace Blazor.ViewProperties.Components
{
	public interface IViewProperty
	{
		ValueTask Get();
	}
}