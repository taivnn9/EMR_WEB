import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environments/environment';

@Component({
    selector: 'virtual-scroll-example',
    templateUrl: './virtual-scroll-example.component.html',
    styleUrls: ['./virtual-scroll-example.component.scss']
})
export class VirtualScrollExampleComponent implements OnInit, OnChanges {

    @Input() items = [];
    @Input() value
    @Output() valueChange = new EventEmitter<any>();

    buffer = [];
    bufferSize = 50;
    numberOfItemsFromEndBeforeFetchingMore = 10;
    loading = false;

    constructor(private http: HttpClient) {
    }

    ngOnChanges(changes: SimpleChanges): void {
        // throw new Error('Method not implemented.');
        
        this.updatebuffer()
    }
    onChangeItem(value: any){
        console.log(value);
        
        this.valueChange.emit(this.value)
    }
    ngOnInit() {
        this.loading = true;
        // debugger

        // this.http.get<any[]>(`${environment.URL_EMR}/api/BenhAn/FakeData10K`).subscribe((photos: any) => {
        //     this.loading = false;
        //     this.items = photos.Data;
            
        // });
    }

    updatebuffer(){
        // debugger
        if(this.buffer.length > 0){
            return
        }
        if(this.items.length > 0){
            this.loading = false;
            this.buffer = this.items.slice(0, this.bufferSize);
            
        }
        if(this.value != null){
            this.append()
        }
        
        this.loading = false;
    }
    onScrollToEnd() {
        this.fetchMore();
    }

    onScroll({ end }) {
        if (this.loading || this.items.length <= this.buffer.length) {
            return;
        }
        if (end + this.numberOfItemsFromEndBeforeFetchingMore >= this.buffer.length) {
            this.fetchMore();
        }
    }

    // Nếu selected id không có trong photosBuffer
    // Tìm trong photos & push vào photosBuffer
    private append(){
        const selectedPhotos = this.items.filter(photo=>photo.value == this.value)
        if(selectedPhotos.length == 0){
            return
        }
        const selectedPhoto = selectedPhotos[0]
        if(!this.buffer.includes(selectedPhoto)){
            this.buffer.push(selectedPhoto)
        }
    }


    private fetchMore() {
        const len = this.buffer.length;
        const more = this.items.slice(len, this.bufferSize + len);
        this.loading = true;
        // using timeout here to simulate backend API delay
        setTimeout(() => {
            this.loading = false;
            this.buffer = this.buffer.concat(more);
        }, 200)
    }

}
