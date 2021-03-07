var plugin = {
  GetReferrerWithMalloc: function () {
    var referrer = document.referrer;
    var bufferSize = lengthBytesUTF8(referrer) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(referrer, buffer, bufferSize);
    return buffer;
  },
  OpenLink: function(url_str) {
    window.open(Pointer_stringify(url_str),'_blank')
  }
};

mergeInto(LibraryManager.library, plugin);
