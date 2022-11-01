namespace Delegates
{
    public class Photo
    {
        static public void Save() { }
        static public Photo Load(string path) { return new Photo(); }

    }
    public class PhotoProcessor
    {
        /// <summary>
        /// parameter to delegat can hold a pointer to a function
        /// or a group of functions that have the signatre
        /// </summary>
        /// <param name="photo"></param>
        public delegate void PhotoFilterHandler(Photo photo);
        
        /// <summary>
        /// Process method to process a photo
        /// </summary>
        /// <param name="path"></param>
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            Photo photo = Photo.Load(path);
            var filters = new PhotoFilters();

            // We can remove the logic below
            // to make this method extensible 
            // and pass a delegate instead.
            // filters.ApplyBrightness(photo);
            // filters.ApplyContrast(photo);
            // filters.Resize(photo);  

            // Using the delegate means that
            // this code does not know what type
            // of filter will be applied. It's up
            // to the client code to decided. Doing
            // this means that this framework does not have 
            // to be complied or redeployed which makes it 
            // extensible
            filterHandler(photo);
        }

        /// <summary>
        /// Process a photo, but this time use built in
        /// delegates provided by .NET
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filterHandler"></param>
        public void Process(string path, Action<Photo> filterHandler)
        {
            // built in delegates provided my .NET
            // System.Action<>
            // System.Func<>

            Photo photo = Photo.Load(path);
            var filters = new PhotoFilters();

            // We can remove the logic below
            // to make this method extensible 
            // and pass a delegate instead.
            // filters.ApplyBrightness(photo);
            // filters.ApplyContrast(photo);
            // filters.Resize(photo);  

            // Using the delegate means that
            // this code does not know what type
            // of filter will be applied. It's up
            // to the client code to decided. Doing
            // this means that this framework does not have 
            // to be complied or redeployed which makes it 
            // extensible
            filterHandler(photo);
        }
    }
}


