using System.Threading.Tasks;

namespace Blazor.ViewProperties.Data
{
	public interface ICounter
	{
		ValueTask<int> Count();
	}
}