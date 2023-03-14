using E02_Delegates;

var processor = new PhotoProcessor();
var filters = new PhotoFilters();

// PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += filters.Resize;

processor.Process("photo.jpg", filterHandler);