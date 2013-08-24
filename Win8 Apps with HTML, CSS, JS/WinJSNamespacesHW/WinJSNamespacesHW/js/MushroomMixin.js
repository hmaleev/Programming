var MushroomMixin = {
    size: 0,

    grow: function (size) {
        this.size = size || this.size;
        if (this.size) {
            this.size += size;
        }
    }
}