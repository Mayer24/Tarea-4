html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
main, menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
}

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, main, menu, nav, section {
  display: block;
}

/* HTML5 hidden-attribute fix for newer browsers */
*[hidden] {
  display: none;
}

body {
  line-height: 1;
}

menu, ol, ul {
  list-style: none;
}

blockquote, q {
  quotes: none;
}

blockquote:before, blockquote:after,
q:before, q:after {
  content: "";
  content: none;
}

table {
  border-collapse: collapse;
  border-spacing: 0;
}

body {
  background-color: #dff2d8;
  background: url(https://wallpaperswide.com/download/lake_mcdonald_montana-wallpaper-1920x1080.jpg) lightgray 50%;
}

.header {
  background: linear-gradient(0deg, rgba(100, 97, 160, 0.5) 0%, rgba(182, 140, 184, 0.5) 100%);
  box-shadow: 0px 1px 15px 0px rgba(0, 0, 0, 0.25);
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem;
  border-radius: 0px 0px 20px 20px;
}
@media (max-width: 780px) {
  .header {
    display: grid;
    justify-content: left;
    justify-items: left;
    padding: 1rem;
  }
}
.header__image {
  width: 100px;
}
.header__link {
  border-radius: 2rem;
  text-decoration: none;
  background: rgba(132, 147, 36, 0.1);
  box-shadow: 0px 4px 4px 0px rgba(0, 0, 0, 0.15);
  color: #dff2d8;
  font-family: "Inter", serif;
  font-size: 1rem;
  padding: 1rem;
}
.header__link:hover {
  background: #849324;
  color: #dff2d8;
  box-shadow: 0px 4px 4px 0px rgba(0, 0, 0, 0.15);
  transition: 0.5s;
}
@media (max-width: 780px) {
  .header__link {
    display: grid;
    margin-bottom: 1rem;
  }
}

h2 {
  display: flex;
  justify-content: center;
  color: #dff2d8;
  font-family: "Inter", serif;
  font-size: 2rem;
  padding: 1rem;
  text-shadow: 0px 4px 4px rgba(38, 35, 34, 0.15);
}

h3 {
  display: flex;
  justify-content: center;
  color: #dff2d8;
  font-family: "Inter", serif;
  font-size: 2rem;
  padding: 1rem;
  text-shadow: 0px 4px 4px rgba(38, 35, 34, 0.15);
}

p {
  display: flex;
  justify-content: center;
  text-align: center;
  color: #dff2d8;
  font-family: "Inter", serif;
  font-size: 14px;
  padding: 1rem;
}

.destinos {
  background: linear-gradient(0deg, rgba(100, 97, 160, 0.5) 0%, rgba(182, 140, 184, 0.5) 100%);
  border-radius: 20px 20px 20px 20px;
  display: flex;
  padding: 1rem;
  justify-content: center;
}
@media (max-width: 780px) {
  .destinos {
    display: grid;
    align-items: center;
    justify-items: center;
    padding: 2rem;
  }
}
.destinos__lugares {
  display: grid;
  justify-items: center;
  margin: 1rem;
}
@media (max-width: 780px) {
  .destinos__lugares {
    display: grid;
    padding: 2rem;
    align-items: center;
  }
}

.paisaje {
  display: flex;
  justify-content: center;
  width: 300px;
  height: 300px;
  border-radius: 50%;
  margin: 2rem;
  box-shadow: 0px 4px 4px 0px rgba(0, 0, 0, 0.25);
}
@media (max-width: 780px) {
  .paisaje {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    align-items: center;
  }
}

/*# sourceMappingURL=styles.cs.map */
