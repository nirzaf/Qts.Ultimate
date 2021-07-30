import { UltimateTemplatePage } from './app.po';

describe('Ultimate App', function() {
  let page: UltimateTemplatePage;

  beforeEach(() => {
    page = new UltimateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
