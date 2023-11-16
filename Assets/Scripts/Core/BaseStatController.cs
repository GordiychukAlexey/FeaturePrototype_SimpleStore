using System;
using UniRx;

namespace Core{
	public class BaseStatController<T> : IDisposable where T : BaseStatView{
		protected readonly T statView;

		public BaseStatController(T statView){
			this.statView = statView;
		}

		protected readonly CompositeDisposable disposables = new();

		public void Dispose(){
			disposables.Dispose();
		}
	}
}