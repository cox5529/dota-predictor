import React from 'react';

import cx from 'classnames';

import { HeroResponse } from '../api';

type HeroImageProps = React.PropsWithChildren & {
  className?: string;
  hero: HeroResponse;
};

const HeroImage: React.FC<HeroImageProps> = (props: HeroImageProps) => {
  return (
    <div
      className={cx(props.className, 'relative aspect-[16/9] bg-cover')}
      style={{ backgroundImage: `url(${props.hero.img})` }}
    >
      {props.children}
      <p className='absolute bottom-0 text-xs left-1/2 -translate-x-1/2 text-center bg-stone-700 opacity-80 px-2'>
        {props.hero.localizedName}
      </p>
    </div>
  );
};

export default HeroImage;
