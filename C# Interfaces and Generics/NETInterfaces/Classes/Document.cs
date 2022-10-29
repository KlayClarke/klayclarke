// TODO: Implement INotifyPropertyChanged
using System.ComponentModel;

namespace NETInterfaces
{
    class Document : IStorable, INotifyPropertyChanged
    {
        private string name;
        private Boolean mNeedsSave = false;
        
        // TODO: INotifyPropertyChanged requires the implementation of 1 event
        public event PropertyChangedEventHandler? PropertyChanged;
        
        // TODO: Define a utility function to call the PropertyChanged event
        private void NotifyPropChanged(string propName)
        {
            PropertyChanged!(this, new PropertyChangedEventArgs(propName));
        }
        
        public Document(string s)
        {
            name = s;
            Console.WriteLine($"Created a document with name {name}");
            
        }
        
        public string DocName
        {
            get { return name; }
            set { 
                name = value;
                NotifyPropChanged("DocName");                
             }
        }
        
        public void Save()
        {
            Console.WriteLine("Saving the document!");
        }
        
        public void Load()
        {
            Console.WriteLine("Loading the document!");
        }
        
        public Boolean NeedsSave 
        {
            get { return mNeedsSave; }
            set {
                mNeedsSave = value;
                NotifyPropChanged("mNeedsSave");
            }
        }
        
    }
}