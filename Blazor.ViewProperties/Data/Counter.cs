using System.Threading.Tasks;

namespace Blazor.ViewProperties.Data
{
	sealed class Counter : ICounter
	{
		public ValueTask<int> Count() => new ValueTask<int>(42);
	}
}