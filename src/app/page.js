"use client";
import Image from "next/image";
import Hero from "./hero";
import CTA from "./cta";
import Feature from "./feature";
import Banner from "./banner";
import Navbar from "./navbar";
import Faq from "./faq";
import Foot from "./footer";
import Team from "./team";



export default function Home() {
  return (
    <>
      <Banner />
      <Navbar />
      <Hero />
      <CTA />
      <Feature />
      <Team />
      <Faq />
      <Foot />
    </>
  );
}
