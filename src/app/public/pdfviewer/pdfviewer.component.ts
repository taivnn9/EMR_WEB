import { AfterViewInit, Component, Input, OnChanges, OnInit, SimpleChanges, ViewChild } from "@angular/core";

@Component({
    selector: 'app-pdf-viewer',
    template: `
              <!-- <ngx-extended-pdf-viewer 
              [base64Src]="base64Src"
              backgroundColor="#ffffff" 
              [height]="'80vh'" 
              [zoom]="'auto'" 
              [useBrowserLocale]="true" 
              [handTool]="false"
              [showHandToolButton]="false"
              [showFindButton]="false"
              [showBookmarkButton]="false"
              [showOpenFileButton]="false"
              >
            </ngx-extended-pdf-viewer>    -->
            <ng2-pdfjs-viewer #pdfViewer></ng2-pdfjs-viewer>  
            `
})
export class PdfViewerComponent implements OnInit, OnChanges , AfterViewInit{
    ngAfterViewInit(): void {
   
    }

    @ViewChild('pdfViewer', { static: true }) public pdfViewer;
    @Input() base64Src: string
    contentType: string = "application/pdf"
    ngOnInit(): void {

    }
    ngOnChanges(changes: SimpleChanges): void {
             
        if (this.base64Src) {
            // console.log(this.base64Src);
            const b64toBlob = (b64Data, contentType = '', sliceSize = 512) => {
                const byteCharacters = atob(b64Data);
                const byteArrays = [];

                for (let offset = 0; offset < byteCharacters.length; offset += sliceSize) {
                    const slice = byteCharacters.slice(offset, offset + sliceSize);

                    const byteNumbers = new Array(slice.length);
                    for (let i = 0; i < slice.length; i++) {
                        byteNumbers[i] = slice.charCodeAt(i);
                    }

                    const byteArray = new Uint8Array(byteNumbers);
                    byteArrays.push(byteArray);
                }

                const blob = new Blob(byteArrays, { type: contentType });
                return blob;
            }
            const blob = b64toBlob(this.base64Src, this.contentType);
            this.pdfViewer.zoom = "page-width"
            this.pdfViewer.pdfSrc = blob; // pdfSrc can be Blob or Uint8Array
            this.pdfViewer.refresh(); // Ask pdf viewer to load/refresh pdf
            const blobUrl = URL.createObjectURL(blob);

        }
    }

}