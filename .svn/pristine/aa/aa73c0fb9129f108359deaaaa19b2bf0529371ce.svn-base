import { Component, OnInit, TemplateRef, Type } from '@angular/core';
import { CustomOverlayRef } from './CustomOverlayRef';

@Component({
  selector: 'app-overlay',
  templateUrl: './overlay.component.html'
})
export class OverlayComponent implements OnInit {
  contentType: 'template' | 'string' | 'component';
  content: string | TemplateRef<any> | Type<any>;
  context;

  constructor(private ref: CustomOverlayRef) {}

  close() {
    this.ref.close(null);
  }

  ngOnInit() {
    this.content = this.ref.content;

    if (typeof this.content === 'string') {
      this.contentType = 'string';
    } else if (this.content instanceof TemplateRef) {
      this.contentType = 'template';
      this.context = {
        close: this.ref.close.bind(this.ref)
      };
    } else {
      this.contentType = 'component';
    }
  }
}
