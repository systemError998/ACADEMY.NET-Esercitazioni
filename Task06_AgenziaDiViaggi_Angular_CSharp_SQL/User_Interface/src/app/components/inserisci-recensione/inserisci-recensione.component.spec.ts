import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InserisciRecensioneComponent } from './inserisci-recensione.component';

describe('InserisciRecensioneComponent', () => {
  let component: InserisciRecensioneComponent;
  let fixture: ComponentFixture<InserisciRecensioneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [InserisciRecensioneComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InserisciRecensioneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
