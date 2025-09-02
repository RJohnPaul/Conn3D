export default function Bentogrid() {
  return (
    <div className="bg-white dark:bg-gray-900 py-24 sm:py-32">
      <div className="mx-auto max-w-2xl px-6 lg:max-w-7xl lg:px-8">
        <h2 className="text-base/7 font-semibold text-indigo-500 dark:text-indigo-400">
          Deploy faster
        </h2>
        <p className="mt-2 max-w-lg text-4xl font-semibold tracking-tight text-pretty text-gray-950 dark:text-gray-50 sm:text-5xl">
          Everything you need in a AR Edu App
        </p>
        <div className="mt-10 grid grid-cols-1 gap-4 sm:mt-16 lg:grid-cols-6 lg:grid-rows-2">
          <div className="relative lg:col-span-3">
            <div className="absolute inset-px rounded-lg bg-white dark:bg-gray-800 max-lg:rounded-t-[2rem] lg:rounded-tl-[2rem]" />
            <div className="relative flex h-full flex-col overflow-hidden rounded-[calc(var(--radius-lg)+1px)] max-lg:rounded-t-[calc(2rem+1px)] lg:rounded-tl-[calc(2rem+1px)]">
              <img
                alt=""
                src="https://tailwindui.com/plus-assets/img/component-images/bento-01-performance.png"
                className="h-80 object-cover object-left"
              />
              <div className="p-10 pt-4">
                <h3 className="text-sm/4 font-semibold text-indigo-500 dark:text-indigo-400">
                  Performance
                </h3>
                <p className="mt-2 text-lg font-medium tracking-tight text-gray-950 dark:text-gray-100">
                  Seamless 3D rendering
                </p>
                <p className="mt-2 max-w-lg text-sm/6 text-gray-600 dark:text-gray-400">
                  Experience smooth, real-time 3D graphics powered by our
                  optimized engine. No lag, no stutter — just immersive
                  interaction on any device.
                </p>
              </div>
            </div>
            <div className="pointer-events-none absolute inset-px rounded-lg ring-1 shadow-sm ring-black/5 dark:ring-white/10 max-lg:rounded-t-[2rem] lg:rounded-tl-[2rem]" />
          </div>
          <div className="relative lg:col-span-3">
            <div className="absolute inset-px rounded-lg bg-white dark:bg-gray-800 lg:rounded-tr-[2rem]" />
            <div className="relative flex h-full flex-col overflow-hidden rounded-[calc(var(--radius-lg)+1px)] lg:rounded-tr-[calc(2rem+1px)]">
              <img
                alt=""
                src="https://tailwindui.com/plus-assets/img/component-images/bento-01-releases.png"
                className="h-80 object-cover object-left lg:object-right"
              />
              <div className="p-10 pt-4">
                <h3 className="text-sm/4 font-semibold text-indigo-500 dark:text-indigo-400">
                  Releases
                </h3>
                <p className="mt-2 text-lg font-medium tracking-tight text-gray-950 dark:text-gray-100">
                  Instant project updates
                </p>
                <p className="mt-2 max-w-lg text-sm/6 text-gray-600 dark:text-gray-400">
                  Use your 3D projects with a single click. Work together
                  instantly with classmates, colleagues
                </p>
              </div>
            </div>
            <div className="pointer-events-none absolute inset-px rounded-lg ring-1 shadow-sm ring-black/5 dark:ring-white/10 lg:rounded-tr-[2rem]" />
          </div>
          <div className="relative lg:col-span-2">
            <div className="absolute inset-px rounded-lg bg-white dark:bg-gray-800 lg:rounded-bl-[2rem]" />
            <div className="relative flex h-full flex-col overflow-hidden rounded-[calc(var(--radius-lg)+1px)] lg:rounded-bl-[calc(2rem+1px)]">
              <img
                alt=""
                src="https://tailwindui.com/plus-assets/img/component-images/bento-01-speed.png"
                className="h-80 object-cover object-left"
              />
              <div className="p-10 pt-4">
                <h3 className="text-sm/4 font-semibold text-indigo-500 dark:text-indigo-400">
                  Speed
                </h3>
                <p className="mt-2 text-lg font-medium tracking-tight text-gray-950 dark:text-gray-100">
                  Built for creators
                </p>
                <p className="mt-2 max-w-lg text-sm/6 text-gray-600 dark:text-gray-400">
                  From students to professionals, Conn3D is designed for speed.
                  Build faster, visualize quicker, and experiment without
                  limits.
                </p>
              </div>
            </div>
            <div className="pointer-events-none absolute inset-px rounded-lg ring-1 shadow-sm ring-black/5 dark:ring-white/10 lg:rounded-bl-[2rem]" />
          </div>
          <div className="relative lg:col-span-2">
            <div className="absolute inset-px rounded-lg bg-white dark:bg-gray-800" />
            <div className="relative flex h-full flex-col overflow-hidden rounded-[calc(var(--radius-lg)+1px)]">
              <img
                alt=""
                src="https://tailwindui.com/plus-assets/img/component-images/bento-01-integrations.png"
                className="h-80 object-cover"
              />
              <div className="p-10 pt-4">
                <h3 className="text-sm/4 font-semibold text-indigo-500 dark:text-indigo-400">
                  AR Integration
                </h3>
                <p className="mt-2 text-lg font-medium tracking-tight text-gray-950 dark:text-gray-100">
                  Unity AR/VR
                </p>
                <p className="mt-2 max-w-lg text-sm/6 text-gray-600 dark:text-gray-400">
                  Integrated with Unity's AR Foundation to create immersive
                  experiences for your 3D projects.
                </p>
              </div>
            </div>
            <div className="pointer-events-none absolute inset-px rounded-lg ring-1 shadow-sm ring-black/5 dark:ring-white/10" />
          </div>
          <div className="relative lg:col-span-2">
            <div className="absolute inset-px rounded-lg bg-white dark:bg-gray-800 max-lg:rounded-b-[2rem] lg:rounded-br-[2rem]" />
            <div className="relative flex h-full flex-col overflow-hidden rounded-[calc(var(--radius-lg)+1px)] max-lg:rounded-b-[calc(2rem+1px)] lg:rounded-br-[calc(2rem+1px)]">
              <img
                alt=""
                src="https://tailwindui.com/plus-assets/img/component-images/bento-01-network.png"
                className="h-80 object-cover"
              />
              <div className="p-10 pt-4">
                <h3 className="text-sm/4 font-semibold text-indigo-500 dark:text-indigo-400">
                  Network
                </h3>
                <p className="mt-2 text-lg font-medium tracking-tight text-gray-950 dark:text-gray-100">
                  Globally distributed CDN
                </p>
                <p className="mt-2 max-w-lg text-sm/6 text-gray-600 dark:text-gray-400">
                  Aenean vulputate justo commodo auctor vehicula in malesuada
                  semper.
                </p>
              </div>
            </div>
            <div className="pointer-events-none absolute inset-px rounded-lg ring-1 shadow-sm ring-black/5 dark:ring-white/10 max-lg:rounded-b-[2rem] lg:rounded-br-[2rem]" />
          </div>
        </div>
      </div>
    </div>
  );
}
