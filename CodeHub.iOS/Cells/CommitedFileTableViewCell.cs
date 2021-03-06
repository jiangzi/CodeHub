using System;
using Foundation;
using UIKit;
using ReactiveUI;
using System.Reactive.Linq;
using CodeHub.Core.ViewModels.Source;

namespace CodeHub.iOS.Cells
{
    public class CommitedFileTableViewCell : ReactiveTableViewCell<CommitedFileItemViewModel>
    {
        public static NSString Key = new NSString("commitedfile");
        private const float ImageSpacing = 10f;

        public CommitedFileTableViewCell(IntPtr handle)
            : base(handle)
        { 
            SeparatorInset = new UIEdgeInsets(0, 0, 0, 0);
            ContentView.Opaque = true;

            this.WhenAnyValue(x => x.ViewModel)
                .Where(x => x != null)
                .Subscribe(x =>
                {
                    ImageView.Image = Octicon.FileCode.ToImage();
                    TextLabel.Text = x.Name;
                });
        }
    }
}

