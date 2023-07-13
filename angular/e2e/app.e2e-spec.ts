import { GMSTemplatePage } from './app.po';

describe('GMS App', function() {
  let page: GMSTemplatePage;

  beforeEach(() => {
    page = new GMSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
